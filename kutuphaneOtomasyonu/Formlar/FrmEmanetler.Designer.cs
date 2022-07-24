
namespace kutuphaneOtomasyonu.Formlar
{
    partial class FrmEmanetler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmanetler));
            this.gridEmanetler = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.chDurum = new DevExpress.XtraEditors.CheckEdit();
            this.txtEmntVerme = new DevExpress.XtraEditors.TextEdit();
            this.txtIslem = new DevExpress.XtraEditors.TextEdit();
            this.LblKitapDili = new DevExpress.XtraEditors.LabelControl();
            this.LblYayinEvi = new DevExpress.XtraEditors.LabelControl();
            this.BtnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGüncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.txtUyeID = new DevExpress.XtraEditors.TextEdit();
            this.txtKitapID = new DevExpress.XtraEditors.TextEdit();
            this.txtEmntAlma = new DevExpress.XtraEditors.TextEdit();
            this.txtEmntNo = new DevExpress.XtraEditors.TextEdit();
            this.LblBaskiYil = new DevExpress.XtraEditors.LabelControl();
            this.LblKitapAd = new DevExpress.XtraEditors.LabelControl();
            this.LblKitapTur = new DevExpress.XtraEditors.LabelControl();
            this.LblYazar = new DevExpress.XtraEditors.LabelControl();
            this.LblID = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmanetler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chDurum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmntVerme.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIslem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUyeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKitapID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmntAlma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmntNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridEmanetler
            // 
            this.gridEmanetler.Location = new System.Drawing.Point(2, 1);
            this.gridEmanetler.MainView = this.gridView1;
            this.gridEmanetler.Name = "gridEmanetler";
            this.gridEmanetler.Size = new System.Drawing.Size(868, 535);
            this.gridEmanetler.TabIndex = 7;
            this.gridEmanetler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridEmanetler;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.gridView1_FocusedRowObjectChanged);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(864, 1);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage2;
            this.xtraTabControl1.Size = new System.Drawing.Size(321, 535);
            this.xtraTabControl1.TabIndex = 6;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.groupControl1);
            this.xtraTabPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage2.ImageOptions.Image")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(319, 507);
            this.xtraTabPage2.Text = "Emanetler Bilgiler";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.chDurum);
            this.groupControl1.Controls.Add(this.txtEmntVerme);
            this.groupControl1.Controls.Add(this.txtIslem);
            this.groupControl1.Controls.Add(this.LblKitapDili);
            this.groupControl1.Controls.Add(this.LblYayinEvi);
            this.groupControl1.Controls.Add(this.BtnTemizle);
            this.groupControl1.Controls.Add(this.BtnGüncelle);
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.BtnEkle);
            this.groupControl1.Controls.Add(this.txtUyeID);
            this.groupControl1.Controls.Add(this.txtKitapID);
            this.groupControl1.Controls.Add(this.txtEmntAlma);
            this.groupControl1.Controls.Add(this.txtEmntNo);
            this.groupControl1.Controls.Add(this.LblBaskiYil);
            this.groupControl1.Controls.Add(this.LblKitapAd);
            this.groupControl1.Controls.Add(this.LblKitapTur);
            this.groupControl1.Controls.Add(this.LblYazar);
            this.groupControl1.Controls.Add(this.LblID);
            this.groupControl1.Location = new System.Drawing.Point(0, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(316, 501);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // chDurum
            // 
            this.chDurum.Location = new System.Drawing.Point(199, 242);
            this.chDurum.Name = "chDurum";
            this.chDurum.Properties.Caption = "";
            this.chDurum.Size = new System.Drawing.Size(75, 20);
            this.chDurum.TabIndex = 29;
            // 
            // txtEmntVerme
            // 
            this.txtEmntVerme.Location = new System.Drawing.Point(163, 148);
            this.txtEmntVerme.Name = "txtEmntVerme";
            this.txtEmntVerme.Size = new System.Drawing.Size(100, 20);
            this.txtEmntVerme.TabIndex = 28;
            // 
            // txtIslem
            // 
            this.txtIslem.Location = new System.Drawing.Point(163, 215);
            this.txtIslem.Name = "txtIslem";
            this.txtIslem.Size = new System.Drawing.Size(100, 20);
            this.txtIslem.TabIndex = 27;
            // 
            // LblKitapDili
            // 
            this.LblKitapDili.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKitapDili.Appearance.Options.UseFont = true;
            this.LblKitapDili.Location = new System.Drawing.Point(34, 218);
            this.LblKitapDili.Name = "LblKitapDili";
            this.LblKitapDili.Size = new System.Drawing.Size(69, 14);
            this.LblKitapDili.TabIndex = 26;
            this.LblKitapDili.Text = "İşlem Tarihi :";
            // 
            // LblYayinEvi
            // 
            this.LblYayinEvi.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblYayinEvi.Appearance.Options.UseFont = true;
            this.LblYayinEvi.Location = new System.Drawing.Point(34, 244);
            this.LblYayinEvi.Name = "LblYayinEvi";
            this.LblYayinEvi.Size = new System.Drawing.Size(90, 14);
            this.LblYayinEvi.TabIndex = 22;
            this.LblYayinEvi.Text = "Emanet Durum :";
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnTemizle.ImageOptions.Image")));
            this.BtnTemizle.Location = new System.Drawing.Point(128, 437);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(75, 23);
            this.BtnTemizle.TabIndex = 20;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGüncelle.ImageOptions.Image")));
            this.BtnGüncelle.Location = new System.Drawing.Point(128, 397);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(75, 23);
            this.BtnGüncelle.TabIndex = 16;
            this.BtnGüncelle.Text = "Güncelle";
            this.BtnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(128, 351);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(75, 23);
            this.BtnSil.TabIndex = 15;
            this.BtnSil.Text = "Sil";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnEkle.ImageOptions.Image")));
            this.BtnEkle.Location = new System.Drawing.Point(128, 306);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(75, 23);
            this.BtnEkle.TabIndex = 14;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // txtUyeID
            // 
            this.txtUyeID.Location = new System.Drawing.Point(163, 78);
            this.txtUyeID.Name = "txtUyeID";
            this.txtUyeID.Size = new System.Drawing.Size(100, 20);
            this.txtUyeID.TabIndex = 12;
            // 
            // txtKitapID
            // 
            this.txtKitapID.Location = new System.Drawing.Point(163, 113);
            this.txtKitapID.Name = "txtKitapID";
            this.txtKitapID.Size = new System.Drawing.Size(100, 20);
            this.txtKitapID.TabIndex = 11;
            // 
            // txtEmntAlma
            // 
            this.txtEmntAlma.Location = new System.Drawing.Point(163, 182);
            this.txtEmntAlma.Name = "txtEmntAlma";
            this.txtEmntAlma.Size = new System.Drawing.Size(100, 20);
            this.txtEmntAlma.TabIndex = 8;
            // 
            // txtEmntNo
            // 
            this.txtEmntNo.EditValue = "";
            this.txtEmntNo.Enabled = false;
            this.txtEmntNo.Location = new System.Drawing.Point(163, 44);
            this.txtEmntNo.Name = "txtEmntNo";
            this.txtEmntNo.Size = new System.Drawing.Size(100, 20);
            this.txtEmntNo.TabIndex = 7;
            // 
            // LblBaskiYil
            // 
            this.LblBaskiYil.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblBaskiYil.Appearance.Options.UseFont = true;
            this.LblBaskiYil.Location = new System.Drawing.Point(34, 188);
            this.LblBaskiYil.Name = "LblBaskiYil";
            this.LblBaskiYil.Size = new System.Drawing.Size(113, 14);
            this.LblBaskiYil.TabIndex = 4;
            this.LblBaskiYil.Text = "Emanet Alma Tarihi :";
            // 
            // LblKitapAd
            // 
            this.LblKitapAd.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKitapAd.Appearance.Options.UseFont = true;
            this.LblKitapAd.Location = new System.Drawing.Point(34, 84);
            this.LblKitapAd.Name = "LblKitapAd";
            this.LblKitapAd.Size = new System.Drawing.Size(45, 14);
            this.LblKitapAd.TabIndex = 3;
            this.LblKitapAd.Text = "Uye ID :";
            // 
            // LblKitapTur
            // 
            this.LblKitapTur.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKitapTur.Appearance.Options.UseFont = true;
            this.LblKitapTur.Location = new System.Drawing.Point(34, 154);
            this.LblKitapTur.Name = "LblKitapTur";
            this.LblKitapTur.Size = new System.Drawing.Size(123, 14);
            this.LblKitapTur.TabIndex = 2;
            this.LblKitapTur.Text = "Emanet Verme Tarihi :";
            // 
            // LblYazar
            // 
            this.LblYazar.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblYazar.Appearance.Options.UseFont = true;
            this.LblYazar.Location = new System.Drawing.Point(34, 119);
            this.LblYazar.Name = "LblYazar";
            this.LblYazar.Size = new System.Drawing.Size(51, 14);
            this.LblYazar.TabIndex = 1;
            this.LblYazar.Text = "Kitap ID :";
            // 
            // LblID
            // 
            this.LblID.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblID.Appearance.Options.UseFont = true;
            this.LblID.Location = new System.Drawing.Point(34, 46);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(110, 14);
            this.LblID.TabIndex = 0;
            this.LblID.Text = "Emanet Numarası :  ";
            // 
            // FrmEmanetler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 536);
            this.Controls.Add(this.gridEmanetler);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "FrmEmanetler";
            this.Text = "Emanetler";
            this.Load += new System.EventHandler(this.FrmEmanetler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmanetler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chDurum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmntVerme.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIslem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUyeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKitapID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmntAlma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmntNo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridEmanetler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit chDurum;
        private DevExpress.XtraEditors.TextEdit txtEmntVerme;
        private DevExpress.XtraEditors.TextEdit txtIslem;
        private DevExpress.XtraEditors.LabelControl LblKitapDili;
        private DevExpress.XtraEditors.LabelControl LblYayinEvi;
        private DevExpress.XtraEditors.SimpleButton BtnTemizle;
        private DevExpress.XtraEditors.SimpleButton BtnGüncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnEkle;
        private DevExpress.XtraEditors.TextEdit txtUyeID;
        private DevExpress.XtraEditors.TextEdit txtKitapID;
        private DevExpress.XtraEditors.TextEdit txtEmntAlma;
        private DevExpress.XtraEditors.TextEdit txtEmntNo;
        private DevExpress.XtraEditors.LabelControl LblBaskiYil;
        private DevExpress.XtraEditors.LabelControl LblKitapAd;
        private DevExpress.XtraEditors.LabelControl LblKitapTur;
        private DevExpress.XtraEditors.LabelControl LblYazar;
        private DevExpress.XtraEditors.LabelControl LblID;
    }
}