using _420DA3_A24_Projet.Business;

namespace _420DA3_A24_Projet.Presentation;
internal partial class OfficeEmpMainMenu : Form {


    private readonly WsysApplication parentApp;
    public OfficeEmpMainMenu(WsysApplication application) {
        this.parentApp = application;
        this.InitializeComponent();
    }
}
