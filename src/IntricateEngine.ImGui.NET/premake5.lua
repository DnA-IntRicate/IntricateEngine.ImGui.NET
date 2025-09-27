-- OUT_DIR and INT_DIR must be defined in the top-most premake file before including this file

project "IntricateEngine.ImGui.NET"
    kind "SharedLib"
    language "C#"
    csversion "latest"
    clr "unsafe"
    dotnetframework "net9.0"
    dotnetassemblyinfo "off"
    namespace "IntricateEngine"

    debugdir (OUT_DIR)
    targetdir (OUT_DIR)
    objdir (INT_DIR)

    files
    {
        "./Common/**.cs",
        "./ImGui/**.cs",
        "./ImGuizmo/**.cs",
        "./Properties/**.cs"
    }

    nuget
    {
        "System.Numerics.Vectors:4.5.0",
        "System.Runtime.CompilerServices.Unsafe:6.0.0",
        "System.Buffers:4.5.1"
    }

    filter "system:windows"
        systemversion "latest"
