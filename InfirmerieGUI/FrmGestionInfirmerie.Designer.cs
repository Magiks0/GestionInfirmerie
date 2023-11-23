
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.visitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.élèvesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicamentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlModif = new System.Windows.Forms.Panel();
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pnlModif.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAccueil
            // 
            this.lblAccueil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAccueil.AutoSize = true;
            this.lblAccueil.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.lblAccueil.Location = new System.Drawing.Point(699, 27);
            this.lblAccueil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccueil.Name = "lblAccueil";
            this.lblAccueil.Size = new System.Drawing.Size(87, 33);
            this.lblAccueil.TabIndex = 0;
            this.lblAccueil.Text = "Élèves";
            this.lblAccueil.Click += new System.EventHandler(this.lblAccueil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(222, 75);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1065, 242);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Calibri", 9F);
            this.button1.Location = new System.Drawing.Point(992, 36);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Supprimer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.LemonChiffon;
            this.button2.Font = new System.Drawing.Font("Calibri", 9F);
            this.button2.Location = new System.Drawing.Point(1062, 36);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 24);
            this.button2.TabIndex = 3;
            this.button2.Text = "Confirmer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.LightGreen;
            this.button3.Font = new System.Drawing.Font("Calibri", 9F);
            this.button3.Location = new System.Drawing.Point(1142, 36);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 24);
            this.button3.TabIndex = 4;
            this.button3.Text = "Ajouter";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visitesToolStripMenuItem,
            this.élèvesToolStripMenuItem,
            this.médicamentsToolStripMenuItem,
            this.statistiquesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(137, 569);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // visitesToolStripMenuItem
            // 
            this.visitesToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("visitesToolStripMenuItem.Image")));
            this.visitesToolStripMenuItem.Name = "visitesToolStripMenuItem";
            this.visitesToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.visitesToolStripMenuItem.Text = "Visites";
            // 
            // élèvesToolStripMenuItem
            // 
            this.élèvesToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.élèvesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("élèvesToolStripMenuItem.Image")));
            this.élèvesToolStripMenuItem.Name = "élèvesToolStripMenuItem";
            this.élèvesToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.élèvesToolStripMenuItem.Text = "Élèves";
            // 
            // médicamentsToolStripMenuItem
            // 
            this.médicamentsToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.médicamentsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("médicamentsToolStripMenuItem.Image")));
            this.médicamentsToolStripMenuItem.Name = "médicamentsToolStripMenuItem";
            this.médicamentsToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.médicamentsToolStripMenuItem.Text = "Médicaments";
            // 
            // statistiquesToolStripMenuItem
            // 
            this.statistiquesToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statistiquesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("statistiquesToolStripMenuItem.Image")));
            this.statistiquesToolStripMenuItem.Name = "statistiquesToolStripMenuItem";
            this.statistiquesToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.statistiquesToolStripMenuItem.Text = "Statistiques";
            // 
            // pnlModif
            // 
            this.pnlModif.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.pnlModif.Location = new System.Drawing.Point(222, 346);
            this.pnlModif.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlModif.Name = "pnlModif";
            this.pnlModif.Size = new System.Drawing.Size(924, 388);
            this.pnlModif.TabIndex = 6;
            this.pnlModif.Visible = false;
            this.pnlModif.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(443, 91);
            this.lblComments.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(107, 13);
            this.lblComments.TabIndex = 14;
            this.lblComments.Text = "Commentaires Santé:";
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(555, 91);
            this.txtComments.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtComments.MinimumSize = new System.Drawing.Size(4, 50);
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(114, 20);
            this.txtComments.TabIndex = 13;
            this.txtComments.TextChanged += new System.EventHandler(this.txtComments_TextChanged);
            // 
            // chkExtraTime
            // 
            this.chkExtraTime.AutoSize = true;
            this.chkExtraTime.Location = new System.Drawing.Point(473, 34);
            this.chkExtraTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkExtraTime.Name = "chkExtraTime";
            this.chkExtraTime.Size = new System.Drawing.Size(79, 17);
            this.chkExtraTime.TabIndex = 12;
            this.chkExtraTime.Text = "Tier-Temps";
            this.chkExtraTime.UseVisualStyleBackColor = true;
            this.chkExtraTime.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblNumeroTelParentModif
            // 
            this.lblNumeroTelParentModif.AutoSize = true;
            this.lblNumeroTelParentModif.Location = new System.Drawing.Point(194, 91);
            this.lblNumeroTelParentModif.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroTelParentModif.Name = "lblNumeroTelParentModif";
            this.lblNumeroTelParentModif.Size = new System.Drawing.Size(111, 13);
            this.lblNumeroTelParentModif.TabIndex = 11;
            this.lblNumeroTelParentModif.Text = "Numero Parent Eleve:";
            // 
            // txtNumeroParent
            // 
            this.txtNumeroParent.Location = new System.Drawing.Point(308, 89);
            this.txtNumeroParent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumeroParent.Name = "txtNumeroParent";
            this.txtNumeroParent.Size = new System.Drawing.Size(107, 20);
            this.txtNumeroParent.TabIndex = 10;
            // 
            // lblTelEleveModif
            // 
            this.lblTelEleveModif.AutoSize = true;
            this.lblTelEleveModif.Location = new System.Drawing.Point(228, 45);
            this.lblTelEleveModif.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelEleveModif.Name = "lblTelEleveModif";
            this.lblTelEleveModif.Size = new System.Drawing.Size(77, 13);
            this.lblTelEleveModif.TabIndex = 9;
            this.lblTelEleveModif.Text = "Numero Eleve:";
            this.lblTelEleveModif.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNumeroEleve
            // 
            this.txtNumeroEleve.Location = new System.Drawing.Point(308, 42);
            this.txtNumeroEleve.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumeroEleve.Name = "txtNumeroEleve";
            this.txtNumeroEleve.Size = new System.Drawing.Size(107, 20);
            this.txtNumeroEleve.TabIndex = 8;
            this.txtNumeroEleve.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(4, 155);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Location = new System.Drawing.Point(2, 134);
            this.lblBirthdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(99, 13);
            this.lblBirthdate.TabIndex = 6;
            this.lblBirthdate.Text = "Date de naissance:";
            // 
            // lblPRenomModif
            // 
            this.lblPRenomModif.AutoSize = true;
            this.lblPRenomModif.Location = new System.Drawing.Point(2, 89);
            this.lblPRenomModif.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPRenomModif.Name = "lblPRenomModif";
            this.lblPRenomModif.Size = new System.Drawing.Size(43, 13);
            this.lblPRenomModif.TabIndex = 4;
            this.lblPRenomModif.Text = "Prenom";
            // 
            // txtPrenomModif
            // 
            this.txtPrenomModif.Location = new System.Drawing.Point(50, 89);
            this.txtPrenomModif.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrenomModif.Name = "txtPrenomModif";
            this.txtPrenomModif.Size = new System.Drawing.Size(107, 20);
            this.txtPrenomModif.TabIndex = 3;
            // 
            // txtIdModif
            // 
            this.txtIdModif.Location = new System.Drawing.Point(0, 2);
            this.txtIdModif.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdModif.Name = "txtIdModif";
            this.txtIdModif.Size = new System.Drawing.Size(76, 20);
            this.txtIdModif.TabIndex = 2;
            this.txtIdModif.Visible = false;
            // 
            // lblNomModif
            // 
            this.lblNomModif.AutoSize = true;
            this.lblNomModif.Location = new System.Drawing.Point(2, 45);
            this.lblNomModif.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomModif.Name = "lblNomModif";
            this.lblNomModif.Size = new System.Drawing.Size(32, 13);
            this.lblNomModif.TabIndex = 1;
            this.lblNomModif.Text = "Nom:";
            // 
            // txtNomModif
            // 
            this.txtNomModif.Location = new System.Drawing.Point(50, 45);
            this.txtNomModif.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNomModif.Name = "txtNomModif";
            this.txtNomModif.Size = new System.Drawing.Size(107, 20);
            this.txtNomModif.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(308, 143);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // GestionEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 569);
            this.Controls.Add(this.pnlModif);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblAccueil);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GestionEleve";
            this.Text = "Gestion Infirmerie | Accueil";
            this.Load += new System.EventHandler(this.GestionEleve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlModif.ResumeLayout(false);
            this.pnlModif.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblAccueil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
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
    }
}