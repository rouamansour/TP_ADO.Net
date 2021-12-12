
namespace TP4
{
    partial class FListe_Cl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FListe_Cl));
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_CIN = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Nom = new MetroFramework.Controls.MetroTextBox();
            this.Txt_Ville = new MetroFramework.Controls.MetroTextBox();
            this.Txt_Prenom = new MetroFramework.Controls.MetroTextBox();
            this.Txt_Tel = new MetroFramework.Controls.MetroTextBox();
            this.Dg_Client = new MetroFramework.Controls.MetroGrid();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CIN";
            // 
            // Txt_CIN
            // 
            // 
            // 
            // 
            this.Txt_CIN.CustomButton.Image = null;
            this.Txt_CIN.CustomButton.Location = new System.Drawing.Point(400, 4);
            this.Txt_CIN.CustomButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Txt_CIN.CustomButton.Name = "";
            this.Txt_CIN.CustomButton.Size = new System.Drawing.Size(82, 79);
            this.Txt_CIN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_CIN.CustomButton.TabIndex = 1;
            this.Txt_CIN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_CIN.CustomButton.UseSelectable = true;
            this.Txt_CIN.CustomButton.Visible = false;
            this.Txt_CIN.Lines = new string[0];
            this.Txt_CIN.Location = new System.Drawing.Point(144, 33);
            this.Txt_CIN.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Txt_CIN.MaxLength = 32767;
            this.Txt_CIN.Name = "Txt_CIN";
            this.Txt_CIN.PasswordChar = '\0';
            this.Txt_CIN.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_CIN.SelectedText = "";
            this.Txt_CIN.SelectionLength = 0;
            this.Txt_CIN.SelectionStart = 0;
            this.Txt_CIN.ShortcutsEnabled = true;
            this.Txt_CIN.Size = new System.Drawing.Size(244, 46);
            this.Txt_CIN.TabIndex = 1;
            this.Txt_CIN.UseSelectable = true;
            this.Txt_CIN.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_CIN.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_CIN.Click += new System.EventHandler(this.Txt_CIN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ville";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(568, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(510, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Téléphone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(962, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Prénom";
            // 
            // Txt_Nom
            // 
            // 
            // 
            // 
            this.Txt_Nom.CustomButton.Image = null;
            this.Txt_Nom.CustomButton.Location = new System.Drawing.Point(400, 4);
            this.Txt_Nom.CustomButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Txt_Nom.CustomButton.Name = "";
            this.Txt_Nom.CustomButton.Size = new System.Drawing.Size(82, 79);
            this.Txt_Nom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Nom.CustomButton.TabIndex = 1;
            this.Txt_Nom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Nom.CustomButton.UseSelectable = true;
            this.Txt_Nom.CustomButton.Visible = false;
            this.Txt_Nom.Lines = new string[0];
            this.Txt_Nom.Location = new System.Drawing.Point(646, 37);
            this.Txt_Nom.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Txt_Nom.MaxLength = 32767;
            this.Txt_Nom.Name = "Txt_Nom";
            this.Txt_Nom.PasswordChar = '\0';
            this.Txt_Nom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Nom.SelectedText = "";
            this.Txt_Nom.SelectionLength = 0;
            this.Txt_Nom.SelectionStart = 0;
            this.Txt_Nom.ShortcutsEnabled = true;
            this.Txt_Nom.Size = new System.Drawing.Size(244, 46);
            this.Txt_Nom.TabIndex = 6;
            this.Txt_Nom.UseSelectable = true;
            this.Txt_Nom.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Nom.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Txt_Ville
            // 
            // 
            // 
            // 
            this.Txt_Ville.CustomButton.Image = null;
            this.Txt_Ville.CustomButton.Location = new System.Drawing.Point(400, 4);
            this.Txt_Ville.CustomButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Txt_Ville.CustomButton.Name = "";
            this.Txt_Ville.CustomButton.Size = new System.Drawing.Size(82, 79);
            this.Txt_Ville.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Ville.CustomButton.TabIndex = 1;
            this.Txt_Ville.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Ville.CustomButton.UseSelectable = true;
            this.Txt_Ville.CustomButton.Visible = false;
            this.Txt_Ville.Lines = new string[0];
            this.Txt_Ville.Location = new System.Drawing.Point(144, 169);
            this.Txt_Ville.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Txt_Ville.MaxLength = 32767;
            this.Txt_Ville.Name = "Txt_Ville";
            this.Txt_Ville.PasswordChar = '\0';
            this.Txt_Ville.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Ville.SelectedText = "";
            this.Txt_Ville.SelectionLength = 0;
            this.Txt_Ville.SelectionStart = 0;
            this.Txt_Ville.ShortcutsEnabled = true;
            this.Txt_Ville.Size = new System.Drawing.Size(244, 46);
            this.Txt_Ville.TabIndex = 7;
            this.Txt_Ville.UseSelectable = true;
            this.Txt_Ville.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Ville.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Txt_Prenom
            // 
            // 
            // 
            // 
            this.Txt_Prenom.CustomButton.Image = null;
            this.Txt_Prenom.CustomButton.Location = new System.Drawing.Point(400, 4);
            this.Txt_Prenom.CustomButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Txt_Prenom.CustomButton.Name = "";
            this.Txt_Prenom.CustomButton.Size = new System.Drawing.Size(82, 79);
            this.Txt_Prenom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Prenom.CustomButton.TabIndex = 1;
            this.Txt_Prenom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Prenom.CustomButton.UseSelectable = true;
            this.Txt_Prenom.CustomButton.Visible = false;
            this.Txt_Prenom.Lines = new string[0];
            this.Txt_Prenom.Location = new System.Drawing.Point(1088, 27);
            this.Txt_Prenom.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Txt_Prenom.MaxLength = 32767;
            this.Txt_Prenom.Name = "Txt_Prenom";
            this.Txt_Prenom.PasswordChar = '\0';
            this.Txt_Prenom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Prenom.SelectedText = "";
            this.Txt_Prenom.SelectionLength = 0;
            this.Txt_Prenom.SelectionStart = 0;
            this.Txt_Prenom.ShortcutsEnabled = true;
            this.Txt_Prenom.Size = new System.Drawing.Size(244, 46);
            this.Txt_Prenom.TabIndex = 8;
            this.Txt_Prenom.UseSelectable = true;
            this.Txt_Prenom.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Prenom.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Txt_Tel
            // 
            // 
            // 
            // 
            this.Txt_Tel.CustomButton.Image = null;
            this.Txt_Tel.CustomButton.Location = new System.Drawing.Point(400, 4);
            this.Txt_Tel.CustomButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Txt_Tel.CustomButton.Name = "";
            this.Txt_Tel.CustomButton.Size = new System.Drawing.Size(82, 79);
            this.Txt_Tel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Tel.CustomButton.TabIndex = 1;
            this.Txt_Tel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Tel.CustomButton.UseSelectable = true;
            this.Txt_Tel.CustomButton.Visible = false;
            this.Txt_Tel.Lines = new string[0];
            this.Txt_Tel.Location = new System.Drawing.Point(646, 169);
            this.Txt_Tel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Txt_Tel.MaxLength = 32767;
            this.Txt_Tel.Name = "Txt_Tel";
            this.Txt_Tel.PasswordChar = '\0';
            this.Txt_Tel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Tel.SelectedText = "";
            this.Txt_Tel.SelectionLength = 0;
            this.Txt_Tel.SelectionStart = 0;
            this.Txt_Tel.ShortcutsEnabled = true;
            this.Txt_Tel.Size = new System.Drawing.Size(244, 46);
            this.Txt_Tel.TabIndex = 9;
            this.Txt_Tel.UseSelectable = true;
            this.Txt_Tel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Tel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Dg_Client
            // 
            this.Dg_Client.AllowUserToResizeRows = false;
            this.Dg_Client.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Dg_Client.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dg_Client.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Dg_Client.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dg_Client.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dg_Client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dg_Client.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dg_Client.EnableHeadersVisualStyles = false;
            this.Dg_Client.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Dg_Client.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Dg_Client.Location = new System.Drawing.Point(170, 317);
            this.Dg_Client.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Dg_Client.Name = "Dg_Client";
            this.Dg_Client.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dg_Client.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Dg_Client.RowHeadersWidth = 82;
            this.Dg_Client.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dg_Client.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dg_Client.Size = new System.Drawing.Size(1343, 212);
            this.Dg_Client.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1170, 148);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 98);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.supprimer_click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1282, 150);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(102, 96);
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.rechercher_click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(950, 150);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(98, 96);
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.Ajouter_Client);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(1060, 150);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(98, 96);
            this.pictureBox6.TabIndex = 16;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.Modifier_click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox6);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.Txt_Tel);
            this.groupBox1.Controls.Add(this.Txt_Prenom);
            this.groupBox1.Controls.Add(this.Txt_Ville);
            this.groupBox1.Controls.Add(this.Txt_Nom);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Txt_CIN);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(1484, 269);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // FListe_Cl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Dg_Client);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FListe_Cl";
            this.Text = "Liste des clients";
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox Txt_CIN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTextBox Txt_Nom;
        private MetroFramework.Controls.MetroTextBox Txt_Ville;
        private MetroFramework.Controls.MetroTextBox Txt_Prenom;
        private MetroFramework.Controls.MetroTextBox Txt_Tel;
        private MetroFramework.Controls.MetroGrid Dg_Client;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}