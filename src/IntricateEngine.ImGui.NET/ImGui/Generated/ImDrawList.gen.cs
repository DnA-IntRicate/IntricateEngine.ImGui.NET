using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;


namespace IntricateEngine.ImGui
{
    public unsafe partial struct ImDrawList
    {
        public ImVector CmdBuffer;
        public ImVector IdxBuffer;
        public ImVector VtxBuffer;
        public ImDrawListFlags Flags;
        public uint _VtxCurrentIdx;
        public nint _Data;
        public ImDrawVert* _VtxWritePtr;
        public ushort* _IdxWritePtr;
        public ImVector _Path;
        public ImDrawCmdHeader _CmdHeader;
        public ImDrawListSplitter _Splitter;
        public ImVector _ClipRectStack;
        public ImVector _TextureStack;
        public ImVector _CallbacksDataBuf;
        public float _FringeScale;
        public byte* _OwnerName;
    }
    
    public readonly unsafe partial struct ImDrawListPtr
    {
        public ImDrawList* NativePtr { get; }
        public ImDrawListPtr(ImDrawList* nativePtr) => NativePtr = nativePtr;
        public ImDrawListPtr(IntPtr nativePtr) => NativePtr = (ImDrawList*)nativePtr;
        public static implicit operator ImDrawListPtr(ImDrawList* nativePtr) => new ImDrawListPtr(nativePtr);
        public static implicit operator ImDrawList* (ImDrawListPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImDrawListPtr(IntPtr nativePtr) => new ImDrawListPtr(nativePtr);
        public ImPtrVector<ImDrawCmdPtr> CmdBuffer => new ImPtrVector<ImDrawCmdPtr>(NativePtr->CmdBuffer, Unsafe.SizeOf<ImDrawCmd>());
        public ImVector<ushort> IdxBuffer => new ImVector<ushort>(NativePtr->IdxBuffer);
        public ImPtrVector<ImDrawVertPtr> VtxBuffer => new ImPtrVector<ImDrawVertPtr>(NativePtr->VtxBuffer, Unsafe.SizeOf<ImDrawVert>());
        public ref ImDrawListFlags Flags => ref Unsafe.AsRef<ImDrawListFlags>(&NativePtr->Flags);
        public ref uint _VtxCurrentIdx => ref Unsafe.AsRef<uint>(&NativePtr->_VtxCurrentIdx);
        public ref nint _Data => ref Unsafe.AsRef<nint>(&NativePtr->_Data);
        public ImDrawVertPtr _VtxWritePtr => new ImDrawVertPtr(NativePtr->_VtxWritePtr);
        public IntPtr _IdxWritePtr { get => (IntPtr)NativePtr->_IdxWritePtr; set => NativePtr->_IdxWritePtr = (ushort*)value; }
        public ImVector<ImVec2> _Path => new ImVector<ImVec2>(NativePtr->_Path);
        public ref ImDrawCmdHeader _CmdHeader => ref Unsafe.AsRef<ImDrawCmdHeader>(&NativePtr->_CmdHeader);
        public ref ImDrawListSplitter _Splitter => ref Unsafe.AsRef<ImDrawListSplitter>(&NativePtr->_Splitter);
        public ImVector<ImVec4> _ClipRectStack => new ImVector<ImVec4>(NativePtr->_ClipRectStack);
        public ImPtrVector<ImTextureRefPtr> _TextureStack => new ImPtrVector<ImTextureRefPtr>(NativePtr->_TextureStack, Unsafe.SizeOf<ImTextureRef>());
        public ImVector<byte> _CallbacksDataBuf => new ImVector<byte>(NativePtr->_CallbacksDataBuf);
        public ref float _FringeScale => ref Unsafe.AsRef<float>(&NativePtr->_FringeScale);
        public NullTerminatedString _OwnerName => new NullTerminatedString(NativePtr->_OwnerName);
        public int _CalcCircleAutoSegmentCount(float radius)
        {
            int ret = ImGuiNative.ImDrawList__CalcCircleAutoSegmentCount((ImDrawList*)(NativePtr), radius);
            return ret;
        }
        public void _ClearFreeMemory()
        {
            ImGuiNative.ImDrawList__ClearFreeMemory((ImDrawList*)(NativePtr));
        }
        public void _OnChangedClipRect()
        {
            ImGuiNative.ImDrawList__OnChangedClipRect((ImDrawList*)(NativePtr));
        }
        public void _OnChangedTexture()
        {
            ImGuiNative.ImDrawList__OnChangedTexture((ImDrawList*)(NativePtr));
        }
        public void _OnChangedVtxOffset()
        {
            ImGuiNative.ImDrawList__OnChangedVtxOffset((ImDrawList*)(NativePtr));
        }
        public void _PathArcToFastEx(ImVec2 center, float radius, int a_min_sample, int a_max_sample, int a_step)
        {
            ImGuiNative.ImDrawList__PathArcToFastEx((ImDrawList*)(NativePtr), center, radius, a_min_sample, a_max_sample, a_step);
        }
        public void _PathArcToN(ImVec2 center, float radius, float a_min, float a_max, int num_segments)
        {
            ImGuiNative.ImDrawList__PathArcToN((ImDrawList*)(NativePtr), center, radius, a_min, a_max, num_segments);
        }
        public void _PopUnusedDrawCmd()
        {
            ImGuiNative.ImDrawList__PopUnusedDrawCmd((ImDrawList*)(NativePtr));
        }
        public void _ResetForNewFrame()
        {
            ImGuiNative.ImDrawList__ResetForNewFrame((ImDrawList*)(NativePtr));
        }
        // public void _SetDrawListSharedData(ref nint data)
        // {
        //     fixed (nint native_data = &data)
        //     {
        //         ImGuiNative.ImDrawList__SetDrawListSharedData((ImDrawList*)(NativePtr), native_data);
        //     }
        // }
        public void _SetTexture(ImTextureRef tex_ref)
        {
            ImGuiNative.ImDrawList__SetTexture((ImDrawList*)(NativePtr), tex_ref);
        }
        public void _TryMergeDrawCmds()
        {
            ImGuiNative.ImDrawList__TryMergeDrawCmds((ImDrawList*)(NativePtr));
        }
        public void AddBezierCubic(ImVec2 p1, ImVec2 p2, ImVec2 p3, ImVec2 p4, uint col, float thickness)
        {
            int num_segments = 0;
            ImGuiNative.ImDrawList_AddBezierCubic((ImDrawList*)(NativePtr), p1, p2, p3, p4, col, thickness, num_segments);
        }
        public void AddBezierCubic(ImVec2 p1, ImVec2 p2, ImVec2 p3, ImVec2 p4, uint col, float thickness, int num_segments)
        {
            ImGuiNative.ImDrawList_AddBezierCubic((ImDrawList*)(NativePtr), p1, p2, p3, p4, col, thickness, num_segments);
        }
        public void AddBezierQuadratic(ImVec2 p1, ImVec2 p2, ImVec2 p3, uint col, float thickness)
        {
            int num_segments = 0;
            ImGuiNative.ImDrawList_AddBezierQuadratic((ImDrawList*)(NativePtr), p1, p2, p3, col, thickness, num_segments);
        }
        public void AddBezierQuadratic(ImVec2 p1, ImVec2 p2, ImVec2 p3, uint col, float thickness, int num_segments)
        {
            ImGuiNative.ImDrawList_AddBezierQuadratic((ImDrawList*)(NativePtr), p1, p2, p3, col, thickness, num_segments);
        }
        public void AddCallback(nint callback, IntPtr userdata)
        {
            void* native_userdata = (void*)userdata.ToPointer();
            uint userdata_size = 0;
            ImGuiNative.ImDrawList_AddCallback((ImDrawList*)(NativePtr), callback, native_userdata, userdata_size);
        }
        public void AddCallback(nint callback, IntPtr userdata, uint userdata_size)
        {
            void* native_userdata = (void*)userdata.ToPointer();
            ImGuiNative.ImDrawList_AddCallback((ImDrawList*)(NativePtr), callback, native_userdata, userdata_size);
        }
        public void AddCircle(ImVec2 center, float radius, uint col)
        {
            int num_segments = 0;
            float thickness = 1.0f;
            ImGuiNative.ImDrawList_AddCircle((ImDrawList*)(NativePtr), center, radius, col, num_segments, thickness);
        }
        public void AddCircle(ImVec2 center, float radius, uint col, int num_segments)
        {
            float thickness = 1.0f;
            ImGuiNative.ImDrawList_AddCircle((ImDrawList*)(NativePtr), center, radius, col, num_segments, thickness);
        }
        public void AddCircle(ImVec2 center, float radius, uint col, int num_segments, float thickness)
        {
            ImGuiNative.ImDrawList_AddCircle((ImDrawList*)(NativePtr), center, radius, col, num_segments, thickness);
        }
        public void AddCircleFilled(ImVec2 center, float radius, uint col)
        {
            int num_segments = 0;
            ImGuiNative.ImDrawList_AddCircleFilled((ImDrawList*)(NativePtr), center, radius, col, num_segments);
        }
        public void AddCircleFilled(ImVec2 center, float radius, uint col, int num_segments)
        {
            ImGuiNative.ImDrawList_AddCircleFilled((ImDrawList*)(NativePtr), center, radius, col, num_segments);
        }
        public void AddConcavePolyFilled(ref ImVec2 points, int num_points, uint col)
        {
            fixed (ImVec2* native_points = &points)
            {
                ImGuiNative.ImDrawList_AddConcavePolyFilled((ImDrawList*)(NativePtr), native_points, num_points, col);
            }
        }
        public void AddConvexPolyFilled(ref ImVec2 points, int num_points, uint col)
        {
            fixed (ImVec2* native_points = &points)
            {
                ImGuiNative.ImDrawList_AddConvexPolyFilled((ImDrawList*)(NativePtr), native_points, num_points, col);
            }
        }
        public void AddDrawCmd()
        {
            ImGuiNative.ImDrawList_AddDrawCmd((ImDrawList*)(NativePtr));
        }
        public void AddEllipse(ImVec2 center, ImVec2 radius, uint col)
        {
            float rot = 0.0f;
            int num_segments = 0;
            float thickness = 1.0f;
            ImGuiNative.ImDrawList_AddEllipse((ImDrawList*)(NativePtr), center, radius, col, rot, num_segments, thickness);
        }
        public void AddEllipse(ImVec2 center, ImVec2 radius, uint col, float rot)
        {
            int num_segments = 0;
            float thickness = 1.0f;
            ImGuiNative.ImDrawList_AddEllipse((ImDrawList*)(NativePtr), center, radius, col, rot, num_segments, thickness);
        }
        public void AddEllipse(ImVec2 center, ImVec2 radius, uint col, float rot, int num_segments)
        {
            float thickness = 1.0f;
            ImGuiNative.ImDrawList_AddEllipse((ImDrawList*)(NativePtr), center, radius, col, rot, num_segments, thickness);
        }
        public void AddEllipse(ImVec2 center, ImVec2 radius, uint col, float rot, int num_segments, float thickness)
        {
            ImGuiNative.ImDrawList_AddEllipse((ImDrawList*)(NativePtr), center, radius, col, rot, num_segments, thickness);
        }
        public void AddEllipseFilled(ImVec2 center, ImVec2 radius, uint col)
        {
            float rot = 0.0f;
            int num_segments = 0;
            ImGuiNative.ImDrawList_AddEllipseFilled((ImDrawList*)(NativePtr), center, radius, col, rot, num_segments);
        }
        public void AddEllipseFilled(ImVec2 center, ImVec2 radius, uint col, float rot)
        {
            int num_segments = 0;
            ImGuiNative.ImDrawList_AddEllipseFilled((ImDrawList*)(NativePtr), center, radius, col, rot, num_segments);
        }
        public void AddEllipseFilled(ImVec2 center, ImVec2 radius, uint col, float rot, int num_segments)
        {
            ImGuiNative.ImDrawList_AddEllipseFilled((ImDrawList*)(NativePtr), center, radius, col, rot, num_segments);
        }
        public void AddImage(ImTextureRef tex_ref, ImVec2 p_min, ImVec2 p_max)
        {
            ImVec2 uv_min = new ImVec2();
            ImVec2 uv_max = new ImVec2(1, 1);
            uint col = 4294967295;
            ImGuiNative.ImDrawList_AddImage((ImDrawList*)(NativePtr), tex_ref, p_min, p_max, uv_min, uv_max, col);
        }
        public void AddImage(ImTextureRef tex_ref, ImVec2 p_min, ImVec2 p_max, ImVec2 uv_min)
        {
            ImVec2 uv_max = new ImVec2(1, 1);
            uint col = 4294967295;
            ImGuiNative.ImDrawList_AddImage((ImDrawList*)(NativePtr), tex_ref, p_min, p_max, uv_min, uv_max, col);
        }
        public void AddImage(ImTextureRef tex_ref, ImVec2 p_min, ImVec2 p_max, ImVec2 uv_min, ImVec2 uv_max)
        {
            uint col = 4294967295;
            ImGuiNative.ImDrawList_AddImage((ImDrawList*)(NativePtr), tex_ref, p_min, p_max, uv_min, uv_max, col);
        }
        public void AddImage(ImTextureRef tex_ref, ImVec2 p_min, ImVec2 p_max, ImVec2 uv_min, ImVec2 uv_max, uint col)
        {
            ImGuiNative.ImDrawList_AddImage((ImDrawList*)(NativePtr), tex_ref, p_min, p_max, uv_min, uv_max, col);
        }
        public void AddImageQuad(ImTextureRef tex_ref, ImVec2 p1, ImVec2 p2, ImVec2 p3, ImVec2 p4)
        {
            ImVec2 uv1 = new ImVec2();
            ImVec2 uv2 = new ImVec2(1, 0);
            ImVec2 uv3 = new ImVec2(1, 1);
            ImVec2 uv4 = new ImVec2(0, 1);
            uint col = 4294967295;
            ImGuiNative.ImDrawList_AddImageQuad((ImDrawList*)(NativePtr), tex_ref, p1, p2, p3, p4, uv1, uv2, uv3, uv4, col);
        }
        public void AddImageQuad(ImTextureRef tex_ref, ImVec2 p1, ImVec2 p2, ImVec2 p3, ImVec2 p4, ImVec2 uv1)
        {
            ImVec2 uv2 = new ImVec2(1, 0);
            ImVec2 uv3 = new ImVec2(1, 1);
            ImVec2 uv4 = new ImVec2(0, 1);
            uint col = 4294967295;
            ImGuiNative.ImDrawList_AddImageQuad((ImDrawList*)(NativePtr), tex_ref, p1, p2, p3, p4, uv1, uv2, uv3, uv4, col);
        }
        public void AddImageQuad(ImTextureRef tex_ref, ImVec2 p1, ImVec2 p2, ImVec2 p3, ImVec2 p4, ImVec2 uv1, ImVec2 uv2)
        {
            ImVec2 uv3 = new ImVec2(1, 1);
            ImVec2 uv4 = new ImVec2(0, 1);
            uint col = 4294967295;
            ImGuiNative.ImDrawList_AddImageQuad((ImDrawList*)(NativePtr), tex_ref, p1, p2, p3, p4, uv1, uv2, uv3, uv4, col);
        }
        public void AddImageQuad(ImTextureRef tex_ref, ImVec2 p1, ImVec2 p2, ImVec2 p3, ImVec2 p4, ImVec2 uv1, ImVec2 uv2, ImVec2 uv3)
        {
            ImVec2 uv4 = new ImVec2(0, 1);
            uint col = 4294967295;
            ImGuiNative.ImDrawList_AddImageQuad((ImDrawList*)(NativePtr), tex_ref, p1, p2, p3, p4, uv1, uv2, uv3, uv4, col);
        }
        public void AddImageQuad(ImTextureRef tex_ref, ImVec2 p1, ImVec2 p2, ImVec2 p3, ImVec2 p4, ImVec2 uv1, ImVec2 uv2, ImVec2 uv3, ImVec2 uv4)
        {
            uint col = 4294967295;
            ImGuiNative.ImDrawList_AddImageQuad((ImDrawList*)(NativePtr), tex_ref, p1, p2, p3, p4, uv1, uv2, uv3, uv4, col);
        }
        public void AddImageQuad(ImTextureRef tex_ref, ImVec2 p1, ImVec2 p2, ImVec2 p3, ImVec2 p4, ImVec2 uv1, ImVec2 uv2, ImVec2 uv3, ImVec2 uv4, uint col)
        {
            ImGuiNative.ImDrawList_AddImageQuad((ImDrawList*)(NativePtr), tex_ref, p1, p2, p3, p4, uv1, uv2, uv3, uv4, col);
        }
        public void AddImageRounded(ImTextureRef tex_ref, ImVec2 p_min, ImVec2 p_max, ImVec2 uv_min, ImVec2 uv_max, uint col, float rounding)
        {
            ImDrawFlags flags = (ImDrawFlags)0;
            ImGuiNative.ImDrawList_AddImageRounded((ImDrawList*)(NativePtr), tex_ref, p_min, p_max, uv_min, uv_max, col, rounding, flags);
        }
        public void AddImageRounded(ImTextureRef tex_ref, ImVec2 p_min, ImVec2 p_max, ImVec2 uv_min, ImVec2 uv_max, uint col, float rounding, ImDrawFlags flags)
        {
            ImGuiNative.ImDrawList_AddImageRounded((ImDrawList*)(NativePtr), tex_ref, p_min, p_max, uv_min, uv_max, col, rounding, flags);
        }
        public void AddLine(ImVec2 p1, ImVec2 p2, uint col)
        {
            float thickness = 1.0f;
            ImGuiNative.ImDrawList_AddLine((ImDrawList*)(NativePtr), p1, p2, col, thickness);
        }
        public void AddLine(ImVec2 p1, ImVec2 p2, uint col, float thickness)
        {
            ImGuiNative.ImDrawList_AddLine((ImDrawList*)(NativePtr), p1, p2, col, thickness);
        }
        public void AddNgon(ImVec2 center, float radius, uint col, int num_segments)
        {
            float thickness = 1.0f;
            ImGuiNative.ImDrawList_AddNgon((ImDrawList*)(NativePtr), center, radius, col, num_segments, thickness);
        }
        public void AddNgon(ImVec2 center, float radius, uint col, int num_segments, float thickness)
        {
            ImGuiNative.ImDrawList_AddNgon((ImDrawList*)(NativePtr), center, radius, col, num_segments, thickness);
        }
        public void AddNgonFilled(ImVec2 center, float radius, uint col, int num_segments)
        {
            ImGuiNative.ImDrawList_AddNgonFilled((ImDrawList*)(NativePtr), center, radius, col, num_segments);
        }
        public void AddPolyline(ref ImVec2 points, int num_points, uint col, ImDrawFlags flags, float thickness)
        {
            fixed (ImVec2* native_points = &points)
            {
                ImGuiNative.ImDrawList_AddPolyline((ImDrawList*)(NativePtr), native_points, num_points, col, flags, thickness);
            }
        }
        public void AddQuad(ImVec2 p1, ImVec2 p2, ImVec2 p3, ImVec2 p4, uint col)
        {
            float thickness = 1.0f;
            ImGuiNative.ImDrawList_AddQuad((ImDrawList*)(NativePtr), p1, p2, p3, p4, col, thickness);
        }
        public void AddQuad(ImVec2 p1, ImVec2 p2, ImVec2 p3, ImVec2 p4, uint col, float thickness)
        {
            ImGuiNative.ImDrawList_AddQuad((ImDrawList*)(NativePtr), p1, p2, p3, p4, col, thickness);
        }
        public void AddQuadFilled(ImVec2 p1, ImVec2 p2, ImVec2 p3, ImVec2 p4, uint col)
        {
            ImGuiNative.ImDrawList_AddQuadFilled((ImDrawList*)(NativePtr), p1, p2, p3, p4, col);
        }
        public void AddRect(ImVec2 p_min, ImVec2 p_max, uint col)
        {
            float rounding = 0.0f;
            ImDrawFlags flags = (ImDrawFlags)0;
            float thickness = 1.0f;
            ImGuiNative.ImDrawList_AddRect((ImDrawList*)(NativePtr), p_min, p_max, col, rounding, flags, thickness);
        }
        public void AddRect(ImVec2 p_min, ImVec2 p_max, uint col, float rounding)
        {
            ImDrawFlags flags = (ImDrawFlags)0;
            float thickness = 1.0f;
            ImGuiNative.ImDrawList_AddRect((ImDrawList*)(NativePtr), p_min, p_max, col, rounding, flags, thickness);
        }
        public void AddRect(ImVec2 p_min, ImVec2 p_max, uint col, float rounding, ImDrawFlags flags)
        {
            float thickness = 1.0f;
            ImGuiNative.ImDrawList_AddRect((ImDrawList*)(NativePtr), p_min, p_max, col, rounding, flags, thickness);
        }
        public void AddRect(ImVec2 p_min, ImVec2 p_max, uint col, float rounding, ImDrawFlags flags, float thickness)
        {
            ImGuiNative.ImDrawList_AddRect((ImDrawList*)(NativePtr), p_min, p_max, col, rounding, flags, thickness);
        }
        public void AddRectFilled(ImVec2 p_min, ImVec2 p_max, uint col)
        {
            float rounding = 0.0f;
            ImDrawFlags flags = (ImDrawFlags)0;
            ImGuiNative.ImDrawList_AddRectFilled((ImDrawList*)(NativePtr), p_min, p_max, col, rounding, flags);
        }
        public void AddRectFilled(ImVec2 p_min, ImVec2 p_max, uint col, float rounding)
        {
            ImDrawFlags flags = (ImDrawFlags)0;
            ImGuiNative.ImDrawList_AddRectFilled((ImDrawList*)(NativePtr), p_min, p_max, col, rounding, flags);
        }
        public void AddRectFilled(ImVec2 p_min, ImVec2 p_max, uint col, float rounding, ImDrawFlags flags)
        {
            ImGuiNative.ImDrawList_AddRectFilled((ImDrawList*)(NativePtr), p_min, p_max, col, rounding, flags);
        }
        public void AddRectFilledMultiColor(ImVec2 p_min, ImVec2 p_max, uint col_upr_left, uint col_upr_right, uint col_bot_right, uint col_bot_left)
        {
            ImGuiNative.ImDrawList_AddRectFilledMultiColor((ImDrawList*)(NativePtr), p_min, p_max, col_upr_left, col_upr_right, col_bot_right, col_bot_left);
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public void AddText(ImVec2 pos, uint col, ReadOnlySpan<char> text_begin)
        {
            byte* native_text_begin;
            int text_begin_byteCount = 0;
                text_begin_byteCount = Encoding.UTF8.GetByteCount(text_begin);
                if (text_begin_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_text_begin = Util.Allocate(text_begin_byteCount + 1);
                }
                else
                {
                    byte* native_text_begin_stackBytes = stackalloc byte[text_begin_byteCount + 1];
                    native_text_begin = native_text_begin_stackBytes;
                }
                int native_text_begin_offset = Util.GetUtf8(text_begin, native_text_begin, text_begin_byteCount);
                native_text_begin[native_text_begin_offset] = 0;
            ImGuiNative.ImDrawList_AddText_Vec2((ImDrawList*)(NativePtr), pos, col, native_text_begin, native_text_begin+text_begin_byteCount);
            if (text_begin_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_text_begin);
            }
        }
#endif
        public void AddText(ImVec2 pos, uint col, string text_begin)
        {
            byte* native_text_begin;
            int text_begin_byteCount = 0;
                text_begin_byteCount = Encoding.UTF8.GetByteCount(text_begin);
                if (text_begin_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_text_begin = Util.Allocate(text_begin_byteCount + 1);
                }
                else
                {
                    byte* native_text_begin_stackBytes = stackalloc byte[text_begin_byteCount + 1];
                    native_text_begin = native_text_begin_stackBytes;
                }
                int native_text_begin_offset = Util.GetUtf8(text_begin, native_text_begin, text_begin_byteCount);
                native_text_begin[native_text_begin_offset] = 0;
            ImGuiNative.ImDrawList_AddText_Vec2((ImDrawList*)(NativePtr), pos, col, native_text_begin, native_text_begin+text_begin_byteCount);
            if (text_begin_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_text_begin);
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public void AddText(ImFontPtr font, float font_size, ImVec2 pos, uint col, ReadOnlySpan<char> text_begin)
        {
            ImFont* native_font = font.NativePtr;
            byte* native_text_begin;
            int text_begin_byteCount = 0;
                text_begin_byteCount = Encoding.UTF8.GetByteCount(text_begin);
                if (text_begin_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_text_begin = Util.Allocate(text_begin_byteCount + 1);
                }
                else
                {
                    byte* native_text_begin_stackBytes = stackalloc byte[text_begin_byteCount + 1];
                    native_text_begin = native_text_begin_stackBytes;
                }
                int native_text_begin_offset = Util.GetUtf8(text_begin, native_text_begin, text_begin_byteCount);
                native_text_begin[native_text_begin_offset] = 0;
            float wrap_width = 0.0f;
            ImVec4* cpu_fine_clip_rect = null;
            ImGuiNative.ImDrawList_AddText_FontPtr((ImDrawList*)(NativePtr), native_font, font_size, pos, col, native_text_begin, native_text_begin+text_begin_byteCount, wrap_width, cpu_fine_clip_rect);
            if (text_begin_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_text_begin);
            }
        }
#endif
        public void AddText(ImFontPtr font, float font_size, ImVec2 pos, uint col, string text_begin)
        {
            ImFont* native_font = font.NativePtr;
            byte* native_text_begin;
            int text_begin_byteCount = 0;
                text_begin_byteCount = Encoding.UTF8.GetByteCount(text_begin);
                if (text_begin_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_text_begin = Util.Allocate(text_begin_byteCount + 1);
                }
                else
                {
                    byte* native_text_begin_stackBytes = stackalloc byte[text_begin_byteCount + 1];
                    native_text_begin = native_text_begin_stackBytes;
                }
                int native_text_begin_offset = Util.GetUtf8(text_begin, native_text_begin, text_begin_byteCount);
                native_text_begin[native_text_begin_offset] = 0;
            float wrap_width = 0.0f;
            ImVec4* cpu_fine_clip_rect = null;
            ImGuiNative.ImDrawList_AddText_FontPtr((ImDrawList*)(NativePtr), native_font, font_size, pos, col, native_text_begin, native_text_begin+text_begin_byteCount, wrap_width, cpu_fine_clip_rect);
            if (text_begin_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_text_begin);
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public void AddText(ImFontPtr font, float font_size, ImVec2 pos, uint col, ReadOnlySpan<char> text_begin, float wrap_width)
        {
            ImFont* native_font = font.NativePtr;
            byte* native_text_begin;
            int text_begin_byteCount = 0;
                text_begin_byteCount = Encoding.UTF8.GetByteCount(text_begin);
                if (text_begin_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_text_begin = Util.Allocate(text_begin_byteCount + 1);
                }
                else
                {
                    byte* native_text_begin_stackBytes = stackalloc byte[text_begin_byteCount + 1];
                    native_text_begin = native_text_begin_stackBytes;
                }
                int native_text_begin_offset = Util.GetUtf8(text_begin, native_text_begin, text_begin_byteCount);
                native_text_begin[native_text_begin_offset] = 0;
            ImVec4* cpu_fine_clip_rect = null;
            ImGuiNative.ImDrawList_AddText_FontPtr((ImDrawList*)(NativePtr), native_font, font_size, pos, col, native_text_begin, native_text_begin+text_begin_byteCount, wrap_width, cpu_fine_clip_rect);
            if (text_begin_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_text_begin);
            }
        }
#endif
        public void AddText(ImFontPtr font, float font_size, ImVec2 pos, uint col, string text_begin, float wrap_width)
        {
            ImFont* native_font = font.NativePtr;
            byte* native_text_begin;
            int text_begin_byteCount = 0;
                text_begin_byteCount = Encoding.UTF8.GetByteCount(text_begin);
                if (text_begin_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_text_begin = Util.Allocate(text_begin_byteCount + 1);
                }
                else
                {
                    byte* native_text_begin_stackBytes = stackalloc byte[text_begin_byteCount + 1];
                    native_text_begin = native_text_begin_stackBytes;
                }
                int native_text_begin_offset = Util.GetUtf8(text_begin, native_text_begin, text_begin_byteCount);
                native_text_begin[native_text_begin_offset] = 0;
            ImVec4* cpu_fine_clip_rect = null;
            ImGuiNative.ImDrawList_AddText_FontPtr((ImDrawList*)(NativePtr), native_font, font_size, pos, col, native_text_begin, native_text_begin+text_begin_byteCount, wrap_width, cpu_fine_clip_rect);
            if (text_begin_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_text_begin);
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public void AddText(ImFontPtr font, float font_size, ImVec2 pos, uint col, ReadOnlySpan<char> text_begin, float wrap_width, ref ImVec4 cpu_fine_clip_rect)
        {
            ImFont* native_font = font.NativePtr;
            byte* native_text_begin;
            int text_begin_byteCount = 0;
                text_begin_byteCount = Encoding.UTF8.GetByteCount(text_begin);
                if (text_begin_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_text_begin = Util.Allocate(text_begin_byteCount + 1);
                }
                else
                {
                    byte* native_text_begin_stackBytes = stackalloc byte[text_begin_byteCount + 1];
                    native_text_begin = native_text_begin_stackBytes;
                }
                int native_text_begin_offset = Util.GetUtf8(text_begin, native_text_begin, text_begin_byteCount);
                native_text_begin[native_text_begin_offset] = 0;
            fixed (ImVec4* native_cpu_fine_clip_rect = &cpu_fine_clip_rect)
            {
                ImGuiNative.ImDrawList_AddText_FontPtr((ImDrawList*)(NativePtr), native_font, font_size, pos, col, native_text_begin, native_text_begin+text_begin_byteCount, wrap_width, native_cpu_fine_clip_rect);
                if (text_begin_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_text_begin);
                }
            }
        }
#endif
        public void AddText(ImFontPtr font, float font_size, ImVec2 pos, uint col, string text_begin, float wrap_width, ref ImVec4 cpu_fine_clip_rect)
        {
            ImFont* native_font = font.NativePtr;
            byte* native_text_begin;
            int text_begin_byteCount = 0;
                text_begin_byteCount = Encoding.UTF8.GetByteCount(text_begin);
                if (text_begin_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_text_begin = Util.Allocate(text_begin_byteCount + 1);
                }
                else
                {
                    byte* native_text_begin_stackBytes = stackalloc byte[text_begin_byteCount + 1];
                    native_text_begin = native_text_begin_stackBytes;
                }
                int native_text_begin_offset = Util.GetUtf8(text_begin, native_text_begin, text_begin_byteCount);
                native_text_begin[native_text_begin_offset] = 0;
            fixed (ImVec4* native_cpu_fine_clip_rect = &cpu_fine_clip_rect)
            {
                ImGuiNative.ImDrawList_AddText_FontPtr((ImDrawList*)(NativePtr), native_font, font_size, pos, col, native_text_begin, native_text_begin+text_begin_byteCount, wrap_width, native_cpu_fine_clip_rect);
                if (text_begin_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_text_begin);
                }
            }
        }
        public void AddTriangle(ImVec2 p1, ImVec2 p2, ImVec2 p3, uint col)
        {
            float thickness = 1.0f;
            ImGuiNative.ImDrawList_AddTriangle((ImDrawList*)(NativePtr), p1, p2, p3, col, thickness);
        }
        public void AddTriangle(ImVec2 p1, ImVec2 p2, ImVec2 p3, uint col, float thickness)
        {
            ImGuiNative.ImDrawList_AddTriangle((ImDrawList*)(NativePtr), p1, p2, p3, col, thickness);
        }
        public void AddTriangleFilled(ImVec2 p1, ImVec2 p2, ImVec2 p3, uint col)
        {
            ImGuiNative.ImDrawList_AddTriangleFilled((ImDrawList*)(NativePtr), p1, p2, p3, col);
        }
        public void ChannelsMerge()
        {
            ImGuiNative.ImDrawList_ChannelsMerge((ImDrawList*)(NativePtr));
        }
        public void ChannelsSetCurrent(int n)
        {
            ImGuiNative.ImDrawList_ChannelsSetCurrent((ImDrawList*)(NativePtr), n);
        }
        public void ChannelsSplit(int count)
        {
            ImGuiNative.ImDrawList_ChannelsSplit((ImDrawList*)(NativePtr), count);
        }
        public ImDrawListPtr CloneOutput()
        {
            ImDrawList* ret = ImGuiNative.ImDrawList_CloneOutput((ImDrawList*)(NativePtr));
            return new ImDrawListPtr(ret);
        }
        public void Destroy()
        {
            ImGuiNative.ImDrawList_destroy((ImDrawList*)(NativePtr));
        }
        public ImVec2 GetClipRectMax()
        {
            ImVec2 ret = ImGuiNative.ImDrawList_GetClipRectMax((ImDrawList*)(NativePtr));
            return ret;
        }
        public ImVec2 GetClipRectMin()
        {
            ImVec2 ret = ImGuiNative.ImDrawList_GetClipRectMin((ImDrawList*)(NativePtr));
            return ret;
        }
        public void PathArcTo(ImVec2 center, float radius, float a_min, float a_max)
        {
            int num_segments = 0;
            ImGuiNative.ImDrawList_PathArcTo((ImDrawList*)(NativePtr), center, radius, a_min, a_max, num_segments);
        }
        public void PathArcTo(ImVec2 center, float radius, float a_min, float a_max, int num_segments)
        {
            ImGuiNative.ImDrawList_PathArcTo((ImDrawList*)(NativePtr), center, radius, a_min, a_max, num_segments);
        }
        public void PathArcToFast(ImVec2 center, float radius, int a_min_of_12, int a_max_of_12)
        {
            ImGuiNative.ImDrawList_PathArcToFast((ImDrawList*)(NativePtr), center, radius, a_min_of_12, a_max_of_12);
        }
        public void PathBezierCubicCurveTo(ImVec2 p2, ImVec2 p3, ImVec2 p4)
        {
            int num_segments = 0;
            ImGuiNative.ImDrawList_PathBezierCubicCurveTo((ImDrawList*)(NativePtr), p2, p3, p4, num_segments);
        }
        public void PathBezierCubicCurveTo(ImVec2 p2, ImVec2 p3, ImVec2 p4, int num_segments)
        {
            ImGuiNative.ImDrawList_PathBezierCubicCurveTo((ImDrawList*)(NativePtr), p2, p3, p4, num_segments);
        }
        public void PathBezierQuadraticCurveTo(ImVec2 p2, ImVec2 p3)
        {
            int num_segments = 0;
            ImGuiNative.ImDrawList_PathBezierQuadraticCurveTo((ImDrawList*)(NativePtr), p2, p3, num_segments);
        }
        public void PathBezierQuadraticCurveTo(ImVec2 p2, ImVec2 p3, int num_segments)
        {
            ImGuiNative.ImDrawList_PathBezierQuadraticCurveTo((ImDrawList*)(NativePtr), p2, p3, num_segments);
        }
        public void PathClear()
        {
            ImGuiNative.ImDrawList_PathClear((ImDrawList*)(NativePtr));
        }
        public void PathEllipticalArcTo(ImVec2 center, ImVec2 radius, float rot, float a_min, float a_max)
        {
            int num_segments = 0;
            ImGuiNative.ImDrawList_PathEllipticalArcTo((ImDrawList*)(NativePtr), center, radius, rot, a_min, a_max, num_segments);
        }
        public void PathEllipticalArcTo(ImVec2 center, ImVec2 radius, float rot, float a_min, float a_max, int num_segments)
        {
            ImGuiNative.ImDrawList_PathEllipticalArcTo((ImDrawList*)(NativePtr), center, radius, rot, a_min, a_max, num_segments);
        }
        public void PathFillConcave(uint col)
        {
            ImGuiNative.ImDrawList_PathFillConcave((ImDrawList*)(NativePtr), col);
        }
        public void PathFillConvex(uint col)
        {
            ImGuiNative.ImDrawList_PathFillConvex((ImDrawList*)(NativePtr), col);
        }
        public void PathLineTo(ImVec2 pos)
        {
            ImGuiNative.ImDrawList_PathLineTo((ImDrawList*)(NativePtr), pos);
        }
        public void PathLineToMergeDuplicate(ImVec2 pos)
        {
            ImGuiNative.ImDrawList_PathLineToMergeDuplicate((ImDrawList*)(NativePtr), pos);
        }
        public void PathRect(ImVec2 rect_min, ImVec2 rect_max)
        {
            float rounding = 0.0f;
            ImDrawFlags flags = (ImDrawFlags)0;
            ImGuiNative.ImDrawList_PathRect((ImDrawList*)(NativePtr), rect_min, rect_max, rounding, flags);
        }
        public void PathRect(ImVec2 rect_min, ImVec2 rect_max, float rounding)
        {
            ImDrawFlags flags = (ImDrawFlags)0;
            ImGuiNative.ImDrawList_PathRect((ImDrawList*)(NativePtr), rect_min, rect_max, rounding, flags);
        }
        public void PathRect(ImVec2 rect_min, ImVec2 rect_max, float rounding, ImDrawFlags flags)
        {
            ImGuiNative.ImDrawList_PathRect((ImDrawList*)(NativePtr), rect_min, rect_max, rounding, flags);
        }
        public void PathStroke(uint col)
        {
            ImDrawFlags flags = (ImDrawFlags)0;
            float thickness = 1.0f;
            ImGuiNative.ImDrawList_PathStroke((ImDrawList*)(NativePtr), col, flags, thickness);
        }
        public void PathStroke(uint col, ImDrawFlags flags)
        {
            float thickness = 1.0f;
            ImGuiNative.ImDrawList_PathStroke((ImDrawList*)(NativePtr), col, flags, thickness);
        }
        public void PathStroke(uint col, ImDrawFlags flags, float thickness)
        {
            ImGuiNative.ImDrawList_PathStroke((ImDrawList*)(NativePtr), col, flags, thickness);
        }
        public void PopClipRect()
        {
            ImGuiNative.ImDrawList_PopClipRect((ImDrawList*)(NativePtr));
        }
        public void PopTexture()
        {
            ImGuiNative.ImDrawList_PopTexture((ImDrawList*)(NativePtr));
        }
        public void PrimQuadUV(ImVec2 a, ImVec2 b, ImVec2 c, ImVec2 d, ImVec2 uv_a, ImVec2 uv_b, ImVec2 uv_c, ImVec2 uv_d, uint col)
        {
            ImGuiNative.ImDrawList_PrimQuadUV((ImDrawList*)(NativePtr), a, b, c, d, uv_a, uv_b, uv_c, uv_d, col);
        }
        public void PrimRect(ImVec2 a, ImVec2 b, uint col)
        {
            ImGuiNative.ImDrawList_PrimRect((ImDrawList*)(NativePtr), a, b, col);
        }
        public void PrimRectUV(ImVec2 a, ImVec2 b, ImVec2 uv_a, ImVec2 uv_b, uint col)
        {
            ImGuiNative.ImDrawList_PrimRectUV((ImDrawList*)(NativePtr), a, b, uv_a, uv_b, col);
        }
        public void PrimReserve(int idx_count, int vtx_count)
        {
            ImGuiNative.ImDrawList_PrimReserve((ImDrawList*)(NativePtr), idx_count, vtx_count);
        }
        public void PrimUnreserve(int idx_count, int vtx_count)
        {
            ImGuiNative.ImDrawList_PrimUnreserve((ImDrawList*)(NativePtr), idx_count, vtx_count);
        }
        public void PrimVtx(ImVec2 pos, ImVec2 uv, uint col)
        {
            ImGuiNative.ImDrawList_PrimVtx((ImDrawList*)(NativePtr), pos, uv, col);
        }
        public void PrimWriteIdx(ushort idx)
        {
            ImGuiNative.ImDrawList_PrimWriteIdx((ImDrawList*)(NativePtr), idx);
        }
        public void PrimWriteVtx(ImVec2 pos, ImVec2 uv, uint col)
        {
            ImGuiNative.ImDrawList_PrimWriteVtx((ImDrawList*)(NativePtr), pos, uv, col);
        }
        public void PushClipRect(ImVec2 clip_rect_min, ImVec2 clip_rect_max)
        {
            byte intersect_with_current_clip_rect = 0;
            ImGuiNative.ImDrawList_PushClipRect((ImDrawList*)(NativePtr), clip_rect_min, clip_rect_max, intersect_with_current_clip_rect);
        }
        public void PushClipRect(ImVec2 clip_rect_min, ImVec2 clip_rect_max, bool intersect_with_current_clip_rect)
        {
            byte native_intersect_with_current_clip_rect = intersect_with_current_clip_rect ? (byte)1 : (byte)0;
            ImGuiNative.ImDrawList_PushClipRect((ImDrawList*)(NativePtr), clip_rect_min, clip_rect_max, native_intersect_with_current_clip_rect);
        }
        public void PushClipRectFullScreen()
        {
            ImGuiNative.ImDrawList_PushClipRectFullScreen((ImDrawList*)(NativePtr));
        }
        public void PushTexture(ImTextureRef tex_ref)
        {
            ImGuiNative.ImDrawList_PushTexture((ImDrawList*)(NativePtr), tex_ref);
        }
    }
}
