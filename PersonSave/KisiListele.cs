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
    public partial class KisiListele : Form
    {
        public KisiListele()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        public void KisiGetir()
        {
            string connectionString = "Server = DESKTOP-OVE5E20\\SQLEXPRESS; Database = PersonelDB; User = sa4; Password = 123456";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string command = "SELECT * FROM Person";
            SqlDataAdapter da = new SqlDataAdapter(command, sqlConnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtGridV.DataSource = dt;
        }

        private void KisiListele_Load(object sender, EventArgs e)
        {
            KisiGetir();
        }

        void KisiAktar()
        {
            try
            {
                txtPersonID.Text = dtGridV.CurrentRow.Cells[0].Value.ToString();
                txtPersonAd.Text = dtGridV.CurrentRow.Cells[1].Value.ToString();
                txtPersonSoyad.Text = dtGridV.CurrentRow.Cells[2].Value.ToString();
                txtPersonAccount.Text = dtGridV.CurrentRow.Cells[3].Value.ToString();
                txtPersonSehir.Text = dtGridV.CurrentRow.Cells[4].Value.ToString();
                txtPersonTel.Text = dtGridV.CurrentRow.Cells[5].Value.ToString();
                MessageBox.Show("Kişi Aktarıldı");
            }
            catch (Exception)
            {
                MessageBox.Show("Kişi Aktarılamadı");
            }
        }

        private void btnKisiAktar_Click(object sender, EventArgs e)
        {
            KisiAktar();
        }

        void KisiGuncelle()
        {
            try
            {
                string id = dtGridV.CurrentRow.Cells[0].Value.ToString();
                string ad = txtPersonAd.Text;
                string soyad = txtPersonSoyad.Text;
                string account = txtPersonAccount.Text;
                string sehir = txtPersonSehir.Text;
                string tel = txtPersonTel.Text;

                string connectionString = "Server = DESKTOP-OVE5E20\\SQLEXPRESS; Database = PersonelDB; User = sa4; Password = 123456";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                string command = $"UPDATE Person SET PersonAd = '{ad}', PersonSoyad = '{soyad}', PersonelAcount = '{account}', PersonSehir = '{sehir}', PersonTel = '{tel}' WHERE PersonID = '{id}'";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Kişi Güncelllendi");
            }
            catch (Exception)
            {
                MessageBox.Show("Kişi Güncellenemedi");
            }
        }

        private void btnKisiGuncelle_Click(object sender, EventArgs e)
        {
            KisiGuncelle();
            KisiGetir();
        }
        
        void KisiSil()
        {
            try
            {
                string id = dtGridV.CurrentRow.Cells[0].Value.ToString();

                string connectionString = "Server = DESKTOP-OVE5E20\\SQLEXPRESS; Database = PersonelDB; User = sa4; Password = 123456";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                string command = $"DELETE FROM Person WHERE PersonID = '{id}'";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Kişi Silindi");
            }
            catch (Exception)
            {
                MessageBox.Show("Kişi Silinemedi");
            }
        }

        private void btnKisiSil_Click(object sender, EventArgs e)
        {
            KisiSil();
            KisiGetir();
        }
    }
}
