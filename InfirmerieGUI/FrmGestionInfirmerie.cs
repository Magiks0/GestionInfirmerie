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
            ActualiserDataGridViewVisites();


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

        #region Visites

        private void ActualiserDataGridViewVisites()
        {
            // Création d'un objet List de visites
            List<Visite> listeVisites = new List<Visite>();
            // Nouvel table qui permetera d'utiliser la liste de visites
            DataTable datatableVisites = new DataTable();

            listeVisites = GestionInfirmerieBL.ToutesLesVisites();

            // Add columns to the DataTable
            datatableVisites.Columns.Add("Id");
            datatableVisites.Columns.Add("Id Eleve");
            datatableVisites.Columns.Add("Nom Eleve");
            datatableVisites.Columns.Add("Prénom Eleve");
            datatableVisites.Columns.Add("Date Debut Visite");
            datatableVisites.Columns.Add("Date Fin Visite");
            datatableVisites.Columns.Add("Motif");
            datatableVisites.Columns.Add("Commentaire");
            datatableVisites.Columns.Add("Renvoi Domicile ?");
            datatableVisites.Columns.Add("Hospitalisation ?");
            datatableVisites.Columns.Add("Parents Prevenu ?");
            datatableVisites.Columns.Add("Id Médicament");
            datatableVisites.Columns.Add("Médicament");
            datatableVisites.Columns.Add("Quantité Médicaments");

            foreach (Visite visit in listeVisites)
            {
                // Add rows to the DataTable
                DataRow row = datatableVisites.NewRow();
                row["Id"] = visit.Id;
                row["Id Eleve"] = visit.Eleve.Id;
                row["Nom Eleve"] = visit.Eleve.Lastname.ToString();
                row["Prénom Eleve"] = visit.Eleve.Firstname.ToString();
                row["Date Debut Visite"] = visit.DateVisite.ToString("dd/MM/yyyy") + " " + visit.HeureDebutVisite.ToString();
                row["Date Fin Visite"] = visit.DateVisite.ToString("dd/MM/yyyy") + " " + visit.HeureFinVisite.ToString();
                row["Motif"] = visit.MotifVisite.ToString();
                row["Commentaire"] = visit.CommentaireVisite.ToString();
                row["Renvoi Domicile ?"] = visit.RenvoiDomicile.ToString();
                row["Hospitalisation ?"] = visit.Hospitalisation.ToString();
                row["Parents Prevenu ?"] = visit.ParentsPrevenus.ToString();
                row["Id Médicament"] = visit.Medicament.Id;
                row["Médicament"] = visit.Medicament.Nom.ToString();
                row["Quantité Médicaments"] = visit.QuantiteMedicament.ToString();
                datatableVisites.Rows.Add(row);
            }
            //rattacher au dgv le datatable
            dgvVisites.DataSource = datatableVisites;
        }

        private void dgvVisites_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // on affiche le panel de modif uniquement
            pnlAjoutVisite.Visible = false;
            pnlModifVisite.Visible = true;

            // on efface tous les champs ajouter au cas où l'utilisateur les avait remplis
            txtAjoutCommentaireVisite.Text = "";
            txtAjoutMotifVisite.Text = "";
            txtAjoutQuantiteMedicamentVisite.Text = "";

            //ELEVE COMBO BOX
            List<Eleve> lesEleves = GestionInfirmerieBL.ToutLesEleves();
            cbModifEleveVisite.DataSource = lesEleves;

            //Medicaments COMBO BOX
            List<Medicament> lesMedicaments = GestionInfirmerieBL.ToutLesMedicaments();
            cbModifMedicamentVisite.DataSource = lesMedicaments;

            int indexRow = e.RowIndex;
            if (indexRow >= 0 && indexRow < dgvVisites.Rows.Count -1)
            {
                DataGridViewRow row = dgvVisites.Rows[indexRow];
                //get the id
                txtModifIdVisite.Text = row.Cells["Id"].Value.ToString();
                //get the combo boxes right
                //cbModifEleveVisite.SelectedItem = row.Cells["Id Eleve"].Value;


                // Assuming that "Id Eleve" is an integer
                int idEleve = int.Parse(row.Cells["Id Eleve"].Value.ToString());

                // Find the corresponding Eleve object in the list
                Eleve selectedEleve = lesEleves.Find(eleve => eleve.Id == idEleve);

                // Set the selected item in the ComboBox
                cbModifEleveVisite.SelectedItem = selectedEleve;

                // Assuming that "Id Médicament" is an integer
                int idMedicament = int.Parse(row.Cells["Id Médicament"].Value.ToString());

                // Find the corresponding Medicament object in the list
                Medicament selectedMedicament = lesMedicaments.Find(medicament => medicament.Id == idMedicament);

                // Set the selected item in the ComboBox
                cbModifMedicamentVisite.SelectedItem = selectedMedicament;


                //cbModifMedicamentVisite.SelectedIndex = int.Parse(row.Cells["Id Médicament"].Value.ToString()) -1;
                //txt
                txtModifCommentaireVisite.Text = row.Cells["Commentaire"].Value.ToString();
                txtModifMotifVisite.Text = row.Cells["Motif"].Value.ToString();
                txtModifQuantiteMedicamentVisite.Text = row.Cells["Quantité Médicaments"].Value.ToString();
                //check-box
                chkbModifHospitalisationVisite.Checked = bool.Parse(row.Cells["Hospitalisation ?"].Value.ToString());
                chkbModifParentsPrevenusVisite.Checked = bool.Parse(row.Cells["Parents Prevenu ?"].Value.ToString());
                chkbModifRenvoiDomicileVisite.Checked = bool.Parse(row.Cells["Renvoi Domicile ?"].Value.ToString());
                //dtp
                dtpModifDateDebutVisite.Value = DateTime.Parse(row.Cells["Date Debut Visite"].Value.ToString());
                dtpModifDateFinVisite.Value = DateTime.Parse(row.Cells["Date Fin Visite"].Value.ToString());
            }

            //DataGridViewRow newRow = dgvVisites.SelectedRows[0];
            //txtModifIdVisite.Text = dgvVisites.SelectedRows[0].Cells["Id"].Value.ToString();
            //cbModifEleveVisite.SelectedIndex = int.Parse(dgvVisites.SelectedRows[0].Cells["Id Eleve"].Value.ToString());

        }

        private void btnConfirmerVisite_Click(object sender, EventArgs e)
        {

            if (pnlAjoutVisite.Visible)
            {
                object newEleveobj = cbAjoutEleveVisite.SelectedItem;
                Eleve newEleve = newEleveobj as Eleve;
                Medicament nouvMedicament = cbAjoutMedicamentVisite.SelectedItem as Medicament;
                Visite nouvVisite = new Visite(newEleve, dtpAjoutDateDebutVisite.Value.TimeOfDay, dtpAjoutDateDebutVisite.Value, dtpAjoutDateFinVisite.Value.TimeOfDay, txtAjoutMotifVisite.Text, txtAjoutCommentaireVisite.Text, chkbAjoutRenvoiDomicileVisite.Checked, chkbAjoutHospitalisationVisite.Checked, chkbAjoutParentsPrevenusVisite.Checked, nouvMedicament, txtAjoutQuantiteMedicamentVisite.Text);

                if (GestionInfirmerieBL.AjouterVisite(nouvVisite) != 0)
                {
                    MessageBox.Show("La visite a bien été ajouté.", "Ajout Réussi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNomMedicAjout.Text = "";
                    ActualiserDataGridViewMedicaments();
                }
                else
                {
                    MessageBox.Show("Erreur lors de l'ajout de la visite.", "Erreur d'Ajout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else if (pnlModifVisite.Visible)
            {
            Eleve updatedEleve = cbModifEleveVisite.SelectedItem as Eleve;
            Medicament updatedMedicament = cbModifMedicamentVisite.SelectedItem as Medicament;

                int.TryParse(txtIdMedicModif.Text, out idMedicModif);
                Visite nouvVisite = new Visite(int.Parse(txtModifIdVisite.Text) ,updatedEleve,  dtpModifDateDebutVisite.Value, dtpModifDateDebutVisite.Value.TimeOfDay, dtpModifDateFinVisite.Value.TimeOfDay, txtModifMotifVisite.Text, txtModifCommentaireVisite.Text, chkbModifRenvoiDomicileVisite.Checked, chkbModifHospitalisationVisite.Checked, chkbModifParentsPrevenusVisite.Checked, updatedMedicament, txtModifQuantiteMedicamentVisite.Text);
                if (GestionInfirmerieBL.UpdateVisite(nouvVisite) != 0)
                {
                    MessageBox.Show("Les modifications de la visite ont bien été prises en compte.", "Modifications Réussies", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualiserDataGridViewVisites();
                }
                else
                {
                    MessageBox.Show("Erreur lors de la modification des données de la visite.\nAucune modification n'a été apportée.", "Erreur Modifications", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnAjouterVisite_Click(object sender, EventArgs e)
        {
            pnlModifVisite.Visible = false;
            pnlAjoutVisite.Visible = true;


            //ELEVE COMBO BOX
            List<Eleve> lesEleves = GestionInfirmerieBL.ToutLesEleves();
            cbAjoutEleveVisite.DataSource = lesEleves;

            //Medicaments COMBO BOX
            List<Medicament> lesMedicaments = GestionInfirmerieBL.ToutLesMedicaments();
            cbAjoutMedicamentVisite.DataSource = lesMedicaments;


        }

        private void cbAjoutMedicamentVisite_TextChanged(object sender, EventArgs e)
        {
            if (cbAjoutMedicamentVisite.SelectedIndex != -1)
            {
                // An item is selected, make the TextBox visible and update its value
                txtAjoutQuantiteMedicamentVisite.Visible = true;
                lblAjoutQuantiteMedicamentVisite.Visible = true;

                // You can set the initial value of the TextBox based on the selected item
                // For example, if your Medicament class has a property Quantity, you can do:
                // txtAjoutQuantiteMedicamentVisite.Text = lesMedicaments[cbAjoutMedicamentVisite.SelectedIndex].Quantity.ToString();
            }
            else
            {
                // No item is selected, make the TextBox invisible

                txtAjoutQuantiteMedicamentVisite.Visible = false;
                lblAjoutQuantiteMedicamentVisite.Visible = false;
                // Optionally, clear the value in the TextBox
                txtAjoutQuantiteMedicamentVisite.Text = string.Empty;
            }
        }
        private void btnSupprimerVisite_Click(object sender, EventArgs e)
        {
            dgvVisites.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Check if any row is selected
            if (dgvVisites.SelectedRows.Count > 0 || dgvVisites.SelectedCells.Count > 0)
            {
                string idSuppr = dgvVisites.SelectedRows[0].Cells["Id"].Value.ToString();
                string nomSuppr = dgvVisites.SelectedRows[0].Cells["Nom Eleve"].Value.ToString();

                var confirmation = MessageBox.Show("Voulez-vous vraiment supprimer la visite de '" + nomSuppr + "' ?", "Confirmation de Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmation == DialogResult.Yes)
                {
                    int.TryParse(idSuppr, out int idVisiteSuppr);

                    // Assuming GestionInfirmerieBL.SupprimerVisite takes a Visite object for deletion
                    Visite visiteToDelete = new Visite(idVisiteSuppr); // Assuming there is an Id property in the Visite class

                    if (GestionInfirmerieBL.SupprimerVisite(visiteToDelete) != 0)
                    {
                        ActualiserDataGridViewVisites();
                        MessageBox.Show("La visite de '" + nomSuppr + "' a bien été supprimée.", "Suppression Réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de la suppression de la visite de '" + nomSuppr + "'.", "Erreur de Suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner une visite à supprimer.", "Aucune Visite Sélectionnée", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        #endregion

        #region ToolStripMenu
        private void médicamentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMedicaments.Visible = true;
            pnlEleves.Visible = false;
            pnlVisites.Visible = false;
            ActualiserDataGridViewMedicaments();
        }

        private void élèvesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlEleves.Visible = true;
            pnlMedicaments.Visible = false;
            pnlVisites.Visible = false;
            ActualiserDataGridViewEleves();
        }

        private void visitesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlVisites.Visible = true;
            pnlEleves.Visible = false;
            pnlMedicaments.Visible = false;
            ActualiserDataGridViewVisites();
        }

        #endregion

    }
}
