--[[
    Note: The following string variables must be defined before including this file in the inclusion hierarchy:
        OUT_DIR: The output target directory
        INT_DIR: The intermediate target directory
        DOTNET_FRAMEWORK: The Premake "dotnetframework" version string
]]

project "CodeGenerator"
    kind "ConsoleApp"
    language "C#"
    csversion "latest"
    clr "unsafe"
    dotnetframework (DOTNET_FRAMEWORK)
    namespace "CodeGenerator"

    debugdir (OUT_DIR .. "/CodeGenerator")
    targetdir (OUT_DIR .. "/CodeGenerator")
    objdir (INT_DIR)

    files
    {
        "./*.cs",
        "./definitions/**.json"
    }

    nuget
    {
        "Newtonsoft.Json:13.0.3"
    }

    filter "system:windows"
        systemversion "latest"

    filter "files:**json"
        buildaction "Copy"
        dependson { } -- Ensure tracking
