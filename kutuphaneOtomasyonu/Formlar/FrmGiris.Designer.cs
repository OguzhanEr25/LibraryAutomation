
namespace kutuphaneOtomasyonu.Formlar
{
    partial class FrmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSifre = new DevExpress.XtraEditors.TextEdit();
            this.LblKullanici = new DevExpress.XtraEditors.LabelControl();
            this.MscKullanici = new System.Windows.Forms.MaskedTextBox();
            this.LblSifre = new DevExpress.XtraEditors.LabelControl();
            this.smpButtonGiris = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.ForeColor = System.Drawing.SystemColors.Info;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 100);
            this.panel1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(18, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(476, 38);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kütüphane Otomasyon Giriş Ekranı";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(406, 203);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtSifre.Properties.Appearance.Options.UseBackColor = true;
            this.txtSifre.Properties.UseSystemPasswordChar = true;
            this.txtSifre.Size = new System.Drawing.Size(100, 20);
            this.txtSifre.TabIndex = 2;
            // 
            // LblKullanici
            // 
            this.LblKullanici.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKullanici.Appearance.Options.UseFont = true;
            this.LblKullanici.Location = new System.Drawing.Point(12, 198);
            this.LblKullanici.Name = "LblKullanici";
            this.LblKullanici.Size = new System.Drawing.Size(139, 25);
            this.LblKullanici.TabIndex = 3;
            this.LblKullanici.Text = "KULLANICI : ";
            // 
            // MscKullanici
            // 
            this.MscKullanici.Location = new System.Drawing.Point(157, 203);
            this.MscKullanici.Mask = "00000";
            this.MscKullanici.Name = "MscKullanici";
            this.MscKullanici.Size = new System.Drawing.Size(125, 20);
            this.MscKullanici.TabIndex = 4;
            this.MscKullanici.ValidatingType = typeof(int);
            // 
            // LblSifre
            // 
            this.LblSifre.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSifre.Appearance.Options.UseFont = true;
            this.LblSifre.Location = new System.Drawing.Point(314, 198);
            this.LblSifre.Name = "LblSifre";
            this.LblSifre.Size = new System.Drawing.Size(77, 25);
            this.LblSifre.TabIndex = 5;
            this.LblSifre.Text = "ŞİFRE :";
            // 
            // smpButtonGiris
            // 
            this.smpButtonGiris.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.smpButtonGiris.Appearance.Options.UseFont = true;
            this.smpButtonGiris.Location = new System.Drawing.Point(203, 285);
            this.smpButtonGiris.Name = "smpButtonGiris";
            this.smpButtonGiris.Size = new System.Drawing.Size(122, 42);
            this.smpButtonGiris.TabIndex = 6;
            this.smpButtonGiris.Text = "Giriş";
            this.smpButtonGiris.Click += new System.EventHandler(this.smpButtonGiris_Click);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(564, 411);
            this.Controls.Add(this.smpButtonGiris);
            this.Controls.Add(this.LblSifre);
            this.Controls.Add(this.MscKullanici);
            this.Controls.Add(this.LblKullanici);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "FrmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giris";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtSifre;
        private DevExpress.XtraEditors.LabelControl LblKullanici;
        private System.Windows.Forms.MaskedTextBox MscKullanici;
        private DevExpress.XtraEditors.LabelControl LblSifre;
        private DevExpress.XtraEditors.SimpleButton smpButtonGiris;
    }
}