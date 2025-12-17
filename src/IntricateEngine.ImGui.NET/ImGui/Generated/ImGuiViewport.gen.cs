using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;


namespace IntricateEngine.ImGui
{
    public unsafe partial struct ImGuiViewport
    {
        public uint ID;
        public ImGuiViewportFlags Flags;
        public ImVec2 Pos;
        public ImVec2 Size;
        public ImVec2 FramebufferScale;
        public ImVec2 WorkPos;
        public ImVec2 WorkSize;
        public float DpiScale;
        public uint ParentViewportId;
        public ImGuiViewport* ParentViewport;
        public ImDrawData* DrawData;
        public void* RendererUserData;
        public void* PlatformUserData;
        public void* PlatformHandle;
        public void* PlatformHandleRaw;
        public byte PlatformWindowCreated;
        public byte PlatformRequestMove;
        public byte PlatformRequestResize;
        public byte PlatformRequestClose;
    }
    
    public readonly unsafe partial struct ImGuiViewportPtr
    {
        public ImGuiViewport* NativePtr { get; }
        public ImGuiViewportPtr(ImGuiViewport* nativePtr) => NativePtr = nativePtr;
        public ImGuiViewportPtr(IntPtr nativePtr) => NativePtr = (ImGuiViewport*)nativePtr;
        public static implicit operator ImGuiViewportPtr(ImGuiViewport* nativePtr) => new ImGuiViewportPtr(nativePtr);
        public static implicit operator ImGuiViewport* (ImGuiViewportPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiViewportPtr(IntPtr nativePtr) => new ImGuiViewportPtr(nativePtr);
        public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);
        public ref ImGuiViewportFlags Flags => ref Unsafe.AsRef<ImGuiViewportFlags>(&NativePtr->Flags);
        public ref ImVec2 Pos => ref Unsafe.AsRef<ImVec2>(&NativePtr->Pos);
        public ref ImVec2 Size => ref Unsafe.AsRef<ImVec2>(&NativePtr->Size);
        public ref ImVec2 FramebufferScale => ref Unsafe.AsRef<ImVec2>(&NativePtr->FramebufferScale);
        public ref ImVec2 WorkPos => ref Unsafe.AsRef<ImVec2>(&NativePtr->WorkPos);
        public ref ImVec2 WorkSize => ref Unsafe.AsRef<ImVec2>(&NativePtr->WorkSize);
        public ref float DpiScale => ref Unsafe.AsRef<float>(&NativePtr->DpiScale);
        public ref uint ParentViewportId => ref Unsafe.AsRef<uint>(&NativePtr->ParentViewportId);
        public ImGuiViewportPtr ParentViewport => new ImGuiViewportPtr(NativePtr->ParentViewport);
        public ImDrawDataPtr DrawData => new ImDrawDataPtr(NativePtr->DrawData);
        public IntPtr RendererUserData { get => (IntPtr)NativePtr->RendererUserData; set => NativePtr->RendererUserData = (void*)value; }
        public IntPtr PlatformUserData { get => (IntPtr)NativePtr->PlatformUserData; set => NativePtr->PlatformUserData = (void*)value; }
        public IntPtr PlatformHandle { get => (IntPtr)NativePtr->PlatformHandle; set => NativePtr->PlatformHandle = (void*)value; }
        public IntPtr PlatformHandleRaw { get => (IntPtr)NativePtr->PlatformHandleRaw; set => NativePtr->PlatformHandleRaw = (void*)value; }
        public ref bool PlatformWindowCreated => ref Unsafe.AsRef<bool>(&NativePtr->PlatformWindowCreated);
        public ref bool PlatformRequestMove => ref Unsafe.AsRef<bool>(&NativePtr->PlatformRequestMove);
        public ref bool PlatformRequestResize => ref Unsafe.AsRef<bool>(&NativePtr->PlatformRequestResize);
        public ref bool PlatformRequestClose => ref Unsafe.AsRef<bool>(&NativePtr->PlatformRequestClose);
        public void Destroy()
        {
            ImGuiNative.ImGuiViewport_destroy((ImGuiViewport*)(NativePtr));
        }
        public ImVec2 GetCenter()
        {
            ImVec2 ret = ImGuiNative.ImGuiViewport_GetCenter((ImGuiViewport*)(NativePtr));
            return ret;
        }
        public ImVec2 GetWorkCenter()
        {
            ImVec2 ret = ImGuiNative.ImGuiViewport_GetWorkCenter((ImGuiViewport*)(NativePtr));
            return ret;
        }
    }
}
