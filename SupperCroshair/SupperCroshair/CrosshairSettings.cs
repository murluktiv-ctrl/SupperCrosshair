using System.Drawing;
using System.Collections.Generic;
using System; // добавь эту строку в самом верху

namespace CrosshairApp
{
    [Serializable] // ← ДОБАВЬ ЭТУ СТРОЧКУ
    public class CrosshairSettings
    {
        public Color Color { get; set; } = Color.Red;
        public int Thickness { get; set; } = 2;
        public int HorizontalLength { get; set; } = 25;
        public int VerticalLength { get; set; } = 25;
        public bool ShowCenterDot { get; set; } = true;
        public int CenterDotSize { get; set; } = 6;
        public bool CrosshairVisible { get; set; } = true;
        public bool ShowOutline { get; set; } = false;
        public Color OutlineColor { get; set; } = Color.Black;
        public int OutlineThickness { get; set; } = 1;
        public bool SyncLines { get; set; } = true;

        // Пресеты
        public List<CrosshairPreset> Presets { get; set; } = new List<CrosshairPreset>();

        public CrosshairSettings()
        {
            // Инициализируем 5 пустых пресетов
            for (int i = 0; i < 5; i++)
            {
                Presets.Add(new CrosshairPreset { Name = $"Preset {i + 1}" });
            }
        }

        public void SaveToPreset(int index, string name)
        {
            if (index >= 0 && index < Presets.Count)
            {
                Presets[index] = new CrosshairPreset
                {
                    Name = name,
                    Color = this.Color,
                    Thickness = this.Thickness,
                    HorizontalLength = this.HorizontalLength,
                    VerticalLength = this.VerticalLength,
                    ShowCenterDot = this.ShowCenterDot,
                    CenterDotSize = this.CenterDotSize,
                    ShowOutline = this.ShowOutline,
                    OutlineColor = this.OutlineColor,
                    OutlineThickness = this.OutlineThickness,
                    SyncLines = this.SyncLines
                };
            }
        }

        public void LoadFromPreset(int index)
        {
            if (index >= 0 && index < Presets.Count && Presets[index] != null)
            {
                var preset = Presets[index];
                this.Color = preset.Color;
                this.Thickness = preset.Thickness;
                this.HorizontalLength = preset.HorizontalLength;
                this.VerticalLength = preset.VerticalLength;
                this.ShowCenterDot = preset.ShowCenterDot;
                this.CenterDotSize = preset.CenterDotSize;
                this.ShowOutline = preset.ShowOutline;
                this.OutlineColor = preset.OutlineColor;
                this.OutlineThickness = preset.OutlineThickness;
                this.SyncLines = preset.SyncLines;
            }
        }
    }

    [Serializable] // ← ДОБАВЬ ЭТУ СТРОЧКУ
    public class CrosshairPreset
    {
        public string Name { get; set; } = "New Preset";
        public Color Color { get; set; } = Color.Red;
        public int Thickness { get; set; } = 2;
        public int HorizontalLength { get; set; } = 25;
        public int VerticalLength { get; set; } = 25;
        public bool ShowCenterDot { get; set; } = true;
        public int CenterDotSize { get; set; } = 6;
        public bool ShowOutline { get; set; } = false;
        public Color OutlineColor { get; set; } = Color.Black;
        public int OutlineThickness { get; set; } = 1;
        public bool SyncLines { get; set; } = true;
        public bool CrosshairVisible { get; set; } = true;
    }
}