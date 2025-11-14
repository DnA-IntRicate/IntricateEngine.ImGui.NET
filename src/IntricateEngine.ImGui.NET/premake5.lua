--[[
    Note: The following string variables must be defined before including this file in the inclusion hierarchy:
        OUT_DIR: The output target directory
        INT_DIR: The intermediate target directory
        DOTNET_FRAMEWORK: The Premake "dotnetframework" version string
]]

project "IntricateEngine.ImGui.NET"
    kind "SharedLib"
    language "C#"
    csversion "latest"
    clr "unsafe"
    dotnetframework (DOTNET_FRAMEWORK)
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

    filter "system:windows"
        systemversion "latest"
