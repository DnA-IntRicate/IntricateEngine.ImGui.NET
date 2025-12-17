using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;


namespace IntricateEngine.ImGui
{
    public unsafe partial struct ImDrawCmdHeader
    {
        public ImVec4 ClipRect;
        public ImTextureRef TexRef;
        public uint VtxOffset;
    }
    
    public readonly unsafe partial struct ImDrawCmdHeaderPtr
    {
        public ImDrawCmdHeader* NativePtr { get; }
        public ImDrawCmdHeaderPtr(ImDrawCmdHeader* nativePtr) => NativePtr = nativePtr;
        public ImDrawCmdHeaderPtr(IntPtr nativePtr) => NativePtr = (ImDrawCmdHeader*)nativePtr;
        public static implicit operator ImDrawCmdHeaderPtr(ImDrawCmdHeader* nativePtr) => new ImDrawCmdHeaderPtr(nativePtr);
        public static implicit operator ImDrawCmdHeader* (ImDrawCmdHeaderPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImDrawCmdHeaderPtr(IntPtr nativePtr) => new ImDrawCmdHeaderPtr(nativePtr);
        public ref ImVec4 ClipRect => ref Unsafe.AsRef<ImVec4>(&NativePtr->ClipRect);
        public ref ImTextureRef TexRef => ref Unsafe.AsRef<ImTextureRef>(&NativePtr->TexRef);
        public ref uint VtxOffset => ref Unsafe.AsRef<uint>(&NativePtr->VtxOffset);
    }
}
