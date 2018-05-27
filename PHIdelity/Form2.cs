using System.Net.Mail;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;
using MySql.Data.MySqlClient;

namespace PHIdelity
{
    public partial class Form2 : Form
    {

        public enum KeyboardLayoutMode
        {
            Default,
            ThumbLayout,
            Handwriting
        }

        private static readonly RegistryKey registryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\TabletTip\\1.7");


        public Boolean CanModify = false;
        string barcode = "";

        public Form2()
        {
            InitializeComponent();
        }


        public string TextBoxCognome
        {
            get { return tbCognome.Text; }
            set { tbCognome.Text = value; }
        }

        public string TextBoxNome
        {
            get { return tbNome.Text; }
            set { tbNome.Text = value; }
        }

        

         public string TextBoxTelefono

        {
            get { return tbTelefono.Text; }
            set { tbTelefono.Text = value; }
        }


        public string TextBoxEmail

        {
            get { return tbEmail.Text; }
            set { tbEmail.Text = value; }
        }


        public string TextBoxPunti
        {
            get { return tbPunti.Text; }
            set { tbPunti.Text = value; }
        }

        public string TextBoxBarcode
        {
            get { return barcode; }
            set { barcode = value; tb_barcode.Text = value; }
        }

        private void Form2_Deactivate(object sender, EventArgs e)
        {
            if (CanModify ) aggiornaDatiAnagrafici();

            Form1 f1 = (Form1)Application.OpenForms["Form1"];
            Users fusers = (Users)Application.OpenForms["Users"];
            if (fusers!=null) fusers.update();
            //Users_Load(null, new EventArgs ());
            f1.TextBoxBarcode = "";
            f1.Form1focus();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            Form3 changePunti = new Form3();
            changePunti.Show();

            //SmtpClient client = new SmtpClient();
            //client.Port = 587;
            //client.Host = "smtp.gmail.com";
            //client.EnableSsl = true;
            //client.Timeout = 10000;
            //client.DeliveryMethod = SmtpDeliveryMethod.Network;
            //client.UseDefaultCredentials = false;
            //client.Credentials = new System.Net.NetworkCredential("maxbasi71@gmail.com", "Lightwave3d");

            //MailMessage mm = new MailMessage("donotreply@nonsolofieno.com", "maxbasi@libero.it", "test", "test");
            //mm.BodyEncoding = UTF8Encoding.UTF8;
            //mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            //client.Send(mm);



        }

        private void button4_Click(object sender, EventArgs e)
        {
            Uso usaPunti = new Uso();
            usaPunti.TextBoxPunti = (sender as Button).Text;
            int punti = Int32.Parse(tbPunti.Text);
            if (punti > Int32.Parse((sender as Button).Text)) {   usaPunti.ShowDialog(); }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Uso usaPunti = new Uso();
            usaPunti.TextBoxPunti = (sender as Button).Text;
            int punti = Int32.Parse(tbPunti.Text);
            if (punti > Int32.Parse((sender as Button).Text)) { usaPunti.ShowDialog(); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Uso usaPunti = new Uso();
            usaPunti.TextBoxPunti = (sender as Button).Text;
            int punti = Int32.Parse(tbPunti.Text);
            if (punti > Int32.Parse((sender as Button).Text)) { usaPunti.ShowDialog(); }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Uso usaPunti = new Uso();
            usaPunti.TextBoxPunti = (sender as Button).Text;
            int punti = Int32.Parse(tbPunti.Text);
            if (punti > Int32.Parse((sender as Button).Text)) { usaPunti.ShowDialog(); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Uso usaPunti = new Uso();
            usaPunti.TextBoxPunti = (sender as Button).Text;
            int punti = Int32.Parse(tbPunti.Text);
            if (punti > Int32.Parse((sender as Button).Text)) { usaPunti.ShowDialog(); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Uso usaPunti = new Uso();
            usaPunti.TextBoxPunti = (sender as Button).Text;
            int punti = Int32.Parse(tbPunti.Text);
            if (punti > Int32.Parse((sender as Button).Text)) { usaPunti.ShowDialog(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Uso usaPunti = new Uso();
            usaPunti.TextBoxPunti = (sender as Button).Text;
            int punti = Int32.Parse(tbPunti.Text);
            if (punti > Int32.Parse((sender as Button).Text)) { usaPunti.ShowDialog(); }
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

        private void tbCognome_MouseEnter(object sender, EventArgs e)
        {
           if (CanModify) ShowKeyboard(true);
         
        }

        private void tbNome_Enter(object sender, EventArgs e)
        {
            //ystem.Diagnostics.Process.Start("osk.exe");
           if (CanModify) ShowKeyboard(true);
        }

        private void tbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCognome_Enter(object sender, EventArgs e)
        {
           if (CanModify) ShowKeyboard(true);
        }

        private void tbEmail_Enter(object sender, EventArgs e)
        {
           if (CanModify) ShowKeyboard(true);
        }

        private void tbTelefono_Enter(object sender, EventArgs e)
        {
           if (CanModify) ShowKeyboard(true);
        }

        private void tbNome_Leave(object sender, EventArgs e)
        {
            
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            lab_changeble.Text ="mod:"+ CanModify.ToString();
            tbCognome.ReadOnly =  ! CanModify;
            tbNome.ReadOnly = !CanModify;
            tbEmail.ReadOnly =! CanModify;
            tbTelefono.ReadOnly =! CanModify;
            


        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            lab_changeble.Text = "mod:" + CanModify.ToString();
            tbCognome.ReadOnly = !CanModify;
            tbNome.ReadOnly =! CanModify;
            tbEmail.ReadOnly = !CanModify;
            tbTelefono.ReadOnly = !CanModify;
        }


        


        private void aggiornaDatiAnagrafici( )
        {

            string dbpwd = "lightwave";
            MySql.Data.MySqlClient.MySqlConnection dbConn = new MySql.Data.MySqlClient.MySqlConnection("Persist Security Info=False;server=localhost;database=phidelity;uid=root;password=" + dbpwd);

            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = "UPDATE phidelity.cards SET nome ='" + tbNome.Text.Replace("'","''") + "', cognome="+ "'" + tbCognome.Text.Replace("'", "''") +  "'"+
              " ,telefono= '" + tbTelefono.Text + "'"+
              " ,email= '" + tbEmail.Text + "'  WHERE barcode = '"+barcode+"';";

            Console.WriteLine("MySQL command= {0}", cmd.CommandText);

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
