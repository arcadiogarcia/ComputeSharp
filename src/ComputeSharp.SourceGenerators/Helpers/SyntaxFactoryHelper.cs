﻿using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace ComputeSharp.SourceGenerators.Helpers;

/// <summary>
/// A class containing additional factory methods for constructing syntax nodes, tokens and trivia.
/// </summary>
internal static class SyntaxFactoryHelper
{
    /// <summary>
    /// Creates an <see cref="object"/>[] array expression with the nested groups in the input sequence.
    /// <para>
    /// That it, it applies the following transformation:
    /// <code>
    /// { ("K1", "V1"), ("K2", "V2") } => new object[] { new string[] { "K1", "V1" }, new string[] { "K2", "V2" } }
    /// </code>
    /// </para>
    /// </summary>
    /// <param name="values">The input sequence of <see cref="string"/> groups.</param>
    /// <returns>An <see cref="ArrayCreationExpressionSyntax"/> instance with the described contents.</returns>
    [Pure]
    public static ArrayCreationExpressionSyntax NestedArrayExpression(IEnumerable<(string A, string B)> groups)
    {
        return
            ArrayCreationExpression(
            ArrayType(PredefinedType(Token(SyntaxKind.ObjectKeyword)))
            .AddRankSpecifiers(ArrayRankSpecifier(SingletonSeparatedList<ExpressionSyntax>(OmittedArraySizeExpression()))))
            .WithInitializer(InitializerExpression(SyntaxKind.ArrayInitializerExpression)
            .AddExpressions(groups.Select(static group =>
                ArrayCreationExpression(
                ArrayType(PredefinedType(Token(SyntaxKind.StringKeyword)))
                .AddRankSpecifiers(ArrayRankSpecifier(SingletonSeparatedList<ExpressionSyntax>(OmittedArraySizeExpression()))))
                .WithInitializer(InitializerExpression(SyntaxKind.ArrayInitializerExpression)
                .AddExpressions(
                    LiteralExpression(SyntaxKind.StringLiteralExpression, Literal(group.A)),
                    LiteralExpression(SyntaxKind.StringLiteralExpression, Literal(group.B))))).ToArray()));
    }
}
