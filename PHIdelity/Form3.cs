using MySql.Data.MySqlClient;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;


namespace PHIdelity
{
    public partial class Form3 : Form
    {
        string barcode = "";
        public Form3()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + (sender as Button).Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + (sender as Button).Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + (sender as Button).Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + (sender as Button).Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + (sender as Button).Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + (sender as Button).Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + (sender as Button).Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + (sender as Button).Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + (sender as Button).Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + (sender as Button).Text;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form2 f2 = (Form2)Application.OpenForms["Form2"];
            aggiornaPunti();

            f2.TextBoxPunti = (Int32.Parse(f2.TextBoxPunti) + Int32.Parse(label1.Text)).ToString();

            Close();
        }



        private void aggiornaPunti()

        {

            Form2 f2 = (Form2)Application.OpenForms["Form2"];
          
            string dbpwd = "lightwave";
        MySql.Data.MySqlClient.MySqlConnection dbConn = new MySql.Data.MySqlClient.MySqlConnection("Persist Security Info=False;server=localhost;database=phidelity;uid=root;password=" + dbpwd);

        MySqlCommand cmd = dbConn.CreateCommand();
            String newPunti = (int.Parse(f2.TextBoxPunti) + int.Parse(label1.Text)).ToString();
            cmd.CommandText = "UPDATE phidelity.cards SET punti = punti +" + label1.Text + " where barcode='" + f2.TextBoxBarcode+"'";
                
            Console.WriteLine("MySQL command= {0}", cmd.CommandText            );

            try
            {
                dbConn.Open();
                int rc_updated = cmd.ExecuteNonQuery();
                using (var wb = new WebClient())
                {
                    String url = "http://www.phi-lab.com/insertRecord.php?nome=" + f2.TextBoxNome + "&cognome=" + f2.TextBoxCognome + "&punti=" + newPunti + "&barcode=" + f2.TextBoxBarcode + "&email=" + f2.TextBoxEmail + "&telefono=" + f2.TextBoxTelefono;
                var response = wb.DownloadString(url);
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro" + erro);
                this.Close();
            }

            dbConn.Close();


        }
    }
}
