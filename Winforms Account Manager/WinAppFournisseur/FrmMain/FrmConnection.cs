using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WUI
{
    public partial class FrmConnection : Form
    {

        public FrmConnection()
        {

            InitializeComponent();
        }



        private void FrmConnection_Load(object sender, EventArgs e)
        {
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {

            this.Close();
        }


        private int errorNumber = 5;

        public void BtnOk_Click(object sender, EventArgs e)
        {
            string log = TxtLogA.Text;
            string pass = TxtPassA.Text;
            string conf = TxtPassA.Text;

            Employe potentialEmployee = new Employe(log, pass, conf);

            CheckDecrypt(potentialEmployee);

        }

        public string lines = "";
        public string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);



        /// <summary>
        /// Méthode qui permet de savoir si l'employer qui essaye de se connecter est bien l'employer qui a créer le compte.
        /// On décrypte le fichier qui contient le mot de passe, si tout correspond on affiche la forme contenant les informations des fournisseurs, sinon on affiche un message et on décompte l'essais.
        /// Lorsque l'essais est arriver à zéro, on supprime tout les fichiers contenant les informations des fournisseurs.
        /// </summary>
        /// <param name="potentialEmployee"></param>
        private void CheckDecrypt(Employe potentialEmployee)
        {

            // modifier -> savoir si le fichier avec le login dedans existe, s'il n'existe pas, erreur,
            // s'il existe on utilise la clé et on lit dedans si le tableau est egale à 1 erreur,
            // s'il est plus grand que un on regarde si le login correspond et si le mot de passe correspond
            if (File.Exists(appDataPath + $"\\WinAppFournisseur\\Data\\Comptes\\employees.{potentialEmployee.Login}.txt.aes") == true)
            {

                ExpressEncription.AESEncription.AES_Decrypt(appDataPath + $"\\WinAppFournisseur\\Data\\Comptes\\employees.{potentialEmployee.Login}.txt.aes", potentialEmployee.Password);

                string[] lineSplit;
                string loginToTest = "";
                string passToTest = "";

                using (StreamReader reader = new StreamReader(appDataPath + $"\\WinAppFournisseur\\Data\\Comptes\\employees.{potentialEmployee.Login}.txt.aes.decrypted"))
                {
                    string lines = reader.ReadToEnd();


                    if (lines.Contains(';'))
                    {
                        lineSplit = lines.Split(';');
                        loginToTest = lineSplit[0];
                        passToTest = lineSplit[1];
                        reader.Close();
                    }
                    else if (!lines.Contains(';'))
                    {
                        reader.Close();
                    }
                }

                if (loginToTest == "" || passToTest == "" || TxtLogA.Text == "" || TxtPassA.Text == "" || passToTest != TxtPassA.Text || loginToTest != TxtLogA.Text)
                {
                    File.Delete(appDataPath + $"\\WinAppFournisseur\\Data\\Comptes\\employees.{potentialEmployee.Login}.txt.aes.decrypted");
                    errorNumber--;
                    MessageBox.Show($"La connexion a échouée, il vous reste {errorNumber} essais");

                }


                else if (passToTest == TxtPassA.Text && loginToTest == TxtLogA.Text)
                {
                    File.Delete(appDataPath + $"\\WinAppFournisseur\\Data\\Comptes\\employees.{potentialEmployee.Login}.txt.aes.decrypted");
                    this.Hide();
                    FrmMain main = new FrmMain();
                    main.ShowDialog();
                    this.Close();

                }
            }

            else if (File.Exists(appDataPath + $"\\WinAppFournisseur\\Data\\Comptes\\employees.{potentialEmployee.Login}.txt.aes") == false)
            {
                errorNumber--;
                MessageBox.Show($"La connexion a échouée, il vous reste {errorNumber} essais");
            }

        }
    }
}
