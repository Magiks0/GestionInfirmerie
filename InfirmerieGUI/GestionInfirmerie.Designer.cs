
namespace InfirmerieGUI
{
    partial class GestionInfirmerie 
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionInfirmerie));
            this.pageTitle = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.loginId = new System.Windows.Forms.TextBox();
            this.loginPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pageTitle
            // 
            this.pageTitle.AutoSize = true;
            this.pageTitle.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageTitle.Location = new System.Drawing.Point(502, 139);
            this.pageTitle.Name = "pageTitle";
            this.pageTitle.Size = new System.Drawing.Size(178, 45);
            this.pageTitle.TabIndex = 0;
            this.pageTitle.Text = "Connexion";
            this.pageTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(369, 235);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(122, 29);
            this.labelId.TabIndex = 1;
            this.labelId.Text = "Identifiant :";
            // 
            // loginId
            // 
            this.loginId.Location = new System.Drawing.Point(473, 237);
            this.loginId.Name = "loginId";
            this.loginId.Size = new System.Drawing.Size(204, 24);
            this.loginId.TabIndex = 2;
            this.loginId.TextChanged += new System.EventHandler(this.loginId_TextChanged);
            // 
            // loginPassword
            // 
            this.loginPassword.Location = new System.Drawing.Point(473, 284);
            this.loginPassword.Name = "loginPassword";
            this.loginPassword.PasswordChar = '*';
            this.loginPassword.Size = new System.Drawing.Size(204, 24);
            this.loginPassword.TabIndex = 4;
            this.loginPassword.TextChanged += new System.EventHandler(this.loginPassword_TextChanged);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(347, 279);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(151, 29);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Mot de Passe :";
            this.labelPassword.Click += new System.EventHandler(this.label3_Click);
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.connectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.connectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.connectButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.connectButton.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectButton.Location = new System.Drawing.Point(496, 346);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(145, 40);
            this.connectButton.TabIndex = 5;
            this.connectButton.Text = "Connexion";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // GestionInfirmerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 529);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.loginPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.loginId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.pageTitle);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestionInfirmerie";
            this.Text = "GestionInfirmerie";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pageTitle;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox loginId;
        private System.Windows.Forms.TextBox loginPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button connectButton;
    }
}

