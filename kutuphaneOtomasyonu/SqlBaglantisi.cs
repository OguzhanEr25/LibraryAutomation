using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace kutuphaneOtomasyonu
{
    class SqlBaglantisi
    {
        //SQL bağlantısı
        public SqlConnection Baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=OGUZHAN;Initial Catalog=kutuphaneOtomasyon;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
