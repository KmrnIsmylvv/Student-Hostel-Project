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
    public partial class frmTelebeEdit : Form
    {
        public frmTelebeEdit()
        {
            InitializeComponent();
        }
        public string id, ad, soyad, telefon, dogumtarixi, fakulte, mail, otaqno, valideynadsoyad, valideyntelefon, unvan;

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand emr = new SqlCommand("delete from Telebe where TlbId=@p1", bgl.baglanti());
                emr.Parameters.AddWithValue("@p1", txtTlbId.Text);
                emr.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Tələbə Cədvəldən Silindi.");
            }
            catch (Exception)
            {

                MessageBox.Show("Xəta Baş Verdi!!!");
            }

            //Otaqgin tutumunu artirma
            SqlCommand otaqemr = new SqlCommand("update Otaqlar set OtaqAktiv=OtaqAktiv-1 where OtaqNo=@otaq1", bgl.baglanti());
            otaqemr.Parameters.AddWithValue("@otaq1", cmbTlbOtaqNo.Text);
            otaqemr.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        SQLbaglantim bgl = new SQLbaglantim();

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand emr = new SqlCommand("update Telebe set TlbAd=@p2,TlbSoyad=@p3,TlbTelefon=@p4,TlbDogum=@p5,TlbFakulte=@p6,TlbMail=@p7,TlbOtaqNo=@p8,TlbValideynAdSoyad=@p9,TlbValideynTelefon=@p10,TlbAdres=@p11 where TlbId=@p1", bgl.baglanti());
                emr.Parameters.AddWithValue("@p1", txtTlbId.Text);
                emr.Parameters.AddWithValue("@p2", txtTlbAd.Text);
                emr.Parameters.AddWithValue("@p3", txtTlbSoyad.Text);
                emr.Parameters.AddWithValue("@p4", mtxTlbTelefon.Text);
                emr.Parameters.AddWithValue("@p5", mtxTlbDogumtarixi.Text);
                emr.Parameters.AddWithValue("@p6", cmbTlbFakulte.Text);
                emr.Parameters.AddWithValue("@p7", txtTlbMail.Text);
                emr.Parameters.AddWithValue("@p8", cmbTlbOtaqNo.Text);
                emr.Parameters.AddWithValue("@p9", txtValideynAdSoyad.Text);
                emr.Parameters.AddWithValue("@p10", mtxValideynTelefon.Text);
                emr.Parameters.AddWithValue("@p11", rtxTlbUnvan.Text);
                emr.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Cədvəl Uğurla Güncəlləndi.");
            }
            catch (Exception)
            {

                MessageBox.Show("Xəta Baş Verdi!!!");
            }
        }

        private void frmTelebeEdit_Load(object sender, EventArgs e)
        {
            txtTlbId.Text = id;
            txtTlbAd.Text = ad;
            txtTlbSoyad.Text = soyad;
            mtxTlbTelefon.Text = telefon;
            mtxTlbDogumtarixi.Text = dogumtarixi;
            cmbTlbFakulte.Text = fakulte;
            txtTlbMail.Text = mail;
            cmbTlbOtaqNo.Text = otaqno;
            txtValideynAdSoyad.Text = valideynadsoyad;
            mtxValideynTelefon.Text = valideyntelefon;
            rtxTlbUnvan.Text = unvan;


            SqlCommand emr = new SqlCommand("select FakulteAd From Fakulteler", bgl.baglanti());
            SqlDataReader oxu = emr.ExecuteReader();
            while (oxu.Read())
            {
                cmbTlbFakulte.Items.Add(oxu[0].ToString());
            }
            bgl.baglanti().Close();

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
