using kutuphaneOtomasyonu.Formlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphaneOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FrmKitaplar frm1;
        private void BtnKitaplar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Kitaplar formunun ana form üzerinden açma şartı
            if (frm1 == null || frm1.IsDisposed)
            {
                frm1 = new FrmKitaplar();
                frm1.MdiParent = this;
                frm1.Show();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        FrmUyeler frm2;
        private void BtnUyeler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Üyeler formunu ana form sekmesi üzerinden açma şartı
            if (frm2 == null || frm2.IsDisposed)
            {
                frm2 = new FrmUyeler();
                frm2.MdiParent = this;
                frm2.Show();
            }
        }

        FrmEmanetler frm3;
        private void btnEmanetler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Emanetler formunu ana form üzerinden açma şartı
            if (frm3 == null || frm3.IsDisposed)
            {
                frm3 = new FrmEmanetler();
                frm3.MdiParent = this;
                frm3.Show();
            }
        }

        FrmAdmin frm4;
        private void btnAyarlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Ayarlar formunu ana form üzerinden açma şartı
            if (frm4 == null || frm4.IsDisposed)
            {
                frm4 = new FrmAdmin();
                frm4.MdiParent = this;
                frm4.Show();
            }
        }

        FrmAnaSayfa frm5;
        private void FrmAnaSayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frm5 == null || frm5.IsDisposed)
            {
                frm5 = new FrmAnaSayfa();
                frm5.MdiParent = this;
                frm5.Show();
            }
        }
    }
}