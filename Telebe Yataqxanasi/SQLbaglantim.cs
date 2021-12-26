using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Telebe_Yataqxanasi
{
    class SQLbaglantim
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-50U56HO;Initial Catalog=TelebeYataqxanasi;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
