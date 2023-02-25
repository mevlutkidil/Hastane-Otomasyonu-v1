using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOAppLayer_PresentationLayer_
{
    public partial class SekreterPanel : Form
    {
        public SekreterPanel()
        {
            InitializeComponent();
        }

        private void btn_doktorislem_Click(object sender, EventArgs e)
        {
            SekreterDoktorİslemleri sekreterDoktorİslemleripanel = new SekreterDoktorİslemleri();   
            sekreterDoktorİslemleripanel.Show();
            this.Hide();
        }

        private void btn_hastaislem_Click(object sender, EventArgs e)
        {
            SekreterHasta sekreterHasta = new SekreterHasta();
            sekreterHasta.Show();
            this.Hide();
        }

        private void btn_bransislemleri_Click(object sender, EventArgs e)
        {
            SekreterBransIslemleri sekreterBransIslemleripanel = new SekreterBransIslemleri();
            sekreterBransIslemleripanel.Show();
            this.Hide();
        }

        private void btn_sekreterIslemleri_Click(object sender, EventArgs e)
        {
            SekreterAdmin sekreterAdminpaneli = new SekreterAdmin();
            sekreterAdminpaneli.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
