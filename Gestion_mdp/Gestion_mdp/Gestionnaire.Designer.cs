
namespace Gestion_mdp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fichierMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegarderMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.entréeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addEntree = new System.Windows.Forms.ToolStripMenuItem();
            this.copierMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.copierMdpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DtgEntries = new System.Windows.Forms.DataGridView();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Contextutilisateur = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenumdp = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuaddEntre = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenudelete = new System.Windows.Forms.ToolStripMenuItem();
            this.modiferLentréeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgEntries)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierMenu,
            this.entréeMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip2";
            // 
            // fichierMenu
            // 
            this.fichierMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuNew,
            this.ouvrirMenu,
            this.fermerMenu,
            this.sauvegarderMenu,
            this.quitterMenu});
            this.fichierMenu.Name = "fichierMenu";
            this.fichierMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.fichierMenu.Size = new System.Drawing.Size(54, 20);
            this.fichierMenu.Text = "Fichier";
            this.fichierMenu.DropDownOpening += new System.EventHandler(this.MenuFileOpen);
            // 
            // MenuNew
            // 
            this.MenuNew.Name = "MenuNew";
            this.MenuNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.MenuNew.Size = new System.Drawing.Size(179, 22);
            this.MenuNew.Text = "Nouveau";
            this.MenuNew.Click += new System.EventHandler(this.NewDatabase);
            // 
            // ouvrirMenu
            // 
            this.ouvrirMenu.Name = "ouvrirMenu";
            this.ouvrirMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.ouvrirMenu.Size = new System.Drawing.Size(179, 22);
            this.ouvrirMenu.Text = "Ouvrir";
            this.ouvrirMenu.Click += new System.EventHandler(this.OpenDatabase);
            // 
            // fermerMenu
            // 
            this.fermerMenu.Name = "fermerMenu";
            this.fermerMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fermerMenu.Size = new System.Drawing.Size(179, 22);
            this.fermerMenu.Text = "Fermer";
            this.fermerMenu.Click += new System.EventHandler(this.CloseDatabase);
            // 
            // sauvegarderMenu
            // 
            this.sauvegarderMenu.Name = "sauvegarderMenu";
            this.sauvegarderMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.sauvegarderMenu.Size = new System.Drawing.Size(179, 22);
            this.sauvegarderMenu.Text = "Sauvegarder";
            this.sauvegarderMenu.Click += new System.EventHandler(this.SauvegardeDatabase);
            // 
            // quitterMenu
            // 
            this.quitterMenu.Name = "quitterMenu";
            this.quitterMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitterMenu.Size = new System.Drawing.Size(179, 22);
            this.quitterMenu.Text = "Quitter";
            this.quitterMenu.Click += new System.EventHandler(this.quitterMenu_Click);
            // 
            // entréeMenu
            // 
            this.entréeMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEntree,
            this.copierMenu,
            this.copierMdpMenu});
            this.entréeMenu.Name = "entréeMenu";
            this.entréeMenu.Size = new System.Drawing.Size(52, 20);
            this.entréeMenu.Text = "Entrée";
            this.entréeMenu.DropDownOpening += new System.EventHandler(this.Menuentrée);
            // 
            // addEntree
            // 
            this.addEntree.Name = "addEntree";
            this.addEntree.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.addEntree.Size = new System.Drawing.Size(254, 22);
            this.addEntree.Text = "Ajouter une entrée";
            this.addEntree.Click += new System.EventHandler(this.AddEntree);
            // 
            // copierMenu
            // 
            this.copierMenu.Name = "copierMenu";
            this.copierMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.copierMenu.Size = new System.Drawing.Size(254, 22);
            this.copierMenu.Text = "copier le nom d\'utilisateur";
            this.copierMenu.Click += new System.EventHandler(this.CopierUtilisateur);
            // 
            // copierMdpMenu
            // 
            this.copierMdpMenu.Name = "copierMdpMenu";
            this.copierMdpMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.copierMdpMenu.Size = new System.Drawing.Size(254, 22);
            this.copierMdpMenu.Text = "copier le mot de passe";
            this.copierMdpMenu.Click += new System.EventHandler(this.Copiemdp);
            // 
            // DtgEntries
            // 
            this.DtgEntries.AllowUserToAddRows = false;
            this.DtgEntries.AllowUserToDeleteRows = false;
            this.DtgEntries.AllowUserToResizeColumns = false;
            this.DtgEntries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgEntries.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DtgEntries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtgEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgEntries.ContextMenuStrip = this.contextMenu;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgEntries.DefaultCellStyle = dataGridViewCellStyle1;
            this.DtgEntries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtgEntries.GridColor = System.Drawing.Color.White;
            this.DtgEntries.Location = new System.Drawing.Point(0, 24);
            this.DtgEntries.Name = "DtgEntries";
            this.DtgEntries.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgEntries.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DtgEntries.RowTemplate.Height = 25;
            this.DtgEntries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgEntries.ShowCellToolTips = false;
            this.DtgEntries.ShowEditingIcon = false;
            this.DtgEntries.ShowRowErrors = false;
            this.DtgEntries.Size = new System.Drawing.Size(800, 426);
            this.DtgEntries.TabIndex = 2;
            this.DtgEntries.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DtgEntriesCellFormatting);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Contextutilisateur,
            this.ContextMenumdp,
            this.ContextMenuaddEntre,
            this.ContextMenudelete,
            this.modiferLentréeToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(215, 136);
            // 
            // Contextutilisateur
            // 
            this.Contextutilisateur.Name = "Contextutilisateur";
            this.Contextutilisateur.Size = new System.Drawing.Size(214, 22);
            this.Contextutilisateur.Text = "Copier le nom d\'utilisateur";
            this.Contextutilisateur.Click += new System.EventHandler(this.CopierUtilisateur);
            // 
            // ContextMenumdp
            // 
            this.ContextMenumdp.Name = "ContextMenumdp";
            this.ContextMenumdp.Size = new System.Drawing.Size(214, 22);
            this.ContextMenumdp.Text = "Copier le mot de passe";
            this.ContextMenumdp.Click += new System.EventHandler(this.Copiemdp);
            // 
            // ContextMenuaddEntre
            // 
            this.ContextMenuaddEntre.Name = "ContextMenuaddEntre";
            this.ContextMenuaddEntre.Size = new System.Drawing.Size(214, 22);
            this.ContextMenuaddEntre.Text = "Ajouter une entrée";
            // 
            // ContextMenudelete
            // 
            this.ContextMenudelete.Name = "ContextMenudelete";
            this.ContextMenudelete.Size = new System.Drawing.Size(214, 22);
            this.ContextMenudelete.Text = "Modifer l\'entrée";
            this.ContextMenudelete.Click += new System.EventHandler(this.ModifierEntrée);
            // 
            // modiferLentréeToolStripMenuItem
            // 
            this.modiferLentréeToolStripMenuItem.Name = "modiferLentréeToolStripMenuItem";
            this.modiferLentréeToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.modiferLentréeToolStripMenuItem.Text = "Supprimer l\'entrée";
            this.modiferLentréeToolStripMenuItem.Click += new System.EventHandler(this.SupprimerEntree);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DtgEntries);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Gestionnaire de mot de passe";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgEntries)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fichierMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuNew;
        private System.Windows.Forms.ToolStripMenuItem ouvrirMenu;
        private System.Windows.Forms.ToolStripMenuItem fermerMenu;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderMenu;
        private System.Windows.Forms.ToolStripMenuItem quitterMenu;
        private System.Windows.Forms.ToolStripMenuItem entréeMenu;
        private System.Windows.Forms.ToolStripMenuItem addEntree;
        private System.Windows.Forms.ToolStripMenuItem copierMenu;
        private System.Windows.Forms.ToolStripMenuItem copierMdpMenu;
        private System.Windows.Forms.DataGridView DtgEntries;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem Contextutilisateur;
        private System.Windows.Forms.ToolStripMenuItem ContextMenumdp;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuaddEntre;
        private System.Windows.Forms.ToolStripMenuItem ContextMenudelete;
        private System.Windows.Forms.ToolStripMenuItem modiferLentréeToolStripMenuItem;
    }
}

