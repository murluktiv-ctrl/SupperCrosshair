using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrosshairApp
{
    public partial class Form1 : Form
    {
        public CrosshairSettings Settings { get; set; }
        private SettingsForm settingsForm;
        private bool isCrosshairVisible = true;
        private Timer focusTimer;

        public Form1()
        {
            InitializeComponent();
            Settings = new CrosshairSettings();
            settingsForm = new SettingsForm(this);
            InitializeForm();
        }

        private void InitializeForm()
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.DoubleBuffered = true;

            // Используем более надежный метод прозрачности
            this.BackColor = Color.Black;
            this.TransparencyKey = Color.Black;

            this.ShowInTaskbar = false;
            this.TopLevel = true;

            // Улучшаем обработку клавиш
            this.KeyPreview = true;

            // Таймер для поддержания фокуса
            focusTimer = new Timer();
            focusTimer.Interval = 100;
            focusTimer.Tick += (s, e) => {
                if (!this.Focused)
                {
                    this.Focus();
                }
            };
            focusTimer.Start();

            this.Paint += Form1_Paint;
            this.KeyDown += Form1_KeyDown;
            this.Load += Form1_Load;
            this.Shown += Form1_Shown;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Убедимся что форма получает фокус
            this.Focus();
            this.BringToFront();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Focus();
            this.BringToFront();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (isCrosshairVisible)
            {
                DrawCrosshair(e.Graphics);
            }
        }

        private void DrawCrosshair(Graphics g)
        {
            int centerX = this.Width / 2;
            int centerY = this.Height / 2;

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Обводка линий
            if (Settings.ShowOutline && Settings.OutlineThickness > 0)
            {
                using (Pen outlinePen = new Pen(Settings.OutlineColor, Settings.Thickness + Settings.OutlineThickness * 2))
                {
                    outlinePen.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;

                    int horizontalLength = Settings.HorizontalLength;
                    int verticalLength = Settings.SyncLines ? Settings.HorizontalLength : Settings.VerticalLength;

                    g.DrawLine(outlinePen,
                        centerX - horizontalLength,
                        centerY,
                        centerX + horizontalLength,
                        centerY);

                    g.DrawLine(outlinePen,
                        centerX,
                        centerY - verticalLength,
                        centerX,
                        centerY + verticalLength);
                }
            }

            // Основные линии
            using (Pen pen = new Pen(Settings.Color, Settings.Thickness))
            {
                pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;

                int horizontalLength = Settings.HorizontalLength;
                int verticalLength = Settings.SyncLines ? Settings.HorizontalLength : Settings.VerticalLength;

                g.DrawLine(pen,
                    centerX - horizontalLength,
                    centerY,
                    centerX + horizontalLength,
                    centerY);

                g.DrawLine(pen,
                    centerX,
                    centerY - verticalLength,
                    centerX,
                    centerY + verticalLength);
            }

            // Центральная точка
            if (Settings.ShowCenterDot && Settings.CenterDotSize > 0)
            {
                int dotSize = Settings.CenterDotSize;

                // Обводка точки
                if (Settings.ShowOutline && Settings.OutlineThickness > 0)
                {
                    using (Brush outlineBrush = new SolidBrush(Settings.OutlineColor))
                    {
                        g.FillEllipse(outlineBrush,
                            centerX - dotSize / 2 - Settings.OutlineThickness,
                            centerY - dotSize / 2 - Settings.OutlineThickness,
                            dotSize + Settings.OutlineThickness * 2,
                            dotSize + Settings.OutlineThickness * 2);
                    }
                }

                // Основная точка
                using (Brush brush = new SolidBrush(Settings.Color))
                {
                    g.FillEllipse(brush,
                        centerX - dotSize / 2,
                        centerY - dotSize / 2,
                        dotSize,
                        dotSize);
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Добавляем больше клавиш для вызова меню
            if (e.KeyCode == Keys.Oemtilde || e.KeyCode == Keys.F2 ||
                e.KeyCode == Keys.F12 || e.KeyCode == Keys.F9 ||
                e.KeyCode == Keys.F10 || e.KeyCode == Keys.F11)
            {
                ToggleSettings();
                e.Handled = true; // Предотвращаем передачу клавиши дальше
            }
            else if (e.KeyCode == Keys.Escape)
            {
                // Esc для выхода
                Application.Exit();
            }
        }

        private void ToggleSettings()
        {
            if (settingsForm == null || settingsForm.IsDisposed)
            {
                settingsForm = new SettingsForm(this);
            }

            if (settingsForm.Visible)
            {
                settingsForm.Hide();
                this.Focus(); // Возвращаем фокус на прицел
            }
            else
            {
                settingsForm.Show();
                settingsForm.BringToFront();
                settingsForm.Focus();
            }
        }

        public void RefreshCrosshair()
        {
            this.Invalidate();
        }

        public void SetCrosshairVisible(bool visible)
        {
            isCrosshairVisible = visible;
            this.Invalidate();
        }

        // Улучшенный метод для работы в играх
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x20; // WS_EX_TRANSPARENT
                cp.ExStyle |= 0x80; // WS_EX_TOOLWINDOW (не показывает в Alt+Tab)
                cp.ExStyle |= 0x00000008; // WS_EX_TOPMOST
                return cp;
            }
        }

        protected override void OnDeactivate(EventArgs e)
        {
            base.OnDeactivate(e);
            // Всегда остаемся поверх других окон
            this.TopMost = true;
        }

        // УБЕРИТЕ ЭТОТ МЕТОД - он уже есть в Form1.Designer.cs
        // protected override void Dispose(bool disposing)
        // {
        //     if (disposing)
        //     {
        //         focusTimer?.Stop();
        //         focusTimer?.Dispose();
        //     }
        //     base.Dispose(disposing);
        // }
    }
}