using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Presentation;
using _420DA3_A24_Projet.Presentation.Views;
using System.Diagnostics;

namespace _420DA3_A24_Projet;

internal static class Program {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main(string[] args) {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
   
        ApplicationConfiguration.Initialize();
        Application.Run(new AdminMainMenu(new WsysApplication()));
        //Application.Run(new ProductView());
    }
}