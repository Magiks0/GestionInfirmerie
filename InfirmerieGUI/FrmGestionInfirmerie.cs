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
using InfirmerieDAL;

namespace InfirmerieGUI
{
    public partial class FrmGestionInfirmerie : Form
    {
        DateTimePicker dtp = new DateTimePicker();
        Rectangle _Rectangle;
        DataGridView dgv = new DataGridView();

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

        public FrmGestionInfirmerie()
        {
            InitializeComponent();
            GestionInfirmerieBL.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Infirmerie"]);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.button2.Click += new EventHandler(button2_Click);
            dataGridView1.CellFormatting += new DataGridViewCellFormattingEventHandler(dataGridView1_CellFormatting);

            dgvMedicaments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.btnConfirmerMedic.Click += new EventHandler(btnConfirmerMedic_Click);


            ActualiserDataGridViewEleves();
            ActualiserDataGridViewMedicaments();


            dataGridView1.Controls.Add(dtp);

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
                    // Afficher une MessageBox pour confirmer la suppression
                    var confirmation = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet élève ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Vérifier si l'utilisateur a cliqué sur 'Yes'
                    if (confirmation == DialogResult.Yes)
                    {
                        // Appel de la méthode de suppression de la BLL
                        GestionInfirmerieBL.GetGestionInfirmeries().SupprimerEleve(eleveASupprimer);

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
            dataGridView1.DataSource = dataTable;
        }



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

            //foreach (DataRow row in datatableMedicaments.Rows)
            //{
            //    MessageBox.Show(row["Id"].ToString() + " " + row["Nom"].ToString());
            //}

            //rattacher au dgv le datatable
            dgvMedicaments.DataSource = datatableMedicaments;
        }




        #region A FAIRE
        //private void AjouterEleve()
        //{
        //    // Collecte des informations à partir des champs de saisie
        //    string nom = txtNomAjout.Text;
        //    string prenom = textBox2.Text;
        //    DateTime dateNaissance = dtp.Value;
        //    string telEleve = textBoxTelEleve.Text;
        //    // Assurez-vous d'avoir un moyen d'obtenir l'ID de la classe
        //    int idClasse = int.Parse(comboBoxClasse.SelectedValue.ToString());
        //    string telParent = textBoxTelParent.Text;
        //    bool tiersTemps = checkBoxTiersTemps.Checked;
        //    string commentaire = textBoxCommentaire.Text;

        //    // Création de l'objet Eleve
        //    Eleve nouvelEleve = new Eleve(string nom, string prenom, string dateNaissance);
        //    {
        //        Lastname = nom,
        //        Firstname = prenom,
        //        Birthdate = dateNaissance,
        //        Phone = telEleve,
        //        ClassNumber = new Classe(idClasse, /* Nom de la classe */),
        //        ParentsPhone = telParent,
        //        ExtraTime = tiersTemps,
        //        Comment = commentaire
        //    };

        //    // Ajout de l'élève via la BLL
        //    GestionInfirmerieBL.GetGestionInfirmeries().AjouterEleve(nouvelEleve);

        //    // Mise à jour du DataGridView
        //    ActualiserDataGridViewEleves();
        //}

        //private void buttonAjouter_Click(object sender, EventArgs e)
        //{
        //    AjouterEleve();
        //}
        #endregion

        private void lblAccueil_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pnlModif.Visible = true;


            int.TryParse(txtIdModif.Text = dataGridView1.SelectedCells[0].Value.ToString(), out idModif);

            nomModif = txtNomModif.Text = dataGridView1.SelectedCells[1].Value.ToString();
            prenomModif = txtPrenomModif.Text = dataGridView1.SelectedCells[2].Value.ToString();

            //Selection de la date a l'apparition du calendrier
            DateTime date = new DateTime();
            DateTime.TryParse(dataGridView1.SelectedCells[3].Value.ToString(), out date);
            selectedDate = monthCalendar1.SelectionStart = date;

