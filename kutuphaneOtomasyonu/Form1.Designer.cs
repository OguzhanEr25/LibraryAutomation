
namespace kutuphaneOtomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnAyarlar = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.FrmAnaSayfa = new DevExpress.XtraBars.BarButtonItem();
            this.BtnKitaplar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnUyeler = new DevExpress.XtraBars.BarButtonItem();
            this.btnEmanetler = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.btnAyarlar);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.Caption = "Admin";
            this.btnAyarlar.Id = 8;
            this.btnAyarlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAyarlar.ImageOptions.Image")));
            this.btnAyarlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAyarlar.ImageOptions.LargeImage")));
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAyarlar_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Kitap Ekle";
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Üye Ekle";
            this.barButtonItem6.Id = 6;
            this.barButtonItem6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.Image")));
            this.barButtonItem6.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.LargeImage")));
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Emanet Ekle";
            this.barButtonItem7.Id = 7;
            this.barButtonItem7.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.Image")));
            this.barButtonItem7.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.LargeImage")));
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.FrmAnaSayfa,
            this.BtnKitaplar,
            this.BtnUyeler,
            this.btnEmanetler,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.btnAyarlar});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2019;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(1343, 148);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // FrmAnaSayfa
            // 
            this.FrmAnaSayfa.Caption = "Ana Sayfa";
            this.FrmAnaSayfa.Id = 1;
            this.FrmAnaSayfa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("FrmAnaSayfa.ImageOptions.Image")));
            this.FrmAnaSayfa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FrmAnaSayfa.ImageOptions.LargeImage")));
            this.FrmAnaSayfa.Name = "FrmAnaSayfa";
            this.FrmAnaSayfa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FrmAnaSayfa_ItemClick);
            // 
            // BtnKitaplar
            // 
            this.BtnKitaplar.Caption = "Kitaplar";
            this.BtnKitaplar.Id = 2;
            this.BtnKitaplar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKitaplar.ImageOptions.Image")));
            this.BtnKitaplar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnKitaplar.ImageOptions.LargeImage")));
            this.BtnKitaplar.Name = "BtnKitaplar";
            this.BtnKitaplar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnKitaplar_ItemClick);
            // 
            // BtnUyeler
            // 
            this.BtnUyeler.Caption = "Üyeler";
            this.BtnUyeler.Id = 3;
            this.BtnUyeler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnUyeler.ImageOptions.Image")));
            this.BtnUyeler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnUyeler.ImageOptions.LargeImage")));
            this.BtnUyeler.Name = "BtnUyeler";
            this.BtnUyeler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnUyeler_ItemClick);
            // 
            // btnEmanetler
            // 
            this.btnEmanetler.Caption = "Emanetler Listesi";
            this.btnEmanetler.Id = 4;
            this.btnEmanetler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEmanetler.ImageOptions.Image")));
            this.btnEmanetler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEmanetler.ImageOptions.LargeImage")));
            this.btnEmanetler.Name = "btnEmanetler";
            this.btnEmanetler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEmanetler_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Kütüphane Bilgi Sistemi";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.FrmAnaSayfa);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnKitaplar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnUyeler);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnEmanetler);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 801);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane Otomasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem FrmAnaSayfa;
        private DevExpress.XtraBars.BarButtonItem BtnKitaplar;
        private DevExpress.XtraBars.BarButtonItem BtnUyeler;
        private DevExpress.XtraBars.BarButtonItem btnEmanetler;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnAyarlar;
    }
}

