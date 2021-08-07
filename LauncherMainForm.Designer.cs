namespace SingleplayerLauncher
{
    partial class LauncherMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LauncherMainForm));
            this.comBoxMap = new System.Windows.Forms.ComboBox();
            this.comBoxHero = new System.Windows.Forms.ComboBox();
            this.characterSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.btnMods = new System.Windows.Forms.Button();
            this.btnResetConfig = new System.Windows.Forms.Button();
            this.chkLog = new System.Windows.Forms.CheckBox();
            this.chkCustomIni = new System.Windows.Forms.CheckBox();
            this.comBoxDye = new System.Windows.Forms.ComboBox();
            this.labelDye = new System.Windows.Forms.Label();
            this.labelSkin = new System.Windows.Forms.Label();
            this.comBoxSkin = new System.Windows.Forms.ComboBox();
            this.labelHero = new System.Windows.Forms.Label();
            this.btnLoadoutEditor = new System.Windows.Forms.Button();
            this.labelMap = new System.Windows.Forms.Label();
            this.mapSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comBoxExtraDifficulty = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelExtraDifficulty = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comBoxDifficulty = new System.Windows.Forms.ComboBox();
            this.labelDifficulty = new System.Windows.Forms.Label();
            this.comBoxGameMode = new System.Windows.Forms.ComboBox();
            this.labelGameMode = new System.Windows.Forms.Label();
            this.lbl720pSizeReference = new System.Windows.Forms.Label();
            this.lblMapSelected = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblDobbin = new System.Windows.Forms.Label();
            this.lblStinkeye = new System.Windows.Forms.Label();
            this.lblIvy = new System.Windows.Forms.Label();
            this.lblCygnus = new System.Windows.Forms.Label();
            this.lblRandomHero = new System.Windows.Forms.Label();
            this.lblYiLin = new System.Windows.Forms.Label();
            this.lblBlackpaw = new System.Windows.Forms.Label();
            this.lblZoey = new System.Windows.Forms.Label();
            this.lblBionka = new System.Windows.Forms.Label();
            this.lblTundra = new System.Windows.Forms.Label();
            this.lblBrass = new System.Windows.Forms.Label();
            this.lblTemper = new System.Windows.Forms.Label();
            this.lblBloodspike = new System.Windows.Forms.Label();
            this.lblOziel = new System.Windows.Forms.Label();
            this.lblDeadeye = new System.Windows.Forms.Label();
            this.lblSmolder = new System.Windows.Forms.Label();
            this.lblMidnight = new System.Windows.Forms.Label();
            this.lblHogarth = new System.Windows.Forms.Label();
            this.lblMaximilian = new System.Windows.Forms.Label();
            this.lblGabriella = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.characterSettingsGroupBox.SuspendLayout();
            this.mapSettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // comBoxMap
            // 
            this.comBoxMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comBoxMap.FormattingEnabled = true;
            this.comBoxMap.Location = new System.Drawing.Point(12, 15);
            this.comBoxMap.Name = "comBoxMap";
            this.comBoxMap.Size = new System.Drawing.Size(158, 450);
            this.comBoxMap.TabIndex = 1;
            this.comBoxMap.SelectedIndexChanged += new System.EventHandler(this.comBoxMap_SelectedIndexChanged);
            // 
            // comBoxHero
            // 
            this.comBoxHero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comBoxHero.FormattingEnabled = true;
            this.comBoxHero.Location = new System.Drawing.Point(8, 32);
            this.comBoxHero.Name = "comBoxHero";
            this.comBoxHero.Size = new System.Drawing.Size(126, 315);
            this.comBoxHero.TabIndex = 2;
            this.comBoxHero.SelectedIndexChanged += new System.EventHandler(this.comBoxHero_SelectedIndexChanged);
            // 
            // characterSettingsGroupBox
            // 
            this.characterSettingsGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.characterSettingsGroupBox.Controls.Add(this.pictureBox2);
            this.characterSettingsGroupBox.Controls.Add(this.lblDobbin);
            this.characterSettingsGroupBox.Controls.Add(this.lblStinkeye);
            this.characterSettingsGroupBox.Controls.Add(this.lblIvy);
            this.characterSettingsGroupBox.Controls.Add(this.btnMods);
            this.characterSettingsGroupBox.Controls.Add(this.btnResetConfig);
            this.characterSettingsGroupBox.Controls.Add(this.lblCygnus);
            this.characterSettingsGroupBox.Controls.Add(this.lblRandomHero);
            this.characterSettingsGroupBox.Controls.Add(this.chkLog);
            this.characterSettingsGroupBox.Controls.Add(this.lblYiLin);
            this.characterSettingsGroupBox.Controls.Add(this.chkCustomIni);
            this.characterSettingsGroupBox.Controls.Add(this.lblBlackpaw);
            this.characterSettingsGroupBox.Controls.Add(this.lblZoey);
            this.characterSettingsGroupBox.Controls.Add(this.lblBionka);
            this.characterSettingsGroupBox.Controls.Add(this.lblTundra);
            this.characterSettingsGroupBox.Controls.Add(this.lblBrass);
            this.characterSettingsGroupBox.Controls.Add(this.lblTemper);
            this.characterSettingsGroupBox.Controls.Add(this.lblBloodspike);
            this.characterSettingsGroupBox.Controls.Add(this.lblOziel);
            this.characterSettingsGroupBox.Controls.Add(this.lblDeadeye);
            this.characterSettingsGroupBox.Controls.Add(this.lblSmolder);
            this.characterSettingsGroupBox.Controls.Add(this.lblMidnight);
            this.characterSettingsGroupBox.Controls.Add(this.lblHogarth);
            this.characterSettingsGroupBox.Controls.Add(this.lblMaximilian);
            this.characterSettingsGroupBox.Controls.Add(this.lblGabriella);
            this.characterSettingsGroupBox.Controls.Add(this.comBoxDye);
            this.characterSettingsGroupBox.Controls.Add(this.labelDye);
            this.characterSettingsGroupBox.Controls.Add(this.labelSkin);
            this.characterSettingsGroupBox.Controls.Add(this.comBoxSkin);
            this.characterSettingsGroupBox.Controls.Add(this.labelHero);
            this.characterSettingsGroupBox.Controls.Add(this.comBoxHero);
            this.characterSettingsGroupBox.Controls.Add(this.btnLoadoutEditor);
            this.characterSettingsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.characterSettingsGroupBox.Name = "characterSettingsGroupBox";
            this.characterSettingsGroupBox.Size = new System.Drawing.Size(536, 664);
            this.characterSettingsGroupBox.TabIndex = 3;
            this.characterSettingsGroupBox.TabStop = false;
            this.characterSettingsGroupBox.Text = "Character Settings";
            // 
            // btnMods
            // 
            this.btnMods.Location = new System.Drawing.Point(370, 570);
            this.btnMods.Name = "btnMods";
            this.btnMods.Size = new System.Drawing.Size(83, 64);
            this.btnMods.TabIndex = 10;
            this.btnMods.Text = "Mods";
            this.btnMods.UseVisualStyleBackColor = true;
            this.btnMods.Click += new System.EventHandler(this.btnMods_Click);
            // 
            // btnResetConfig
            // 
            this.btnResetConfig.Location = new System.Drawing.Point(458, 570);
            this.btnResetConfig.Name = "btnResetConfig";
            this.btnResetConfig.Size = new System.Drawing.Size(70, 64);
            this.btnResetConfig.TabIndex = 9;
            this.btnResetConfig.Text = "Reset Configs";
            this.btnResetConfig.UseVisualStyleBackColor = true;
            this.btnResetConfig.Click += new System.EventHandler(this.btnResetConfig_Click);
            // 
            // chkLog
            // 
            this.chkLog.AutoSize = true;
            this.chkLog.Location = new System.Drawing.Point(458, 644);
            this.chkLog.Name = "chkLog";
            this.chkLog.Size = new System.Drawing.Size(44, 17);
            this.chkLog.TabIndex = 6;
            this.chkLog.Text = "Log";
            this.chkLog.UseVisualStyleBackColor = true;
            // 
            // chkCustomIni
            // 
            this.chkCustomIni.AutoSize = true;
            this.chkCustomIni.Location = new System.Drawing.Point(370, 644);
            this.chkCustomIni.Name = "chkCustomIni";
            this.chkCustomIni.Size = new System.Drawing.Size(77, 17);
            this.chkCustomIni.TabIndex = 4;
            this.chkCustomIni.Text = "Custom .ini";
            this.chkCustomIni.UseVisualStyleBackColor = true;
            this.chkCustomIni.CheckedChanged += new System.EventHandler(this.chkCustomIni_CheckedChanged);
            // 
            // comBoxDye
            // 
            this.comBoxDye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comBoxDye.FormattingEnabled = true;
            this.comBoxDye.Location = new System.Drawing.Point(8, 556);
            this.comBoxDye.Name = "comBoxDye";
            this.comBoxDye.Size = new System.Drawing.Size(126, 100);
            this.comBoxDye.TabIndex = 6;
            // 
            // labelDye
            // 
            this.labelDye.AutoSize = true;
            this.labelDye.Location = new System.Drawing.Point(5, 540);
            this.labelDye.Name = "labelDye";
            this.labelDye.Size = new System.Drawing.Size(26, 13);
            this.labelDye.TabIndex = 5;
            this.labelDye.Text = "Dye";
            // 
            // labelSkin
            // 
            this.labelSkin.AutoSize = true;
            this.labelSkin.Location = new System.Drawing.Point(8, 349);
            this.labelSkin.Name = "labelSkin";
            this.labelSkin.Size = new System.Drawing.Size(28, 13);
            this.labelSkin.TabIndex = 3;
            this.labelSkin.Text = "Skin";
            // 
            // comBoxSkin
            // 
            this.comBoxSkin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comBoxSkin.FormattingEnabled = true;
            this.comBoxSkin.Location = new System.Drawing.Point(8, 365);
            this.comBoxSkin.Name = "comBoxSkin";
            this.comBoxSkin.Size = new System.Drawing.Size(126, 177);
            this.comBoxSkin.TabIndex = 4;
            // 
            // labelHero
            // 
            this.labelHero.AutoSize = true;
            this.labelHero.Location = new System.Drawing.Point(14, 16);
            this.labelHero.Name = "labelHero";
            this.labelHero.Size = new System.Drawing.Size(30, 13);
            this.labelHero.TabIndex = 1;
            this.labelHero.Text = "Hero";
            // 
            // btnLoadoutEditor
            // 
            this.btnLoadoutEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadoutEditor.Location = new System.Drawing.Point(373, 365);
            this.btnLoadoutEditor.Name = "btnLoadoutEditor";
            this.btnLoadoutEditor.Size = new System.Drawing.Size(157, 138);
            this.btnLoadoutEditor.TabIndex = 7;
            this.btnLoadoutEditor.Text = "Loadout editor";
            this.btnLoadoutEditor.UseVisualStyleBackColor = true;
            this.btnLoadoutEditor.Click += new System.EventHandler(this.btnLoadoutEditor_Click);
            // 
            // labelMap
            // 
            this.labelMap.AutoSize = true;
            this.labelMap.Location = new System.Drawing.Point(15, 15);
            this.labelMap.Name = "labelMap";
            this.labelMap.Size = new System.Drawing.Size(28, 13);
            this.labelMap.TabIndex = 0;
            this.labelMap.Text = "Map";
            // 
            // mapSettingsGroupBox
            // 
            this.mapSettingsGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.mapSettingsGroupBox.Controls.Add(this.label1);
            this.mapSettingsGroupBox.Controls.Add(this.checkBox1);
            this.mapSettingsGroupBox.Controls.Add(this.btnLaunch);
            this.mapSettingsGroupBox.Controls.Add(this.comBoxExtraDifficulty);
            this.mapSettingsGroupBox.Controls.Add(this.textBox2);
            this.mapSettingsGroupBox.Controls.Add(this.labelExtraDifficulty);
            this.mapSettingsGroupBox.Controls.Add(this.textBox1);
            this.mapSettingsGroupBox.Controls.Add(this.comBoxDifficulty);
            this.mapSettingsGroupBox.Controls.Add(this.labelDifficulty);
            this.mapSettingsGroupBox.Controls.Add(this.comBoxGameMode);
            this.mapSettingsGroupBox.Controls.Add(this.labelGameMode);
            this.mapSettingsGroupBox.Controls.Add(this.comBoxMap);
            this.mapSettingsGroupBox.Controls.Add(this.labelMap);
            this.mapSettingsGroupBox.Location = new System.Drawing.Point(554, 12);
            this.mapSettingsGroupBox.Name = "mapSettingsGroupBox";
            this.mapSettingsGroupBox.Size = new System.Drawing.Size(706, 664);
            this.mapSettingsGroupBox.TabIndex = 8;
            this.mapSettingsGroupBox.TabStop = false;
            this.mapSettingsGroupBox.Text = "Map Settings";
            this.mapSettingsGroupBox.Enter += new System.EventHandler(this.mapSettingsGroupBox_Enter);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.checkBox1.Enabled = false;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(703, 569);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 29);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Music";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comBoxExtraDifficulty
            // 
            this.comBoxExtraDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comBoxExtraDifficulty.Enabled = false;
            this.comBoxExtraDifficulty.FormattingEnabled = true;
            this.comBoxExtraDifficulty.Location = new System.Drawing.Point(94, 489);
            this.comBoxExtraDifficulty.Name = "comBoxExtraDifficulty";
            this.comBoxExtraDifficulty.Size = new System.Drawing.Size(76, 173);
            this.comBoxExtraDifficulty.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBox2.Location = new System.Drawing.Point(526, 610);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(171, 20);
            this.textBox2.TabIndex = 14;
            this.textBox2.Text = "https://discord.gg/YrCaHw7Hza";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelExtraDifficulty
            // 
            this.labelExtraDifficulty.AutoSize = true;
            this.labelExtraDifficulty.Location = new System.Drawing.Point(91, 468);
            this.labelExtraDifficulty.Name = "labelExtraDifficulty";
            this.labelExtraDifficulty.Size = new System.Drawing.Size(53, 13);
            this.labelExtraDifficulty.TabIndex = 8;
            this.labelExtraDifficulty.Text = "Difficulty+";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBox1.Location = new System.Drawing.Point(423, 636);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "https://github.com/TimeMaster18/OMDU-SinglePlayer";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comBoxDifficulty
            // 
            this.comBoxDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comBoxDifficulty.Enabled = false;
            this.comBoxDifficulty.FormattingEnabled = true;
            this.comBoxDifficulty.Location = new System.Drawing.Point(12, 580);
            this.comBoxDifficulty.Name = "comBoxDifficulty";
            this.comBoxDifficulty.Size = new System.Drawing.Size(76, 86);
            this.comBoxDifficulty.TabIndex = 7;
            this.comBoxDifficulty.SelectedIndexChanged += new System.EventHandler(this.comBoxDifficulty_SelectedIndexChanged);
            // 
            // labelDifficulty
            // 
            this.labelDifficulty.AutoSize = true;
            this.labelDifficulty.Location = new System.Drawing.Point(9, 561);
            this.labelDifficulty.Name = "labelDifficulty";
            this.labelDifficulty.Size = new System.Drawing.Size(47, 13);
            this.labelDifficulty.TabIndex = 6;
            this.labelDifficulty.Text = "Difficulty";
            // 
            // comBoxGameMode
            // 
            this.comBoxGameMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comBoxGameMode.Enabled = false;
            this.comBoxGameMode.FormattingEnabled = true;
            this.comBoxGameMode.Location = new System.Drawing.Point(12, 488);
            this.comBoxGameMode.Name = "comBoxGameMode";
            this.comBoxGameMode.Size = new System.Drawing.Size(76, 73);
            this.comBoxGameMode.TabIndex = 5;
            this.comBoxGameMode.SelectedIndexChanged += new System.EventHandler(this.comBoxGameMode_SelectedIndexChanged);
            // 
            // labelGameMode
            // 
            this.labelGameMode.AutoSize = true;
            this.labelGameMode.Location = new System.Drawing.Point(9, 468);
            this.labelGameMode.Name = "labelGameMode";
            this.labelGameMode.Size = new System.Drawing.Size(34, 13);
            this.labelGameMode.TabIndex = 2;
            this.labelGameMode.Text = "Mode";
            // 
            // lbl720pSizeReference
            // 
            this.lbl720pSizeReference.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl720pSizeReference.Location = new System.Drawing.Point(1265, 680);
            this.lbl720pSizeReference.Name = "lbl720pSizeReference";
            this.lbl720pSizeReference.Size = new System.Drawing.Size(1280, 720);
            this.lbl720pSizeReference.TabIndex = 37;
            this.lbl720pSizeReference.Text = "lbl720pSizeReference";
            // 
            // lblMapSelected
            // 
            this.lblMapSelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMapSelected.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMapSelected.Location = new System.Drawing.Point(739, 26);
            this.lblMapSelected.Name = "lblMapSelected";
            this.lblMapSelected.Size = new System.Drawing.Size(512, 36);
            this.lblMapSelected.TabIndex = 38;
            this.lblMapSelected.Text = "lblMapSelected";
            this.lblMapSelected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::SingleplayerLauncher.Properties.Resources.OMDU_logo;
            this.pictureBox1.InitialImage = global::SingleplayerLauncher.Properties.Resources.OMDU_logo;
            this.pictureBox1.Location = new System.Drawing.Point(739, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // btnLaunch
            // 
            this.btnLaunch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnLaunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunch.Image = ((System.Drawing.Image)(resources.GetObject("btnLaunch.Image")));
            this.btnLaunch.Location = new System.Drawing.Point(183, 583);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(234, 75);
            this.btnLaunch.TabIndex = 0;
            this.btnLaunch.UseVisualStyleBackColor = false;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::SingleplayerLauncher.Properties.Resources.OMDU_logo;
            this.pictureBox2.Location = new System.Drawing.Point(141, 365);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(223, 282);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 55;
            this.pictureBox2.TabStop = false;
            // 
            // lblDobbin
            // 
            this.lblDobbin.BackColor = System.Drawing.Color.Black;
            this.lblDobbin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDobbin.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDobbin.ForeColor = System.Drawing.Color.White;
            this.lblDobbin.Image = ((System.Drawing.Image)(resources.GetObject("lblDobbin.Image")));
            this.lblDobbin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDobbin.Location = new System.Drawing.Point(297, 110);
            this.lblDobbin.Name = "lblDobbin";
            this.lblDobbin.Size = new System.Drawing.Size(78, 78);
            this.lblDobbin.TabIndex = 54;
            this.lblDobbin.Text = "Dobbin";
            this.lblDobbin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblDobbin.Click += new System.EventHandler(this.lblDobbin_Click);
            // 
            // lblStinkeye
            // 
            this.lblStinkeye.BackColor = System.Drawing.Color.Black;
            this.lblStinkeye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStinkeye.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStinkeye.ForeColor = System.Drawing.Color.White;
            this.lblStinkeye.Image = ((System.Drawing.Image)(resources.GetObject("lblStinkeye.Image")));
            this.lblStinkeye.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblStinkeye.Location = new System.Drawing.Point(141, 265);
            this.lblStinkeye.Name = "lblStinkeye";
            this.lblStinkeye.Size = new System.Drawing.Size(78, 78);
            this.lblStinkeye.TabIndex = 53;
            this.lblStinkeye.Text = "Stinkeye";
            this.lblStinkeye.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblStinkeye.Click += new System.EventHandler(this.lblStinkeye_Click);
            // 
            // lblIvy
            // 
            this.lblIvy.BackColor = System.Drawing.Color.Blue;
            this.lblIvy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIvy.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIvy.ForeColor = System.Drawing.Color.White;
            this.lblIvy.Image = ((System.Drawing.Image)(resources.GetObject("lblIvy.Image")));
            this.lblIvy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblIvy.Location = new System.Drawing.Point(141, 187);
            this.lblIvy.Name = "lblIvy";
            this.lblIvy.Size = new System.Drawing.Size(78, 78);
            this.lblIvy.TabIndex = 52;
            this.lblIvy.Text = "Ivy";
            this.lblIvy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblIvy.Click += new System.EventHandler(this.lblIvy_Click);
            // 
            // lblCygnus
            // 
            this.lblCygnus.BackColor = System.Drawing.Color.Black;
            this.lblCygnus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCygnus.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCygnus.ForeColor = System.Drawing.Color.White;
            this.lblCygnus.Image = ((System.Drawing.Image)(resources.GetObject("lblCygnus.Image")));
            this.lblCygnus.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCygnus.Location = new System.Drawing.Point(141, 109);
            this.lblCygnus.Name = "lblCygnus";
            this.lblCygnus.Size = new System.Drawing.Size(78, 78);
            this.lblCygnus.TabIndex = 51;
            this.lblCygnus.Text = "Cygnus";
            this.lblCygnus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblCygnus.Click += new System.EventHandler(this.lblCygnus_Click);
            // 
            // lblRandomHero
            // 
            this.lblRandomHero.BackColor = System.Drawing.Color.Black;
            this.lblRandomHero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRandomHero.Enabled = false;
            this.lblRandomHero.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRandomHero.ForeColor = System.Drawing.Color.White;
            this.lblRandomHero.Image = ((System.Drawing.Image)(resources.GetObject("lblRandomHero.Image")));
            this.lblRandomHero.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblRandomHero.Location = new System.Drawing.Point(141, 32);
            this.lblRandomHero.Name = "lblRandomHero";
            this.lblRandomHero.Size = new System.Drawing.Size(78, 78);
            this.lblRandomHero.TabIndex = 50;
            this.lblRandomHero.Text = "disabled";
            this.lblRandomHero.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblYiLin
            // 
            this.lblYiLin.BackColor = System.Drawing.Color.Black;
            this.lblYiLin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblYiLin.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYiLin.ForeColor = System.Drawing.Color.White;
            this.lblYiLin.Image = ((System.Drawing.Image)(resources.GetObject("lblYiLin.Image")));
            this.lblYiLin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblYiLin.Location = new System.Drawing.Point(375, 265);
            this.lblYiLin.Name = "lblYiLin";
            this.lblYiLin.Size = new System.Drawing.Size(78, 78);
            this.lblYiLin.TabIndex = 48;
            this.lblYiLin.Text = "Yi-Lin";
            this.lblYiLin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblYiLin.Click += new System.EventHandler(this.lblYiLin_Click);
            // 
            // lblBlackpaw
            // 
            this.lblBlackpaw.BackColor = System.Drawing.Color.Black;
            this.lblBlackpaw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBlackpaw.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlackpaw.ForeColor = System.Drawing.Color.White;
            this.lblBlackpaw.Image = ((System.Drawing.Image)(resources.GetObject("lblBlackpaw.Image")));
            this.lblBlackpaw.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblBlackpaw.Location = new System.Drawing.Point(297, 32);
            this.lblBlackpaw.Name = "lblBlackpaw";
            this.lblBlackpaw.Size = new System.Drawing.Size(78, 78);
            this.lblBlackpaw.TabIndex = 36;
            this.lblBlackpaw.Text = "Blackpaw";
            this.lblBlackpaw.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblBlackpaw.Click += new System.EventHandler(this.lblBlackpaw_Click);
            // 
            // lblZoey
            // 
            this.lblZoey.BackColor = System.Drawing.Color.Black;
            this.lblZoey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblZoey.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZoey.ForeColor = System.Drawing.Color.White;
            this.lblZoey.Image = ((System.Drawing.Image)(resources.GetObject("lblZoey.Image")));
            this.lblZoey.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblZoey.Location = new System.Drawing.Point(453, 265);
            this.lblZoey.Name = "lblZoey";
            this.lblZoey.Size = new System.Drawing.Size(78, 78);
            this.lblZoey.TabIndex = 49;
            this.lblZoey.Text = "Zoey";
            this.lblZoey.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblZoey.Click += new System.EventHandler(this.lblZoey_Click);
            // 
            // lblBionka
            // 
            this.lblBionka.BackColor = System.Drawing.Color.Blue;
            this.lblBionka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBionka.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBionka.ForeColor = System.Drawing.Color.White;
            this.lblBionka.Image = ((System.Drawing.Image)(resources.GetObject("lblBionka.Image")));
            this.lblBionka.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblBionka.Location = new System.Drawing.Point(219, 32);
            this.lblBionka.Name = "lblBionka";
            this.lblBionka.Size = new System.Drawing.Size(78, 78);
            this.lblBionka.TabIndex = 35;
            this.lblBionka.Text = "Bionka";
            this.lblBionka.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblBionka.Click += new System.EventHandler(this.lblBionka_Click);
            // 
            // lblTundra
            // 
            this.lblTundra.BackColor = System.Drawing.Color.Black;
            this.lblTundra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTundra.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTundra.ForeColor = System.Drawing.Color.White;
            this.lblTundra.Image = ((System.Drawing.Image)(resources.GetObject("lblTundra.Image")));
            this.lblTundra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTundra.Location = new System.Drawing.Point(297, 265);
            this.lblTundra.Name = "lblTundra";
            this.lblTundra.Size = new System.Drawing.Size(78, 78);
            this.lblTundra.TabIndex = 47;
            this.lblTundra.Text = "Tundra";
            this.lblTundra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblTundra.Click += new System.EventHandler(this.lblTundra_Click);
            // 
            // lblBrass
            // 
            this.lblBrass.BackColor = System.Drawing.Color.Black;
            this.lblBrass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBrass.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrass.ForeColor = System.Drawing.Color.White;
            this.lblBrass.Image = ((System.Drawing.Image)(resources.GetObject("lblBrass.Image")));
            this.lblBrass.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblBrass.Location = new System.Drawing.Point(453, 32);
            this.lblBrass.Name = "lblBrass";
            this.lblBrass.Size = new System.Drawing.Size(78, 78);
            this.lblBrass.TabIndex = 37;
            this.lblBrass.Text = "Brass";
            this.lblBrass.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblBrass.Click += new System.EventHandler(this.lblBrass_Click);
            // 
            // lblTemper
            // 
            this.lblTemper.BackColor = System.Drawing.Color.Black;
            this.lblTemper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTemper.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemper.ForeColor = System.Drawing.Color.White;
            this.lblTemper.Image = ((System.Drawing.Image)(resources.GetObject("lblTemper.Image")));
            this.lblTemper.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTemper.Location = new System.Drawing.Point(219, 265);
            this.lblTemper.Name = "lblTemper";
            this.lblTemper.Size = new System.Drawing.Size(78, 78);
            this.lblTemper.TabIndex = 46;
            this.lblTemper.Text = "Temper";
            this.lblTemper.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblTemper.Click += new System.EventHandler(this.lblTemper_Click);
            // 
            // lblBloodspike
            // 
            this.lblBloodspike.BackColor = System.Drawing.Color.Black;
            this.lblBloodspike.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBloodspike.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodspike.ForeColor = System.Drawing.Color.White;
            this.lblBloodspike.Image = ((System.Drawing.Image)(resources.GetObject("lblBloodspike.Image")));
            this.lblBloodspike.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblBloodspike.Location = new System.Drawing.Point(375, 32);
            this.lblBloodspike.Name = "lblBloodspike";
            this.lblBloodspike.Size = new System.Drawing.Size(78, 78);
            this.lblBloodspike.TabIndex = 38;
            this.lblBloodspike.Text = "Bloodspike";
            this.lblBloodspike.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblBloodspike.Click += new System.EventHandler(this.lblBloodspike_Click);
            // 
            // lblOziel
            // 
            this.lblOziel.BackColor = System.Drawing.Color.Black;
            this.lblOziel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOziel.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOziel.ForeColor = System.Drawing.Color.White;
            this.lblOziel.Image = ((System.Drawing.Image)(resources.GetObject("lblOziel.Image")));
            this.lblOziel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblOziel.Location = new System.Drawing.Point(375, 187);
            this.lblOziel.Name = "lblOziel";
            this.lblOziel.Size = new System.Drawing.Size(78, 78);
            this.lblOziel.TabIndex = 44;
            this.lblOziel.Text = "Oziel";
            this.lblOziel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblOziel.Click += new System.EventHandler(this.lblOziel_Click);
            // 
            // lblDeadeye
            // 
            this.lblDeadeye.BackColor = System.Drawing.Color.Black;
            this.lblDeadeye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeadeye.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadeye.ForeColor = System.Drawing.Color.White;
            this.lblDeadeye.Image = ((System.Drawing.Image)(resources.GetObject("lblDeadeye.Image")));
            this.lblDeadeye.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDeadeye.Location = new System.Drawing.Point(219, 109);
            this.lblDeadeye.Name = "lblDeadeye";
            this.lblDeadeye.Size = new System.Drawing.Size(78, 78);
            this.lblDeadeye.TabIndex = 39;
            this.lblDeadeye.Text = "Deadeye";
            this.lblDeadeye.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblDeadeye.Click += new System.EventHandler(this.lblDeadeye_Click);
            // 
            // lblSmolder
            // 
            this.lblSmolder.BackColor = System.Drawing.Color.Blue;
            this.lblSmolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSmolder.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmolder.ForeColor = System.Drawing.Color.White;
            this.lblSmolder.Image = ((System.Drawing.Image)(resources.GetObject("lblSmolder.Image")));
            this.lblSmolder.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSmolder.Location = new System.Drawing.Point(453, 187);
            this.lblSmolder.Name = "lblSmolder";
            this.lblSmolder.Size = new System.Drawing.Size(78, 78);
            this.lblSmolder.TabIndex = 45;
            this.lblSmolder.Text = "Smolder";
            this.lblSmolder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblSmolder.Click += new System.EventHandler(this.lblSmolder_Click);
            // 
            // lblMidnight
            // 
            this.lblMidnight.BackColor = System.Drawing.Color.Black;
            this.lblMidnight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMidnight.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMidnight.ForeColor = System.Drawing.Color.White;
            this.lblMidnight.Image = ((System.Drawing.Image)(resources.GetObject("lblMidnight.Image")));
            this.lblMidnight.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMidnight.Location = new System.Drawing.Point(297, 187);
            this.lblMidnight.Name = "lblMidnight";
            this.lblMidnight.Size = new System.Drawing.Size(78, 78);
            this.lblMidnight.TabIndex = 43;
            this.lblMidnight.Text = "Midnight";
            this.lblMidnight.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblMidnight.Click += new System.EventHandler(this.lblMidnight_Click);
            // 
            // lblHogarth
            // 
            this.lblHogarth.BackColor = System.Drawing.Color.Blue;
            this.lblHogarth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHogarth.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHogarth.ForeColor = System.Drawing.Color.White;
            this.lblHogarth.Image = ((System.Drawing.Image)(resources.GetObject("lblHogarth.Image")));
            this.lblHogarth.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblHogarth.Location = new System.Drawing.Point(453, 110);
            this.lblHogarth.Name = "lblHogarth";
            this.lblHogarth.Size = new System.Drawing.Size(78, 78);
            this.lblHogarth.TabIndex = 41;
            this.lblHogarth.Text = "Hogarth";
            this.lblHogarth.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblHogarth.Click += new System.EventHandler(this.lblHogarth_Click);
            // 
            // lblMaximilian
            // 
            this.lblMaximilian.BackColor = System.Drawing.Color.Blue;
            this.lblMaximilian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMaximilian.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaximilian.ForeColor = System.Drawing.Color.White;
            this.lblMaximilian.Image = ((System.Drawing.Image)(resources.GetObject("lblMaximilian.Image")));
            this.lblMaximilian.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMaximilian.Location = new System.Drawing.Point(219, 187);
            this.lblMaximilian.Name = "lblMaximilian";
            this.lblMaximilian.Size = new System.Drawing.Size(78, 78);
            this.lblMaximilian.TabIndex = 42;
            this.lblMaximilian.Text = "Maximilian";
            this.lblMaximilian.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblMaximilian.Click += new System.EventHandler(this.lblMaximilian_Click);
            // 
            // lblGabriella
            // 
            this.lblGabriella.BackColor = System.Drawing.Color.Blue;
            this.lblGabriella.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGabriella.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGabriella.ForeColor = System.Drawing.Color.White;
            this.lblGabriella.Image = ((System.Drawing.Image)(resources.GetObject("lblGabriella.Image")));
            this.lblGabriella.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblGabriella.Location = new System.Drawing.Point(375, 109);
            this.lblGabriella.Name = "lblGabriella";
            this.lblGabriella.Size = new System.Drawing.Size(78, 78);
            this.lblGabriella.TabIndex = 40;
            this.lblGabriella.Text = "Gabriella";
            this.lblGabriella.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblGabriella.Click += new System.EventHandler(this.lblGabriella_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(441, 617);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Stay up to date";
            // 
            // LauncherMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lblMapSelected);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mapSettingsGroupBox);
            this.Controls.Add(this.characterSettingsGroupBox);
            this.Controls.Add(this.lbl720pSizeReference);
            this.Name = "LauncherMainForm";
            this.Text = "OMDU Offline Launcher 720p- ((Unofficial Toad Modded)) (07/27/2021) (10:20 PM EST" +
    ") ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.characterSettingsGroupBox.ResumeLayout(false);
            this.characterSettingsGroupBox.PerformLayout();
            this.mapSettingsGroupBox.ResumeLayout(false);
            this.mapSettingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.ComboBox comBoxMap;
        private System.Windows.Forms.ComboBox comBoxHero;
        private System.Windows.Forms.GroupBox characterSettingsGroupBox;
        private System.Windows.Forms.Label labelHero;
        private System.Windows.Forms.Label labelMap;
        private System.Windows.Forms.CheckBox chkCustomIni;
        private System.Windows.Forms.CheckBox chkLog;
        private System.Windows.Forms.Label labelSkin;
        private System.Windows.Forms.ComboBox comBoxSkin;
        private System.Windows.Forms.Label labelDye;
        private System.Windows.Forms.ComboBox comBoxDye;
        private System.Windows.Forms.Button btnLoadoutEditor;
        private System.Windows.Forms.GroupBox mapSettingsGroupBox;
        private System.Windows.Forms.ComboBox comBoxDifficulty;
        private System.Windows.Forms.Label labelDifficulty;
        private System.Windows.Forms.ComboBox comBoxGameMode;
        private System.Windows.Forms.Label labelGameMode;
        private System.Windows.Forms.ComboBox comBoxExtraDifficulty;
        private System.Windows.Forms.Label labelExtraDifficulty;
        private System.Windows.Forms.Button btnResetConfig;
        private System.Windows.Forms.Button btnMods;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl720pSizeReference;
        private System.Windows.Forms.Label lblMapSelected;
        private System.Windows.Forms.Label lblDobbin;
        private System.Windows.Forms.Label lblStinkeye;
        private System.Windows.Forms.Label lblIvy;
        private System.Windows.Forms.Label lblCygnus;
        private System.Windows.Forms.Label lblRandomHero;
        private System.Windows.Forms.Label lblYiLin;
        private System.Windows.Forms.Label lblBlackpaw;
        private System.Windows.Forms.Label lblZoey;
        private System.Windows.Forms.Label lblBionka;
        private System.Windows.Forms.Label lblTundra;
        private System.Windows.Forms.Label lblBrass;
        private System.Windows.Forms.Label lblTemper;
        private System.Windows.Forms.Label lblBloodspike;
        private System.Windows.Forms.Label lblOziel;
        private System.Windows.Forms.Label lblDeadeye;
        private System.Windows.Forms.Label lblSmolder;
        private System.Windows.Forms.Label lblMidnight;
        private System.Windows.Forms.Label lblHogarth;
        private System.Windows.Forms.Label lblMaximilian;
        private System.Windows.Forms.Label lblGabriella;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
    }
}

