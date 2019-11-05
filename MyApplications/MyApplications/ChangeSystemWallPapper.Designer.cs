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
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnConfirmSelectPath);
            this.panel2.Controls.Add(this.btnSelectWallPapperPath);
            this.panel2.Controls.Add(this.papperFilePath);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.papperFile);
            this.panel2.Size = new System.Drawing.Size(800, 420);
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
            // ChangeSystemWallPapper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "ChangeSystemWallPapper";
            this.Tittle = "ChangeSystemWallPapper";
            this.Load += new System.EventHandler(this.ChangeSystemWallPapper_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}