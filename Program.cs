using Projects.Models;
using Projects.Views;
using Projects.Presenters;
using Projects._Repositories;
using EmployeesForms;
using System.Configuration;

namespace Projects
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string sqlConnectingString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            IMainView view = new MainView();
            
            new MainPresnter(view, sqlConnectingString);
            Application.Run((Form)view);
        }
    }
}