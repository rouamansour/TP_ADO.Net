
namespace TP4
{
    partial class FProduit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FProduit));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_Ref = new MetroFramework.Controls.MetroTextBox();
            this.Txt_Desg = new MetroFramework.Controls.MetroTextBox();
            this.Txt_Prix = new MetroFramework.Controls.MetroTextBox();
            this.Txt_Qte = new MetroFramework.Controls.MetroTextBox();
            this.Cmb_Categ = new MetroFramework.Controls.MetroComboBox();
            this.Btn_Enregistrer = new MetroFramework.Controls.MetroButton();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Nouv_Lig = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nouv_Lig)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajout nouveau produit";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reference";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Designation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Categorie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prix de vente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Qte en stk";
            // 
            // Txt_Ref
            // 
            // 
            // 
            // 
            this.Txt_Ref.CustomButton.Image = null;
            this.Txt_Ref.CustomButton.Location = new System.Drawing.Point(86, 1);
            this.Txt_Ref.CustomButton.Name = "";
            this.Txt_Ref.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.Txt_Ref.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Ref.CustomButton.TabIndex = 1;
            this.Txt_Ref.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Ref.CustomButton.UseSelectable = true;
            this.Txt_Ref.CustomButton.Visible = false;
            this.Txt_Ref.Lines = new string[0];
            this.Txt_Ref.Location = new System.Drawing.Point(98, 64);
            this.Txt_Ref.MaxLength = 32767;
            this.Txt_Ref.Name = "Txt_Ref";
            this.Txt_Ref.PasswordChar = '\0';
            this.Txt_Ref.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Ref.SelectedText = "";
            this.Txt_Ref.SelectionLength = 0;
            this.Txt_Ref.SelectionStart = 0;
            this.Txt_Ref.ShortcutsEnabled = true;
            this.Txt_Ref.Size = new System.Drawing.Size(110, 25);
            this.Txt_Ref.TabIndex = 7;
            this.Txt_Ref.UseSelectable = true;
            this.Txt_Ref.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Ref.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Txt_Desg
            // 
            // 
            // 
            // 
            this.Txt_Desg.CustomButton.Image = null;
            this.Txt_Desg.CustomButton.Location = new System.Drawing.Point(79, 2);
            this.Txt_Desg.CustomButton.Name = "";
            this.Txt_Desg.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.Txt_Desg.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Desg.CustomButton.TabIndex = 1;
            this.Txt_Desg.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Desg.CustomButton.UseSelectable = true;
            this.Txt_Desg.CustomButton.Visible = false;
            this.Txt_Desg.Lines = new string[0];
            this.Txt_Desg.Location = new System.Drawing.Point(98, 117);
            this.Txt_Desg.MaxLength = 32767;
            this.Txt_Desg.Name = "Txt_Desg";
            this.Txt_Desg.PasswordChar = '\0';
            this.Txt_Desg.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Desg.SelectedText = "";
            this.Txt_Desg.SelectionLength = 0;
            this.Txt_Desg.SelectionStart = 0;
            this.Txt_Desg.ShortcutsEnabled = true;
            this.Txt_Desg.Size = new System.Drawing.Size(107, 30);
            this.Txt_Desg.TabIndex = 8;
            this.Txt_Desg.UseSelectable = true;
            this.Txt_Desg.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Desg.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Txt_Prix
            // 
            // 
            // 
            // 
            this.Txt_Prix.CustomButton.Image = null;
            this.Txt_Prix.CustomButton.Location = new System.Drawing.Point(79, 2);
            this.Txt_Prix.CustomButton.Name = "";
            this.Txt_Prix.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.Txt_Prix.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Prix.CustomButton.TabIndex = 1;
            this.Txt_Prix.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Prix.CustomButton.UseSelectable = true;
            this.Txt_Prix.CustomButton.Visible = false;
            this.Txt_Prix.Lines = new string[0];
            this.Txt_Prix.Location = new System.Drawing.Point(98, 210);
            this.Txt_Prix.MaxLength = 32767;
            this.Txt_Prix.Name = "Txt_Prix";
            this.Txt_Prix.PasswordChar = '\0';
            this.Txt_Prix.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Prix.SelectedText = "";
            this.Txt_Prix.SelectionLength = 0;
            this.Txt_Prix.SelectionStart = 0;
            this.Txt_Prix.ShortcutsEnabled = true;
            this.Txt_Prix.Size = new System.Drawing.Size(107, 30);
            this.Txt_Prix.TabIndex = 11;
            this.Txt_Prix.UseSelectable = true;
            this.Txt_Prix.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Prix.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_Prix.Click += new System.EventHandler(this.Txt_Prix_Click);
            // 
            // Txt_Qte
            // 
            // 
            // 
            // 
            this.Txt_Qte.CustomButton.Image = null;
            this.Txt_Qte.CustomButton.Location = new System.Drawing.Point(79, 2);
            this.Txt_Qte.CustomButton.Name = "";
            this.Txt_Qte.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.Txt_Qte.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Qte.CustomButton.TabIndex = 1;
            this.Txt_Qte.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Qte.CustomButton.UseSelectable = true;
            this.Txt_Qte.CustomButton.Visible = false;
            this.Txt_Qte.Lines = new string[0];
            this.Txt_Qte.Location = new System.Drawing.Point(98, 258);
            this.Txt_Qte.MaxLength = 32767;
            this.Txt_Qte.Name = "Txt_Qte";
            this.Txt_Qte.PasswordChar = '\0';
            this.Txt_Qte.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Qte.SelectedText = "";
            this.Txt_Qte.SelectionLength = 0;
            this.Txt_Qte.SelectionStart = 0;
            this.Txt_Qte.ShortcutsEnabled = true;
            this.Txt_Qte.Size = new System.Drawing.Size(107, 30);
            this.Txt_Qte.TabIndex = 12;
            this.Txt_Qte.UseSelectable = true;
            this.Txt_Qte.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Qte.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Cmb_Categ
            // 
            this.Cmb_Categ.FormattingEnabled = true;
            this.Cmb_Categ.ItemHeight = 23;
            this.Cmb_Categ.Location = new System.Drawing.Point(99, 171);
            this.Cmb_Categ.Name = "Cmb_Categ";
            this.Cmb_Categ.Size = new System.Drawing.Size(105, 29);
            this.Cmb_Categ.TabIndex = 13;
            this.Cmb_Categ.UseSelectable = true;
            // 
            // Btn_Enregistrer
            // 
            this.Btn_Enregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Enregistrer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Enregistrer.Location = new System.Drawing.Point(55, 326);
            this.Btn_Enregistrer.Name = "Btn_Enregistrer";
            this.Btn_Enregistrer.Size = new System.Drawing.Size(148, 39);
            this.Btn_Enregistrer.TabIndex = 15;
            this.Btn_Enregistrer.Text = "Enregistrer";
            this.Btn_Enregistrer.UseSelectable = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(287, 19);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(437, 435);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            // 
            // Nouv_Lig
            // 
            this.Nouv_Lig.Image = ((System.Drawing.Image)(resources.GetObject("Nouv_Lig.Image")));
            this.Nouv_Lig.Location = new System.Drawing.Point(55, 326);
            this.Nouv_Lig.Name = "Nouv_Lig";
            this.Nouv_Lig.Size = new System.Drawing.Size(43, 39);
            this.Nouv_Lig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Nouv_Lig.TabIndex = 20;
            this.Nouv_Lig.TabStop = false;
            // 
            // FProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 512);
            this.Controls.Add(this.Nouv_Lig);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.Btn_Enregistrer);
            this.Controls.Add(this.Cmb_Categ);
            this.Controls.Add(this.Txt_Qte);
            this.Controls.Add(this.Txt_Prix);
            this.Controls.Add(this.Txt_Desg);
            this.Controls.Add(this.Txt_Ref);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FProduit";
            this.Text = "FProduit";
            this.Load += new System.EventHandler(this.FProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nouv_Lig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroTextBox Txt_Ref;
        private MetroFramework.Controls.MetroTextBox Txt_Desg;
        private MetroFramework.Controls.MetroTextBox Txt_Prix;
        private MetroFramework.Controls.MetroTextBox Txt_Qte;
        private MetroFramework.Controls.MetroComboBox Cmb_Categ;
        private MetroFramework.Controls.MetroButton Btn_Enregistrer;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox Nouv_Lig;
    }
}