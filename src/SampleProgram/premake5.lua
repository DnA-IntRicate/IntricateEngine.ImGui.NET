-- OUT_DIR and INT_DIR must be defined in the top-most premake file before including this file

project "SampleProgram"
    kind "ConsoleApp"
    language "C#"
    csversion "latest"
    clr "unsafe"
    dotnetframework "net9.0"
    namespace "IntricateEngine.ImGui"

    debugdir (OUT_DIR)
    targetdir (OUT_DIR)
    objdir (INT_DIR)

    files
    {
        "./*.cs",

        "./Shaders/GLSL/imgui-vertex.glsl",
        "./Shaders/GLSL/imgui-frag.glsl",
        "./Shaders/HLSL/imgui-vertex.hlsl.bytes",
        "./Shaders/HLSL/imgui-frag.hlsl.bytes",
        "./Shaders/SPIR-V/imgui-vertex.spv",
        "./Shaders/SPIR-V/imgui-frag.spv",
        "./Shaders/Metal/imgui-vertex.metallib",
        "./Shaders/Metal/imgui-frag.metallib"
    }

    nuget
    {
        "Veldrid:4.9.0",
        "Veldrid.StartupUtilities:4.9.0"
    }

    links
    {
        "IntricateEngine.ImGui.NET"
    }

    filter "system:windows"
        postbuildcommands
        {
            -- .NET SDK style projects insist on throwing everything into the net9.0 folder
            -- TODO: Figure out a way to stop this from happening (without doing copylocals)
            '{COPYFILE} "%{REPO_ROOT}/deps/cimgui/win-x64/cimgui.dll" "%{OUT_DIR}/net9.0"'
        }

    filter "system:linux"
        postbuildcommands
        {
            '{COPYFILE} "%{REPO_ROOT}/deps/cimgui/osx/cimgui.dylib" "%{OUT_DIR}/net9.0"'
        }

    filter "system:macosx"
        postbuildcommands
        {
            '{COPYFILE} "%{REPO_ROOT}/deps/cimgui/linux-x64/cimgui.so" "%{OUT_DIR}/net9.0"'
        }

    filter "files:Shaders/**"
        buildaction "Embed"
