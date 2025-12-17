using System.Collections.Generic;


namespace CodeGenerator
{
    internal class TypeInfo
    {
        public static readonly Dictionary<string, string> WellKnownTypes = new Dictionary<string, string>()
        {
            { "bool", "byte" },
            { "unsigned char", "byte" },
            { "signed char", "sbyte" },
            { "char", "byte" },
            { "ImWchar", "ushort" },
            { "ImFileHandle", "nint" },
            { "ImU8", "byte" },
            { "ImS8", "sbyte" },
            { "ImU16", "ushort" },
            { "ImS16", "short" },
            { "ImU32", "uint" },
            { "ImS32", "int" },
            { "ImU64", "ulong" },
            { "ImS64", "long" },
            { "unsigned short", "ushort" },
            { "unsigned int", "uint" },
            { "ImVec2", "ImVec2" },
            { "ImVec2_Simple", "ImVec2" },
            { "ImVec2_c", "ImVec2" },
            { "ImVec2i_c", "ImVec2i"},
            { "ImVec2ih_c", "ImVec2ih"},
            { "ImVec3", "ImVec3" },
            { "ImVec3_c", "ImVec3" },
            { "ImVec4", "ImVec4" },
            { "ImWchar16", "ushort" }, // char is not blittable
            { "ImVec4_Simple", "ImVec4" },
            { "ImVec4_c", "ImVec4" },
            { "ImColor_Simple", "ImColor" },
            { "ImColor_c", "ImColor" },
            { "ImTextureID", "nint" },
            { "ImTextureRef_c", "ImTextureRef" },
            { "ImGuiID", "uint" },
            { "ImDrawIdx", "ushort" },
            { "ImDrawListSharedData", "nint" },
            { "ImDrawListSharedData*", "nint" },
            { "ImDrawCallback", "nint" },
            { "size_t", "uint" },
            { "ImGuiContext*", "nint" },
            { "ImPlotContext*", "nint" },
            { "EditorContext*", "nint" },
            { "ImGuiMemAllocFunc", "nint" },
            { "ImGuiMemFreeFunc", "nint" },
            { "ImFontBuilderIO", "nint" },
            { "float[2]", "ImVec2*" },
            { "float[3]", "ImVec3*" },
            { "float[4]", "ImVec4*" },
            { "int[2]", "int*" },
            { "int[3]", "int*" },
            { "int[4]", "int*" },
            { "float&", "float*" },
            { "ImVec2[2]", "ImVec2*" },
            { "char* []", "byte**" },
            { "char[5]", "byte*" },
            { "unsigned char[256]", "byte*"},
            { "ImPlotFormatter", "nint" },
            { "ImPlotGetter", "nint" },
            { "ImPlotTransform", "nint" },
            { "ImGuiKeyChord", "ImGuiKey" },
            { "ImGuiSelectionUserData", "long" },
            { "ImGuiFreeTypeLoaderFlags*", "nint"},
            { "ImRect", "ImRect" },
            // { "ImRect*", "nint" },
            { "ImRect_c", "ImRect" },
            { "ImGuiDir*", "nint" },
            { "ImFontAtlasRectId", "int" }
        };
        
        public static readonly List<string> WellKnownEnums = [ "ImGuiMouseButton" ];

        public static readonly Dictionary<string, string> AlternateEnumPrefixes = new Dictionary<string, string>()
        {
            { "ImGuiKey", "ImGuiMod" }
        };

        public static readonly Dictionary<string, string> AlternateEnumPrefixSubstitutions = new Dictionary<string, string>()
        {
            { "ImGuiMod_", "Mod" }
        };

        public static readonly Dictionary<string, string> WellKnownFieldReplacements = new Dictionary<string, string>()
        {
            { "bool", "bool" } // Force bool to remain as bool in type-safe wrappers.
        };

        public static readonly HashSet<string> CustomDefinedTypes =
        [
            "ImVector",
            "ImVec2",
            "ImVec3",
            "ImVec4",
            // "ImRect",
            "ImGuiStoragePair"
        ];

