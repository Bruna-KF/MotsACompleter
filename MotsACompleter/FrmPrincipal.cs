﻿using System;
using System.IO;
using System.Windows.Forms;
using VisualArrays;

namespace AppJeuEntrecroises
{
    /// <summary>
    /// Le but du jeu est de compléter la grille quadrillée avec les lettres qui forment le mot correspondant
    /// à la définition affichée dans la liste à droite.
    /// 
    /// </summary>
    public partial class FrmPrincipal : Form
    {
        public const string APP_INFO = "(Da Fonseca, Bruna)";

        public const int NBR_MOTS = 10;
        public const int INDEX_COL_DESCRIPTION = 0; // index de la colonne contenant la description d'un mot
        public const int INDEX_COL_MOT = 1; // index de la colonne contenant le mot à compléter
        public const int INDEX_COL_POSITION = 2; // index de la colonne contenant la position de la première lettre à révéler

        public string[,] m_tabLignes = new string[NBR_MOTS, 3]; // va contenir les informations du fichier

        #region (NE PAS MODIFIER)
        //==================================================================================================
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFO;

            ObtenirLaListeDesFichiers();
            if (cboListeFichiers.Items.Count > 0)
                cboListeFichiers.SelectedIndex = 0;

            PréparerNouvellePartie();
        }
        //==================================================================================================
        public FrmPrincipal(int version)
        {
            InitializeComponent();
            Text += APP_INFO;

            ObtenirLaListeDesFichiers();
            //if (cboListeDeMots.Items.Count > 0)
            //    cboListeDeMots.SelectedIndex = 0;

            vcaMots.Clear();
            vcaMots.Enabled = true;
            vcaMots.SelectedIndex = -1;
            vsaDescriptions.Clear();
        }
        //==================================================================================================
        /// <summary>
        /// Prépare une nouvelle partie, car la liste courante vient de changer
        /// </summary>
        public void cboListeDeMots_SelectedIndexChanged(object sender, EventArgs e)
        {
            PréparerNouvellePartie();
        }
        //==================================================================================================
        public void mnuFichierQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
        //==================================================================================================
        /// <summary>
        /// Prépare une nouvelle partie
        /// </summary>
        public void mnuFichierNouvellePartie_Click(object sender, EventArgs e)
        {
            PréparerNouvellePartie();
        }

        //==================================================================================================
        private void VcaMots_SelectedIndexChanged(object sender, EventArgs e)
        {
            mnuAideVoirLaLettre.Enabled = vcaMots.SelectedIndex != -1;
            mnuAideVoirLeMot.Enabled = vcaMots.SelectedIndex != -1;
        }
        #endregion

        #region ObtenirLaListeDesFichiers (NE PAS MODIFIER)
        //==================================================================================================
        /// <summary>
        /// Initialise le cboListeDeMots avec les noms des fichiers.
        /// Utilise la méthode Directory.GetFiles() pour obtenir les noms de fichiers
        /// </summary>
        public void ObtenirLaListeDesFichiers()
        {
            if (Directory.Exists("Mots"))
            {
                string[] tabSrcFichiers = Directory.GetFiles("Mots");

                foreach (string srcFichier in tabSrcFichiers)
                {
                    string[] tabÉlémentsSource = srcFichier.Split('\\');
                    string nomFichierAvecExt = tabÉlémentsSource[1];

                    string[] tabNomExt = nomFichierAvecExt.Split('.');
                    string nomFichierSansExt = tabNomExt[0];

                    cboListeFichiers.Items.Add(nomFichierSansExt);
                }
            }
        }
        #endregion

        #region PréparerNouvellePartie (NE PAS MODIFIER)
        //==================================================================================================
        /// <summary>
        /// Prépare le jeu pour une nouvelle partie
        /// </summary>
        public void PréparerNouvellePartie()
        {
            vcaMots.Clear();
            vcaMots.Enabled = true;
            vcaMots.SelectedIndex = -1;
            vsaDescriptions.Clear();

            ChargerLesLignesDuFichier();
            AfficherLesDescriptions();
            PlacerLesDeuxLettresÀRévéler();
            TronquerLesCellulesInutilisées();
        }
        #endregion

        #region ChargerLesLignesDuFichier (À COMPLÉTER)
        //==================================================================================================
        /// <summary>
        /// TODO 01 (30 pts) : Charger les lignes du fichier
        /// Le but de cette méthode est de lire les informations du fichier courant et de les placer
        /// dans le tableau m_tabLignes. Cette méthode ne doit rien afficher à l'écran.
        /// Le nom du fichier à lire est obtenu en utilisant l'élément sélectionné dans le cboListeFichiers
        /// </summary>
        public void ChargerLesLignesDuFichier()
        {
            // À COMPLÉTER...

            // Cette méthode recherche des informations et remplit le tableau m_tabLignes.
            string nomDuFichier = "Mots\\" + cboListeFichiers.Text + ".txt";
            StreamReader objFichier = new StreamReader(nomDuFichier);

            int rangée = 0;
            while (!objFichier.EndOfStream)
            {
                string ligneLue = objFichier.ReadLine();

                string[] tabInfos = ligneLue.Split('|');


                for (int colonne = 0; colonne < 3; colonne++)
                    m_tabLignes[rangée, colonne] = tabInfos[colonne].ToUpper();

                rangée++;

            }
            objFichier.Close();

        }
        #endregion

