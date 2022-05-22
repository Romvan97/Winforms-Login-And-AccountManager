using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using BLL;
using System.Security.Cryptography;


namespace WUI
{

    public partial class FrmCreation : Form
    {


        public string key = "";
        public static string log;
        public static string pass;
        public string AllTestResult = "";

        public FrmCreation()
        {
            InitializeComponent();
        }

        private void FrmCreation_Load(object sender, EventArgs e)
        {

        }

        public string employeLogin;
        public string employePassword;
        public string employeConfirmation;
        public bool EmployeIsCreated = false;
        private void BtnConfirmCreation_Click(object sender, EventArgs e)
        {


            CreationEmploye();
            if (EmployeIsCreated == true)
            {
                this.Hide();

                FrmConnection frmConnection = new FrmConnection();

                frmConnection.ShowDialog();
                this.Close();
            }

        }


        public string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private bool CreationEmploye()
        {
            string employeLogin,
                   employePassword,
                   employeConfirmation,

                   testSiTousLesChampsSontRemplis,
                   testSiLesMotsDePassesSontLesMemes,
                   testLeNombreDeCaracteresDuMotDePasse;

            TestDeTousLesChampsDuFormulaire(out employeLogin, out employePassword, out employeConfirmation, out testSiTousLesChampsSontRemplis, out testSiLesMotsDePassesSontLesMemes, out testLeNombreDeCaracteresDuMotDePasse);

            AllTestResult = testSiTousLesChampsSontRemplis + testSiLesMotsDePassesSontLesMemes + testLeNombreDeCaracteresDuMotDePasse;

            AfficheLesErreursDuFormulaire();

            EmployeIsCreated = false;

            return FormulaireValideDoncEcritEtEncrypte(employeLogin, employePassword);

        }


        private void TestDeTousLesChampsDuFormulaire(out string employeLogin, out string employePassword, out string employeConfirmation, out string testSiTousLesChampsSontRemplis, out string testSiLesMotsDePassesSontLesMemes, out string testLeNombreDeCaracteresDuMotDePasse)
        {
            employeLogin = TxtLoginCreation.Text;
            employePassword = TxtPassWordCreation.Text;
            employeConfirmation = TxtConfirmationCreation.Text;

            Employe employe = new Employe(employeLogin, employePassword, employeConfirmation);
            testSiTousLesChampsSontRemplis = "";
            testSiLesMotsDePassesSontLesMemes = "";
            testLeNombreDeCaracteresDuMotDePasse = "";
            if (employeLogin == "" || employePassword == "" || employeConfirmation == "")
            {
                testSiTousLesChampsSontRemplis = "Tous les champs ne sont pas remplis";
            }
            if (employePassword != employeConfirmation)
            {
                testSiLesMotsDePassesSontLesMemes = "Les mots de passes ne correspondent pas";
            }
            if (employePassword.Length < 8 && employePassword != "")
            {
                testLeNombreDeCaracteresDuMotDePasse = "le mot de passe de contient pas > de 8 caractères";

            }
        }
        private void AfficheLesErreursDuFormulaire()
        {
            if (AllTestResult == "Tous les champs ne sont pas remplis")
            {

                //errorA.ShowDialog();
                MessageBox.Show("Tous les champs doivent être remplis");

            }

            if (AllTestResult == "Les mots de passes ne correspondent pas")
            {

                MessageBox.Show("Les mots de passes ne correspondent pas");

            }


            if (AllTestResult == "le mot de passe de contient pas > de 8 caractères")
            {

                MessageBox.Show("Votre mot de passe doit contenir plus de 8 caractères");

            }


            if (AllTestResult == "Tous les champs ne sont pas remplis" + "Les mots de passes ne correspondent pas")
            {

                MessageBox.Show("Tous les champs doivent être remplis\r\nLes mots de passes ne correspondent pas");

            }


            if (AllTestResult == "Les mots de passes ne correspondent pas" + "le mot de passe de contient pas > de 8 caractères")
            {

                MessageBox.Show("Les mots de passes ne correspondent pas\r\nVotre mot de passe doit contenir plus de 8 caractères");

            }

            if (AllTestResult == "Tous les champs ne sont pas remplis" + "le mot de passe de contient pas > de 8 caractères")
            {
                MessageBox.Show("Tous les champs doivent être remplis\r\nVotre mot de passe doit contenir plus de 8 caractères");

            }



            if (AllTestResult == "Tous les champs ne sont pas remplis" + "Les mots de passes ne correspondent pas" + "le mot de passe de contient pas > de 8 caractères")
            {

                MessageBox.Show("Tous les champs doivent être remplis\r\nLes mots de passes ne correspondent pas\r\nVotre mot de passe doit contenir plus de 8 caractères");
            }
        }


