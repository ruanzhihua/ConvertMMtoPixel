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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.buttonSelectCacheFolder = new System.Windows.Forms.Button();
            this.textBoxWaterPDFFolder = new System.Windows.Forms.TextBox();
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
            this.buttonExecute.Location = new System.Drawing.Point(19, 174);
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
            this.button5.Location = new System.Drawing.Point(257, 69);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "DO";
            this.button5.UseVisualStyleBackColor = true;
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
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(19, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(21, 14);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "PDF";
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
    }
}