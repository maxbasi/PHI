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
using Microsoft.Win32;
using System.Diagnostics;

namespace PHIdelity
{
    public partial class Nuovo : Form
    {

        public enum KeyboardLayoutMode
        {
            Default,
            ThumbLayout,
            Handwriting
        }

        private static readonly RegistryKey registryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\TabletTip\\1.7");


        string barcode = "";
        string punti = "";

        public Nuovo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string TextBoxPunti
        {
            get { return punti; }
            set { punti = value; }
        }

        public string TextBoxBarcode
        {
            get { return barcode; }
            set { barcode = value; }
        }
        private void button1_Click(object sender, EventArgs e)
        {


 


            string dbpwd = "lightwave";
            MySql.Data.MySqlClient.MySqlConnection dbConn = new MySql.Data.MySqlClient.MySqlConnection("Persist Security Info=False;server=localhost;database=phidelity;uid=root;password=" + dbpwd);
         
            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = "INSERT INTO phidelity.cards (nome,cognome,punti, barcode, telefono,email) VALUES("+
                "'"+tbNome.Text+"',"+
                "'" + tbCognome.Text + "'," +
                "'0'," +
                "'"+ barcode+ "'" +          " ," +
            "'" + tbTelefono.Text + "'" + ", "+
            "'" + tbEmail.Text + "'" + ") ;";
            Console.WriteLine("MySQL command= {0}", cmd.CommandText            );

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



            Close();
        }

        private void tbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbNome_Enter(object sender, EventArgs e)
        {
            ShowKeyboard(true);
        }




        private void Form2_Load(object sender, EventArgs e)
        {
            SetKeyboardDockedMode(true);
            SetKeyboardLayoutMode(KeyboardLayoutMode.ThumbLayout);

        }


        private static void SetKeyboardDockedMode(bool isDocked)
        {
            registryKey.SetValue("EdgeTargetDockedState", Convert.ToInt32(isDocked), RegistryValueKind.DWord);
        }



        public static void ShowKeyboard(bool killExistingProcess)
        {
            if (killExistingProcess)
            {
                // If the user presses the close button on the keyboard then TabTip.exe will still run in the background. If we have made registry
                // changes to the keyboard settings, they don't take effect until the process is started again so killing this ensures the keyboard
                // will open with our new settings.
                foreach (var process in Process.GetProcessesByName("TabTip"))
                {
                    process.Kill();
                }
            }

            string onScreenKeyboardPath = @"C:\Program Files\Common Files\Microsoft Shared\ink\TabTip.exe";
            Process.Start(onScreenKeyboardPath);
        }


        private static void SetKeyboardLayoutMode(KeyboardLayoutMode mode)
        {
            switch (mode)
            {
                case KeyboardLayoutMode.Handwriting:
                    registryKey.SetValue("KeyboardLayoutPreference", 0, RegistryValueKind.DWord);
                    registryKey.SetValue("LastUsedModalityWasHandwriting", 1, RegistryValueKind.DWord);
                    break;
                case KeyboardLayoutMode.ThumbLayout:
                    registryKey.SetValue("KeyboardLayoutPreference", 1, RegistryValueKind.DWord);
                    registryKey.SetValue("LastUsedModalityWasHandwriting", 0, RegistryValueKind.DWord);
                    // 0 = small, 1 = medium, 2 = large
                    registryKey.SetValue("ThumbKeyboardSizePreference", 2, RegistryValueKind.DWord);
                    break;
                default:
                    registryKey.SetValue("KeyboardLayoutPreference", 0, RegistryValueKind.DWord);
                    registryKey.SetValue("LastUsedModalityWasHandwriting", 0, RegistryValueKind.DWord);
                    break;
            }
        }






    }
}
