using System;


namespace IntricateEngine.ImGui
{
    [Flags]
    public enum ImGuiLogFlags
    {
        None = 0,
        OutputTTY = 1,
        OutputFile = 2,
        OutputBuffer = 4,
        OutputClipboard = 8,
        OutputMask = 15,
    }
}
