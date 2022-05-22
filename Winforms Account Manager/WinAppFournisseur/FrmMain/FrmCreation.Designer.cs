namespace WUI
{
    partial class FrmCreation
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtLoginCreation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPassWordCreation = new System.Windows.Forms.TextBox();
            this.TxtConfirmationCreation = new System.Windows.Forms.TextBox();
            this.BtnConfirmCreation = new System.Windows.Forms.Button();
            this.BtnAnnulerCreation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login :";
            // 
            // TxtLoginCreation
            // 
            this.TxtLoginCreation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtLoginCreation.Location = new System.Drawing.Point(142, 31);
            this.TxtLoginCreation.Name = "TxtLoginCreation";
            this.TxtLoginCreation.Size = new System.Drawing.Size(225, 23);
            this.TxtLoginCreation.TabIndex = 1;
            this.TxtLoginCreation.TextChanged += new System.EventHandler(this.TxtLoginCreation_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(32, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(32, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Confirmation :";
            // 
            // TxtPassWordCreation
            // 
            this.TxtPassWordCreation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPassWordCreation.Location = new System.Drawing.Point(142, 68);
            this.TxtPassWordCreation.Name = "TxtPassWordCreation";
            this.TxtPassWordCreation.Size = new System.Drawing.Size(225, 23);
            this.TxtPassWordCreation.TabIndex = 4;
            this.TxtPassWordCreation.UseSystemPasswordChar = true;
            this.TxtPassWordCreation.TextChanged += new System.EventHandler(this.TxtPassWordCreation_TextChanged);
            // 
            // TxtConfirmationCreation
            // 
            this.TxtConfirmationCreation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtConfirmationCreation.Location = new System.Drawing.Point(142, 105);
            this.TxtConfirmationCreation.Name = "TxtConfirmationCreation";
            this.TxtConfirmationCreation.Size = new System.Drawing.Size(225, 23);
            this.TxtConfirmationCreation.TabIndex = 5;
            this.TxtConfirmationCreation.UseSystemPasswordChar = true;
            this.TxtConfirmationCreation.TextChanged += new System.EventHandler(this.TxtConfirmationCreation_TextChanged);
            // 
            // BtnConfirmCreation
            // 
            this.BtnConfirmCreation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnConfirmCreation.Location = new System.Drawing.Point(142, 157);
            this.BtnConfirmCreation.Name = "BtnConfirmCreation";
            this.BtnConfirmCreation.Size = new System.Drawing.Size(95, 34);
            this.BtnConfirmCreation.TabIndex = 6;
            this.BtnConfirmCreation.Text = "OK";
            this.BtnConfirmCreation.UseVisualStyleBackColor = true;
            this.BtnConfirmCreation.Click += new System.EventHandler(this.BtnConfirmCreation_Click);
            // 
            // BtnAnnulerCreation
            // 
            this.BtnAnnulerCreation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAnnulerCreation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAnnulerCreation.Location = new System.Drawing.Point(273, 157);
            this.BtnAnnulerCreation.Name = "BtnAnnulerCreation";
            this.BtnAnnulerCreation.Size = new System.Drawing.Size(94, 34);
            this.BtnAnnulerCreation.TabIndex = 7;
            this.BtnAnnulerCreation.Text = "ANNULER";
            this.BtnAnnulerCreation.UseVisualStyleBackColor = true;
            this.BtnAnnulerCreation.Click += new System.EventHandler(this.BtnAnnulerCreation_Click);
            // 
            // FrmCreation
            // 
            this.AcceptButton = this.BtnConfirmCreation;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnAnnulerCreation;
            this.ClientSize = new System.Drawing.Size(409, 218);
            this.Controls.Add(this.BtnAnnulerCreation);
            this.Controls.Add(this.BtnConfirmCreation);
            this.Controls.Add(this.TxtConfirmationCreation);
            this.Controls.Add(this.TxtPassWordCreation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtLoginCreation);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(425, 257);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(425, 257);
            this.Name = "FrmCreation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Création de votre compte";
            this.Load += new System.EventHandler(this.FrmCreation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox TxtLoginCreation;
        private Label label2;
        private Label label3;
        private TextBox TxtPassWordCreation;
        private TextBox TxtConfirmationCreation;
        private Button BtnConfirmCreation;
        private Button BtnAnnulerCreation;
    }
}