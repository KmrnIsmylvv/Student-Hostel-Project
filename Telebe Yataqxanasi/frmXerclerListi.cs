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
    public partial class frmXerclerListi : Form
    {
        public frmXerclerListi()
        {
            InitializeComponent();
        }

        private void frmXerclerListi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'telebeYataqxanasiDataSet4.Odemeler' table. You can move, or remove it, as needed.
            this.odemelerTableAdapter.Fill(this.telebeYataqxanasiDataSet4.Odemeler);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            frmXercEdit fr = new frmXercEdit();
            secilen=dataGridView1.SelectedCells[0].RowIndex;
            fr.id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            fr.isiq = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            fr.su = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            fr.qaz = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            fr.internet = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            fr.qida = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            fr.isci = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            fr.diger = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            fr.Show();
        }
    }
}
