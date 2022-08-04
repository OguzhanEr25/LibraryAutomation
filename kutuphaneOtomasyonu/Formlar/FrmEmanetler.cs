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
using DevExpress.XtraEditors;


namespace kutuphaneOtomasyonu.Formlar
{
    public partial class FrmEmanetler : Form
    {
        public FrmEmanetler()
        {
            InitializeComponent();
        }

        DbKutuphaneEntities db = new DbKutuphaneEntities();
        SqlBaglantisi bgl = new SqlBaglantisi();
        DataTable dt = new DataTable();
        void Listele()
        {
            //Procedure ile kitaplar tablosunu çağırma
            SqlDataAdapter da = new SqlDataAdapter("Execute KitapEmanetler ", bgl.Baglanti());
            da.Fill(dt);

            gridEmanetler.DataSource = dt;

            // Entities ile verileri çağırma
            //var deger = (from item in db.TblEmanetler
            //             select new
            //             {
            //                 item.EmanetNo,
            //                 item.uyeID,
            //                 item.TblUyeler.Ad,
            //                 item.kitapId,
            //                 item.TblKitaplar.kitapAd,
            //                 item.EmanetVermeTarihi,
            //                 item.EmanetAlmaTarihi,
            //                 item.EmanetIslemTarihi,
            //                 item.EmanetDurum
            //             });
            //gridEmanetler.DataSource = deger.ToList();

            //gridEmanetler.DataSource = db.TblEmanetler.ToList();
        }

        void Temizle()
        {
            txtEmntNo.Text = "";
            txtUyeID.Text = "";
            txtKitapID.Text = "";
            dtEmanetVerme.Text = "";
            dtEmanetAlma.Text = "";
            txtIslem.Text = "";
            chDurum.Text = "";
        }

        private void FrmEmanetler_Load(object sender, EventArgs e) 
        {
            Listele();
        }
        
