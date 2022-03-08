// Copyright (c) The Vignette Authors
// Licensed under BSD 3-Clause License. See LICENSE for details.

using System.Runtime.InteropServices;

namespace Oxide.Javascript.Interop
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct JSStaticValue
    {
        [MarshalAs(UnmanagedType.LPUTF8Str)]
        internal string Name;

        internal JSObjectGetPropertyCallbackEx GetProperty;
        internal JSObjectSetPropertyCallback SetProperty;
        internal JSPropertyAttribute Attributes;
    }
}
