using System;
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

namespace InfirmerieGUI
{
    public partial class FrmGestionInfirmerie : Form
    {
        #region Déclaration des variables
        DateTimePicker dtp = new DateTimePicker();
        //Eleves
        private int idModif;
        private string nomModif;
        private string prenomModif;
        private DateTime selectedDate;
        private string NumEleveModif;
        private string NumParentModif;
        private string comments;
        private bool check;
        private bool extraTime;

        //Medicaments
        int idMedicModif;
        string nomMedicModif;
        #endregion

        public FrmGestionInfirmerie()
        {
            InitializeComponent();
            GestionInfirmerieBL.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Infirmerie"]);
            dgvEleves.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.btnConfirmereleve.Click += new EventHandler(button2_Click);
            dgvEleves.CellFormatting += new DataGridViewCellFormattingEventHandler(dataGridView1_CellFormatting);

            dgvMedicaments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.btnConfirmerMedic.Click += new EventHandler(btnConfirmerMedic_Click);


            ActualiserDataGridViewEleves();
            ActualiserDataGridViewMedicaments();


            dgvEleves.Controls.Add(dtp);

            dtp.Visible = false;
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.TextChanged += new EventHandler(dtp_TextChange);
        }

        #region Elèves
        private void dtp_TextChange(Object sender, EventArgs e)
        {
            dgvEleves.CurrentCell.Value = dtp.Text.ToString();
        } 
        private void dataGridView1_Scroll(Object sender, EventArgs e)
        {
            dtp.Visible = false;
        }

