
namespace kutuphaneOtomasyonu.Formlar
{
    partial class FrmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.gridAdmin = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabAdmin = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabKitap = new DevExpress.XtraTab.XtraTabPage();
            this.grpControlAdmin = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtKullaniciAd = new DevExpress.XtraEditors.TextEdit();
            this.txtSifre = new DevExpress.XtraEditors.TextEdit();
            this.BtnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtKullaniciSoyad = new DevExpress.XtraEditors.TextEdit();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lytID = new DevExpress.XtraLayout.LayoutControlItem();
            this.lytSoyad = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lytSifre = new DevExpress.XtraLayout.LayoutControlItem();
            this.lytAd = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabAdmin)).BeginInit();
            this.xtraTabAdmin.SuspendLayout();
            this.xtraTabKitap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpControlAdmin)).BeginInit();
            this.grpControlAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lytID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lytSoyad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lytSifre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lytAd)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAdmin
            // 
            this.gridAdmin.Location = new System.Drawing.Point(2, 1);
            this.gridAdmin.MainView = this.gridView1;
            this.gridAdmin.Name = "gridAdmin";
            this.gridAdmin.Size = new System.Drawing.Size(870, 534);
            this.gridAdmin.TabIndex = 3;
            this.gridAdmin.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridAdmin;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.gridView1_FocusedRowObjectChanged);
            // 
            // xtraTabAdmin
            // 
            this.xtraTabAdmin.Location = new System.Drawing.Point(871, 1);
            this.xtraTabAdmin.Name = "xtraTabAdmin";
            this.xtraTabAdmin.SelectedTabPage = this.xtraTabKitap;
            this.xtraTabAdmin.Size = new System.Drawing.Size(314, 535);
            this.xtraTabAdmin.TabIndex = 4;
            this.xtraTabAdmin.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabKitap});
            // 
            // xtraTabKitap
            // 
            this.xtraTabKitap.Controls.Add(this.grpControlAdmin);
            this.xtraTabKitap.Name = "xtraTabKitap";
            this.xtraTabKitap.Size = new System.Drawing.Size(312, 510);
            this.xtraTabKitap.Text = "Admin";
            // 
            // grpControlAdmin
            // 
            this.grpControlAdmin.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("grpControlAdmin.CaptionImageOptions.Image")));
            this.grpControlAdmin.Controls.Add(this.layoutControl1);
            this.grpControlAdmin.Location = new System.Drawing.Point(0, 0);
            this.grpControlAdmin.Name = "grpControlAdmin";
            this.grpControlAdmin.Size = new System.Drawing.Size(312, 510);
            this.grpControlAdmin.TabIndex = 0;
            this.grpControlAdmin.Text = "Admin Kullanıcı Ayarları";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtKullaniciAd);
            this.layoutControl1.Controls.Add(this.txtSifre);
            this.layoutControl1.Controls.Add(this.BtnTemizle);
            this.layoutControl1.Controls.Add(this.BtnGuncelle);
            this.layoutControl1.Controls.Add(this.BtnEkle);
            this.layoutControl1.Controls.Add(this.labelControl1);
            this.layoutControl1.Controls.Add(this.txtKullaniciSoyad);
            this.layoutControl1.Controls.Add(this.txtID);
            this.layoutControl1.Controls.Add(this.pictureEdit1);
            this.layoutControl1.Location = new System.Drawing.Point(37, 64);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(254, 322);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtKullaniciAd
            // 
            this.txtKullaniciAd.Location = new System.Drawing.Point(132, 188);
            this.txtKullaniciAd.Name = "txtKullaniciAd";
            this.txtKullaniciAd.Size = new System.Drawing.Size(110, 20);
            this.txtKullaniciAd.StyleController = this.layoutControl1;
            this.txtKullaniciAd.TabIndex = 13;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(132, 164);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(110, 20);
            this.txtSifre.StyleController = this.layoutControl1;
            this.txtSifre.TabIndex = 11;
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.BtnTemizle.Location = new System.Drawing.Point(79, 288);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(163, 22);
            this.BtnTemizle.StyleController = this.layoutControl1;
            this.BtnTemizle.TabIndex = 10;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(79, 262);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(163, 22);
            this.BtnGuncelle.StyleController = this.layoutControl1;
            this.BtnGuncelle.TabIndex = 9;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.BtnEkle.Location = new System.Drawing.Point(79, 236);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(163, 22);
            this.BtnEkle.StyleController = this.layoutControl1;
            this.BtnEkle.TabIndex = 8;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 236);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 13);
            this.labelControl1.StyleController = this.layoutControl1;
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "labelControl1";
            // 
            // txtKullaniciSoyad
            // 
            this.txtKullaniciSoyad.Location = new System.Drawing.Point(132, 212);
            this.txtKullaniciSoyad.Name = "txtKullaniciSoyad";
            this.txtKullaniciSoyad.Size = new System.Drawing.Size(110, 20);
            this.txtKullaniciSoyad.StyleController = this.layoutControl1;
            this.txtKullaniciSoyad.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(132, 140);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(110, 20);
            this.txtID.StyleController = this.layoutControl1;
            this.txtID.TabIndex = 4;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(132, 12);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(110, 124);
            this.pictureEdit1.StyleController = this.layoutControl1;
            this.pictureEdit1.TabIndex = 3;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.lytID,
            this.lytSoyad,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.lytSifre,
            this.lytAd});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(254, 322);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.pictureEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(234, 128);
            this.layoutControlItem1.Text = "                                    ";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(108, 13);
            // 
            // lytID
            // 
            this.lytID.Control = this.txtID;
            this.lytID.Location = new System.Drawing.Point(0, 128);
            this.lytID.Name = "lytID";
            this.lytID.Size = new System.Drawing.Size(234, 24);
            this.lytID.Text = "Kullanıcı ID :";
            this.lytID.TextSize = new System.Drawing.Size(108, 13);
            // 
            // lytSoyad
            // 
            this.lytSoyad.Control = this.txtKullaniciSoyad;
            this.lytSoyad.Location = new System.Drawing.Point(0, 200);
            this.lytSoyad.Name = "lytSoyad";
            this.lytSoyad.Size = new System.Drawing.Size(234, 24);
            this.lytSoyad.Text = "Kullanıcı Soyad :";
            this.lytSoyad.TextSize = new System.Drawing.Size(108, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.labelControl1;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 224);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(67, 78);
            this.layoutControlItem6.Text = " ";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.BtnEkle;
            this.layoutControlItem7.Location = new System.Drawing.Point(67, 224);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(167, 26);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.BtnGuncelle;
            this.layoutControlItem8.Location = new System.Drawing.Point(67, 250);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(167, 26);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.BtnTemizle;
            this.layoutControlItem9.Location = new System.Drawing.Point(67, 276);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(167, 26);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // lytSifre
            // 
            this.lytSifre.Control = this.txtSifre;
            this.lytSifre.Location = new System.Drawing.Point(0, 152);
            this.lytSifre.Name = "lytSifre";
            this.lytSifre.Size = new System.Drawing.Size(234, 24);
            this.lytSifre.Text = "Kullanıcı Şifre :";
            this.lytSifre.TextSize = new System.Drawing.Size(108, 13);
            // 
            // lytAd
            // 
            this.lytAd.Control = this.txtKullaniciAd;
            this.lytAd.Location = new System.Drawing.Point(0, 176);
            this.lytAd.Name = "lytAd";
            this.lytAd.Size = new System.Drawing.Size(234, 24);
            this.lytAd.Text = "Kullanıcı Adı :";
            this.lytAd.TextSize = new System.Drawing.Size(108, 13);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 536);
            this.Controls.Add(this.gridAdmin);
            this.Controls.Add(this.xtraTabAdmin);
            this.Name = "FrmAdmin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabAdmin)).EndInit();
            this.xtraTabAdmin.ResumeLayout(false);
            this.xtraTabKitap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpControlAdmin)).EndInit();
            this.grpControlAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lytID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lytSoyad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lytSifre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lytAd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridAdmin;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabControl xtraTabAdmin;
        private DevExpress.XtraTab.XtraTabPage xtraTabKitap;
        private DevExpress.XtraEditors.GroupControl grpControlAdmin;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAd;
        private DevExpress.XtraEditors.TextEdit txtSifre;
        private DevExpress.XtraEditors.SimpleButton BtnTemizle;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnEkle;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtKullaniciSoyad;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem lytID;
        private DevExpress.XtraLayout.LayoutControlItem lytSoyad;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem lytSifre;
        private DevExpress.XtraLayout.LayoutControlItem lytAd;
    }
}