        private bool FormulaireValideDoncEcritEtEncrypte(string employeLogin, string employePassword)
        {


            if (AllTestResult == "" && File.Exists(appDataPath + $"\\WinAppFournisseur\\Data\\Comptes\\employees.{employeLogin}.txt.aes") == false)
            {
                Directory.CreateDirectory(appDataPath + "\\WinAppFournisseur\\Data\\Comptes\\");

                string dateDeCreation = DateTime.Now.ToLongDateString();
                using (StreamWriter EmployeData = new(appDataPath + $"\\WinAppFournisseur\\Data\\Comptes\\employees.{employeLogin}.txt"))
                {
                    EmployeData.Write($"{employeLogin};{employePassword};{dateDeCreation}");
                }
                log = employeLogin;
                pass = employePassword;


                ExpressEncription.AESEncription.AES_Encrypt(appDataPath + $"\\WinAppFournisseur\\Data\\Comptes\\employees.{employeLogin}.txt", employePassword);
                File.Delete(appDataPath + $"\\WinAppFournisseur\\Data\\Comptes\\employees.{employeLogin}.txt");
                EmployeIsCreated = true;
                return EmployeIsCreated;
            }

            else if (AllTestResult == "" && File.Exists(appDataPath + $"\\WinAppFournisseur\\Data\\Comptes\\employees.{employeLogin}.txt.aes") == true)
            {
                MessageBox.Show("Ce login existe déjà, veuillez en créer un autre");
                EmployeIsCreated = false;
                return EmployeIsCreated;
            }


            return EmployeIsCreated;
        }


        private void BtnAnnulerCreation_Click(object sender, EventArgs e)
        {
            DirectoryInfo directory = new DirectoryInfo(appDataPath + $"\\WinAppFournisseur\\Data\\Comptes\\");

            int files = directory.GetFiles("*.aes").Length; // récupère le nombre de fichiers présent dans le dossier

            List<string> regle = new List<string>();
            string employeetxt = "";
            string employeeLogin = "";
            string sousExtension = "";
            string extension = "";

            foreach (string s in Directory.GetFiles(appDataPath + $"\\WinAppFournisseur\\Data\\Comptes\\", "*.aes").Select(Path.GetFileName))
            {
                string[] structure = s.Split('.');
                employeetxt = structure[0];
                employeeLogin = structure[1];
                sousExtension = structure[2];
                extension = structure[3];

            }

            if (files >= 1 && employeetxt == "employees" && employeeLogin != "" && sousExtension == "txt" && extension == "aes")
            {
                FrmMain main = new FrmMain();
                this.Hide();
                main.ShowDialog();
                this.Close();

            }

            else
            {
                this.Close();
            }

        }

        private void TxtLoginCreation_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPassWordCreation_TextChanged(object sender, EventArgs e)
        {
            employeLogin = TxtLoginCreation.Text;
            employePassword = TxtPassWordCreation.Text;
            employeConfirmation = TxtConfirmationCreation.Text;

            Employe passEmploye = new Employe(employeLogin, employePassword, employeConfirmation);


            if (employePassword.Length < 8)
            {
                TxtPassWordCreation.ForeColor = Color.Red;

            }
            else
            {
                TxtPassWordCreation.ForeColor = Color.Black;
            }
        }

        private void TxtConfirmationCreation_TextChanged(object sender, EventArgs e)
        {
            employeLogin = TxtLoginCreation.Text;
            employePassword = TxtPassWordCreation.Text;
            employeConfirmation = TxtConfirmationCreation.Text;

            Employe confirmEmploye = new Employe(employeLogin, employePassword, employeConfirmation);

            if (employePassword != employeConfirmation)
            {
                TxtConfirmationCreation.ForeColor = Color.Red;
            }

            else
            {
                TxtConfirmationCreation.ForeColor = Color.Black;
            }

        }
    }
}
