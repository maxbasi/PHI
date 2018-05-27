using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;

namespace PHIdelity
{
    public partial class Users : Form
    {
        private System.Windows.Forms.DataGridView myNewGrid;
        private List<BattleShipRow> battleShipGrid; // Declare this here so that you can use it later to manipulate the cell contents

        Form1 form1;

        public Users(Form1 frm)
        {
            InitializeComponent();
            form1 = frm;
        }

        public void update()
        {
             Users_Load(null, new EventArgs());
        }
        

        private void Users_Load(object sender, EventArgs e)
        {
           

            string dbpwd = "lightwave";
            MySql.Data.MySqlClient.MySqlConnection dbConn = new MySql.Data.MySqlClient.MySqlConnection("Persist Security Info=False;server=localhost;database=phidelity;uid=root;password=" + dbpwd);

            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = @"select barcode, nome,cognome,punti, case  when createdate is null then '' else CONCAT(DAY(createdate),"" -"",MONTH(createdate),"" - "",Year(createdate))    end as createdate      from  phidelity.cards  order by barcode ";
            string sqlQuery = cmd.CommandText;
        //    this.listBox1.Items.Clear();
            try
            {
                dbConn.Open();

               

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                dataGridView1.DataSource = new BindingSource(table, null);

                dataGridView1.RowTemplate.Height = 60;

                using (var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)) //close con on reader.Close
                {
                    while (reader.Read())
                    {
                         String code = "";
                         if (reader["barcode"] != DBNull.Value) code = (string)reader["barcode"] + "## ";

                        String nome = "";
                        if (reader["nome"] != DBNull.Value) nome = (string)reader["nome"];

                        String cognome = "";
                        if (reader["cognome"] != DBNull.Value) cognome = (string)reader["cognome"];


                        string title1 = nome.PadRight(20, ' ').Substring(0, 20) + cognome.PadRight(20,' ').Substring(0, 20); ;
                        string title =  title1 ;


                        string description2 = "";
                        if (reader["punti"] != DBNull.Value) description2 = ((int)reader["punti"]).ToString();
                        string description =  "  -   ";
                        if (reader["createdate"] != DBNull.Value) description = ((string)reader["createdate"]).ToString() + "  -   ";


                        string item = code+ string.Format("{0} - {1}", title, description+ description2);

                       
                   //   this.listBox1.Items.Add(item);
                       



                    }


                    
                 


                }
                
    }
            catch (Exception erro)
            {
                System.Windows.MessageBox.Show("Erro" + erro);
                this.Close();
            }

            dbConn.Close();
        }



        public class BattleShipRow
        {
            public string Cell1 { get; set; }
            public string Cell2 { get; set; }
            public string Cell3 { get; set; }
            public string Cell4 { get; set; }
            public string Cell5 { get; set; }
            public string Cell6 { get; set; }
            public string Cell7 { get; set; }
            public string Cell8 { get; set; }
            public string Cell9 { get; set; }
            public string Cell10 { get; set; }
            public string Cell11 { get; set; }
            public string Cell12 { get; set; }
        }

        private void LoadGridData()
        {
            battleShipGrid = new List<BattleShipRow>();
            for (var i = 0; i < 3; i++)
            {
                battleShipGrid.Add(new BattleShipRow());
            }
            myNewGrid.DataSource = battleShipGrid;
        }

        private void MyNewGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         //   throw new NotImplementedException();
        }























        private void ListBox1_DrawItem(object sender,
    System.Windows.Forms.DrawItemEventArgs e)
        {
           // // Draw the background of the ListBox control for each item.
           // e.DrawBackground();
           // // Define the default color of the brush as black.
           // Brush myBrush = Brushes.Black;

           // // Determine the color of the brush to draw each item based 
           // // on the index of the item to draw.
           // switch (e.Index)
           // {
           //     case 0:
           //         myBrush = Brushes.Red;
           //         break;
           //     case 1:
           //         myBrush = Brushes.Orange;
           //         break;
           //     case 2:
           //         myBrush = Brushes.Purple;
           //         break;
           // }
           // myBrush = Brushes.Purple;

           // // Draw the current item text based on the current Font 
           // // and the custom brush settings.
           //e.Graphics.DrawString(listBox1.Items[e.Index].ToString(),
           //     e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
           // // If the ListBox has focus, draw a focus rectangle around the selected item.
           // e.DrawFocusRectangle();
        }

        private void Users_ControlAdded(object sender, ControlEventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_Click(object sender, EventArgs e)
        {
          
           
           
        }

        private void Users_Deactivate(object sender, EventArgs e)
        {

            form1.WindowState  = FormWindowState.Maximized;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //e.ColumnIndex
            String barcode  = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

           

            Form2 Detail;

 
            barcode = barcode.Split('#')[0];



            int numRows = 0;

            string dbpwd = "lightwave";
            MySql.Data.MySqlClient.MySqlConnection dbConn = new MySql.Data.MySqlClient.MySqlConnection("Persist Security Info=False;server=localhost;database=phidelity;uid=root;password=" + dbpwd);
            //    barcode = "00001";
            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = "SELECT * FROM phidelity.cards where barcode='" + barcode + "' ;";
            Console.WriteLine("MySQL command= {0}", cmd.CommandText
                    );


            dbConn.Open();


            MySqlDataReader reader = cmd.ExecuteReader();
            Detail = new Form2();
            Detail.TextBoxBarcode = barcode;

            while (reader.Read())
            {
                string nome = reader.GetString("nome");
                string cognome = reader.GetString("cognome");
                string punti = reader.GetString("punti");
                string email = reader.GetString("email");
                string telefono = reader.GetString("telefono");
                Detail.TextBoxNome = nome;
                if (email != null)
                    Detail.TextBoxEmail = email;
                if (telefono != null)
                    Detail.TextBoxTelefono = telefono;
                if (cognome != null)
                    Detail.TextBoxCognome = cognome;
                if (punti != null)
                    Detail.TextBoxPunti = punti;
                numRows++;



            }

            Detail.CanModify = true;


            //  MessageBox.Show(barcode);
            Detail.Show();


        }

        private void Users_Shown(object sender, EventArgs e)
        {
            //FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = FormWindowState.Normal;
            WindowState = FormWindowState.Maximized;
        }
    }
}
