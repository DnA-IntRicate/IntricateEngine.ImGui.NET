--[[
    This file is tailored for including in the Intricate Engine build system

    Note: The following string variables must be defined before including this file in the inclusion hierarchy:
        OUT_DIR: The output target directory
        INT_DIR: The intermediate target directory
        DOTNET_FRAMEWORK: The Premake "dotnetframework" version string
]]

include "src/IntricateEngine.ImGui.NET"

