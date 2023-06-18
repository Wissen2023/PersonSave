using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonSave
{
    public partial class YeniKisi : Form
    {
        public YeniKisi()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        void KisiKaydet()
        {
            try
            {
                string id = txtPersonID.Text;
                string ad = txtPersonAd.Text;
                string soyad = txtPersonSoyad.Text;
                string acount = txtPersonelAcount.Text;
                string sehir = txtPersonSehir.Text;
                string tel = txtPersonTel.Text;

                string connectionString = "Server = DESKTOP-OVE5E20\\SQLEXPRESS; Database = PersonelDB; User = sa4; Password = 123456";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                string command = $"INSERT INTO Person VALUES ('{id}', '{ad}', '{soyad}', '{acount}', '{sehir}', '{tel}')";
                SqlCommand cmd = new SqlCommand(command, sqlConnection);
                sqlConnection.Open();
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Kişi Kaydedildi !!!");
            }
            catch (Exception)
            {
                MessageBox.Show("Kişi Kaydı Başarısız !!!");
            }
        }

        private void btnKisiKaydet_Click(object sender, EventArgs e)
        {
            KisiKaydet();
        }
    }
}
