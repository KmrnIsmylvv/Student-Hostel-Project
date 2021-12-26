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
    public partial class frmFakulteler : Form
    {
        public frmFakulteler()
        {
            InitializeComponent();
        }
        SQLbaglantim bgl = new SQLbaglantim();
        private void frmFakulteler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'telebeYataqxanasiDataSet.Fakulteler' table. You can move, or remove it, as needed.
            this.fakultelerTableAdapter.Fill(this.telebeYataqxanasiDataSet.Fakulteler);
        }

        private void btnElaveEt_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand emr = new SqlCommand("insert into Fakulteler (FakulteAd) values (@p1)", bgl.baglanti()) ;
                emr.Parameters.AddWithValue("@p1", txtFakulteAd.Text);
                emr.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Fakultə Cədvələ Əlavə Olundu.");
                this.fakultelerTableAdapter.Fill(this.telebeYataqxanasiDataSet.Fakulteler);
            }
            catch (Exception)
            {
                MessageBox.Show("Xəta Baş verdi!!!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand emr = new SqlCommand("delete from Fakulteler where FakulteId=@p1", bgl.baglanti());
                emr.Parameters.AddWithValue("@p1", txtFakulteId.Text);
                emr.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Fakultə Cədvəldən Silindi.");
                this.fakultelerTableAdapter.Fill(this.telebeYataqxanasiDataSet.Fakulteler);
            }
            catch (Exception)
            {
                MessageBox.Show("Xəta Baş verdi!!!");
            }
        }
        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, fakultead;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            fakultead = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            txtFakulteId.Text = id;
            txtFakulteAd.Text = fakultead;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand emr = new SqlCommand("update Fakulteler set FakulteAd=@p1 where FakulteId=@p2", bgl.baglanti());
                emr.Parameters.AddWithValue("@p2", txtFakulteId.Text);
                emr.Parameters.AddWithValue("@p1", txtFakulteAd.Text);
                emr.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Fakultə Güncəlləndi");
                this.fakultelerTableAdapter.Fill(this.telebeYataqxanasiDataSet.Fakulteler);
            }
            catch (Exception)
            {
                MessageBox.Show("Xəta Baş verdi!!!");
            }
        }
    }
}
