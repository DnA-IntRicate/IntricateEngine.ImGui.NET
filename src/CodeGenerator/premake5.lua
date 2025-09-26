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

    postbuildcommands
    {
        -- .NET SDK style projects insist on throwing everything into the net9.0 folder
        -- TODO: Figure out a way to stop this from happening (without doing copylocals)
        '{COPYDIR} "./definitions" "%{OUT_DIR}/CodeGenerator/net9.0/definitions"'
    }

    filter "system:windows"
        systemversion "latest"

    filter "files:**json"
        buildaction "None"
        dependson { } -- Ensure tracking
