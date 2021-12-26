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
    public partial class frmAdminGiris : Form
    {
        public frmAdminGiris()
        {
            InitializeComponent();
        }
        SQLbaglantim bgl = new SQLbaglantim();

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand emr = new SqlCommand("select * from Admin where AdminAd=@p1 and AdminSifre=@p2", bgl.baglanti());
            emr.Parameters.AddWithValue("@p1", txtIstifadeciAdi.Text);
            emr.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader oxu = emr.ExecuteReader();
            if (oxu.Read())
            {
                frmAnaSehife fr = new frmAnaSehife();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("İstifadəçi Adı və ya Şifrə Yanlışdır!!!");
                txtIstifadeciAdi.Clear();
                txtSifre.Clear();
                txtIstifadeciAdi.Focus();
            }
        }

        private void frmAdminGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
