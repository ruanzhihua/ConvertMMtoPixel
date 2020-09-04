namespace MyApplications
{
    partial class EditPictureForCell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPictureForCell));
            this.axCell1 = new AxCELL50Lib.AxCell();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ResultPicturePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditPicture = new DevExpress.XtraEditors.SimpleButton();
            this.OriginPicture = new System.Windows.Forms.PictureBox();
            this.ResultPicture = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axCell1)).BeginInit();
            this.panel4.SuspendLayout();
            this.ResultPicturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OriginPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEditPicture);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ResultPicturePanel);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.axCell1);
            this.panel2.Size = new System.Drawing.Size(1157, 616);
            // 
            // axCell1
            // 
            this.axCell1.Dock = System.Windows.Forms.DockStyle.Left;
            this.axCell1.Enabled = true;
            this.axCell1.Location = new System.Drawing.Point(0, 0);
            this.axCell1.Name = "axCell1";
            this.axCell1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axCell1.OcxState")));
            this.axCell1.Size = new System.Drawing.Size(406, 616);
            this.axCell1.TabIndex = 0;
            this.axCell1.DropCellSelected += new AxCELL50Lib._DCell2000Events_DropCellSelectedEventHandler(this.axCell1_DropCellSelected);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.OriginPicture);
            this.panel4.Location = new System.Drawing.Point(459, 67);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(280, 280);
            this.panel4.TabIndex = 1;
            // 
            // ResultPicturePanel
            // 
            this.ResultPicturePanel.Controls.Add(this.ResultPicture);
            this.ResultPicturePanel.Location = new System.Drawing.Point(786, 67);
            this.ResultPicturePanel.Name = "ResultPicturePanel";
            this.ResultPicturePanel.Size = new System.Drawing.Size(280, 280);
            this.ResultPicturePanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "原图片";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(784, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "修改预览";
            // 
            // btnEditPicture
            // 
            this.btnEditPicture.Location = new System.Drawing.Point(459, 365);
            this.btnEditPicture.Name = "btnEditPicture";
            this.btnEditPicture.Size = new System.Drawing.Size(56, 21);
            this.btnEditPicture.TabIndex = 5;
            this.btnEditPicture.Text = "编辑";
            this.btnEditPicture.Click += new System.EventHandler(this.btnEditPicture_Click);
            // 
            // OriginPicture
            // 
            this.OriginPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OriginPicture.Location = new System.Drawing.Point(0, 0);
            this.OriginPicture.Name = "OriginPicture";
            this.OriginPicture.Size = new System.Drawing.Size(280, 280);
            this.OriginPicture.TabIndex = 0;
            this.OriginPicture.TabStop = false;
            // 
            // ResultPicture
            // 
            this.ResultPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultPicture.Location = new System.Drawing.Point(0, 0);
            this.ResultPicture.Name = "ResultPicture";
            this.ResultPicture.Size = new System.Drawing.Size(280, 280);
            this.ResultPicture.TabIndex = 0;
            this.ResultPicture.TabStop = false;
            // 
            // EditPictureForCell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 646);
            this.Name = "EditPictureForCell";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axCell1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResultPicturePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OriginPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxCELL50Lib.AxCell axCell1;
        private DevExpress.XtraEditors.SimpleButton btnEditPicture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ResultPicturePanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox OriginPicture;
        private System.Windows.Forms.PictureBox ResultPicture;
    }
}