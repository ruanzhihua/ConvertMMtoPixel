namespace MyApplications
{
    partial class ChangeSystemWallPapper
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
            this.papperFile = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnConfirmSelectPath = new System.Windows.Forms.Button();
            this.btnSelectWallPapperPath = new System.Windows.Forms.Button();
            this.papperFilePath = new System.Windows.Forms.TextBox();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBoxWaterPapper = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBoxPDFFolder = new System.Windows.Forms.TextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.textBoxPDFPath = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.textLocationY = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textLocationX = new System.Windows.Forms.TextBox();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.textBoxLocationY = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.textBoxLocationX = new System.Windows.Forms.TextBox();
            this.buttonSelectCacheFolder = new System.Windows.Forms.Button();
            this.textBoxWaterPDFFolder = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.button11 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupControl1);
            this.panel2.Controls.Add(this.btnConfirmSelectPath);
            this.panel2.Controls.Add(this.btnSelectWallPapperPath);
            this.panel2.Controls.Add(this.papperFilePath);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.papperFile);
            this.panel2.Size = new System.Drawing.Size(1129, 596);
            // 
            // papperFile
            // 
            this.papperFile.Location = new System.Drawing.Point(480, 58);
            this.papperFile.Name = "papperFile";
            this.papperFile.Size = new System.Drawing.Size(127, 21);
            this.papperFile.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(613, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "选择壁纸文件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(10, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(407, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(711, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "DO";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnConfirmSelectPath
            // 
            this.btnConfirmSelectPath.Location = new System.Drawing.Point(711, 94);
            this.btnConfirmSelectPath.Name = "btnConfirmSelectPath";
            this.btnConfirmSelectPath.Size = new System.Drawing.Size(47, 23);
            this.btnConfirmSelectPath.TabIndex = 6;
            this.btnConfirmSelectPath.Text = "DO";
            this.btnConfirmSelectPath.UseVisualStyleBackColor = true;
            this.btnConfirmSelectPath.Click += new System.EventHandler(this.btnConfirmSelectPath_Click);
            // 
            // btnSelectWallPapperPath
            // 
            this.btnSelectWallPapperPath.Location = new System.Drawing.Point(613, 94);
            this.btnSelectWallPapperPath.Name = "btnSelectWallPapperPath";
            this.btnSelectWallPapperPath.Size = new System.Drawing.Size(92, 23);
            this.btnSelectWallPapperPath.TabIndex = 5;
            this.btnSelectWallPapperPath.Text = "选择壁纸路径";
            this.btnSelectWallPapperPath.UseVisualStyleBackColor = true;
            this.btnSelectWallPapperPath.Click += new System.EventHandler(this.btnSelectWallPapperPath_Click);
            // 
            // papperFilePath
            // 
            this.papperFilePath.Location = new System.Drawing.Point(480, 96);
            this.papperFilePath.Name = "papperFilePath";
            this.papperFilePath.Size = new System.Drawing.Size(127, 21);
            this.papperFilePath.TabIndex = 4;
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(19, 286);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(47, 23);
            this.buttonExecute.TabIndex = 12;
            this.buttonExecute.Text = "执行";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(152, 107);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "选择水印文件";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBoxWaterPapper
            // 
            this.textBoxWaterPapper.Location = new System.Drawing.Point(19, 109);
            this.textBoxWaterPapper.Name = "textBoxWaterPapper";
            this.textBoxWaterPapper.Size = new System.Drawing.Size(127, 22);
            this.textBoxWaterPapper.TabIndex = 10;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(484, 218);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(99, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "获取文字位置";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(152, 69);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(99, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "选择PDF文件夹";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBoxPDFFolder
            // 
            this.textBoxPDFFolder.Location = new System.Drawing.Point(19, 71);
            this.textBoxPDFFolder.Name = "textBoxPDFFolder";
            this.textBoxPDFFolder.Size = new System.Drawing.Size(127, 22);
            this.textBoxPDFFolder.TabIndex = 7;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.button11);
            this.groupControl1.Controls.Add(this.button10);
            this.groupControl1.Controls.Add(this.button9);
            this.groupControl1.Controls.Add(this.textBoxPDFPath);
            this.groupControl1.Controls.Add(this.button8);
            this.groupControl1.Controls.Add(this.textLocationY);
            this.groupControl1.Controls.Add(this.button3);
            this.groupControl1.Controls.Add(this.textLocationX);
            this.groupControl1.Controls.Add(this.textBoxText);
            this.groupControl1.Controls.Add(this.textBoxLocationY);
            this.groupControl1.Controls.Add(this.button7);
            this.groupControl1.Controls.Add(this.textBoxLocationX);
            this.groupControl1.Controls.Add(this.buttonSelectCacheFolder);
            this.groupControl1.Controls.Add(this.textBoxWaterPDFFolder);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.textBoxPDFFolder);
            this.groupControl1.Controls.Add(this.buttonExecute);
            this.groupControl1.Controls.Add(this.button6);
            this.groupControl1.Controls.Add(this.button4);
            this.groupControl1.Controls.Add(this.button5);
            this.groupControl1.Controls.Add(this.textBoxWaterPapper);
            this.groupControl1.Location = new System.Drawing.Point(461, 123);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(602, 421);
            this.groupControl1.TabIndex = 13;
            this.groupControl1.Text = "批量添加水印";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(414, 286);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(47, 23);
            this.button10.TabIndex = 26;
            this.button10.Text = "缩放";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(351, 286);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(47, 23);
            this.button9.TabIndex = 25;
            this.button9.Text = "签章";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBoxPDFPath
            // 
            this.textBoxPDFPath.Location = new System.Drawing.Point(351, 73);
            this.textBoxPDFPath.Name = "textBoxPDFPath";
            this.textBoxPDFPath.Size = new System.Drawing.Size(127, 22);
            this.textBoxPDFPath.TabIndex = 23;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(484, 71);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(99, 23);
            this.button8.TabIndex = 24;
            this.button8.Text = "选择PDF文件";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // textLocationY
            // 
            this.textLocationY.Location = new System.Drawing.Point(437, 181);
            this.textLocationY.Name = "textLocationY";
            this.textLocationY.Size = new System.Drawing.Size(77, 22);
            this.textLocationY.TabIndex = 22;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(520, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "文字坐标";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textLocationX
            // 
            this.textLocationX.Location = new System.Drawing.Point(351, 181);
            this.textLocationX.Name = "textLocationX";
            this.textLocationX.Size = new System.Drawing.Size(77, 22);
            this.textLocationX.TabIndex = 20;
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(351, 218);
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(127, 22);
            this.textBoxText.TabIndex = 19;
            // 
            // textBoxLocationY
            // 
            this.textBoxLocationY.Location = new System.Drawing.Point(56, 182);
            this.textBoxLocationY.Name = "textBoxLocationY";
            this.textBoxLocationY.Size = new System.Drawing.Size(31, 22);
            this.textBoxLocationY.TabIndex = 18;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(152, 182);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(99, 23);
            this.button7.TabIndex = 17;
            this.button7.Text = "水印文件坐标(x,y)";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBoxLocationX
            // 
            this.textBoxLocationX.Location = new System.Drawing.Point(19, 182);
            this.textBoxLocationX.Name = "textBoxLocationX";
            this.textBoxLocationX.Size = new System.Drawing.Size(31, 22);
            this.textBoxLocationX.TabIndex = 16;
            // 
            // buttonSelectCacheFolder
            // 
            this.buttonSelectCacheFolder.Location = new System.Drawing.Point(152, 144);
            this.buttonSelectCacheFolder.Name = "buttonSelectCacheFolder";
            this.buttonSelectCacheFolder.Size = new System.Drawing.Size(99, 23);
            this.buttonSelectCacheFolder.TabIndex = 15;
            this.buttonSelectCacheFolder.Text = "选择存储位置";
            this.buttonSelectCacheFolder.UseVisualStyleBackColor = true;
            this.buttonSelectCacheFolder.Click += new System.EventHandler(this.buttonSelectCacheFolder_Click);
            // 
            // textBoxWaterPDFFolder
            // 
            this.textBoxWaterPDFFolder.Location = new System.Drawing.Point(19, 146);
            this.textBoxWaterPDFFolder.Name = "textBoxWaterPDFFolder";
            this.textBoxWaterPDFFolder.Size = new System.Drawing.Size(127, 22);
            this.textBoxWaterPDFFolder.TabIndex = 14;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(19, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(21, 14);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "PDF";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(257, 107);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(56, 23);
            this.button11.TabIndex = 27;
            this.button11.Text = "测试流";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // ChangeSystemWallPapper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 626);
            this.Name = "ChangeSystemWallPapper";
            this.Tittle = "ChangeSystemWallPapper";
            this.Load += new System.EventHandler(this.ChangeSystemWallPapper_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox papperFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnConfirmSelectPath;
        private System.Windows.Forms.Button btnSelectWallPapperPath;
        private System.Windows.Forms.TextBox papperFilePath;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBoxWaterPapper;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBoxPDFFolder;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button buttonSelectCacheFolder;
        private System.Windows.Forms.TextBox textBoxWaterPDFFolder;
        private System.Windows.Forms.TextBox textBoxLocationY;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBoxLocationX;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.TextBox textLocationY;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textLocationX;
        private System.Windows.Forms.TextBox textBoxPDFPath;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
    }
}