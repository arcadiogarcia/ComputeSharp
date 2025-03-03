﻿using ComputeSharp.Core.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ComputeSharp.Tests.Internals;

[TestClass]
[TestCategory("AlignmentHelper")]
public class AlignmentHelperTests
{
    [TestMethod]
    [DataRow(1, 16, 16)]
    [DataRow(2, 16, 16)]
    [DataRow(4, 16, 16)]
    [DataRow(8, 16, 16)]
    [DataRow(16, 16, 16)]
    [DataRow(20, 16, 32)]
    [DataRow(40, 16, 48)]
    public void Pad(int size, int alignment, int expected)
    {
        int result = AlignmentHelper.Pad(size, alignment);

        Assert.AreEqual(result, expected);
    }

    [TestMethod]
    [DataRow(0, 4, 16, 0)]
    [DataRow(0, 8, 16, 0)]
    [DataRow(0, 12, 16, 0)]
    [DataRow(0, 16, 16, 0)]
    [DataRow(0, 20, 16, 0)]
    [DataRow(20, 4, 16, 20)]
    [DataRow(20, 16, 16, 32)]
    [DataRow(24, 8, 16, 24)]
    public void AlignToBoundary(int offset, int size, int alignment, int expected)
    {
        int result = AlignmentHelper.AlignToBoundary(offset, size, alignment);

        Assert.AreEqual(result, expected);
    }
}
