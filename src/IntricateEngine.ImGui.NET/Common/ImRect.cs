using System;
using System.Runtime.InteropServices;


namespace IntricateEngine.ImGui
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct ImRect
    {
        public ImRect()
        {
            Min = new ImVec2(0.0f, 0.0f);
            Max = new ImVec2(0.0f, 0.0f);
        }

        public ImRect(ImVec2 min, ImVec2 max)
        {
            Min = min;
            Max = max;
        }

        public ImRect(ImVec4 v)
        {
            Min = new ImVec2(v.x, v.y);
            Max = new ImVec2(v.z, v.w);
        }

        public ImRect(float x1, float y1, float x2, float y2)
        {
            Min = new ImVec2(x1, y1);
            Max = new ImVec2(x2, y2);
        }

        public readonly bool Contains(ImVec2 p) => (p.x >= Min.x) && (p.y >= Min.y) && (p.x < Max.x) && (p.y < Max.y);
        public readonly bool Contains(ImRect r) => (r.Min.x >= Min.x) && (r.Min.y >= Min.y) && (r.Max.x <= Max.x) && (r.Max.y <= Max.y);
        public readonly bool ContainsWithPad(ImVec2 p, ImVec2 pad)
            => (p.x >= Min.x - pad.x) && (p.y >= Min.y - pad.y) && (p.x < Max.x + pad.x) && (p.y < Max.y + pad.y);

        public readonly bool Overlaps(ImRect r) => ((r.Min.y < Max.y) && (r.Max.y > Min.y) && (r.Min.x < Max.x) && (r.Max.x > Min.x));

        public void Add(ImVec2 p)
        {
            _ = (
                (Min.x > p.x ? Min.x = p.x : Min.x),
                (Min.y > p.y ? Min.y = p.y : Min.y),
                (Max.x < p.x ? Max.x = p.x : Max.x),
                (Max.y < p.y ? Max.y = p.y : Max.y)
            );
        }

        public void Add(ImRect r) =>
            _ = (
                (Min.x > r.Min.x ? Min.x = r.Min.x : Min.x),
                (Min.y > r.Min.y ? Min.y = r.Min.y : Min.y),
                (Max.x < r.Max.x ? Max.x = r.Max.x : Max.x),
                (Max.y < r.Max.y ? Max.y = r.Max.y : Max.y)
            );

        public void Expand(float amount) =>
            _ = (
                Min.x -= amount,
                Min.y -= amount,
                Max.x += amount,
                Max.y += amount
            );

        public void Expand(ImVec2 amount) =>
            _ = (
                Min.x -= amount.x,
                Min.y -= amount.y,
                Max.x += amount.x,
                Max.y += amount.y
            );

        public void Translate(ImVec2 d) =>
            _ = (
                Min.x += d.x,
                Min.y += d.y,
                Max.x += d.x,
                Max.y += d.y
            );

        public void TranslateX(float dx) =>
            _ = (Min.x += dx, Max.x += dx);

        public void TranslateY(float dy) =>
            _ = (Min.y += dy, Max.y += dy);

        // public void ClipWith(ImRect r) =>
        //     _ = (
        //         Min = ImMax(Min, r.Min),
        //         Max = ImMin(Max, r.Max)
        //     );
        // 
        // public void ClipWithFull(ImRect r) =>
        //     _ = (
        //         Min = ImClamp(Min, r.Min, r.Max),
        //         Max = ImClamp(Max, r.Min, r.Max)
        //     );

        public void Floor() =>
            _ = (
                Min.x = (float)(int)(Min.x),
                Min.y = (float)(int)(Min.y),
                Max.x = (float)(int)(Max.x),
                Max.y = (float)(int)(Max.y)
            );

        public readonly ImVec4 ToVec4() => new ImVec4(Min.x, Min.y, Max.x, Max.y);

        public readonly ImVec2 Center => new ImVec2((Min.x + Max.x) * 0.5f, (Min.y + Max.y) * 0.5f);
        public readonly ImVec2 Size => new ImVec2(Max.x - Min.x, Max.y - Min.y);

        public readonly ImVec2 TopLeft => Min;
        public readonly ImVec2 TopRight => new ImVec2(Max.x, Min.y);
        public readonly ImVec2 BottomLeft => new ImVec2(Min.x, Max.y);
        public readonly ImVec2 BottomRight => Max;

        public readonly float Width => Max.x - Min.x;
        public readonly float Height => Max.y - Min.y;
        public readonly float Area => (Max.x - Min.x) * (Max.y - Min.y);

        public readonly bool IsInverted => (Min.x > Max.x) || (Min.y > Max.y);

        public ImVec2 Min;    // Upper-left
        public ImVec2 Max;    // Lower-right
    }
}
