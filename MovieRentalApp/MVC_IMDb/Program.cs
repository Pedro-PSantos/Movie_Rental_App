using MVC_IMDb.Controllers;
using MVC_IMDb.Forms;
using MVC_IMDb.Models;
using System;

namespace MVC_IMDb
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // O programa inicializa no login
            LoginController loginController = new LoginController();
            loginController.IniciarFormDeLogin();

            // O resto do programa ocorre após login
            new MenuController( loginController.GetUserModel() ).IniciarPrograma();
        }
    }
}