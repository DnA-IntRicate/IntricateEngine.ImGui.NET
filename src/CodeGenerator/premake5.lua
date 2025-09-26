-- OUT_DIR and INT_DIR must be defined in the top-most premake file before including this file

project "CodeGenerator"
    kind "ConsoleApp"
    language "C#"
    csversion "latest"
    clr "unsafe"
    dotnetframework "net9.0"
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
