namespace NombreCacheGraphique
{
    partial class FrmNombreCache
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
            this.txtValeur = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.grpValeur = new System.Windows.Forms.GroupBox();
            this.grpReponse = new System.Windows.Forms.GroupBox();
            this.btnRejouer = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.grpValeur.SuspendLayout();
            this.grpReponse.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtValeur
            // 
            this.txtValeur.Location = new System.Drawing.Point(6, 19);
            this.txtValeur.Name = "txtValeur";
            this.txtValeur.Size = new System.Drawing.Size(108, 20);
            this.txtValeur.TabIndex = 0;
            this.txtValeur.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValeur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValeur_KeyPress);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(6, 16);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(49, 13);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "message";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(120, 19);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(36, 20);
            this.btnValider.TabIndex = 3;
            this.btnValider.Text = "OK";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.BtnValider_Click);
            // 
            // grpValeur
            // 
            this.grpValeur.Controls.Add(this.txtValeur);
            this.grpValeur.Controls.Add(this.btnValider);
            this.grpValeur.Location = new System.Drawing.Point(12, 12);
            this.grpValeur.Name = "grpValeur";
            this.grpValeur.Size = new System.Drawing.Size(168, 50);
            this.grpValeur.TabIndex = 0;
            this.grpValeur.TabStop = false;
            // 
            // grpReponse
            // 
            this.grpReponse.Controls.Add(this.lblMessage);
            this.grpReponse.Location = new System.Drawing.Point(12, 68);
            this.grpReponse.Name = "grpReponse";
            this.grpReponse.Size = new System.Drawing.Size(168, 42);
            this.grpReponse.TabIndex = 6;
            this.grpReponse.TabStop = false;
            // 
            // btnRejouer
            // 
            this.btnRejouer.Image = global::NombreCacheGraphique.Properties.Resources.playagain;
            this.btnRejouer.Location = new System.Drawing.Point(186, 12);
            this.btnRejouer.Name = "btnRejouer";
            this.btnRejouer.Size = new System.Drawing.Size(46, 46);
            this.btnRejouer.TabIndex = 7;
            this.btnRejouer.UseVisualStyleBackColor = true;
            this.btnRejouer.Click += new System.EventHandler(this.BtnRejouer_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Image = global::NombreCacheGraphique.Properties.Resources.quitter;
            this.btnQuitter.Location = new System.Drawing.Point(186, 64);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(46, 46);
            this.btnQuitter.TabIndex = 4;
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // FrmNombreCache
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 120);
            this.Controls.Add(this.btnRejouer);
            this.Controls.Add(this.grpReponse);
            this.Controls.Add(this.grpValeur);
            this.Controls.Add(this.btnQuitter);
            this.Name = "FrmNombreCache";
            this.Text = "nombre caché";
            this.Load += new System.EventHandler(this.FrmNombreCache_Load);
            this.grpValeur.ResumeLayout(false);
            this.grpValeur.PerformLayout();
            this.grpReponse.ResumeLayout(false);
            this.grpReponse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtValeur;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.GroupBox grpValeur;
        private System.Windows.Forms.GroupBox grpReponse;
        private System.Windows.Forms.Button btnRejouer;
    }
}

