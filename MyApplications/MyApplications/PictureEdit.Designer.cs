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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barListItem1 = new DevExpress.XtraBars.BarListItem();
            this.btnSelectArea = new DevExpress.XtraEditors.SimpleButton();
            this.imageCroppingBox1 = new MyControls.Components.ImageCroppingBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.buttonPictureTextColor = new System.Windows.Forms.Button();
            this.comboBoxFontSize = new System.Windows.Forms.ComboBox();
            this.textBoxPictureText = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonConfirmPictureTextContenr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
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
            this.barButtonItem6});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3)});
            this.bar1.Text = "Tools";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "完成";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
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
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(893, 43);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 473);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(893, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 43);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 430);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(893, 43);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 430);
            // 
            // barListItem1
            // 
            this.barListItem1.Caption = "barListItem1";
            this.barListItem1.Id = 4;
            this.barListItem1.Name = "barListItem1";
            // 
            // btnSelectArea
            // 
            this.btnSelectArea.Location = new System.Drawing.Point(389, 166);
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
            this.imageCroppingBox1.Location = new System.Drawing.Point(167, 98);
            this.imageCroppingBox1.MaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.imageCroppingBox1.Name = "imageCroppingBox1";
            this.imageCroppingBox1.SelectedRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.imageCroppingBox1.Size = new System.Drawing.Size(200, 150);
            this.imageCroppingBox1.TabIndex = 10;
            this.imageCroppingBox1.Text = "imageCroppingBox1";
            this.imageCroppingBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imageCroppingBox1_MouseClick);
            // 
            // panelBottom
            // 
            this.panelBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBottom.Controls.Add(this.buttonPictureTextColor);
            this.panelBottom.Controls.Add(this.comboBoxFontSize);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 443);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(893, 30);
            this.panelBottom.TabIndex = 15;
            this.panelBottom.Visible = false;
            // 
            // buttonPictureTextColor
            // 
            this.buttonPictureTextColor.ForeColor = System.Drawing.Color.Red;
            this.buttonPictureTextColor.Location = new System.Drawing.Point(430, 4);
            this.buttonPictureTextColor.Name = "buttonPictureTextColor";
            this.buttonPictureTextColor.Size = new System.Drawing.Size(75, 23);
            this.buttonPictureTextColor.TabIndex = 17;
            this.buttonPictureTextColor.Text = "颜色选择";
            this.buttonPictureTextColor.UseVisualStyleBackColor = true;
            this.buttonPictureTextColor.Click += new System.EventHandler(this.buttonPictureTextColor_Click);
            // 
            // comboBoxFontSize
            // 
            this.comboBoxFontSize.FormattingEnabled = true;
            this.comboBoxFontSize.Location = new System.Drawing.Point(303, 3);
            this.comboBoxFontSize.Name = "comboBoxFontSize";
            this.comboBoxFontSize.Size = new System.Drawing.Size(121, 22);
            this.comboBoxFontSize.TabIndex = 0;
            // 
            // textBoxPictureText
            // 
            this.textBoxPictureText.Location = new System.Drawing.Point(389, 196);
            this.textBoxPictureText.Name = "textBoxPictureText";
            this.textBoxPictureText.Size = new System.Drawing.Size(83, 22);
            this.textBoxPictureText.TabIndex = 16;
            this.textBoxPictureText.Visible = false;
            // 
            // buttonConfirmPictureTextContenr
            // 
            this.buttonConfirmPictureTextContenr.ForeColor = System.Drawing.Color.Black;
            this.buttonConfirmPictureTextContenr.Location = new System.Drawing.Point(478, 196);
            this.buttonConfirmPictureTextContenr.Name = "buttonConfirmPictureTextContenr";
            this.buttonConfirmPictureTextContenr.Size = new System.Drawing.Size(22, 23);
            this.buttonConfirmPictureTextContenr.TabIndex = 18;
            this.buttonConfirmPictureTextContenr.Text = "√";
            this.buttonConfirmPictureTextContenr.UseVisualStyleBackColor = true;
            this.buttonConfirmPictureTextContenr.Visible = false;
            this.buttonConfirmPictureTextContenr.Click += new System.EventHandler(this.buttonConfirmPictureTextContenr_Click);
            // 
            // PictureEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 493);
            this.Controls.Add(this.buttonConfirmPictureTextContenr);
            this.Controls.Add(this.textBoxPictureText);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.imageCroppingBox1);
            this.Controls.Add(this.btnSelectArea);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "PictureEdit";
            this.Text = "ToolbarForm1";
            this.Load += new System.EventHandler(this.PictureEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panelBottom.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.ComboBox comboBoxFontSize;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private System.Windows.Forms.Button buttonPictureTextColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonConfirmPictureTextContenr;
    }
}