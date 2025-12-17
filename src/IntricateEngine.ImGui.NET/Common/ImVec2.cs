using System;
using System.Runtime.InteropServices;


namespace IntricateEngine.ImGui
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct ImVec2
    {
        public ImVec2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public ImVec2(float value)
        {
            this.x = value;
            this.y = value;
        }

        public ImVec2()
        {
            x = 0.0f;
            y = 0.0f;
        }

        public float x;
        public float y;
    }
}
