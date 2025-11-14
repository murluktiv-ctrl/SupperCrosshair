using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace CrosshairApp
{
    public partial class SettingsForm : Form
    {
        private Form1 mainForm;
        private bool isEnglish = false;
        private int selectedPresetIndex = 0;
        private bool suppressNotifications = false;

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private const int HOTKEY_ID = 1;
        private const uint MOD_NONE = 0x0000;
        private const uint VK_F2 = 0x71;

        public SettingsForm(Form1 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            RegisterGlobalHotKey();
            CenterToScreen();
            CreateColorPalette();
            UpdateLanguage();

            FixAllClicks();
            LoadPresets();
            LoadAllSettings();
            SelectPreset(0);
        }

        private void FixAllClicks()
        {
            var allButtons = new List<Button>
            {
                btnTabCrosshair, btnTabParams, btnTabProgram,
                btnLanguage, btnLoadPreset, btnSavePreset, btnResetPreset,
                btnPreset1, btnPreset2, btnPreset3, btnPreset4, btnPreset5,
                btnOutlineColor, btnHide, btnExitApp
            };

            foreach (var button in allButtons)
            {
                button.MouseUp += (s, e) =>
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        System.Threading.Thread.Sleep(50);
                        button.PerformClick();
                    }
                };
            }

            var allCheckboxes = new List<CheckBox>
            {
                chkCrosshairVisible, chkSyncLines, chkShowOutline, chkShowDot
            };

            foreach (var checkbox in allCheckboxes)
            {
                checkbox.MouseUp += (s, e) =>
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        System.Threading.Thread.Sleep(50);
                        checkbox.Checked = !checkbox.Checked;
                    }
                };
            }
        }

        private string GetPresetsFilePath()
        {
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string appFolder = Path.Combine(appData, "CrosshairApp");
            if (!Directory.Exists(appFolder)) Directory.CreateDirectory(appFolder);
            return Path.Combine(appFolder, "presets.xml");
        }

        private void LoadPresets()
        {
            try
            {
                string filePath = GetPresetsFilePath();
                if (File.Exists(filePath))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<SerializableCrosshairPreset>));
                    using (FileStream stream = new FileStream(filePath, FileMode.Open))
                    {
                        var serializablePresets = (List<SerializableCrosshairPreset>)serializer.Deserialize(stream);

                        if (serializablePresets != null && serializablePresets.Count >= 5)
                        {
                            for (int i = 0; i < 5; i++)
                            {
                                mainForm.Settings.Presets[i] = serializablePresets[i].ToCrosshairPreset();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading presets: " + ex.Message);
            }
        }

        private void SavePresets()
        {
            try
            {
                string filePath = GetPresetsFilePath();
                var serializablePresets = new List<SerializableCrosshairPreset>();
                for (int i = 0; i < 5; i++)
                {
                    serializablePresets.Add(new SerializableCrosshairPreset(mainForm.Settings.Presets[i]));
                }

                XmlSerializer serializer = new XmlSerializer(typeof(List<SerializableCrosshairPreset>));
                using (FileStream stream = new FileStream(filePath, FileMode.Create))
                {
                    serializer.Serialize(stream, serializablePresets);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving presets: " + ex.Message);
            }
        }

        private void UpdatePresetButtons()
        {
            Button[] presetButtons = { btnPreset1, btnPreset2, btnPreset3, btnPreset4, btnPreset5 };

            for (int i = 0; i < presetButtons.Length; i++)
            {
                var preset = mainForm.Settings.Presets[i];

                presetButtons[i].Text = "";
                presetButtons[i].BackgroundImage = DrawMiniCrosshair(preset, presetButtons[i].Size);
                presetButtons[i].BackgroundImageLayout = ImageLayout.Center;

                if (i == selectedPresetIndex)
                {
                    presetButtons[i].BackColor = Color.FromArgb(100, 100, 150);
                    presetButtons[i].FlatAppearance.BorderColor = Color.Cyan;
                    presetButtons[i].FlatAppearance.BorderSize = 2;
                }
                else
                {
                    presetButtons[i].BackColor = Color.FromArgb(70, 70, 70);
                    presetButtons[i].FlatAppearance.BorderColor = Color.Gray;
                    presetButtons[i].FlatAppearance.BorderSize = 1;
                }
            }
        }

        private Bitmap DrawMiniCrosshair(CrosshairPreset preset, Size buttonSize)
        {
            Bitmap bmp = new Bitmap(buttonSize.Width, buttonSize.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Transparent);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                int centerX = buttonSize.Width / 2;
                int centerY = buttonSize.Height / 2;

                int thickness = Math.Max(2, preset.Thickness);
                int horizontal = Math.Max(3, preset.HorizontalLength / 2);
                int vertical = Math.Max(3, preset.VerticalLength / 2);
                int dotSize = Math.Max(2, preset.CenterDotSize / 2);

                if (preset.ShowOutline && preset.OutlineThickness > 0)
                {
                    using (Pen outlinePen = new Pen(preset.OutlineColor, thickness + preset.OutlineThickness))
                    {
                        g.DrawLine(outlinePen, centerX - horizontal, centerY, centerX + horizontal, centerY);
                        g.DrawLine(outlinePen, centerX, centerY - vertical, centerX, centerY + vertical);
                    }
                }

                using (Pen pen = new Pen(preset.Color, thickness))
                {
                    g.DrawLine(pen, centerX - horizontal, centerY, centerX + horizontal, centerY);
                    g.DrawLine(pen, centerX, centerY - vertical, centerX, centerY + vertical);
                }

                if (preset.ShowCenterDot && dotSize > 0)
                {
                    using (Brush brush = new SolidBrush(preset.Color))
                    {
                        g.FillEllipse(brush, centerX - dotSize / 2, centerY - dotSize / 2, dotSize, dotSize);
                    }
                }
            }
            return bmp;
        }

        private void LoadAllSettings()
        {
            if (mainForm?.Settings != null)
            {
                chkCrosshairVisible.Checked = mainForm.Settings.CrosshairVisible;

                numThickness.Value = Math.Max(numThickness.Minimum, Math.Min(numThickness.Maximum, mainForm.Settings.Thickness));
                trackThickness.Value = Math.Max(trackThickness.Minimum, Math.Min(trackThickness.Maximum, mainForm.Settings.Thickness));

                numHorizontal.Value = Math.Max(numHorizontal.Minimum, Math.Min(numHorizontal.Maximum, mainForm.Settings.HorizontalLength));
                trackHorizontal.Value = Math.Max(trackHorizontal.Minimum, Math.Min(trackHorizontal.Maximum, mainForm.Settings.HorizontalLength));

                numVertical.Value = Math.Max(numVertical.Minimum, Math.Min(numVertical.Maximum, mainForm.Settings.VerticalLength));
                trackVertical.Value = Math.Max(trackVertical.Minimum, Math.Min(trackVertical.Maximum, mainForm.Settings.VerticalLength));

                chkShowDot.Checked = mainForm.Settings.ShowCenterDot;
                numDotSize.Value = Math.Max(numDotSize.Minimum, Math.Min(numDotSize.Maximum, mainForm.Settings.CenterDotSize));
                trackDotSize.Value = Math.Max(trackDotSize.Minimum, Math.Min(trackDotSize.Maximum, mainForm.Settings.CenterDotSize));

                chkShowOutline.Checked = mainForm.Settings.ShowOutline;
                numOutline.Value = Math.Max(numOutline.Minimum, Math.Min(numOutline.Maximum, mainForm.Settings.OutlineThickness));
                trackOutline.Value = Math.Max(trackOutline.Minimum, Math.Min(trackOutline.Maximum, mainForm.Settings.OutlineThickness));

                chkSyncLines.Checked = mainForm.Settings.SyncLines;

                colorPreview.BackColor = mainForm.Settings.Color;
                btnOutlineColor.BackColor = mainForm.Settings.OutlineColor;
            }
        }

        private void CreateColorPalette()
        {
            Color[] colors = new Color[]
            {
                Color.Red, Color.Green, Color.Blue, Color.Yellow, Color.White,
                Color.Cyan, Color.Magenta, Color.Orange, Color.Lime, Color.Pink,
                Color.Purple, Color.Brown, Color.Gray, Color.LightBlue, Color.LightGreen
            };

            int x = 0, y = 0;
            int buttonSize = 30;

            foreach (Color color in colors)
            {
                Button colorButton = new Button();
                colorButton.BackColor = color;
                colorButton.FlatStyle = FlatStyle.Flat;
                colorButton.FlatAppearance.BorderSize = 1;
                colorButton.FlatAppearance.BorderColor = Color.White;
                colorButton.Size = new Size(buttonSize, buttonSize);
                colorButton.Location = new Point(x, y);
                colorButton.MouseUp += (s, e) =>
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        System.Threading.Thread.Sleep(50);
                        mainForm.Settings.Color = color;
                        colorPreview.BackColor = color;
                        mainForm.RefreshCrosshair();
                    }
                };

                pnlColors.Controls.Add(colorButton);

                x += buttonSize + 5;
                if (x + buttonSize > pnlColors.Width)
                {
                    x = 0;
                    y += buttonSize + 5;
                }
            }
        }

        private void UpdateLanguage()
        {
            if (isEnglish)
            {
                this.Text = "Crosshair Settings";
                btnTabCrosshair.Text = "Crosshair";
                btnTabParams.Text = "Parameters";
                btnTabProgram.Text = "Program";
                chkCrosshairVisible.Text = "Crosshair";
                lblPresets.Text = "Presets:";
                btnSavePreset.Text = "Save";
                btnLoadPreset.Text = "Load";
                btnResetPreset.Text = "Reset All";
                btnLanguage.Text = "RU"; // Изменено на RU
                lblThickness.Text = "Thickness:";
                lblHorizontal.Text = "Horizontal length:";
                lblVertical.Text = "Vertical length:";
                chkShowDot.Text = "Center dot";
                lblDotSize.Text = "Dot size:";
                chkShowOutline.Text = "Outline";
                lblOutline.Text = "Outline thickness:";
                btnOutlineColor.Text = "Color";
                chkSyncLines.Text = "Synchronize";
                btnHide.Text = "Hide settings";
                btnExitApp.Text = "Exit program";
            }
            else
            {
                this.Text = "Настройки прицела";
                btnTabCrosshair.Text = "Прицел";
                btnTabParams.Text = "Параметры";
                btnTabProgram.Text = "Программа";
                chkCrosshairVisible.Text = "Прицел";
                lblPresets.Text = "Пресеты:";
                btnSavePreset.Text = "Сохранить";
                btnLoadPreset.Text = "Загрузить";
                btnResetPreset.Text = "Сбросить все";
                btnLanguage.Text = "EN"; // Изменено на EN
                lblThickness.Text = "Толщина:";
                lblHorizontal.Text = "Длина горизонтали:";
                lblVertical.Text = "Длина вертикали:";
                chkShowDot.Text = "Центральная точка";
                lblDotSize.Text = "Размер точки:";
                chkShowOutline.Text = "Обводка";
                lblOutline.Text = "Толщина обводки:";
                btnOutlineColor.Text = "Цвет";
                chkSyncLines.Text = "Синхронизировать";
                btnHide.Text = "Скрыть настройки";
                btnExitApp.Text = "Выход из программы";
            }
        }

        private void RegisterGlobalHotKey()
        {
            if (!RegisterHotKey(this.Handle, HOTKEY_ID, MOD_NONE, VK_F2))
            {
                MessageBox.Show("Не удалось зарегистрировать горячую клавишу F2", "Ошибка");
            }
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;

            if (m.Msg == WM_HOTKEY)
            {
                if (m.WParam.ToInt32() == HOTKEY_ID)
                {
                    if (this.Visible)
                    {
                        this.Hide();
                    }
                    else
                    {
                        this.Show();
                        this.BringToFront();
                        this.Focus();
                    }
                }
            }

            base.WndProc(ref m);
        }

        private void btnTabCrosshair_Click(object sender, EventArgs e)
        {
            pnlCrosshair.Visible = true;
            pnlParams.Visible = false;
            pnlProgram.Visible = false;
        }

        private void btnTabParams_Click(object sender, EventArgs e)
        {
            pnlCrosshair.Visible = false;
            pnlParams.Visible = true;
            pnlProgram.Visible = false;
        }

        private void btnTabProgram_Click(object sender, EventArgs e)
        {
            pnlCrosshair.Visible = false;
            pnlParams.Visible = false;
            pnlProgram.Visible = true;
        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            isEnglish = !isEnglish;
            UpdateLanguage();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPreset1_Click(object sender, EventArgs e)
        {
            SelectPreset(0);
        }

        private void btnPreset2_Click(object sender, EventArgs e)
        {
            SelectPreset(1);
        }

        private void btnPreset3_Click(object sender, EventArgs e)
        {
            SelectPreset(2);
        }

        private void btnPreset4_Click(object sender, EventArgs e)
        {
            SelectPreset(3);
        }

        private void btnPreset5_Click(object sender, EventArgs e)
        {
            SelectPreset(4);
        }

        private void SelectPreset(int index)
        {
            selectedPresetIndex = index;
            var preset = mainForm.Settings.Presets[index];
            txtPresetName.Text = preset.Name;
            UpdatePresetButtons();
        }

        private void btnSavePreset_Click(object sender, EventArgs e)
        {
            if (suppressNotifications) return;

            if (mainForm?.Settings != null && !string.IsNullOrEmpty(txtPresetName.Text))
            {
                suppressNotifications = true;
                mainForm.Settings.SaveToPreset(selectedPresetIndex, txtPresetName.Text);
                UpdatePresetButtons();
                SavePresets();
                ShowSingleNotification("Пресет сохранен!", "Успех");
                suppressNotifications = false;
            }
        }

        private void btnLoadPreset_Click(object sender, EventArgs e)
        {
            if (suppressNotifications) return;

            if (mainForm?.Settings != null)
            {
                suppressNotifications = true;
                mainForm.Settings.LoadFromPreset(selectedPresetIndex);
                LoadAllSettings();
                mainForm.RefreshCrosshair();
                ShowSingleNotification("Пресет загружен!", "Успех");
                suppressNotifications = false;
            }
        }

        private void btnResetPreset_Click(object sender, EventArgs e)
        {
            if (suppressNotifications) return;

            var result = MessageBox.Show(
                "Вы уверены, что хотите сбросить ВСЕ пресеты к значениям по умолчанию?\nЭто действие нельзя отменить!",
                "Сброс пресетов",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                suppressNotifications = true;

                var defaultPreset = new CrosshairPreset
                {
                    Name = "Default",
                    Color = Color.Red,
                    Thickness = 2,
                    HorizontalLength = 25,
                    VerticalLength = 25,
                    ShowCenterDot = true,
                    CenterDotSize = 6,
                    ShowOutline = false,
                    OutlineColor = Color.Black,
                    OutlineThickness = 1,
                    SyncLines = true,
                    CrosshairVisible = true
                };

                for (int i = 0; i < 5; i++)
                {
                    mainForm.Settings.Presets[i] = new CrosshairPreset
                    {
                        Name = $"Preset {i + 1}",
                        Color = defaultPreset.Color,
                        Thickness = defaultPreset.Thickness,
                        HorizontalLength = defaultPreset.HorizontalLength,
                        VerticalLength = defaultPreset.VerticalLength,
                        ShowCenterDot = defaultPreset.ShowCenterDot,
                        CenterDotSize = defaultPreset.CenterDotSize,
                        ShowOutline = defaultPreset.ShowOutline,
                        OutlineColor = defaultPreset.OutlineColor,
                        OutlineThickness = defaultPreset.OutlineThickness,
                        SyncLines = defaultPreset.SyncLines,
                        CrosshairVisible = defaultPreset.CrosshairVisible
                    };
                }

                UpdatePresetButtons();
                SavePresets();
                SelectPreset(0);
                ShowSingleNotification("Все пресеты сброшены!", "Успех");
                suppressNotifications = false;
            }
        }

        private void btnOutlineColor_Click(object sender, EventArgs e)
        {
            if (suppressNotifications) return;

            suppressNotifications = true;

            colorDialog.Color = mainForm.Settings.OutlineColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                mainForm.Settings.OutlineColor = colorDialog.Color;
                btnOutlineColor.BackColor = colorDialog.Color;
                mainForm.RefreshCrosshair();
            }

            suppressNotifications = false;
        }

        private void ShowSingleNotification(string message, string title)
        {
            System.Threading.Thread.Sleep(50);
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void chkCrosshairVisible_CheckedChanged(object sender, EventArgs e)
        {
            if (mainForm != null)
            {
                mainForm.Settings.CrosshairVisible = chkCrosshairVisible.Checked;
                mainForm.SetCrosshairVisible(chkCrosshairVisible.Checked);
            }
        }

        private void chkSyncLines_CheckedChanged(object sender, EventArgs e)
        {
            if (mainForm != null)
            {
                mainForm.Settings.SyncLines = chkSyncLines.Checked;
                mainForm.RefreshCrosshair();
            }
        }

        private void trackOutline_Scroll(object sender, EventArgs e)
        {
            numOutline.Value = trackOutline.Value;
            if (mainForm != null)
            {
                mainForm.Settings.OutlineThickness = trackOutline.Value;
                mainForm.RefreshCrosshair();
            }
        }

        private void numOutline_ValueChanged(object sender, EventArgs e)
        {
            trackOutline.Value = (int)numOutline.Value;
            if (mainForm != null)
            {
                mainForm.Settings.OutlineThickness = (int)numOutline.Value;
                mainForm.RefreshCrosshair();
            }
        }

        private void chkShowOutline_CheckedChanged(object sender, EventArgs e)
        {
            if (mainForm != null)
            {
                mainForm.Settings.ShowOutline = chkShowOutline.Checked;
                mainForm.RefreshCrosshair();
            }
        }

        private void trackDotSize_Scroll(object sender, EventArgs e)
        {
            numDotSize.Value = trackDotSize.Value;
            if (mainForm != null)
            {
                mainForm.Settings.CenterDotSize = trackDotSize.Value;
                mainForm.RefreshCrosshair();
            }
        }

        private void numDotSize_ValueChanged(object sender, EventArgs e)
        {
            trackDotSize.Value = (int)numDotSize.Value;
            if (mainForm != null)
            {
                mainForm.Settings.CenterDotSize = (int)numDotSize.Value;
                mainForm.RefreshCrosshair();
            }
        }

        private void chkShowDot_CheckedChanged(object sender, EventArgs e)
        {
            if (mainForm != null)
            {
                mainForm.Settings.ShowCenterDot = chkShowDot.Checked;
                mainForm.RefreshCrosshair();
            }
        }

        private void trackVertical_Scroll(object sender, EventArgs e)
        {
            numVertical.Value = trackVertical.Value;
            if (mainForm != null && !mainForm.Settings.SyncLines)
            {
                mainForm.Settings.VerticalLength = trackVertical.Value;
                mainForm.RefreshCrosshair();
            }
        }

        private void numVertical_ValueChanged(object sender, EventArgs e)
        {
            trackVertical.Value = (int)numVertical.Value;
            if (mainForm != null && !mainForm.Settings.SyncLines)
            {
                mainForm.Settings.VerticalLength = (int)numVertical.Value;
                mainForm.RefreshCrosshair();
            }
        }

        private void trackHorizontal_Scroll(object sender, EventArgs e)
        {
            numHorizontal.Value = trackHorizontal.Value;
            if (mainForm != null)
            {
                mainForm.Settings.HorizontalLength = trackHorizontal.Value;
                if (mainForm.Settings.SyncLines)
                {
                    mainForm.Settings.VerticalLength = trackHorizontal.Value;
                    numVertical.Value = trackHorizontal.Value;
                    trackVertical.Value = trackHorizontal.Value;
                }
                mainForm.RefreshCrosshair();
            }
        }

        private void numHorizontal_ValueChanged(object sender, EventArgs e)
        {
            trackHorizontal.Value = (int)numHorizontal.Value;
            if (mainForm != null)
            {
                mainForm.Settings.HorizontalLength = (int)numHorizontal.Value;
                if (mainForm.Settings.SyncLines)
                {
                    mainForm.Settings.VerticalLength = (int)numHorizontal.Value;
                    numVertical.Value = numHorizontal.Value;
                    trackVertical.Value = (int)numHorizontal.Value;
                }
                mainForm.RefreshCrosshair();
            }
        }

        private void trackThickness_Scroll(object sender, EventArgs e)
        {
            numThickness.Value = trackThickness.Value;
            if (mainForm != null)
            {
                mainForm.Settings.Thickness = trackThickness.Value;
                mainForm.RefreshCrosshair();
            }
        }

        private void numThickness_ValueChanged(object sender, EventArgs e)
        {
            trackThickness.Value = (int)numThickness.Value;
            if (mainForm != null)
            {
                mainForm.Settings.Thickness = (int)numThickness.Value;
                mainForm.RefreshCrosshair();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
            base.OnFormClosing(e);
        }

        protected override void OnClosed(EventArgs e)
        {
            UnregisterHotKey(this.Handle, HOTKEY_ID);
            base.OnClosed(e);
        }
    }

    [Serializable]
    public class SerializableCrosshairPreset
    {
        public string Name { get; set; }
        public int ColorArgb { get; set; }
        public int Thickness { get; set; }
        public int HorizontalLength { get; set; }
        public int VerticalLength { get; set; }
        public bool ShowCenterDot { get; set; }
        public int CenterDotSize { get; set; }
        public bool ShowOutline { get; set; }
        public int OutlineColorArgb { get; set; }
        public int OutlineThickness { get; set; }
        public bool SyncLines { get; set; }
        public bool CrosshairVisible { get; set; }

        public SerializableCrosshairPreset() { }

        public SerializableCrosshairPreset(CrosshairPreset preset)
        {
            Name = preset.Name;
            ColorArgb = preset.Color.ToArgb();
            Thickness = preset.Thickness;
            HorizontalLength = preset.HorizontalLength;
            VerticalLength = preset.VerticalLength;
            ShowCenterDot = preset.ShowCenterDot;
            CenterDotSize = preset.CenterDotSize;
            ShowOutline = preset.ShowOutline;
            OutlineColorArgb = preset.OutlineColor.ToArgb();
            OutlineThickness = preset.OutlineThickness;
            SyncLines = preset.SyncLines;
            CrosshairVisible = preset.CrosshairVisible;
        }

        public CrosshairPreset ToCrosshairPreset()
        {
            return new CrosshairPreset
            {
                Name = this.Name,
                Color = Color.FromArgb(this.ColorArgb),
                Thickness = this.Thickness,
                HorizontalLength = this.HorizontalLength,
                VerticalLength = this.VerticalLength,
                ShowCenterDot = this.ShowCenterDot,
                CenterDotSize = this.CenterDotSize,
                ShowOutline = this.ShowOutline,
                OutlineColor = Color.FromArgb(this.OutlineColorArgb),
                OutlineThickness = this.OutlineThickness,
                SyncLines = this.SyncLines,
                CrosshairVisible = this.CrosshairVisible
            };
        }
    }
}