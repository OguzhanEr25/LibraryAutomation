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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Execute AdmınLog", bgl.Baglanti());
            da.Fill(dt);
            gridAdmin.DataSource = dt;
        }

        void Temizle()
        {
            txtID.Text = "";
            txtSifre.Text = "";
            txtKullaniciAd.Text = "";
            txtKullaniciSoyad.Text = "";
        }

        //public string yeniYol;
        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtID.Text = dr["kullaniciID"].ToString();
            txtSifre.Text = dr["kullaniciSifre"].ToString();
            txtKullaniciAd.Text =dr["kullaniciAd"].ToString();
            txtKullaniciSoyad.Text = dr["kullaniciSoyad"].ToString();
            //yeniYol = "C:\\Users\\oguz_\\source\\repos\\kutuphaneOtomasyonu\\kutuphaneOtomasyonu\\" + "\\Resimler\\" + dr["kullaniciFoto"].ToString();
            //pictureEdit1.Image = Image.FromFile(yeniYol);
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand("Insert into TblAdmin (kullaniciID,kullaniciSifre,kullaniciAd,kullaniciSoyad) values(@p1,@p2,@p3,@p4)", bgl.Baglanti());
            ekle.Parameters.AddWithValue("@p1", txtID.Text);
            ekle.Parameters.AddWithValue("@p2", txtSifre.Text);
            ekle.Parameters.AddWithValue("@p3", txtKullaniciAd.Text);
            ekle.Parameters.AddWithValue("@p4", txtKullaniciSoyad.Text);
            ekle.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Kullanıcı oluşturuldu", "Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Information);
            Listele();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("UPDATE TblAdmin set kullaniciSifre = @p1, kullaniciAd = @p2, kullaniciSoyad = @p3 WHERE kullaniciID = @p4", bgl.Baglanti());
            guncelle.Parameters.AddWithValue("@p1", txtSifre.Text);
            guncelle.Parameters.AddWithValue("@p2", txtKullaniciAd.Text);
            guncelle.Parameters.AddWithValue("@p3", txtKullaniciSoyad.Text);
            guncelle.Parameters.AddWithValue("@p4", txtID.Text);
            guncelle.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Kullanıcı güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();

        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
