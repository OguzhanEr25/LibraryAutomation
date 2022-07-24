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
    public partial class FrmEmanetler : Form
    {
        public FrmEmanetler()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        DataTable dt = new DataTable();
        void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Execute KitapEmanetler ", bgl.Baglanti());
            da.Fill(dt);
            
            gridEmanetler.DataSource = dt;
        }

        void Temizle()
        {
            txtEmntNo.Text = "";
            txtUyeID.Text = "";
            txtKitapID.Text = "";
            txtEmntVerme.Text = "";
            txtEmntAlma.Text = "";
            txtIslem.Text = "";
            chDurum.Text = "";
        }

        private void FrmEmanetler_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtEmntNo.Text = dr["EmanetNo"].ToString();
                txtUyeID.Text = dr["UyeID"].ToString();
                txtKitapID.Text = dr["kitapId"].ToString();
                txtEmntVerme.Text = dr["EmanetVermeTarihi"].ToString();
                txtEmntAlma.Text = dr["EmanetAlmaTarihi"].ToString();
                txtIslem.Text = dr["EmanetIslemTarihi"].ToString();
                chDurum.Text = dr["EmanetDurum"].ToString(); // bu şekilde mi sorulacak
            }
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand("Insert into TblEmanetler (UyeID,kitapId,EmanetVermeTarihi,EmanetIslemTarihi," +
                "EmanetDurum)" +
               " values(@p1,@p2,@p3,@p4,@p5)", bgl.Baglanti());
            ekle.Parameters.AddWithValue("@p1", txtUyeID.Text);
            ekle.Parameters.AddWithValue("@p2", txtKitapID.Text);
            ekle.Parameters.AddWithValue("@p3", txtEmntVerme.Text);
            ekle.Parameters.AddWithValue("@p4", txtIslem.Text);
            ekle.Parameters.AddWithValue("@p5", chDurum.Text);
            ekle.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Emanet Bilgileri Girildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("Update TblEmanetler set uyeID=@p1, kitapId=@p2, EmanetVermeTarihi=@p3, EmanetAlmaTarihi=@p4," +
                " EmanetIslemTarihi=@p5, EmanetDurum=@p6 Where EmanetNo=@p7", bgl.Baglanti());
            guncelle.Parameters.AddWithValue("@p1", txtUyeID.Text);
            guncelle.Parameters.AddWithValue("@p2", txtKitapID.Text);
            guncelle.Parameters.AddWithValue("@p3", txtEmntVerme.Text);
            guncelle.Parameters.AddWithValue("@p4", txtEmntAlma.Text);
            guncelle.Parameters.AddWithValue("@p5", txtIslem.Text);
            guncelle.Parameters.AddWithValue("@p6", chDurum.Text); // değişmiyor sorulacak
            guncelle.Parameters.AddWithValue("@p7", txtEmntNo.Text);
            guncelle.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Emanet Bilgileri güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("Delete from TblEmanetler Where EmanetNo=@p1", bgl.Baglanti());
            sil.Parameters.AddWithValue("@P1", txtEmntNo.Text);
            sil.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Emanet Bilgileri silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Listele();
        }
    }
}
