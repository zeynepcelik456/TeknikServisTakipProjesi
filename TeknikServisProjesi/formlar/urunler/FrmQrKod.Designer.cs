namespace TeknikServisProjesi.formlar
{
    partial class FrmQrKod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQrKod));
            this.panel12 = new System.Windows.Forms.Panel();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.txtSerıNO = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit5 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerıNO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit5.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Black;
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel12.Location = new System.Drawing.Point(253, 111);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(250, 3);
            this.panel12.TabIndex = 45;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(264, 169);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(220, 172);
            this.pictureEdit1.TabIndex = 59;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.simpleButton4.Appearance.Options.UseBackColor = true;
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.ImageOptions.Image = global::TeknikServisProjesi.Properties.Resources.barcode2_32x32;
            this.simpleButton4.Location = new System.Drawing.Point(264, 120);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(220, 43);
            this.simpleButton4.TabIndex = 58;
            this.simpleButton4.Text = "Qr Kod Oluştur";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // txtSerıNO
            // 
            this.txtSerıNO.EditValue = "Seri No";
            this.txtSerıNO.Location = new System.Drawing.Point(253, 73);
            this.txtSerıNO.Name = "txtSerıNO";
            this.txtSerıNO.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtSerıNO.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSerıNO.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSerıNO.Properties.Appearance.Options.UseBackColor = true;
            this.txtSerıNO.Properties.Appearance.Options.UseFont = true;
            this.txtSerıNO.Properties.Appearance.Options.UseForeColor = true;
            this.txtSerıNO.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtSerıNO.Size = new System.Drawing.Size(186, 32);
            this.txtSerıNO.TabIndex = 44;
            // 
            // pictureEdit5
            // 
            this.pictureEdit5.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureEdit5.EditValue = ((object)(resources.GetObject("pictureEdit5.EditValue")));
            this.pictureEdit5.Location = new System.Drawing.Point(0, 0);
            this.pictureEdit5.Name = "pictureEdit5";
            this.pictureEdit5.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.pictureEdit5.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit5.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit5.Properties.PictureAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.pictureEdit5.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit5.Size = new System.Drawing.Size(386, 346);
            this.pictureEdit5.TabIndex = 42;
            // 
            // FrmQrKod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(515, 346);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.txtSerıNO);
            this.Controls.Add(this.pictureEdit5);
            this.Name = "FrmQrKod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmQrKod";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerıNO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit5.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private System.Windows.Forms.Panel panel12;
        private DevExpress.XtraEditors.TextEdit txtSerıNO;
        private DevExpress.XtraEditors.PictureEdit pictureEdit5;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}