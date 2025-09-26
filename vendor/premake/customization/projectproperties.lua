-- Originally copied from: https://github.com/premake/premake-core/issues/1963

require "vstudio"

local function platformsElement(cfg)
    _p(2,'<Platforms>x64</Platforms>')
end

premake.override(premake.vstudio.cs2005.elements, "projectProperties", function (oldfn, cfg)
    return table.join(oldfn(cfg), {
    platformsElement,
    })
end)
