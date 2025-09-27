include "../vendor/premake/customization/dotnetassemblyinfo.lua"
include "../vendor/premake/customization/solutionitems.lua"
include "../vendor/premake/customization/projectproperties.lua"

REPO_ROOT = "../.."
OUT_DIR = "%{REPO_ROOT}/bin/%{cfg.buildcfg}"
INT_DIR = "%{REPO_ROOT}/bin/obj/%{cfg.buildcfg}/%{prj.name}"

workspace "IntricateEngine.ImGui.NET"
    startproject "SampleProgram"

    configurations
    {
        "Debug",
        "Release"
    }

    platforms
    {
        "x64"
    }

    solutionitems
    {
        ".editorconfig"
    }

    flags
    {
        "MultiProcessorCompile"
    }

    filter "platforms:x64"
        system "windows"
        architecture "x86_64"

    filter "system:windows"
        systemversion "latest"
        staticruntime "Off"

    filter "system:linux"
        systemversion "latest"
        pic "On"
        staticruntime "Off"

    filter "system:macosx"
        systemversion "latest"
        pic "On"
        staticruntime "Off"

    filter "configurations:Debug"
        runtime "Debug"
        symbols "Full"

    filter "configurations:Release"
        runtime "Release"
        symbols "Off"
        optimize "Full"
        linktimeoptimization "on"

        flags
        {
            "NoBufferSecurityCheck",
            "NoRuntimeChecks",
            "NoIncrementalLink"
        }

CIMGUI_PROJ = ""
include "CodeGenerator"
include "SampleProgram"
include "IntricateEngine.ImGui.NET"
include "IntricateEngine.ImGuizmo.NET"
