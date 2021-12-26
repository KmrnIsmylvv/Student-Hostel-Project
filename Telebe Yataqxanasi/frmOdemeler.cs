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
    public partial class frmOdemeler : Form
    {
        public frmOdemeler()
        {
            InitializeComponent();
        }
        SQLbaglantim bgl = new SQLbaglantim();

        private void frmOdemeler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'telebeYataqxanasiDataSet2.Borclar' table. You can move, or remove it, as needed.
            this.borclarTableAdapter.Fill(this.telebeYataqxanasiDataSet2.Borclar);

        }

        private void btnOdemeAl_Click(object sender, EventArgs e)
        {   //Yeniborcu yazdirmaq
            int odenen, qalan, yeniborc;
            odenen = Convert.ToInt16(txtOdenilen.Text);
            qalan = Convert.ToInt16(txtQalanBorc.Text);
            yeniborc = qalan - odenen;
            txtQalanBorc.Text = yeniborc.ToString();

            //cedveli update etmek
            SqlCommand emr = new SqlCommand("update Borclar set TlbQalanBorc=@p1 where TlbId=@p2", bgl.baglanti());
            emr.Parameters.AddWithValue("@p2", txtTlbId.Text);
            emr.Parameters.AddWithValue("@p1", txtQalanBorc.Text);
            emr.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ödəniş Uğurla Tamamlandı.");
            this.borclarTableAdapter.Fill(this.telebeYataqxanasiDataSet2.Borclar);

            //Kassaya yazdirmaq
            SqlCommand emr2 = new SqlCommand("insert into Kassa (OdemeAy,OdemeMiqdar) values (@k1,@k2)", bgl.baglanti());
            emr2.Parameters.AddWithValue("@k1", txtOdenenAy.Text);
            emr2.Parameters.AddWithValue("@k2", txtOdenilen.Text);
            emr2.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, ad, soyad, qalan;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            qalan = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            txtAd.Text = ad;
            txtSoyad.Text = soyad;
            txtTlbId.Text = id;
            txtQalanBorc.Text = qalan;
        }

       
    }
}
