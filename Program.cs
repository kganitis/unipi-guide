using System;
using System.Windows.Forms;

namespace WindowsFormsApp2023_Final
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormCacheManager cacheManager = FormCacheManager.Instance;
            Application.Run(new LoginForm());
        }
    }
}
