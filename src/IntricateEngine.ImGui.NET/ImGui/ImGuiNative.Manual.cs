using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;


namespace IntricateEngine.ImGui
{
    public static unsafe partial class ImGuiNative
    {
        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiPlatformIO_Set_Platform_GetWindowPos")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiPlatformIO_Set_Platform_GetWindowPos(ImGuiPlatformIO* platform_io, IntPtr funcPtr);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiPlatformIO_Set_Platform_GetWindowSize")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiPlatformIO_Set_Platform_GetWindowSize(ImGuiPlatformIO* platform_io, IntPtr funcPtr);
    }
}
