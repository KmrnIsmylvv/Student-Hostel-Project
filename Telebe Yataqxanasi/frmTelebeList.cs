using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telebe_Yataqxanasi
{
    public partial class frmTelebeList : Form
    {
        public frmTelebeList()
        {
            InitializeComponent();
        }

        private void frmTelebeList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'telebeYataqxanasiDataSet3.Telebe' table. You can move, or remove it, as needed.
            this.telebeTableAdapter.Fill(this.telebeYataqxanasiDataSet3.Telebe);

        }

        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            frmTelebeEdit fr = new frmTelebeEdit();
            fr.id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            fr.ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            fr.soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            fr.telefon = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            fr.dogumtarixi = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            fr.fakulte = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            fr.mail = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            fr.otaqno = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            fr.valideynadsoyad = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            fr.valideyntelefon = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            fr.unvan = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            fr.Show();
        }
    }
}
