using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Metier1;
using DAO;
namespace TP4
{
    public partial class FListe_Cl : Form
    {
        public FListe_Cl()
        {
            InitializeComponent();
        }

        private void Dg_Client_DoubleClick(object sender, EventArgs e)
        {
            int ind = Dg_Client.CurrentRow.Index;
            Txt_CIN.Text = Dg_Client[0, ind].Value.ToString();
            Txt_Nom.Text = Dg_Client[1, ind].Value.ToString();
            Txt_Prenom.Text = Dg_Client[2, ind].Value.ToString();
            Txt_Ville.Text = Dg_Client[3, ind].Value.ToString();
            Txt_Tel.Text = Dg_Client[4, ind].Value.ToString();
        }

        private void FListe_Client_Load(object sender, EventArgs e)
        {
            Dg_Client.DataSource = ClientAdo.Liste_Client();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Ajouter_Client(object sender, EventArgs e)
        {

            if (ClientAdo.Existe_Client(Int64.Parse(Txt_CIN.Text)))
                MetroFramework.MetroMessageBox.Show(this, "\n\nClient déjà existant", "Attention !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
            {
                Client C = new Client
                {
                    CIN_Cl = Int64.Parse(Txt_CIN.Text),
                    Nom_Cl = Txt_Nom.Text,
                    Pren_Cl = Txt_Prenom.Text,
                    Ville_Cl = Txt_Ville.Text,
                    Tel_Cl = Int64.Parse(Txt_Tel.Text)
                };
                ClientAdo CA = new ClientAdo();
                CA.Inserer(C);
                Dg_Client.DataSource = ClientAdo.Liste_Client();
            }



        }

        private void Mdifier_click(object sender, EventArgs e)
        {
            
        }

        private void Modifier_click(object sender, EventArgs e)
        {
            Client C = new Client
            {
                CIN_Cl = Int64.Parse(Txt_CIN.Text),
                Nom_Cl = Txt_Nom.Text,
                Pren_Cl = Txt_Prenom.Text,
                Ville_Cl = Txt_Ville.Text,
                Tel_Cl = Int64.Parse(Txt_Tel.Text)
            };
            ClientAdo CA = new ClientAdo();
            CA.Modifier(C);
            Dg_Client.DataSource = ClientAdo.Liste_Client();
        }

        private void supprimer_click(object sender, EventArgs e)
        {
            DialogResult Rep = MetroFramework.MetroMessageBox.Show(this, "\n\nVoulez-vous Confirmer la Suppression", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Rep == DialogResult.Yes)
            {
                ClientAdo CA = new ClientAdo();
                CA.Supprimer(Int64.Parse(Txt_CIN.Text));
                Dg_Client.DataSource = ClientAdo.Liste_Client();
            }
        }

        private void rechercher_click(object sender, EventArgs e)
        {
            DataTable dtc = ClientAdo.Liste_Client(Int64.Parse(Txt_CIN.Text));
            if (dtc.Rows.Count == 0)
                MetroFramework.MetroMessageBox.Show(this, "Client inexistant");
            else
            {
                Txt_Nom.Text = dtc.Rows[0][1].ToString();
                Txt_Prenom.Text = dtc.Rows[0][2].ToString();
                Txt_Ville.Text = dtc.Rows[0][3].ToString();
                Txt_Tel.Text = dtc.Rows[0][1].ToString();
            }
        }

        private void Txt_CIN_Click(object sender, EventArgs e)
        {

        }
    }
    }
}