        // gridView'de gösterilen verilerin satırlarını groupControl üzerine yansıtma
        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {

            txtEmntNo.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "EmanetNo").ToString();
            txtUyeID.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "uyeID").ToString();
            txtKitapID.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "kitapId").ToString();
            dtEmanetVerme.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "EmanetVermeTarihi").ToString();
            dtEmanetAlma.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "EmanetAlmaTarihi").ToString();
            txtIslem.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "EmanetIslemTarihi").ToString();
            chDurum.Checked = Convert.ToBoolean(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "EmanetDurum").ToString());
        }

            private void BtnEkle_Click(object sender, EventArgs e)
        {
            //SqlCommand ekle = new SqlCommand("Insert into TblEmanetler (UyeID,kitapId,EmanetVermeTarihi,EmanetIslemTarihi," +
            //    "EmanetDurum)" +
            //   " values(@p1,@p2,@p3,@p4,@p5)", bgl.Baglanti());
            //ekle.Parameters.AddWithValue("@p1", txtUyeID.Text);
            //ekle.Parameters.AddWithValue("@p2", txtKitapID.Text);
            //ekle.Parameters.AddWithValue("@p3", txtEmntVerme.Text);
            //ekle.Parameters.AddWithValue("@p4", txtIslem.Text);
            //ekle.Parameters.AddWithValue("@p5", chDurum.Text);
            //ekle.ExecuteNonQuery();
            //bgl.Baglanti().Close();

            
            // Entities ile veri ekleme
            TblEmanetler emanet = new TblEmanetler();
            emanet.uyeID = Convert.ToInt32(txtUyeID.Text);
            emanet.kitapId = Convert.ToInt32(txtKitapID.Text);
            emanet.EmanetVermeTarihi = Convert.ToDateTime(dtEmanetVerme.Text);
            emanet.EmanetAlmaTarihi = Convert.ToDateTime(dtEmanetAlma.Text);
            emanet.EmanetIslemTarihi = Convert.ToDateTime(txtIslem.Text);
            // checkEdit durum kontrol
            if(chDurum.Checked == true)
            {
                chDurum.Visible = true;
            }
            else
            {
                chDurum.Visible = false;
            }
            emanet.EmanetDurum = chDurum.Checked;
            db.TblEmanetler.Add(emanet);
            db.SaveChanges();
            MessageBox.Show("Emanet Bilgileri Girildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        // Güncelleme butonu
        private void BtnGüncelle_Click(object sender, EventArgs e)
        {

            //SqlCommand guncelle = new SqlCommand("Update TblEmanetler set uyeID=@p1, kitapId=@p2, EmanetVermeTarihi=@p3, EmanetAlmaTarihi=@p4," +
            //    " EmanetIslemTarihi=@p5, EmanetDurum=@p6 Where EmanetNo=@p7", bgl.Baglanti());
            //guncelle.Parameters.AddWithValue("@p1", txtUyeID.Text);
            //guncelle.Parameters.AddWithValue("@p2", txtKitapID.Text);
            //guncelle.Parameters.AddWithValue("@p3", txtEmntVerme.Text);
            //guncelle.Parameters.AddWithValue("@p4", txtEmntAlma.Text);
            //guncelle.Parameters.AddWithValue("@p5", txtIslem.Text);
            //guncelle.Parameters.AddWithValue("@p6", chDurum.Text); // değişmiyor sorulacak
            //guncelle.Parameters.AddWithValue("@p7", txtEmntNo.Text);
            //guncelle.ExecuteNonQuery();
            
            // Entities ile veri güncelleme
            int id = Convert.ToInt32(txtEmntNo.Text);
            var item = db.TblEmanetler.Find(id);
            item.uyeID = Convert.ToInt32(txtUyeID.Text.ToString());
            item.kitapId = Convert.ToInt32(txtKitapID.Text.ToString());
            item.EmanetVermeTarihi = Convert.ToDateTime(dtEmanetVerme.Text);
            // tarihi null alma araştır
            item.EmanetAlmaTarihi = Convert.ToDateTime(dtEmanetAlma.Text);
            item.EmanetIslemTarihi = Convert.ToDateTime(txtIslem.Text);
            // checkEdit durum kontrol
            if (chDurum.Checked == true)    
            {
                chDurum.Visible = true;
            }
            else
            {
                chDurum.Visible = false;
            }
            item.EmanetDurum = chDurum.Checked;
            
            db.SaveChanges();

            //using (DbKutuphaneEntities db1 = new DbKutuphaneEntities())
            //{
            //    var guncelle = db.TblEmanetler.FirstOrDefault(x => x.EmanetNo == id);
            //    item.uyeID = Convert.ToInt32(txtUyeID.Text.ToString());
            //    item.kitapId = Convert.ToInt32(txtKitapID.Text.ToString());
            //    item.EmanetVermeTarihi = Convert.ToDateTime(txtEmntVerme.Text);
            //    item.EmanetAlmaTarihi = Convert.ToDateTime(txtEmntAlma.Text);
            //    item.EmanetIslemTarihi = Convert.ToDateTime(txtIslem.Text);
            //    if (chDurum.Checked == true)
            //    {
            //        chDurum.Visible = true;
            //    }
            //    else
            //    {
            //        chDurum.Visible = false;
            //    }
            //    item.EmanetDurum = chDurum.Checked;
            //    db.SaveChanges();
            //    Listele();
            //}
            bgl.Baglanti().Close();
            MessageBox.Show("Emanet Bilgileri güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            chDurum.Checked = false;
            Listele();
            
        }
        // Silme butonu
        private void BtnSil_Click(object sender, EventArgs e)
        {
            // ID'ye bağlı verileri siler
            SqlCommand sil = new SqlCommand("Delete from TblEmanetler Where EmanetNo=@p1", bgl.Baglanti());
            sil.Parameters.AddWithValue("@P1", txtEmntNo.Text);
            sil.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Emanet Bilgileri silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Listele();
        }

        private void BtnSirala_Click(object sender, EventArgs e)
        {
            // Sadece emanet alınmış kitapları listele
            if (radioEmntAlinan.Checked == true)
            {
                List<KitapEmanetler_Result> list = db.KitapEmanetler().Where(p => p.EmanetDurum == true).ToList();
                gridEmanetler.DataSource = list;
            }
            if(radioEmntVerilen.Checked == true)
            {
                // Sadece emanet verilen kitapları listele
                List<KitapEmanetler_Result> list2 = db.KitapEmanetler().Where(p => p.EmanetDurum == false).ToList();
                gridEmanetler.DataSource = list2;
            }
            if(radioTumu.Checked == true)
            {
                List<KitapEmanetler_Result> list3 = db.KitapEmanetler().Select(x => x).ToList();
                gridEmanetler.DataSource = list3;
            }
        }

        private void txtEmanetBul_EditValueChanged(object sender, EventArgs e)
        {
            // Aranan emanet kitabı, emanet numarasına göre listede gösterme
            string arananEmnt = txtEmanetBul.Text;
            var deger = from item in db.KitapEmanetler()
                        where Convert.ToString(item.EmanetNo).Contains(arananEmnt)
                        select item;
            gridEmanetler.DataSource = deger.ToList();
        }
    }
}