        public static readonly Dictionary<string, string> WellKnownDefaultValues = new Dictionary<string, string>()
        {
            { "((void *)0)", "null" },
            { "((void*)0)", "null" },
            { "NULL", "null"},
            { "nullptr", "null"},
            { "ImVec2(0,0)", "new ImVec2()" },
            { "ImVec2(0.0f,0.0f)", "new ImVec2()" },
            { "ImVec2(-FLT_MIN,0)", "new ImVec2(-float.MinValue, 0.0f)" },
            { "ImVec2(-1,0)", "new ImVec2(-1, 0)" },
            { "ImVec2(1,0)", "new ImVec2(1, 0)" },
            { "ImVec2(1,1)", "new ImVec2(1, 1)" },
            { "ImVec2(0,1)", "new ImVec2(0, 1)" },
            { "ImVec4(0,0,0,0)", "new ImVec4()" },
            { "ImVec4(1,1,1,1)", "new ImVec4(1, 1, 1, 1)" },
            { "ImVec4(0,0,0,-1)", "new ImVec4(0, 0, 0, -1)" },
            { "ImPlotPoint(0,0)", "new ImPlotPoint { x = 0, y = 0 }" },
            { "ImPlotPoint(1,1)", "new ImPlotPoint { x = 1, y = 1 }" },
            { "ImDrawCornerFlags_All", "ImDrawCornerFlags.All" },
            { "ImPlotFlags_None", "ImPlotFlags.None"},
            { "ImPlotAxisFlags_None", "ImPlotAxisFlags.None"},
            { "ImPlotAxisFlags_NoGridLines", "ImPlotAxisFlags.NoGridLines"},
            { "ImGuiCond_Once", "ImGuiCond.Once"},
            { "ImPlotOrientation_Vertical", "ImPlotOrientation.Vertical"},
            { "PinShape_CircleFilled", "PinShape.CircleFilled"},
            { "ImGuiPopupFlags_None", "ImGuiPopupFlags.None"},
            { "ImGuiNavHighlightFlags_TypeDefault", "ImGuiNavHighlightFlags.TypeDefault"},
            { "ImGuiKeyModFlags_Ctrl", "ImGuiKeyModFlags.Ctrl"},
            { "ImPlotYAxis_1", "ImPlotYAxis._1"},
            { "FLT_MAX", "float.MaxValue" },
            { "(((ImU32)(255)<<24)|((ImU32)(255)<<16)|((ImU32)(255)<<8)|((ImU32)(255)<<0))", "0xFFFFFFFF" },
            { "sizeof(ImU8)", "sizeof(byte)"},
            { "sizeof(ImS8)", "sizeof(sbyte)"},
            { "sizeof(ImU16)", "sizeof(ushort)"},
            { "sizeof(ImS16)", "sizeof(short)"},
            { "sizeof(ImU32)", "sizeof(uint)"},
            { "sizeof(ImS32)", "sizeof(int)"},
            { "sizeof(ImU64)", "sizeof(ulong)"},
            { "sizeof(ImS64)", "sizeof(long)"},
            { "ImPlotBin_Sturges", "(int)ImPlotBin.Sturges" },
            { "ImPlotRect()", "new ImPlotRect()" },
            { "ImPlotCond_Once", "ImPlotCond.Once" },
            { "ImPlotRange()", "new ImPlotRange()" },
            { "ImGuiTypingSelectFlags_None", "ImGuiTypingSelectFlags.None" } // TODO(Adam): Eh?
        };

        public static readonly Dictionary<string, string> IdentifierReplacements = new Dictionary<string, string>()
        {
            { "in", "@in" },
            { "out", "@out" },
            { "ref", "@ref" }
        };

        public static readonly HashSet<string> LegalFixedTypes =
        [
            "byte",
            "sbyte",
            "char",
            "ushort",
            "short",
            "uint",
            "int",
            "ulong",
            "long",
            "float",
            "double"
        ];

        public static readonly HashSet<string> SkippedFunctions =
        [
            "igInputText",
            "igInputTextMultiline",
            "igInputTextWithHint"// ,

            // Weird functions
            // "FindBestWindowPosForPopupEx",

            // Fonts
            // Freetype
        ];
    }
}
