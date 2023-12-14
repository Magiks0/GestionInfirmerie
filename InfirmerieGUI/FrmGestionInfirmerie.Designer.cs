
namespace InfirmerieGUI
{
    partial class FrmGestionInfirmerie
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionInfirmerie));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint37 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 52D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint38 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 45D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint39 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 25D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint40 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint41 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint42 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint43 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint44 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint45 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint46 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint47 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 5D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint48 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 75D);
            this.lblAccueil = new System.Windows.Forms.Label();
            this.dgvEleves = new System.Windows.Forms.DataGridView();
            this.btnSupprimerEleve = new System.Windows.Forms.Button();
            this.btnConfirmereleve = new System.Windows.Forms.Button();
            this.btnAjoutEleve = new System.Windows.Forms.Button();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.visitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.élèvesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicamentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlModif = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.chkExtraTime = new System.Windows.Forms.CheckBox();
            this.lblNumeroTelParentModif = new System.Windows.Forms.Label();
            this.txtNumeroParent = new System.Windows.Forms.TextBox();
            this.lblTelEleveModif = new System.Windows.Forms.Label();
            this.txtNumeroEleve = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.lblPRenomModif = new System.Windows.Forms.Label();
            this.txtPrenomModif = new System.Windows.Forms.TextBox();
            this.txtIdModif = new System.Windows.Forms.TextBox();
            this.lblNomModif = new System.Windows.Forms.Label();
            this.txtNomModif = new System.Windows.Forms.TextBox();
            this.pnlEleves = new System.Windows.Forms.Panel();
            this.pnlAjoutEleve = new System.Windows.Forms.Panel();
            this.cboxClasseEleveAjout = new System.Windows.Forms.ComboBox();
            this.lblCommentaireEleveAjout = new System.Windows.Forms.Label();
            this.txtCommentaireEleveAjout = new System.Windows.Forms.TextBox();
            this.chkExtraTimeEleveAjout = new System.Windows.Forms.CheckBox();
            this.lblNumeroParentEleveAjout = new System.Windows.Forms.Label();
            this.txtNumeroParentEleveAjout = new System.Windows.Forms.TextBox();
            this.lblNumeroEleveAjout = new System.Windows.Forms.Label();
            this.txtNumeroEleveAjout = new System.Windows.Forms.TextBox();
            this.mcBirthdateEleveAjout = new System.Windows.Forms.MonthCalendar();
            this.lblBirthdateEleveAjout = new System.Windows.Forms.Label();
            this.lblPrenomEleveAjout = new System.Windows.Forms.Label();
            this.txtPrenomEleveAjout = new System.Windows.Forms.TextBox();
            this.txtIdEleveAjout = new System.Windows.Forms.TextBox();
            this.lblNomEleveAjout = new System.Windows.Forms.Label();
            this.txtNomEleveAjout = new System.Windows.Forms.TextBox();
            this.pnlMedicaments = new System.Windows.Forms.Panel();
            this.lblMedicaments = new System.Windows.Forms.Label();
            this.pnlAjoutMedic = new System.Windows.Forms.Panel();
            this.lblAjoutMedic = new System.Windows.Forms.Label();
            this.txtIdMedicAjout = new System.Windows.Forms.TextBox();
            this.lblNomMedicAjout = new System.Windows.Forms.Label();
            this.txtNomMedicAjout = new System.Windows.Forms.TextBox();
            this.pnlMedicModif = new System.Windows.Forms.Panel();
            this.lblModifMedic = new System.Windows.Forms.Label();
            this.txtIdMedicModif = new System.Windows.Forms.TextBox();
            this.lblNomMedicModif = new System.Windows.Forms.Label();
            this.txtNomMedicModif = new System.Windows.Forms.TextBox();
            this.btnAjoutMEdic = new System.Windows.Forms.Button();
            this.dgvMedicaments = new System.Windows.Forms.DataGridView();
            this.btnSupprimerMedic = new System.Windows.Forms.Button();
            this.btnConfirmerMedic = new System.Windows.Forms.Button();
            this.pnlVisites = new System.Windows.Forms.Panel();
            this.pnlModifVisite = new System.Windows.Forms.Panel();
            this.txtModifIdVisite = new System.Windows.Forms.TextBox();
            this.lblModifEleveVisite = new System.Windows.Forms.Label();
            this.cbModifEleveVisite = new System.Windows.Forms.ComboBox();
            this.lblModifMedicamentVisite = new System.Windows.Forms.Label();
            this.dtpModifDateFinVisite = new System.Windows.Forms.DateTimePicker();
            this.lblModifDateFinVisite = new System.Windows.Forms.Label();
            this.dtpModifDateDebutVisite = new System.Windows.Forms.DateTimePicker();
            this.chkbModifParentsPrevenusVisite = new System.Windows.Forms.CheckBox();
            this.chkbModifHospitalisationVisite = new System.Windows.Forms.CheckBox();
            this.cbModifMedicamentVisite = new System.Windows.Forms.ComboBox();
            this.txtModifCommentaireVisite = new System.Windows.Forms.TextBox();
            this.chkbModifRenvoiDomicileVisite = new System.Windows.Forms.CheckBox();
            this.lblModifQuantiteMedicamentVisite = new System.Windows.Forms.Label();
            this.txtModifQuantiteMedicamentVisite = new System.Windows.Forms.TextBox();
            this.lblModifCommentaireVisite = new System.Windows.Forms.Label();
            this.lblModifDateDebutVisite = new System.Windows.Forms.Label();
            this.lblModifMotifVisite = new System.Windows.Forms.Label();
            this.txtModifMotifVisite = new System.Windows.Forms.TextBox();
            this.pnlAjoutVisite = new System.Windows.Forms.Panel();
            this.lblAjoutEleveVisite = new System.Windows.Forms.Label();
            this.cbAjoutEleveVisite = new System.Windows.Forms.ComboBox();
            this.lblAjoutMedicamentVisite = new System.Windows.Forms.Label();
            this.dtpAjoutDateFinVisite = new System.Windows.Forms.DateTimePicker();
            this.lblAjoutDateFinVisite = new System.Windows.Forms.Label();
            this.dtpAjoutDateDebutVisite = new System.Windows.Forms.DateTimePicker();
            this.chkbAjoutParentsPrevenusVisite = new System.Windows.Forms.CheckBox();
            this.chkbAjoutHospitalisationVisite = new System.Windows.Forms.CheckBox();
            this.cbAjoutMedicamentVisite = new System.Windows.Forms.ComboBox();
            this.txtAjoutCommentaireVisite = new System.Windows.Forms.TextBox();
            this.chkbAjoutRenvoiDomicileVisite = new System.Windows.Forms.CheckBox();
            this.lblAjoutQuantiteMedicamentVisite = new System.Windows.Forms.Label();
            this.txtAjoutQuantiteMedicamentVisite = new System.Windows.Forms.TextBox();
            this.lblAjoutCommentaireVisite = new System.Windows.Forms.Label();
            this.lblAjoutDateDebutVisite = new System.Windows.Forms.Label();
            this.lblAjoutMotifVisite = new System.Windows.Forms.Label();
            this.txtAjoutMotifVisite = new System.Windows.Forms.TextBox();
            this.lblVisites = new System.Windows.Forms.Label();
            this.btnAjouterVisite = new System.Windows.Forms.Button();
            this.dgvVisites = new System.Windows.Forms.DataGridView();
            this.btnSupprimerVisite = new System.Windows.Forms.Button();
            this.btnConfirmerVisite = new System.Windows.Forms.Button();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.pnlSeparatorHorizontal = new System.Windows.Forms.Panel();
            this.pnlGraphique = new System.Windows.Forms.Panel();
            this.lblGraphNbVisite = new System.Windows.Forms.Label();
            this.Graphique = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlResults = new System.Windows.Forms.Panel();
            this.lblVisiteParDateResult = new System.Windows.Forms.Label();
            this.lblNbVisiteParDate = new System.Windows.Forms.Label();
            this.lblNbMedicamentDonnesParVisiteResult = new System.Windows.Forms.Label();
            this.lblNbMedicamentDonnesParVisite = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblTempsMoyenParVisiteResult = new System.Windows.Forms.Label();
            this.lblTempsMoyenDeVisite = new System.Windows.Forms.Label();
            this.lblNbVisiteParEleveResult = new System.Windows.Forms.Label();
            this.lblNbVisiteParEleve = new System.Windows.Forms.Label();
            this.lblNbMedicamentDonnesResult = new System.Windows.Forms.Label();
            this.lblNbMedicamentsDonnes = new System.Windows.Forms.Label();
            this.dtpFinVisite = new System.Windows.Forms.DateTimePicker();
            this.lblFinVisite = new System.Windows.Forms.Label();
            this.dtpDebutVisite = new System.Windows.Forms.DateTimePicker();
            this.lblDebutVisite = new System.Windows.Forms.Label();
            this.lblNbEleveTotal = new System.Windows.Forms.Label();
            this.lblResultNbVisites = new System.Windows.Forms.Label();
            this.pnlSeparator = new System.Windows.Forms.Panel();
            this.lblResultNbEleve = new System.Windows.Forms.Label();
            this.lblNbTotalVisites = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dtpGraphAnnee = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEleves)).BeginInit();
            this.msMenu.SuspendLayout();
            this.pnlModif.SuspendLayout();
            this.pnlEleves.SuspendLayout();
            this.pnlAjoutEleve.SuspendLayout();
            this.pnlMedicaments.SuspendLayout();
            this.pnlAjoutMedic.SuspendLayout();
            this.pnlMedicModif.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicaments)).BeginInit();
            this.pnlVisites.SuspendLayout();
            this.pnlModifVisite.SuspendLayout();
            this.pnlAjoutVisite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisites)).BeginInit();
            this.pnlStats.SuspendLayout();
            this.pnlGraphique.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Graphique)).BeginInit();
            this.pnlResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAccueil
            // 
            this.lblAccueil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAccueil.AutoSize = true;
            this.lblAccueil.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.lblAccueil.Location = new System.Drawing.Point(620, 9);
            this.lblAccueil.Name = "lblAccueil";
            this.lblAccueil.Size = new System.Drawing.Size(107, 41);
            this.lblAccueil.TabIndex = 0;
            this.lblAccueil.Text = "Élèves";
            // 
            // dgvEleves
            // 
            this.dgvEleves.AllowUserToOrderColumns = true;
            this.dgvEleves.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEleves.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEleves.BackgroundColor = System.Drawing.Color.White;
            this.dgvEleves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEleves.Location = new System.Drawing.Point(149, 70);
            this.dgvEleves.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEleves.Name = "dgvEleves";
            this.dgvEleves.ReadOnly = true;
            this.dgvEleves.RowHeadersWidth = 51;
            this.dgvEleves.RowTemplate.Height = 24;
            this.dgvEleves.Size = new System.Drawing.Size(1053, 298);
            this.dgvEleves.TabIndex = 1;
            this.dgvEleves.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvEleves.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnSupprimerEleve
            // 
            this.btnSupprimerEleve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprimerEleve.BackColor = System.Drawing.Color.IndianRed;
            this.btnSupprimerEleve.FlatAppearance.BorderSize = 0;
            this.btnSupprimerEleve.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnSupprimerEleve.Location = new System.Drawing.Point(853, 27);
            this.btnSupprimerEleve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSupprimerEleve.Name = "btnSupprimerEleve";
            this.btnSupprimerEleve.Size = new System.Drawing.Size(117, 30);
            this.btnSupprimerEleve.TabIndex = 2;
            this.btnSupprimerEleve.Text = "Supprimer";
            this.btnSupprimerEleve.UseVisualStyleBackColor = false;
            this.btnSupprimerEleve.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnConfirmereleve
            // 
            this.btnConfirmereleve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmereleve.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnConfirmereleve.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnConfirmereleve.Location = new System.Drawing.Point(976, 27);
            this.btnConfirmereleve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmereleve.Name = "btnConfirmereleve";
            this.btnConfirmereleve.Size = new System.Drawing.Size(129, 30);
            this.btnConfirmereleve.TabIndex = 3;
            this.btnConfirmereleve.Text = "Confirmer";
            this.btnConfirmereleve.UseVisualStyleBackColor = false;
            this.btnConfirmereleve.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAjoutEleve
            // 
            this.btnAjoutEleve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjoutEleve.BackColor = System.Drawing.Color.LightGreen;
            this.btnAjoutEleve.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnAjoutEleve.Location = new System.Drawing.Point(1111, 27);
            this.btnAjoutEleve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAjoutEleve.Name = "btnAjoutEleve";
            this.btnAjoutEleve.Size = new System.Drawing.Size(91, 30);
            this.btnAjoutEleve.TabIndex = 4;
            this.btnAjoutEleve.Text = "Ajouter";
            this.btnAjoutEleve.UseVisualStyleBackColor = false;
            this.btnAjoutEleve.Click += new System.EventHandler(this.button3_Click);
            // 
            // msMenu
            // 
            this.msMenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.msMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.msMenu.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visitesToolStripMenuItem,
            this.élèvesToolStripMenuItem,
            this.médicamentsToolStripMenuItem,
            this.statistiquesToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.msMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.msMenu.Size = new System.Drawing.Size(305, 807);
            this.msMenu.TabIndex = 5;
            this.msMenu.Text = "menuStrip1";
            // 
            // visitesToolStripMenuItem
            // 
            this.visitesToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("visitesToolStripMenuItem.Image")));
            this.visitesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.visitesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.visitesToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 45, 0, 0);
            this.visitesToolStripMenuItem.Name = "visitesToolStripMenuItem";
            this.visitesToolStripMenuItem.Size = new System.Drawing.Size(294, 53);
            this.visitesToolStripMenuItem.Text = "Visites";
            this.visitesToolStripMenuItem.Click += new System.EventHandler(this.visitesToolStripMenuItem_Click);
            // 
            // élèvesToolStripMenuItem
            // 
            this.élèvesToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.élèvesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("élèvesToolStripMenuItem.Image")));
            this.élèvesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.élèvesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.élèvesToolStripMenuItem.Name = "élèvesToolStripMenuItem";
            this.élèvesToolStripMenuItem.Size = new System.Drawing.Size(294, 53);
            this.élèvesToolStripMenuItem.Text = "Élèves";
            this.élèvesToolStripMenuItem.Click += new System.EventHandler(this.élèvesToolStripMenuItem_Click);
            // 
            // médicamentsToolStripMenuItem
            // 
            this.médicamentsToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.médicamentsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("médicamentsToolStripMenuItem.Image")));
            this.médicamentsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.médicamentsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.médicamentsToolStripMenuItem.Name = "médicamentsToolStripMenuItem";
            this.médicamentsToolStripMenuItem.Size = new System.Drawing.Size(294, 53);
            this.médicamentsToolStripMenuItem.Text = "Médicaments";
            this.médicamentsToolStripMenuItem.Click += new System.EventHandler(this.médicamentsToolStripMenuItem_Click);
            // 
            // statistiquesToolStripMenuItem
            // 
            this.statistiquesToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statistiquesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("statistiquesToolStripMenuItem.Image")));
            this.statistiquesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statistiquesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.statistiquesToolStripMenuItem.Name = "statistiquesToolStripMenuItem";
            this.statistiquesToolStripMenuItem.Size = new System.Drawing.Size(294, 53);
            this.statistiquesToolStripMenuItem.Text = "Statistiques";
            this.statistiquesToolStripMenuItem.Click += new System.EventHandler(this.statistiquesToolStripMenuItem_Click);
            // 
            // pnlModif
            // 
            this.pnlModif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlModif.Controls.Add(this.comboBox1);
            this.pnlModif.Controls.Add(this.lblComments);
            this.pnlModif.Controls.Add(this.txtComments);
            this.pnlModif.Controls.Add(this.chkExtraTime);
            this.pnlModif.Controls.Add(this.lblNumeroTelParentModif);
            this.pnlModif.Controls.Add(this.txtNumeroParent);
            this.pnlModif.Controls.Add(this.lblTelEleveModif);
            this.pnlModif.Controls.Add(this.txtNumeroEleve);
            this.pnlModif.Controls.Add(this.monthCalendar1);
            this.pnlModif.Controls.Add(this.lblBirthdate);
            this.pnlModif.Controls.Add(this.lblPRenomModif);
            this.pnlModif.Controls.Add(this.txtPrenomModif);
            this.pnlModif.Controls.Add(this.txtIdModif);
            this.pnlModif.Controls.Add(this.lblNomModif);
            this.pnlModif.Controls.Add(this.txtNomModif);
            this.pnlModif.Location = new System.Drawing.Point(149, 372);
            this.pnlModif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlModif.Name = "pnlModif";
            this.pnlModif.Size = new System.Drawing.Size(1053, 478);
            this.pnlModif.TabIndex = 6;
            this.pnlModif.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(411, 176);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 15;
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(591, 112);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(143, 17);
            this.lblComments.TabIndex = 14;
            this.lblComments.Text = "Commentaires Santé:";
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(740, 112);
            this.txtComments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtComments.MinimumSize = new System.Drawing.Size(4, 50);
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(151, 22);
            this.txtComments.TabIndex = 13;
            // 
            // chkExtraTime
            // 
            this.chkExtraTime.AutoSize = true;
            this.chkExtraTime.Location = new System.Drawing.Point(631, 42);
            this.chkExtraTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkExtraTime.Name = "chkExtraTime";
            this.chkExtraTime.Size = new System.Drawing.Size(103, 21);
            this.chkExtraTime.TabIndex = 12;
            this.chkExtraTime.Text = "Tier-Temps";
            this.chkExtraTime.UseVisualStyleBackColor = true;
            // 
            // lblNumeroTelParentModif
            // 
            this.lblNumeroTelParentModif.AutoSize = true;
            this.lblNumeroTelParentModif.Location = new System.Drawing.Point(259, 112);
            this.lblNumeroTelParentModif.Name = "lblNumeroTelParentModif";
            this.lblNumeroTelParentModif.Size = new System.Drawing.Size(147, 17);
            this.lblNumeroTelParentModif.TabIndex = 11;
            this.lblNumeroTelParentModif.Text = "Numero Parent Eleve:";
            // 
            // txtNumeroParent
            // 
            this.txtNumeroParent.Location = new System.Drawing.Point(411, 110);
            this.txtNumeroParent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumeroParent.Name = "txtNumeroParent";
            this.txtNumeroParent.Size = new System.Drawing.Size(141, 22);
            this.txtNumeroParent.TabIndex = 10;
            // 
            // lblTelEleveModif
            // 
            this.lblTelEleveModif.AutoSize = true;
            this.lblTelEleveModif.Location = new System.Drawing.Point(304, 55);
            this.lblTelEleveModif.Name = "lblTelEleveModif";
            this.lblTelEleveModif.Size = new System.Drawing.Size(101, 17);
            this.lblTelEleveModif.TabIndex = 9;
            this.lblTelEleveModif.Text = "Numero Eleve:";
            // 
            // txtNumeroEleve
            // 
            this.txtNumeroEleve.Location = new System.Drawing.Point(411, 52);
            this.txtNumeroEleve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumeroEleve.Name = "txtNumeroEleve";
            this.txtNumeroEleve.Size = new System.Drawing.Size(141, 22);
            this.txtNumeroEleve.TabIndex = 8;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(5, 191);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Location = new System.Drawing.Point(3, 165);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(130, 17);
            this.lblBirthdate.TabIndex = 6;
            this.lblBirthdate.Text = "Date de naissance:";
            // 
            // lblPRenomModif
            // 
            this.lblPRenomModif.AutoSize = true;
            this.lblPRenomModif.Location = new System.Drawing.Point(3, 110);
            this.lblPRenomModif.Name = "lblPRenomModif";
            this.lblPRenomModif.Size = new System.Drawing.Size(57, 17);
            this.lblPRenomModif.TabIndex = 4;
            this.lblPRenomModif.Text = "Prenom";
            // 
            // txtPrenomModif
            // 
            this.txtPrenomModif.Location = new System.Drawing.Point(67, 110);
            this.txtPrenomModif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrenomModif.Name = "txtPrenomModif";
            this.txtPrenomModif.Size = new System.Drawing.Size(141, 22);
            this.txtPrenomModif.TabIndex = 3;
            // 
            // txtIdModif
            // 
            this.txtIdModif.Location = new System.Drawing.Point(0, 2);
            this.txtIdModif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdModif.Name = "txtIdModif";
            this.txtIdModif.Size = new System.Drawing.Size(100, 22);
            this.txtIdModif.TabIndex = 2;
            this.txtIdModif.Visible = false;
            // 
            // lblNomModif
            // 
            this.lblNomModif.AutoSize = true;
            this.lblNomModif.Location = new System.Drawing.Point(3, 55);
            this.lblNomModif.Name = "lblNomModif";
            this.lblNomModif.Size = new System.Drawing.Size(41, 17);
            this.lblNomModif.TabIndex = 1;
            this.lblNomModif.Text = "Nom:";
            // 
            // txtNomModif
            // 
            this.txtNomModif.Location = new System.Drawing.Point(67, 55);
            this.txtNomModif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomModif.Name = "txtNomModif";
            this.txtNomModif.Size = new System.Drawing.Size(141, 22);
            this.txtNomModif.TabIndex = 0;
            // 
            // pnlEleves
            // 
            this.pnlEleves.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEleves.Controls.Add(this.pnlAjoutEleve);
            this.pnlEleves.Controls.Add(this.lblAccueil);
            this.pnlEleves.Controls.Add(this.pnlModif);
            this.pnlEleves.Controls.Add(this.btnAjoutEleve);
            this.pnlEleves.Controls.Add(this.dgvEleves);
            this.pnlEleves.Controls.Add(this.btnSupprimerEleve);
            this.pnlEleves.Controls.Add(this.btnConfirmereleve);
            this.pnlEleves.Location = new System.Drawing.Point(320, 27);
            this.pnlEleves.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlEleves.Name = "pnlEleves";
            this.pnlEleves.Size = new System.Drawing.Size(1379, 780);
            this.pnlEleves.TabIndex = 7;
            // 
            // pnlAjoutEleve
            // 
            this.pnlAjoutEleve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAjoutEleve.Controls.Add(this.cboxClasseEleveAjout);
            this.pnlAjoutEleve.Controls.Add(this.lblCommentaireEleveAjout);
            this.pnlAjoutEleve.Controls.Add(this.txtCommentaireEleveAjout);
            this.pnlAjoutEleve.Controls.Add(this.chkExtraTimeEleveAjout);
            this.pnlAjoutEleve.Controls.Add(this.lblNumeroParentEleveAjout);
            this.pnlAjoutEleve.Controls.Add(this.txtNumeroParentEleveAjout);
            this.pnlAjoutEleve.Controls.Add(this.lblNumeroEleveAjout);
            this.pnlAjoutEleve.Controls.Add(this.txtNumeroEleveAjout);
            this.pnlAjoutEleve.Controls.Add(this.mcBirthdateEleveAjout);
            this.pnlAjoutEleve.Controls.Add(this.lblBirthdateEleveAjout);
            this.pnlAjoutEleve.Controls.Add(this.lblPrenomEleveAjout);
            this.pnlAjoutEleve.Controls.Add(this.txtPrenomEleveAjout);
            this.pnlAjoutEleve.Controls.Add(this.txtIdEleveAjout);
            this.pnlAjoutEleve.Controls.Add(this.lblNomEleveAjout);
            this.pnlAjoutEleve.Controls.Add(this.txtNomEleveAjout);
            this.pnlAjoutEleve.Location = new System.Drawing.Point(149, 374);
            this.pnlAjoutEleve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlAjoutEleve.Name = "pnlAjoutEleve";
            this.pnlAjoutEleve.Size = new System.Drawing.Size(1053, 478);
            this.pnlAjoutEleve.TabIndex = 16;
            this.pnlAjoutEleve.Visible = false;
            // 
            // cboxClasseEleveAjout
            // 
            this.cboxClasseEleveAjout.FormattingEnabled = true;
            this.cboxClasseEleveAjout.Location = new System.Drawing.Point(411, 176);
            this.cboxClasseEleveAjout.Margin = new System.Windows.Forms.Padding(4);
            this.cboxClasseEleveAjout.Name = "cboxClasseEleveAjout";
            this.cboxClasseEleveAjout.Size = new System.Drawing.Size(160, 24);
            this.cboxClasseEleveAjout.TabIndex = 15;
            this.cboxClasseEleveAjout.Visible = false;
            // 
            // lblCommentaireEleveAjout
            // 
            this.lblCommentaireEleveAjout.AutoSize = true;
            this.lblCommentaireEleveAjout.Location = new System.Drawing.Point(591, 112);
            this.lblCommentaireEleveAjout.Name = "lblCommentaireEleveAjout";
            this.lblCommentaireEleveAjout.Size = new System.Drawing.Size(143, 17);
            this.lblCommentaireEleveAjout.TabIndex = 14;
            this.lblCommentaireEleveAjout.Text = "Commentaires Santé:";
            // 
            // txtCommentaireEleveAjout
            // 
            this.txtCommentaireEleveAjout.Location = new System.Drawing.Point(740, 112);
            this.txtCommentaireEleveAjout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCommentaireEleveAjout.MinimumSize = new System.Drawing.Size(4, 50);
            this.txtCommentaireEleveAjout.Name = "txtCommentaireEleveAjout";
            this.txtCommentaireEleveAjout.Size = new System.Drawing.Size(151, 22);
            this.txtCommentaireEleveAjout.TabIndex = 13;
            // 
            // chkExtraTimeEleveAjout
            // 
            this.chkExtraTimeEleveAjout.AutoSize = true;
            this.chkExtraTimeEleveAjout.Location = new System.Drawing.Point(631, 42);
            this.chkExtraTimeEleveAjout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkExtraTimeEleveAjout.Name = "chkExtraTimeEleveAjout";
            this.chkExtraTimeEleveAjout.Size = new System.Drawing.Size(103, 21);
            this.chkExtraTimeEleveAjout.TabIndex = 12;
            this.chkExtraTimeEleveAjout.Text = "Tier-Temps";
            this.chkExtraTimeEleveAjout.UseVisualStyleBackColor = true;
            // 
            // lblNumeroParentEleveAjout
            // 
            this.lblNumeroParentEleveAjout.AutoSize = true;
            this.lblNumeroParentEleveAjout.Location = new System.Drawing.Point(259, 112);
            this.lblNumeroParentEleveAjout.Name = "lblNumeroParentEleveAjout";
            this.lblNumeroParentEleveAjout.Size = new System.Drawing.Size(147, 17);
            this.lblNumeroParentEleveAjout.TabIndex = 11;
            this.lblNumeroParentEleveAjout.Text = "Numero Parent Eleve:";
            // 
            // txtNumeroParentEleveAjout
            // 
            this.txtNumeroParentEleveAjout.Location = new System.Drawing.Point(411, 110);
            this.txtNumeroParentEleveAjout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumeroParentEleveAjout.Name = "txtNumeroParentEleveAjout";
            this.txtNumeroParentEleveAjout.Size = new System.Drawing.Size(141, 22);
            this.txtNumeroParentEleveAjout.TabIndex = 10;
            // 
            // lblNumeroEleveAjout
            // 
            this.lblNumeroEleveAjout.AutoSize = true;
            this.lblNumeroEleveAjout.Location = new System.Drawing.Point(304, 55);
            this.lblNumeroEleveAjout.Name = "lblNumeroEleveAjout";
            this.lblNumeroEleveAjout.Size = new System.Drawing.Size(101, 17);
            this.lblNumeroEleveAjout.TabIndex = 9;
            this.lblNumeroEleveAjout.Text = "Numero Eleve:";
            // 
            // txtNumeroEleveAjout
            // 
            this.txtNumeroEleveAjout.Location = new System.Drawing.Point(411, 52);
            this.txtNumeroEleveAjout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumeroEleveAjout.Name = "txtNumeroEleveAjout";
            this.txtNumeroEleveAjout.Size = new System.Drawing.Size(141, 22);
            this.txtNumeroEleveAjout.TabIndex = 8;
            // 
            // mcBirthdateEleveAjout
            // 
            this.mcBirthdateEleveAjout.Location = new System.Drawing.Point(5, 191);
            this.mcBirthdateEleveAjout.MaxSelectionCount = 1;
            this.mcBirthdateEleveAjout.Name = "mcBirthdateEleveAjout";
            this.mcBirthdateEleveAjout.TabIndex = 7;
            // 
            // lblBirthdateEleveAjout
            // 
            this.lblBirthdateEleveAjout.AutoSize = true;
            this.lblBirthdateEleveAjout.Location = new System.Drawing.Point(3, 165);
            this.lblBirthdateEleveAjout.Name = "lblBirthdateEleveAjout";
            this.lblBirthdateEleveAjout.Size = new System.Drawing.Size(130, 17);
            this.lblBirthdateEleveAjout.TabIndex = 6;
            this.lblBirthdateEleveAjout.Text = "Date de naissance:";
            // 
            // lblPrenomEleveAjout
            // 
            this.lblPrenomEleveAjout.AutoSize = true;
            this.lblPrenomEleveAjout.Location = new System.Drawing.Point(3, 110);
            this.lblPrenomEleveAjout.Name = "lblPrenomEleveAjout";
            this.lblPrenomEleveAjout.Size = new System.Drawing.Size(57, 17);
            this.lblPrenomEleveAjout.TabIndex = 4;
            this.lblPrenomEleveAjout.Text = "Prenom";
            // 
            // txtPrenomEleveAjout
            // 
            this.txtPrenomEleveAjout.Location = new System.Drawing.Point(67, 110);
            this.txtPrenomEleveAjout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrenomEleveAjout.Name = "txtPrenomEleveAjout";
            this.txtPrenomEleveAjout.Size = new System.Drawing.Size(141, 22);
            this.txtPrenomEleveAjout.TabIndex = 3;
            // 
            // txtIdEleveAjout
            // 
            this.txtIdEleveAjout.Location = new System.Drawing.Point(0, 2);
            this.txtIdEleveAjout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdEleveAjout.Name = "txtIdEleveAjout";
            this.txtIdEleveAjout.Size = new System.Drawing.Size(100, 22);
            this.txtIdEleveAjout.TabIndex = 2;
            this.txtIdEleveAjout.Visible = false;
            // 
            // lblNomEleveAjout
            // 
            this.lblNomEleveAjout.AutoSize = true;
            this.lblNomEleveAjout.Location = new System.Drawing.Point(3, 55);
            this.lblNomEleveAjout.Name = "lblNomEleveAjout";
            this.lblNomEleveAjout.Size = new System.Drawing.Size(41, 17);
            this.lblNomEleveAjout.TabIndex = 1;
            this.lblNomEleveAjout.Text = "Nom:";
            // 
            // txtNomEleveAjout
            // 
            this.txtNomEleveAjout.Location = new System.Drawing.Point(67, 55);
            this.txtNomEleveAjout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomEleveAjout.Name = "txtNomEleveAjout";
            this.txtNomEleveAjout.Size = new System.Drawing.Size(141, 22);
            this.txtNomEleveAjout.TabIndex = 0;
            // 
            // pnlMedicaments
            // 
            this.pnlMedicaments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMedicaments.Controls.Add(this.lblMedicaments);
            this.pnlMedicaments.Controls.Add(this.pnlAjoutMedic);
            this.pnlMedicaments.Controls.Add(this.pnlMedicModif);
            this.pnlMedicaments.Controls.Add(this.btnAjoutMEdic);
            this.pnlMedicaments.Controls.Add(this.dgvMedicaments);
            this.pnlMedicaments.Controls.Add(this.btnSupprimerMedic);
            this.pnlMedicaments.Controls.Add(this.btnConfirmerMedic);
            this.pnlMedicaments.Location = new System.Drawing.Point(320, 42);
            this.pnlMedicaments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMedicaments.Name = "pnlMedicaments";
            this.pnlMedicaments.Size = new System.Drawing.Size(1371, 1038);
            this.pnlMedicaments.TabIndex = 8;
            this.pnlMedicaments.Visible = false;
            // 
            // lblMedicaments
            // 
            this.lblMedicaments.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMedicaments.AutoSize = true;
            this.lblMedicaments.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.lblMedicaments.Location = new System.Drawing.Point(563, 16);
            this.lblMedicaments.Name = "lblMedicaments";
            this.lblMedicaments.Size = new System.Drawing.Size(211, 41);
            this.lblMedicaments.TabIndex = 0;
            this.lblMedicaments.Text = "Médicaments";
            // 
            // pnlAjoutMedic
            // 
            this.pnlAjoutMedic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAjoutMedic.Controls.Add(this.lblAjoutMedic);
            this.pnlAjoutMedic.Controls.Add(this.txtIdMedicAjout);
            this.pnlAjoutMedic.Controls.Add(this.lblNomMedicAjout);
            this.pnlAjoutMedic.Controls.Add(this.txtNomMedicAjout);
            this.pnlAjoutMedic.Location = new System.Drawing.Point(152, 372);
            this.pnlAjoutMedic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlAjoutMedic.Name = "pnlAjoutMedic";
            this.pnlAjoutMedic.Size = new System.Drawing.Size(1043, 480);
            this.pnlAjoutMedic.TabIndex = 7;
            this.pnlAjoutMedic.Visible = false;
            // 
            // lblAjoutMedic
            // 
            this.lblAjoutMedic.AutoSize = true;
            this.lblAjoutMedic.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjoutMedic.Location = new System.Drawing.Point(3, 0);
            this.lblAjoutMedic.Name = "lblAjoutMedic";
            this.lblAjoutMedic.Size = new System.Drawing.Size(292, 35);
            this.lblAjoutMedic.TabIndex = 3;
            this.lblAjoutMedic.Text = "Ajouter un médicament";
            // 
            // txtIdMedicAjout
            // 
            this.txtIdMedicAjout.Location = new System.Drawing.Point(0, 2);
            this.txtIdMedicAjout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdMedicAjout.Name = "txtIdMedicAjout";
            this.txtIdMedicAjout.Size = new System.Drawing.Size(100, 22);
            this.txtIdMedicAjout.TabIndex = 2;
            this.txtIdMedicAjout.Visible = false;
            // 
            // lblNomMedicAjout
            // 
            this.lblNomMedicAjout.AutoSize = true;
            this.lblNomMedicAjout.Location = new System.Drawing.Point(20, 53);
            this.lblNomMedicAjout.Name = "lblNomMedicAjout";
            this.lblNomMedicAjout.Size = new System.Drawing.Size(41, 17);
            this.lblNomMedicAjout.TabIndex = 1;
            this.lblNomMedicAjout.Text = "Nom:";
            // 
            // txtNomMedicAjout
            // 
            this.txtNomMedicAjout.Location = new System.Drawing.Point(80, 50);
            this.txtNomMedicAjout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomMedicAjout.Name = "txtNomMedicAjout";
            this.txtNomMedicAjout.Size = new System.Drawing.Size(141, 22);
            this.txtNomMedicAjout.TabIndex = 0;
            // 
            // pnlMedicModif
            // 
            this.pnlMedicModif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMedicModif.Controls.Add(this.lblModifMedic);
            this.pnlMedicModif.Controls.Add(this.txtIdMedicModif);
            this.pnlMedicModif.Controls.Add(this.lblNomMedicModif);
            this.pnlMedicModif.Controls.Add(this.txtNomMedicModif);
            this.pnlMedicModif.Location = new System.Drawing.Point(149, 374);
            this.pnlMedicModif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMedicModif.Name = "pnlMedicModif";
            this.pnlMedicModif.Size = new System.Drawing.Size(1048, 480);
            this.pnlMedicModif.TabIndex = 6;
            this.pnlMedicModif.Visible = false;
            // 
            // lblModifMedic
            // 
            this.lblModifMedic.AutoSize = true;
            this.lblModifMedic.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifMedic.Location = new System.Drawing.Point(0, 2);
            this.lblModifMedic.Name = "lblModifMedic";
            this.lblModifMedic.Size = new System.Drawing.Size(305, 35);
            this.lblModifMedic.TabIndex = 8;
            this.lblModifMedic.Text = "Modifier un médicament";
            // 
            // txtIdMedicModif
            // 
            this.txtIdMedicModif.Location = new System.Drawing.Point(0, 2);
            this.txtIdMedicModif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdMedicModif.Name = "txtIdMedicModif";
            this.txtIdMedicModif.Size = new System.Drawing.Size(100, 22);
            this.txtIdMedicModif.TabIndex = 2;
            this.txtIdMedicModif.Visible = false;
            // 
            // lblNomMedicModif
            // 
            this.lblNomMedicModif.AutoSize = true;
            this.lblNomMedicModif.Location = new System.Drawing.Point(20, 53);
            this.lblNomMedicModif.Name = "lblNomMedicModif";
            this.lblNomMedicModif.Size = new System.Drawing.Size(41, 17);
            this.lblNomMedicModif.TabIndex = 1;
            this.lblNomMedicModif.Text = "Nom:";
            // 
            // txtNomMedicModif
            // 
            this.txtNomMedicModif.Location = new System.Drawing.Point(80, 50);
            this.txtNomMedicModif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomMedicModif.Name = "txtNomMedicModif";
            this.txtNomMedicModif.Size = new System.Drawing.Size(141, 22);
            this.txtNomMedicModif.TabIndex = 0;
            // 
            // btnAjoutMEdic
            // 
            this.btnAjoutMEdic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjoutMEdic.BackColor = System.Drawing.Color.LightGreen;
            this.btnAjoutMEdic.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnAjoutMEdic.Location = new System.Drawing.Point(1103, 27);
            this.btnAjoutMEdic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAjoutMEdic.Name = "btnAjoutMEdic";
            this.btnAjoutMEdic.Size = new System.Drawing.Size(91, 30);
            this.btnAjoutMEdic.TabIndex = 4;
            this.btnAjoutMEdic.Text = "Ajouter";
            this.btnAjoutMEdic.UseVisualStyleBackColor = false;
            this.btnAjoutMEdic.Click += new System.EventHandler(this.btnAjoutMEdic_Click);
            // 
            // dgvMedicaments
            // 
            this.dgvMedicaments.AllowUserToOrderColumns = true;
            this.dgvMedicaments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMedicaments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicaments.BackgroundColor = System.Drawing.Color.White;
            this.dgvMedicaments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicaments.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvMedicaments.Location = new System.Drawing.Point(149, 71);
            this.dgvMedicaments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMedicaments.Name = "dgvMedicaments";
            this.dgvMedicaments.ReadOnly = true;
            this.dgvMedicaments.RowHeadersWidth = 51;
            this.dgvMedicaments.RowTemplate.Height = 24;
            this.dgvMedicaments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicaments.Size = new System.Drawing.Size(1045, 300);
            this.dgvMedicaments.TabIndex = 1;
            this.dgvMedicaments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicaments_CellClick);
            // 
            // btnSupprimerMedic
            // 
            this.btnSupprimerMedic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprimerMedic.BackColor = System.Drawing.Color.IndianRed;
            this.btnSupprimerMedic.FlatAppearance.BorderSize = 0;
            this.btnSupprimerMedic.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnSupprimerMedic.Location = new System.Drawing.Point(845, 27);
            this.btnSupprimerMedic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSupprimerMedic.Name = "btnSupprimerMedic";
            this.btnSupprimerMedic.Size = new System.Drawing.Size(117, 30);
            this.btnSupprimerMedic.TabIndex = 2;
            this.btnSupprimerMedic.Text = "Supprimer";
            this.btnSupprimerMedic.UseVisualStyleBackColor = false;
            this.btnSupprimerMedic.Click += new System.EventHandler(this.btnSupprimerMedic_Click);
            // 
            // btnConfirmerMedic
            // 
            this.btnConfirmerMedic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmerMedic.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnConfirmerMedic.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnConfirmerMedic.Location = new System.Drawing.Point(968, 27);
            this.btnConfirmerMedic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmerMedic.Name = "btnConfirmerMedic";
            this.btnConfirmerMedic.Size = new System.Drawing.Size(129, 30);
            this.btnConfirmerMedic.TabIndex = 3;
            this.btnConfirmerMedic.Text = "Confirmer";
            this.btnConfirmerMedic.UseVisualStyleBackColor = false;
            this.btnConfirmerMedic.Click += new System.EventHandler(this.btnConfirmerMedic_Click);
            // 
            // pnlVisites
            // 
            this.pnlVisites.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlVisites.Controls.Add(this.pnlModifVisite);
            this.pnlVisites.Controls.Add(this.pnlAjoutVisite);
            this.pnlVisites.Controls.Add(this.lblVisites);
            this.pnlVisites.Controls.Add(this.btnAjouterVisite);
            this.pnlVisites.Controls.Add(this.dgvVisites);
            this.pnlVisites.Controls.Add(this.btnSupprimerVisite);
            this.pnlVisites.Controls.Add(this.btnConfirmerVisite);
            this.pnlVisites.Location = new System.Drawing.Point(320, 11);
            this.pnlVisites.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlVisites.Name = "pnlVisites";
            this.pnlVisites.Size = new System.Drawing.Size(1379, 780);
            this.pnlVisites.TabIndex = 17;
            // 
            // pnlModifVisite
            // 
            this.pnlModifVisite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlModifVisite.Controls.Add(this.txtModifIdVisite);
            this.pnlModifVisite.Controls.Add(this.lblModifEleveVisite);
            this.pnlModifVisite.Controls.Add(this.cbModifEleveVisite);
            this.pnlModifVisite.Controls.Add(this.lblModifMedicamentVisite);
            this.pnlModifVisite.Controls.Add(this.dtpModifDateFinVisite);
            this.pnlModifVisite.Controls.Add(this.lblModifDateFinVisite);
            this.pnlModifVisite.Controls.Add(this.dtpModifDateDebutVisite);
            this.pnlModifVisite.Controls.Add(this.chkbModifParentsPrevenusVisite);
            this.pnlModifVisite.Controls.Add(this.chkbModifHospitalisationVisite);
            this.pnlModifVisite.Controls.Add(this.cbModifMedicamentVisite);
            this.pnlModifVisite.Controls.Add(this.txtModifCommentaireVisite);
            this.pnlModifVisite.Controls.Add(this.chkbModifRenvoiDomicileVisite);
            this.pnlModifVisite.Controls.Add(this.lblModifQuantiteMedicamentVisite);
            this.pnlModifVisite.Controls.Add(this.txtModifQuantiteMedicamentVisite);
            this.pnlModifVisite.Controls.Add(this.lblModifCommentaireVisite);
            this.pnlModifVisite.Controls.Add(this.lblModifDateDebutVisite);
            this.pnlModifVisite.Controls.Add(this.lblModifMotifVisite);
            this.pnlModifVisite.Controls.Add(this.txtModifMotifVisite);
            this.pnlModifVisite.Location = new System.Drawing.Point(149, 420);
            this.pnlModifVisite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlModifVisite.Name = "pnlModifVisite";
            this.pnlModifVisite.Size = new System.Drawing.Size(1053, 478);
            this.pnlModifVisite.TabIndex = 22;
            this.pnlModifVisite.Visible = false;
            // 
            // txtModifIdVisite
            // 
            this.txtModifIdVisite.Location = new System.Drawing.Point(23, 9);
            this.txtModifIdVisite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModifIdVisite.Name = "txtModifIdVisite";
            this.txtModifIdVisite.Size = new System.Drawing.Size(141, 22);
            this.txtModifIdVisite.TabIndex = 24;
            this.txtModifIdVisite.Visible = false;
            // 
            // lblModifEleveVisite
            // 
            this.lblModifEleveVisite.AutoSize = true;
            this.lblModifEleveVisite.Location = new System.Drawing.Point(19, 49);
            this.lblModifEleveVisite.Name = "lblModifEleveVisite";
            this.lblModifEleveVisite.Size = new System.Drawing.Size(51, 17);
            this.lblModifEleveVisite.TabIndex = 23;
            this.lblModifEleveVisite.Text = "Eleve :";
            // 
            // cbModifEleveVisite
            // 
            this.cbModifEleveVisite.FormattingEnabled = true;
            this.cbModifEleveVisite.Location = new System.Drawing.Point(79, 44);
            this.cbModifEleveVisite.Margin = new System.Windows.Forms.Padding(4);
            this.cbModifEleveVisite.Name = "cbModifEleveVisite";
            this.cbModifEleveVisite.Size = new System.Drawing.Size(248, 24);
            this.cbModifEleveVisite.TabIndex = 22;
            // 
            // lblModifMedicamentVisite
            // 
            this.lblModifMedicamentVisite.AutoSize = true;
            this.lblModifMedicamentVisite.Location = new System.Drawing.Point(373, 316);
            this.lblModifMedicamentVisite.Name = "lblModifMedicamentVisite";
            this.lblModifMedicamentVisite.Size = new System.Drawing.Size(96, 17);
            this.lblModifMedicamentVisite.TabIndex = 21;
            this.lblModifMedicamentVisite.Text = "Medicament ?";
            // 
            // dtpModifDateFinVisite
            // 
            this.dtpModifDateFinVisite.CustomFormat = "dd MMMM, yyyy  |  HH:mm";
            this.dtpModifDateFinVisite.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpModifDateFinVisite.Location = new System.Drawing.Point(661, 69);
            this.dtpModifDateFinVisite.Margin = new System.Windows.Forms.Padding(4);
            this.dtpModifDateFinVisite.Name = "dtpModifDateFinVisite";
            this.dtpModifDateFinVisite.Size = new System.Drawing.Size(265, 22);
            this.dtpModifDateFinVisite.TabIndex = 20;
            // 
            // lblModifDateFinVisite
            // 
            this.lblModifDateFinVisite.AutoSize = true;
            this.lblModifDateFinVisite.Location = new System.Drawing.Point(657, 39);
            this.lblModifDateFinVisite.Name = "lblModifDateFinVisite";
            this.lblModifDateFinVisite.Size = new System.Drawing.Size(171, 17);
            this.lblModifDateFinVisite.TabIndex = 19;
            this.lblModifDateFinVisite.Text = "Heure / Jour début visite :";
            // 
            // dtpModifDateDebutVisite
            // 
            this.dtpModifDateDebutVisite.CustomFormat = "dd MMMM, yyyy  |  HH:mm";
            this.dtpModifDateDebutVisite.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpModifDateDebutVisite.Location = new System.Drawing.Point(363, 68);
            this.dtpModifDateDebutVisite.Margin = new System.Windows.Forms.Padding(4);
            this.dtpModifDateDebutVisite.Name = "dtpModifDateDebutVisite";
            this.dtpModifDateDebutVisite.Size = new System.Drawing.Size(265, 22);
            this.dtpModifDateDebutVisite.TabIndex = 18;
            // 
            // chkbModifParentsPrevenusVisite
            // 
            this.chkbModifParentsPrevenusVisite.AutoSize = true;
            this.chkbModifParentsPrevenusVisite.Location = new System.Drawing.Point(703, 252);
            this.chkbModifParentsPrevenusVisite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkbModifParentsPrevenusVisite.Name = "chkbModifParentsPrevenusVisite";
            this.chkbModifParentsPrevenusVisite.Size = new System.Drawing.Size(155, 21);
            this.chkbModifParentsPrevenusVisite.TabIndex = 17;
            this.chkbModifParentsPrevenusVisite.Text = "Parents Prevenus ?";
            this.chkbModifParentsPrevenusVisite.UseVisualStyleBackColor = true;
            // 
            // chkbModifHospitalisationVisite
            // 
            this.chkbModifHospitalisationVisite.AutoSize = true;
            this.chkbModifHospitalisationVisite.Location = new System.Drawing.Point(377, 252);
            this.chkbModifHospitalisationVisite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkbModifHospitalisationVisite.Name = "chkbModifHospitalisationVisite";
            this.chkbModifHospitalisationVisite.Size = new System.Drawing.Size(134, 21);
            this.chkbModifHospitalisationVisite.TabIndex = 16;
            this.chkbModifHospitalisationVisite.Text = "Hospitalisation ?";
            this.chkbModifHospitalisationVisite.UseVisualStyleBackColor = true;
            // 
            // cbModifMedicamentVisite
            // 
            this.cbModifMedicamentVisite.FormattingEnabled = true;
            this.cbModifMedicamentVisite.Location = new System.Drawing.Point(487, 311);
            this.cbModifMedicamentVisite.Margin = new System.Windows.Forms.Padding(4);
            this.cbModifMedicamentVisite.Name = "cbModifMedicamentVisite";
            this.cbModifMedicamentVisite.Size = new System.Drawing.Size(141, 24);
            this.cbModifMedicamentVisite.TabIndex = 15;
            // 
            // txtModifCommentaireVisite
            // 
            this.txtModifCommentaireVisite.Location = new System.Drawing.Point(709, 156);
            this.txtModifCommentaireVisite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModifCommentaireVisite.MinimumSize = new System.Drawing.Size(4, 50);
            this.txtModifCommentaireVisite.Name = "txtModifCommentaireVisite";
            this.txtModifCommentaireVisite.Size = new System.Drawing.Size(151, 22);
            this.txtModifCommentaireVisite.TabIndex = 13;
            // 
            // chkbModifRenvoiDomicileVisite
            // 
            this.chkbModifRenvoiDomicileVisite.AutoSize = true;
            this.chkbModifRenvoiDomicileVisite.Location = new System.Drawing.Point(536, 252);
            this.chkbModifRenvoiDomicileVisite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkbModifRenvoiDomicileVisite.Name = "chkbModifRenvoiDomicileVisite";
            this.chkbModifRenvoiDomicileVisite.Size = new System.Drawing.Size(143, 21);
            this.chkbModifRenvoiDomicileVisite.TabIndex = 12;
            this.chkbModifRenvoiDomicileVisite.Text = "Renvoi Domicile ?";
            this.chkbModifRenvoiDomicileVisite.UseVisualStyleBackColor = true;
            // 
            // lblModifQuantiteMedicamentVisite
            // 
            this.lblModifQuantiteMedicamentVisite.AutoSize = true;
            this.lblModifQuantiteMedicamentVisite.Location = new System.Drawing.Point(675, 315);
            this.lblModifQuantiteMedicamentVisite.Name = "lblModifQuantiteMedicamentVisite";
            this.lblModifQuantiteMedicamentVisite.Size = new System.Drawing.Size(154, 17);
            this.lblModifQuantiteMedicamentVisite.TabIndex = 11;
            this.lblModifQuantiteMedicamentVisite.Text = "Quantité Medicament ?";
            // 
            // txtModifQuantiteMedicamentVisite
            // 
            this.txtModifQuantiteMedicamentVisite.Location = new System.Drawing.Point(836, 311);
            this.txtModifQuantiteMedicamentVisite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModifQuantiteMedicamentVisite.Name = "txtModifQuantiteMedicamentVisite";
            this.txtModifQuantiteMedicamentVisite.Size = new System.Drawing.Size(141, 22);
            this.txtModifQuantiteMedicamentVisite.TabIndex = 10;
            // 
            // lblModifCommentaireVisite
            // 
            this.lblModifCommentaireVisite.AutoSize = true;
            this.lblModifCommentaireVisite.Location = new System.Drawing.Point(605, 160);
            this.lblModifCommentaireVisite.Name = "lblModifCommentaireVisite";
            this.lblModifCommentaireVisite.Size = new System.Drawing.Size(99, 17);
            this.lblModifCommentaireVisite.TabIndex = 9;
            this.lblModifCommentaireVisite.Text = "Commentaire :";
            // 
            // lblModifDateDebutVisite
            // 
            this.lblModifDateDebutVisite.AutoSize = true;
            this.lblModifDateDebutVisite.Location = new System.Drawing.Point(359, 38);
            this.lblModifDateDebutVisite.Name = "lblModifDateDebutVisite";
            this.lblModifDateDebutVisite.Size = new System.Drawing.Size(171, 17);
            this.lblModifDateDebutVisite.TabIndex = 6;
            this.lblModifDateDebutVisite.Text = "Heure / Jour début visite :";
            // 
            // lblModifMotifVisite
            // 
            this.lblModifMotifVisite.AutoSize = true;
            this.lblModifMotifVisite.Location = new System.Drawing.Point(363, 160);
            this.lblModifMotifVisite.Name = "lblModifMotifVisite";
            this.lblModifMotifVisite.Size = new System.Drawing.Size(46, 17);
            this.lblModifMotifVisite.TabIndex = 1;
            this.lblModifMotifVisite.Text = "Motif :";
            // 
            // txtModifMotifVisite
            // 
            this.txtModifMotifVisite.Location = new System.Drawing.Point(416, 154);
            this.txtModifMotifVisite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModifMotifVisite.Name = "txtModifMotifVisite";
            this.txtModifMotifVisite.Size = new System.Drawing.Size(141, 22);
            this.txtModifMotifVisite.TabIndex = 0;
            // 
            // pnlAjoutVisite
            // 
            this.pnlAjoutVisite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAjoutVisite.Controls.Add(this.lblAjoutEleveVisite);
            this.pnlAjoutVisite.Controls.Add(this.cbAjoutEleveVisite);
            this.pnlAjoutVisite.Controls.Add(this.lblAjoutMedicamentVisite);
            this.pnlAjoutVisite.Controls.Add(this.dtpAjoutDateFinVisite);
            this.pnlAjoutVisite.Controls.Add(this.lblAjoutDateFinVisite);
            this.pnlAjoutVisite.Controls.Add(this.dtpAjoutDateDebutVisite);
            this.pnlAjoutVisite.Controls.Add(this.chkbAjoutParentsPrevenusVisite);
            this.pnlAjoutVisite.Controls.Add(this.chkbAjoutHospitalisationVisite);
            this.pnlAjoutVisite.Controls.Add(this.cbAjoutMedicamentVisite);
            this.pnlAjoutVisite.Controls.Add(this.txtAjoutCommentaireVisite);
            this.pnlAjoutVisite.Controls.Add(this.chkbAjoutRenvoiDomicileVisite);
            this.pnlAjoutVisite.Controls.Add(this.lblAjoutQuantiteMedicamentVisite);
            this.pnlAjoutVisite.Controls.Add(this.txtAjoutQuantiteMedicamentVisite);
            this.pnlAjoutVisite.Controls.Add(this.lblAjoutCommentaireVisite);
            this.pnlAjoutVisite.Controls.Add(this.lblAjoutDateDebutVisite);
            this.pnlAjoutVisite.Controls.Add(this.lblAjoutMotifVisite);
            this.pnlAjoutVisite.Controls.Add(this.txtAjoutMotifVisite);
            this.pnlAjoutVisite.Location = new System.Drawing.Point(135, 405);
            this.pnlAjoutVisite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlAjoutVisite.Name = "pnlAjoutVisite";
            this.pnlAjoutVisite.Size = new System.Drawing.Size(1053, 478);
            this.pnlAjoutVisite.TabIndex = 16;
            this.pnlAjoutVisite.Visible = false;
            // 
            // lblAjoutEleveVisite
            // 
            this.lblAjoutEleveVisite.AutoSize = true;
            this.lblAjoutEleveVisite.Location = new System.Drawing.Point(48, 58);
            this.lblAjoutEleveVisite.Name = "lblAjoutEleveVisite";
            this.lblAjoutEleveVisite.Size = new System.Drawing.Size(51, 17);
            this.lblAjoutEleveVisite.TabIndex = 25;
            this.lblAjoutEleveVisite.Text = "Eleve :";
            // 
            // cbAjoutEleveVisite
            // 
            this.cbAjoutEleveVisite.FormattingEnabled = true;
            this.cbAjoutEleveVisite.Location = new System.Drawing.Point(108, 53);
            this.cbAjoutEleveVisite.Margin = new System.Windows.Forms.Padding(4);
            this.cbAjoutEleveVisite.Name = "cbAjoutEleveVisite";
            this.cbAjoutEleveVisite.Size = new System.Drawing.Size(248, 24);
            this.cbAjoutEleveVisite.TabIndex = 24;
            // 
            // lblAjoutMedicamentVisite
            // 
            this.lblAjoutMedicamentVisite.AutoSize = true;
            this.lblAjoutMedicamentVisite.Location = new System.Drawing.Point(401, 316);
            this.lblAjoutMedicamentVisite.Name = "lblAjoutMedicamentVisite";
            this.lblAjoutMedicamentVisite.Size = new System.Drawing.Size(96, 17);
            this.lblAjoutMedicamentVisite.TabIndex = 21;
            this.lblAjoutMedicamentVisite.Text = "Medicament ?";
            // 
            // dtpAjoutDateFinVisite
            // 
            this.dtpAjoutDateFinVisite.CustomFormat = "dd MMMM, yyyy  |  HH:mm";
            this.dtpAjoutDateFinVisite.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAjoutDateFinVisite.Location = new System.Drawing.Point(683, 59);
            this.dtpAjoutDateFinVisite.Margin = new System.Windows.Forms.Padding(4);
            this.dtpAjoutDateFinVisite.Name = "dtpAjoutDateFinVisite";
            this.dtpAjoutDateFinVisite.Size = new System.Drawing.Size(265, 22);
            this.dtpAjoutDateFinVisite.TabIndex = 20;
            // 
            // lblAjoutDateFinVisite
            // 
            this.lblAjoutDateFinVisite.AutoSize = true;
            this.lblAjoutDateFinVisite.Location = new System.Drawing.Point(679, 30);
            this.lblAjoutDateFinVisite.Name = "lblAjoutDateFinVisite";
            this.lblAjoutDateFinVisite.Size = new System.Drawing.Size(171, 17);
            this.lblAjoutDateFinVisite.TabIndex = 19;
            this.lblAjoutDateFinVisite.Text = "Heure / Jour début visite :";
            // 
            // dtpAjoutDateDebutVisite
            // 
            this.dtpAjoutDateDebutVisite.CustomFormat = "dd MMMM, yyyy  |  HH:mm";
            this.dtpAjoutDateDebutVisite.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAjoutDateDebutVisite.Location = new System.Drawing.Point(384, 58);
            this.dtpAjoutDateDebutVisite.Margin = new System.Windows.Forms.Padding(4);
            this.dtpAjoutDateDebutVisite.Name = "dtpAjoutDateDebutVisite";
            this.dtpAjoutDateDebutVisite.Size = new System.Drawing.Size(265, 22);
            this.dtpAjoutDateDebutVisite.TabIndex = 18;
            // 
            // chkbAjoutParentsPrevenusVisite
            // 
            this.chkbAjoutParentsPrevenusVisite.AutoSize = true;
            this.chkbAjoutParentsPrevenusVisite.Location = new System.Drawing.Point(724, 242);
            this.chkbAjoutParentsPrevenusVisite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkbAjoutParentsPrevenusVisite.Name = "chkbAjoutParentsPrevenusVisite";
            this.chkbAjoutParentsPrevenusVisite.Size = new System.Drawing.Size(155, 21);
            this.chkbAjoutParentsPrevenusVisite.TabIndex = 17;
            this.chkbAjoutParentsPrevenusVisite.Text = "Parents Prevenus ?";
            this.chkbAjoutParentsPrevenusVisite.UseVisualStyleBackColor = true;
            // 
            // chkbAjoutHospitalisationVisite
            // 
            this.chkbAjoutHospitalisationVisite.AutoSize = true;
            this.chkbAjoutHospitalisationVisite.Location = new System.Drawing.Point(399, 242);
            this.chkbAjoutHospitalisationVisite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkbAjoutHospitalisationVisite.Name = "chkbAjoutHospitalisationVisite";
            this.chkbAjoutHospitalisationVisite.Size = new System.Drawing.Size(134, 21);
            this.chkbAjoutHospitalisationVisite.TabIndex = 16;
            this.chkbAjoutHospitalisationVisite.Text = "Hospitalisation ?";
            this.chkbAjoutHospitalisationVisite.UseVisualStyleBackColor = true;
            // 
            // cbAjoutMedicamentVisite
            // 
            this.cbAjoutMedicamentVisite.FormattingEnabled = true;
            this.cbAjoutMedicamentVisite.Location = new System.Drawing.Point(515, 313);
            this.cbAjoutMedicamentVisite.Margin = new System.Windows.Forms.Padding(4);
            this.cbAjoutMedicamentVisite.Name = "cbAjoutMedicamentVisite";
            this.cbAjoutMedicamentVisite.Size = new System.Drawing.Size(141, 24);
            this.cbAjoutMedicamentVisite.TabIndex = 15;
            this.cbAjoutMedicamentVisite.TextChanged += new System.EventHandler(this.cbAjoutMedicamentVisite_TextChanged);
            // 
            // txtAjoutCommentaireVisite
            // 
            this.txtAjoutCommentaireVisite.Location = new System.Drawing.Point(731, 146);
            this.txtAjoutCommentaireVisite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAjoutCommentaireVisite.MinimumSize = new System.Drawing.Size(4, 50);
            this.txtAjoutCommentaireVisite.Name = "txtAjoutCommentaireVisite";
            this.txtAjoutCommentaireVisite.Size = new System.Drawing.Size(151, 22);
            this.txtAjoutCommentaireVisite.TabIndex = 13;
            // 
            // chkbAjoutRenvoiDomicileVisite
            // 
            this.chkbAjoutRenvoiDomicileVisite.AutoSize = true;
            this.chkbAjoutRenvoiDomicileVisite.Location = new System.Drawing.Point(557, 242);
            this.chkbAjoutRenvoiDomicileVisite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkbAjoutRenvoiDomicileVisite.Name = "chkbAjoutRenvoiDomicileVisite";
            this.chkbAjoutRenvoiDomicileVisite.Size = new System.Drawing.Size(143, 21);
            this.chkbAjoutRenvoiDomicileVisite.TabIndex = 12;
            this.chkbAjoutRenvoiDomicileVisite.Text = "Renvoi Domicile ?";
            this.chkbAjoutRenvoiDomicileVisite.UseVisualStyleBackColor = true;
            // 
            // lblAjoutQuantiteMedicamentVisite
            // 
            this.lblAjoutQuantiteMedicamentVisite.AutoSize = true;
            this.lblAjoutQuantiteMedicamentVisite.Location = new System.Drawing.Point(679, 316);
            this.lblAjoutQuantiteMedicamentVisite.Name = "lblAjoutQuantiteMedicamentVisite";
            this.lblAjoutQuantiteMedicamentVisite.Size = new System.Drawing.Size(154, 17);
            this.lblAjoutQuantiteMedicamentVisite.TabIndex = 11;
            this.lblAjoutQuantiteMedicamentVisite.Text = "Quantité Medicament ?";
            this.lblAjoutQuantiteMedicamentVisite.Visible = false;
            // 
            // txtAjoutQuantiteMedicamentVisite
            // 
            this.txtAjoutQuantiteMedicamentVisite.Location = new System.Drawing.Point(840, 313);
            this.txtAjoutQuantiteMedicamentVisite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAjoutQuantiteMedicamentVisite.Name = "txtAjoutQuantiteMedicamentVisite";
            this.txtAjoutQuantiteMedicamentVisite.Size = new System.Drawing.Size(141, 22);
            this.txtAjoutQuantiteMedicamentVisite.TabIndex = 10;
            this.txtAjoutQuantiteMedicamentVisite.Visible = false;
            // 
            // lblAjoutCommentaireVisite
            // 
            this.lblAjoutCommentaireVisite.AutoSize = true;
            this.lblAjoutCommentaireVisite.Location = new System.Drawing.Point(627, 150);
            this.lblAjoutCommentaireVisite.Name = "lblAjoutCommentaireVisite";
            this.lblAjoutCommentaireVisite.Size = new System.Drawing.Size(99, 17);
            this.lblAjoutCommentaireVisite.TabIndex = 9;
            this.lblAjoutCommentaireVisite.Text = "Commentaire :";
            // 
            // lblAjoutDateDebutVisite
            // 
            this.lblAjoutDateDebutVisite.AutoSize = true;
            this.lblAjoutDateDebutVisite.Location = new System.Drawing.Point(380, 28);
            this.lblAjoutDateDebutVisite.Name = "lblAjoutDateDebutVisite";
            this.lblAjoutDateDebutVisite.Size = new System.Drawing.Size(171, 17);
            this.lblAjoutDateDebutVisite.TabIndex = 6;
            this.lblAjoutDateDebutVisite.Text = "Heure / Jour début visite :";
            // 
            // lblAjoutMotifVisite
            // 
            this.lblAjoutMotifVisite.AutoSize = true;
            this.lblAjoutMotifVisite.Location = new System.Drawing.Point(384, 150);
            this.lblAjoutMotifVisite.Name = "lblAjoutMotifVisite";
            this.lblAjoutMotifVisite.Size = new System.Drawing.Size(46, 17);
            this.lblAjoutMotifVisite.TabIndex = 1;
            this.lblAjoutMotifVisite.Text = "Motif :";
            // 
            // txtAjoutMotifVisite
            // 
            this.txtAjoutMotifVisite.Location = new System.Drawing.Point(437, 144);
            this.txtAjoutMotifVisite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAjoutMotifVisite.Name = "txtAjoutMotifVisite";
            this.txtAjoutMotifVisite.Size = new System.Drawing.Size(141, 22);
            this.txtAjoutMotifVisite.TabIndex = 0;
            // 
            // lblVisites
            // 
            this.lblVisites.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblVisites.AutoSize = true;
            this.lblVisites.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.lblVisites.Location = new System.Drawing.Point(620, 9);
            this.lblVisites.Name = "lblVisites";
            this.lblVisites.Size = new System.Drawing.Size(111, 41);
            this.lblVisites.TabIndex = 0;
            this.lblVisites.Text = "Visites";
            // 
            // btnAjouterVisite
            // 
            this.btnAjouterVisite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjouterVisite.BackColor = System.Drawing.Color.LightGreen;
            this.btnAjouterVisite.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnAjouterVisite.Location = new System.Drawing.Point(1111, 27);
            this.btnAjouterVisite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAjouterVisite.Name = "btnAjouterVisite";
            this.btnAjouterVisite.Size = new System.Drawing.Size(91, 30);
            this.btnAjouterVisite.TabIndex = 4;
            this.btnAjouterVisite.Text = "Ajouter";
            this.btnAjouterVisite.UseVisualStyleBackColor = false;
            this.btnAjouterVisite.Click += new System.EventHandler(this.btnAjouterVisite_Click);
            // 
            // dgvVisites
            // 
            this.dgvVisites.AllowUserToOrderColumns = true;
            this.dgvVisites.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVisites.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVisites.BackgroundColor = System.Drawing.Color.White;
            this.dgvVisites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisites.Location = new System.Drawing.Point(149, 70);
            this.dgvVisites.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvVisites.Name = "dgvVisites";
            this.dgvVisites.ReadOnly = true;
            this.dgvVisites.RowHeadersWidth = 51;
            this.dgvVisites.RowTemplate.Height = 24;
            this.dgvVisites.Size = new System.Drawing.Size(1053, 298);
            this.dgvVisites.TabIndex = 1;
            this.dgvVisites.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVisites_CellClick);
            this.dgvVisites.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.dgvVisites_SortCompare);
            // 
            // btnSupprimerVisite
            // 
            this.btnSupprimerVisite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprimerVisite.BackColor = System.Drawing.Color.IndianRed;
            this.btnSupprimerVisite.FlatAppearance.BorderSize = 0;
            this.btnSupprimerVisite.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnSupprimerVisite.Location = new System.Drawing.Point(853, 27);
            this.btnSupprimerVisite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSupprimerVisite.Name = "btnSupprimerVisite";
            this.btnSupprimerVisite.Size = new System.Drawing.Size(117, 30);
            this.btnSupprimerVisite.TabIndex = 2;
            this.btnSupprimerVisite.Text = "Supprimer";
            this.btnSupprimerVisite.UseVisualStyleBackColor = false;
            this.btnSupprimerVisite.Click += new System.EventHandler(this.btnSupprimerVisite_Click);
            // 
            // btnConfirmerVisite
            // 
            this.btnConfirmerVisite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmerVisite.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnConfirmerVisite.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnConfirmerVisite.Location = new System.Drawing.Point(976, 27);
            this.btnConfirmerVisite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmerVisite.Name = "btnConfirmerVisite";
            this.btnConfirmerVisite.Size = new System.Drawing.Size(129, 30);
            this.btnConfirmerVisite.TabIndex = 3;
            this.btnConfirmerVisite.Text = "Confirmer";
            this.btnConfirmerVisite.UseVisualStyleBackColor = false;
            this.btnConfirmerVisite.Click += new System.EventHandler(this.btnConfirmerVisite_Click);
            // 
            // pnlStats
            // 
            this.pnlStats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStats.Controls.Add(this.pnlSeparatorHorizontal);
            this.pnlStats.Controls.Add(this.pnlGraphique);
            this.pnlStats.Controls.Add(this.pnlResults);
            this.pnlStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlStats.Location = new System.Drawing.Point(320, 0);
            this.pnlStats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(1379, 780);
            this.pnlStats.TabIndex = 23;
            // 
            // pnlSeparatorHorizontal
            // 
            this.pnlSeparatorHorizontal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSeparatorHorizontal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSeparatorHorizontal.Location = new System.Drawing.Point(34, 352);
            this.pnlSeparatorHorizontal.Name = "pnlSeparatorHorizontal";
            this.pnlSeparatorHorizontal.Size = new System.Drawing.Size(1000, 2);
            this.pnlSeparatorHorizontal.TabIndex = 8;
            // 
            // pnlGraphique
            // 
            this.pnlGraphique.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGraphique.Controls.Add(this.dtpGraphAnnee);
            this.pnlGraphique.Controls.Add(this.lblGraphNbVisite);
            this.pnlGraphique.Controls.Add(this.Graphique);
            this.pnlGraphique.Location = new System.Drawing.Point(10, 369);
            this.pnlGraphique.Name = "pnlGraphique";
            this.pnlGraphique.Size = new System.Drawing.Size(1062, 408);
            this.pnlGraphique.TabIndex = 1;
            // 
            // lblGraphNbVisite
            // 
            this.lblGraphNbVisite.AutoSize = true;
            this.lblGraphNbVisite.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGraphNbVisite.Location = new System.Drawing.Point(24, 2);
            this.lblGraphNbVisite.Name = "lblGraphNbVisite";
            this.lblGraphNbVisite.Size = new System.Drawing.Size(353, 29);
            this.lblGraphNbVisite.TabIndex = 1;
            this.lblGraphNbVisite.Text = "Visites par mois pour l\'année :";
            // 
            // Graphique
            // 
            this.Graphique.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "ChartArea1";
            this.Graphique.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.Graphique.Legends.Add(legend4);
            this.Graphique.Location = new System.Drawing.Point(24, 45);
            this.Graphique.Name = "Graphique";
            this.Graphique.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Nombre de visites par mois";
            series4.Points.Add(dataPoint37);
            series4.Points.Add(dataPoint38);
            series4.Points.Add(dataPoint39);
            series4.Points.Add(dataPoint40);
            series4.Points.Add(dataPoint41);
            series4.Points.Add(dataPoint42);
            series4.Points.Add(dataPoint43);
            series4.Points.Add(dataPoint44);
            series4.Points.Add(dataPoint45);
            series4.Points.Add(dataPoint46);
            series4.Points.Add(dataPoint47);
            series4.Points.Add(dataPoint48);
            this.Graphique.Series.Add(series4);
            this.Graphique.Size = new System.Drawing.Size(1030, 349);
            this.Graphique.TabIndex = 0;
            this.Graphique.Text = "chart1";
            // 
            // pnlResults
            // 
            this.pnlResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlResults.Controls.Add(this.lblVisiteParDateResult);
            this.pnlResults.Controls.Add(this.lblNbVisiteParDate);
            this.pnlResults.Controls.Add(this.lblNbMedicamentDonnesParVisiteResult);
            this.pnlResults.Controls.Add(this.lblNbMedicamentDonnesParVisite);
            this.pnlResults.Controls.Add(this.lblMinutes);
            this.pnlResults.Controls.Add(this.lblTempsMoyenParVisiteResult);
            this.pnlResults.Controls.Add(this.lblTempsMoyenDeVisite);
            this.pnlResults.Controls.Add(this.lblNbVisiteParEleveResult);
            this.pnlResults.Controls.Add(this.lblNbVisiteParEleve);
            this.pnlResults.Controls.Add(this.lblNbMedicamentDonnesResult);
            this.pnlResults.Controls.Add(this.lblNbMedicamentsDonnes);
            this.pnlResults.Controls.Add(this.dtpFinVisite);
            this.pnlResults.Controls.Add(this.lblFinVisite);
            this.pnlResults.Controls.Add(this.dtpDebutVisite);
            this.pnlResults.Controls.Add(this.lblDebutVisite);
            this.pnlResults.Controls.Add(this.lblNbEleveTotal);
            this.pnlResults.Controls.Add(this.lblResultNbVisites);
            this.pnlResults.Controls.Add(this.pnlSeparator);
            this.pnlResults.Controls.Add(this.lblResultNbEleve);
            this.pnlResults.Controls.Add(this.lblNbTotalVisites);
            this.pnlResults.Controls.Add(this.label1);
            this.pnlResults.Location = new System.Drawing.Point(10, 30);
            this.pnlResults.Name = "pnlResults";
            this.pnlResults.Size = new System.Drawing.Size(1113, 316);
            this.pnlResults.TabIndex = 0;
            // 
            // lblVisiteParDateResult
            // 
            this.lblVisiteParDateResult.AutoSize = true;
            this.lblVisiteParDateResult.Location = new System.Drawing.Point(1000, 63);
            this.lblVisiteParDateResult.Name = "lblVisiteParDateResult";
            this.lblVisiteParDateResult.Size = new System.Drawing.Size(24, 26);
            this.lblVisiteParDateResult.TabIndex = 22;
            this.lblVisiteParDateResult.Text = "0";
            // 
            // lblNbVisiteParDate
            // 
            this.lblNbVisiteParDate.AutoSize = true;
            this.lblNbVisiteParDate.Location = new System.Drawing.Point(413, 63);
            this.lblNbVisiteParDate.Name = "lblNbVisiteParDate";
            this.lblNbVisiteParDate.Size = new System.Drawing.Size(193, 26);
            this.lblNbVisiteParDate.TabIndex = 21;
            this.lblNbVisiteParDate.Text = "Nombre de visites:";
            // 
            // lblNbMedicamentDonnesParVisiteResult
            // 
            this.lblNbMedicamentDonnesParVisiteResult.AutoSize = true;
            this.lblNbMedicamentDonnesParVisiteResult.Location = new System.Drawing.Point(1000, 261);
            this.lblNbMedicamentDonnesParVisiteResult.Name = "lblNbMedicamentDonnesParVisiteResult";
            this.lblNbMedicamentDonnesParVisiteResult.Size = new System.Drawing.Size(24, 26);
            this.lblNbMedicamentDonnesParVisiteResult.TabIndex = 20;
            this.lblNbMedicamentDonnesParVisiteResult.Text = "0";
            // 
            // lblNbMedicamentDonnesParVisite
            // 
            this.lblNbMedicamentDonnesParVisite.AutoSize = true;
            this.lblNbMedicamentDonnesParVisite.Location = new System.Drawing.Point(413, 261);
            this.lblNbMedicamentDonnesParVisite.Name = "lblNbMedicamentDonnesParVisite";
            this.lblNbMedicamentDonnesParVisite.Size = new System.Drawing.Size(509, 26);
            this.lblNbMedicamentDonnesParVisite.TabIndex = 19;
            this.lblNbMedicamentDonnesParVisite.Text = "Nombre moyen de médicaments donnés pas visite:";
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(1030, 212);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(48, 26);
            this.lblMinutes.TabIndex = 18;
            this.lblMinutes.Text = "min";
            // 
            // lblTempsMoyenParVisiteResult
            // 
            this.lblTempsMoyenParVisiteResult.AutoSize = true;
            this.lblTempsMoyenParVisiteResult.Location = new System.Drawing.Point(1000, 212);
            this.lblTempsMoyenParVisiteResult.Name = "lblTempsMoyenParVisiteResult";
            this.lblTempsMoyenParVisiteResult.Size = new System.Drawing.Size(24, 26);
            this.lblTempsMoyenParVisiteResult.TabIndex = 17;
            this.lblTempsMoyenParVisiteResult.Text = "0";
            // 
            // lblTempsMoyenDeVisite
            // 
            this.lblTempsMoyenDeVisite.AutoSize = true;
            this.lblTempsMoyenDeVisite.Location = new System.Drawing.Point(413, 212);
            this.lblTempsMoyenDeVisite.Name = "lblTempsMoyenDeVisite";
            this.lblTempsMoyenDeVisite.Size = new System.Drawing.Size(249, 26);
            this.lblTempsMoyenDeVisite.TabIndex = 16;
            this.lblTempsMoyenDeVisite.Text = "Temps moyen par visite:";
            // 
            // lblNbVisiteParEleveResult
            // 
            this.lblNbVisiteParEleveResult.AutoSize = true;
            this.lblNbVisiteParEleveResult.Location = new System.Drawing.Point(1000, 160);
            this.lblNbVisiteParEleveResult.Name = "lblNbVisiteParEleveResult";
            this.lblNbVisiteParEleveResult.Size = new System.Drawing.Size(24, 26);
            this.lblNbVisiteParEleveResult.TabIndex = 15;
            this.lblNbVisiteParEleveResult.Text = "0";
            // 
            // lblNbVisiteParEleve
            // 
            this.lblNbVisiteParEleve.AutoSize = true;
            this.lblNbVisiteParEleve.Location = new System.Drawing.Point(413, 160);
            this.lblNbVisiteParEleve.Name = "lblNbVisiteParEleve";
            this.lblNbVisiteParEleve.Size = new System.Drawing.Size(299, 26);
            this.lblNbVisiteParEleve.TabIndex = 14;
            this.lblNbVisiteParEleve.Text = "Nombre de visites par élèves:";
            // 
            // lblNbMedicamentDonnesResult
            // 
            this.lblNbMedicamentDonnesResult.AutoSize = true;
            this.lblNbMedicamentDonnesResult.Location = new System.Drawing.Point(1000, 112);
            this.lblNbMedicamentDonnesResult.Name = "lblNbMedicamentDonnesResult";
            this.lblNbMedicamentDonnesResult.Size = new System.Drawing.Size(24, 26);
            this.lblNbMedicamentDonnesResult.TabIndex = 13;
            this.lblNbMedicamentDonnesResult.Text = "0";
            // 
            // lblNbMedicamentsDonnes
            // 
            this.lblNbMedicamentsDonnes.AutoSize = true;
            this.lblNbMedicamentsDonnes.Location = new System.Drawing.Point(413, 112);
            this.lblNbMedicamentsDonnes.Name = "lblNbMedicamentsDonnes";
            this.lblNbMedicamentsDonnes.Size = new System.Drawing.Size(340, 26);
            this.lblNbMedicamentsDonnes.TabIndex = 12;
            this.lblNbMedicamentsDonnes.Text = "Nombre de médicaments donnés:";
            // 
            // dtpFinVisite
            // 
            this.dtpFinVisite.CustomFormat = "dd MMMM yyyy";
            this.dtpFinVisite.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFinVisite.Location = new System.Drawing.Point(796, 5);
            this.dtpFinVisite.Name = "dtpFinVisite";
            this.dtpFinVisite.Size = new System.Drawing.Size(261, 32);
            this.dtpFinVisite.TabIndex = 11;
            this.dtpFinVisite.ValueChanged += new System.EventHandler(this.dtpFinVisite_ValueChanged);
            // 
            // lblFinVisite
            // 
            this.lblFinVisite.AutoSize = true;
            this.lblFinVisite.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinVisite.Location = new System.Drawing.Point(739, 7);
            this.lblFinVisite.Name = "lblFinVisite";
            this.lblFinVisite.Size = new System.Drawing.Size(51, 26);
            this.lblFinVisite.TabIndex = 10;
            this.lblFinVisite.Text = "Au :";
            // 
            // dtpDebutVisite
            // 
            this.dtpDebutVisite.CustomFormat = "dd MMMM yyyy";
            this.dtpDebutVisite.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDebutVisite.Location = new System.Drawing.Point(469, 5);
            this.dtpDebutVisite.Name = "dtpDebutVisite";
            this.dtpDebutVisite.Size = new System.Drawing.Size(249, 32);
            this.dtpDebutVisite.TabIndex = 9;
            this.dtpDebutVisite.Value = new System.DateTime(2022, 12, 14, 10, 5, 0, 0);
            this.dtpDebutVisite.ValueChanged += new System.EventHandler(this.dtpDebutVisite_ValueChanged);
            // 
            // lblDebutVisite
            // 
            this.lblDebutVisite.AutoSize = true;
            this.lblDebutVisite.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebutVisite.Location = new System.Drawing.Point(411, 9);
            this.lblDebutVisite.Name = "lblDebutVisite";
            this.lblDebutVisite.Size = new System.Drawing.Size(52, 26);
            this.lblDebutVisite.TabIndex = 8;
            this.lblDebutVisite.Text = "Du :";
            // 
            // lblNbEleveTotal
            // 
            this.lblNbEleveTotal.AutoSize = true;
            this.lblNbEleveTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbEleveTotal.Location = new System.Drawing.Point(35, 97);
            this.lblNbEleveTotal.Name = "lblNbEleveTotal";
            this.lblNbEleveTotal.Size = new System.Drawing.Size(265, 29);
            this.lblNbEleveTotal.TabIndex = 2;
            this.lblNbEleveTotal.Text = "Nombre total d\'élèves:";
            // 
            // lblResultNbVisites
            // 
            this.lblResultNbVisites.AutoSize = true;
            this.lblResultNbVisites.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultNbVisites.Location = new System.Drawing.Point(313, 169);
            this.lblResultNbVisites.Name = "lblResultNbVisites";
            this.lblResultNbVisites.Size = new System.Drawing.Size(27, 29);
            this.lblResultNbVisites.TabIndex = 6;
            this.lblResultNbVisites.Text = "0";
            // 
            // pnlSeparator
            // 
            this.pnlSeparator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSeparator.Location = new System.Drawing.Point(403, 6);
            this.pnlSeparator.Name = "pnlSeparator";
            this.pnlSeparator.Size = new System.Drawing.Size(2, 300);
            this.pnlSeparator.TabIndex = 7;
            // 
            // lblResultNbEleve
            // 
            this.lblResultNbEleve.AutoSize = true;
            this.lblResultNbEleve.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultNbEleve.Location = new System.Drawing.Point(313, 97);
            this.lblResultNbEleve.Name = "lblResultNbEleve";
            this.lblResultNbEleve.Size = new System.Drawing.Size(27, 29);
            this.lblResultNbEleve.TabIndex = 3;
            this.lblResultNbEleve.Text = "0";
            // 
            // lblNbTotalVisites
            // 
            this.lblNbTotalVisites.AutoSize = true;
            this.lblNbTotalVisites.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbTotalVisites.Location = new System.Drawing.Point(35, 169);
            this.lblNbTotalVisites.Name = "lblNbTotalVisites";
            this.lblNbTotalVisites.Size = new System.Drawing.Size(279, 29);
            this.lblNbTotalVisites.TabIndex = 4;
            this.lblNbTotalVisites.Text = "Nombre total de visites:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 5;
            // 
            // dtpGraphAnnee
            // 
            this.dtpGraphAnnee.CustomFormat = "yyyy";
            this.dtpGraphAnnee.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGraphAnnee.Location = new System.Drawing.Point(383, 2);
            this.dtpGraphAnnee.Name = "dtpGraphAnnee";
            this.dtpGraphAnnee.ShowUpDown = true;
            this.dtpGraphAnnee.Size = new System.Drawing.Size(108, 32);
            this.dtpGraphAnnee.TabIndex = 23;
            this.dtpGraphAnnee.Value = new System.DateTime(2023, 12, 14, 10, 28, 47, 0);
            this.dtpGraphAnnee.ValueChanged += new System.EventHandler(this.dtpGraphAnnee_ValueChanged);
            // 
            // FrmGestionInfirmerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1653, 807);
            this.Controls.Add(this.pnlStats);
            this.Controls.Add(this.pnlVisites);
            this.Controls.Add(this.pnlEleves);
            this.Controls.Add(this.pnlMedicaments);
            this.Controls.Add(this.msMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmGestionInfirmerie";
            this.Text = "Gestion Infirmerie | Accueil";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEleves)).EndInit();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.pnlModif.ResumeLayout(false);
            this.pnlModif.PerformLayout();
            this.pnlEleves.ResumeLayout(false);
            this.pnlEleves.PerformLayout();
            this.pnlAjoutEleve.ResumeLayout(false);
            this.pnlAjoutEleve.PerformLayout();
            this.pnlMedicaments.ResumeLayout(false);
            this.pnlMedicaments.PerformLayout();
            this.pnlAjoutMedic.ResumeLayout(false);
            this.pnlAjoutMedic.PerformLayout();
            this.pnlMedicModif.ResumeLayout(false);
            this.pnlMedicModif.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicaments)).EndInit();
            this.pnlVisites.ResumeLayout(false);
            this.pnlVisites.PerformLayout();
            this.pnlModifVisite.ResumeLayout(false);
            this.pnlModifVisite.PerformLayout();
            this.pnlAjoutVisite.ResumeLayout(false);
            this.pnlAjoutVisite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisites)).EndInit();
            this.pnlStats.ResumeLayout(false);
            this.pnlGraphique.ResumeLayout(false);
            this.pnlGraphique.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Graphique)).EndInit();
            this.pnlResults.ResumeLayout(false);
            this.pnlResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblAccueil;
        private System.Windows.Forms.DataGridView dgvEleves;
        private System.Windows.Forms.Button btnSupprimerEleve;
        private System.Windows.Forms.Button btnConfirmereleve;
        private System.Windows.Forms.Button btnAjoutEleve;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem visitesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médicamentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistiquesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem élèvesToolStripMenuItem;
        private System.Windows.Forms.Panel pnlModif;
        private System.Windows.Forms.Label lblNomModif;
        private System.Windows.Forms.TextBox txtNomModif;
        private System.Windows.Forms.TextBox txtIdModif;
        private System.Windows.Forms.Label lblPRenomModif;
        private System.Windows.Forms.TextBox txtPrenomModif;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblTelEleveModif;
        private System.Windows.Forms.TextBox txtNumeroEleve;
        private System.Windows.Forms.Label lblNumeroTelParentModif;
        private System.Windows.Forms.TextBox txtNumeroParent;
        private System.Windows.Forms.CheckBox chkExtraTime;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel pnlEleves;
        private System.Windows.Forms.Panel pnlMedicaments;
        private System.Windows.Forms.Label lblMedicaments;
        private System.Windows.Forms.Panel pnlMedicModif;
        private System.Windows.Forms.TextBox txtIdMedicModif;
        private System.Windows.Forms.Label lblNomMedicModif;
        private System.Windows.Forms.TextBox txtNomMedicModif;
        private System.Windows.Forms.Button btnAjoutMEdic;
        private System.Windows.Forms.DataGridView dgvMedicaments;
        private System.Windows.Forms.Button btnSupprimerMedic;
        private System.Windows.Forms.Button btnConfirmerMedic;
        private System.Windows.Forms.Panel pnlAjoutMedic;
        private System.Windows.Forms.TextBox txtIdMedicAjout;
        private System.Windows.Forms.Label lblNomMedicAjout;
        private System.Windows.Forms.TextBox txtNomMedicAjout;
        private System.Windows.Forms.Label lblAjoutMedic;
        private System.Windows.Forms.Label lblModifMedic;
        private System.Windows.Forms.Panel pnlAjoutEleve;
        private System.Windows.Forms.ComboBox cboxClasseEleveAjout;
        private System.Windows.Forms.Label lblCommentaireEleveAjout;
        private System.Windows.Forms.TextBox txtCommentaireEleveAjout;
        private System.Windows.Forms.CheckBox chkExtraTimeEleveAjout;
        private System.Windows.Forms.Label lblNumeroParentEleveAjout;
        private System.Windows.Forms.TextBox txtNumeroParentEleveAjout;
        private System.Windows.Forms.Label lblNumeroEleveAjout;
        private System.Windows.Forms.TextBox txtNumeroEleveAjout;
        private System.Windows.Forms.MonthCalendar mcBirthdateEleveAjout;
        private System.Windows.Forms.Label lblBirthdateEleveAjout;
        private System.Windows.Forms.Label lblPrenomEleveAjout;
        private System.Windows.Forms.TextBox txtPrenomEleveAjout;
        private System.Windows.Forms.TextBox txtIdEleveAjout;
        private System.Windows.Forms.Label lblNomEleveAjout;
        private System.Windows.Forms.TextBox txtNomEleveAjout;
        private System.Windows.Forms.Panel pnlVisites;
        private System.Windows.Forms.Label lblVisites;
        private System.Windows.Forms.Button btnAjouterVisite;
        private System.Windows.Forms.DataGridView dgvVisites;
        private System.Windows.Forms.Button btnSupprimerVisite;
        private System.Windows.Forms.Button btnConfirmerVisite;
        private System.Windows.Forms.Panel pnlModifVisite;
        private System.Windows.Forms.Label lblModifMedicamentVisite;
        private System.Windows.Forms.DateTimePicker dtpModifDateFinVisite;
        private System.Windows.Forms.Label lblModifDateFinVisite;
        private System.Windows.Forms.DateTimePicker dtpModifDateDebutVisite;
        private System.Windows.Forms.CheckBox chkbModifParentsPrevenusVisite;
        private System.Windows.Forms.CheckBox chkbModifHospitalisationVisite;
        private System.Windows.Forms.ComboBox cbModifMedicamentVisite;
        private System.Windows.Forms.TextBox txtModifCommentaireVisite;
        private System.Windows.Forms.CheckBox chkbModifRenvoiDomicileVisite;
        private System.Windows.Forms.Label lblModifQuantiteMedicamentVisite;
        private System.Windows.Forms.TextBox txtModifQuantiteMedicamentVisite;
        private System.Windows.Forms.Label lblModifCommentaireVisite;
        private System.Windows.Forms.Label lblModifDateDebutVisite;
        private System.Windows.Forms.Label lblModifMotifVisite;
        private System.Windows.Forms.TextBox txtModifMotifVisite;
        private System.Windows.Forms.Panel pnlAjoutVisite;
        private System.Windows.Forms.Label lblAjoutMedicamentVisite;
        private System.Windows.Forms.DateTimePicker dtpAjoutDateFinVisite;
        private System.Windows.Forms.Label lblAjoutDateFinVisite;
        private System.Windows.Forms.DateTimePicker dtpAjoutDateDebutVisite;
        private System.Windows.Forms.CheckBox chkbAjoutParentsPrevenusVisite;
        private System.Windows.Forms.CheckBox chkbAjoutHospitalisationVisite;
        private System.Windows.Forms.ComboBox cbAjoutMedicamentVisite;
        private System.Windows.Forms.TextBox txtAjoutCommentaireVisite;
        private System.Windows.Forms.CheckBox chkbAjoutRenvoiDomicileVisite;
        private System.Windows.Forms.Label lblAjoutQuantiteMedicamentVisite;
        private System.Windows.Forms.TextBox txtAjoutQuantiteMedicamentVisite;
        private System.Windows.Forms.Label lblAjoutCommentaireVisite;
        private System.Windows.Forms.Label lblAjoutDateDebutVisite;
        private System.Windows.Forms.Label lblAjoutMotifVisite;
        private System.Windows.Forms.TextBox txtAjoutMotifVisite;
        private System.Windows.Forms.Label lblModifEleveVisite;
        private System.Windows.Forms.ComboBox cbModifEleveVisite;
        private System.Windows.Forms.Label lblAjoutEleveVisite;
        private System.Windows.Forms.ComboBox cbAjoutEleveVisite;
        private System.Windows.Forms.TextBox txtModifIdVisite;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Panel pnlGraphique;
        private System.Windows.Forms.Panel pnlResults;
        private System.Windows.Forms.Label lblNbEleveTotal;
        private System.Windows.Forms.Label lblResultNbEleve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNbTotalVisites;
        private System.Windows.Forms.Label lblResultNbVisites;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Graphique;
        private System.Windows.Forms.Panel pnlSeparator;
        private System.Windows.Forms.Panel pnlSeparatorHorizontal;
        private System.Windows.Forms.Label lblDebutVisite;
        private System.Windows.Forms.DateTimePicker dtpFinVisite;
        private System.Windows.Forms.Label lblFinVisite;
        private System.Windows.Forms.DateTimePicker dtpDebutVisite;
        private System.Windows.Forms.Label lblNbVisiteParEleve;
        private System.Windows.Forms.Label lblNbMedicamentDonnesResult;
        private System.Windows.Forms.Label lblNbMedicamentsDonnes;
        private System.Windows.Forms.Label lblNbVisiteParEleveResult;
        private System.Windows.Forms.Label lblNbMedicamentDonnesParVisiteResult;
        private System.Windows.Forms.Label lblNbMedicamentDonnesParVisite;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblTempsMoyenParVisiteResult;
        private System.Windows.Forms.Label lblTempsMoyenDeVisite;
        private System.Windows.Forms.Label lblNbVisiteParDate;
        private System.Windows.Forms.Label lblVisiteParDateResult;
        private System.Windows.Forms.Label lblGraphNbVisite;
        private System.Windows.Forms.DateTimePicker dtpGraphAnnee;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}