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
    public partial class FrmKitaplar : Form
    {
        public FrmKitaplar()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        DataTable dt = new DataTable();
        

        void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TblKitaplar",bgl.Baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void FrmKitaplar_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
