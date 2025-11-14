namespace CrosshairApp
{
    partial class SettingsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnlTabs = new System.Windows.Forms.Panel();
            this.btnTabProgram = new System.Windows.Forms.Button();
            this.btnTabParams = new System.Windows.Forms.Button();
            this.btnTabCrosshair = new System.Windows.Forms.Button();
            this.pnlCrosshair = new System.Windows.Forms.Panel();
            this.btnResetPreset = new System.Windows.Forms.Button();
            this.btnLanguage = new System.Windows.Forms.Button();
            this.btnLoadPreset = new System.Windows.Forms.Button();
            this.btnSavePreset = new System.Windows.Forms.Button();
            this.txtPresetName = new System.Windows.Forms.TextBox();
            this.lblPresets = new System.Windows.Forms.Label();
            this.btnPreset5 = new System.Windows.Forms.Button();
            this.btnPreset4 = new System.Windows.Forms.Button();
            this.btnPreset3 = new System.Windows.Forms.Button();
            this.btnPreset2 = new System.Windows.Forms.Button();
            this.btnPreset1 = new System.Windows.Forms.Button();
            this.pnlColors = new System.Windows.Forms.Panel();
            this.colorPreview = new System.Windows.Forms.Panel();
            this.chkCrosshairVisible = new System.Windows.Forms.CheckBox();
            this.pnlParams = new System.Windows.Forms.Panel();
            this.btnOutlineColor = new System.Windows.Forms.Button();
            this.lblOutline = new System.Windows.Forms.Label();
            this.numOutline = new System.Windows.Forms.NumericUpDown();
            this.trackOutline = new System.Windows.Forms.TrackBar();
            this.chkShowOutline = new System.Windows.Forms.CheckBox();
            this.lblDotSize = new System.Windows.Forms.Label();
            this.numDotSize = new System.Windows.Forms.NumericUpDown();
            this.trackDotSize = new System.Windows.Forms.TrackBar();
            this.chkShowDot = new System.Windows.Forms.CheckBox();
            this.chkSyncLines = new System.Windows.Forms.CheckBox();
            this.lblVertical = new System.Windows.Forms.Label();
            this.numVertical = new System.Windows.Forms.NumericUpDown();
            this.trackVertical = new System.Windows.Forms.TrackBar();
            this.lblHorizontal = new System.Windows.Forms.Label();
            this.numHorizontal = new System.Windows.Forms.NumericUpDown();
            this.trackHorizontal = new System.Windows.Forms.TrackBar();
            this.lblThickness = new System.Windows.Forms.Label();
            this.numThickness = new System.Windows.Forms.NumericUpDown();
            this.trackThickness = new System.Windows.Forms.TrackBar();
            this.pnlProgram = new System.Windows.Forms.Panel();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnExitApp = new System.Windows.Forms.Button();
            this.pnlTabs.SuspendLayout();
            this.pnlCrosshair.SuspendLayout();
            this.pnlParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOutline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackOutline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDotSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackDotSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVertical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVertical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHorizontal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackHorizontal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackThickness)).BeginInit();
            this.pnlProgram.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTabs
            // 
            this.pnlTabs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlTabs.Controls.Add(this.btnTabProgram);
            this.pnlTabs.Controls.Add(this.btnTabParams);
            this.pnlTabs.Controls.Add(this.btnTabCrosshair);
            this.pnlTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTabs.Location = new System.Drawing.Point(0, 0);
            this.pnlTabs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTabs.Name = "pnlTabs";
            this.pnlTabs.Size = new System.Drawing.Size(600, 62);
            this.pnlTabs.TabIndex = 0;
            // 
            // btnTabProgram
            // 
            this.btnTabProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnTabProgram.FlatAppearance.BorderSize = 0;
            this.btnTabProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabProgram.ForeColor = System.Drawing.Color.White;
            this.btnTabProgram.Location = new System.Drawing.Point(402, 8);
            this.btnTabProgram.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTabProgram.Name = "btnTabProgram";
            this.btnTabProgram.Size = new System.Drawing.Size(180, 46);
            this.btnTabProgram.TabIndex = 2;
            this.btnTabProgram.Text = "Программа";
            this.btnTabProgram.UseVisualStyleBackColor = false;
            this.btnTabProgram.Click += new System.EventHandler(this.btnTabProgram_Click);
            // 
            // btnTabParams
            // 
            this.btnTabParams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnTabParams.FlatAppearance.BorderSize = 0;
            this.btnTabParams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabParams.ForeColor = System.Drawing.Color.White;
            this.btnTabParams.Location = new System.Drawing.Point(207, 8);
            this.btnTabParams.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTabParams.Name = "btnTabParams";
            this.btnTabParams.Size = new System.Drawing.Size(180, 46);
            this.btnTabParams.TabIndex = 1;
            this.btnTabParams.Text = "Параметры";
            this.btnTabParams.UseVisualStyleBackColor = false;
            this.btnTabParams.Click += new System.EventHandler(this.btnTabParams_Click);
            // 
            // btnTabCrosshair
            // 
            this.btnTabCrosshair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnTabCrosshair.FlatAppearance.BorderSize = 0;
            this.btnTabCrosshair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabCrosshair.ForeColor = System.Drawing.Color.White;
            this.btnTabCrosshair.Location = new System.Drawing.Point(12, 8);
            this.btnTabCrosshair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTabCrosshair.Name = "btnTabCrosshair";
            this.btnTabCrosshair.Size = new System.Drawing.Size(180, 46);
            this.btnTabCrosshair.TabIndex = 0;
            this.btnTabCrosshair.Text = "Прицел";
            this.btnTabCrosshair.UseVisualStyleBackColor = false;
            this.btnTabCrosshair.Click += new System.EventHandler(this.btnTabCrosshair_Click);
            // 
            // pnlCrosshair
            // 
            this.pnlCrosshair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlCrosshair.Controls.Add(this.btnResetPreset);
            this.pnlCrosshair.Controls.Add(this.btnLanguage);
            this.pnlCrosshair.Controls.Add(this.btnLoadPreset);
            this.pnlCrosshair.Controls.Add(this.btnSavePreset);
            this.pnlCrosshair.Controls.Add(this.txtPresetName);
            this.pnlCrosshair.Controls.Add(this.lblPresets);
            this.pnlCrosshair.Controls.Add(this.btnPreset5);
            this.pnlCrosshair.Controls.Add(this.btnPreset4);
            this.pnlCrosshair.Controls.Add(this.btnPreset3);
            this.pnlCrosshair.Controls.Add(this.btnPreset2);
            this.pnlCrosshair.Controls.Add(this.btnPreset1);
            this.pnlCrosshair.Controls.Add(this.pnlColors);
            this.pnlCrosshair.Controls.Add(this.colorPreview);
            this.pnlCrosshair.Controls.Add(this.chkCrosshairVisible);
            this.pnlCrosshair.Location = new System.Drawing.Point(15, 77);
            this.pnlCrosshair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlCrosshair.Name = "pnlCrosshair";
            this.pnlCrosshair.Size = new System.Drawing.Size(570, 585);
            this.pnlCrosshair.TabIndex = 1;
            // 
            // btnResetPreset
            // 
            this.btnResetPreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnResetPreset.FlatAppearance.BorderSize = 0;
            this.btnResetPreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPreset.ForeColor = System.Drawing.Color.White;
            this.btnResetPreset.Location = new System.Drawing.Point(150, 523);
            this.btnResetPreset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnResetPreset.Name = "btnResetPreset";
            this.btnResetPreset.Size = new System.Drawing.Size(135, 46);
            this.btnResetPreset.TabIndex = 13;
            this.btnResetPreset.Text = "Сбросить все";
            this.btnResetPreset.UseVisualStyleBackColor = false;
            this.btnResetPreset.Click += new System.EventHandler(this.btnResetPreset_Click);
            // 
            // btnLanguage
            // 
            this.btnLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnLanguage.FlatAppearance.BorderSize = 0;
            this.btnLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLanguage.ForeColor = System.Drawing.Color.White;
            this.btnLanguage.Location = new System.Drawing.Point(450, 23);
            this.btnLanguage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.Size = new System.Drawing.Size(90, 38);
            this.btnLanguage.TabIndex = 12;
            this.btnLanguage.Text = "RU";
            this.btnLanguage.UseVisualStyleBackColor = false;
            this.btnLanguage.Click += new System.EventHandler(this.btnLanguage_Click);
            // 
            // btnLoadPreset
            // 
            this.btnLoadPreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnLoadPreset.FlatAppearance.BorderSize = 0;
            this.btnLoadPreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadPreset.ForeColor = System.Drawing.Color.White;
            this.btnLoadPreset.Location = new System.Drawing.Point(300, 523);
            this.btnLoadPreset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoadPreset.Name = "btnLoadPreset";
            this.btnLoadPreset.Size = new System.Drawing.Size(120, 46);
            this.btnLoadPreset.TabIndex = 11;
            this.btnLoadPreset.Text = "Загрузить";
            this.btnLoadPreset.UseVisualStyleBackColor = false;
            this.btnLoadPreset.Click += new System.EventHandler(this.btnLoadPreset_Click);
            // 
            // btnSavePreset
            // 
            this.btnSavePreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnSavePreset.FlatAppearance.BorderSize = 0;
            this.btnSavePreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePreset.ForeColor = System.Drawing.Color.White;
            this.btnSavePreset.Location = new System.Drawing.Point(435, 523);
            this.btnSavePreset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSavePreset.Name = "btnSavePreset";
            this.btnSavePreset.Size = new System.Drawing.Size(120, 46);
            this.btnSavePreset.TabIndex = 10;
            this.btnSavePreset.Text = "Сохранить";
            this.btnSavePreset.UseVisualStyleBackColor = false;
            this.btnSavePreset.Click += new System.EventHandler(this.btnSavePreset_Click);
            // 
            // txtPresetName
            // 
            this.txtPresetName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtPresetName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPresetName.ForeColor = System.Drawing.Color.White;
            this.txtPresetName.Location = new System.Drawing.Point(30, 531);
            this.txtPresetName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPresetName.Name = "txtPresetName";
            this.txtPresetName.Size = new System.Drawing.Size(104, 26);
            this.txtPresetName.TabIndex = 9;
            this.txtPresetName.Text = "Мой прицел";
            // 
            // lblPresets
            // 
            this.lblPresets.AutoSize = true;
            this.lblPresets.ForeColor = System.Drawing.Color.White;
            this.lblPresets.Location = new System.Drawing.Point(30, 385);
            this.lblPresets.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPresets.Name = "lblPresets";
            this.lblPresets.Size = new System.Drawing.Size(80, 20);
            this.lblPresets.TabIndex = 8;
            this.lblPresets.Text = "Пресеты:";
            // 
            // btnPreset5
            // 
            this.btnPreset5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnPreset5.FlatAppearance.BorderSize = 0;
            this.btnPreset5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreset5.ForeColor = System.Drawing.Color.White;
            this.btnPreset5.Location = new System.Drawing.Point(450, 415);
            this.btnPreset5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPreset5.Name = "btnPreset5";
            this.btnPreset5.Size = new System.Drawing.Size(90, 92);
            this.btnPreset5.TabIndex = 7;
            this.btnPreset5.UseVisualStyleBackColor = false;
            this.btnPreset5.Click += new System.EventHandler(this.btnPreset5_Click);
            // 
            // btnPreset4
            // 
            this.btnPreset4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnPreset4.FlatAppearance.BorderSize = 0;
            this.btnPreset4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreset4.ForeColor = System.Drawing.Color.White;
            this.btnPreset4.Location = new System.Drawing.Point(345, 415);
            this.btnPreset4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPreset4.Name = "btnPreset4";
            this.btnPreset4.Size = new System.Drawing.Size(90, 92);
            this.btnPreset4.TabIndex = 6;
            this.btnPreset4.UseVisualStyleBackColor = false;
            this.btnPreset4.Click += new System.EventHandler(this.btnPreset4_Click);
            // 
            // btnPreset3
            // 
            this.btnPreset3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnPreset3.FlatAppearance.BorderSize = 0;
            this.btnPreset3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreset3.ForeColor = System.Drawing.Color.White;
            this.btnPreset3.Location = new System.Drawing.Point(240, 415);
            this.btnPreset3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPreset3.Name = "btnPreset3";
            this.btnPreset3.Size = new System.Drawing.Size(90, 92);
            this.btnPreset3.TabIndex = 5;
            this.btnPreset3.UseVisualStyleBackColor = false;
            this.btnPreset3.Click += new System.EventHandler(this.btnPreset3_Click);
            // 
            // btnPreset2
            // 
            this.btnPreset2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnPreset2.FlatAppearance.BorderSize = 0;
            this.btnPreset2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreset2.ForeColor = System.Drawing.Color.White;
            this.btnPreset2.Location = new System.Drawing.Point(135, 415);
            this.btnPreset2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPreset2.Name = "btnPreset2";
            this.btnPreset2.Size = new System.Drawing.Size(90, 92);
            this.btnPreset2.TabIndex = 4;
            this.btnPreset2.UseVisualStyleBackColor = false;
            this.btnPreset2.Click += new System.EventHandler(this.btnPreset2_Click);
            // 
            // btnPreset1
            // 
            this.btnPreset1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnPreset1.FlatAppearance.BorderSize = 0;
            this.btnPreset1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreset1.ForeColor = System.Drawing.Color.White;
            this.btnPreset1.Location = new System.Drawing.Point(30, 415);
            this.btnPreset1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPreset1.Name = "btnPreset1";
            this.btnPreset1.Size = new System.Drawing.Size(90, 92);
            this.btnPreset1.TabIndex = 3;
            this.btnPreset1.UseVisualStyleBackColor = false;
            this.btnPreset1.Click += new System.EventHandler(this.btnPreset1_Click);
            // 
            // pnlColors
            // 
            this.pnlColors.Location = new System.Drawing.Point(30, 77);
            this.pnlColors.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlColors.Name = "pnlColors";
            this.pnlColors.Size = new System.Drawing.Size(360, 185);
            this.pnlColors.TabIndex = 2;
            // 
            // colorPreview
            // 
            this.colorPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPreview.Location = new System.Drawing.Point(405, 77);
            this.colorPreview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.colorPreview.Name = "colorPreview";
            this.colorPreview.Size = new System.Drawing.Size(134, 137);
            this.colorPreview.TabIndex = 1;
            // 
            // chkCrosshairVisible
            // 
            this.chkCrosshairVisible.AutoSize = true;
            this.chkCrosshairVisible.Checked = true;
            this.chkCrosshairVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCrosshairVisible.ForeColor = System.Drawing.Color.White;
            this.chkCrosshairVisible.Location = new System.Drawing.Point(30, 31);
            this.chkCrosshairVisible.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkCrosshairVisible.Name = "chkCrosshairVisible";
            this.chkCrosshairVisible.Size = new System.Drawing.Size(93, 24);
            this.chkCrosshairVisible.TabIndex = 0;
            this.chkCrosshairVisible.Text = "Прицел";
            this.chkCrosshairVisible.UseVisualStyleBackColor = true;
            this.chkCrosshairVisible.CheckedChanged += new System.EventHandler(this.chkCrosshairVisible_CheckedChanged);
            // 
            // pnlParams
            // 
            this.pnlParams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlParams.Controls.Add(this.btnOutlineColor);
            this.pnlParams.Controls.Add(this.lblOutline);
            this.pnlParams.Controls.Add(this.numOutline);
            this.pnlParams.Controls.Add(this.trackOutline);
            this.pnlParams.Controls.Add(this.chkShowOutline);
            this.pnlParams.Controls.Add(this.lblDotSize);
            this.pnlParams.Controls.Add(this.numDotSize);
            this.pnlParams.Controls.Add(this.trackDotSize);
            this.pnlParams.Controls.Add(this.chkShowDot);
            this.pnlParams.Controls.Add(this.chkSyncLines);
            this.pnlParams.Controls.Add(this.lblVertical);
            this.pnlParams.Controls.Add(this.numVertical);
            this.pnlParams.Controls.Add(this.trackVertical);
            this.pnlParams.Controls.Add(this.lblHorizontal);
            this.pnlParams.Controls.Add(this.numHorizontal);
            this.pnlParams.Controls.Add(this.trackHorizontal);
            this.pnlParams.Controls.Add(this.lblThickness);
            this.pnlParams.Controls.Add(this.numThickness);
            this.pnlParams.Controls.Add(this.trackThickness);
            this.pnlParams.Location = new System.Drawing.Point(15, 77);
            this.pnlParams.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlParams.Name = "pnlParams";
            this.pnlParams.Size = new System.Drawing.Size(570, 585);
            this.pnlParams.TabIndex = 2;
            this.pnlParams.Visible = false;
            // 
            // btnOutlineColor
            // 
            this.btnOutlineColor.BackColor = System.Drawing.Color.Black;
            this.btnOutlineColor.FlatAppearance.BorderSize = 0;
            this.btnOutlineColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutlineColor.ForeColor = System.Drawing.Color.White;
            this.btnOutlineColor.Location = new System.Drawing.Point(495, 516);
            this.btnOutlineColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOutlineColor.Name = "btnOutlineColor";
            this.btnOutlineColor.Size = new System.Drawing.Size(66, 38);
            this.btnOutlineColor.TabIndex = 14;
            this.btnOutlineColor.Text = "Цвет";
            this.btnOutlineColor.UseVisualStyleBackColor = false;
            this.btnOutlineColor.Click += new System.EventHandler(this.btnOutlineColor_Click);
            // 
            // lblOutline
            // 
            this.lblOutline.AutoSize = true;
            this.lblOutline.ForeColor = System.Drawing.Color.White;
            this.lblOutline.Location = new System.Drawing.Point(172, 500);
            this.lblOutline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutline.Name = "lblOutline";
            this.lblOutline.Size = new System.Drawing.Size(149, 20);
            this.lblOutline.TabIndex = 15;
            this.lblOutline.Text = "Толщина обводки:";
            // 
            // numOutline
            // 
            this.numOutline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.numOutline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numOutline.ForeColor = System.Drawing.Color.White;
            this.numOutline.Location = new System.Drawing.Point(412, 523);
            this.numOutline.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numOutline.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numOutline.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numOutline.Name = "numOutline";
            this.numOutline.Size = new System.Drawing.Size(75, 26);
            this.numOutline.TabIndex = 16;
            this.numOutline.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numOutline.ValueChanged += new System.EventHandler(this.numOutline_ValueChanged);
            // 
            // trackOutline
            // 
            this.trackOutline.Location = new System.Drawing.Point(172, 523);
            this.trackOutline.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackOutline.Minimum = 1;
            this.trackOutline.Name = "trackOutline";
            this.trackOutline.Size = new System.Drawing.Size(225, 69);
            this.trackOutline.TabIndex = 17;
            this.trackOutline.Value = 1;
            this.trackOutline.Scroll += new System.EventHandler(this.trackOutline_Scroll);
            // 
            // chkShowOutline
            // 
            this.chkShowOutline.AutoSize = true;
            this.chkShowOutline.ForeColor = System.Drawing.Color.White;
            this.chkShowOutline.Location = new System.Drawing.Point(172, 462);
            this.chkShowOutline.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkShowOutline.Name = "chkShowOutline";
            this.chkShowOutline.Size = new System.Drawing.Size(102, 24);
            this.chkShowOutline.TabIndex = 13;
            this.chkShowOutline.Text = "Обводка";
            this.chkShowOutline.UseVisualStyleBackColor = true;
            this.chkShowOutline.CheckedChanged += new System.EventHandler(this.chkShowOutline_CheckedChanged);
            // 
            // lblDotSize
            // 
            this.lblDotSize.AutoSize = true;
            this.lblDotSize.ForeColor = System.Drawing.Color.White;
            this.lblDotSize.Location = new System.Drawing.Point(172, 392);
            this.lblDotSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDotSize.Name = "lblDotSize";
            this.lblDotSize.Size = new System.Drawing.Size(117, 20);
            this.lblDotSize.TabIndex = 10;
            this.lblDotSize.Text = "Размер точки:";
            // 
            // numDotSize
            // 
            this.numDotSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.numDotSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numDotSize.ForeColor = System.Drawing.Color.White;
            this.numDotSize.Location = new System.Drawing.Point(412, 415);
            this.numDotSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numDotSize.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numDotSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDotSize.Name = "numDotSize";
            this.numDotSize.Size = new System.Drawing.Size(75, 26);
            this.numDotSize.TabIndex = 11;
            this.numDotSize.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numDotSize.ValueChanged += new System.EventHandler(this.numDotSize_ValueChanged);
            // 
            // trackDotSize
            // 
            this.trackDotSize.Location = new System.Drawing.Point(172, 415);
            this.trackDotSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackDotSize.Maximum = 30;
            this.trackDotSize.Minimum = 1;
            this.trackDotSize.Name = "trackDotSize";
            this.trackDotSize.Size = new System.Drawing.Size(225, 69);
            this.trackDotSize.TabIndex = 12;
            this.trackDotSize.Value = 6;
            this.trackDotSize.Scroll += new System.EventHandler(this.trackDotSize_Scroll);
            // 
            // chkShowDot
            // 
            this.chkShowDot.AutoSize = true;
            this.chkShowDot.Checked = true;
            this.chkShowDot.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowDot.ForeColor = System.Drawing.Color.White;
            this.chkShowDot.Location = new System.Drawing.Point(172, 354);
            this.chkShowDot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkShowDot.Name = "chkShowDot";
            this.chkShowDot.Size = new System.Drawing.Size(186, 24);
            this.chkShowDot.TabIndex = 9;
            this.chkShowDot.Text = "Центральная точка";
            this.chkShowDot.UseVisualStyleBackColor = true;
            this.chkShowDot.CheckedChanged += new System.EventHandler(this.chkShowDot_CheckedChanged);
            // 
            // chkSyncLines
            // 
            this.chkSyncLines.AutoSize = true;
            this.chkSyncLines.Checked = true;
            this.chkSyncLines.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSyncLines.ForeColor = System.Drawing.Color.White;
            this.chkSyncLines.Location = new System.Drawing.Point(172, 277);
            this.chkSyncLines.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkSyncLines.Name = "chkSyncLines";
            this.chkSyncLines.Size = new System.Drawing.Size(178, 24);
            this.chkSyncLines.TabIndex = 18;
            this.chkSyncLines.Text = "Синхронизировать";
            this.chkSyncLines.UseVisualStyleBackColor = true;
            this.chkSyncLines.CheckedChanged += new System.EventHandler(this.chkSyncLines_CheckedChanged);
            // 
            // lblVertical
            // 
            this.lblVertical.AutoSize = true;
            this.lblVertical.ForeColor = System.Drawing.Color.White;
            this.lblVertical.Location = new System.Drawing.Point(172, 208);
            this.lblVertical.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVertical.Name = "lblVertical";
            this.lblVertical.Size = new System.Drawing.Size(147, 20);
            this.lblVertical.TabIndex = 6;
            this.lblVertical.Text = "Длина вертикали:";
            // 
            // numVertical
            // 
            this.numVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.numVertical.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numVertical.ForeColor = System.Drawing.Color.White;
            this.numVertical.Location = new System.Drawing.Point(412, 231);
            this.numVertical.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numVertical.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numVertical.Name = "numVertical";
            this.numVertical.Size = new System.Drawing.Size(75, 26);
            this.numVertical.TabIndex = 7;
            this.numVertical.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numVertical.ValueChanged += new System.EventHandler(this.numVertical_ValueChanged);
            // 
            // trackVertical
            // 
            this.trackVertical.Location = new System.Drawing.Point(172, 231);
            this.trackVertical.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackVertical.Maximum = 100;
            this.trackVertical.Minimum = 1;
            this.trackVertical.Name = "trackVertical";
            this.trackVertical.Size = new System.Drawing.Size(225, 69);
            this.trackVertical.TabIndex = 8;
            this.trackVertical.Value = 25;
            this.trackVertical.Scroll += new System.EventHandler(this.trackVertical_Scroll);
            // 
            // lblHorizontal
            // 
            this.lblHorizontal.AutoSize = true;
            this.lblHorizontal.ForeColor = System.Drawing.Color.White;
            this.lblHorizontal.Location = new System.Drawing.Point(172, 115);
            this.lblHorizontal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHorizontal.Name = "lblHorizontal";
            this.lblHorizontal.Size = new System.Drawing.Size(163, 20);
            this.lblHorizontal.TabIndex = 3;
            this.lblHorizontal.Text = "Длина горизонтали:";
            // 
            // numHorizontal
            // 
            this.numHorizontal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.numHorizontal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numHorizontal.ForeColor = System.Drawing.Color.White;
            this.numHorizontal.Location = new System.Drawing.Point(412, 138);
            this.numHorizontal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numHorizontal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHorizontal.Name = "numHorizontal";
            this.numHorizontal.Size = new System.Drawing.Size(75, 26);
            this.numHorizontal.TabIndex = 4;
            this.numHorizontal.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numHorizontal.ValueChanged += new System.EventHandler(this.numHorizontal_ValueChanged);
            // 
            // trackHorizontal
            // 
            this.trackHorizontal.Location = new System.Drawing.Point(172, 138);
            this.trackHorizontal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackHorizontal.Maximum = 100;
            this.trackHorizontal.Minimum = 1;
            this.trackHorizontal.Name = "trackHorizontal";
            this.trackHorizontal.Size = new System.Drawing.Size(225, 69);
            this.trackHorizontal.TabIndex = 5;
            this.trackHorizontal.Value = 25;
            this.trackHorizontal.Scroll += new System.EventHandler(this.trackHorizontal_Scroll);
            // 
            // lblThickness
            // 
            this.lblThickness.AutoSize = true;
            this.lblThickness.ForeColor = System.Drawing.Color.White;
            this.lblThickness.Location = new System.Drawing.Point(172, 23);
            this.lblThickness.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThickness.Name = "lblThickness";
            this.lblThickness.Size = new System.Drawing.Size(81, 20);
            this.lblThickness.TabIndex = 0;
            this.lblThickness.Text = "Толщина:";
            // 
            // numThickness
            // 
            this.numThickness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.numThickness.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numThickness.ForeColor = System.Drawing.Color.White;
            this.numThickness.Location = new System.Drawing.Point(412, 46);
            this.numThickness.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numThickness.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numThickness.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numThickness.Name = "numThickness";
            this.numThickness.Size = new System.Drawing.Size(75, 26);
            this.numThickness.TabIndex = 1;
            this.numThickness.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numThickness.ValueChanged += new System.EventHandler(this.numThickness_ValueChanged);
            // 
            // trackThickness
            // 
            this.trackThickness.Location = new System.Drawing.Point(172, 46);
            this.trackThickness.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackThickness.Maximum = 20;
            this.trackThickness.Minimum = 1;
            this.trackThickness.Name = "trackThickness";
            this.trackThickness.Size = new System.Drawing.Size(225, 69);
            this.trackThickness.TabIndex = 2;
            this.trackThickness.Value = 2;
            this.trackThickness.Scroll += new System.EventHandler(this.trackThickness_Scroll);
            // 
            // pnlProgram
            // 
            this.pnlProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlProgram.Controls.Add(this.btnHide);
            this.pnlProgram.Controls.Add(this.btnExitApp);
            this.pnlProgram.Location = new System.Drawing.Point(15, 77);
            this.pnlProgram.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlProgram.Name = "pnlProgram";
            this.pnlProgram.Size = new System.Drawing.Size(570, 185);
            this.pnlProgram.TabIndex = 3;
            this.pnlProgram.Visible = false;
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnHide.FlatAppearance.BorderSize = 0;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.ForeColor = System.Drawing.Color.White;
            this.btnHide.Location = new System.Drawing.Point(30, 31);
            this.btnHide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(510, 54);
            this.btnHide.TabIndex = 1;
            this.btnHide.Text = "Скрыть настройки";
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnExitApp
            // 
            this.btnExitApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExitApp.FlatAppearance.BorderSize = 0;
            this.btnExitApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitApp.ForeColor = System.Drawing.Color.White;
            this.btnExitApp.Location = new System.Drawing.Point(30, 100);
            this.btnExitApp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Size = new System.Drawing.Size(510, 54);
            this.btnExitApp.TabIndex = 0;
            this.btnExitApp.Text = "Выход из программы";
            this.btnExitApp.UseVisualStyleBackColor = false;
            this.btnExitApp.Click += new System.EventHandler(this.btnExitApp_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(600, 692);
            this.Controls.Add(this.pnlProgram);
            this.Controls.Add(this.pnlParams);
            this.Controls.Add(this.pnlCrosshair);
            this.Controls.Add(this.pnlTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки прицела";
            this.pnlTabs.ResumeLayout(false);
            this.pnlCrosshair.ResumeLayout(false);
            this.pnlCrosshair.PerformLayout();
            this.pnlParams.ResumeLayout(false);
            this.pnlParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOutline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackOutline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDotSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackDotSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVertical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVertical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHorizontal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackHorizontal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackThickness)).EndInit();
            this.pnlProgram.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel pnlTabs;
        private System.Windows.Forms.Button btnTabCrosshair;
        private System.Windows.Forms.Button btnTabParams;
        private System.Windows.Forms.Button btnTabProgram;
        private System.Windows.Forms.Panel pnlCrosshair;
        private System.Windows.Forms.CheckBox chkCrosshairVisible;
        private System.Windows.Forms.Panel pnlColors;
        private System.Windows.Forms.Panel colorPreview;
        private System.Windows.Forms.Button btnPreset1;
        private System.Windows.Forms.Button btnPreset2;
        private System.Windows.Forms.Button btnPreset3;
        private System.Windows.Forms.Button btnPreset4;
        private System.Windows.Forms.Button btnPreset5;
        private System.Windows.Forms.Label lblPresets;
        private System.Windows.Forms.TextBox txtPresetName;
        private System.Windows.Forms.Button btnSavePreset;
        private System.Windows.Forms.Button btnLoadPreset;
        private System.Windows.Forms.Button btnLanguage;
        private System.Windows.Forms.Button btnResetPreset;
        private System.Windows.Forms.Panel pnlParams;
        private System.Windows.Forms.TrackBar trackThickness;
        private System.Windows.Forms.NumericUpDown numThickness;
        private System.Windows.Forms.Label lblThickness;
        private System.Windows.Forms.TrackBar trackHorizontal;
        private System.Windows.Forms.NumericUpDown numHorizontal;
        private System.Windows.Forms.Label lblHorizontal;
        private System.Windows.Forms.TrackBar trackVertical;
        private System.Windows.Forms.NumericUpDown numVertical;
        private System.Windows.Forms.Label lblVertical;
        private System.Windows.Forms.CheckBox chkShowDot;
        private System.Windows.Forms.TrackBar trackDotSize;
        private System.Windows.Forms.NumericUpDown numDotSize;
        private System.Windows.Forms.Label lblDotSize;
        private System.Windows.Forms.CheckBox chkShowOutline;
        private System.Windows.Forms.TrackBar trackOutline;
        private System.Windows.Forms.NumericUpDown numOutline;
        private System.Windows.Forms.Label lblOutline;
        private System.Windows.Forms.Button btnOutlineColor;
        private System.Windows.Forms.CheckBox chkSyncLines;
        private System.Windows.Forms.Panel pnlProgram;
        private System.Windows.Forms.Button btnExitApp;
        private System.Windows.Forms.Button btnHide;
    }
}