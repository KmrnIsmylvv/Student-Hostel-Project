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
    public partial class frmAdminGuncelle : Form
    {
        public frmAdminGuncelle()
        {
            InitializeComponent();
        }

        SQLbaglantim bgl = new SQLbaglantim();

        private void frmSifreGuncelle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'telebeYataqxanasiDataSet5.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.telebeYataqxanasiDataSet5.Admin);

        }

        private void btnYaddaSaxla_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand emr = new SqlCommand("insert into Admin (AdminAd,AdminSifre) values (@p1,@p2)", bgl.baglanti());
                emr.Parameters.AddWithValue("@p1", txtİstifadeciAd.Text);
                emr.Parameters.AddWithValue("@p2", txtSifre.Text);
                emr.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("İstifadəçi Cədvələ Əlavə Olundu.");
                this.adminTableAdapter.Fill(this.telebeYataqxanasiDataSet5.Admin);
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
            string id, ad, sifre;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            sifre = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            txtİstifadeciİd.Text = id;
            txtİstifadeciAd.Text = ad;
            txtSifre.Text = sifre;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand emr = new SqlCommand("delete from Admin where AdminId=@p1", bgl.baglanti());
                emr.Parameters.AddWithValue("@p1", txtİstifadeciİd.Text);
                emr.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("İstifadəçi Cədvəldən Silindi.");
                this.adminTableAdapter.Fill(this.telebeYataqxanasiDataSet5.Admin);
            }
            catch (Exception)
            {

                MessageBox.Show("Xəta Baş Verdi!!!");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand emr = new SqlCommand("update Admin set AdminAd=@p1,AdminSifre=@p2 where AdminId=@p3", bgl.baglanti());
                emr.Parameters.AddWithValue("@p1", txtİstifadeciAd.Text);
                emr.Parameters.AddWithValue("@p2", txtSifre.Text);
                emr.Parameters.AddWithValue("@p3", txtİstifadeciİd.Text);
                emr.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Cədvəl Uğurla Güncəlləndi.");
                this.adminTableAdapter.Fill(this.telebeYataqxanasiDataSet5.Admin);
            }
            catch (Exception)
            {
                MessageBox.Show("Xəta Baş Verdi!!!");
            }
        }
    }
}
