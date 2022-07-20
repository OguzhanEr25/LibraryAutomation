
namespace kutuphaneOtomasyonu.Formlar
{
    partial class FrmKitaplar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKitaplar));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BtnGüncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textEdit6 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.LblAciklama = new DevExpress.XtraEditors.LabelControl();
            this.LblYayinEvi = new DevExpress.XtraEditors.LabelControl();
            this.LblKitapDil = new DevExpress.XtraEditors.LabelControl();
            this.LblKitapAd = new DevExpress.XtraEditors.LabelControl();
            this.LblBaskiYili = new DevExpress.XtraEditors.LabelControl();
            this.LblYazar = new DevExpress.XtraEditors.LabelControl();
            this.LblID = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(1, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(677, 449);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(683, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage2;
            this.xtraTabControl1.Size = new System.Drawing.Size(266, 449);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.groupControl1);
            this.xtraTabPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage2.ImageOptions.Image")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(264, 421);
            this.xtraTabPage2.Text = "Kitap Bilgiler";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BtnGüncelle);
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.BtnEkle);
            this.groupControl1.Controls.Add(this.richTextBox1);
            this.groupControl1.Controls.Add(this.textEdit6);
            this.groupControl1.Controls.Add(this.textEdit5);
            this.groupControl1.Controls.Add(this.textEdit4);
            this.groupControl1.Controls.Add(this.textEdit3);
            this.groupControl1.Controls.Add(this.textEdit2);
            this.groupControl1.Controls.Add(this.textEdit1);
            this.groupControl1.Controls.Add(this.LblAciklama);
            this.groupControl1.Controls.Add(this.LblYayinEvi);
            this.groupControl1.Controls.Add(this.LblKitapDil);
            this.groupControl1.Controls.Add(this.LblKitapAd);
            this.groupControl1.Controls.Add(this.LblBaskiYili);
            this.groupControl1.Controls.Add(this.LblYazar);
            this.groupControl1.Controls.Add(this.LblID);
            this.groupControl1.Location = new System.Drawing.Point(0, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(264, 415);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGüncelle.ImageOptions.Image")));
            this.BtnGüncelle.Location = new System.Drawing.Point(84, 372);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(75, 23);
            this.BtnGüncelle.TabIndex = 16;
            this.BtnGüncelle.Text = "Güncelle";
            // 
            // BtnSil
            // 
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(84, 343);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(75, 23);
            this.BtnSil.TabIndex = 15;
            this.BtnSil.Text = "Sil";
            // 
            // BtnEkle
            // 
            this.BtnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnEkle.ImageOptions.Image")));
            this.BtnEkle.Location = new System.Drawing.Point(84, 314);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(75, 23);
            this.BtnEkle.TabIndex = 14;
            this.BtnEkle.Text = "Ekle";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(84, 202);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(133, 96);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // textEdit6
            // 
            this.textEdit6.Location = new System.Drawing.Point(117, 48);
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.Size = new System.Drawing.Size(100, 20);
            this.textEdit6.TabIndex = 12;
            // 
            // textEdit5
            // 
            this.textEdit5.Location = new System.Drawing.Point(117, 82);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Size = new System.Drawing.Size(100, 20);
            this.textEdit5.TabIndex = 11;
            // 
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(117, 114);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Size = new System.Drawing.Size(100, 20);
            this.textEdit4.TabIndex = 10;
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(117, 173);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(100, 20);
            this.textEdit3.TabIndex = 9;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(117, 143);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(100, 20);
            this.textEdit2.TabIndex = 8;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(117, 18);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 7;
            // 
            // LblAciklama
            // 
            this.LblAciklama.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAciklama.Appearance.Options.UseFont = true;
            this.LblAciklama.Location = new System.Drawing.Point(24, 204);
            this.LblAciklama.Name = "LblAciklama";
            this.LblAciklama.Size = new System.Drawing.Size(54, 14);
            this.LblAciklama.TabIndex = 6;
            this.LblAciklama.Text = "Açıklama :";
            // 
            // LblYayinEvi
            // 
            this.LblYayinEvi.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblYayinEvi.Appearance.Options.UseFont = true;
            this.LblYayinEvi.Location = new System.Drawing.Point(24, 175);
            this.LblYayinEvi.Name = "LblYayinEvi";
            this.LblYayinEvi.Size = new System.Drawing.Size(56, 14);
            this.LblYayinEvi.TabIndex = 5;
            this.LblYayinEvi.Text = "Yayın Evi :";
            // 
            // LblKitapDil
            // 
            this.LblKitapDil.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKitapDil.Appearance.Options.UseFont = true;
            this.LblKitapDil.Location = new System.Drawing.Point(24, 145);
            this.LblKitapDil.Name = "LblKitapDil";
            this.LblKitapDil.Size = new System.Drawing.Size(53, 14);
            this.LblKitapDil.TabIndex = 4;
            this.LblKitapDil.Text = "Kitap Dili :";
            // 
            // LblKitapAd
            // 
            this.LblKitapAd.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKitapAd.Appearance.Options.UseFont = true;
            this.LblKitapAd.Location = new System.Drawing.Point(24, 50);
            this.LblKitapAd.Name = "LblKitapAd";
            this.LblKitapAd.Size = new System.Drawing.Size(52, 14);
            this.LblKitapAd.TabIndex = 3;
            this.LblKitapAd.Text = "Kitap Adı:";
            // 
            // LblBaskiYili
            // 
            this.LblBaskiYili.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblBaskiYili.Appearance.Options.UseFont = true;
            this.LblBaskiYili.Location = new System.Drawing.Point(24, 116);
            this.LblBaskiYili.Name = "LblBaskiYili";
            this.LblBaskiYili.Size = new System.Drawing.Size(48, 14);
            this.LblBaskiYili.TabIndex = 2;
            this.LblBaskiYili.Text = "Baskı Yılı:";
            // 
            // LblYazar
            // 
            this.LblYazar.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblYazar.Appearance.Options.UseFont = true;
            this.LblYazar.Location = new System.Drawing.Point(24, 84);
            this.LblYazar.Name = "LblYazar";
            this.LblYazar.Size = new System.Drawing.Size(66, 14);
            this.LblYazar.TabIndex = 1;
            this.LblYazar.Text = "Kitap Yazarı:";
            // 
            // LblID
            // 
            this.LblID.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblID.Appearance.Options.UseFont = true;
            this.LblID.Location = new System.Drawing.Point(24, 20);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(16, 14);
            this.LblID.TabIndex = 0;
            this.LblID.Text = "ID:";
            // 
            // FrmKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 451);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmKitaplar";
            this.Text = "FrmKitaplar";
            this.Load += new System.EventHandler(this.FrmKitaplar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton BtnGüncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnEkle;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DevExpress.XtraEditors.TextEdit textEdit6;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl LblAciklama;
        private DevExpress.XtraEditors.LabelControl LblYayinEvi;
        private DevExpress.XtraEditors.LabelControl LblKitapDil;
        private DevExpress.XtraEditors.LabelControl LblKitapAd;
        private DevExpress.XtraEditors.LabelControl LblBaskiYili;
        private DevExpress.XtraEditors.LabelControl LblYazar;
        private DevExpress.XtraEditors.LabelControl LblID;
    }
}