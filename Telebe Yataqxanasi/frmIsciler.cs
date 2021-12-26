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
    public partial class frmIsciler : Form
    {
        public frmIsciler()
        {
            InitializeComponent();
        }

        SQLbaglantim bgl = new SQLbaglantim();

        private void frmIsciler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'telebeYataqxanasiDataSet6.Isciler' table. You can move, or remove it, as needed.
            this.iscilerTableAdapter.Fill(this.telebeYataqxanasiDataSet6.Isciler);
        }

        private void btnYaddaSaxla_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand emr = new SqlCommand("insert into Isciler (IsciAdSoyad,IsciSobe) values (@p1,@p2)", bgl.baglanti());
                emr.Parameters.AddWithValue("@p1", txtIsciAd.Text);
                emr.Parameters.AddWithValue("@p2", txtIsciSobe.Text);
                emr.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("İşçi Cədvələ Əlavə Olundu.");
                this.iscilerTableAdapter.Fill(this.telebeYataqxanasiDataSet6.Isciler);
                txtIsciId.Clear();
                txtIsciAd.Clear();
                txtIsciSobe.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Xəta Baş Verdi!!!"); 
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand emr = new SqlCommand("delete from Isciler where IsciId=@p1", bgl.baglanti());
                emr.Parameters.AddWithValue("@p1", txtIsciId.Text);
                emr.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("İşçi Cədvəldən Silindi.");
                this.iscilerTableAdapter.Fill(this.telebeYataqxanasiDataSet6.Isciler);
                txtIsciId.Clear();
                txtIsciAd.Clear();
                txtIsciSobe.Clear();
            }
            catch (Exception)
            {

                MessageBox.Show("Xəta Baş Verdi!!!");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string id, adsoyad, sobe;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            adsoyad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            sobe = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            txtIsciId.Text = id;
            txtIsciAd.Text = adsoyad;
            txtIsciSobe.Text = sobe;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand emr = new SqlCommand("update Isciler set IsciAdSoyad=@p2,IsciSobe=@p3 where IsciId=@p1", bgl.baglanti());
                emr.Parameters.AddWithValue("@p1", txtIsciId.Text);
                emr.Parameters.AddWithValue("@p2", txtIsciAd.Text);
                emr.Parameters.AddWithValue("@p3", txtIsciSobe.Text);
                emr.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Cədvəl Uğurla Güncəlləndi.");
                this.iscilerTableAdapter.Fill(this.telebeYataqxanasiDataSet6.Isciler);
            }
            catch (Exception)
            {

                MessageBox.Show("Xəta Baş Verdi!!!");
            }
        }
    }
}
