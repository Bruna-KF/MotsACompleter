namespace AppJeuEntrecroises
{
    partial class FrmPrincipal
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
            this.vcaMots = new VisualArrays.VisualCharArray();
            this.vsaDescriptions = new VisualArrays.VisualStringArray();
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierNouvellePartie = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSéparateur = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAide = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAideVoirLaLettre = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAideVoirLeMot = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAideVoirTousLesMots = new System.Windows.Forms.ToolStripMenuItem();
            this.lblListeDesMots = new System.Windows.Forms.Label();
            this.cboListeFichiers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // vcaMots
            // 
            this.vcaMots.AutoNextIndex = true;
            this.vcaMots.BackColor = System.Drawing.Color.White;
            this.vcaMots.CellMargin = 0;
            this.vcaMots.CellSize = new System.Drawing.Size(33, 34);
            this.vcaMots.ColumnCount = 9;
            this.vcaMots.ColumnHeader.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vcaMots.ColumnHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vcaMots.ColumnHeader.Style = VisualArrays.enuHeaderBkgStyle.None;
            this.vcaMots.ColumnHeader.ValueStyle = VisualArrays.enuDataStyle.IndexBase1;
            this.vcaMots.DefaultValue = ' ';
            this.vcaMots.DisabledAppearance.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.vcaMots.DisabledAppearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vcaMots.DisabledAppearance.Style = VisualArrays.enuBkgStyle.FillShape;
            this.vcaMots.DisabledAppearance.TextColor = System.Drawing.Color.Gainsboro;
            this.vcaMots.EnabledAppearance.BackgroundColor = System.Drawing.Color.White;
            this.vcaMots.EnabledAppearance.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vcaMots.EnabledAppearance.TextColor = System.Drawing.Color.DimGray;
            this.vcaMots.GridAppearance.Color = System.Drawing.Color.Black;
            this.vcaMots.Location = new System.Drawing.Point(12, 113);
            this.vcaMots.Name = "vcaMots";
            this.vcaMots.Padding = new System.Windows.Forms.Padding(2);
            this.vcaMots.RowCount = 10;
            this.vcaMots.RowHeader.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vcaMots.RowHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vcaMots.RowHeader.Style = VisualArrays.enuHeaderBkgStyle.None;
            this.vcaMots.RowHeader.ValueStyle = VisualArrays.enuDataStyle.IndexBase1;
            this.vcaMots.RowHeader.Visible = true;
            this.vcaMots.SelectionMode = System.Windows.Forms.SelectionMode.One;
            this.vcaMots.Size = new System.Drawing.Size(331, 355);
            this.vcaMots.SpecialValue = '.';
            this.vcaMots.SpecialValueAppearance.BackgroundColor = System.Drawing.Color.Black;
            this.vcaMots.SpecialValueAppearance.Enabled = false;
            this.vcaMots.SpecialValueAppearance.Style = VisualArrays.enuBkgStyle.FillShape;
            this.vcaMots.TabIndex = 0;
            this.vcaMots.ValueChanged += new System.EventHandler<VisualArrays.ValueChangedEventArgs>(this.vcaMots_ValueChanged);
            this.vcaMots.SelectedIndexChanged += new System.EventHandler(this.VcaMots_SelectedIndexChanged);
            // 
            // vsaDescriptions
            // 
            this.vsaDescriptions.BackColor = System.Drawing.Color.White;
            this.vsaDescriptions.CellContentAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vsaDescriptions.CellSize = new System.Drawing.Size(378, 30);
            this.vsaDescriptions.ColumnCount = 1;
            this.vsaDescriptions.DefaultValue = "";
            this.vsaDescriptions.DisabledAppearance.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.vsaDescriptions.DisabledAppearance.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsaDescriptions.DisabledAppearance.StrikeAppearance.Color = System.Drawing.Color.Teal;
            this.vsaDescriptions.DisabledAppearance.StrikeAppearance.PenWidth = 2;
            this.vsaDescriptions.DisabledAppearance.Style = VisualArrays.enuBkgStyle.FillShape;
            this.vsaDescriptions.DisabledAppearance.TextColor = System.Drawing.Color.Gainsboro;
            this.vsaDescriptions.EnabledAppearance.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsaDescriptions.EnabledAppearance.Style = VisualArrays.enuBkgStyle.None;
            this.vsaDescriptions.EnabledAppearance.TextColor = System.Drawing.Color.Black;
            this.vsaDescriptions.Location = new System.Drawing.Point(349, 113);
            this.vsaDescriptions.Name = "vsaDescriptions";
            this.vsaDescriptions.Padding = new System.Windows.Forms.Padding(2);
            this.vsaDescriptions.RowCount = 10;
            this.vsaDescriptions.RowHeader.ForeColor = System.Drawing.Color.White;
            this.vsaDescriptions.Size = new System.Drawing.Size(388, 355);
            this.vsaDescriptions.TabIndex = 1;
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier,
            this.mnuAide});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(749, 24);
            this.mnuPrincipal.TabIndex = 10;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuFichier
            // 
            this.mnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichierNouvellePartie,
            this.mnuSéparateur,
            this.mnuFichierQuitter});
            this.mnuFichier.Name = "mnuFichier";
            this.mnuFichier.Size = new System.Drawing.Size(54, 20);
            this.mnuFichier.Text = "&Fichier";
            // 
            // mnuFichierNouvellePartie
            // 
            this.mnuFichierNouvellePartie.Name = "mnuFichierNouvellePartie";
            this.mnuFichierNouvellePartie.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuFichierNouvellePartie.Size = new System.Drawing.Size(197, 22);
            this.mnuFichierNouvellePartie.Text = "&Nouvelle Partie";
            this.mnuFichierNouvellePartie.Click += new System.EventHandler(this.mnuFichierNouvellePartie_Click);
            // 
            // mnuSéparateur
            // 
            this.mnuSéparateur.Name = "mnuSéparateur";
            this.mnuSéparateur.Size = new System.Drawing.Size(194, 6);
            // 
            // mnuFichierQuitter
            // 
            this.mnuFichierQuitter.Name = "mnuFichierQuitter";
            this.mnuFichierQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuFichierQuitter.Size = new System.Drawing.Size(197, 22);
            this.mnuFichierQuitter.Text = "&Quitter";
            this.mnuFichierQuitter.Click += new System.EventHandler(this.mnuFichierQuitter_Click);
            // 
            // mnuAide
            // 
            this.mnuAide.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAideVoirLaLettre,
            this.mnuAideVoirLeMot,
            this.mnuAideVoirTousLesMots});
            this.mnuAide.Name = "mnuAide";
            this.mnuAide.Size = new System.Drawing.Size(43, 20);
            this.mnuAide.Text = "&Aide";
            // 
            // mnuAideVoirLaLettre
            // 
            this.mnuAideVoirLaLettre.Enabled = false;
            this.mnuAideVoirLaLettre.Name = "mnuAideVoirLaLettre";
            this.mnuAideVoirLaLettre.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.mnuAideVoirLaLettre.Size = new System.Drawing.Size(208, 22);
            this.mnuAideVoirLaLettre.Text = "Voir la lettre";
            this.mnuAideVoirLaLettre.Click += new System.EventHandler(this.MnuAideVoirLaLettre_Click);
            // 
            // mnuAideVoirLeMot
            // 
            this.mnuAideVoirLeMot.Enabled = false;
            this.mnuAideVoirLeMot.Name = "mnuAideVoirLeMot";
            this.mnuAideVoirLeMot.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.mnuAideVoirLeMot.Size = new System.Drawing.Size(208, 22);
            this.mnuAideVoirLeMot.Text = "Voir le mot";
            this.mnuAideVoirLeMot.Click += new System.EventHandler(this.MnuAideVoirLeMot_Click);
            // 
            // mnuAideVoirTousLesMots
            // 
            this.mnuAideVoirTousLesMots.Name = "mnuAideVoirTousLesMots";
            this.mnuAideVoirTousLesMots.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.mnuAideVoirTousLesMots.Size = new System.Drawing.Size(208, 22);
            this.mnuAideVoirTousLesMots.Text = "Voir tous les mots";
            this.mnuAideVoirTousLesMots.Click += new System.EventHandler(this.MnuAideVoirTousLesMots_Click);
            // 
            // lblListeDesMots
            // 
            this.lblListeDesMots.AutoSize = true;
            this.lblListeDesMots.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListeDesMots.Location = new System.Drawing.Point(34, 50);
            this.lblListeDesMots.Name = "lblListeDesMots";
            this.lblListeDesMots.Size = new System.Drawing.Size(155, 16);
            this.lblListeDesMots.TabIndex = 11;
            this.lblListeDesMots.Text = "Liste courante des mots :";
            // 
            // cboListeFichiers
            // 
            this.cboListeFichiers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboListeFichiers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboListeFichiers.FormattingEnabled = true;
            this.cboListeFichiers.Location = new System.Drawing.Point(195, 47);
            this.cboListeFichiers.Name = "cboListeFichiers";
            this.cboListeFichiers.Size = new System.Drawing.Size(148, 24);
            this.cboListeFichiers.TabIndex = 12;
            this.cboListeFichiers.SelectedIndexChanged += new System.EventHandler(this.cboListeDeMots_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Description du mot à compléter :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mots à compléter par le joueur :";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 478);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboListeFichiers);
            this.Controls.Add(this.lblListeDesMots);
            this.Controls.Add(this.mnuPrincipal);
            this.Controls.Add(this.vsaDescriptions);
            this.Controls.Add(this.vcaMots);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mots à compléter  ";
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public VisualArrays.VisualCharArray vcaMots;
        public VisualArrays.VisualStringArray vsaDescriptions;
        public System.Windows.Forms.MenuStrip mnuPrincipal;
        public System.Windows.Forms.ToolStripMenuItem mnuFichier;
        public System.Windows.Forms.ToolStripMenuItem mnuFichierNouvellePartie;
        public System.Windows.Forms.ToolStripSeparator mnuSéparateur;
        public System.Windows.Forms.ToolStripMenuItem mnuFichierQuitter;
        public System.Windows.Forms.ToolStripMenuItem mnuAide;
        public System.Windows.Forms.Label lblListeDesMots;
        public System.Windows.Forms.ComboBox cboListeFichiers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem mnuAideVoirLaLettre;
        private System.Windows.Forms.ToolStripMenuItem mnuAideVoirLeMot;
        private System.Windows.Forms.ToolStripMenuItem mnuAideVoirTousLesMots;
    }
}

