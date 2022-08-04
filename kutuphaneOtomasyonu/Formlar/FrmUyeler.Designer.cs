
namespace kutuphaneOtomasyonu.Formlar
{
    partial class FrmUyeler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUyeler));
            this.gridControlUye = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.LblAdres = new DevExpress.XtraEditors.LabelControl();
            this.BtnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.pctBox = new System.Windows.Forms.PictureBox();
            this.BtnResimSec = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGüncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.rchAdres = new System.Windows.Forms.RichTextBox();
            this.txtAd = new DevExpress.XtraEditors.TextEdit();
            this.txtSoyad = new DevExpress.XtraEditors.TextEdit();
            this.txtTelefon = new DevExpress.XtraEditors.TextEdit();
            this.txtMail = new DevExpress.XtraEditors.TextEdit();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.LblKitapDil = new DevExpress.XtraEditors.LabelControl();
            this.LblKitapAd = new DevExpress.XtraEditors.LabelControl();
            this.LblBaskiYili = new DevExpress.XtraEditors.LabelControl();
            this.LblYazar = new DevExpress.XtraEditors.LabelControl();
            this.LblID = new DevExpress.XtraEditors.LabelControl();
            this.txtUyeAra = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUyeAra.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlUye
            // 
            this.gridControlUye.Location = new System.Drawing.Point(1, 1);
            this.gridControlUye.MainView = this.gridView1;
            this.gridControlUye.Name = "gridControlUye";
            this.gridControlUye.Size = new System.Drawing.Size(987, 629);
            this.gridControlUye.TabIndex = 1;
            this.gridControlUye.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlUye;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.gridView1_FocusedRowObjectChanged);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.xtraTabControl1.Location = new System.Drawing.Point(988, 1);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage2;
            this.xtraTabControl1.Size = new System.Drawing.Size(349, 630);
            this.xtraTabControl1.TabIndex = 2;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.groupControl1);
            this.xtraTabPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage2.ImageOptions.Image")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(347, 604);
            this.xtraTabPage2.Text = "Üye Bilgiler";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtUyeAra);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.LblAdres);
            this.groupControl1.Controls.Add(this.BtnTemizle);
            this.groupControl1.Controls.Add(this.pctBox);
            this.groupControl1.Controls.Add(this.BtnResimSec);
            this.groupControl1.Controls.Add(this.BtnGüncelle);
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.BtnEkle);
            this.groupControl1.Controls.Add(this.rchAdres);
            this.groupControl1.Controls.Add(this.txtAd);
            this.groupControl1.Controls.Add(this.txtSoyad);
            this.groupControl1.Controls.Add(this.txtTelefon);
            this.groupControl1.Controls.Add(this.txtMail);
            this.groupControl1.Controls.Add(this.txtID);
            this.groupControl1.Controls.Add(this.LblKitapDil);
            this.groupControl1.Controls.Add(this.LblKitapAd);
            this.groupControl1.Controls.Add(this.LblBaskiYili);
            this.groupControl1.Controls.Add(this.LblYazar);
            this.groupControl1.Controls.Add(this.LblID);
            this.groupControl1.Location = new System.Drawing.Point(-1, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(348, 601);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // LblAdres
            // 
            this.LblAdres.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.LblAdres.Appearance.Options.UseFont = true;
            this.LblAdres.Location = new System.Drawing.Point(38, 321);
            this.LblAdres.Name = "LblAdres";
            this.LblAdres.Size = new System.Drawing.Size(39, 14);
            this.LblAdres.TabIndex = 21;
            this.LblAdres.Text = "Adres :";
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnTemizle.ImageOptions.Image")));
            this.BtnTemizle.Location = new System.Drawing.Point(199, 526);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(75, 23);
            this.BtnTemizle.TabIndex = 20;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // pctBox
            // 
            this.pctBox.Location = new System.Drawing.Point(156, 5);
            this.pctBox.Name = "pctBox";
            this.pctBox.Size = new System.Drawing.Size(118, 118);
            this.pctBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBox.TabIndex = 19;
            this.pctBox.TabStop = false;
            // 
            // BtnResimSec
            // 
            this.BtnResimSec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnResimSec.ImageOptions.Image")));
            this.BtnResimSec.Location = new System.Drawing.Point(199, 479);
            this.BtnResimSec.Name = "BtnResimSec";
            this.BtnResimSec.Size = new System.Drawing.Size(75, 23);
            this.BtnResimSec.TabIndex = 18;
            this.BtnResimSec.Text = "Resim Seç";
            this.BtnResimSec.Click += new System.EventHandler(this.BtnResimSec_Click);
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGüncelle.ImageOptions.Image")));
            this.BtnGüncelle.Location = new System.Drawing.Point(70, 568);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(75, 23);
            this.BtnGüncelle.TabIndex = 16;
            this.BtnGüncelle.Text = "Güncelle";
            this.BtnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(70, 526);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(75, 23);
            this.BtnSil.TabIndex = 15;
            this.BtnSil.Text = "Sil";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnEkle.ImageOptions.Image")));
            this.BtnEkle.Location = new System.Drawing.Point(70, 479);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(75, 23);
            this.BtnEkle.TabIndex = 14;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // rchAdres
            // 
            this.rchAdres.Location = new System.Drawing.Point(156, 319);
            this.rchAdres.Name = "rchAdres";
            this.rchAdres.Size = new System.Drawing.Size(118, 76);
            this.rchAdres.TabIndex = 13;
            this.rchAdres.Text = "";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(156, 174);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 12;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(156, 209);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 11;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(156, 245);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 20);
            this.txtTelefon.TabIndex = 10;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(156, 280);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 20);
            this.txtMail.TabIndex = 8;
            // 
            // txtID
            // 
            this.txtID.EditValue = "";
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(156, 136);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 7;
            // 
            // LblKitapDil
            // 
            this.LblKitapDil.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.LblKitapDil.Appearance.Options.UseFont = true;
            this.LblKitapDil.Location = new System.Drawing.Point(38, 282);
            this.LblKitapDil.Name = "LblKitapDil";
            this.LblKitapDil.Size = new System.Drawing.Size(27, 14);
            this.LblKitapDil.TabIndex = 4;
            this.LblKitapDil.Text = "Mail :";
            // 
            // LblKitapAd
            // 
            this.LblKitapAd.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.LblKitapAd.Appearance.Options.UseFont = true;
            this.LblKitapAd.Location = new System.Drawing.Point(38, 176);
            this.LblKitapAd.Name = "LblKitapAd";
            this.LblKitapAd.Size = new System.Drawing.Size(23, 14);
            this.LblKitapAd.TabIndex = 3;
            this.LblKitapAd.Text = "Ad :";
            // 
            // LblBaskiYili
            // 
            this.LblBaskiYili.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.LblBaskiYili.Appearance.Options.UseFont = true;
            this.LblBaskiYili.Location = new System.Drawing.Point(38, 247);
            this.LblBaskiYili.Name = "LblBaskiYili";
            this.LblBaskiYili.Size = new System.Drawing.Size(42, 14);
            this.LblBaskiYili.TabIndex = 2;
            this.LblBaskiYili.Text = "Telefon";
            // 
            // LblYazar
            // 
            this.LblYazar.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.LblYazar.Appearance.Options.UseFont = true;
            this.LblYazar.Location = new System.Drawing.Point(38, 211);
            this.LblYazar.Name = "LblYazar";
            this.LblYazar.Size = new System.Drawing.Size(41, 14);
            this.LblYazar.TabIndex = 1;
            this.LblYazar.Text = "Soyad :";
            // 
            // LblID
            // 
            this.LblID.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.LblID.Appearance.Options.UseFont = true;
            this.LblID.Location = new System.Drawing.Point(38, 138);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(16, 14);
            this.LblID.TabIndex = 0;
            this.LblID.Text = "ID:";
            // 
            // txtUyeAra
            // 
            this.txtUyeAra.Location = new System.Drawing.Point(156, 419);
            this.txtUyeAra.Name = "txtUyeAra";
            this.txtUyeAra.Size = new System.Drawing.Size(100, 20);
            this.txtUyeAra.TabIndex = 23;
            this.txtUyeAra.EditValueChanged += new System.EventHandler(this.txtUyeAra_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(38, 421);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 14);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "Üye Ara :";
            // 
            // FrmUyeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 631);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.gridControlUye);
            this.Name = "FrmUyeler";
            this.Text = "Üyeler";
            this.Load += new System.EventHandler(this.FrmUyeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUyeAra.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlUye;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton BtnTemizle;
        private System.Windows.Forms.PictureBox pctBox;
        private DevExpress.XtraEditors.SimpleButton BtnResimSec;
        private DevExpress.XtraEditors.SimpleButton BtnGüncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnEkle;
        private System.Windows.Forms.RichTextBox rchAdres;
        private DevExpress.XtraEditors.TextEdit txtAd;
        private DevExpress.XtraEditors.TextEdit txtSoyad;
        private DevExpress.XtraEditors.TextEdit txtTelefon;
        private DevExpress.XtraEditors.TextEdit txtMail;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl LblKitapDil;
        private DevExpress.XtraEditors.LabelControl LblKitapAd;
        private DevExpress.XtraEditors.LabelControl LblBaskiYili;
        private DevExpress.XtraEditors.LabelControl LblYazar;
        private DevExpress.XtraEditors.LabelControl LblID;
        private DevExpress.XtraEditors.LabelControl LblAdres;
        private DevExpress.XtraEditors.TextEdit txtUyeAra;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}