using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;


/**
 * 
 * 1000punti


320 punti un trattamento viso antiage
300 punti un trattamento corpo snellente
200 pulizia viso
180 punti mani e piedi
150 punti un massaggio
50  punti manicure

1 punti  - 1 euro

    **/
namespace PHIdelity
{
    public partial class Form1 : Form
    {
        string barcode = "";
        string keypressed="";
        System.Timers.Timer aTimer;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

            string dbpwd = "lightwave";
            MySql.Data.MySqlClient.MySqlConnection dbConn = new MySql.Data.MySqlClient.MySqlConnection("Persist Security Info=False;server=localhost;database=phidelity;uid=root;password=" + dbpwd);

            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = "SELECT * FROM phidelity.cards where barcode='" + textBox1.Text + "' ;";

            try
            {
                dbConn.Open();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro" + erro);
                this.Close();
            }

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                Console.WriteLine("MySQL version : {0}", reader.ToString());
            }



        }

        private void searchdb()
        {
            Form2 Detail  ;
            Nuovo NewUser;
            int numRows = 0;

          

            string dbpwd = "lightwave";
            MySql.Data.MySqlClient.MySqlConnection dbConn = new MySql.Data.MySqlClient.MySqlConnection("Persist Security Info=False;server=localhost;database=phidelity;uid=root;password=" + dbpwd);
        //    barcode = "00001";
            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = "SELECT * FROM phidelity.cards where barcode='" + barcode + "' ;";
            Console.WriteLine("MySQL command= {0}", cmd.CommandText
                    );

            try
            {
                dbConn.Open();
           

            MySqlDataReader reader = cmd.ExecuteReader();
            Detail = new Form2();

            
            while (reader.Read())
            {
                string nome =  reader.GetString("nome");
                string cognome = reader.GetString("cognome");
                string punti = reader.GetString("punti");
                string email = reader.GetString("email");
                string telefono = reader.GetString("telefono");

                    Detail.TextBoxBarcode = barcode;
                    Detail.TextBoxNome = nome;
                if (email!=null)
                Detail.TextBoxEmail = email;
                if (telefono != null)
                    Detail.TextBoxTelefono = telefono;
                if (cognome != null)
                    Detail.TextBoxCognome = cognome;
                if (punti != null)
                    Detail.TextBoxPunti = punti;
                numRows++;



            }

            if (numRows < 1)
            {
                NewUser = new Nuovo();
                NewUser.TextBoxBarcode = barcode;
                NewUser.Show();

            }
            else
            { 
                Detail.TextBoxBarcode = barcode;
                    Detail.CanModify = false;
                    //  MessageBox.Show(barcode);
                    Detail.Show();
            }
            dbConn.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro" + erro);
                this.Close();
            }


        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Enter)
            {
                barcode = keypressed;
                searchdb();
                barcode = "";
            }
            else
            {
                keypressed = keypressed + e.KeyValue.ToString();
            label2.Text = keypressed
                ;
            }
        }


        public string TextBoxBarcode
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
           
        }

        public void Form1focus()
        {
            //MessageBox.Show("ciao");
            textBox1.Text= "";
            barcode = "";
            this.Show();
            textBox1.Focus();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                label2.Text = barcode;
                searchdb();
                barcode = "";
            }
            else
            {
               
              
                     
            }


        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Return)
                barcode = barcode + e.KeyChar.ToString();
            label2.Text = barcode;
        }



       
        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            DateTime OGGI = DateTime.Now;
            if (OGGI.Date.Month == 12)
            {
                Form1 f1 = (Form1)Application.OpenForms["Form1"];

                f1.BackgroundImage = Properties.Resources.abstract_christmas_tree_art_2;

            };
            if (OGGI.Date.Month == 1)
            {
                Form1 f1 = (Form1)Application.OpenForms["Form1"];

                f1.BackgroundImage = Properties.Resources.befana;

            };

            if (OGGI.Date == DateTime.Parse("03/12/2017")) MessageBox.Show("ciao");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            aTimer = new System.Timers.Timer(1000); //one hour in milliseconds
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);

           
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


            //FormBorderStyle = FormBorderStyle.None;
            


            Users Detail = new Users(this);
           Detail.Show();


        


        }


        private void AddFormHeader()
        {
            this.SuspendLayout();

            //Create a container panel to contain all controls in the form except the header label I'll add later.
            Panel p = new Panel();
            p.Size = this.Size;
            p.Location = new Point(0, 0);
            p.AutoScroll = true;

            foreach (Control c in this.Controls)
            {
                p.Controls.Add(c);
            }

            this.Controls.Add(p);

            //Create the header and add it to the form.
            Label header = new Label();
            header.Text = "hello!";
            header.Location = new Point(0, 0);

            this.Controls.Add(header);
            header.BringToFront();

            this.ResumeLayout();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            WindowState = FormWindowState.Maximized;
        }
    }
}
