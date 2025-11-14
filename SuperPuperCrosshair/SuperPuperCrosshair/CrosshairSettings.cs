using System.Drawing;

namespace CrosshairApp
{
    public class CrosshairSettings
    {
        public int DotSize { get; set; } = 4;
        public Color Color { get; set; } = Color.Red;
        public int HorizontalLength { get; set; } = 20;
        public int VerticalLength { get; set; } = 20;
        public int Thickness { get; set; } = 2;
    }
}