        #region AfficherLesDescriptions (À COMPLÉTER)
        //==================================================================================================
        /// <summary>
        /// TODO 02 (7 pts) : Afficher les descriptions
        /// En utilisant les informations dans m_tabLignes, cette méthode doit s'occuper
        /// d'afficher les 10 descriptions dans la grille vsaDescriptions
        /// </summary>
        public void AfficherLesDescriptions()
        {
            // À COMPLÉTER...
            // Cette méthode récupère les informations de la table m_tablignes et les place dans la grille vsaDescriptions (avec une boucle for). 

            for (int index = 0; index < vsaDescriptions.Length; index++)
            {
                vsaDescriptions[index] = m_tabLignes[index, INDEX_COL_DESCRIPTION];
            }

        }
        #endregion

        #region PlacerLesDeuxLettresÀRévéler (À COMPLÉTER)
        //==================================================================================================
        /// <summary>
        /// TODO 03 (8 pts) : Placer les deux lettres du mot à révéler
        /// Cette méthode va révéler exactement 2 lettres pour chacun des mots à compléter.
        /// Elle placera donc un total de 20 lettres dans la grille de caractères vcaMots. Les 2 lettres à 
        /// révéler sont toujours consécutives. L'index de la première des deux lettres à révéler est disponible
        /// dans la dernière colonne du tableau m_tabLignes. Les cellules des lettres révélées devront être
        /// désactivées afin d'empêcher la modification par le joueur.
        /// </summary>
        public void PlacerLesDeuxLettresÀRévéler()
        {
            // À COMPLÉTER...
            //Cette méthode permet à l'utilisateur d'avoir une idée du mot qu'il doit remplir dans la grille.


            for (int index = 0; index < vcaMots.RowCount; index++)
            {
                string mot = m_tabLignes[index, INDEX_COL_MOT];
                string position = m_tabLignes[index, INDEX_COL_POSITION];
                int Indexposition = int.Parse(position);



                vcaMots[index, Indexposition] = mot[Indexposition];
                vcaMots[index, Indexposition + 1] = mot[Indexposition + 1];
                vcaMots.DisableCell(index, Indexposition);
                vcaMots.DisableCell(index, Indexposition + 1);

            }
        }
        #endregion

        #region TronquerLesCellulesInutilisées (À COMPLÉTER)
        //==================================================================================================
        /// <summary>
        /// TODO 04 (10 pts) : Tronquer les cellules inutilisées
        /// Cette méthode s'occupe de noircir les cellules inutilisées dans la grille,
        /// cette situation se produit lorsque la longueur du mot à compléter est inférieure au nombre de colonnes
        /// de la grille. Pour noircir une cellule il s'agit simplement de lui assigner la valeur suivante :
        /// vcaMots.SpecialValue
        /// </summary>
        public void TronquerLesCellulesInutilisées()
        {
            // À COMPLÉTER...
            //Cette méthode désactive les espaces qui ne seront pas utilisés en fonction de la taille du mot.


            for (int row = 0; row < vcaMots.RowCount; row++)
            {
                string mot = m_tabLignes[row, INDEX_COL_MOT];

                for (int col = mot.Length; col < vcaMots.ColumnCount; col++)
                {
                    if (mot.Length < vcaMots.ColumnCount)
                    {
                        vcaMots[row, col] = vcaMots.SpecialValue;
                    }

                }
            }

        }
        #endregion

        #region MotEstValide (À COMPLÉTER)
        //==================================================================================================
        /// <summary>
        /// TODO 05 (7 pts) : Vérifier que le mot dans la grille correspond au mot attendu
        /// Cette méthode doit retourner vrai ou faux selon que le mot dans la grille vcaMots
        /// à la rangée pRangée est identique au mot pMot. Vous devez donc comparer chacun des caractères dans la grille
        /// à la rangée pRangée avec ceux de la chaîne pMot contenant la solution du mot à compléter. Aussitôt
        /// qu'un caractère dans la grille est différent du mot à compléter la méthode retourne false.
        /// </summary>
        /// <param name="pRangée">Rangée sur laquelle se trouve le mot à vérifier</param>
        /// <param name="pMot">Solution du mot à compléter</param>
        /// <returns></returns>
        public bool MotEstValide(int pRangée, string pMot)
        {
            // À COMPLÉTER...
            //Cette méthode compare chaque lettre de la grille pour savoir si le mot est correct ou non.

            pMot = m_tabLignes[pRangée, INDEX_COL_MOT];


            for (int col = 0; col < pMot.Length; col++)
            {

                if (vcaMots[pRangée, col] != pMot[col])
                { return false; }

            }
                           
            return true;


        }
        #endregion

