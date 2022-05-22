using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using Model;
using System.Linq;
using BLL;

namespace WUI
{
    public partial class FrmSuppressionCompte : Form
    {

        public string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;



        public FrmSuppressionCompte()
        {
            InitializeComponent();
            customizeDesing();


        }

        private void customizeDesing()
        {


        }

        public List<string> allComptes = new List<string>();
        public List<string> allComptesAfterClear = new List<string>();

        public List<string> allLoginAfterSort = new List<string>();
        public List<string> allDatesAfterSort = new List<string>();


        public List<string> allCreationsDates = new List<string>();
        public List<string> allCreationsDatesAfterClear = new List<string>();

        public List<string> allCreationsDatesBeforeSort = new List<string>();
        public List<string> allCreationsDatesAfterSort = new List<string>();

        public List<string> allCreationsDatesAndLoginAfterSort = new List<string>();

        public List<int> IndexChanged = new List<int>();

        public string employeeLogin = "";
        public string employL = "";

        private void FrmSuppressionCompte_Load(object sender, EventArgs e)
        {
            CmbOrderBy.Text = "Trier par :";
            LoadDataGridView();

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSuppressionCompte_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void FrmSuppressionCompte_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void FrmSuppressionCompte_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnExit_MouseDown(object sender, MouseEventArgs e)
        {
            BtnExit.ForeColor = Color.Black;
        }

        private void BtnExit_MouseHover(object sender, EventArgs e)
        {

        }

        private void BtnExit_MouseEnter(object sender, EventArgs e)
        {
            BtnExit.ForeColor = Color.Black;
        }

        private void BtnExit_MouseLeave(object sender, EventArgs e)
        {
            BtnExit.ForeColor = Color.White;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            TxtLoginToDelete.Text = (DgvComptesData.CurrentRow.Cells[1].Value).ToString();
        }


        private void CmbOrderBy_SelectedIndexChanged(object sender, EventArgs e)
        {


            //  // concatènes les dates avec les login dans la variable After sort
            for (int indexOfDatesAndLogin = 0; indexOfDatesAndLogin < allCreationsDates.Count; indexOfDatesAndLogin++)
            {
                allCreationsDatesAndLoginAfterSort.Add($"{allCreationsDates[indexOfDatesAndLogin]}§{allComptes[indexOfDatesAndLogin]}");
            }

            allCreationsDatesAndLoginAfterSort.Sort();

            DgvComptesData.RowCount = allComptes.Count;






            if (CmbOrderBy.SelectedItem == "Login")
            {
                allComptes.Sort();

                int column = 0;



                for (int rowIndex = 0; rowIndex < allComptes.Count; rowIndex++) // permet de placer chaque éléments dans les colonnes après il faut changer de rows
                {


                    column++;
                    DgvComptesData.Rows[rowIndex].Cells[column].Value = allComptes[rowIndex];
                    column++;
                    DgvComptesData.Rows[rowIndex].Cells[column].Value = allCreationsDates[rowIndex];
                    column++;

                    if (column == 3)
                    {
                        column = 0;
                    }
                }
                DgvComptesData.Refresh();


            }



            if (CmbOrderBy.SelectedItem == "Date de création")
            {

                string[] loginAndDateSplitted;

                for (int index = 0; index < allCreationsDatesAndLoginAfterSort.Count; index++)
                {
                    string loginAfterSplit;
                    string datesAfterSplit;
                    string loginBeforeSplit = allCreationsDatesAndLoginAfterSort[index];
                    loginAndDateSplitted = loginBeforeSplit.Split('§');
                    loginAfterSplit = loginAndDateSplitted[1];
                    datesAfterSplit = loginAndDateSplitted[0];

                    allLoginAfterSort.Add(loginAfterSplit);
                    allDatesAfterSort.Add(datesAfterSplit);
                }


                int column = 0;



                for (int rowIndex = 0; rowIndex < allComptes.Count; rowIndex++) // permet de placer chaque éléments dans les colonnes après il faut changer de rows
                {


                    column++;
                    DgvComptesData.Rows[rowIndex].Cells[column].Value = allLoginAfterSort[rowIndex];
                    column++;
                    DgvComptesData.Rows[rowIndex].Cells[column].Value = allDatesAfterSort[rowIndex];
                    column++;

                    if (column == 3)
                    {
                        column = 0;
                    }
                }
                DgvComptesData.Refresh();

            }

        }

        private void TxtLoginToDelete_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            if (TxtLoginToDelete.Text != "")
            {
                string login = TxtLoginToDelete.Text;
                File.Delete(appDataPath + $"\\WinAppFournisseur\\Data\\Comptes\\employees.{login}.txt.aes");
                DgvComptesData.Rows.Clear();
                DgvComptesData.RowCount = 0;
                DgvComptesData.Refresh();

                LoadAnotherDataGridView();

                DgvComptesData.Refresh();
            }


        }

