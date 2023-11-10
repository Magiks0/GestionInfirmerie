using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InfirmerieBLL;
using System.Configuration;

namespace InfirmerieGUI
{
    public partial class GestionInfirmerie : Form
    {
        public GestionInfirmerie()
        {
            InitializeComponent();
            GestionInfirmerieBL.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Infirmerie"]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            string login = loginId.Text;
            string mdp = loginPassword.Text;

            bool authentifie = GestionInfirmerieBL.AuthentifierInfirmerie(login, mdp);

            if (authentifie)
            {
                MessageBox.Show("Authentification réussie !");
            }
            else
            {
                MessageBox.Show("Authentification échouée. Vérifiez vos identifiants.");
            }
        }
    }
}
