
namespace MyApplications
{
    partial class FileWatcherForm
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
            this.buttonSelectCacheFolder = new System.Windows.Forms.Button();
            this.textboxWatcherPath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSelectCacheFolder
            // 
            this.buttonSelectCacheFolder.Location = new System.Drawing.Point(224, 63);
            this.buttonSelectCacheFolder.Name = "buttonSelectCacheFolder";
            this.buttonSelectCacheFolder.Size = new System.Drawing.Size(99, 23);
            this.buttonSelectCacheFolder.TabIndex = 17;
            this.buttonSelectCacheFolder.Text = "选择监视位置";
            this.buttonSelectCacheFolder.UseVisualStyleBackColor = true;
            this.buttonSelectCacheFolder.Click += new System.EventHandler(this.buttonSelectCacheFolder_Click);
            // 
            // textboxWatcherPath
            // 
            this.textboxWatcherPath.Location = new System.Drawing.Point(91, 65);
            this.textboxWatcherPath.Name = "textboxWatcherPath";
            this.textboxWatcherPath.Size = new System.Drawing.Size(127, 21);
            this.textboxWatcherPath.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "监视开始";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FileWatcherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSelectCacheFolder);
            this.Controls.Add(this.textboxWatcherPath);
            this.Name = "FileWatcherForm";
            this.Text = "FileWatcherForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectCacheFolder;
        private System.Windows.Forms.TextBox textboxWatcherPath;
        private System.Windows.Forms.Button button1;
    }
}