namespace WUI
{
    partial class FrmSuppressionCompte
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.DgvComptesData = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LblNbrDeComptes = new System.Windows.Forms.Label();
            this.BtnAnnuler = new System.Windows.Forms.Button();
            this.BtnSupprimer = new System.Windows.Forms.Button();
            this.TxtLoginToDelete = new System.Windows.Forms.TextBox();
            this.CmbOrderBy = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvComptesData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.BtnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 63);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmSuppressionCompte_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmSuppressionCompte_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmSuppressionCompte_MouseUp);
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(327, 12);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(31, 36);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.Text = "X";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            this.BtnExit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnExit_MouseDown);
            this.BtnExit.MouseEnter += new System.EventHandler(this.BtnExit_MouseEnter);
            this.BtnExit.MouseLeave += new System.EventHandler(this.BtnExit_MouseLeave);
            this.BtnExit.MouseHover += new System.EventHandler(this.BtnExit_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(79, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Comptes";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(280, 579);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Quitter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.DgvComptesData);
            this.panel5.Location = new System.Drawing.Point(13, 121);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(345, 405);
            this.panel5.TabIndex = 7;
            // 
            // DgvComptesData
            // 
            this.DgvComptesData.AllowUserToAddRows = false;
            this.DgvComptesData.AllowUserToResizeColumns = false;
            this.DgvComptesData.AllowUserToResizeRows = false;
            this.DgvComptesData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvComptesData.BackgroundColor = System.Drawing.Color.White;
            this.DgvComptesData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvComptesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvComptesData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Login,
            this.CreationDate});
            this.DgvComptesData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvComptesData.Location = new System.Drawing.Point(0, 0);
            this.DgvComptesData.Margin = new System.Windows.Forms.Padding(0);
            this.DgvComptesData.Name = "DgvComptesData";
            this.DgvComptesData.RowHeadersVisible = false;
            this.DgvComptesData.RowHeadersWidth = 45;
            this.DgvComptesData.RowTemplate.Height = 25;
            this.DgvComptesData.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DgvComptesData.Size = new System.Drawing.Size(345, 405);
            this.DgvComptesData.TabIndex = 0;
            this.DgvComptesData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.FillWeight = 45.68528F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 45;
            this.ID.Name = "ID";
            // 
            // Login
            // 
            this.Login.FillWeight = 127.1574F;
            this.Login.HeaderText = "Login";
            this.Login.MinimumWidth = 130;
            this.Login.Name = "Login";
            // 
            // CreationDate
            // 
            this.CreationDate.FillWeight = 127.1574F;
            this.CreationDate.HeaderText = "Date de création";
            this.CreationDate.MinimumWidth = 200;
            this.CreationDate.Name = "CreationDate";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(13, 574);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmSuppressionCompte_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmSuppressionCompte_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmSuppressionCompte_MouseUp);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(13, 622);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(345, 15);
            this.panel4.TabIndex = 3;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmSuppressionCompte_MouseDown);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmSuppressionCompte_MouseMove);
            this.panel4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmSuppressionCompte_MouseUp);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(358, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(14, 574);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmSuppressionCompte_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmSuppressionCompte_MouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmSuppressionCompte_MouseUp);
            // 
            // LblNbrDeComptes
            // 
            this.LblNbrDeComptes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNbrDeComptes.Location = new System.Drawing.Point(21, 70);
            this.LblNbrDeComptes.MaximumSize = new System.Drawing.Size(57, 37);
            this.LblNbrDeComptes.MinimumSize = new System.Drawing.Size(57, 37);
            this.LblNbrDeComptes.Name = "LblNbrDeComptes";
            this.LblNbrDeComptes.Size = new System.Drawing.Size(57, 37);
            this.LblNbrDeComptes.TabIndex = 8;
            this.LblNbrDeComptes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnnuler.Location = new System.Drawing.Point(123, 579);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(61, 27);
            this.BtnAnnuler.TabIndex = 8;
            this.BtnAnnuler.Text = "Annuler";
            this.BtnAnnuler.UseVisualStyleBackColor = true;
            this.BtnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // BtnSupprimer
            // 
            this.BtnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSupprimer.Location = new System.Drawing.Point(31, 579);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.Size = new System.Drawing.Size(75, 27);
            this.BtnSupprimer.TabIndex = 9;
            this.BtnSupprimer.Text = "Supprimer";
            this.BtnSupprimer.UseVisualStyleBackColor = true;
            this.BtnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            // 
            // TxtLoginToDelete
            // 
            this.TxtLoginToDelete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtLoginToDelete.Location = new System.Drawing.Point(31, 542);
            this.TxtLoginToDelete.Name = "TxtLoginToDelete";
            this.TxtLoginToDelete.Size = new System.Drawing.Size(153, 23);
            this.TxtLoginToDelete.TabIndex = 10;
            this.TxtLoginToDelete.TextChanged += new System.EventHandler(this.TxtLoginToDelete_TextChanged);
            // 
            // CmbOrderBy
            // 
            this.CmbOrderBy.BackColor = System.Drawing.Color.White;
            this.CmbOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbOrderBy.Items.AddRange(new object[] {
            "Login",
            "Date de création"});
            this.CmbOrderBy.Location = new System.Drawing.Point(213, 542);
            this.CmbOrderBy.Name = "CmbOrderBy";
            this.CmbOrderBy.Size = new System.Drawing.Size(124, 23);
            this.CmbOrderBy.TabIndex = 11;
            this.CmbOrderBy.SelectedIndexChanged += new System.EventHandler(this.CmbOrderBy_SelectedIndexChanged);
            // 
            // FrmSuppressionCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.BtnExit;
            this.ClientSize = new System.Drawing.Size(372, 637);
            this.Controls.Add(this.CmbOrderBy);
            this.Controls.Add(this.LblNbrDeComptes);
            this.Controls.Add(this.TxtLoginToDelete);
            this.Controls.Add(this.BtnSupprimer);
            this.Controls.Add(this.BtnAnnuler);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(372, 637);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(372, 637);
            this.Name = "FrmSuppressionCompte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmSuppressionCompte";
            this.Load += new System.EventHandler(this.FrmSuppressionCompte_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmSuppressionCompte_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmSuppressionCompte_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmSuppressionCompte_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvComptesData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button BtnExit;
        private Label label1;
        private Button button1;
        private Panel panel5;
        private DataGridView DgvComptesData;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private Label LblNbrDeComptes;
        private Button BtnAnnuler;
        private Button BtnSupprimer;
        private TextBox TxtLoginToDelete;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Login;
        private DataGridViewTextBoxColumn CreationDate;
        private ComboBox CmbOrderBy;
    }
}