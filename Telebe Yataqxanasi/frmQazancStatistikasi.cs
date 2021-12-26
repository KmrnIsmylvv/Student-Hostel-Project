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
    public partial class frmQazancStatistikasi : Form
    {
        public frmQazancStatistikasi()
        {
            InitializeComponent();
        }

        SQLbaglantim bgl = new SQLbaglantim();

        private void frmQazancStatistikasi_Load(object sender, EventArgs e)
        {
            //Kassadaki umumi miqdar
            SqlCommand emr = new SqlCommand("select sum(OdemeMiqdar) from Kassa", bgl.baglanti());
            SqlDataReader oxu = emr.ExecuteReader();
            while (oxu.Read())
            {
                lblKassaPul.Text = oxu[0].ToString() + " AZN";
            }
            bgl.baglanti().Close();


            //Aylari tekrarsiz siralama
            SqlCommand emr2 = new SqlCommand("select distinct(OdemeAy) from Kassa", bgl.baglanti());
            SqlDataReader oxu2 = emr2.ExecuteReader();
            while (oxu2.Read())
            {
                cmbAy.Items.Add(oxu2[0].ToString());
            }
            bgl.baglanti().Close();

            //chart a elave etmek
            SqlCommand emr3 = new SqlCommand("select OdemeAy,sum(OdemeMiqdar) from Kassa group by OdemeAy", bgl.baglanti());
            SqlDataReader oxu3 = emr3.ExecuteReader();
            while (oxu3.Read())
            {
                this.chart1.Series["Aylıq"].Points.AddXY(oxu3[0], oxu3[1]);
            }
            bgl.baglanti().Close();

           

        }

        private void cmbAy_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand emr = new SqlCommand("Select sum(OdemeMiqdar) from Kassa where OdemeAy=@p1", bgl.baglanti());
            emr.Parameters.AddWithValue("@p1", cmbAy.Text);
            SqlDataReader oxu = emr.ExecuteReader();
            while (oxu.Read())
            {
                lblSecilenAydakiPul.Text = oxu[0].ToString();
            }
            bgl.baglanti().Close();
        }
    }
}
