
namespace SqliteAdd
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textInput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textShxName = new System.Windows.Forms.TextBox();
            this.textFileName = new System.Windows.Forms.TextBox();
            this.textFileMd5 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmdArgs = new System.Windows.Forms.TextBox();
            this.execCmdArgs1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "getFileMd5";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(35, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "getShxList";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textInput
            // 
            this.textInput.Location = new System.Drawing.Point(35, 84);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(246, 21);
            this.textInput.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.textShxName);
            this.groupBox1.Controls.Add(this.textFileName);
            this.groupBox1.Controls.Add(this.textFileMd5);
            this.groupBox1.Location = new System.Drawing.Point(421, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 181);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(8, 123);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(68, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "ShxName";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(8, 85);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(68, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "FileName";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(8, 50);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "FileMd5";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(222, 85);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "ExecInsert";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textShxName
            // 
            this.textShxName.Location = new System.Drawing.Point(82, 125);
            this.textShxName.Name = "textShxName";
            this.textShxName.Size = new System.Drawing.Size(100, 21);
            this.textShxName.TabIndex = 2;
            // 
            // textFileName
            // 
            this.textFileName.Location = new System.Drawing.Point(82, 87);
            this.textFileName.Name = "textFileName";
            this.textFileName.Size = new System.Drawing.Size(100, 21);
            this.textFileName.TabIndex = 1;
            // 
            // textFileMd5
            // 
            this.textFileMd5.Location = new System.Drawing.Point(82, 50);
            this.textFileMd5.Name = "textFileMd5";
            this.textFileMd5.Size = new System.Drawing.Size(100, 21);
            this.textFileMd5.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(127, 37);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 4;
            this.button7.Text = "deleteDataWithMd5";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.textInput);
            this.groupBox2.Location = new System.Drawing.Point(36, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 151);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.execCmdArgs1);
            this.groupBox3.Controls.Add(this.cmdArgs);
            this.groupBox3.Location = new System.Drawing.Point(46, 277);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(328, 134);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "cmd命令模拟";
            // 
            // cmdArgs
            // 
            this.cmdArgs.Location = new System.Drawing.Point(25, 29);
            this.cmdArgs.Name = "cmdArgs";
            this.cmdArgs.Size = new System.Drawing.Size(246, 21);
            this.cmdArgs.TabIndex = 0;
            // 
            // execCmdArgs1
            // 
            this.execCmdArgs1.Location = new System.Drawing.Point(25, 66);
            this.execCmdArgs1.Name = "execCmdArgs1";
            this.execCmdArgs1.Size = new System.Drawing.Size(75, 23);
            this.execCmdArgs1.TabIndex = 1;
            this.execCmdArgs1.Text = "执行一";
            this.execCmdArgs1.UseVisualStyleBackColor = true;
            this.execCmdArgs1.Click += new System.EventHandler(this.execCmdArgs1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "SqliteAdd";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textShxName;
        private System.Windows.Forms.TextBox textFileName;
        private System.Windows.Forms.TextBox textFileMd5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button execCmdArgs1;
        private System.Windows.Forms.TextBox cmdArgs;
    }
}