        #region DésactiverMot (À COMPLÉTER)
        //==================================================================================================
        /// <summary>
        /// TODO 06 (7 pts) : Désactiver les cellules du mot complété
        /// Désactive toutes les cellules dans vcaMots contenant les caractères du mot à compléter 
        /// ainsi que sa description dans vsaDescriptions.
        /// </summary>
        /// <param name="pRangée">Rangée sur laquelle se trouve le mot à vérifier</param>     
        /// <param name="pLongueurMot">Nombre de caractères du mot à compléter</param>
        public void DésactiverMot(int pRangée, int pLongueurMot)
        {
            // À COMPLÉTER...
            //Cette méthode vérifie si le mot est complet, puis le désactive.

            string mot = m_tabLignes[pRangée, INDEX_COL_MOT];
            pLongueurMot = mot.Length;



            if (MotEstValide(pRangée, mot))
            {
                for (int col = 0; col < mot.Length; col++)
                {
                    vcaMots.DisableCell(pRangée, col); 
                    vsaDescriptions.DisableCell(pRangée);
                }
            }

        }

        
        #endregion

        #region vcaMots_ValueChanged
        //==================================================================================================
        /// <summary>
        ///  À chaque modification dans la grille vcaMots, on vérifie si le mot a été trouvé
        /// </summary>
        public void vcaMots_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int rangée = e.Address.Row; // NE PAS MODIFIER
            int colonne = e.Address.Column; // NE PAS MODIFIER

            if (vcaMots.SelectedIndex != -1)
            {
                vcaMots[rangée, colonne] = char.ToUpper(vcaMots[rangée, colonne]);

                // TODO 07 (8 pts) : Valider le mot saisi
                // L'utilisateur vient juste de saisir un caractère dans la grille vcaMots. En utilisant les méthodes
                // MotEstValide ainsi que DésactiverMot, désactiver le mot sur la rangée courante si celui-ci est valide.

                // À COMPLÉTER...
                
                
                string Mot = m_tabLignes[rangée, INDEX_COL_MOT];
                if (MotEstValide(rangée, Mot))
                {
                    DésactiverMot(rangée, colonne);
                }

            }
        }
        #endregion

        #region MnuAideVoirLaLettre_Click (À COMPLÉTER)
        //==================================================================================================
        /// <summary>
        /// TODO 08 (7 pts) : Voir la lettre
        /// Utiliser les variables rangée, colonne et m_tabLignes afin d'afficher la lettre de la solution 
        /// du mot à compléter. Désactiver la cellule sélectionnée.
        /// </summary>
        public void MnuAideVoirLaLettre_Click(object sender, EventArgs e)
        {
            int rangée = vcaMots.SelectedAddress.Row; // NE PAS MODIFIER
            int colonne = vcaMots.SelectedAddress.Column; // NE PAS MODIFIER

            // À COMPLÉTER...
            //Cette méthode aide l'utilisateur et donne une lettre qui fait partie du mot.

            string mot = m_tabLignes[rangée, INDEX_COL_MOT];
            
            vcaMots[rangée, colonne] = mot[colonne];

            vcaMots.DisableCell(rangée, colonne);
        }
        #endregion

        #region MnuAideVoirLeMot_Click (À COMPLÉTER)
        //==================================================================================================
        /// <summary>
        /// TODO 09 (8 pts) : Voir le mot
        /// Utiliser les variables rangée et m_tabLignes afin d'afficher et désactiver chacune des lettres 
        /// de la solution du mot à compléter. Désactiver la description du mot affiché.
        /// </summary>
        public void MnuAideVoirLeMot_Click(object sender, EventArgs e)
        {
            int rangée = vcaMots.SelectedAddress.Row; // NE PAS MODIFIER

            // À COMPLÉTER...
            //aide l'utilisateur à renvoyer un mot de la grille.


            string mot = m_tabLignes[rangée, INDEX_COL_MOT];

            for (int col = 0; col < mot.Length; col++)
            {
                vcaMots[rangée, col] = mot[col];
                vcaMots.DisableCell(rangée, col);
                vsaDescriptions.DisableCell(rangée);
            }


        }
        #endregion

        #region MnuAideVoirTousLesMots_Click (À COMPLÉTER)
        //==================================================================================================
        /// <summary>
        /// TODO 10 (8 pts) : Voir tous les mots
        /// Afficher tous les caractères de tous les mots à compléter, ne pas oublier de désactiver les cellules
        /// dans la grille vcaMots ainsi que toutes les descriptions dans vsaDescriptions.
        /// </summary>
        public void MnuAideVoirTousLesMots_Click(object sender, EventArgs e)
        {
            // À COMPLÉTER...
            // Renvoie tous les mots du jeu et désactive les grilles.

            for (int row = 0; row < vcaMots.RowCount; row++)
            {
                string mot = m_tabLignes[row, INDEX_COL_MOT];
               
                for (int col = 0; col < mot.Length; col++)
                {
                    vcaMots[row, col] = mot[col];
                    vcaMots.DisableCell(row, col);
                    vsaDescriptions.DisableCell(row);
                }
            }

        }
        #endregion

    }
}
