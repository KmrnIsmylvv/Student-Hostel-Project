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
    public partial class frmAnaSehife : Form
    {
        public frmAnaSehife()
        {
            InitializeComponent();
        }

        private void frmAnaSehife_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'telebeYataqxanasiDataSet1.Telebe' table. You can move, or remove it, as needed.
            this.telebeTableAdapter.Fill(this.telebeYataqxanasiDataSet1.Telebe);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void kalkulyatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mspaint.exe");
        }

        private void kralFMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://46.20.3.204:80/";
        }

        private void power100ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://powerfm.listenpowerapp.com/powerfm/mpeg/icecast.audio";
        }

        private void kralPopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://46.20.3.201:80/";
        }

        private void tələbəƏlavəEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTelebeList fr = new frmTelebeList();
            fr.Show();
        }

        private void tələbəCədvəliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTelebeQeydiyyat fr = new frmTelebeQeydiyyat();
            fr.Show();
        }

       

        private void fakultəEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFakulteler fr = new frmFakulteler();
            fr.Show();
        }

        private void gəlirStatistikasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOdemeler fr = new frmOdemeler();
            fr.Show();
        }

        private void xərcƏlavəEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXercler fr = new frmXercler();
            fr.Show();
        }

        private void xərcStatistikasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXerclerListi fr = new frmXerclerListi();
            fr.Show();
        }

        private void şifrəYeniləToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminGuncelle fr = new frmAdminGuncelle();
            fr.Show();
        }

        private void işçiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIsciler fr = new frmIsciler();
            fr.Show();
        }

        private void gılToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQazancStatistikasi fr = new frmQazancStatistikasi();
            fr.Show();
        }

        private void statistikalarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void haqqımzdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proqram Kamran İsmayılov tərəfindən 06/17/2021 tarixində tamamlanmışdır...","Tələbə Yataqxanası",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void çıxışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.close();

        }
    }
}
