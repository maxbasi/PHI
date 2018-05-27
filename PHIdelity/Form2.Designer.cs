namespace PHIdelity
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPunti = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCognome = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tb_barcode = new System.Windows.Forms.TextBox();
            this.lab_changeble = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("A Yummy Apology", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(840, 228);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(281, 79);
            this.button1.TabIndex = 18;
            this.button1.Text = "aggiungi ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("A Yummy Apology", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(835, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 32);
            this.label4.TabIndex = 17;
            this.label4.Text = "Punti";
            // 
            // tbPunti
            // 
            this.tbPunti.BackColor = System.Drawing.Color.Red;
            this.tbPunti.Font = new System.Drawing.Font("Berlin Sans FB", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPunti.ForeColor = System.Drawing.Color.Honeydew;
            this.tbPunti.Location = new System.Drawing.Point(840, 135);
            this.tbPunti.Margin = new System.Windows.Forms.Padding(5);
            this.tbPunti.Name = "tbPunti";
            this.tbPunti.ReadOnly = true;
            this.tbPunti.Size = new System.Drawing.Size(281, 64);
            this.tbPunti.TabIndex = 16;
            this.tbPunti.TabStop = false;
            this.tbPunti.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("A Yummy Apology", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(438, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 30);
            this.label3.TabIndex = 15;
            this.label3.Text = "Cognome";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("A Yummy Apology", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 30);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nome";
            // 
            // tbCognome
            // 
            this.tbCognome.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCognome.ForeColor = System.Drawing.Color.Red;
            this.tbCognome.Location = new System.Drawing.Point(443, 147);
            this.tbCognome.Margin = new System.Windows.Forms.Padding(5);
            this.tbCognome.Name = "tbCognome";
            this.tbCognome.ReadOnly = true;
            this.tbCognome.Size = new System.Drawing.Size(331, 41);
            this.tbCognome.TabIndex = 13;
            this.tbCognome.TabStop = false;
            this.tbCognome.Enter += new System.EventHandler(this.tbCognome_Enter);
            this.tbCognome.MouseEnter += new System.EventHandler(this.tbCognome_MouseEnter);
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.ForeColor = System.Drawing.Color.Red;
            this.tbNome.Location = new System.Drawing.Point(77, 147);
            this.tbNome.Margin = new System.Windows.Forms.Padding(5);
            this.tbNome.Name = "tbNome";
            this.tbNome.ReadOnly = true;
            this.tbNome.Size = new System.Drawing.Size(354, 41);
            this.tbNome.TabIndex = 12;
            this.tbNome.TabStop = false;
            this.tbNome.TextChanged += new System.EventHandler(this.tbNome_TextChanged);
            this.tbNome.Enter += new System.EventHandler(this.tbNome_Enter);
            this.tbNome.Leave += new System.EventHandler(this.tbNome_Leave);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("A Yummy Apology", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(72, 228);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.TabIndex = 28;
            this.label1.Text = "E-mail";
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tbEmail.Location = new System.Drawing.Point(77, 263);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(5);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(354, 32);
            this.tbEmail.TabIndex = 27;
            this.tbEmail.Enter += new System.EventHandler(this.tbEmail_Enter);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("A Yummy Apology", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(438, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 30);
            this.label5.TabIndex = 30;
            this.label5.Text = "Telefono ";
            // 
            // tbTelefono
            // 
            this.tbTelefono.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefono.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tbTelefono.Location = new System.Drawing.Point(443, 263);
            this.tbTelefono.Margin = new System.Windows.Forms.Padding(5);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(354, 32);
            this.tbTelefono.TabIndex = 29;
            this.tbTelefono.Enter += new System.EventHandler(this.tbTelefono_Enter);
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Image = global::PHIdelity.Properties.Resources._15001;
            this.button2.Location = new System.Drawing.Point(1156, 263);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 189);
            this.button2.TabIndex = 31;
            this.button2.Text = "1500";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button8
            // 
            this.button8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button8.Image = global::PHIdelity.Properties.Resources._90;
            this.button8.Location = new System.Drawing.Point(1130, 462);
            this.button8.Margin = new System.Windows.Forms.Padding(5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(209, 223);
            this.button8.TabIndex = 26;
            this.button8.Text = "90";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Image = global::PHIdelity.Properties.Resources._2001;
            this.button7.Location = new System.Drawing.Point(471, 462);
            this.button7.Margin = new System.Windows.Forms.Padding(5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(210, 223);
            this.button7.TabIndex = 25;
            this.button7.Text = "220";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Image = global::PHIdelity.Properties.Resources._300;
            this.button6.Location = new System.Drawing.Point(251, 462);
            this.button6.Margin = new System.Windows.Forms.Padding(5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(210, 223);
            this.button6.TabIndex = 24;
            this.button6.Text = "300";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Image = global::PHIdelity.Properties.Resources._1801;
            this.button5.Location = new System.Drawing.Point(691, 462);
            this.button5.Margin = new System.Windows.Forms.Padding(5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(210, 223);
            this.button5.TabIndex = 20;
            this.button5.Text = "200";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Image = global::PHIdelity.Properties.Resources._3201;
            this.button4.Location = new System.Drawing.Point(31, 462);
            this.button4.Margin = new System.Windows.Forms.Padding(5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(210, 223);
            this.button4.TabIndex = 21;
            this.button4.Text = "320";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.Image = global::PHIdelity.Properties.Resources._150;
            this.button3.Location = new System.Drawing.Point(911, 462);
            this.button3.Margin = new System.Windows.Forms.Padding(5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(209, 223);
            this.button3.TabIndex = 22;
            this.button3.Text = "150";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tb_barcode
            // 
            this.tb_barcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_barcode.ForeColor = System.Drawing.Color.Gainsboro;
            this.tb_barcode.Location = new System.Drawing.Point(77, 198);
            this.tb_barcode.Margin = new System.Windows.Forms.Padding(5);
            this.tb_barcode.Name = "tb_barcode";
            this.tb_barcode.ReadOnly = true;
            this.tb_barcode.Size = new System.Drawing.Size(129, 20);
            this.tb_barcode.TabIndex = 12;
            this.tb_barcode.TabStop = false;
            this.tb_barcode.Text = "-----";
            this.tb_barcode.TextChanged += new System.EventHandler(this.tbNome_TextChanged);
            this.tb_barcode.Enter += new System.EventHandler(this.tbNome_Enter);
            this.tb_barcode.Leave += new System.EventHandler(this.tbNome_Leave);
            // 
            // lab_changeble
            // 
            this.lab_changeble.AutoSize = true;
            this.lab_changeble.Font = new System.Drawing.Font("Adobe Caslon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_changeble.Location = new System.Drawing.Point(13, 13);
            this.lab_changeble.Name = "lab_changeble";
            this.lab_changeble.Size = new System.Drawing.Size(60, 27);
            this.lab_changeble.TabIndex = 32;
            this.lab_changeble.Text = "--------";
            // 
            // Form2
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 731);
            this.Controls.Add(this.lab_changeble);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPunti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCognome);
            this.Controls.Add(this.tb_barcode);
            this.Controls.Add(this.tbNome);
            this.Font = new System.Drawing.Font("A Yummy Apology", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "STATO CLIENTE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Form2_Activated);
            this.Deactivate += new System.EventHandler(this.Form2_Deactivate);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Shown += new System.EventHandler(this.Form2_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPunti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCognome;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tb_barcode;
        private System.Windows.Forms.Label lab_changeble;
    }
}