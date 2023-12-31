﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InfirmerieBLL;
using InfirmerieBO;
using System.Configuration;

namespace InfirmerieGUI
{
    public partial class GstionInfirmerie : Form
    {
        public GstionInfirmerie()
        {
            //Initialisation du Formulaire
            InitializeComponent();

            // Initialisation de la chaîne de connexion
            GestionInfirmerieBL.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Infirmerie"]);
        }
        // Click du bouton "Connexion"
        private void connectButton_Click(object sender, EventArgs e)
        {
            string login = loginId.Text;
            string mdp = loginPassword.Text;
            Utilisateur user = new Utilisateur(login, mdp);


            bool authentifie = GestionInfirmerieBL.AuthentifierInfirmerie(user);

            if (authentifie)
            {
                // Créer un nouveau formulaire SI l'authentification réussi
                MessageBox.Show("Authentification réussie !");
                this.Hide();
                FrmGestionInfirmerie FrmHome = new FrmGestionInfirmerie();
                FrmHome.ShowDialog();
                this.Close();
            }
            else
            {
                // L'authentification n'est pas réussi, on renvoie un message d'erreur
                labelId.ForeColor = Color.Red;
                labelPassword.ForeColor = Color.Red;
                MessageBox.Show("Authentification échouée. Vérifiez vos identifiants.");
            }
        }

        private void loginId_TextChanged(object sender, EventArgs e)
        {
            if(loginId.TextLength == 0)
            {
                labelId.ForeColor = Color.Black;
            }
        }

        private void loginPassword_TextChanged(object sender, EventArgs e)
        {
            if (loginPassword.TextLength == 0)
            {
                labelPassword.ForeColor = Color.Black;
            }
        }

        private void GstionInfirmerie_Load(object sender, EventArgs e)
        {

        }
    }
}
