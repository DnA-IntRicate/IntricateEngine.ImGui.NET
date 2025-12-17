using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;


namespace IntricateEngine.ImGui
{
    public unsafe partial struct ImGuiPlatformMonitor
    {
        public ImVec2 MainPos;
        public ImVec2 MainSize;
        public ImVec2 WorkPos;
        public ImVec2 WorkSize;
        public float DpiScale;
        public void* PlatformHandle;
    }
    
    public readonly unsafe partial struct ImGuiPlatformMonitorPtr
    {
        public ImGuiPlatformMonitor* NativePtr { get; }
        public ImGuiPlatformMonitorPtr(ImGuiPlatformMonitor* nativePtr) => NativePtr = nativePtr;
        public ImGuiPlatformMonitorPtr(IntPtr nativePtr) => NativePtr = (ImGuiPlatformMonitor*)nativePtr;
        public static implicit operator ImGuiPlatformMonitorPtr(ImGuiPlatformMonitor* nativePtr) => new ImGuiPlatformMonitorPtr(nativePtr);
        public static implicit operator ImGuiPlatformMonitor* (ImGuiPlatformMonitorPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiPlatformMonitorPtr(IntPtr nativePtr) => new ImGuiPlatformMonitorPtr(nativePtr);
        public ref ImVec2 MainPos => ref Unsafe.AsRef<ImVec2>(&NativePtr->MainPos);
        public ref ImVec2 MainSize => ref Unsafe.AsRef<ImVec2>(&NativePtr->MainSize);
        public ref ImVec2 WorkPos => ref Unsafe.AsRef<ImVec2>(&NativePtr->WorkPos);
        public ref ImVec2 WorkSize => ref Unsafe.AsRef<ImVec2>(&NativePtr->WorkSize);
        public ref float DpiScale => ref Unsafe.AsRef<float>(&NativePtr->DpiScale);
        public IntPtr PlatformHandle { get => (IntPtr)NativePtr->PlatformHandle; set => NativePtr->PlatformHandle = (void*)value; }
        public void Destroy()
        {
            ImGuiNative.ImGuiPlatformMonitor_destroy((ImGuiPlatformMonitor*)(NativePtr));
        }
    }
}
