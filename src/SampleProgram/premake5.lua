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

    filter "files:Shaders/**"
        buildaction "Embed"
