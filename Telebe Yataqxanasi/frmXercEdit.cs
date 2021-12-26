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
    public partial class frmXercEdit : Form
    {
        public frmXercEdit()
        {
            InitializeComponent();
        }

        SQLbaglantim bgl = new SQLbaglantim();

        public string isiq, su, qaz, internet, qida, isci, diger, id;

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand emr = new SqlCommand("update Odemeler set Isiq=@p2,Su=@p3,Qaz=@p4,Internet=@p5,Qida=@p6,Isci=@p7,Diger=@p8 where OdemeId=@p1", bgl.baglanti());
                emr.Parameters.AddWithValue("@p1", txtId.Text);
                emr.Parameters.AddWithValue("@p2", txtIsiq.Text);
                emr.Parameters.AddWithValue("@p3", txtSu.Text);
                emr.Parameters.AddWithValue("@p4", txtQaz.Text);
                emr.Parameters.AddWithValue("@p5", txtInternet.Text);
                emr.Parameters.AddWithValue("@p6", txtQida.Text);
                emr.Parameters.AddWithValue("@p7", txtIsci.Text);
                emr.Parameters.AddWithValue("@p8", txtDiger.Text);
                emr.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Xərc Cədvəli Güncəlləndi.");
            }
            catch (Exception)
            {

                MessageBox.Show("Xəta Baş Verdi!!!");
            }
        }

        private void frmXercEdit_Load(object sender, EventArgs e)
        {
            txtId.Text = id;
            txtIsiq.Text = isiq;
            txtSu.Text = su;
            txtQaz.Text = qaz;
            txtInternet.Text = internet;
            txtQida.Text = qida;
            txtIsci.Text = isci;
            txtDiger.Text = diger;
        }
    }
}
