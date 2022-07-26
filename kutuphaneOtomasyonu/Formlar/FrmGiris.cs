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

namespace kutuphaneOtomasyonu.Formlar
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void smpButtonGiris_Click(object sender, EventArgs e)
        {
            SqlCommand giris = new SqlCommand("SELECT kullaniciID,kullaniciSifre FROM TblAdmin WHERE kullaniciID =@p1 and kullaniciSifre =@p2", bgl.Baglanti());
            giris.Parameters.AddWithValue("@p1", MscKullanici.Text);
            giris.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = giris.ExecuteReader();
            if (dr.Read())
            {
                Form1 frm1 = new Form1();
                frm1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı ID veya Şifre");
                MscKullanici.Text = "";
                txtSifre.Text = "";
            }
            bgl.Baglanti().Close(); 
        }
    }
}
