using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;


namespace IntricateEngine.ImGui
{
    public static unsafe partial class ImGuiNative
    {
        [LibraryImport("IntricateEngine", EntryPoint = "igAcceptDragDropPayload")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImGuiPayload* igAcceptDragDropPayload(byte* type, ImGuiDragDropFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igAlignTextToFramePadding")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igAlignTextToFramePadding();

        [LibraryImport("IntricateEngine", EntryPoint = "igArrowButton")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igArrowButton(byte* str_id, ImGuiDir dir);

        [LibraryImport("IntricateEngine", EntryPoint = "igBegin")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igBegin(byte* name, byte* p_open, ImGuiWindowFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igBeginChild_Str")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igBeginChild_Str(byte* str_id, Vector2 size, ImGuiChildFlags child_flags, ImGuiWindowFlags window_flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igBeginChild_ID")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igBeginChild_ID(uint id, Vector2 size, ImGuiChildFlags child_flags, ImGuiWindowFlags window_flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igBeginCombo")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igBeginCombo(byte* label, byte* preview_value, ImGuiComboFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igBeginDisabled")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igBeginDisabled(byte disabled);

        [LibraryImport("IntricateEngine", EntryPoint = "igBeginDragDropSource")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igBeginDragDropSource(ImGuiDragDropFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igBeginDragDropTarget")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igBeginDragDropTarget();

        [LibraryImport("IntricateEngine", EntryPoint = "igBeginGroup")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igBeginGroup();

        [LibraryImport("IntricateEngine", EntryPoint = "igBeginItemTooltip")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igBeginItemTooltip();

        [LibraryImport("IntricateEngine", EntryPoint = "igBeginListBox")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igBeginListBox(byte* label, Vector2 size);

        [LibraryImport("IntricateEngine", EntryPoint = "igBeginMainMenuBar")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igBeginMainMenuBar();

        [LibraryImport("IntricateEngine", EntryPoint = "igBeginMenu")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igBeginMenu(byte* label, byte enabled);

        [LibraryImport("IntricateEngine", EntryPoint = "igBeginMenuBar")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igBeginMenuBar();

        [LibraryImport("IntricateEngine", EntryPoint = "igBeginMultiSelect")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImGuiMultiSelectIO* igBeginMultiSelect(ImGuiMultiSelectFlags flags, int selection_size, int items_count);

        [LibraryImport("IntricateEngine", EntryPoint = "igBeginPopup")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igBeginPopup(byte* str_id, ImGuiWindowFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igBeginPopupContextItem")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igBeginPopupContextItem(byte* str_id, ImGuiPopupFlags popup_flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igBeginPopupContextVoid")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igBeginPopupContextVoid(byte* str_id, ImGuiPopupFlags popup_flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igBeginPopupContextWindow")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igBeginPopupContextWindow(byte* str_id, ImGuiPopupFlags popup_flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igBeginPopupModal")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igBeginPopupModal(byte* name, byte* p_open, ImGuiWindowFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igBeginTabBar")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igBeginTabBar(byte* str_id, ImGuiTabBarFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igBeginTabItem")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igBeginTabItem(byte* label, byte* p_open, ImGuiTabItemFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igBeginTable")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igBeginTable(byte* str_id, int columns, ImGuiTableFlags flags, Vector2 outer_size, float inner_width);

        [LibraryImport("IntricateEngine", EntryPoint = "igBeginTooltip")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igBeginTooltip();

        [LibraryImport("IntricateEngine", EntryPoint = "igBullet")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igBullet();

        [LibraryImport("IntricateEngine", EntryPoint = "igBulletText")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igBulletText(byte* fmt);

        [LibraryImport("IntricateEngine", EntryPoint = "igButton")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igButton(byte* label, Vector2 size);

        [LibraryImport("IntricateEngine", EntryPoint = "igCalcItemWidth")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial float igCalcItemWidth();

        [LibraryImport("IntricateEngine", EntryPoint = "igCalcTextSize")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igCalcTextSize(Vector2* pOut, byte* text, byte* text_end, byte hide_text_after_double_hash, float wrap_width);

        [LibraryImport("IntricateEngine", EntryPoint = "igCheckbox")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igCheckbox(byte* label, byte* v);

        [LibraryImport("IntricateEngine", EntryPoint = "igCheckboxFlags_IntPtr")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igCheckboxFlags_IntPtr(byte* label, int* flags, int flags_value);

        [LibraryImport("IntricateEngine", EntryPoint = "igCheckboxFlags_UintPtr")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igCheckboxFlags_UintPtr(byte* label, uint* flags, uint flags_value);

        [LibraryImport("IntricateEngine", EntryPoint = "igCloseCurrentPopup")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igCloseCurrentPopup();

        [LibraryImport("IntricateEngine", EntryPoint = "igCollapsingHeader_TreeNodeFlags")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igCollapsingHeader_TreeNodeFlags(byte* label, ImGuiTreeNodeFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igCollapsingHeader_BoolPtr")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igCollapsingHeader_BoolPtr(byte* label, byte* p_visible, ImGuiTreeNodeFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igColorButton")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igColorButton(byte* desc_id, Vector4 col, ImGuiColorEditFlags flags, Vector2 size);

        [LibraryImport("IntricateEngine", EntryPoint = "igColorConvertFloat4ToU32")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial uint igColorConvertFloat4ToU32(Vector4 @in);

        [LibraryImport("IntricateEngine", EntryPoint = "igColorConvertHSVtoRGB")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igColorConvertHSVtoRGB(float h, float s, float v, float* out_r, float* out_g, float* out_b);

        [LibraryImport("IntricateEngine", EntryPoint = "igColorConvertRGBtoHSV")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igColorConvertRGBtoHSV(float r, float g, float b, float* out_h, float* out_s, float* out_v);

        [LibraryImport("IntricateEngine", EntryPoint = "igColorConvertU32ToFloat4")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igColorConvertU32ToFloat4(Vector4* pOut, uint @in);

        [LibraryImport("IntricateEngine", EntryPoint = "igColorEdit3")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igColorEdit3(byte* label, Vector3* col, ImGuiColorEditFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igColorEdit4")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igColorEdit4(byte* label, Vector4* col, ImGuiColorEditFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igColorPicker3")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igColorPicker3(byte* label, Vector3* col, ImGuiColorEditFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igColorPicker4")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igColorPicker4(byte* label, Vector4* col, ImGuiColorEditFlags flags, float* ref_col);

        [LibraryImport("IntricateEngine", EntryPoint = "igColumns")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igColumns(int count, byte* id, byte borders);

        [LibraryImport("IntricateEngine", EntryPoint = "igCombo_Str_arr")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igCombo_Str_arr(byte* label, int* current_item, byte** items, int items_count, int popup_max_height_in_items);

        [LibraryImport("IntricateEngine", EntryPoint = "igCombo_Str")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igCombo_Str(byte* label, int* current_item, byte* items_separated_by_zeros, int popup_max_height_in_items);

        [LibraryImport("IntricateEngine", EntryPoint = "igCreateContext")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial IntPtr igCreateContext(ImFontAtlas* shared_font_atlas);

        [LibraryImport("IntricateEngine", EntryPoint = "igDebugCheckVersionAndDataLayout")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igDebugCheckVersionAndDataLayout(byte* version_str, uint sz_io, uint sz_style, uint sz_vec2, uint sz_vec4, uint sz_drawvert, uint sz_drawidx);

        [LibraryImport("IntricateEngine", EntryPoint = "igDebugFlashStyleColor")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igDebugFlashStyleColor(ImGuiCol idx);

        [LibraryImport("IntricateEngine", EntryPoint = "igDebugLog")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igDebugLog(byte* fmt);

        [LibraryImport("IntricateEngine", EntryPoint = "igDebugStartItemPicker")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igDebugStartItemPicker();

        [LibraryImport("IntricateEngine", EntryPoint = "igDebugTextEncoding")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igDebugTextEncoding(byte* text);

        [LibraryImport("IntricateEngine", EntryPoint = "igDestroyContext")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igDestroyContext(IntPtr ctx);

        [LibraryImport("IntricateEngine", EntryPoint = "igDestroyPlatformWindows")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igDestroyPlatformWindows();

        [LibraryImport("IntricateEngine", EntryPoint = "igDockSpace")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial uint igDockSpace(uint dockspace_id, Vector2 size, ImGuiDockNodeFlags flags, ImGuiWindowClass* window_class);

        [LibraryImport("IntricateEngine", EntryPoint = "igDockSpaceOverViewport")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial uint igDockSpaceOverViewport(uint dockspace_id, ImGuiViewport* viewport, ImGuiDockNodeFlags flags, ImGuiWindowClass* window_class);

        [LibraryImport("IntricateEngine", EntryPoint = "igDragFloat")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igDragFloat(byte* label, float* v, float v_speed, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igDragFloat2")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igDragFloat2(byte* label, Vector2* v, float v_speed, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igDragFloat3")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igDragFloat3(byte* label, Vector3* v, float v_speed, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igDragFloat4")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igDragFloat4(byte* label, Vector4* v, float v_speed, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igDragFloatRange2")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igDragFloatRange2(byte* label, float* v_current_min, float* v_current_max, float v_speed, float v_min, float v_max, byte* format, byte* format_max, ImGuiSliderFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igDragInt")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igDragInt(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igDragInt2")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igDragInt2(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igDragInt3")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igDragInt3(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igDragInt4")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igDragInt4(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igDragIntRange2")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igDragIntRange2(byte* label, int* v_current_min, int* v_current_max, float v_speed, int v_min, int v_max, byte* format, byte* format_max, ImGuiSliderFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igDragScalar")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igDragScalar(byte* label, ImGuiDataType data_type, void* p_data, float v_speed, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igDragScalarN")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igDragScalarN(byte* label, ImGuiDataType data_type, void* p_data, int components, float v_speed, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igDummy")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igDummy(Vector2 size);

        [LibraryImport("IntricateEngine", EntryPoint = "igEnd")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igEnd();

        [LibraryImport("IntricateEngine", EntryPoint = "igEndChild")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igEndChild();

        [LibraryImport("IntricateEngine", EntryPoint = "igEndCombo")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igEndCombo();

        [LibraryImport("IntricateEngine", EntryPoint = "igEndDisabled")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igEndDisabled();

        [LibraryImport("IntricateEngine", EntryPoint = "igEndDragDropSource")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igEndDragDropSource();

        [LibraryImport("IntricateEngine", EntryPoint = "igEndDragDropTarget")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igEndDragDropTarget();

        [LibraryImport("IntricateEngine", EntryPoint = "igEndFrame")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igEndFrame();

        [LibraryImport("IntricateEngine", EntryPoint = "igEndGroup")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igEndGroup();

        [LibraryImport("IntricateEngine", EntryPoint = "igEndListBox")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igEndListBox();

        [LibraryImport("IntricateEngine", EntryPoint = "igEndMainMenuBar")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igEndMainMenuBar();

        [LibraryImport("IntricateEngine", EntryPoint = "igEndMenu")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igEndMenu();

        [LibraryImport("IntricateEngine", EntryPoint = "igEndMenuBar")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igEndMenuBar();

        [LibraryImport("IntricateEngine", EntryPoint = "igEndMultiSelect")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImGuiMultiSelectIO* igEndMultiSelect();

        [LibraryImport("IntricateEngine", EntryPoint = "igEndPopup")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igEndPopup();

        [LibraryImport("IntricateEngine", EntryPoint = "igEndTabBar")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igEndTabBar();

        [LibraryImport("IntricateEngine", EntryPoint = "igEndTabItem")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igEndTabItem();

        [LibraryImport("IntricateEngine", EntryPoint = "igEndTable")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igEndTable();

        [LibraryImport("IntricateEngine", EntryPoint = "igEndTooltip")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igEndTooltip();

        [LibraryImport("IntricateEngine", EntryPoint = "igFindViewportByID")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImGuiViewport* igFindViewportByID(uint id);

        [LibraryImport("IntricateEngine", EntryPoint = "igFindViewportByPlatformHandle")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImGuiViewport* igFindViewportByPlatformHandle(void* platform_handle);

        [LibraryImport("IntricateEngine", EntryPoint = "igGetAllocatorFunctions")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igGetAllocatorFunctions(IntPtr* p_alloc_func, IntPtr* p_free_func, void** p_user_data);

        [LibraryImport("IntricateEngine", EntryPoint = "igGetBackgroundDrawList")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImDrawList* igGetBackgroundDrawList(ImGuiViewport* viewport);

        [LibraryImport("IntricateEngine", EntryPoint = "igGetClipboardText")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte* igGetClipboardText();

        [LibraryImport("IntricateEngine", EntryPoint = "igGetColorU32_Col")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial uint igGetColorU32_Col(ImGuiCol idx, float alpha_mul);

        [LibraryImport("IntricateEngine", EntryPoint = "igGetColorU32_Vec4")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial uint igGetColorU32_Vec4(Vector4 col);

        [LibraryImport("IntricateEngine", EntryPoint = "igGetColorU32_U32")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial uint igGetColorU32_U32(uint col, float alpha_mul);

        [LibraryImport("IntricateEngine", EntryPoint = "igGetColumnIndex")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial int igGetColumnIndex();

        [LibraryImport("IntricateEngine", EntryPoint = "igGetColumnOffset")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial float igGetColumnOffset(int column_index);

        [LibraryImport("IntricateEngine", EntryPoint = "igGetColumnsCount")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial int igGetColumnsCount();

        [LibraryImport("IntricateEngine", EntryPoint = "igGetColumnWidth")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial float igGetColumnWidth(int column_index);

        [LibraryImport("IntricateEngine", EntryPoint = "igGetContentRegionAvail")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igGetContentRegionAvail(Vector2* pOut);

        [LibraryImport("IntricateEngine", EntryPoint = "igGetCurrentContext")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial IntPtr igGetCurrentContext();

        [LibraryImport("IntricateEngine", EntryPoint = "igGetCursorPos")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igGetCursorPos(Vector2* pOut);

        [LibraryImport("IntricateEngine", EntryPoint = "igGetCursorPosX")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial float igGetCursorPosX();

        [LibraryImport("IntricateEngine", EntryPoint = "igGetCursorPosY")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial float igGetCursorPosY();

        [LibraryImport("IntricateEngine", EntryPoint = "igGetCursorScreenPos")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igGetCursorScreenPos(Vector2* pOut);

        [LibraryImport("IntricateEngine", EntryPoint = "igGetCursorStartPos")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igGetCursorStartPos(Vector2* pOut);

        [LibraryImport("IntricateEngine", EntryPoint = "igGetDragDropPayload")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImGuiPayload* igGetDragDropPayload();

        [LibraryImport("IntricateEngine", EntryPoint = "igGetDrawData")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImDrawData* igGetDrawData();

        [LibraryImport("IntricateEngine", EntryPoint = "igGetDrawListSharedData")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial IntPtr igGetDrawListSharedData();

        [LibraryImport("IntricateEngine", EntryPoint = "igGetFont")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImFont* igGetFont();

        [LibraryImport("IntricateEngine", EntryPoint = "igGetFontSize")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial float igGetFontSize();

        [LibraryImport("IntricateEngine", EntryPoint = "igGetFontTexUvWhitePixel")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igGetFontTexUvWhitePixel(Vector2* pOut);

        [LibraryImport("IntricateEngine", EntryPoint = "igGetForegroundDrawList_ViewportPtr")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImDrawList* igGetForegroundDrawList_ViewportPtr(ImGuiViewport* viewport);

        [LibraryImport("IntricateEngine", EntryPoint = "igGetFrameCount")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial int igGetFrameCount();

        [LibraryImport("IntricateEngine", EntryPoint = "igGetFrameHeight")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial float igGetFrameHeight();

        [LibraryImport("IntricateEngine", EntryPoint = "igGetFrameHeightWithSpacing")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial float igGetFrameHeightWithSpacing();

        [LibraryImport("IntricateEngine", EntryPoint = "igGetID_Str")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial uint igGetID_Str(byte* str_id);

        [LibraryImport("IntricateEngine", EntryPoint = "igGetID_StrStr")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial uint igGetID_StrStr(byte* str_id_begin, byte* str_id_end);

        [LibraryImport("IntricateEngine", EntryPoint = "igGetID_Ptr")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial uint igGetID_Ptr(void* ptr_id);

        [LibraryImport("IntricateEngine", EntryPoint = "igGetID_Int")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial uint igGetID_Int(int int_id);

        [LibraryImport("IntricateEngine", EntryPoint = "igGetIO")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImGuiIO* igGetIO();

        [LibraryImport("IntricateEngine", EntryPoint = "igGetItemID")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial uint igGetItemID();

        [LibraryImport("IntricateEngine", EntryPoint = "igGetItemRectMax")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igGetItemRectMax(Vector2* pOut);

        [LibraryImport("IntricateEngine", EntryPoint = "igGetItemRectMin")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igGetItemRectMin(Vector2* pOut);

        [LibraryImport("IntricateEngine", EntryPoint = "igGetItemRectSize")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igGetItemRectSize(Vector2* pOut);

        [LibraryImport("IntricateEngine", EntryPoint = "igGetKeyName")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte* igGetKeyName(ImGuiKey key);

        [LibraryImport("IntricateEngine", EntryPoint = "igGetKeyPressedAmount")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial int igGetKeyPressedAmount(ImGuiKey key, float repeat_delay, float rate);

        [LibraryImport("IntricateEngine", EntryPoint = "igGetMainViewport")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImGuiViewport* igGetMainViewport();

        [LibraryImport("IntricateEngine", EntryPoint = "igGetMouseClickedCount")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial int igGetMouseClickedCount(ImGuiMouseButton button);

        [LibraryImport("IntricateEngine", EntryPoint = "igGetMouseCursor")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImGuiMouseCursor igGetMouseCursor();

        [LibraryImport("IntricateEngine", EntryPoint = "igGetMouseDragDelta")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igGetMouseDragDelta(Vector2* pOut, ImGuiMouseButton button, float lock_threshold);

        [LibraryImport("IntricateEngine", EntryPoint = "igGetMousePos")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igGetMousePos(Vector2* pOut);

        [LibraryImport("IntricateEngine", EntryPoint = "igGetMousePosOnOpeningCurrentPopup")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igGetMousePosOnOpeningCurrentPopup(Vector2* pOut);

        [LibraryImport("IntricateEngine", EntryPoint = "igGetPlatformIO")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImGuiPlatformIO* igGetPlatformIO();

        [LibraryImport("IntricateEngine", EntryPoint = "igGetScrollMaxX")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial float igGetScrollMaxX();

        [LibraryImport("IntricateEngine", EntryPoint = "igGetScrollMaxY")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial float igGetScrollMaxY();

        [LibraryImport("IntricateEngine", EntryPoint = "igGetScrollX")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial float igGetScrollX();

        [LibraryImport("IntricateEngine", EntryPoint = "igGetScrollY")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial float igGetScrollY();

        [LibraryImport("IntricateEngine", EntryPoint = "igGetStateStorage")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImGuiStorage* igGetStateStorage();

        [LibraryImport("IntricateEngine", EntryPoint = "igGetStyle")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImGuiStyle* igGetStyle();

        [LibraryImport("IntricateEngine", EntryPoint = "igGetStyleColorName")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte* igGetStyleColorName(ImGuiCol idx);

        [LibraryImport("IntricateEngine", EntryPoint = "igGetStyleColorVec4")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial Vector4* igGetStyleColorVec4(ImGuiCol idx);

        [LibraryImport("IntricateEngine", EntryPoint = "igGetTextLineHeight")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial float igGetTextLineHeight();

        [LibraryImport("IntricateEngine", EntryPoint = "igGetTextLineHeightWithSpacing")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial float igGetTextLineHeightWithSpacing();

        [LibraryImport("IntricateEngine", EntryPoint = "igGetTime")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial double igGetTime();

        [LibraryImport("IntricateEngine", EntryPoint = "igGetTreeNodeToLabelSpacing")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial float igGetTreeNodeToLabelSpacing();

        [LibraryImport("IntricateEngine", EntryPoint = "igGetVersion")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte* igGetVersion();

        [LibraryImport("IntricateEngine", EntryPoint = "igGetWindowDockID")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial uint igGetWindowDockID();

        [LibraryImport("IntricateEngine", EntryPoint = "igGetWindowDpiScale")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial float igGetWindowDpiScale();

        [LibraryImport("IntricateEngine", EntryPoint = "igGetWindowDrawList")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImDrawList* igGetWindowDrawList();

        [LibraryImport("IntricateEngine", EntryPoint = "igGetWindowHeight")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial float igGetWindowHeight();

        [LibraryImport("IntricateEngine", EntryPoint = "igGetWindowPos")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igGetWindowPos(Vector2* pOut);

        [LibraryImport("IntricateEngine", EntryPoint = "igGetWindowSize")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igGetWindowSize(Vector2* pOut);

        [LibraryImport("IntricateEngine", EntryPoint = "igGetWindowViewport")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImGuiViewport* igGetWindowViewport();

        [LibraryImport("IntricateEngine", EntryPoint = "igGetWindowWidth")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial float igGetWindowWidth();

        [LibraryImport("IntricateEngine", EntryPoint = "igImage")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igImage(IntPtr user_texture_id, Vector2 image_size, Vector2 uv0, Vector2 uv1, Vector4 tint_col, Vector4 border_col);

        [LibraryImport("IntricateEngine", EntryPoint = "igImageButton")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igImageButton(byte* str_id, IntPtr user_texture_id, Vector2 image_size, Vector2 uv0, Vector2 uv1, Vector4 bg_col, Vector4 tint_col);

        [LibraryImport("IntricateEngine", EntryPoint = "igIndent")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igIndent(float indent_w);

        [LibraryImport("IntricateEngine", EntryPoint = "igInputDouble")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igInputDouble(byte* label, double* v, double step, double step_fast, byte* format, ImGuiInputTextFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igInputFloat")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igInputFloat(byte* label, float* v, float step, float step_fast, byte* format, ImGuiInputTextFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igInputFloat2")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igInputFloat2(byte* label, Vector2* v, byte* format, ImGuiInputTextFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igInputFloat3")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igInputFloat3(byte* label, Vector3* v, byte* format, ImGuiInputTextFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igInputFloat4")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igInputFloat4(byte* label, Vector4* v, byte* format, ImGuiInputTextFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igInputInt")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igInputInt(byte* label, int* v, int step, int step_fast, ImGuiInputTextFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igInputInt2")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igInputInt2(byte* label, int* v, ImGuiInputTextFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igInputInt3")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igInputInt3(byte* label, int* v, ImGuiInputTextFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igInputInt4")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igInputInt4(byte* label, int* v, ImGuiInputTextFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igInputScalar")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igInputScalar(byte* label, ImGuiDataType data_type, void* p_data, void* p_step, void* p_step_fast, byte* format, ImGuiInputTextFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igInputScalarN")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igInputScalarN(byte* label, ImGuiDataType data_type, void* p_data, int components, void* p_step, void* p_step_fast, byte* format, ImGuiInputTextFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igInputText")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igInputText(byte* label, byte* buf, uint buf_size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* user_data);

        [LibraryImport("IntricateEngine", EntryPoint = "igInputTextMultiline")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igInputTextMultiline(byte* label, byte* buf, uint buf_size, Vector2 size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* user_data);

        [LibraryImport("IntricateEngine", EntryPoint = "igInputTextWithHint")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igInputTextWithHint(byte* label, byte* hint, byte* buf, uint buf_size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* user_data);

        [LibraryImport("IntricateEngine", EntryPoint = "igInvisibleButton")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igInvisibleButton(byte* str_id, Vector2 size, ImGuiButtonFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igIsAnyItemActive")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igIsAnyItemActive();

        [LibraryImport("IntricateEngine", EntryPoint = "igIsAnyItemFocused")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igIsAnyItemFocused();

        [LibraryImport("IntricateEngine", EntryPoint = "igIsAnyItemHovered")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igIsAnyItemHovered();

        [LibraryImport("IntricateEngine", EntryPoint = "igIsAnyMouseDown")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igIsAnyMouseDown();

        [LibraryImport("IntricateEngine", EntryPoint = "igIsItemActivated")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igIsItemActivated();

        [LibraryImport("IntricateEngine", EntryPoint = "igIsItemActive")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igIsItemActive();

        [LibraryImport("IntricateEngine", EntryPoint = "igIsItemClicked")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igIsItemClicked(ImGuiMouseButton mouse_button);

        [LibraryImport("IntricateEngine", EntryPoint = "igIsItemDeactivated")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igIsItemDeactivated();

        [LibraryImport("IntricateEngine", EntryPoint = "igIsItemDeactivatedAfterEdit")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igIsItemDeactivatedAfterEdit();

        [LibraryImport("IntricateEngine", EntryPoint = "igIsItemEdited")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igIsItemEdited();

        [LibraryImport("IntricateEngine", EntryPoint = "igIsItemFocused")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igIsItemFocused();

        [LibraryImport("IntricateEngine", EntryPoint = "igIsItemHovered")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igIsItemHovered(ImGuiHoveredFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igIsItemToggledOpen")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igIsItemToggledOpen();

        [LibraryImport("IntricateEngine", EntryPoint = "igIsItemToggledSelection")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igIsItemToggledSelection();

        [LibraryImport("IntricateEngine", EntryPoint = "igIsItemVisible")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igIsItemVisible();

        [LibraryImport("IntricateEngine", EntryPoint = "igIsKeyChordPressed_Nil")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igIsKeyChordPressed_Nil(ImGuiKey key_chord);

        [LibraryImport("IntricateEngine", EntryPoint = "igIsKeyDown_Nil")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igIsKeyDown_Nil(ImGuiKey key);

        [LibraryImport("IntricateEngine", EntryPoint = "igIsKeyPressed_Bool")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igIsKeyPressed_Bool(ImGuiKey key, byte repeat);

        [LibraryImport("IntricateEngine", EntryPoint = "igIsKeyReleased_Nil")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igIsKeyReleased_Nil(ImGuiKey key);

        [LibraryImport("IntricateEngine", EntryPoint = "igIsMouseClicked_Bool")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igIsMouseClicked_Bool(ImGuiMouseButton button, byte repeat);

        [LibraryImport("IntricateEngine", EntryPoint = "igIsMouseDoubleClicked_Nil")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igIsMouseDoubleClicked_Nil(ImGuiMouseButton button);

        [LibraryImport("IntricateEngine", EntryPoint = "igIsMouseDown_Nil")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igIsMouseDown_Nil(ImGuiMouseButton button);

        [LibraryImport("IntricateEngine", EntryPoint = "igIsMouseDragging")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igIsMouseDragging(ImGuiMouseButton button, float lock_threshold);

        [LibraryImport("IntricateEngine", EntryPoint = "igIsMouseHoveringRect")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igIsMouseHoveringRect(Vector2 r_min, Vector2 r_max, byte clip);

        [LibraryImport("IntricateEngine", EntryPoint = "igIsMousePosValid")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igIsMousePosValid(Vector2* mouse_pos);

        [LibraryImport("IntricateEngine", EntryPoint = "igIsMouseReleased_Nil")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igIsMouseReleased_Nil(ImGuiMouseButton button);

        [LibraryImport("IntricateEngine", EntryPoint = "igIsPopupOpen_Str")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igIsPopupOpen_Str(byte* str_id, ImGuiPopupFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igIsRectVisible_Nil")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igIsRectVisible_Nil(Vector2 size);

        [LibraryImport("IntricateEngine", EntryPoint = "igIsRectVisible_Vec2")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igIsRectVisible_Vec2(Vector2 rect_min, Vector2 rect_max);

        [LibraryImport("IntricateEngine", EntryPoint = "igIsWindowAppearing")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igIsWindowAppearing();

        [LibraryImport("IntricateEngine", EntryPoint = "igIsWindowCollapsed")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igIsWindowCollapsed();

        [LibraryImport("IntricateEngine", EntryPoint = "igIsWindowDocked")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igIsWindowDocked();

        [LibraryImport("IntricateEngine", EntryPoint = "igIsWindowFocused")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igIsWindowFocused(ImGuiFocusedFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igIsWindowHovered")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igIsWindowHovered(ImGuiHoveredFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igLabelText")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igLabelText(byte* label, byte* fmt);

        [LibraryImport("IntricateEngine", EntryPoint = "igListBox_Str_arr")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igListBox_Str_arr(byte* label, int* current_item, byte** items, int items_count, int height_in_items);

        [LibraryImport("IntricateEngine", EntryPoint = "igLoadIniSettingsFromDisk")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igLoadIniSettingsFromDisk(byte* ini_filename);

        [LibraryImport("IntricateEngine", EntryPoint = "igLoadIniSettingsFromMemory")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igLoadIniSettingsFromMemory(byte* ini_data, uint ini_size);

        [LibraryImport("IntricateEngine", EntryPoint = "igLogButtons")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igLogButtons();

        [LibraryImport("IntricateEngine", EntryPoint = "igLogFinish")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igLogFinish();

        [LibraryImport("IntricateEngine", EntryPoint = "igLogText")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igLogText(byte* fmt);

        [LibraryImport("IntricateEngine", EntryPoint = "igLogToClipboard")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igLogToClipboard(int auto_open_depth);

        [LibraryImport("IntricateEngine", EntryPoint = "igLogToFile")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igLogToFile(int auto_open_depth, byte* filename);

        [LibraryImport("IntricateEngine", EntryPoint = "igLogToTTY")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igLogToTTY(int auto_open_depth);

        [LibraryImport("IntricateEngine", EntryPoint = "igMemAlloc")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void* igMemAlloc(uint size);

        [LibraryImport("IntricateEngine", EntryPoint = "igMemFree")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igMemFree(void* ptr);

        [LibraryImport("IntricateEngine", EntryPoint = "igMenuItem_Bool")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igMenuItem_Bool(byte* label, byte* shortcut, byte selected, byte enabled);

        [LibraryImport("IntricateEngine", EntryPoint = "igMenuItem_BoolPtr")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igMenuItem_BoolPtr(byte* label, byte* shortcut, byte* p_selected, byte enabled);

        [LibraryImport("IntricateEngine", EntryPoint = "igNewFrame")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igNewFrame();

        [LibraryImport("IntricateEngine", EntryPoint = "igNewLine")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igNewLine();

        [LibraryImport("IntricateEngine", EntryPoint = "igNextColumn")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igNextColumn();

        [LibraryImport("IntricateEngine", EntryPoint = "igOpenPopup_Str")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igOpenPopup_Str(byte* str_id, ImGuiPopupFlags popup_flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igOpenPopup_ID")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igOpenPopup_ID(uint id, ImGuiPopupFlags popup_flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igOpenPopupOnItemClick")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igOpenPopupOnItemClick(byte* str_id, ImGuiPopupFlags popup_flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igPlotHistogram_FloatPtr")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igPlotHistogram_FloatPtr(byte* label, float* values, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, Vector2 graph_size, int stride);

        [LibraryImport("IntricateEngine", EntryPoint = "igPlotLines_FloatPtr")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igPlotLines_FloatPtr(byte* label, float* values, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, Vector2 graph_size, int stride);

        [LibraryImport("IntricateEngine", EntryPoint = "igPopClipRect")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igPopClipRect();

        [LibraryImport("IntricateEngine", EntryPoint = "igPopFont")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igPopFont();

        [LibraryImport("IntricateEngine", EntryPoint = "igPopID")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igPopID();

        [LibraryImport("IntricateEngine", EntryPoint = "igPopItemFlag")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igPopItemFlag();

        [LibraryImport("IntricateEngine", EntryPoint = "igPopItemWidth")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igPopItemWidth();

        [LibraryImport("IntricateEngine", EntryPoint = "igPopStyleColor")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igPopStyleColor(int count);

        [LibraryImport("IntricateEngine", EntryPoint = "igPopStyleVar")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igPopStyleVar(int count);

        [LibraryImport("IntricateEngine", EntryPoint = "igPopTextWrapPos")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igPopTextWrapPos();

        [LibraryImport("IntricateEngine", EntryPoint = "igProgressBar")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igProgressBar(float fraction, Vector2 size_arg, byte* overlay);

        [LibraryImport("IntricateEngine", EntryPoint = "igPushClipRect")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igPushClipRect(Vector2 clip_rect_min, Vector2 clip_rect_max, byte intersect_with_current_clip_rect);

        [LibraryImport("IntricateEngine", EntryPoint = "igPushFont")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igPushFont(ImFont* font);

        [LibraryImport("IntricateEngine", EntryPoint = "igPushID_Str")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igPushID_Str(byte* str_id);

        [LibraryImport("IntricateEngine", EntryPoint = "igPushID_StrStr")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igPushID_StrStr(byte* str_id_begin, byte* str_id_end);

        [LibraryImport("IntricateEngine", EntryPoint = "igPushID_Ptr")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igPushID_Ptr(void* ptr_id);

        [LibraryImport("IntricateEngine", EntryPoint = "igPushID_Int")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igPushID_Int(int int_id);

        [LibraryImport("IntricateEngine", EntryPoint = "igPushItemFlag")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igPushItemFlag(ImGuiItemFlags option, byte enabled);

        [LibraryImport("IntricateEngine", EntryPoint = "igPushItemWidth")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igPushItemWidth(float item_width);

        [LibraryImport("IntricateEngine", EntryPoint = "igPushStyleColor_U32")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igPushStyleColor_U32(ImGuiCol idx, uint col);

        [LibraryImport("IntricateEngine", EntryPoint = "igPushStyleColor_Vec4")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igPushStyleColor_Vec4(ImGuiCol idx, Vector4 col);

        [LibraryImport("IntricateEngine", EntryPoint = "igPushStyleVar_Float")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igPushStyleVar_Float(ImGuiStyleVar idx, float val);

        [LibraryImport("IntricateEngine", EntryPoint = "igPushStyleVar_Vec2")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igPushStyleVar_Vec2(ImGuiStyleVar idx, Vector2 val);

        [LibraryImport("IntricateEngine", EntryPoint = "igPushStyleVarX")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igPushStyleVarX(ImGuiStyleVar idx, float val_x);

        [LibraryImport("IntricateEngine", EntryPoint = "igPushStyleVarY")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igPushStyleVarY(ImGuiStyleVar idx, float val_y);

        [LibraryImport("IntricateEngine", EntryPoint = "igPushTextWrapPos")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igPushTextWrapPos(float wrap_local_pos_x);

        [LibraryImport("IntricateEngine", EntryPoint = "igRadioButton_Bool")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igRadioButton_Bool(byte* label, byte active);

        [LibraryImport("IntricateEngine", EntryPoint = "igRadioButton_IntPtr")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igRadioButton_IntPtr(byte* label, int* v, int v_button);

        [LibraryImport("IntricateEngine", EntryPoint = "igRender")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igRender();

        [LibraryImport("IntricateEngine", EntryPoint = "igRenderPlatformWindowsDefault")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igRenderPlatformWindowsDefault(void* platform_render_arg, void* renderer_render_arg);

        [LibraryImport("IntricateEngine", EntryPoint = "igResetMouseDragDelta")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igResetMouseDragDelta(ImGuiMouseButton button);

        [LibraryImport("IntricateEngine", EntryPoint = "igSameLine")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSameLine(float offset_from_start_x, float spacing);

        [LibraryImport("IntricateEngine", EntryPoint = "igSaveIniSettingsToDisk")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSaveIniSettingsToDisk(byte* ini_filename);

        [LibraryImport("IntricateEngine", EntryPoint = "igSaveIniSettingsToMemory")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte* igSaveIniSettingsToMemory(uint* out_ini_size);

        [LibraryImport("IntricateEngine", EntryPoint = "igSelectable_Bool")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igSelectable_Bool(byte* label, byte selected, ImGuiSelectableFlags flags, Vector2 size);

        [LibraryImport("IntricateEngine", EntryPoint = "igSelectable_BoolPtr")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igSelectable_BoolPtr(byte* label, byte* p_selected, ImGuiSelectableFlags flags, Vector2 size);

        [LibraryImport("IntricateEngine", EntryPoint = "igSeparator")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSeparator();

        [LibraryImport("IntricateEngine", EntryPoint = "igSeparatorText")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSeparatorText(byte* label);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetAllocatorFunctions")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetAllocatorFunctions(IntPtr alloc_func, IntPtr free_func, void* user_data);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetClipboardText")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetClipboardText(byte* text);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetColorEditOptions")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetColorEditOptions(ImGuiColorEditFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetColumnOffset")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetColumnOffset(int column_index, float offset_x);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetColumnWidth")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetColumnWidth(int column_index, float width);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetCurrentContext")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetCurrentContext(IntPtr ctx);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetCursorPos")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetCursorPos(Vector2 local_pos);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetCursorPosX")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetCursorPosX(float local_x);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetCursorPosY")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetCursorPosY(float local_y);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetCursorScreenPos")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetCursorScreenPos(Vector2 pos);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetDragDropPayload")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igSetDragDropPayload(byte* type, void* data, uint sz, ImGuiCond cond);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetItemDefaultFocus")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetItemDefaultFocus();

        [LibraryImport("IntricateEngine", EntryPoint = "igSetItemKeyOwner_Nil")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetItemKeyOwner_Nil(ImGuiKey key);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetItemTooltip")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetItemTooltip(byte* fmt);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetKeyboardFocusHere")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetKeyboardFocusHere(int offset);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetMouseCursor")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetMouseCursor(ImGuiMouseCursor cursor_type);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetNavCursorVisible")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetNavCursorVisible(byte visible);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetNextFrameWantCaptureKeyboard")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetNextFrameWantCaptureKeyboard(byte want_capture_keyboard);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetNextFrameWantCaptureMouse")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetNextFrameWantCaptureMouse(byte want_capture_mouse);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetNextItemAllowOverlap")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetNextItemAllowOverlap();

        [LibraryImport("IntricateEngine", EntryPoint = "igSetNextItemOpen")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetNextItemOpen(byte is_open, ImGuiCond cond);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetNextItemSelectionUserData")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetNextItemSelectionUserData(long selection_user_data);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetNextItemShortcut")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetNextItemShortcut(ImGuiKey key_chord, ImGuiInputFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetNextItemStorageID")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetNextItemStorageID(uint storage_id);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetNextItemWidth")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetNextItemWidth(float item_width);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetNextWindowBgAlpha")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetNextWindowBgAlpha(float alpha);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetNextWindowClass")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetNextWindowClass(ImGuiWindowClass* window_class);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetNextWindowCollapsed")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetNextWindowCollapsed(byte collapsed, ImGuiCond cond);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetNextWindowContentSize")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetNextWindowContentSize(Vector2 size);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetNextWindowDockID")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetNextWindowDockID(uint dock_id, ImGuiCond cond);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetNextWindowFocus")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetNextWindowFocus();

        [LibraryImport("IntricateEngine", EntryPoint = "igSetNextWindowPos")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetNextWindowPos(Vector2 pos, ImGuiCond cond, Vector2 pivot);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetNextWindowScroll")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetNextWindowScroll(Vector2 scroll);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetNextWindowSize")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetNextWindowSize(Vector2 size, ImGuiCond cond);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetNextWindowSizeConstraints")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetNextWindowSizeConstraints(Vector2 size_min, Vector2 size_max, ImGuiSizeCallback custom_callback, void* custom_callback_data);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetNextWindowViewport")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetNextWindowViewport(uint viewport_id);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetScrollFromPosX_Float")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetScrollFromPosX_Float(float local_x, float center_x_ratio);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetScrollFromPosY_Float")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetScrollFromPosY_Float(float local_y, float center_y_ratio);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetScrollHereX")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetScrollHereX(float center_x_ratio);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetScrollHereY")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetScrollHereY(float center_y_ratio);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetScrollX_Float")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetScrollX_Float(float scroll_x);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetScrollY_Float")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetScrollY_Float(float scroll_y);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetStateStorage")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetStateStorage(ImGuiStorage* storage);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetTabItemClosed")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetTabItemClosed(byte* tab_or_docked_window_label);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetTooltip")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetTooltip(byte* fmt);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetWindowCollapsed_Bool")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetWindowCollapsed_Bool(byte collapsed, ImGuiCond cond);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetWindowCollapsed_Str")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetWindowCollapsed_Str(byte* name, byte collapsed, ImGuiCond cond);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetWindowFocus_Nil")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetWindowFocus_Nil();

        [LibraryImport("IntricateEngine", EntryPoint = "igSetWindowFocus_Str")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetWindowFocus_Str(byte* name);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetWindowFontScale")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetWindowFontScale(float scale);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetWindowPos_Vec2")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetWindowPos_Vec2(Vector2 pos, ImGuiCond cond);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetWindowPos_Str")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetWindowPos_Str(byte* name, Vector2 pos, ImGuiCond cond);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetWindowSize_Vec2")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetWindowSize_Vec2(Vector2 size, ImGuiCond cond);

        [LibraryImport("IntricateEngine", EntryPoint = "igSetWindowSize_Str")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSetWindowSize_Str(byte* name, Vector2 size, ImGuiCond cond);

        [LibraryImport("IntricateEngine", EntryPoint = "igShortcut_Nil")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igShortcut_Nil(ImGuiKey key_chord, ImGuiInputFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igShowAboutWindow")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igShowAboutWindow(byte* p_open);

        [LibraryImport("IntricateEngine", EntryPoint = "igShowDebugLogWindow")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igShowDebugLogWindow(byte* p_open);

        [LibraryImport("IntricateEngine", EntryPoint = "igShowDemoWindow")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igShowDemoWindow(byte* p_open);

        [LibraryImport("IntricateEngine", EntryPoint = "igShowFontSelector")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igShowFontSelector(byte* label);

        [LibraryImport("IntricateEngine", EntryPoint = "igShowIDStackToolWindow")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igShowIDStackToolWindow(byte* p_open);

        [LibraryImport("IntricateEngine", EntryPoint = "igShowMetricsWindow")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igShowMetricsWindow(byte* p_open);

        [LibraryImport("IntricateEngine", EntryPoint = "igShowStyleEditor")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igShowStyleEditor(ImGuiStyle* @ref);

        [LibraryImport("IntricateEngine", EntryPoint = "igShowStyleSelector")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igShowStyleSelector(byte* label);

        [LibraryImport("IntricateEngine", EntryPoint = "igShowUserGuide")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igShowUserGuide();

        [LibraryImport("IntricateEngine", EntryPoint = "igSliderAngle")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igSliderAngle(byte* label, float* v_rad, float v_degrees_min, float v_degrees_max, byte* format, ImGuiSliderFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igSliderFloat")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igSliderFloat(byte* label, float* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igSliderFloat2")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igSliderFloat2(byte* label, Vector2* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igSliderFloat3")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igSliderFloat3(byte* label, Vector3* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igSliderFloat4")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igSliderFloat4(byte* label, Vector4* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igSliderInt")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igSliderInt(byte* label, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igSliderInt2")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igSliderInt2(byte* label, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igSliderInt3")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igSliderInt3(byte* label, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igSliderInt4")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igSliderInt4(byte* label, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igSliderScalar")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igSliderScalar(byte* label, ImGuiDataType data_type, void* p_data, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igSliderScalarN")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igSliderScalarN(byte* label, ImGuiDataType data_type, void* p_data, int components, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igSmallButton")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igSmallButton(byte* label);

        [LibraryImport("IntricateEngine", EntryPoint = "igSpacing")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igSpacing();

        [LibraryImport("IntricateEngine", EntryPoint = "igStyleColorsClassic")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igStyleColorsClassic(ImGuiStyle* dst);

        [LibraryImport("IntricateEngine", EntryPoint = "igStyleColorsDark")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igStyleColorsDark(ImGuiStyle* dst);

        [LibraryImport("IntricateEngine", EntryPoint = "igStyleColorsLight")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igStyleColorsLight(ImGuiStyle* dst);

        [LibraryImport("IntricateEngine", EntryPoint = "igTabItemButton")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igTabItemButton(byte* label, ImGuiTabItemFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igTableAngledHeadersRow")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igTableAngledHeadersRow();

        [LibraryImport("IntricateEngine", EntryPoint = "igTableGetColumnCount")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial int igTableGetColumnCount();

        [LibraryImport("IntricateEngine", EntryPoint = "igTableGetColumnFlags")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImGuiTableColumnFlags igTableGetColumnFlags(int column_n);

        [LibraryImport("IntricateEngine", EntryPoint = "igTableGetColumnIndex")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial int igTableGetColumnIndex();

        [LibraryImport("IntricateEngine", EntryPoint = "igTableGetColumnName_Int")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte* igTableGetColumnName_Int(int column_n);

        [LibraryImport("IntricateEngine", EntryPoint = "igTableGetHoveredColumn")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial int igTableGetHoveredColumn();

        [LibraryImport("IntricateEngine", EntryPoint = "igTableGetRowIndex")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial int igTableGetRowIndex();

        [LibraryImport("IntricateEngine", EntryPoint = "igTableGetSortSpecs")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImGuiTableSortSpecs* igTableGetSortSpecs();

        [LibraryImport("IntricateEngine", EntryPoint = "igTableHeader")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igTableHeader(byte* label);

        [LibraryImport("IntricateEngine", EntryPoint = "igTableHeadersRow")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igTableHeadersRow();

        [LibraryImport("IntricateEngine", EntryPoint = "igTableNextColumn")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igTableNextColumn();

        [LibraryImport("IntricateEngine", EntryPoint = "igTableNextRow")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igTableNextRow(ImGuiTableRowFlags row_flags, float min_row_height);

        [LibraryImport("IntricateEngine", EntryPoint = "igTableSetBgColor")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igTableSetBgColor(ImGuiTableBgTarget target, uint color, int column_n);

        [LibraryImport("IntricateEngine", EntryPoint = "igTableSetColumnEnabled")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igTableSetColumnEnabled(int column_n, byte v);

        [LibraryImport("IntricateEngine", EntryPoint = "igTableSetColumnIndex")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igTableSetColumnIndex(int column_n);

        [LibraryImport("IntricateEngine", EntryPoint = "igTableSetupColumn")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igTableSetupColumn(byte* label, ImGuiTableColumnFlags flags, float init_width_or_weight, uint user_id);

        [LibraryImport("IntricateEngine", EntryPoint = "igTableSetupScrollFreeze")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igTableSetupScrollFreeze(int cols, int rows);

        [LibraryImport("IntricateEngine", EntryPoint = "igText")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igText(byte* fmt);

        [LibraryImport("IntricateEngine", EntryPoint = "igTextColored")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igTextColored(Vector4 col, byte* fmt);

        [LibraryImport("IntricateEngine", EntryPoint = "igTextDisabled")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igTextDisabled(byte* fmt);

        [LibraryImport("IntricateEngine", EntryPoint = "igTextLink")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igTextLink(byte* label);

        [LibraryImport("IntricateEngine", EntryPoint = "igTextLinkOpenURL")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igTextLinkOpenURL(byte* label, byte* url);

        [LibraryImport("IntricateEngine", EntryPoint = "igTextUnformatted")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igTextUnformatted(byte* text, byte* text_end);

        [LibraryImport("IntricateEngine", EntryPoint = "igTextWrapped")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igTextWrapped(byte* fmt);

        [LibraryImport("IntricateEngine", EntryPoint = "igTreeNode_Str")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igTreeNode_Str(byte* label);

        [LibraryImport("IntricateEngine", EntryPoint = "igTreeNode_StrStr")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igTreeNode_StrStr(byte* str_id, byte* fmt);

        [LibraryImport("IntricateEngine", EntryPoint = "igTreeNode_Ptr")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igTreeNode_Ptr(void* ptr_id, byte* fmt);

        [LibraryImport("IntricateEngine", EntryPoint = "igTreeNodeEx_Str")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igTreeNodeEx_Str(byte* label, ImGuiTreeNodeFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igTreeNodeEx_StrStr")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igTreeNodeEx_StrStr(byte* str_id, ImGuiTreeNodeFlags flags, byte* fmt);

        [LibraryImport("IntricateEngine", EntryPoint = "igTreeNodeEx_Ptr")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igTreeNodeEx_Ptr(void* ptr_id, ImGuiTreeNodeFlags flags, byte* fmt);

        [LibraryImport("IntricateEngine", EntryPoint = "igTreePop")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igTreePop();

        [LibraryImport("IntricateEngine", EntryPoint = "igTreePush_Str")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igTreePush_Str(byte* str_id);

        [LibraryImport("IntricateEngine", EntryPoint = "igTreePush_Ptr")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igTreePush_Ptr(void* ptr_id);

        [LibraryImport("IntricateEngine", EntryPoint = "igUnindent")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igUnindent(float indent_w);

        [LibraryImport("IntricateEngine", EntryPoint = "igUpdatePlatformWindows")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igUpdatePlatformWindows();

        [LibraryImport("IntricateEngine", EntryPoint = "igValue_Bool")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igValue_Bool(byte* prefix, byte b);

        [LibraryImport("IntricateEngine", EntryPoint = "igValue_Int")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igValue_Int(byte* prefix, int v);

        [LibraryImport("IntricateEngine", EntryPoint = "igValue_Uint")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igValue_Uint(byte* prefix, uint v);

        [LibraryImport("IntricateEngine", EntryPoint = "igValue_Float")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void igValue_Float(byte* prefix, float v, byte* float_format);

        [LibraryImport("IntricateEngine", EntryPoint = "igVSliderFloat")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igVSliderFloat(byte* label, Vector2 size, float* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igVSliderInt")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igVSliderInt(byte* label, Vector2 size, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "igVSliderScalar")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte igVSliderScalar(byte* label, Vector2 size, ImGuiDataType data_type, void* p_data, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "ImColor_destroy")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImColor_destroy(ImColor* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImColor_HSV")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImColor_HSV(ImColor* pOut, float h, float s, float v, float a);

        [LibraryImport("IntricateEngine", EntryPoint = "ImColor_ImColor_Nil")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImColor* ImColor_ImColor_Nil();

        [LibraryImport("IntricateEngine", EntryPoint = "ImColor_ImColor_Float")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImColor* ImColor_ImColor_Float(float r, float g, float b, float a);

        [LibraryImport("IntricateEngine", EntryPoint = "ImColor_ImColor_Vec4")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImColor* ImColor_ImColor_Vec4(Vector4 col);

        [LibraryImport("IntricateEngine", EntryPoint = "ImColor_ImColor_Int")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImColor* ImColor_ImColor_Int(int r, int g, int b, int a);

        [LibraryImport("IntricateEngine", EntryPoint = "ImColor_ImColor_U32")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImColor* ImColor_ImColor_U32(uint rgba);

        [LibraryImport("IntricateEngine", EntryPoint = "ImColor_SetHSV")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImColor_SetHSV(ImColor* self, float h, float s, float v, float a);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawCmd_destroy")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawCmd_destroy(ImDrawCmd* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawCmd_GetTexID")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial IntPtr ImDrawCmd_GetTexID(ImDrawCmd* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawCmd_ImDrawCmd")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImDrawCmd* ImDrawCmd_ImDrawCmd();

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawData_AddDrawList")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawData_AddDrawList(ImDrawData* self, ImDrawList* draw_list);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawData_Clear")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawData_Clear(ImDrawData* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawData_DeIndexAllBuffers")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawData_DeIndexAllBuffers(ImDrawData* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawData_destroy")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawData_destroy(ImDrawData* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawData_ImDrawData")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImDrawData* ImDrawData_ImDrawData();

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawData_ScaleClipRects")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawData_ScaleClipRects(ImDrawData* self, Vector2 fb_scale);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList__CalcCircleAutoSegmentCount")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial int ImDrawList__CalcCircleAutoSegmentCount(ImDrawList* self, float radius);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList__ClearFreeMemory")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList__ClearFreeMemory(ImDrawList* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList__OnChangedClipRect")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList__OnChangedClipRect(ImDrawList* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList__OnChangedTextureID")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList__OnChangedTextureID(ImDrawList* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList__OnChangedVtxOffset")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList__OnChangedVtxOffset(ImDrawList* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList__PathArcToFastEx")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList__PathArcToFastEx(ImDrawList* self, Vector2 center, float radius, int a_min_sample, int a_max_sample, int a_step);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList__PathArcToN")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList__PathArcToN(ImDrawList* self, Vector2 center, float radius, float a_min, float a_max, int num_segments);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList__PopUnusedDrawCmd")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList__PopUnusedDrawCmd(ImDrawList* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList__ResetForNewFrame")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList__ResetForNewFrame(ImDrawList* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList__SetTextureID")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList__SetTextureID(ImDrawList* self, IntPtr texture_id);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList__TryMergeDrawCmds")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList__TryMergeDrawCmds(ImDrawList* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_AddBezierCubic")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_AddBezierCubic(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col, float thickness, int num_segments);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_AddBezierQuadratic")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_AddBezierQuadratic(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, uint col, float thickness, int num_segments);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_AddCallback")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_AddCallback(ImDrawList* self, IntPtr callback, void* userdata, uint userdata_size);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_AddCircle")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_AddCircle(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments, float thickness);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_AddCircleFilled")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_AddCircleFilled(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_AddConcavePolyFilled")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_AddConcavePolyFilled(ImDrawList* self, Vector2* points, int num_points, uint col);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_AddConvexPolyFilled")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_AddConvexPolyFilled(ImDrawList* self, Vector2* points, int num_points, uint col);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_AddDrawCmd")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_AddDrawCmd(ImDrawList* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_AddEllipse")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_AddEllipse(ImDrawList* self, Vector2 center, Vector2 radius, uint col, float rot, int num_segments, float thickness);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_AddEllipseFilled")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_AddEllipseFilled(ImDrawList* self, Vector2 center, Vector2 radius, uint col, float rot, int num_segments);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_AddImage")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_AddImage(ImDrawList* self, IntPtr user_texture_id, Vector2 p_min, Vector2 p_max, Vector2 uv_min, Vector2 uv_max, uint col);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_AddImageQuad")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_AddImageQuad(ImDrawList* self, IntPtr user_texture_id, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 uv1, Vector2 uv2, Vector2 uv3, Vector2 uv4, uint col);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_AddImageRounded")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_AddImageRounded(ImDrawList* self, IntPtr user_texture_id, Vector2 p_min, Vector2 p_max, Vector2 uv_min, Vector2 uv_max, uint col, float rounding, ImDrawFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_AddLine")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_AddLine(ImDrawList* self, Vector2 p1, Vector2 p2, uint col, float thickness);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_AddNgon")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_AddNgon(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments, float thickness);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_AddNgonFilled")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_AddNgonFilled(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_AddPolyline")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_AddPolyline(ImDrawList* self, Vector2* points, int num_points, uint col, ImDrawFlags flags, float thickness);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_AddQuad")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_AddQuad(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col, float thickness);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_AddQuadFilled")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_AddQuadFilled(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_AddRect")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_AddRect(ImDrawList* self, Vector2 p_min, Vector2 p_max, uint col, float rounding, ImDrawFlags flags, float thickness);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_AddRectFilled")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_AddRectFilled(ImDrawList* self, Vector2 p_min, Vector2 p_max, uint col, float rounding, ImDrawFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_AddRectFilledMultiColor")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_AddRectFilledMultiColor(ImDrawList* self, Vector2 p_min, Vector2 p_max, uint col_upr_left, uint col_upr_right, uint col_bot_right, uint col_bot_left);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_AddText_Vec2")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_AddText_Vec2(ImDrawList* self, Vector2 pos, uint col, byte* text_begin, byte* text_end);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_AddText_FontPtr")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_AddText_FontPtr(ImDrawList* self, ImFont* font, float font_size, Vector2 pos, uint col, byte* text_begin, byte* text_end, float wrap_width, Vector4* cpu_fine_clip_rect);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_AddTriangle")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_AddTriangle(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, uint col, float thickness);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_AddTriangleFilled")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_AddTriangleFilled(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, uint col);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_ChannelsMerge")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_ChannelsMerge(ImDrawList* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_ChannelsSetCurrent")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_ChannelsSetCurrent(ImDrawList* self, int n);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_ChannelsSplit")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_ChannelsSplit(ImDrawList* self, int count);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_CloneOutput")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImDrawList* ImDrawList_CloneOutput(ImDrawList* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_destroy")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_destroy(ImDrawList* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_GetClipRectMax")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_GetClipRectMax(Vector2* pOut, ImDrawList* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_GetClipRectMin")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_GetClipRectMin(Vector2* pOut, ImDrawList* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_ImDrawList")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImDrawList* ImDrawList_ImDrawList(IntPtr shared_data);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_PathArcTo")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_PathArcTo(ImDrawList* self, Vector2 center, float radius, float a_min, float a_max, int num_segments);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_PathArcToFast")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_PathArcToFast(ImDrawList* self, Vector2 center, float radius, int a_min_of_12, int a_max_of_12);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_PathBezierCubicCurveTo")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_PathBezierCubicCurveTo(ImDrawList* self, Vector2 p2, Vector2 p3, Vector2 p4, int num_segments);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_PathBezierQuadraticCurveTo")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_PathBezierQuadraticCurveTo(ImDrawList* self, Vector2 p2, Vector2 p3, int num_segments);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_PathClear")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_PathClear(ImDrawList* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_PathEllipticalArcTo")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_PathEllipticalArcTo(ImDrawList* self, Vector2 center, Vector2 radius, float rot, float a_min, float a_max, int num_segments);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_PathFillConcave")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_PathFillConcave(ImDrawList* self, uint col);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_PathFillConvex")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_PathFillConvex(ImDrawList* self, uint col);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_PathLineTo")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_PathLineTo(ImDrawList* self, Vector2 pos);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_PathLineToMergeDuplicate")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_PathLineToMergeDuplicate(ImDrawList* self, Vector2 pos);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_PathRect")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_PathRect(ImDrawList* self, Vector2 rect_min, Vector2 rect_max, float rounding, ImDrawFlags flags);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_PathStroke")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_PathStroke(ImDrawList* self, uint col, ImDrawFlags flags, float thickness);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_PopClipRect")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_PopClipRect(ImDrawList* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_PopTextureID")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_PopTextureID(ImDrawList* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_PrimQuadUV")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_PrimQuadUV(ImDrawList* self, Vector2 a, Vector2 b, Vector2 c, Vector2 d, Vector2 uv_a, Vector2 uv_b, Vector2 uv_c, Vector2 uv_d, uint col);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_PrimRect")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_PrimRect(ImDrawList* self, Vector2 a, Vector2 b, uint col);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_PrimRectUV")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_PrimRectUV(ImDrawList* self, Vector2 a, Vector2 b, Vector2 uv_a, Vector2 uv_b, uint col);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_PrimReserve")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_PrimReserve(ImDrawList* self, int idx_count, int vtx_count);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_PrimUnreserve")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_PrimUnreserve(ImDrawList* self, int idx_count, int vtx_count);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_PrimVtx")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_PrimVtx(ImDrawList* self, Vector2 pos, Vector2 uv, uint col);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_PrimWriteIdx")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_PrimWriteIdx(ImDrawList* self, ushort idx);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_PrimWriteVtx")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_PrimWriteVtx(ImDrawList* self, Vector2 pos, Vector2 uv, uint col);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_PushClipRect")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_PushClipRect(ImDrawList* self, Vector2 clip_rect_min, Vector2 clip_rect_max, byte intersect_with_current_clip_rect);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_PushClipRectFullScreen")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_PushClipRectFullScreen(ImDrawList* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawList_PushTextureID")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawList_PushTextureID(ImDrawList* self, IntPtr texture_id);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawListSplitter_Clear")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawListSplitter_Clear(ImDrawListSplitter* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawListSplitter_ClearFreeMemory")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawListSplitter_ClearFreeMemory(ImDrawListSplitter* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawListSplitter_destroy")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawListSplitter_destroy(ImDrawListSplitter* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawListSplitter_ImDrawListSplitter")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImDrawListSplitter* ImDrawListSplitter_ImDrawListSplitter();

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawListSplitter_Merge")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawListSplitter_Merge(ImDrawListSplitter* self, ImDrawList* draw_list);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawListSplitter_SetCurrentChannel")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawListSplitter_SetCurrentChannel(ImDrawListSplitter* self, ImDrawList* draw_list, int channel_idx);

        [LibraryImport("IntricateEngine", EntryPoint = "ImDrawListSplitter_Split")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImDrawListSplitter_Split(ImDrawListSplitter* self, ImDrawList* draw_list, int count);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFont_AddGlyph")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImFont_AddGlyph(ImFont* self, ImFontConfig* src_cfg, ushort c, float x0, float y0, float x1, float y1, float u0, float v0, float u1, float v1, float advance_x);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFont_AddRemapChar")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImFont_AddRemapChar(ImFont* self, ushort dst, ushort src, byte overwrite_dst);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFont_BuildLookupTable")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImFont_BuildLookupTable(ImFont* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFont_CalcTextSizeA")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImFont_CalcTextSizeA(Vector2* pOut, ImFont* self, float size, float max_width, float wrap_width, byte* text_begin, byte* text_end, byte** remaining);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFont_CalcWordWrapPositionA")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte* ImFont_CalcWordWrapPositionA(ImFont* self, float scale, byte* text, byte* text_end, float wrap_width);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFont_ClearOutputData")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImFont_ClearOutputData(ImFont* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFont_destroy")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImFont_destroy(ImFont* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFont_FindGlyph")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImFontGlyph* ImFont_FindGlyph(ImFont* self, ushort c);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFont_FindGlyphNoFallback")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImFontGlyph* ImFont_FindGlyphNoFallback(ImFont* self, ushort c);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFont_GetCharAdvance")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial float ImFont_GetCharAdvance(ImFont* self, ushort c);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFont_GetDebugName")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte* ImFont_GetDebugName(ImFont* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFont_GrowIndex")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImFont_GrowIndex(ImFont* self, int new_size);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFont_ImFont")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImFont* ImFont_ImFont();

        [LibraryImport("IntricateEngine", EntryPoint = "ImFont_IsGlyphRangeUnused")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte ImFont_IsGlyphRangeUnused(ImFont* self, uint c_begin, uint c_last);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFont_IsLoaded")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte ImFont_IsLoaded(ImFont* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFont_RenderChar")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImFont_RenderChar(ImFont* self, ImDrawList* draw_list, float size, Vector2 pos, uint col, ushort c);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFont_RenderText")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImFont_RenderText(ImFont* self, ImDrawList* draw_list, float size, Vector2 pos, uint col, Vector4 clip_rect, byte* text_begin, byte* text_end, float wrap_width, byte cpu_fine_clip);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFont_SetGlyphVisible")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImFont_SetGlyphVisible(ImFont* self, ushort c, byte visible);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFontAtlas_AddCustomRectFontGlyph")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial int ImFontAtlas_AddCustomRectFontGlyph(ImFontAtlas* self, ImFont* font, ushort id, int width, int height, float advance_x, Vector2 offset);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFontAtlas_AddCustomRectRegular")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial int ImFontAtlas_AddCustomRectRegular(ImFontAtlas* self, int width, int height);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFontAtlas_AddFont")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImFont* ImFontAtlas_AddFont(ImFontAtlas* self, ImFontConfig* font_cfg);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFontAtlas_AddFontDefault")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImFont* ImFontAtlas_AddFontDefault(ImFontAtlas* self, ImFontConfig* font_cfg);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFontAtlas_AddFontFromFileTTF")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImFont* ImFontAtlas_AddFontFromFileTTF(ImFontAtlas* self, byte* filename, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFontAtlas_AddFontFromMemoryCompressedBase85TTF")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImFont* ImFontAtlas_AddFontFromMemoryCompressedBase85TTF(ImFontAtlas* self, byte* compressed_font_data_base85, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFontAtlas_AddFontFromMemoryCompressedTTF")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImFont* ImFontAtlas_AddFontFromMemoryCompressedTTF(ImFontAtlas* self, void* compressed_font_data, int compressed_font_data_size, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFontAtlas_AddFontFromMemoryTTF")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImFont* ImFontAtlas_AddFontFromMemoryTTF(ImFontAtlas* self, void* font_data, int font_data_size, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFontAtlas_Build")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte ImFontAtlas_Build(ImFontAtlas* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFontAtlas_CalcCustomRectUV")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImFontAtlas_CalcCustomRectUV(ImFontAtlas* self, ImFontAtlasCustomRect* rect, Vector2* out_uv_min, Vector2* out_uv_max);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFontAtlas_Clear")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImFontAtlas_Clear(ImFontAtlas* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFontAtlas_ClearFonts")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImFontAtlas_ClearFonts(ImFontAtlas* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFontAtlas_ClearInputData")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImFontAtlas_ClearInputData(ImFontAtlas* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFontAtlas_ClearTexData")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImFontAtlas_ClearTexData(ImFontAtlas* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFontAtlas_destroy")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImFontAtlas_destroy(ImFontAtlas* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFontAtlas_GetCustomRectByIndex")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImFontAtlasCustomRect* ImFontAtlas_GetCustomRectByIndex(ImFontAtlas* self, int index);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFontAtlas_GetGlyphRangesChineseFull")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ushort* ImFontAtlas_GetGlyphRangesChineseFull(ImFontAtlas* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFontAtlas_GetGlyphRangesChineseSimplifiedCommon")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ushort* ImFontAtlas_GetGlyphRangesChineseSimplifiedCommon(ImFontAtlas* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFontAtlas_GetGlyphRangesCyrillic")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ushort* ImFontAtlas_GetGlyphRangesCyrillic(ImFontAtlas* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFontAtlas_GetGlyphRangesDefault")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ushort* ImFontAtlas_GetGlyphRangesDefault(ImFontAtlas* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFontAtlas_GetGlyphRangesGreek")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ushort* ImFontAtlas_GetGlyphRangesGreek(ImFontAtlas* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFontAtlas_GetGlyphRangesJapanese")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ushort* ImFontAtlas_GetGlyphRangesJapanese(ImFontAtlas* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFontAtlas_GetGlyphRangesKorean")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ushort* ImFontAtlas_GetGlyphRangesKorean(ImFontAtlas* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFontAtlas_GetGlyphRangesThai")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ushort* ImFontAtlas_GetGlyphRangesThai(ImFontAtlas* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFontAtlas_GetGlyphRangesVietnamese")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ushort* ImFontAtlas_GetGlyphRangesVietnamese(ImFontAtlas* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFontAtlas_GetMouseCursorTexData")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte ImFontAtlas_GetMouseCursorTexData(ImFontAtlas* self, ImGuiMouseCursor cursor, Vector2* out_offset, Vector2* out_size, Vector2* out_uv_border, Vector2* out_uv_fill);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFontAtlas_GetTexDataAsAlpha8")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImFontAtlas_GetTexDataAsAlpha8(ImFontAtlas* self, byte** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFontAtlas_GetTexDataAsAlpha8")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImFontAtlas_GetTexDataAsAlpha8(ImFontAtlas* self, IntPtr* out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFontAtlas_GetTexDataAsRGBA32")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImFontAtlas_GetTexDataAsRGBA32(ImFontAtlas* self, byte** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFontAtlas_GetTexDataAsRGBA32")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImFontAtlas_GetTexDataAsRGBA32(ImFontAtlas* self, IntPtr* out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFontAtlas_ImFontAtlas")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImFontAtlas* ImFontAtlas_ImFontAtlas();

        [LibraryImport("IntricateEngine", EntryPoint = "ImFontAtlas_IsBuilt")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte ImFontAtlas_IsBuilt(ImFontAtlas* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFontAtlas_SetTexID")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImFontAtlas_SetTexID(ImFontAtlas* self, IntPtr id);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFontAtlasCustomRect_destroy")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImFontAtlasCustomRect_destroy(ImFontAtlasCustomRect* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFontAtlasCustomRect_ImFontAtlasCustomRect")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImFontAtlasCustomRect* ImFontAtlasCustomRect_ImFontAtlasCustomRect();

        [LibraryImport("IntricateEngine", EntryPoint = "ImFontAtlasCustomRect_IsPacked")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte ImFontAtlasCustomRect_IsPacked(ImFontAtlasCustomRect* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFontConfig_destroy")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImFontConfig_destroy(ImFontConfig* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFontConfig_ImFontConfig")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImFontConfig* ImFontConfig_ImFontConfig();

        [LibraryImport("IntricateEngine", EntryPoint = "ImFontGlyphRangesBuilder_AddChar")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImFontGlyphRangesBuilder_AddChar(ImFontGlyphRangesBuilder* self, ushort c);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFontGlyphRangesBuilder_AddRanges")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImFontGlyphRangesBuilder_AddRanges(ImFontGlyphRangesBuilder* self, ushort* ranges);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFontGlyphRangesBuilder_AddText")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImFontGlyphRangesBuilder_AddText(ImFontGlyphRangesBuilder* self, byte* text, byte* text_end);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFontGlyphRangesBuilder_BuildRanges")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImFontGlyphRangesBuilder_BuildRanges(ImFontGlyphRangesBuilder* self, ImVector* out_ranges);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFontGlyphRangesBuilder_Clear")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImFontGlyphRangesBuilder_Clear(ImFontGlyphRangesBuilder* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFontGlyphRangesBuilder_destroy")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImFontGlyphRangesBuilder_destroy(ImFontGlyphRangesBuilder* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFontGlyphRangesBuilder_GetBit")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte ImFontGlyphRangesBuilder_GetBit(ImFontGlyphRangesBuilder* self, uint n);

        [LibraryImport("IntricateEngine", EntryPoint = "ImFontGlyphRangesBuilder_ImFontGlyphRangesBuilder")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImFontGlyphRangesBuilder* ImFontGlyphRangesBuilder_ImFontGlyphRangesBuilder();

        [LibraryImport("IntricateEngine", EntryPoint = "ImFontGlyphRangesBuilder_SetBit")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImFontGlyphRangesBuilder_SetBit(ImFontGlyphRangesBuilder* self, uint n);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiFreeType_GetBuilderForFreeType")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial IntPtr* ImGuiFreeType_GetBuilderForFreeType();

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiInputTextCallbackData_ClearSelection")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiInputTextCallbackData_ClearSelection(ImGuiInputTextCallbackData* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiInputTextCallbackData_DeleteChars")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiInputTextCallbackData_DeleteChars(ImGuiInputTextCallbackData* self, int pos, int bytes_count);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiInputTextCallbackData_destroy")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiInputTextCallbackData_destroy(ImGuiInputTextCallbackData* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiInputTextCallbackData_HasSelection")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte ImGuiInputTextCallbackData_HasSelection(ImGuiInputTextCallbackData* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiInputTextCallbackData_ImGuiInputTextCallbackData")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImGuiInputTextCallbackData* ImGuiInputTextCallbackData_ImGuiInputTextCallbackData();

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiInputTextCallbackData_InsertChars")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiInputTextCallbackData_InsertChars(ImGuiInputTextCallbackData* self, int pos, byte* text, byte* text_end);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiInputTextCallbackData_SelectAll")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiInputTextCallbackData_SelectAll(ImGuiInputTextCallbackData* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiIO_AddFocusEvent")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiIO_AddFocusEvent(ImGuiIO* self, byte focused);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiIO_AddInputCharacter")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiIO_AddInputCharacter(ImGuiIO* self, uint c);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiIO_AddInputCharactersUTF8")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiIO_AddInputCharactersUTF8(ImGuiIO* self, byte* str);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiIO_AddInputCharacterUTF16")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiIO_AddInputCharacterUTF16(ImGuiIO* self, ushort c);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiIO_AddKeyAnalogEvent")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiIO_AddKeyAnalogEvent(ImGuiIO* self, ImGuiKey key, byte down, float v);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiIO_AddKeyEvent")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiIO_AddKeyEvent(ImGuiIO* self, ImGuiKey key, byte down);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiIO_AddMouseButtonEvent")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiIO_AddMouseButtonEvent(ImGuiIO* self, int button, byte down);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiIO_AddMousePosEvent")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiIO_AddMousePosEvent(ImGuiIO* self, float x, float y);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiIO_AddMouseSourceEvent")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiIO_AddMouseSourceEvent(ImGuiIO* self, ImGuiMouseSource source);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiIO_AddMouseViewportEvent")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiIO_AddMouseViewportEvent(ImGuiIO* self, uint id);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiIO_AddMouseWheelEvent")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiIO_AddMouseWheelEvent(ImGuiIO* self, float wheel_x, float wheel_y);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiIO_ClearEventsQueue")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiIO_ClearEventsQueue(ImGuiIO* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiIO_ClearInputKeys")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiIO_ClearInputKeys(ImGuiIO* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiIO_ClearInputMouse")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiIO_ClearInputMouse(ImGuiIO* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiIO_destroy")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiIO_destroy(ImGuiIO* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiIO_ImGuiIO")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImGuiIO* ImGuiIO_ImGuiIO();

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiIO_SetAppAcceptingEvents")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiIO_SetAppAcceptingEvents(ImGuiIO* self, byte accepting_events);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiIO_SetKeyEventNativeData")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiIO_SetKeyEventNativeData(ImGuiIO* self, ImGuiKey key, int native_keycode, int native_scancode, int native_legacy_index);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiListClipper_Begin")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiListClipper_Begin(ImGuiListClipper* self, int items_count, float items_height);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiListClipper_destroy")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiListClipper_destroy(ImGuiListClipper* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiListClipper_End")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiListClipper_End(ImGuiListClipper* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiListClipper_ImGuiListClipper")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImGuiListClipper* ImGuiListClipper_ImGuiListClipper();

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiListClipper_IncludeItemByIndex")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiListClipper_IncludeItemByIndex(ImGuiListClipper* self, int item_index);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiListClipper_IncludeItemsByIndex")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiListClipper_IncludeItemsByIndex(ImGuiListClipper* self, int item_begin, int item_end);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiListClipper_SeekCursorForItem")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiListClipper_SeekCursorForItem(ImGuiListClipper* self, int item_index);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiListClipper_Step")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte ImGuiListClipper_Step(ImGuiListClipper* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiOnceUponAFrame_destroy")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiOnceUponAFrame_destroy(ImGuiOnceUponAFrame* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiOnceUponAFrame_ImGuiOnceUponAFrame")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImGuiOnceUponAFrame* ImGuiOnceUponAFrame_ImGuiOnceUponAFrame();

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiPayload_Clear")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiPayload_Clear(ImGuiPayload* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiPayload_destroy")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiPayload_destroy(ImGuiPayload* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiPayload_ImGuiPayload")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImGuiPayload* ImGuiPayload_ImGuiPayload();

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiPayload_IsDataType")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte ImGuiPayload_IsDataType(ImGuiPayload* self, byte* type);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiPayload_IsDelivery")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte ImGuiPayload_IsDelivery(ImGuiPayload* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiPayload_IsPreview")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte ImGuiPayload_IsPreview(ImGuiPayload* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiPlatformImeData_destroy")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiPlatformImeData_destroy(ImGuiPlatformImeData* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiPlatformImeData_ImGuiPlatformImeData")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImGuiPlatformImeData* ImGuiPlatformImeData_ImGuiPlatformImeData();

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiPlatformIO_destroy")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiPlatformIO_destroy(ImGuiPlatformIO* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiPlatformIO_ImGuiPlatformIO")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImGuiPlatformIO* ImGuiPlatformIO_ImGuiPlatformIO();

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiPlatformMonitor_destroy")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiPlatformMonitor_destroy(ImGuiPlatformMonitor* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiPlatformMonitor_ImGuiPlatformMonitor")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImGuiPlatformMonitor* ImGuiPlatformMonitor_ImGuiPlatformMonitor();

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiSelectionBasicStorage_ApplyRequests")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiSelectionBasicStorage_ApplyRequests(ImGuiSelectionBasicStorage* self, ImGuiMultiSelectIO* ms_io);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiSelectionBasicStorage_Clear")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiSelectionBasicStorage_Clear(ImGuiSelectionBasicStorage* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiSelectionBasicStorage_Contains")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte ImGuiSelectionBasicStorage_Contains(ImGuiSelectionBasicStorage* self, uint id);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiSelectionBasicStorage_destroy")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiSelectionBasicStorage_destroy(ImGuiSelectionBasicStorage* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiSelectionBasicStorage_GetNextSelectedItem")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte ImGuiSelectionBasicStorage_GetNextSelectedItem(ImGuiSelectionBasicStorage* self, void** opaque_it, uint* out_id);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiSelectionBasicStorage_GetStorageIdFromIndex")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial uint ImGuiSelectionBasicStorage_GetStorageIdFromIndex(ImGuiSelectionBasicStorage* self, int idx);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiSelectionBasicStorage_ImGuiSelectionBasicStorage")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImGuiSelectionBasicStorage* ImGuiSelectionBasicStorage_ImGuiSelectionBasicStorage();

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiSelectionBasicStorage_SetItemSelected")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiSelectionBasicStorage_SetItemSelected(ImGuiSelectionBasicStorage* self, uint id, byte selected);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiSelectionBasicStorage_Swap")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiSelectionBasicStorage_Swap(ImGuiSelectionBasicStorage* self, ImGuiSelectionBasicStorage* r);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiSelectionExternalStorage_ApplyRequests")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiSelectionExternalStorage_ApplyRequests(ImGuiSelectionExternalStorage* self, ImGuiMultiSelectIO* ms_io);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiSelectionExternalStorage_destroy")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiSelectionExternalStorage_destroy(ImGuiSelectionExternalStorage* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiSelectionExternalStorage_ImGuiSelectionExternalStorage")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImGuiSelectionExternalStorage* ImGuiSelectionExternalStorage_ImGuiSelectionExternalStorage();

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiStorage_BuildSortByKey")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiStorage_BuildSortByKey(ImGuiStorage* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiStorage_Clear")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiStorage_Clear(ImGuiStorage* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiStorage_GetBool")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte ImGuiStorage_GetBool(ImGuiStorage* self, uint key, byte default_val);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiStorage_GetBoolRef")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte* ImGuiStorage_GetBoolRef(ImGuiStorage* self, uint key, byte default_val);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiStorage_GetFloat")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial float ImGuiStorage_GetFloat(ImGuiStorage* self, uint key, float default_val);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiStorage_GetFloatRef")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial float* ImGuiStorage_GetFloatRef(ImGuiStorage* self, uint key, float default_val);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiStorage_GetInt")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial int ImGuiStorage_GetInt(ImGuiStorage* self, uint key, int default_val);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiStorage_GetIntRef")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial int* ImGuiStorage_GetIntRef(ImGuiStorage* self, uint key, int default_val);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiStorage_GetVoidPtr")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void* ImGuiStorage_GetVoidPtr(ImGuiStorage* self, uint key);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiStorage_GetVoidPtrRef")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void** ImGuiStorage_GetVoidPtrRef(ImGuiStorage* self, uint key, void* default_val);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiStorage_SetAllInt")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiStorage_SetAllInt(ImGuiStorage* self, int val);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiStorage_SetBool")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiStorage_SetBool(ImGuiStorage* self, uint key, byte val);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiStorage_SetFloat")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiStorage_SetFloat(ImGuiStorage* self, uint key, float val);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiStorage_SetInt")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiStorage_SetInt(ImGuiStorage* self, uint key, int val);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiStorage_SetVoidPtr")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiStorage_SetVoidPtr(ImGuiStorage* self, uint key, void* val);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiStoragePair_destroy")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiStoragePair_destroy(ImGuiStoragePair* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiStoragePair_ImGuiStoragePair_Int")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImGuiStoragePair* ImGuiStoragePair_ImGuiStoragePair_Int(uint _key, int _val);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiStoragePair_ImGuiStoragePair_Float")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImGuiStoragePair* ImGuiStoragePair_ImGuiStoragePair_Float(uint _key, float _val);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiStoragePair_ImGuiStoragePair_Ptr")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImGuiStoragePair* ImGuiStoragePair_ImGuiStoragePair_Ptr(uint _key, void* _val);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiStyle_destroy")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiStyle_destroy(ImGuiStyle* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiStyle_ImGuiStyle")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImGuiStyle* ImGuiStyle_ImGuiStyle();

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiStyle_ScaleAllSizes")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiStyle_ScaleAllSizes(ImGuiStyle* self, float scale_factor);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiTableColumnSortSpecs_destroy")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiTableColumnSortSpecs_destroy(ImGuiTableColumnSortSpecs* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiTableColumnSortSpecs_ImGuiTableColumnSortSpecs")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImGuiTableColumnSortSpecs* ImGuiTableColumnSortSpecs_ImGuiTableColumnSortSpecs();

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiTableSortSpecs_destroy")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiTableSortSpecs_destroy(ImGuiTableSortSpecs* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiTableSortSpecs_ImGuiTableSortSpecs")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImGuiTableSortSpecs* ImGuiTableSortSpecs_ImGuiTableSortSpecs();

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiTextBuffer_append")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiTextBuffer_append(ImGuiTextBuffer* self, byte* str, byte* str_end);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiTextBuffer_appendf")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiTextBuffer_appendf(ImGuiTextBuffer* buffer, byte* fmt);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiTextBuffer_begin")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte* ImGuiTextBuffer_begin(ImGuiTextBuffer* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiTextBuffer_c_str")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte* ImGuiTextBuffer_c_str(ImGuiTextBuffer* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiTextBuffer_clear")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiTextBuffer_clear(ImGuiTextBuffer* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiTextBuffer_destroy")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiTextBuffer_destroy(ImGuiTextBuffer* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiTextBuffer_empty")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte ImGuiTextBuffer_empty(ImGuiTextBuffer* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiTextBuffer_end")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte* ImGuiTextBuffer_end(ImGuiTextBuffer* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiTextBuffer_ImGuiTextBuffer")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImGuiTextBuffer* ImGuiTextBuffer_ImGuiTextBuffer();

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiTextBuffer_reserve")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiTextBuffer_reserve(ImGuiTextBuffer* self, int capacity);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiTextBuffer_size")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial int ImGuiTextBuffer_size(ImGuiTextBuffer* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiTextFilter_Build")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiTextFilter_Build(ImGuiTextFilter* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiTextFilter_Clear")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiTextFilter_Clear(ImGuiTextFilter* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiTextFilter_destroy")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiTextFilter_destroy(ImGuiTextFilter* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiTextFilter_Draw")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte ImGuiTextFilter_Draw(ImGuiTextFilter* self, byte* label, float width);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiTextFilter_ImGuiTextFilter")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImGuiTextFilter* ImGuiTextFilter_ImGuiTextFilter(byte* default_filter);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiTextFilter_IsActive")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte ImGuiTextFilter_IsActive(ImGuiTextFilter* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiTextFilter_PassFilter")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte ImGuiTextFilter_PassFilter(ImGuiTextFilter* self, byte* text, byte* text_end);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiTextRange_destroy")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiTextRange_destroy(ImGuiTextRange* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiTextRange_empty")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte ImGuiTextRange_empty(ImGuiTextRange* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiTextRange_ImGuiTextRange_Nil")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImGuiTextRange* ImGuiTextRange_ImGuiTextRange_Nil();

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiTextRange_ImGuiTextRange_Str")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImGuiTextRange* ImGuiTextRange_ImGuiTextRange_Str(byte* _b, byte* _e);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiTextRange_split")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiTextRange_split(ImGuiTextRange* self, byte separator, ImVector* @out);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiViewport_destroy")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiViewport_destroy(ImGuiViewport* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiViewport_GetCenter")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiViewport_GetCenter(Vector2* pOut, ImGuiViewport* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiViewport_GetWorkCenter")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiViewport_GetWorkCenter(Vector2* pOut, ImGuiViewport* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiViewport_ImGuiViewport")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImGuiViewport* ImGuiViewport_ImGuiViewport();

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiWindowClass_destroy")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuiWindowClass_destroy(ImGuiWindowClass* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuiWindowClass_ImGuiWindowClass")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial ImGuiWindowClass* ImGuiWindowClass_ImGuiWindowClass();

        [LibraryImport("IntricateEngine", EntryPoint = "ImVec2_destroy")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImVec2_destroy(Vector2* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImVec2_ImVec2_Nil")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial Vector2* ImVec2_ImVec2_Nil();

        [LibraryImport("IntricateEngine", EntryPoint = "ImVec2_ImVec2_Float")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial Vector2* ImVec2_ImVec2_Float(float _x, float _y);

        [LibraryImport("IntricateEngine", EntryPoint = "ImVec4_destroy")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImVec4_destroy(Vector4* self);

        [LibraryImport("IntricateEngine", EntryPoint = "ImVec4_ImVec4_Nil")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial Vector4* ImVec4_ImVec4_Nil();

        [LibraryImport("IntricateEngine", EntryPoint = "ImVec4_ImVec4_Float")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial Vector4* ImVec4_ImVec4_Float(float _x, float _y, float _z, float _w);

    }
}
