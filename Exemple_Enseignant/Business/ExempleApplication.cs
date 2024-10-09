﻿
global using global::System;
global using global::System.Collections.Generic;
global using global::System.Drawing;
global using global::System.Linq;
global using global::System.Windows.Forms;
using _420DA3_A24_Exemple_Enseignant.Business.Services;
using _420DA3_A24_Exemple_Enseignant.DataAccess.Contexts;
using _420DA3_A24_Exemple_Enseignant.Presentation;

namespace _420DA3_A24_Exemple_Enseignant.Business;
internal class ExempleApplication {
    private readonly ExempleDbContext dbContext;
    private readonly MainMenu mainMenu;
    public MedecinService MedecinService { get; private set; }
    public PatientService PatientService { get; private set; }
    public RendezVousService RendezVousService { get; private set; }

    public ExempleApplication() {
        ApplicationConfiguration.Initialize();
        this.dbContext = new ExempleDbContext();
        this.MedecinService = new MedecinService(this, this.dbContext);
        this.PatientService = new PatientService(this, this.dbContext);
        this.RendezVousService = new RendezVousService(this, this.dbContext);
        this.mainMenu = new MainMenu(this);
    }

    public void LogException(Exception ex) {
        string? stack = ex.StackTrace;
        Console.Error.WriteLine(ex.Message);
        while (ex.InnerException != null) {
            ex = ex.InnerException;
            Console.Error.WriteLine(ex.Message);
        }
        Console.Error.WriteLine("Stack trace:");
        Console.Error.WriteLine(stack);
    }

    public string GetCopyrightNotice() {
        return $"(c) {DateTime.Now.Year} Marc-Eric Boury - All rights reserved.";
    }

    public void Start() {
        Application.Run(this.mainMenu);
    }

    public void Shutdown() {
        Application.Exit();
    }
}