             NumEleveModif = txtNumeroEleve.Text = dataGridView1.SelectedCells[4].Value.ToString();
             NumParentModif = txtNumeroParent.Text = dataGridView1.SelectedCells[7].Value.ToString();

            bool.TryParse(dataGridView1.SelectedCells[8].Value.ToString(), out check);
            extraTime = chkExtraTime.Checked = check;
            
            comments = txtComments.Text = dataGridView1.SelectedCells[9].Value.ToString();


            //comboBox1.Items =
            //int index;
            //int.TryParse(dataGridView1.SelectedCells[5].Value.ToString(), out index);
            //comboBox1.SelectedIndex = index;
            //comboBox1.SelectedItem = dataGridView1.SelectedCells[6].Value.ToString();

        }

        private void GestionEleve_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Classe uneClasse = new Classe(1, "Seconde1");
            Eleve updateEleve = new Eleve(idModif, txtNomModif.Text, txtPrenomModif.Text, monthCalendar1.SelectionStart, txtNumeroEleve.Text, uneClasse, txtNumeroParent.Text, chkExtraTime.Checked, txtComments.Text);
            EleveDAO.UpdateEleve(updateEleve);
            ActualiserDataGridViewEleves();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void txtBirthdateModif_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtComments_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dgvMedicaments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pnlAjoutMedic.Visible = false;
            pnlMedicModif.Visible = true;
            txtNomMedicAjout.Text = "";

            txtIdMedicModif.Text = dgvMedicaments.SelectedRows[0].Cells["Id"].Value.ToString();
            txtNomMedicModif.Text = dgvMedicaments.SelectedRows[0].Cells["Nom"].Value.ToString();

        }

        private void pnlMedicaments_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConfirmerMedic_Click(object sender, EventArgs e)
        {
            if (txtNomMedicAjout.Text != "")
            {
                Medicament nouvMedicament = new Medicament(txtNomMedicAjout.Text);
                if (MedicamentDAO.InsertMedicament(nouvMedicament) != 0)
                { 
                    MessageBox.Show(txtNomMedicAjout.Text + " à bien été ajouté !");
                    txtNomMedicAjout.Text = "";
                    ActualiserDataGridViewMedicaments();
                }else{
                    MessageBox.Show("Erreur dans l'ajout de "+ txtNomMedicAjout.Text + " !");
                }
             
            }

            string changes = dgvMedicaments.SelectedRows[0].Cells["Nom"].Value.ToString();
            if(txtNomMedicModif.Text != changes && txtNomMedicModif.Text != "")
            {   
                int.TryParse(txtIdMedicModif.Text, out idMedicModif);
                Medicament unMedicament = new Medicament(idMedicModif, txtNomMedicModif.Text);
                if(MedicamentDAO.UpdateMedicament(unMedicament) != 0)
                {
                    MessageBox.Show("Vos modifications ont bien été pris en compte !");
                    ActualiserDataGridViewMedicaments();
                }
                else
                {
                    MessageBox.Show("Vos modifications n'ont pas été appliqués !");
                }
            }
        }

        private void txtNomMedicAjout_TextChanged(object sender, EventArgs e)
        {

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
            var confirmation = MessageBox.Show("Voulez-vous supprimer " + nomSuppr + " ?","Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(confirmation == DialogResult.Yes)
            {
                string idSuppr = dgvMedicaments.SelectedRows[0].Cells["Id"].Value.ToString();
                int.TryParse(idSuppr, out idMedicModif);
                Medicament DelMedicament = new Medicament(idMedicModif, txtNomMedicModif.Text);
                if(MedicamentDAO.DeleteMedicament(DelMedicament) != 0)
                {
                    MessageBox.Show(nomSuppr + " à bien été supprimé !");
                    ActualiserDataGridViewMedicaments();
                }
                else
                {
                    MessageBox.Show("Erreur de suppression !");
                }
            }
        }
    }
}
