﻿
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
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.dtIslemTarihi = new DevExpress.XtraEditors.DateEdit();
            this.txtEmanetBul = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.radioTumu = new System.Windows.Forms.RadioButton();
            this.radioEmntVerilen = new System.Windows.Forms.RadioButton();
            this.radioEmntAlinan = new System.Windows.Forms.RadioButton();
            this.BtnSirala = new DevExpress.XtraEditors.SimpleButton();
            this.dtEmanetAlma = new DevExpress.XtraEditors.DateEdit();
            this.dtEmanetVerme = new DevExpress.XtraEditors.DateEdit();
            this.chDurum = new DevExpress.XtraEditors.CheckEdit();
            this.LblKitapDili = new DevExpress.XtraEditors.LabelControl();
            this.LblYayinEvi = new DevExpress.XtraEditors.LabelControl();
            this.BtnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGüncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.txtUyeID = new DevExpress.XtraEditors.TextEdit();
            this.txtKitapID = new DevExpress.XtraEditors.TextEdit();
            this.txtEmntNo = new DevExpress.XtraEditors.TextEdit();
            this.LblBaskiYil = new DevExpress.XtraEditors.LabelControl();
            this.LblKitapAd = new DevExpress.XtraEditors.LabelControl();
            this.LblKitapTur = new DevExpress.XtraEditors.LabelControl();
            this.LblYazar = new DevExpress.XtraEditors.LabelControl();
            this.LblID = new DevExpress.XtraEditors.LabelControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmanetler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtIslemTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtIslemTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmanetBul.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmanetAlma.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmanetAlma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmanetVerme.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmanetVerme.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chDurum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUyeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKitapID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmntNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridEmanetler
            // 
            this.gridEmanetler.Location = new System.Drawing.Point(2, 1);
            this.gridEmanetler.MainView = this.gridView1;
            this.gridEmanetler.Name = "gridEmanetler";
            this.gridEmanetler.Size = new System.Drawing.Size(979, 616);
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
            this.xtraTabControl1.Location = new System.Drawing.Point(981, 1);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage2;
            this.xtraTabControl1.Size = new System.Drawing.Size(356, 616);
            this.xtraTabControl1.TabIndex = 6;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.groupControl1);
            this.xtraTabPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage2.ImageOptions.Image")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(354, 588);
            this.xtraTabPage2.Text = "Emanetler Bilgiler";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.progressBarControl1);
            this.groupControl1.Controls.Add(this.dtIslemTarihi);
            this.groupControl1.Controls.Add(this.txtEmanetBul);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.radioTumu);
            this.groupControl1.Controls.Add(this.radioEmntVerilen);
            this.groupControl1.Controls.Add(this.radioEmntAlinan);
            this.groupControl1.Controls.Add(this.BtnSirala);
            this.groupControl1.Controls.Add(this.dtEmanetAlma);
            this.groupControl1.Controls.Add(this.dtEmanetVerme);
            this.groupControl1.Controls.Add(this.chDurum);
            this.groupControl1.Controls.Add(this.LblKitapDili);
            this.groupControl1.Controls.Add(this.LblYayinEvi);
            this.groupControl1.Controls.Add(this.BtnTemizle);
            this.groupControl1.Controls.Add(this.BtnGüncelle);
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.BtnEkle);
            this.groupControl1.Controls.Add(this.txtUyeID);
            this.groupControl1.Controls.Add(this.txtKitapID);
            this.groupControl1.Controls.Add(this.txtEmntNo);
            this.groupControl1.Controls.Add(this.LblBaskiYil);
            this.groupControl1.Controls.Add(this.LblKitapAd);
            this.groupControl1.Controls.Add(this.LblKitapTur);
            this.groupControl1.Controls.Add(this.LblYazar);
            this.groupControl1.Controls.Add(this.LblID);
            this.groupControl1.Location = new System.Drawing.Point(0, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(354, 582);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Location = new System.Drawing.Point(39, 540);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Size = new System.Drawing.Size(121, 18);
            this.progressBarControl1.TabIndex = 8;
            // 
            // dtIslemTarihi
            // 
            this.dtIslemTarihi.EditValue = null;
            this.dtIslemTarihi.Location = new System.Drawing.Point(179, 209);
            this.dtIslemTarihi.Name = "dtIslemTarihi";
            this.dtIslemTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtIslemTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtIslemTarihi.Size = new System.Drawing.Size(100, 20);
            this.dtIslemTarihi.TabIndex = 38;
            // 
            // txtEmanetBul
            // 
            this.txtEmanetBul.Location = new System.Drawing.Point(179, 311);
            this.txtEmanetBul.Name = "txtEmanetBul";
            this.txtEmanetBul.Size = new System.Drawing.Size(100, 20);
            this.txtEmanetBul.TabIndex = 37;
            this.txtEmanetBul.EditValueChanged += new System.EventHandler(this.txtEmanetBul_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(50, 313);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 14);
            this.labelControl1.TabIndex = 36;
            this.labelControl1.Text = "Emanet Ara :  ";
            // 
            // radioTumu
            // 
            this.radioTumu.AutoSize = true;
            this.radioTumu.Location = new System.Drawing.Point(39, 410);
            this.radioTumu.Name = "radioTumu";
            this.radioTumu.Size = new System.Drawing.Size(51, 17);
            this.radioTumu.TabIndex = 35;
            this.radioTumu.TabStop = true;
            this.radioTumu.Text = "Tümü";
            this.radioTumu.UseVisualStyleBackColor = true;
            // 
            // radioEmntVerilen
            // 
            this.radioEmntVerilen.AutoSize = true;
            this.radioEmntVerilen.Location = new System.Drawing.Point(39, 474);
            this.radioEmntVerilen.Name = "radioEmntVerilen";
            this.radioEmntVerilen.Size = new System.Drawing.Size(108, 17);
            this.radioEmntVerilen.TabIndex = 34;
            this.radioEmntVerilen.TabStop = true;
            this.radioEmntVerilen.Text = "Emanet Verilenler";
            this.radioEmntVerilen.UseVisualStyleBackColor = true;
            // 
            // radioEmntAlinan
            // 
            this.radioEmntAlinan.AutoSize = true;
            this.radioEmntAlinan.Location = new System.Drawing.Point(39, 442);
            this.radioEmntAlinan.Name = "radioEmntAlinan";
            this.radioEmntAlinan.Size = new System.Drawing.Size(105, 17);
            this.radioEmntAlinan.TabIndex = 33;
            this.radioEmntAlinan.TabStop = true;
            this.radioEmntAlinan.Text = "Emanet Alınanlar";
            this.radioEmntAlinan.UseVisualStyleBackColor = true;
            // 
            // BtnSirala
            // 
            this.BtnSirala.Location = new System.Drawing.Point(54, 511);
            this.BtnSirala.Name = "BtnSirala";
            this.BtnSirala.Size = new System.Drawing.Size(75, 23);
            this.BtnSirala.TabIndex = 32;
            this.BtnSirala.Text = "Sırala";
            this.BtnSirala.Click += new System.EventHandler(this.BtnSirala_Click);
            // 
            // dtEmanetAlma
            // 
            this.dtEmanetAlma.EditValue = null;
            this.dtEmanetAlma.Location = new System.Drawing.Point(179, 179);
            this.dtEmanetAlma.Name = "dtEmanetAlma";
            this.dtEmanetAlma.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEmanetAlma.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEmanetAlma.Size = new System.Drawing.Size(100, 20);
            this.dtEmanetAlma.TabIndex = 31;
            // 
            // dtEmanetVerme
            // 
            this.dtEmanetVerme.EditValue = null;
            this.dtEmanetVerme.Location = new System.Drawing.Point(179, 145);
            this.dtEmanetVerme.Name = "dtEmanetVerme";
            this.dtEmanetVerme.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEmanetVerme.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEmanetVerme.Size = new System.Drawing.Size(100, 20);
            this.dtEmanetVerme.TabIndex = 30;
            // 
            // chDurum
            // 
            this.chDurum.Location = new System.Drawing.Point(213, 239);
            this.chDurum.Name = "chDurum";
            this.chDurum.Properties.Caption = "";
            this.chDurum.Size = new System.Drawing.Size(75, 20);
            this.chDurum.TabIndex = 29;
            // 
            // LblKitapDili
            // 
            this.LblKitapDili.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.LblKitapDili.Appearance.Options.UseFont = true;
            this.LblKitapDili.Location = new System.Drawing.Point(50, 215);
            this.LblKitapDili.Name = "LblKitapDili";
            this.LblKitapDili.Size = new System.Drawing.Size(69, 14);
            this.LblKitapDili.TabIndex = 26;
            this.LblKitapDili.Text = "İşlem Tarihi :";
            // 
            // LblYayinEvi
            // 
            this.LblYayinEvi.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.LblYayinEvi.Appearance.Options.UseFont = true;
            this.LblYayinEvi.Location = new System.Drawing.Point(50, 241);
            this.LblYayinEvi.Name = "LblYayinEvi";
            this.LblYayinEvi.Size = new System.Drawing.Size(90, 14);
            this.LblYayinEvi.TabIndex = 22;
            this.LblYayinEvi.Text = "Emanet Durum :";
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnTemizle.ImageOptions.Image")));
            this.BtnTemizle.Location = new System.Drawing.Point(188, 526);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(75, 23);
            this.BtnTemizle.TabIndex = 20;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGüncelle.ImageOptions.Image")));
            this.BtnGüncelle.Location = new System.Drawing.Point(188, 486);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(75, 23);
            this.BtnGüncelle.TabIndex = 16;
            this.BtnGüncelle.Text = "Güncelle";
            this.BtnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(188, 440);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(75, 23);
            this.BtnSil.TabIndex = 15;
            this.BtnSil.Text = "Sil";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnEkle.ImageOptions.Image")));
            this.BtnEkle.Location = new System.Drawing.Point(188, 395);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(75, 23);
            this.BtnEkle.TabIndex = 14;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // txtUyeID
            // 
            this.txtUyeID.Location = new System.Drawing.Point(179, 75);
            this.txtUyeID.Name = "txtUyeID";
            this.txtUyeID.Size = new System.Drawing.Size(100, 20);
            this.txtUyeID.TabIndex = 12;
            // 
            // txtKitapID
            // 
            this.txtKitapID.Location = new System.Drawing.Point(179, 110);
            this.txtKitapID.Name = "txtKitapID";
            this.txtKitapID.Size = new System.Drawing.Size(100, 20);
            this.txtKitapID.TabIndex = 11;
            // 
            // txtEmntNo
            // 
            this.txtEmntNo.EditValue = "";
            this.txtEmntNo.Enabled = false;
            this.txtEmntNo.Location = new System.Drawing.Point(179, 41);
            this.txtEmntNo.Name = "txtEmntNo";
            this.txtEmntNo.Size = new System.Drawing.Size(100, 20);
            this.txtEmntNo.TabIndex = 7;
            // 
            // LblBaskiYil
            // 
            this.LblBaskiYil.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.LblBaskiYil.Appearance.Options.UseFont = true;
            this.LblBaskiYil.Location = new System.Drawing.Point(50, 185);
            this.LblBaskiYil.Name = "LblBaskiYil";
            this.LblBaskiYil.Size = new System.Drawing.Size(113, 14);
            this.LblBaskiYil.TabIndex = 4;
            this.LblBaskiYil.Text = "Emanet Alma Tarihi :";
            // 
            // LblKitapAd
            // 
            this.LblKitapAd.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.LblKitapAd.Appearance.Options.UseFont = true;
            this.LblKitapAd.Location = new System.Drawing.Point(50, 81);
            this.LblKitapAd.Name = "LblKitapAd";
            this.LblKitapAd.Size = new System.Drawing.Size(45, 14);
            this.LblKitapAd.TabIndex = 3;
            this.LblKitapAd.Text = "Uye ID :";
            // 
            // LblKitapTur
            // 
            this.LblKitapTur.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.LblKitapTur.Appearance.Options.UseFont = true;
            this.LblKitapTur.Location = new System.Drawing.Point(50, 151);
            this.LblKitapTur.Name = "LblKitapTur";
            this.LblKitapTur.Size = new System.Drawing.Size(123, 14);
            this.LblKitapTur.TabIndex = 2;
            this.LblKitapTur.Text = "Emanet Verme Tarihi :";
            // 
            // LblYazar
            // 
            this.LblYazar.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.LblYazar.Appearance.Options.UseFont = true;
            this.LblYazar.Location = new System.Drawing.Point(50, 116);
            this.LblYazar.Name = "LblYazar";
            this.LblYazar.Size = new System.Drawing.Size(51, 14);
            this.LblYazar.TabIndex = 1;
            this.LblYazar.Text = "Kitap ID :";
            // 
            // LblID
            // 
            this.LblID.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.LblID.Appearance.Options.UseFont = true;
            this.LblID.Location = new System.Drawing.Point(50, 43);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(110, 14);
            this.LblID.TabIndex = 0;
            this.LblID.Text = "Emanet Numarası :  ";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // FrmEmanetler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 618);
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
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtIslemTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtIslemTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmanetBul.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmanetAlma.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmanetAlma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmanetVerme.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmanetVerme.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chDurum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUyeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKitapID.Properties)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl LblKitapDili;
        private DevExpress.XtraEditors.LabelControl LblYayinEvi;
        private DevExpress.XtraEditors.SimpleButton BtnTemizle;
        private DevExpress.XtraEditors.SimpleButton BtnGüncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnEkle;
        private DevExpress.XtraEditors.TextEdit txtUyeID;
        private DevExpress.XtraEditors.TextEdit txtKitapID;
        private DevExpress.XtraEditors.TextEdit txtEmntNo;
        private DevExpress.XtraEditors.LabelControl LblBaskiYil;
        private DevExpress.XtraEditors.LabelControl LblKitapAd;
        private DevExpress.XtraEditors.LabelControl LblKitapTur;
        private DevExpress.XtraEditors.LabelControl LblYazar;
        private DevExpress.XtraEditors.LabelControl LblID;
        private DevExpress.XtraEditors.DateEdit dtEmanetAlma;
        private DevExpress.XtraEditors.DateEdit dtEmanetVerme;
        private System.Windows.Forms.RadioButton radioEmntVerilen;
        private System.Windows.Forms.RadioButton radioEmntAlinan;
        private DevExpress.XtraEditors.SimpleButton BtnSirala;
        private System.Windows.Forms.RadioButton radioTumu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtEmanetBul;
        private DevExpress.XtraEditors.DateEdit dtIslemTarihi;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}