        private void SupprimerEleve()
        {
            if (dgvEleves.SelectedRows.Count > 0)
            {
                int.TryParse(dgvEleves.SelectedRows[0].Cells["ClassId"].Value.ToString(), out int idClasseADel);
                int index = dgvEleves.SelectedRows[0].Index;
                int idModif;
                int.TryParse(dgvEleves.SelectedRows[0].Cells["Id"].Value.ToString(), out idModif);
                string nomModif = dgvEleves.SelectedRows[0].Cells["LastName"].Value.ToString();
                string prenomModif = dgvEleves.SelectedRows[0].Cells["FirstName"].Value.ToString();
                DateTime dateNaissance = DateTime.Parse(dgvEleves.SelectedRows[0].Cells["Birthdate"].Value.ToString());
                string numEleve = dgvEleves.SelectedRows[0].Cells["Phone"].Value.ToString();
                Classe numClasse = new Classe(idClasseADel, dgvEleves.SelectedRows[0].Cells["ClassName"].Value.ToString());
                string numParent = dgvEleves.SelectedRows[0].Cells["ParentsPhone"].Value.ToString();
                bool extraTime;
                bool.TryParse(dgvEleves.SelectedRows[0].Cells["extraTime"].Value.ToString(), out extraTime);
                string comment = dgvEleves.SelectedRows[0].Cells["Comment"].Value.ToString();

                Eleve eleveASupprimer = new Eleve(idModif, nomModif, prenomModif, dateNaissance, numEleve, numClasse, numParent, extraTime, comment);

                if (eleveASupprimer != null)
                {
                    // Afficher une MessageBox pour confirmer la suppression
                    var confirmation = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet élève ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Vérifier si l'utilisateur a cliqué sur 'Yes'
                    if (confirmation == DialogResult.Yes)
                    {
                        // Appel de la méthode de suppression de la BLL
                        GestionInfirmerieBL.SupprimerEleve(eleveASupprimer);

                        // Rafraîchir le DataGridView
                        ActualiserDataGridViewEleves();
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un élève à supprimer.");
            }
        }
        private void ActualiserDataGridViewEleves()
        {
            // Création d'un objet List d'Eleve
            List<Eleve> listeEleves = new List<Eleve>();
            // Nouvel table qui permetera d'utiliser la listeEleves d'élèves
            DataTable dataTable = new DataTable();

            listeEleves = GestionInfirmerieBL.ToutLesEleves();

            // Add columns to the DataTable
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Firstname");
            dataTable.Columns.Add("Lastname");
            dataTable.Columns.Add("Birthdate");
            dataTable.Columns.Add("Phone");
            dataTable.Columns.Add("ClassId");
            dataTable.Columns.Add("ClassName");
            dataTable.Columns.Add("ParentsPhone");
            dataTable.Columns.Add("ExtraTime");
            dataTable.Columns.Add("Comment");

            foreach (Eleve unEleve in listeEleves)
            {
                // Add rows to the DataTable
                dataTable.Rows.Add(
                    unEleve.Id.ToString(),
                    unEleve.Firstname.ToString(),
                    unEleve.Lastname.ToString(),
                    unEleve.Birthdate.ToString(),
                    unEleve.Phone.ToString(),
                    unEleve.ClassNumber.GetId().ToString(),
                    unEleve.ClassNumber.GetName().ToString(),
                    unEleve.ParentsPhone.ToString(),
                    unEleve.ExtraTime.ToString(),
                    unEleve.Comment.ToString()
                );
            }

            // Rattachement de la DataTable à la source de données du datagridview
            dgvEleves.DataSource = dataTable;
        }


        #region A FAIRE
        private void AjouterEleve()
        {
            // Collecte des informations à partir des champs de saisie
            string nom = txtNomEleveAjout.Text;
            string prenom = txtPrenomEleveAjout.Text;
            DateTime dateNaissance = mcBirthdateEleveAjout.SelectionStart;
            string telEleve = txtNumeroEleveAjout.Text;
            // Assurez-vous d'avoir un moyen d'obtenir l'ID de la classe
            Classe classe = new Classe(1);
            string telParent = txtNumeroParentEleveAjout.Text;
            bool tiersTemps = chkExtraTimeEleveAjout.Checked;
            string commentaire = txtCommentaireEleveAjout.Text;


            // Création de l'objet Eleve
            Eleve nouvelEleve = new Eleve(nom, prenom, dateNaissance, telEleve, classe, telParent, tiersTemps, commentaire);

            // Ajout de l'élève via la BLL
            GestionInfirmerieBL.AjouterEleve(nouvelEleve);

            // Mise à jour du DataGridView
            ActualiserDataGridViewEleves();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            AjouterEleve();
        }
        #endregion

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pnlModif.Visible = true;


            int.TryParse(txtIdModif.Text = dgvEleves.SelectedCells[0].Value.ToString(), out idModif);

            nomModif = txtNomModif.Text = dgvEleves.SelectedCells[2].Value.ToString();
            prenomModif = txtPrenomModif.Text = dgvEleves.SelectedCells[1].Value.ToString();

            //Selection de la date a l'apparition du calendrier
            DateTime date = new DateTime();
            DateTime.TryParse(dgvEleves.SelectedCells[3].Value.ToString(), out date);
            selectedDate = monthCalendar1.SelectionStart = date;

             NumEleveModif = txtNumeroEleve.Text = dgvEleves.SelectedCells[4].Value.ToString();
             NumParentModif = txtNumeroParent.Text = dgvEleves.SelectedCells[7].Value.ToString();

            bool.TryParse(dgvEleves.SelectedCells[8].Value.ToString(), out check);
            extraTime = chkExtraTime.Checked = check;
            
            comments = txtComments.Text = dgvEleves.SelectedCells[9].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Classe uneClasse = new Classe(1, "Seconde1");
            Eleve updateEleve = new Eleve(idModif, txtNomModif.Text, txtPrenomModif.Text, monthCalendar1.SelectionStart, txtNumeroEleve.Text, uneClasse, txtNumeroParent.Text, chkExtraTime.Checked, txtComments.Text);
            GestionInfirmerieBL.UpdateEleve(updateEleve);
            ActualiserDataGridViewEleves();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvEleves.Columns[e.ColumnIndex].HeaderText == "Classe Élève" && e.RowIndex >= 0)
            {
                Classe maClasse = dgvEleves.Rows[e.RowIndex].DataBoundItem as Classe;
                if (maClasse != null)
                {
                    e.Value = maClasse.GetName();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int indexNouvelleLigne = dgvEleves.Rows.Add();

            // Initialisation des valeurs de la nouvelle ligne (facultatif)
            dgvEleves.Rows[indexNouvelleLigne].Cells["NomColonne"].Value = "Valeur par défaut"; // Remplacez "NomColonne" et "Valeur par défaut" comme nécessaire
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SupprimerEleve();
        }
        #endregion

        #region Médicaments

        private void ActualiserDataGridViewMedicaments()
        {
            // Création d'un objet List d'Eleve
            List<Medicament> listeMedicaments = new List<Medicament>();
            // Nouvel table qui permetera d'utiliser la liste de medicaments
            DataTable datatableMedicaments = new DataTable();

            listeMedicaments = GestionInfirmerieBL.ToutLesMedicaments();

            // Add columns to the DataTable
            datatableMedicaments.Columns.Add("Id");
            datatableMedicaments.Columns.Add("Nom");

            foreach (Medicament medic in listeMedicaments)
            {
                // Add rows to the DataTable
                DataRow row = datatableMedicaments.NewRow();
                row["Id"] = medic.Id.ToString();
                row["Nom"] = medic.Nom.ToString();
                datatableMedicaments.Rows.Add(row);
            }
            //rattacher au dgv le datatable
            dgvMedicaments.DataSource = datatableMedicaments;
        }

        private void médicamentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMedicaments.Visible = true;
            pnlEleves.Visible = false;
            ActualiserDataGridViewMedicaments();
        }

        private void élèvesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlEleves.Visible = true;
            pnlMedicaments.Visible = false;
        }

