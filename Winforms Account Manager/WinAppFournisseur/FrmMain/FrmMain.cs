namespace WUI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void compteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quitterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nouveauCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCreation frmCreate = new FrmCreation();
            frmCreate.ShowDialog();
            this.Close();
        }

        private void supprimerCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSuppressionCompte frmSupprimerCompte = new FrmSuppressionCompte();
            frmSupprimerCompte.ShowDialog();    
        }
    }
}