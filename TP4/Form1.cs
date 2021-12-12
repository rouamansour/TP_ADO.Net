using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP4
{
    public partial class FMenu : MetroFramework.Forms.MetroForm
    {
        public FMenu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Ajout_Client(object sender, EventArgs e)
        {
            FListe_Cl f = new FListe_Cl();
            f.Show();
        }

        private void FMenu_Load(object sender, EventArgs e)
        {
            Connexion.Ouvrir();
            MessageBox.Show(Connexion.cn.State.ToString());
        }

        private void FMenu_Leave(object sender, EventArgs e)
        {
            Connexion.Fermer();
        }
    }
}
