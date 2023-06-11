using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonSave
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYeniKisi_Click(object sender, EventArgs e)
        {
            YeniKisi yeniKisi = new YeniKisi();
            yeniKisi.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKisiListele_Click(object sender, EventArgs e)
        {
            KisiListele kisiListele = new KisiListele();
            kisiListele.Show();
            this.Hide();
        }
    }
}
