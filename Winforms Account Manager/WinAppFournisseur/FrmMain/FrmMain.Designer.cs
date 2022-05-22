namespace WUI
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Clmn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clmn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clmn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn10 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmn11 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauFournisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editionToolStripMenuItem,
            this.compteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1144, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clmn1,
            this.Clmn2,
            this.Clmn3,
            this.clmn4,
            this.clmn5,
            this.clmn6,
            this.clmn7,
            this.clmn8,
            this.clmn9,
            this.clmn10,
            this.clmn11});
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1144, 404);
            this.dataGridView1.TabIndex = 2;
            // 
            // Clmn1
            // 
            this.Clmn1.HeaderText = "ID";
            this.Clmn1.Name = "Clmn1";
            // 
            // Clmn2
            // 
            this.Clmn2.HeaderText = "Name";
            this.Clmn2.Name = "Clmn2";
            // 
            // Clmn3
            // 
            this.Clmn3.HeaderText = "Address";
            this.Clmn3.Name = "Clmn3";
            // 
            // clmn4
            // 
            this.clmn4.HeaderText = "City";
            this.clmn4.Name = "clmn4";
            // 
            // clmn5
            // 
            this.clmn5.HeaderText = "Postal code";
            this.clmn5.Name = "clmn5";
            // 
            // clmn6
            // 
            this.clmn6.HeaderText = "Mail address";
            this.clmn6.Name = "clmn6";
            // 
            // clmn7
            // 
            this.clmn7.HeaderText = "In command";
            this.clmn7.Name = "clmn7";
            // 
            // clmn8
            // 
            this.clmn8.HeaderText = "Creation date";
            this.clmn8.Name = "clmn8";
            // 
            // clmn9
            // 
            this.clmn9.HeaderText = "Modification date";
            this.clmn9.Name = "clmn9";
            // 
            // clmn10
            // 
            this.clmn10.HeaderText = "";
            this.clmn10.Name = "clmn10";
            this.clmn10.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clmn11
            // 
            this.clmn11.HeaderText = "";
            this.clmn11.Name = "clmn11";
            this.clmn11.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmn11.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1144, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 20);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // editionToolStripMenuItem
            // 
            this.editionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauFournisseurToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
            this.editionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.editionToolStripMenuItem.Text = "Edition";
            // 
            // nouveauFournisseurToolStripMenuItem
            // 
            this.nouveauFournisseurToolStripMenuItem.Name = "nouveauFournisseurToolStripMenuItem";
            this.nouveauFournisseurToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nouveauFournisseurToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.nouveauFournisseurToolStripMenuItem.Text = "Nouveau fournisseur";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // compteToolStripMenuItem
            // 
            this.compteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauCompteToolStripMenuItem,
            this.supprimerCompteToolStripMenuItem,
            this.quitterToolStripMenuItem1});
            this.compteToolStripMenuItem.Name = "compteToolStripMenuItem";
            this.compteToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.compteToolStripMenuItem.Text = "Compte";
            this.compteToolStripMenuItem.Click += new System.EventHandler(this.compteToolStripMenuItem_Click);
            // 
            // nouveauCompteToolStripMenuItem
            // 
            this.nouveauCompteToolStripMenuItem.Name = "nouveauCompteToolStripMenuItem";
            this.nouveauCompteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.N)));
            this.nouveauCompteToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
            this.nouveauCompteToolStripMenuItem.Text = "Nouveau compte";
            this.nouveauCompteToolStripMenuItem.Click += new System.EventHandler(this.nouveauCompteToolStripMenuItem_Click);
            // 
            // supprimerCompteToolStripMenuItem
            // 
            this.supprimerCompteToolStripMenuItem.Name = "supprimerCompteToolStripMenuItem";
            this.supprimerCompteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Delete)));
            this.supprimerCompteToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
            this.supprimerCompteToolStripMenuItem.Text = "Supprimer compte";
            this.supprimerCompteToolStripMenuItem.Click += new System.EventHandler(this.supprimerCompteToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem1
            // 
            this.quitterToolStripMenuItem1.Name = "quitterToolStripMenuItem1";
            this.quitterToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitterToolStripMenuItem1.Size = new System.Drawing.Size(285, 22);
            this.quitterToolStripMenuItem1.Text = "Quitter";
            this.quitterToolStripMenuItem1.Click += new System.EventHandler(this.quitterToolStripMenuItem1_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Gestion des fournisseurs";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Clmn1;
        private DataGridViewTextBoxColumn Clmn2;
        private DataGridViewTextBoxColumn Clmn3;
        private DataGridViewTextBoxColumn clmn4;
        private DataGridViewTextBoxColumn clmn5;
        private DataGridViewTextBoxColumn clmn6;
        private DataGridViewTextBoxColumn clmn7;
        private DataGridViewTextBoxColumn clmn8;
        private DataGridViewTextBoxColumn clmn9;
        private DataGridViewButtonColumn clmn10;
        private DataGridViewButtonColumn clmn11;
        private ToolStripMenuItem editionToolStripMenuItem;
        private ToolStripMenuItem nouveauFournisseurToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem compteToolStripMenuItem;
        private ToolStripMenuItem nouveauCompteToolStripMenuItem;
        private ToolStripMenuItem supprimerCompteToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem1;
        private StatusStrip statusStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
    }
}