using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;


namespace IntricateEngine.ImGui
{
    public unsafe partial struct ImDrawCmd
    {
        public ImVec4 ClipRect;
        public ImTextureRef TexRef;
        public uint VtxOffset;
        public uint IdxOffset;
        public uint ElemCount;
        public nint UserCallback;
        public void* UserCallbackData;
        public int UserCallbackDataSize;
        public int UserCallbackDataOffset;
    }
    
    public readonly unsafe partial struct ImDrawCmdPtr
    {
        public ImDrawCmd* NativePtr { get; }
        public ImDrawCmdPtr(ImDrawCmd* nativePtr) => NativePtr = nativePtr;
        public ImDrawCmdPtr(IntPtr nativePtr) => NativePtr = (ImDrawCmd*)nativePtr;
        public static implicit operator ImDrawCmdPtr(ImDrawCmd* nativePtr) => new ImDrawCmdPtr(nativePtr);
        public static implicit operator ImDrawCmd* (ImDrawCmdPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImDrawCmdPtr(IntPtr nativePtr) => new ImDrawCmdPtr(nativePtr);
        public ref ImVec4 ClipRect => ref Unsafe.AsRef<ImVec4>(&NativePtr->ClipRect);
        public ref ImTextureRef TexRef => ref Unsafe.AsRef<ImTextureRef>(&NativePtr->TexRef);
        public ref uint VtxOffset => ref Unsafe.AsRef<uint>(&NativePtr->VtxOffset);
        public ref uint IdxOffset => ref Unsafe.AsRef<uint>(&NativePtr->IdxOffset);
        public ref uint ElemCount => ref Unsafe.AsRef<uint>(&NativePtr->ElemCount);
        public ref nint UserCallback => ref Unsafe.AsRef<nint>(&NativePtr->UserCallback);
        public IntPtr UserCallbackData { get => (IntPtr)NativePtr->UserCallbackData; set => NativePtr->UserCallbackData = (void*)value; }
        public ref int UserCallbackDataSize => ref Unsafe.AsRef<int>(&NativePtr->UserCallbackDataSize);
        public ref int UserCallbackDataOffset => ref Unsafe.AsRef<int>(&NativePtr->UserCallbackDataOffset);
        public void Destroy()
        {
            ImGuiNative.ImDrawCmd_destroy((ImDrawCmd*)(NativePtr));
        }
        public nint GetTexID()
        {
            nint ret = ImGuiNative.ImDrawCmd_GetTexID((ImDrawCmd*)(NativePtr));
            return ret;
        }
    }
}
