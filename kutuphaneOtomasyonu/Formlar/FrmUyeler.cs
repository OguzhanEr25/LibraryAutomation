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
    public partial class FrmUyeler : Form
    {
        public FrmUyeler()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        DataTable dt = new DataTable();
        DbKutuphaneEntities db = new DbKutuphaneEntities();

        void Listele() // SQL deki verilerin grid üzerinde görünmesini sağlar
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TblUyeler", bgl.Baglanti());
            da.Fill(dt);
            gridControlUye.DataSource = dt;
        }

        void Temizle() // gruoup kontrolde bulunan textlerin içlerini temizler
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTelefon.Text = "";
            txtMail.Text = "";
            rchAdres.Text = "";
            pctBox.ImageLocation = "";
        }

        private void FrmUyeler_Load(object sender, EventArgs e) //Form 
        {
            Listele();
        }

        // gridView'de gösterilen verilerin textbox'larda da görülmesi
        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(dr != null)
            {
                txtID.Text = dr["ID"].ToString();
                txtAd.Text = dr["Ad"].ToString();
                txtSoyad.Text = dr["Soyad"].ToString();
                txtTelefon.Text = dr["Telefon"].ToString();
                txtMail.Text = dr["Mail"].ToString();
                rchAdres.Text = dr["Adres"].ToString();
                yeniYol = "C:\\Users\\oguz_\\source\\repos\\kutuphaneOtomasyonu\\kutuphaneOtomasyonu" + "\\Resimler\\" + dr["uyeFoto"].ToString();
                pctBox.ImageLocation = yeniYol;
            }
        }
        //Tabloya veri ekleme butonu
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand("Insert into TblUyeler (Ad,Soyad,Telefon,Mail,Adres,uyeFoto) values(@p1,@p2,@p3,@p4,@p5,@p6)", bgl.Baglanti());
            ekle.Parameters.AddWithValue("@p1", txtAd.Text);
            ekle.Parameters.AddWithValue("@p2", txtSoyad.Text);
            ekle.Parameters.AddWithValue("@p3", txtTelefon.Text);
            ekle.Parameters.AddWithValue("@p4", txtMail.Text);
            ekle.Parameters.AddWithValue("@p5", rchAdres.Text);
            ekle.Parameters.AddWithValue("@p6", Path.GetFileName(yeniYol));
            ekle.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Personel eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        public string yeniYol;
        private void BtnResimSec_Click(object sender, EventArgs e) // Dosyalardan resim seçebilmek için gereken metod
        {
            OpenFileDialog dosya =new OpenFileDialog();
            dosya.Filter = "Resim Dosyası | *.jpg; *; *.png; *.nef | Tüm Dosyalar | *.* "; // Resim dosyası türlerini filtreleme
            dosya.ShowDialog();
            string dosyaYolu = dosya.FileName; // seçilen dosyanın dosya adı
            yeniYol = "C:\\Users\\oguz_\\source\\repos\\kutuphaneOtomasyonu\\kutuphaneOtomasyonu" + "\\Resimler\\" + Guid.NewGuid().ToString() + ".jpg";
            File.Copy(dosyaYolu, yeniYol); // Resim dosyanın yolunu yeni yola kopyalama
            pctBox.ImageLocation = yeniYol;
        }
        // Güncelleme butonu
        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("Update TblUyeler set Ad=@p1, Soyad=@p2, Telefon=@p3,Mail=@p4, Adres=@p5, uyeFoto=@p6 Where ID=@p7", bgl.Baglanti());
            guncelle.Parameters.AddWithValue("@p1", txtAd.Text);
            guncelle.Parameters.AddWithValue("@p2", txtSoyad.Text);
            guncelle.Parameters.AddWithValue("@p3", txtTelefon.Text);
            guncelle.Parameters.AddWithValue("@p4", txtMail.Text);
            guncelle.Parameters.AddWithValue("@p5", rchAdres.Text);
            guncelle.Parameters.AddWithValue("@p6", Path.GetFileName(yeniYol));
            guncelle.Parameters.AddWithValue("@p7", txtID.Text);
            guncelle.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Personel güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();

        }
        // Temizle butonu
        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            // Verinin ID'sine bağlı bütün verileri siler
            SqlCommand sil = new SqlCommand("Delete from TblUyeler Where ID=@p1", bgl.Baglanti());
            sil.Parameters.AddWithValue("@P1", txtID.Text);
            sil.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Personel silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Listele();
        }

        private void txtUyeAra_EditValueChanged(object sender, EventArgs e) 
        {
            // Aranan üye ismini listede gösterme
            string uyeAra = txtUyeAra.Text;
            var deger = from item in db.TblUyeler
                        where item.Ad.Contains(uyeAra)
                        select item;
            gridControlUye.DataSource = deger.ToList();
        }
    }
}
