using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;


namespace IntricateEngine.ImGui
{
    public unsafe partial struct ImGuiSizeCallbackData
    {
        public void* UserData;
        public ImVec2 Pos;
        public ImVec2 CurrentSize;
        public ImVec2 DesiredSize;
    }
    
    public readonly unsafe partial struct ImGuiSizeCallbackDataPtr
    {
        public ImGuiSizeCallbackData* NativePtr { get; }
        public ImGuiSizeCallbackDataPtr(ImGuiSizeCallbackData* nativePtr) => NativePtr = nativePtr;
        public ImGuiSizeCallbackDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiSizeCallbackData*)nativePtr;
        public static implicit operator ImGuiSizeCallbackDataPtr(ImGuiSizeCallbackData* nativePtr) => new ImGuiSizeCallbackDataPtr(nativePtr);
        public static implicit operator ImGuiSizeCallbackData* (ImGuiSizeCallbackDataPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiSizeCallbackDataPtr(IntPtr nativePtr) => new ImGuiSizeCallbackDataPtr(nativePtr);
        public IntPtr UserData { get => (IntPtr)NativePtr->UserData; set => NativePtr->UserData = (void*)value; }
        public ref ImVec2 Pos => ref Unsafe.AsRef<ImVec2>(&NativePtr->Pos);
        public ref ImVec2 CurrentSize => ref Unsafe.AsRef<ImVec2>(&NativePtr->CurrentSize);
        public ref ImVec2 DesiredSize => ref Unsafe.AsRef<ImVec2>(&NativePtr->DesiredSize);
    }
}
