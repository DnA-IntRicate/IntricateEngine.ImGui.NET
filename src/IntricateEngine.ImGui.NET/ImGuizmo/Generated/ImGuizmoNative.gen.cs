using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using IntricateEngine.ImGui;


namespace IntricateEngine.ImGuizmo
{
    public static unsafe partial class ImGuizmoNative
    {
        [LibraryImport("IntricateEngine", EntryPoint = "ImGuizmo_AllowAxisFlip")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuizmo_AllowAxisFlip(byte value);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuizmo_BeginFrame")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuizmo_BeginFrame();

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuizmo_DecomposeMatrixToComponents")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuizmo_DecomposeMatrixToComponents(float* matrix, float* translation, float* rotation, float* scale);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuizmo_DrawCubes")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuizmo_DrawCubes(float* view, float* projection, float* matrices, int matrixCount);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuizmo_DrawGrid")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuizmo_DrawGrid(float* view, float* projection, float* matrix, float gridSize);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuizmo_Enable")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuizmo_Enable(byte enable);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuizmo_IsOverNil")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte ImGuizmo_IsOverNil();

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuizmo_IsOverOPERATION")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte ImGuizmo_IsOverOPERATION(OPERATION op);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuizmo_IsUsing")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte ImGuizmo_IsUsing();

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuizmo_Manipulate")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial byte ImGuizmo_Manipulate(float* view, float* projection, OPERATION operation, MODE mode, float* matrix, float* deltaMatrix, float* snap, float* localBounds, float* boundsSnap);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuizmo_RecomposeMatrixFromComponents")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuizmo_RecomposeMatrixFromComponents(float* translation, float* rotation, float* scale, float* matrix);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuizmo_SetDrawlist")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuizmo_SetDrawlist(ImDrawList* drawlist);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuizmo_SetGizmoSizeClipSpace")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuizmo_SetGizmoSizeClipSpace(float value);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuizmo_SetID")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuizmo_SetID(int id);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuizmo_SetImGuiContext")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuizmo_SetImGuiContext(IntPtr ctx);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuizmo_SetOrthographic")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuizmo_SetOrthographic(byte isOrthographic);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuizmo_SetRect")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuizmo_SetRect(float x, float y, float width, float height);

        [LibraryImport("IntricateEngine", EntryPoint = "ImGuizmo_ViewManipulate")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial void ImGuizmo_ViewManipulate(float* view, float length, Vector2 position, Vector2 size, uint backgroundColor);

    }
}
