
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionInfirmerie));
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvEleves)).BeginInit();
            this.msMenu.SuspendLayout();
            this.pnlModif.SuspendLayout();
            this.pnlEleves.SuspendLayout();
            this.pnlAjoutEleve.SuspendLayout();
            this.pnlMedicaments.SuspendLayout();
            this.pnlAjoutMedic.SuspendLayout();
            this.pnlMedicModif.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicaments)).BeginInit();
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
            this.msMenu.AutoSize = false;
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
            this.msMenu.Size = new System.Drawing.Size(302, 807);
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
            this.visitesToolStripMenuItem.Size = new System.Drawing.Size(296, 53);
            this.visitesToolStripMenuItem.Text = "Visites";
            // 
            // élèvesToolStripMenuItem
            // 
            this.élèvesToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.élèvesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("élèvesToolStripMenuItem.Image")));
            this.élèvesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.élèvesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.élèvesToolStripMenuItem.Name = "élèvesToolStripMenuItem";
            this.élèvesToolStripMenuItem.Size = new System.Drawing.Size(296, 53);
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
            this.médicamentsToolStripMenuItem.Size = new System.Drawing.Size(296, 53);
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
            this.statistiquesToolStripMenuItem.Size = new System.Drawing.Size(296, 53);
            this.statistiquesToolStripMenuItem.Text = "Statistiques";
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
            this.pnlEleves.Location = new System.Drawing.Point(49, 229);
            this.pnlEleves.Name = "pnlEleves";
            this.pnlEleves.Size = new System.Drawing.Size(1378, 780);
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
            this.pnlMedicaments.Controls.Add(this.pnlEleves);
            this.pnlMedicaments.Controls.Add(this.lblMedicaments);
            this.pnlMedicaments.Controls.Add(this.pnlAjoutMedic);
            this.pnlMedicaments.Controls.Add(this.pnlMedicModif);
            this.pnlMedicaments.Controls.Add(this.btnAjoutMEdic);
            this.pnlMedicaments.Controls.Add(this.dgvMedicaments);
            this.pnlMedicaments.Controls.Add(this.btnSupprimerMedic);
            this.pnlMedicaments.Controls.Add(this.btnConfirmerMedic);
            this.pnlMedicaments.Location = new System.Drawing.Point(300, 0);
            this.pnlMedicaments.Name = "pnlMedicaments";
            this.pnlMedicaments.Size = new System.Drawing.Size(1370, 1038);
            this.pnlMedicaments.TabIndex = 8;
            this.pnlMedicaments.Visible = false;
            // 
            // lblMedicaments
            // 
            this.lblMedicaments.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMedicaments.AutoSize = true;
            this.lblMedicaments.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.lblMedicaments.Location = new System.Drawing.Point(562, 16);
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
            this.pnlAjoutMedic.Size = new System.Drawing.Size(1042, 480);
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
            this.lblModifMedic.Location = new System.Drawing.Point(0, 3);
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
            this.dgvMedicaments.Location = new System.Drawing.Point(149, 72);
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
            // FrmGestionInfirmerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1654, 807);
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
            this.ResumeLayout(false);

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
    }
}