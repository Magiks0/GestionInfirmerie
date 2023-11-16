
namespace InfirmerieGUI
{
    partial class GestionEleve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionEleve));
            this.lblAccueil = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.visitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicamentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.élèvesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prénom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classe = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.date_naissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_parent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_eleve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAccueil
            // 
            this.lblAccueil.AutoSize = true;
            this.lblAccueil.Font = new System.Drawing.Font("Agency FB", 14F);
            this.lblAccueil.Location = new System.Drawing.Point(658, 33);
            this.lblAccueil.Name = "lblAccueil";
            this.lblAccueil.Size = new System.Drawing.Size(59, 28);
            this.lblAccueil.TabIndex = 0;
            this.lblAccueil.Text = "Élèves";
            this.lblAccueil.Click += new System.EventHandler(this.lblAccueil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Prénom,
            this.classe,
            this.date_naissance,
            this.sant,
            this.num_parent,
            this.num_eleve});
            this.dataGridView1.Location = new System.Drawing.Point(255, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(872, 376);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(892, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Supprimer";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LemonChiffon;
            this.button2.Location = new System.Drawing.Point(986, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Confirmer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGreen;
            this.button3.Location = new System.Drawing.Point(1093, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 30);
            this.button3.TabIndex = 4;
            this.button3.Text = "Ajouter";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visitesToolStripMenuItem,
            this.médicamentsToolStripMenuItem,
            this.élèvesToolStripMenuItem,
            this.statistiquesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(200, 529);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // visitesToolStripMenuItem
            // 
            this.visitesToolStripMenuItem.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("visitesToolStripMenuItem.Image")));
            this.visitesToolStripMenuItem.Name = "visitesToolStripMenuItem";
            this.visitesToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.visitesToolStripMenuItem.Text = "Visites";
            // 
            // médicamentsToolStripMenuItem
            // 
            this.médicamentsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.médicamentsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("médicamentsToolStripMenuItem.Image")));
            this.médicamentsToolStripMenuItem.Name = "médicamentsToolStripMenuItem";
            this.médicamentsToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.médicamentsToolStripMenuItem.Text = "Médicaments";
            // 
            // statistiquesToolStripMenuItem
            // 
            this.statistiquesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("statistiquesToolStripMenuItem.Image")));
            this.statistiquesToolStripMenuItem.Name = "statistiquesToolStripMenuItem";
            this.statistiquesToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.statistiquesToolStripMenuItem.Text = "Statistiques";
            // 
            // élèvesToolStripMenuItem
            // 
            this.élèvesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("élèvesToolStripMenuItem.Image")));
            this.élèvesToolStripMenuItem.Name = "élèvesToolStripMenuItem";
            this.élèvesToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.élèvesToolStripMenuItem.Text = "Élèves";
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 6;
            this.Nom.Name = "Nom";
            this.Nom.Width = 125;
            // 
            // Prénom
            // 
            this.Prénom.HeaderText = "Prénom";
            this.Prénom.MinimumWidth = 6;
            this.Prénom.Name = "Prénom";
            this.Prénom.Width = 125;
            // 
            // classe
            // 
            this.classe.HeaderText = "Classe";
            this.classe.MinimumWidth = 6;
            this.classe.Name = "classe";
            this.classe.Width = 125;
            // 
            // date_naissance
            // 
            this.date_naissance.HeaderText = "Date de naissance";
            this.date_naissance.MinimumWidth = 6;
            this.date_naissance.Name = "date_naissance";
            this.date_naissance.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.date_naissance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.date_naissance.Width = 125;
            // 
            // sant
            // 
            this.sant.HeaderText = "Santé de l\'élève";
            this.sant.MinimumWidth = 6;
            this.sant.Name = "sant";
            this.sant.Width = 125;
            // 
            // num_parent
            // 
            this.num_parent.HeaderText = "Numéro de tél du Parent";
            this.num_parent.MinimumWidth = 6;
            this.num_parent.Name = "num_parent";
            this.num_parent.Width = 125;
            // 
            // num_eleve
            // 
            this.num_eleve.HeaderText = "Numéro de tel de l\'élève";
            this.num_eleve.MinimumWidth = 6;
            this.num_eleve.Name = "num_eleve";
            this.num_eleve.Width = 125;
            // 
            // GestionEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 529);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblAccueil);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GestionEleve";
            this.Text = "Gestion Infirmerie | Accueil";
            this.Load += new System.EventHandler(this.GestionEleve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prénom;
        private System.Windows.Forms.DataGridViewComboBoxColumn classe;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_naissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn sant;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_parent;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_eleve;
    }
}