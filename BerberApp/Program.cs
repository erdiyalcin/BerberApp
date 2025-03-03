using BerberApp.Models;

namespace BerberApp
{
    internal static class Program
    {
        // Giriş yapan kullanıcının bilgilerini saklamak ve istediğim yerden erişmek
        public static Kullanici kullanici = new Kullanici();


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmGiris());
        }
    }
}