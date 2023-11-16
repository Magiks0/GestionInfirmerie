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
    public partial class GestionEleve : Form
    {
        DateTimePicker dtp = new DateTimePicker();
        Rectangle _Rectangle;
        DataGridView dgv = new DataGridView();

        public GestionEleve()
        {
            InitializeComponent();
            GestionInfirmerieBL.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Infirmerie"]);

            // Création d'un objet List d'Eleve à afficher dans le datagridview
            List<Eleve> liste = new List<Eleve>();


            liste = GestionInfirmerieBL.ToutLesEleves();
            // Rattachement de la List à la source de données du datagridview

            dataGridView1.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn lastNameColumn = new DataGridViewTextBoxColumn();
            lastNameColumn.DataPropertyName = "Lastname";
            lastNameColumn.HeaderText = "Nom Élève";
            dataGridView1.Columns.Add(lastNameColumn);

            DataGridViewTextBoxColumn firstNameColumn = new DataGridViewTextBoxColumn();
            firstNameColumn.DataPropertyName = "Firstname";
            firstNameColumn.HeaderText = "Prénom Élève";
            dataGridView1.Columns.Add(firstNameColumn);

            DataGridViewTextBoxColumn classColumn = new DataGridViewTextBoxColumn();
            classColumn.DataPropertyName = "classNumber";
            classColumn.HeaderText = "Classe Élève";
            dataGridView1.Columns.Add(classColumn);

            DataGridViewTextBoxColumn birthDateColumn = new DataGridViewTextBoxColumn();
            birthDateColumn.DataPropertyName = "Birthdate";
            birthDateColumn.HeaderText = "Date de Naissance Élève";
            dataGridView1.Columns.Add(birthDateColumn);

            DataGridViewTextBoxColumn healthColumn = new DataGridViewTextBoxColumn();
            healthColumn.DataPropertyName = "Comment";
            healthColumn.HeaderText = "Santé de l'Élève";
            dataGridView1.Columns.Add(healthColumn);

            DataGridViewTextBoxColumn parentPhoneColumn = new DataGridViewTextBoxColumn();
            parentPhoneColumn.DataPropertyName = "ParentsPhone";
            parentPhoneColumn.HeaderText = "Numéro Téléphone Parent Élève";
            dataGridView1.Columns.Add(parentPhoneColumn);

            DataGridViewTextBoxColumn studentPhoneColumn = new DataGridViewTextBoxColumn();
            studentPhoneColumn.DataPropertyName = "Phone";
            studentPhoneColumn.HeaderText = "Numéro Téléphone Élève";
            dataGridView1.Columns.Add(studentPhoneColumn);

            DataGridViewTextBoxColumn extraTimeColumn = new DataGridViewTextBoxColumn();
            studentPhoneColumn.DataPropertyName = "ExtraTime";
            studentPhoneColumn.HeaderText = "Tiers temps?";
            dataGridView1.Columns.Add(extraTimeColumn);

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

        private void lblAccueil_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (dataGridView1.Columns[e.ColumnIndex].Name)
            {
                case "date_naissance":
                    _Rectangle = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                    dtp.Size = new Size(_Rectangle.Width, _Rectangle.Height);
                    dtp.Location = new Point(_Rectangle.X, _Rectangle.Y);
                    dtp.Visible = true;
                    break;
            }
        }

        private void GestionEleve_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
