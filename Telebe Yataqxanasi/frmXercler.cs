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

namespace Telebe_Yataqxanasi
{
    public partial class frmXercler : Form
    {
        public frmXercler()
        {
            InitializeComponent();
        }
        SQLbaglantim bgl = new SQLbaglantim();
     

        private void btnYaddaSaxla_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand emr = new SqlCommand("insert into Odemeler (Isiq,Su,Qaz,Internet,Qida,Isci,Diger) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
                emr.Parameters.AddWithValue("@p1", txtIsiq.Text);
                emr.Parameters.AddWithValue("@p2", txtSu.Text);
                emr.Parameters.AddWithValue("@p3", txtQaz.Text);
                emr.Parameters.AddWithValue("@p4", txtInternet.Text);
                emr.Parameters.AddWithValue("@p5", txtQida.Text);
                emr.Parameters.AddWithValue("@p6", txtIsci.Text);
                emr.Parameters.AddWithValue("@p7", txtDiger.Text);
                emr.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Məlumatlar Cəvələ Əlavə Olundu.");
            }
            catch (Exception)
            {
                MessageBox.Show("Xəta Baş Verdi!!!");
            }

        }

        private void frmXercler_Load(object sender, EventArgs e)
        {

        }
    }
}
