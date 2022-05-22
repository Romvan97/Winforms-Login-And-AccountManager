using System.IO;

namespace WUI
{
    internal static class Program
    {

        /// <summary>
        /// Permet de récupérer sur n'importe quel ordinateur le chemin AppData\Roaming
        /// </summary>
        public static string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        
        static void Main()
        {

            ApplicationConfiguration.Initialize();

            if (Directory.Exists(appDataPath + "\\WinAppFournisseur\\Data\\Comptes\\") == false || Directory.GetFiles(appDataPath + "\\WinAppFournisseur\\Data\\Comptes\\").Length == 0)
            {
                Application.Run(new FrmCreation());
                
            }


            else if (Directory.Exists(appDataPath + "\\WinAppFournisseur\\Data\\Comptes\\") == true && Directory.GetFiles(appDataPath + "\\WinAppFournisseur\\Data\\Comptes\\").Length != 0)
            {
                Application.Run(new FrmConnection());
            }
        }
    }
}