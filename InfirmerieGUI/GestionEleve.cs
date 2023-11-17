﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InfirmerieBLL;
using InfirmerieBO;
using InfirmerieDAL;

namespace InfirmerieGUI
{
    public partial class GestionEleve : Form
    {
        DateTimePicker dtp = new DateTimePicker();
        Rectangle _Rectangle;
        DataGridView dgv = new DataGridView();

        public GestionEleve()
        {
            InitializeComponent();
            GestionInfirmerieBL.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Infirmerie"]);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.button2.Click += new EventHandler(button2_Click);
            dataGridView1.CellFormatting += new DataGridViewCellFormattingEventHandler(dataGridView1_CellFormatting);



            // Création d'un objet List d'Eleve à afficher dans le datagridview
            List<Eleve> liste = new List<Eleve>();


            liste = GestionInfirmerieBL.ToutLesEleves();
            // Rattachement de la List à la source de données du datagridview

           dataGridView1.DataSource = liste;

            dataGridView1.Controls.Add(dtp);

            //for (int i = 0; i < liste.Count(); i++)
            //{
            //    dataGridView1[0, i].Value = liste[i].Firstname;
            //    dataGridView1[0, i].Value = liste[i].Lastname;
            //    dataGridView1[0, i].Value = liste[i].ClassNumber.GetName();
            //    dataGridView1[0, i].Value = liste[i].Birthdate;
            //    dataGridView1[0, i].Value = liste[i].Comment;
            //    dataGridView1[0, i].Value = liste[i].ParentsPhone;
            //    dataGridView1[0, i].Value = liste[i].Phone;
            //}

            dataGridView1.DataSource = liste;
            dtp.Visible = false;
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.TextChanged += new EventHandler(dtp_TextChange);
        }
        private void dtp_TextChange(Object sender, EventArgs e)
        {
            dataGridView1.CurrentCell.Value = dtp.Text.ToString();
        } 
        private void dataGridView1_Scroll(Object sender, EventArgs e)
        {
            dtp.Visible = false;
        }

        private void SupprimerEleve()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;

                Eleve eleveASupprimer = dataGridView1.Rows[index].DataBoundItem as Eleve;

                if (eleveASupprimer != null)
                {
                    // Appel de la méthode de suppression de la BLL
                    GestionInfirmerieBL.GetGestionInfirmeries().SupprimerEleve(eleveASupprimer);

                    // Rafraîchir le DataGridView
                    ActualiserDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un élève à supprimer.");
            }
        }

        private void ActualiserDataGridView()
        {
            dataGridView1.DataSource = GestionInfirmerieBL.ToutLesEleves();
        }

        private void AjouterEleve()
        {
            // Collecte des informations à partir des champs de saisie
            string nom = textBoxNom.Text;
            string prenom = textBoxPrenom.Text;
            DateTime dateNaissance = dateTimePickerNaissance.Value;
            string telEleve = textBoxTelEleve.Text;
            // Assurez-vous d'avoir un moyen d'obtenir l'ID de la classe
            int idClasse = int.Parse(comboBoxClasse.SelectedValue.ToString());
            string telParent = textBoxTelParent.Text;
            bool tiersTemps = checkBoxTiersTemps.Checked;
            string commentaire = textBoxCommentaire.Text;

            // Création de l'objet Eleve
            Eleve nouvelEleve = new Eleve(string nom, string prenom, );
            {
                Lastname = nom,
                Firstname = prenom,
                Birthdate = dateNaissance,
                Phone = telEleve,
                ClassNumber = new Classe(idClasse, /* Nom de la classe */),
                ParentsPhone = telParent,
                ExtraTime = tiersTemps,
                Comment = commentaire
            };

            // Ajout de l'élève via la BLL
            GestionInfirmerieBL.GetGestionInfirmeries().AjouterEleve(nouvelEleve);

            // Mise à jour du DataGridView
            ActualiserDataGridView();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            AjouterEleve();
        }


        private void lblAccueil_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void GestionEleve_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Classe Élève" && e.RowIndex >= 0)
            {
                Classe maClasse = dataGridView1.Rows[e.RowIndex].DataBoundItem as Classe;
                if (maClasse != null)
                {
                    e.Value = maClasse.GetName();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int indexNouvelleLigne = dataGridView1.Rows.Add();

            // Initialisation des valeurs de la nouvelle ligne (facultatif)
            dataGridView1.Rows[indexNouvelleLigne].Cells["NomColonne"].Value = "Valeur par défaut"; // Remplacez "NomColonne" et "Valeur par défaut" comme nécessaire
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SupprimerEleve();
        }
    }
}
