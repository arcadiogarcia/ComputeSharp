#pragma once

#include "Class.g.h"

namespace winrt::ComputeSharp_UI_Native::implementation
{
    struct Class : ClassT<Class>
    {
        Class();

        int32_t MyProperty();
        void MyProperty(int32_t value);
    };
}

namespace winrt::ComputeSharp_UI_Native::factory_implementation
{
    struct Class : ClassT<Class, implementation::Class>
    {
    };
}
