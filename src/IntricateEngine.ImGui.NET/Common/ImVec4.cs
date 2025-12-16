using System;
using System.Runtime.InteropServices;


namespace IntricateEngine.ImGui
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct ImVec4
    {
        public ImVec4(float x, float y, float z, float w = 1.0f)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public ImVec4()
        {
            x = 0.0f;
            y = 0.0f;
            z = 0.0f;
            w = 0.0f;
        }

        public float x;
        public float y;
        public float z;
        public float w;
    }
}
