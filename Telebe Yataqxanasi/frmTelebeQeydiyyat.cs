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
    public partial class frmTelebeQeydiyyat : Form
    {
        public frmTelebeQeydiyyat()
        {
            InitializeComponent();

        }
        SQLbaglantim bgl = new SQLbaglantim();

        private void btnYaddaSaxla_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand emr = new SqlCommand("insert into Telebe (TlbAd,TlbSoyad,TlbTelefon,TlbDogum,TlbFakulte,TlbMail,TlbOtaqNo,TlbValideynAdSoyad,TlbValideynTelefon,TlbAdres) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.baglanti());
                emr.Parameters.AddWithValue("@p1", txtTlbAd.Text);
                emr.Parameters.AddWithValue("@p2", txtTlbSoyad.Text);
                emr.Parameters.AddWithValue("@p3", mtxTlbTelefon.Text);
                emr.Parameters.AddWithValue("@p4", mtxTlbDogumtarixi.Text);
                emr.Parameters.AddWithValue("@p5", cmbTlbFakulte.Text);
                emr.Parameters.AddWithValue("@p6", txtTlbMail.Text);
                emr.Parameters.AddWithValue("@p7", cmbTlbOtaqNo.Text);
                emr.Parameters.AddWithValue("@p8", txtValideynAdSoyad.Text);
                emr.Parameters.AddWithValue("@p9", mtxValideynTelefon.Text);
                emr.Parameters.AddWithValue("@p10", rtxTlbUnvan.Text);
                emr.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Qeydiyyat Uğurla Tamalandı.");


                //Telebenin id sini labele yazdirmaq
                SqlCommand emr3 = new SqlCommand("select TlbId from Telebe", bgl.baglanti());
                SqlDataReader oxu = emr3.ExecuteReader();
                while (oxu.Read())
                {
                    label11.Text = oxu[0].ToString();
                }
                bgl.baglanti().Close();



                //Borc Elave Etmek
                SqlCommand emr2 = new SqlCommand("insert into Borclar (TlbId,TlbAd,TlbSoyad) values(@b1,@b2,@b3)", bgl.baglanti());
                emr2.Parameters.AddWithValue("@b1", label11.Text);
                emr2.Parameters.AddWithValue("@b2", txtTlbAd.Text);
                emr2.Parameters.AddWithValue("@b3", txtTlbSoyad.Text);
                emr2.ExecuteNonQuery();
                bgl.baglanti().Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Xəta Baş Verdi!!!");
            }

            //Telebe Otaq Aktivliyi
            SqlCommand emrotaq = new SqlCommand("update Otaqlar set OtaqAktiv=OtaqAktiv+1 where OtaqNo=@otaq1", bgl.baglanti());
            emrotaq.Parameters.AddWithValue("@otaq1", cmbTlbOtaqNo.Text);
            emrotaq.ExecuteNonQuery();
            bgl.baglanti().Close();

        }

        private void frmTelebeQeydiyyat_Load(object sender, EventArgs e)
        {
            //Fakulteleri elave etmek
            SqlCommand emr = new SqlCommand("select FakulteAd From Fakulteler", bgl.baglanti());
            SqlDataReader oxu = emr.ExecuteReader();
            while (oxu.Read())
            {
                cmbTlbFakulte.Items.Add(oxu[0].ToString());
            }
            bgl.baglanti().Close();

            //Otaqlari elave etmek
            SqlCommand emr2 = new SqlCommand("select OtaqNo from Otaqlar where OtaqTutum!=OtaqAktiv", bgl.baglanti());
            SqlDataReader oxu2 = emr2.ExecuteReader();
            while (oxu2.Read())
            {
                cmbTlbOtaqNo.Items.Add(oxu2[0].ToString());
            }
            bgl.baglanti().Close();




        }
    }
}
