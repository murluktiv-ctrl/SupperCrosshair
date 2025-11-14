using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrosshairApp
{
    public partial class SettingsForm : Form
    {
        private CrosshairSettings settings;
        public event EventHandler SettingsChanged;

        public SettingsForm(CrosshairSettings settings)
        {
            InitializeComponent();
            this.settings = settings;
            InitializeControls();
        }

        private void InitializeControls()
        {
            this.Text = "Crosshair Settings";
            this.Size = new Size(300, 400);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);

            // Размер точки
            var lblDotSize = new Label { Text = "Dot Size:", Location = new Point(10, 20), Width = 100 };
            var trackDotSize = new TrackBar { Location = new Point(10, 40), Width = 250, Minimum = 1, Maximum = 20, Value = settings.DotSize };

            // Цвет
            var lblColor = new Label { Text = "Color:", Location = new Point(10, 80), Width = 100 };
            var btnColor = new Button { Text = "Choose Color", Location = new Point(10, 100), Width = 100 };
            var colorPanel = new Panel { Location = new Point(120, 100), Size = new Size(50, 20), BackColor = settings.Color };

            // Горизонтальная длина
            var lblHorizontal = new Label { Text = "Horizontal Length:", Location = new Point(10, 130), Width = 120 };
            var trackHorizontal = new TrackBar { Location = new Point(10, 150), Width = 250, Minimum = 0, Maximum = 100, Value = settings.HorizontalLength };

            // Вертикальная длина
            var lblVertical = new Label { Text = "Vertical Length:", Location = new Point(10, 180), Width = 120 };
            var trackVertical = new TrackBar { Location = new Point(10, 200), Width = 250, Minimum = 0, Maximum = 100, Value = settings.VerticalLength };

            // Толщина
            var lblThickness = new Label { Text = "Thickness:", Location = new Point(10, 230), Width = 100 };
            var trackThickness = new TrackBar { Location = new Point(10, 250), Width = 250, Minimum = 1, Maximum = 10, Value = settings.Thickness };

            // Кнопка применения
            var btnApply = new Button { Text = "Apply", Location = new Point(10, 300), Width = 100 };

            // Добавляем контролы на форму
            this.Controls.AddRange(new Control[] {
                lblDotSize, trackDotSize,
                lblColor, btnColor, colorPanel,
                lblHorizontal, trackHorizontal,
                lblVertical, trackVertical,
                lblThickness, trackThickness,
                btnApply
            });

            // Обработчики событий
            btnColor.Click += (s, e) =>
            {
                var colorDialog = new ColorDialog { Color = settings.Color };
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    settings.Color = colorDialog.Color;
                    colorPanel.BackColor = colorDialog.Color;
                }
            };

            btnApply.Click += (s, e) =>
            {
                settings.DotSize = trackDotSize.Value;
                settings.HorizontalLength = trackHorizontal.Value;
                settings.VerticalLength = trackVertical.Value;
                settings.Thickness = trackThickness.Value;

                SettingsChanged?.Invoke(this, EventArgs.Empty);
            };
        }
    }
}