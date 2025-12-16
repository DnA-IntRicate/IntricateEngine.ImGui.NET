using System;
using System.Runtime.InteropServices;


namespace IntricateEngine.ImGui
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct ImVec3
    {
        public ImVec3(float x, float y, float z = 0.0f)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public ImVec3()
        {
            x = 0.0f;
            y = 0.0f;
            z = 0.0f;
        }

        public float x;
        public float y;
        public float z;
    }
}
