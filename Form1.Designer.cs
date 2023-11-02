namespace Clock
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startStopButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.timerScreen = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.historiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voirLhistoriqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viderLhistoriqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerLhistoriqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paramètresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.désactiverLesMillisecondesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.désactiverLesSecondesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.désactiverLesMinutesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.désactiverLesHeuresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startStopButton
            // 
            this.startStopButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.startStopButton.Location = new System.Drawing.Point(59, 89);
            this.startStopButton.Name = "startStopButton";
            this.startStopButton.Size = new System.Drawing.Size(75, 23);
            this.startStopButton.TabIndex = 0;
            this.startStopButton.Text = "Démarrer";
            this.startStopButton.UseVisualStyleBackColor = true;
            this.startStopButton.Click += new System.EventHandler(this.startStopButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.ForeColor = System.Drawing.Color.Red;
            this.resetButton.Location = new System.Drawing.Point(223, 89);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "Réinitialiser";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // timerScreen
            // 
            this.timerScreen.Location = new System.Drawing.Point(94, 43);
            this.timerScreen.Name = "timerScreen";
            this.timerScreen.ReadOnly = true;
            this.timerScreen.Size = new System.Drawing.Size(164, 20);
            this.timerScreen.TabIndex = 2;
            this.timerScreen.Text = "00:00:00:00";
            this.timerScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historiqueToolStripMenuItem,
            this.applicationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(348, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // historiqueToolStripMenuItem
            // 
            this.historiqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voirLhistoriqueToolStripMenuItem,
            this.viderLhistoriqueToolStripMenuItem,
            this.enregistrerLhistoriqueToolStripMenuItem});
            this.historiqueToolStripMenuItem.Name = "historiqueToolStripMenuItem";
            this.historiqueToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.historiqueToolStripMenuItem.Text = "Historique";
            // 
            // voirLhistoriqueToolStripMenuItem
            // 
            this.voirLhistoriqueToolStripMenuItem.Name = "voirLhistoriqueToolStripMenuItem";
            this.voirLhistoriqueToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.voirLhistoriqueToolStripMenuItem.Text = "Voir l\'historique";
            this.voirLhistoriqueToolStripMenuItem.Click += new System.EventHandler(this.voirLhistoriqueToolStripMenuItem_Click);
            // 
            // viderLhistoriqueToolStripMenuItem
            // 
            this.viderLhistoriqueToolStripMenuItem.Name = "viderLhistoriqueToolStripMenuItem";
            this.viderLhistoriqueToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.viderLhistoriqueToolStripMenuItem.Text = "Vider l\'historique";
            this.viderLhistoriqueToolStripMenuItem.Click += new System.EventHandler(this.viderLhistoriqueToolStripMenuItem_Click);
            // 
            // enregistrerLhistoriqueToolStripMenuItem
            // 
            this.enregistrerLhistoriqueToolStripMenuItem.Name = "enregistrerLhistoriqueToolStripMenuItem";
            this.enregistrerLhistoriqueToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.enregistrerLhistoriqueToolStripMenuItem.Text = "Enregistrer l\'historique";
            this.enregistrerLhistoriqueToolStripMenuItem.Click += new System.EventHandler(this.enregistrerLhistoriqueToolStripMenuItem_Click);
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paramètresToolStripMenuItem,
            this.aProposToolStripMenuItem,
            this.quitterToolStripMenuItem1});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.applicationToolStripMenuItem.Text = "Application";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aProposToolStripMenuItem.Text = "A propos";
            this.aProposToolStripMenuItem.Click += new System.EventHandler(this.aProposToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem1
            // 
            this.quitterToolStripMenuItem1.Name = "quitterToolStripMenuItem1";
            this.quitterToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.quitterToolStripMenuItem1.Text = "Quitter";
            this.quitterToolStripMenuItem1.Click += new System.EventHandler(this.quitterToolStripMenuItem1_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // paramètresToolStripMenuItem
            // 
            this.paramètresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.désactiverLesMillisecondesToolStripMenuItem,
            this.désactiverLesSecondesToolStripMenuItem,
            this.désactiverLesMinutesToolStripMenuItem,
            this.désactiverLesHeuresToolStripMenuItem});
            this.paramètresToolStripMenuItem.Name = "paramètresToolStripMenuItem";
            this.paramètresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.paramètresToolStripMenuItem.Text = "Paramètres";
            // 
            // désactiverLesMillisecondesToolStripMenuItem
            // 
            this.désactiverLesMillisecondesToolStripMenuItem.Checked = true;
            this.désactiverLesMillisecondesToolStripMenuItem.CheckOnClick = true;
            this.désactiverLesMillisecondesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.désactiverLesMillisecondesToolStripMenuItem.Name = "désactiverLesMillisecondesToolStripMenuItem";
            this.désactiverLesMillisecondesToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.désactiverLesMillisecondesToolStripMenuItem.Text = "Affichage des millisecondes";
            this.désactiverLesMillisecondesToolStripMenuItem.Click += new System.EventHandler(this.désactiverLesMillisecondesToolStripMenuItem_Click);
            // 
            // désactiverLesSecondesToolStripMenuItem
            // 
            this.désactiverLesSecondesToolStripMenuItem.Checked = true;
            this.désactiverLesSecondesToolStripMenuItem.CheckOnClick = true;
            this.désactiverLesSecondesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.désactiverLesSecondesToolStripMenuItem.Name = "désactiverLesSecondesToolStripMenuItem";
            this.désactiverLesSecondesToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.désactiverLesSecondesToolStripMenuItem.Text = "Affichage des secondes";
            this.désactiverLesSecondesToolStripMenuItem.Click += new System.EventHandler(this.désactiverLesSecondesToolStripMenuItem_Click);
            // 
            // désactiverLesMinutesToolStripMenuItem
            // 
            this.désactiverLesMinutesToolStripMenuItem.Checked = true;
            this.désactiverLesMinutesToolStripMenuItem.CheckOnClick = true;
            this.désactiverLesMinutesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.désactiverLesMinutesToolStripMenuItem.Enabled = false;
            this.désactiverLesMinutesToolStripMenuItem.Name = "désactiverLesMinutesToolStripMenuItem";
            this.désactiverLesMinutesToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.désactiverLesMinutesToolStripMenuItem.Text = "Affichage des minutes (Soon)";
            this.désactiverLesMinutesToolStripMenuItem.Click += new System.EventHandler(this.désactiverLesMinutesToolStripMenuItem_Click);
            // 
            // désactiverLesHeuresToolStripMenuItem
            // 
            this.désactiverLesHeuresToolStripMenuItem.Checked = true;
            this.désactiverLesHeuresToolStripMenuItem.CheckOnClick = true;
            this.désactiverLesHeuresToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.désactiverLesHeuresToolStripMenuItem.Enabled = false;
            this.désactiverLesHeuresToolStripMenuItem.Name = "désactiverLesHeuresToolStripMenuItem";
            this.désactiverLesHeuresToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.désactiverLesHeuresToolStripMenuItem.Text = "Affichage des heures (Soon)";
            this.désactiverLesHeuresToolStripMenuItem.Click += new System.EventHandler(this.désactiverLesHeuresToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 139);
            this.Controls.Add(this.timerScreen);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.startStopButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clock V0.1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startStopButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox timerScreen;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem historiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voirLhistoriqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viderLhistoriqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerLhistoriqueToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem paramètresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem désactiverLesMillisecondesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem désactiverLesSecondesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem désactiverLesMinutesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem désactiverLesHeuresToolStripMenuItem;
    }
}