        private void dgvMedicaments_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            pnlAjoutMedic.Visible = false;
            pnlMedicModif.Visible = true;
            txtNomMedicAjout.Text = "";

            txtIdMedicModif.Text = dgvMedicaments.SelectedRows[0].Cells["Id"].Value.ToString();
            txtNomMedicModif.Text = dgvMedicaments.SelectedRows[0].Cells["Nom"].Value.ToString();

        }

        private void btnConfirmerMedic_Click(object sender, EventArgs e)
        {
            if (txtNomMedicAjout.Text != "")
            {
                Medicament nouvMedicament = new Medicament(txtNomMedicAjout.Text);
                if (GestionInfirmerieBL.AjouterMedicament(nouvMedicament) != 0)
                {
                    MessageBox.Show("Le médicament '" + txtNomMedicAjout.Text + "' a bien été ajouté.", "Ajout Réussi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNomMedicAjout.Text = "";
                    ActualiserDataGridViewMedicaments();
                }
                else
                {
                    MessageBox.Show("Erreur lors de l'ajout du médicament '" + txtNomMedicAjout.Text + "'.", "Erreur d'Ajout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            string changes = dgvMedicaments.SelectedRows[0].Cells["Nom"].Value.ToString();
            if (txtNomMedicModif.Text != changes && txtNomMedicModif.Text != "")
            {
                int.TryParse(txtIdMedicModif.Text, out idMedicModif);
                Medicament unMedicament = new Medicament(idMedicModif, txtNomMedicModif.Text);
                if (GestionInfirmerieBL.UpdateMedicament(unMedicament) != 0)
                {
                    MessageBox.Show("Les modifications du médicament ont bien été prises en compte.", "Modifications Réussies", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualiserDataGridViewMedicaments();
                }
                else
                {
                    MessageBox.Show("Erreur lors de la modification des données du médicament.\nAucune modification n'a été apportée.", "Erreur Modifications", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnAjoutMEdic_Click(object sender, EventArgs e)
        {
            pnlMedicModif.Visible = false;
            pnlAjoutMedic.Visible = true;
            txtNomMedicModif.Text = "";
            txtIdMedicAjout.Text = "";
        }

        private void btnSupprimerMedic_Click(object sender, EventArgs e)
        {
            string nomSuppr = dgvMedicaments.SelectedRows[0].Cells["Nom"].Value.ToString();
            var confirmation = MessageBox.Show("Voulez-vous vraiment supprimer le médicament '" + nomSuppr + "' ?", "Confirmation de Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation == DialogResult.Yes)
            {
                string idSuppr = dgvMedicaments.SelectedRows[0].Cells["Id"].Value.ToString();
                int.TryParse(idSuppr, out idMedicModif);
                Medicament DelMedicament = new Medicament(idMedicModif, txtNomMedicModif.Text);

                if (GestionInfirmerieBL.SupprimerMedicament(DelMedicament) != 0)
                {
                    ActualiserDataGridViewMedicaments();
                    txtNomMedicModif.Text = "";
                    MessageBox.Show("Le médicament '" + nomSuppr + "' a bien été supprimé.", "Suppression Réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erreur lors de la suppression du médicament '" + nomSuppr + "'.", "Erreur de Suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        
    }
}
