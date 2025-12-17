using System;


namespace IntricateEngine.ImGui
{
    [Flags]
    public enum ImFontFlags
    {
        None = 0,
        NoLoadError = 2,
        NoLoadGlyphs = 4,
        LockBakedSizes = 8,
    }
}
