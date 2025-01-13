using System;
using System.Windows.Forms;
using Serilog;
using Serilog.Formatting.Json;

namespace NombreCacheGraphique
{
    public partial class FrmNombreCache : Form
    {
        // déclaration globale
        private int phase;  // phase 1 : saisie du nombre à chercher ; pahase 2 : recherche
        private int valeurAChercher; // contiendra la valeur à chercher
        private int nbEssai; // nombre d'essais pour trouver la valeur

        /// <summary>
        /// initialisation des composants graphiques
        /// </summary>
        public FrmNombreCache()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Chargement de la fenêtre : initialisations pour commencer le jeu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmNombreCache_Load(object sender, EventArgs e)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .WriteTo.Console()
                .WriteTo.File(new JsonFormatter(),"logs/log.txt", rollingInterval: RollingInterval.Day)
                .WriteTo.File("logs/errorlog.txt", 
                restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Information)
                .WriteTo.EventLog("NombreCacheGraphique", manageEventSource: true,
                restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Fatal)
                .CreateLogger();
            BtnRejouer_Click(null, null);
        }

        /// <summary>
        /// Réinitialisations au début du jeu ou au début des tentatives
        /// </summary>
        private void Initialiser()
        {
            if (phase == 1)
            {
                grpValeur.Text = "Valeur (entre 1 et 100)";
                grpValeur.Enabled = true;
                grpReponse.Visible = false;
            }
            else
            {
                Log.Debug("méthode initialiser : else du test sur phase qui doit être à 2. phase = {0}", phase);
                grpValeur.Text = "Essai  (entre 1 et 100)";
                nbEssai = 0;
                grpReponse.Text = "";
                grpReponse.Visible = true;
            }
            lblMessage.Text = "";
            EffacerZoneSaisie();
        }

        /// <summary>
        /// Clic sur le bouton btnRejouer (flèche ronde) : démarrage d'un nouveau jeu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRejouer_Click(object sender, EventArgs e)
        {
            phase = 1;
            Initialiser();
        }

        /// <summary>
        /// Clic sur le bouton btnQuitter : fermeture de l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Clic sur le bouton btnValider (OK)
        /// Si 1ère phase de jeu : contrôle le nombre(entre 1 et 100) et lance la 2ème phase(recherche)
        /// Si 2ème phase de jeu : compare l'essai avec le nombre de départ et affiche le message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnValider_Click(object sender, EventArgs e)
        {
            //  contrôle si la valeur saisie est bien un entier
            try
            {
                int valeur = int.Parse(txtValeur.Text);
                // contrôle si le nombre est entre 1 et 100
                if (valeur < 1 || valeur > 100)
                {
                    EffacerZoneSaisie();
                }
                else
                {
                    if (phase == 1)
                    {
                        // mémorisation de la valeur à chercher
                        valeurAChercher = valeur;
                        // passage à la phase 2
                        phase = 2;
                        Initialiser();
                    }
                    else
                    {
                        // affiche le nombre d'essais
                        nbEssai++;
                        grpReponse.Text = "Essai n°" + nbEssai;
                        // comparaison et affichage du message correspondant
                        if (valeur == valeurAChercher)
                        {
                            lblMessage.Text = "Bravo !!! C'était bien " + valeurAChercher;
                            EffacerZoneSaisie();
                            grpValeur.Enabled = false;
                            btnRejouer.Focus();
                        }
                        else
                        {
                            if (valeur < valeurAChercher)
                            {
                                lblMessage.Text = valeur + " est trop petit";
                            }
                            else
                            {
                                lblMessage.Text = valeur + " est trop grand";
                            }
                            EffacerZoneSaisie();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Log.Information("erreur de convrsion en int de la valeur saisie. valeur = {0}", txtValeur.Text);
                Log.Fatal(ex, "erreur de conversion en int de la valeur saisie");
                EffacerZoneSaisie();
            }
        }

        /// <summary>
        /// Efface la zone de saisie et repositionne le curseur
        /// </summary>
        private void EffacerZoneSaisie()
        {
            txtValeur.Text = "";
            txtValeur.Focus();
        }

        /// <summary>
        /// Validation dans txtValeur
        /// Même effet que le clic sur le bouton ok
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtValeur_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                BtnValider_Click(null, null);
            }
        }
    }
}
