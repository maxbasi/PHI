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
    public partial class Uso : Form
    {
        string tbPunti = "";
        public Uso()
        {
            InitializeComponent();
        }


        public string TextBoxPunti
        {
            get { return tbPunti; }
            set { tbPunti = value; }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = (Form2)Application.OpenForms["Form2"];
            aggiornaPunti();
            f2.TextBoxPunti = (Int32.Parse(f2.TextBoxPunti) - Int32.Parse(tbPunti)).ToString();
            f2.Text = "hai addebitato "+ Int32.Parse(tbPunti).ToString() +" punti" ;
            Close();
        }

        private void aggiornaPunti()

        {

            Form2 f2 = (Form2)Application.OpenForms["Form2"];

            string dbpwd = "lightwave";
            MySql.Data.MySqlClient.MySqlConnection dbConn = new MySql.Data.MySqlClient.MySqlConnection("Persist Security Info=False;server=localhost;database=phidelity;uid=root;password=" + dbpwd);

            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = "UPDATE phidelity.cards SET punti = punti -" + tbPunti + " where barcode='" + f2.TextBoxBarcode + "'";

            Console.WriteLine("MySQL command= {0}", cmd.CommandText);
            using (var wb = new WebClient())
            {
                String url = "http://www.phi-lab.com/insertRecord.php?nome=" + f2.TextBoxNome + "&cognome=" + f2.TextBoxCognome + "&punti=" + f2.TextBoxPunti + "&barcode=" + f2.TextBoxBarcode + "&email=" + f2.TextBoxEmail + "&telefono=" + f2.TextBoxTelefono;
                var response = wb.DownloadString(url);
                MessageBox.Show(url);
            }
            try
            {

              

                dbConn.Open();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro" + erro);
                this.Close();
            }

            int rc_updated = cmd.ExecuteNonQuery();



            dbConn.Close();


        }

    }
}