        /// <summary>
       /// Cette méthode permet d'initialiser la datagrid view avec tous les comptes présents
        /// </summary>
        private void LoadDataGridView()
        {

            DirectoryInfo directory = new DirectoryInfo(appDataPath + $"\\WinAppFournisseur\\Data\\Comptes\\");

            int files = directory.GetFiles("*.aes").Length; // récupère le nombre de fichiers présent dans le dossier




            this.LblNbrDeComptes.Text = files.ToString();


            // Je dois récupérer tout les login et date de créations

            string[] employeeName;

            foreach (string s in Directory.GetFiles(appDataPath + $"\\WinAppFournisseur\\Data\\Comptes\\", "*.aes").Select(Path.GetFileName))
            {
                FileInfo fileInformationsDate = new FileInfo(appDataPath + $"\\WinAppFournisseur\\Data\\Comptes\\{s}");
                string date = (fileInformationsDate.CreationTime.ToLongDateString()); //date création
                string heure = (fileInformationsDate.CreationTime.ToLongTimeString()); //heure création

                allCreationsDates.Add(date + "  " + heure); // j'ajoute à la liste la date et l'heure de la création du login correspondant
                employeeName = s.Split('.');
                employeeLogin = employeeName[1];
                allComptes.Add(employeeLogin); // j'ajoute à la liste un login
            }




            // Avant je dois récupérer tout les login et date de création, après je dois la mapper avec les rows/column
            int ID = 1;


            // A cet instant AllComptes.Count = 3 et contient en [0] céline; en [1] Quentin; en [2] Romain
            int column = 0;

            DgvComptesData.RowCount = allComptes.Count; // initialise les rows au nombres de comptes 


            for (int rowIndex = 0; rowIndex < allComptes.Count; rowIndex++) // permet de placer chaque éléments dans les colonnes après il faut changer de rows
            {

                DgvComptesData.Rows[rowIndex].Cells[column].Value = ID.ToString();
                column++;
                DgvComptesData.Rows[rowIndex].Cells[column].Value = allComptes[rowIndex];
                column++;
                DgvComptesData.Rows[rowIndex].Cells[column].Value = allCreationsDates[rowIndex];
                column++;

                if (column == 3)
                {
                    ID = ID + 1;
                    column = 0;
                }
            }
        }

        /// <summary>
        /// Cette méthode permet de réinitialiser la datagrid view avec les comptes qui n'ont pas été supprimés
        /// </summary>
        private void LoadAnotherDataGridView()
        {


            DirectoryInfo dir = new DirectoryInfo(appDataPath + $"\\WinAppFournisseur\\Data\\Comptes\\");

            int files = dir.GetFiles("*.aes").Length; // récupère le nombre de fichiers présent dans le dossier




            this.LblNbrDeComptes.Text = files.ToString();


            // Je dois récupérer tout les login et date de créations

            string[] employN = null;
            allComptesAfterClear.Clear();
            allCreationsDatesAfterClear.Clear();


            foreach (string D in Directory.GetFiles(appDataPath + $"\\WinAppFournisseur\\Data\\Comptes\\", "*.aes").Select(Path.GetFileName))
            {
                FileInfo fileInformationsDates = new FileInfo(appDataPath + $"\\WinAppFournisseur\\Data\\Comptes\\{D}");
                string date = (fileInformationsDates.CreationTime.ToLongDateString()); 
                string heure = (fileInformationsDates.CreationTime.ToLongTimeString()); 

                allCreationsDatesAfterClear.Add(date + "  " + heure);
                employN = D.Split('.');
                employL = employN[1];
                allComptesAfterClear.Add(employL); 
            }

            int Id = 1;


          
            int column = 0;

            DgvComptesData.RowCount = allComptesAfterClear.Count;


            for (int rowIndex = 0; rowIndex < allComptesAfterClear.Count; rowIndex++) 
            {

                DgvComptesData.Rows[rowIndex].Cells[column].Value = Id.ToString();
                column++;
                DgvComptesData.Rows[rowIndex].Cells[column].Value = allComptesAfterClear[rowIndex];
                column++;
                DgvComptesData.Rows[rowIndex].Cells[column].Value = allCreationsDatesAfterClear[rowIndex];
                column++;

                if (column == 3)
                {
                    Id = Id + 1;
                    column = 0;
                }
            }
        }


        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            TxtLoginToDelete.Text = "";
        }
    }
}
