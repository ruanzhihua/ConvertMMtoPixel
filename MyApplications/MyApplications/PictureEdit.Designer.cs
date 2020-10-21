namespace MyApplications
{
    partial class PictureEdit
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PictureEdit));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barStaticItemPictureSize = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barListItem1 = new DevExpress.XtraBars.BarListItem();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnSelectArea = new DevExpress.XtraEditors.SimpleButton();
            this.imageCroppingBox1 = new MyControls.Components.ImageCroppingBox();
            this.buttonPictureTextColor = new System.Windows.Forms.Button();
            this.comboBoxFontSize = new System.Windows.Forms.ComboBox();
            this.textBoxPictureText = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonConfirmPictureTextContenr = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.buttonImageCrop = new System.Windows.Forms.Button();
            this.buttonImageRotate = new System.Windows.Forms.Button();
            this.buttonImageMirror = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textZoomHeight = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textZoomWidth = new System.Windows.Forms.TextBox();
            this.zoomValue = new DevExpress.XtraEditors.LabelControl();
            this.btnConfirmZoom = new System.Windows.Forms.Button();
            this.zoomTrackBarControl1 = new DevExpress.XtraEditors.ZoomTrackBarControl();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureTextGroup = new System.Windows.Forms.GroupBox();
            this.colorEdit1 = new DevExpress.XtraEditors.ColorEdit();
            this.fontEdit1 = new DevExpress.XtraEditors.FontEdit();
            this.fontEdit2 = new DevExpress.XtraEditors.ButtonEdit();
            this.panelMain = new System.Windows.Forms.Panel();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::MyApplications.WaitFormCommon), true, true);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBarControl1.Properties)).BeginInit();
            this.pictureTextGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontEdit2.Properties)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barListItem1,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barStaticItemPictureSize});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem6)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "旋转";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "镜像";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "裁剪";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "缩放";
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "文字";
            this.barButtonItem6.Id = 6;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItemPictureSize)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barStaticItemPictureSize
            // 
            this.barStaticItemPictureSize.Caption = "长：宽：";
            this.barStaticItemPictureSize.Id = 7;
            this.barStaticItemPictureSize.Name = "barStaticItemPictureSize";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(893, 21);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 544);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(893, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 21);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 523);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(893, 21);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 523);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "完成";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barListItem1
            // 
            this.barListItem1.Caption = "barListItem1";
            this.barListItem1.Id = 4;
            this.barListItem1.Name = "barListItem1";
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // btnSelectArea
            // 
            this.btnSelectArea.Location = new System.Drawing.Point(492, 154);
            this.btnSelectArea.Name = "btnSelectArea";
            this.btnSelectArea.Size = new System.Drawing.Size(83, 23);
            this.btnSelectArea.TabIndex = 5;
            this.btnSelectArea.Text = "确定选择区域";
            this.btnSelectArea.Visible = false;
            this.btnSelectArea.Click += new System.EventHandler(this.btnSelectArea_Click);
            // 
            // imageCroppingBox1
            // 
            this.imageCroppingBox1.BackColor = System.Drawing.Color.White;
            this.imageCroppingBox1.Image = null;
            this.imageCroppingBox1.IsDrawMagnifier = false;
            this.imageCroppingBox1.IsLockSelected = false;
            this.imageCroppingBox1.IsSetClip = true;
            this.imageCroppingBox1.Location = new System.Drawing.Point(0, 0);
            this.imageCroppingBox1.MaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.imageCroppingBox1.Name = "imageCroppingBox1";
            this.imageCroppingBox1.SelectedRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.imageCroppingBox1.Size = new System.Drawing.Size(200, 150);
            this.imageCroppingBox1.TabIndex = 10;
            this.imageCroppingBox1.Text = "imageCroppingBox1";
            this.imageCroppingBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imageCroppingBox1_MouseClick);
            this.imageCroppingBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imageCroppingBox1_MouseUp_1);
            // 
            // buttonPictureTextColor
            // 
            this.buttonPictureTextColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPictureTextColor.ForeColor = System.Drawing.Color.Red;
            this.buttonPictureTextColor.Location = new System.Drawing.Point(6, 30);
            this.buttonPictureTextColor.Name = "buttonPictureTextColor";
            this.buttonPictureTextColor.Size = new System.Drawing.Size(43, 33);
            this.buttonPictureTextColor.TabIndex = 17;
            this.buttonPictureTextColor.Text = "文字";
            this.buttonPictureTextColor.UseVisualStyleBackColor = true;
            this.buttonPictureTextColor.Click += new System.EventHandler(this.buttonPictureTextColor_Click);
            // 
            // comboBoxFontSize
            // 
            this.comboBoxFontSize.FormattingEnabled = true;
            this.comboBoxFontSize.Location = new System.Drawing.Point(78, 15);
            this.comboBoxFontSize.Name = "comboBoxFontSize";
            this.comboBoxFontSize.Size = new System.Drawing.Size(100, 22);
            this.comboBoxFontSize.TabIndex = 0;
            this.comboBoxFontSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxFontSize_SelectedIndexChanged);
            // 
            // textBoxPictureText
            // 
            this.textBoxPictureText.Location = new System.Drawing.Point(492, 184);
            this.textBoxPictureText.Name = "textBoxPictureText";
            this.textBoxPictureText.Size = new System.Drawing.Size(83, 22);
            this.textBoxPictureText.TabIndex = 16;
            this.textBoxPictureText.Visible = false;
            // 
            // buttonConfirmPictureTextContenr
            // 
            this.buttonConfirmPictureTextContenr.ForeColor = System.Drawing.Color.Black;
            this.buttonConfirmPictureTextContenr.Location = new System.Drawing.Point(581, 184);
            this.buttonConfirmPictureTextContenr.Name = "buttonConfirmPictureTextContenr";
            this.buttonConfirmPictureTextContenr.Size = new System.Drawing.Size(22, 23);
            this.buttonConfirmPictureTextContenr.TabIndex = 18;
            this.buttonConfirmPictureTextContenr.Text = "√";
            this.buttonConfirmPictureTextContenr.UseVisualStyleBackColor = true;
            this.buttonConfirmPictureTextContenr.Visible = false;
            this.buttonConfirmPictureTextContenr.Click += new System.EventHandler(this.buttonConfirmPictureTextContenr_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLeft.AutoScroll = true;
            this.panelLeft.Controls.Add(this.buttonConfirmPictureTextContenr);
            this.panelLeft.Controls.Add(this.textBoxPictureText);
            this.panelLeft.Controls.Add(this.btnSelectArea);
            this.panelLeft.Controls.Add(this.imageCroppingBox1);
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(681, 523);
            this.panelLeft.TabIndex = 23;
            this.panelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLeft_Paint);
            // 
            // panelRight
            // 
            this.panelRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRight.Controls.Add(this.simpleButton1);
            this.panelRight.Controls.Add(this.buttonImageCrop);
            this.panelRight.Controls.Add(this.buttonImageRotate);
            this.panelRight.Controls.Add(this.buttonImageMirror);
            this.panelRight.Controls.Add(this.groupBox1);
            this.panelRight.Controls.Add(this.button2);
            this.panelRight.Controls.Add(this.button1);
            this.panelRight.Controls.Add(this.pictureTextGroup);
            this.panelRight.Controls.Add(this.fontEdit2);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(684, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(209, 523);
            this.panelRight.TabIndex = 28;
            // 
            // buttonImageCrop
            // 
            this.buttonImageCrop.ForeColor = System.Drawing.Color.Black;
            this.buttonImageCrop.Location = new System.Drawing.Point(34, 354);
            this.buttonImageCrop.Name = "buttonImageCrop";
            this.buttonImageCrop.Size = new System.Drawing.Size(50, 23);
            this.buttonImageCrop.TabIndex = 31;
            this.buttonImageCrop.Tag = "100%";
            this.buttonImageCrop.Text = "裁剪";
            this.buttonImageCrop.UseVisualStyleBackColor = true;
            this.buttonImageCrop.Click += new System.EventHandler(this.buttonImageCrop_Click);
            // 
            // buttonImageRotate
            // 
            this.buttonImageRotate.ForeColor = System.Drawing.Color.Black;
            this.buttonImageRotate.Location = new System.Drawing.Point(34, 311);
            this.buttonImageRotate.Name = "buttonImageRotate";
            this.buttonImageRotate.Size = new System.Drawing.Size(50, 23);
            this.buttonImageRotate.TabIndex = 30;
            this.buttonImageRotate.Tag = "100%";
            this.buttonImageRotate.Text = "旋转";
            this.buttonImageRotate.UseVisualStyleBackColor = true;
            this.buttonImageRotate.Click += new System.EventHandler(this.buttonImageRotate_Click);
            // 
            // buttonImageMirror
            // 
            this.buttonImageMirror.ForeColor = System.Drawing.Color.Black;
            this.buttonImageMirror.Location = new System.Drawing.Point(106, 311);
            this.buttonImageMirror.Name = "buttonImageMirror";
            this.buttonImageMirror.Size = new System.Drawing.Size(50, 23);
            this.buttonImageMirror.TabIndex = 29;
            this.buttonImageMirror.Tag = "100%";
            this.buttonImageMirror.Text = "镜像";
            this.buttonImageMirror.UseVisualStyleBackColor = true;
            this.buttonImageMirror.Click += new System.EventHandler(this.buttonImageMirror_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.textZoomHeight);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.textZoomWidth);
            this.groupBox1.Controls.Add(this.zoomValue);
            this.groupBox1.Controls.Add(this.btnConfirmZoom);
            this.groupBox1.Controls.Add(this.zoomTrackBarControl1);
            this.groupBox1.Location = new System.Drawing.Point(4, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 133);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "缩放";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(78, 88);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 14);
            this.labelControl2.TabIndex = 32;
            this.labelControl2.Text = "宽：";
            // 
            // textZoomHeight
            // 
            this.textZoomHeight.Location = new System.Drawing.Point(102, 85);
            this.textZoomHeight.Name = "textZoomHeight";
            this.textZoomHeight.Size = new System.Drawing.Size(39, 22);
            this.textZoomHeight.TabIndex = 31;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 88);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 14);
            this.labelControl1.TabIndex = 30;
            this.labelControl1.Text = "长：";
            // 
            // textZoomWidth
            // 
            this.textZoomWidth.Location = new System.Drawing.Point(30, 85);
            this.textZoomWidth.Name = "textZoomWidth";
            this.textZoomWidth.Size = new System.Drawing.Size(39, 22);
            this.textZoomWidth.TabIndex = 27;
            // 
            // zoomValue
            // 
            this.zoomValue.Location = new System.Drawing.Point(6, 35);
            this.zoomValue.Name = "zoomValue";
            this.zoomValue.Size = new System.Drawing.Size(33, 14);
            this.zoomValue.TabIndex = 27;
            this.zoomValue.Text = "100%";
            // 
            // btnConfirmZoom
            // 
            this.btnConfirmZoom.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmZoom.Location = new System.Drawing.Point(127, 26);
            this.btnConfirmZoom.Name = "btnConfirmZoom";
            this.btnConfirmZoom.Size = new System.Drawing.Size(65, 23);
            this.btnConfirmZoom.TabIndex = 28;
            this.btnConfirmZoom.Tag = "100%";
            this.btnConfirmZoom.Text = "确定缩放";
            this.btnConfirmZoom.UseVisualStyleBackColor = true;
            this.btnConfirmZoom.Click += new System.EventHandler(this.btnConfirmZoom_Click);
            // 
            // zoomTrackBarControl1
            // 
            this.zoomTrackBarControl1.EditValue = 100;
            this.zoomTrackBarControl1.Location = new System.Drawing.Point(6, 66);
            this.zoomTrackBarControl1.MenuManager = this.barManager1;
            this.zoomTrackBarControl1.Name = "zoomTrackBarControl1";
            this.zoomTrackBarControl1.Properties.Maximum = 100;
            this.zoomTrackBarControl1.Size = new System.Drawing.Size(186, 16);
            this.zoomTrackBarControl1.TabIndex = 22;
            this.zoomTrackBarControl1.Value = 100;
            this.zoomTrackBarControl1.ValueChanged += new System.EventHandler(this.zoomTrackBarControl1_ValueChanged);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(33, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "选择图片";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(10, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "选择图片";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureTextGroup
            // 
            this.pictureTextGroup.Controls.Add(this.comboBoxFontSize);
            this.pictureTextGroup.Controls.Add(this.buttonPictureTextColor);
            this.pictureTextGroup.Controls.Add(this.colorEdit1);
            this.pictureTextGroup.Controls.Add(this.fontEdit1);
            this.pictureTextGroup.Location = new System.Drawing.Point(4, 51);
            this.pictureTextGroup.Name = "pictureTextGroup";
            this.pictureTextGroup.Size = new System.Drawing.Size(200, 100);
            this.pictureTextGroup.TabIndex = 21;
            this.pictureTextGroup.TabStop = false;
            this.pictureTextGroup.Text = "图片文字风格";
            // 
            // colorEdit1
            // 
            this.colorEdit1.EditValue = System.Drawing.Color.Red;
            this.colorEdit1.Location = new System.Drawing.Point(78, 43);
            this.colorEdit1.MenuManager = this.barManager1;
            this.colorEdit1.Name = "colorEdit1";
            this.colorEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.colorEdit1.Size = new System.Drawing.Size(100, 20);
            this.colorEdit1.TabIndex = 18;
            this.colorEdit1.TextChanged += new System.EventHandler(this.colorEdit1_TextChanged);
            // 
            // fontEdit1
            // 
            this.fontEdit1.Location = new System.Drawing.Point(78, 69);
            this.fontEdit1.MenuManager = this.barManager1;
            this.fontEdit1.Name = "fontEdit1";
            this.fontEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fontEdit1.Size = new System.Drawing.Size(100, 20);
            this.fontEdit1.TabIndex = 19;
            this.fontEdit1.SelectedIndexChanged += new System.EventHandler(this.fontEdit1_SelectedIndexChanged);
            this.fontEdit1.TextChanged += new System.EventHandler(this.fontEdit1_TextChanged);
            // 
            // fontEdit2
            // 
            this.fontEdit2.Location = new System.Drawing.Point(82, 12);
            this.fontEdit2.MenuManager = this.barManager1;
            this.fontEdit2.Name = "fontEdit2";
            this.fontEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fontEdit2.Size = new System.Drawing.Size(114, 20);
            this.fontEdit2.TabIndex = 23;
            this.fontEdit2.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.fontEdit2_ButtonClick);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelRight);
            this.panelMain.Controls.Add(this.panelLeft);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 21);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(893, 523);
            this.panelMain.TabIndex = 29;
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.simpleButton1.Location = new System.Drawing.Point(59, 421);
            this.simpleButton1.LookAndFeel.SkinName = "DevExpress Style";
            this.simpleButton1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.simpleButton1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton1.Size = new System.Drawing.Size(86, 30);
            this.simpleButton1.TabIndex = 32;
            this.simpleButton1.Text = "   完成";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // PictureEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 567);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "PictureEdit";
            this.Text = "ToolbarForm1";
            this.Load += new System.EventHandler(this.PictureEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBarControl1)).EndInit();
            this.pictureTextGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.colorEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontEdit2.Properties)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarListItem barListItem1;
        private DevExpress.XtraEditors.SimpleButton btnSelectArea;
        private MyControls.Components.ImageCroppingBox imageCroppingBox1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private System.Windows.Forms.TextBox textBoxPictureText;
        private System.Windows.Forms.ComboBox comboBoxFontSize;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private System.Windows.Forms.Button buttonPictureTextColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonConfirmPictureTextContenr;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelMain;
        private DevExpress.XtraEditors.FontEdit fontEdit1;
        private DevExpress.XtraEditors.ColorEdit colorEdit1;
        private System.Windows.Forms.GroupBox pictureTextGroup;
        private DevExpress.XtraEditors.ZoomTrackBarControl zoomTrackBarControl1;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.ButtonEdit fontEdit2;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private DevExpress.XtraEditors.LabelControl zoomValue;
        private System.Windows.Forms.Button btnConfirmZoom;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox textZoomHeight;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox textZoomWidth;
        private DevExpress.XtraBars.BarStaticItem barStaticItemPictureSize;
        private System.Windows.Forms.Button buttonImageRotate;
        private System.Windows.Forms.Button buttonImageMirror;
        private System.Windows.Forms.Button buttonImageCrop;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}