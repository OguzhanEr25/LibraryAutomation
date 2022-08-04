using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace kutuphaneOtomasyonu.Formlar
{
    public partial class FrmKitaplar : Form
    {
        public FrmKitaplar()
        {
            InitializeComponent();
        }

        DbKutuphaneEntities db =new DbKutuphaneEntities();
        SqlBaglantisi bgl = new SqlBaglantisi();
        
        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TblKitaplar Where kitapTuru ='Comedy|Drama'", bgl.Baglanti());
            da.Fill(dt);
            gridBilimKurgu.DataSource = dt;

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from TblKitaplar Where kitapTuru ='Documentary'", bgl.Baglanti());
            da2.Fill(dt2);
            gridFantastik.DataSource = dt2;

            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter("select * from TblKitaplar Where kitapTuru ='Crime|Drama'", bgl.Baglanti());
            da3.Fill(dt3);
            gridTarihi.DataSource = dt3;

            DataTable dt4 = new DataTable();
            SqlDataAdapter da4 = new SqlDataAdapter("select * from TblKitaplar Where kitapTuru ='Horror'", bgl.Baglanti());
            da4.Fill(dt4);
            gridCocuk.DataSource = dt4;

            DataTable dt5 = new DataTable();
            SqlDataAdapter da5 = new SqlDataAdapter("select * from TblKitaplar Where kitapTuru ='Drama'", bgl.Baglanti());
            da5.Fill(dt5);
            gridSosyoloji.DataSource = dt5;

            DataTable dt6 = new DataTable();
            SqlDataAdapter da6 = new SqlDataAdapter("Select * From TblKitaplar", bgl.Baglanti());
            da6.Fill(dt6);
            gridTumu.DataSource = dt6;
        }

        void Temizle()
        {
            txtKitapAd.Text = "";
            txtYazar.Text = "";
            cmBoxTur.Text = "";
            dateBaskiYili.Text = "";
            LblKitapDili.Text = "";
            txtYayinEvi.Text = "";
            rchAciklama.Text = "";
            pctBox.ImageLocation = "";

        }

        void turEkle() //comboBax da kitap türlerini gösterme metodu
        {
            SqlCommand turEkle = new SqlCommand("Select * From TblKitapTurleri", bgl.Baglanti());
            SqlDataReader dr = turEkle.ExecuteReader();
            while (dr.Read())
            {
                cmBoxTur.Properties.Items.Add(dr[1]);
            }
            bgl.Baglanti().Close();
        }

        private void FrmKitaplar_Load(object sender, EventArgs e)
        {
            Listele();
            turEkle();
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(dr != null)
            {
                txtID.Text = dr["kitapID"].ToString();
                txtKitapAd.Text = dr["kitapAd"].ToString();
                txtYazar.Text = dr["kitapYazari"].ToString();
                cmBoxTur.Text = dr["kitapTuru"].ToString();
                dateBaskiYili.Text = dr["kitapBaskiYili"].ToString();
                txtKitapDili .Text = dr["kitapDili"].ToString();
                txtYayinEvi.Text = dr["YayinEvi"].ToString();
                rchAciklama.Text = dr["Aciklama"].ToString();
                yeniYol = "C:\\Users\\oguz_\\source\\repos\\kutuphaneOtomasyonu\\kutuphaneOtomasyonu" + "\\Resimler\\" + dr["kitapFoto"].ToString();
                pctBox.ImageLocation = yeniYol;
            }
        }

        private void gridView2_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr2 = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            if (dr2 != null)
            {
                txtID.Text = dr2["kitapID"].ToString();
                txtKitapAd.Text = dr2["kitapAd"].ToString();
                txtYazar.Text = dr2["kitapYazari"].ToString();
                cmBoxTur.Text = dr2["kitapTuru"].ToString();
                dateBaskiYili.Text = dr2["kitapBaskiYili"].ToString();
                txtKitapDili.Text = dr2["kitapDili"].ToString();
                txtYayinEvi.Text = dr2["YayinEvi"].ToString();
                rchAciklama.Text = dr2["Aciklama"].ToString();
                yeniYol = "C:\\Users\\oguz_\\source\\repos\\kutuphaneOtomasyonu\\kutuphaneOtomasyonu" + "\\Resimler\\" + dr2["kitapFoto"].ToString();
                pctBox.ImageLocation = yeniYol;
            }
        }

        private void gridView3_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr3 = gridView3.GetDataRow(gridView3.FocusedRowHandle);
            if (dr3 != null)
            {
                txtID.Text = dr3["kitapID"].ToString();
                txtKitapAd.Text = dr3["kitapAd"].ToString();
                txtYazar.Text = dr3["kitapYazari"].ToString();
                cmBoxTur.Text = dr3["kitapTuru"].ToString();
                dateBaskiYili.Text = dr3["kitapBaskiYili"].ToString();
                txtKitapDili.Text = dr3["kitapDili"].ToString();
                txtYayinEvi.Text = dr3["YayinEvi"].ToString();
                rchAciklama.Text = dr3["Aciklama"].ToString();
                yeniYol = "C:\\Users\\oguz_\\source\\repos\\kutuphaneOtomasyonu\\kutuphaneOtomasyonu" + "\\Resimler\\" + dr3["kitapFoto"].ToString();
                pctBox.ImageLocation = yeniYol;
            }
        }

        private void gridView4_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr4 = gridView4.GetDataRow(gridView4.FocusedRowHandle);
            if (dr4 != null)
            {
                txtID.Text = dr4["kitapID"].ToString();
                txtKitapAd.Text = dr4["kitapAd"].ToString();
                txtYazar.Text = dr4["kitapYazari"].ToString();
                cmBoxTur.Text = dr4["kitapTuru"].ToString();
                dateBaskiYili.Text = dr4["kitapBaskiYili"].ToString();
                txtKitapDili.Text = dr4["kitapDili"].ToString();
                txtYayinEvi.Text = dr4["YayinEvi"].ToString();
                rchAciklama.Text = dr4["Aciklama"].ToString();
                yeniYol = "C:\\Users\\oguz_\\source\\repos\\kutuphaneOtomasyonu\\kutuphaneOtomasyonu" + "\\Resimler\\" + dr4["kitapFoto"].ToString();
                pctBox.ImageLocation = yeniYol;
            }
        }

        private void gridView5_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr5 = gridView5.GetDataRow(gridView5.FocusedRowHandle);
            if (dr5 != null)
            {
                txtID.Text = dr5["kitapID"].ToString();
                txtKitapAd.Text = dr5["kitapAd"].ToString();
                txtYazar.Text = dr5["kitapYazari"].ToString();
                cmBoxTur.Text = dr5["kitapTuru"].ToString();
                dateBaskiYili.Text = dr5["kitapBaskiYili"].ToString();
                txtKitapDili.Text = dr5["kitapDili"].ToString();
                txtYayinEvi.Text = dr5["YayinEvi"].ToString();
                rchAciklama.Text = dr5["Aciklama"].ToString();
                yeniYol = "C:\\Users\\oguz_\\source\\repos\\kutuphaneOtomasyonu\\kutuphaneOtomasyonu" + "\\Resimler\\" + dr5["kitapFoto"].ToString();
                pctBox.ImageLocation = yeniYol;
            }
        }
        private void gridView6_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr6 = gridView5.GetDataRow(gridView6.FocusedRowHandle);
            if (dr6 != null)
            {
                txtID.Text = dr6["kitapID"].ToString();
                txtKitapAd.Text = dr6["kitapAd"].ToString();
                txtYazar.Text = dr6["kitapYazari"].ToString();
                cmBoxTur.Text = dr6["kitapTuru"].ToString();
                dateBaskiYili.Text = dr6["kitapBaskiYili"].ToString();
                txtKitapDili.Text = dr6["kitapDili"].ToString();
                txtYayinEvi.Text = dr6["YayinEvi"].ToString();
                rchAciklama.Text = dr6["Aciklama"].ToString();
                yeniYol = "C:\\Users\\oguz_\\source\\repos\\kutuphaneOtomasyonu\\kutuphaneOtomasyonu" + "\\Resimler\\" + dr6["kitapFoto"].ToString();
                pctBox.ImageLocation = yeniYol;
            }
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            //SqlCommand ekle = new SqlCommand("Insert into TblKitaplar (kitapAd,kitapYazari,kitapTuru,kitapBaskiYili,kitapDili,YayinEvi," +
            //    "Aciklama,kitapFoto)" +
            //    " values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.Baglanti());
            //ekle.Parameters.AddWithValue("@p1", txtKitapAd.Text);
            //ekle.Parameters.AddWithValue("@p2", txtYazar.Text);
            //ekle.Parameters.AddWithValue("@p3", cmBoxTur.Text);
            //ekle.Parameters.AddWithValue("@p4", dateBaskiYili.Text);
            //ekle.Parameters.AddWithValue("@p5", txtKitapDili.Text);
            //ekle.Parameters.AddWithValue("@p6", txtYayinEvi.Text);
            //ekle.Parameters.AddWithValue("@p7", rchAciklama.Text);
            //ekle.Parameters.AddWithValue("@p8", Path.GetFileName(yeniYol));
            //ekle.ExecuteNonQuery();
            //bgl.Baglanti().Close();

            // Entities ile veri ekleme
            TblKitaplar ekle = new TblKitaplar();
            ekle.kitapAd = txtKitapAd.Text;
            ekle.kitapYazari = txtYazar.Text;
            ekle.kitapTuru = cmBoxTur.Text;
            ekle.kitapBaskiYili = Convert.ToDateTime(dateBaskiYili.Text);
            ekle.kitapDili = txtKitapDili.Text;
            ekle.YayinEvi = txtYayinEvi.Text;
            ekle.Aciklama = rchAciklama.Text;
            db.TblKitaplar.Add(ekle);
            db.SaveChanges();
            MessageBox.Show("Kİtap eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        public string yeniYol;
        private void BtnResimSec_Click(object sender, EventArgs e)  
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.png;*.nef | Tüm Dosyalar | *.*"; // Dosya uzantısı için filtreleme 
            dosya.ShowDialog();
            string dosyaYolu = dosya.FileName;
            yeniYol = "C:\\Users\\oguz_\\source\\repos\\kutuphaneOtomasyonu\\kutuphaneOtomasyonu\\"
                + "\\Resimler\\" + Guid.NewGuid().ToString();
            File.Copy(dosyaYolu, yeniYol);
            pctBox.ImageLocation = yeniYol;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            // ID'ye bağlı bütün verileri siler
            SqlCommand sil = new SqlCommand("Delete from TblKitaplar Where kitapID=@p1", bgl.Baglanti());
            sil.Parameters.AddWithValue("@P1", txtID.Text);
            sil.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Kitap silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Listele();
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            //SqlCommand guncelle = new SqlCommand("Update TblKitaplar set kitapAd=@p1, kitapYazari=@p2, kitapTuru=@p3, kitapBaskiYili=@p4," +
            //    " kitapDili=@p5, YayinEvi=@p6, Aciklama=@p7, kitapFoto=@p8 Where kitapID=@p9", bgl.Baglanti());
            //guncelle.Parameters.AddWithValue("@p1", txtKitapAd.Text);
            //guncelle.Parameters.AddWithValue("@p2", txtYazar.Text);
            //guncelle.Parameters.AddWithValue("@p3", cmBoxTur.Text);
            //guncelle.Parameters.AddWithValue("@p4", dateBaskiYili.Text);
            //guncelle.Parameters.AddWithValue("@p5", txtKitapDili.Text);
            //guncelle.Parameters.AddWithValue("@p6", txtYayinEvi.Text);
            //guncelle.Parameters.AddWithValue("@p7", rchAciklama.Text);
            //guncelle.Parameters.AddWithValue("@p8", Path.GetFileName(yeniYol));
            //guncelle.Parameters.AddWithValue("@p9", txtID.Text);
            //guncelle.ExecuteNonQuery();
            //bgl.Baglanti().Close();
            
            //Entities ile ID'ye göre veri güncelleme
            int id = Convert.ToInt32(txtID.Text);
            var guncelle = db.TblKitaplar.Find(id);
            guncelle.kitapAd = txtKitapAd.Text;
            guncelle.kitapYazari = txtYazar.Text;
            guncelle.kitapTuru = cmBoxTur.Text;
            guncelle.kitapBaskiYili = Convert.ToDateTime(dateBaskiYili.Text);
            guncelle.YayinEvi = txtYayinEvi.Text;
            guncelle.Aciklama = rchAciklama.Text;
            guncelle.kitapFoto = Path.GetFileName(yeniYol);
            db.SaveChanges();
            bgl.Baglanti().Close();
            MessageBox.Show("Kitap güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void txtKitapBul_EditValueChanged(object sender, EventArgs e)
        {
            // Aranan kitabı adına göre listede gösterme
            string arananKitap = txtKitapBul.Text;
            var degerler = from item in db.TblKitaplar
                           where item.kitapAd.Contains(arananKitap)
                           select item;
            gridTumu.DataSource = degerler.ToList();
        }
    }
}
