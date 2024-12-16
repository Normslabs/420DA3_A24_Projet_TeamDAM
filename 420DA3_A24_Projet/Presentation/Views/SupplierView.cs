using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;

namespace _420DA3_A24_Projet.Presentation.Views;
internal partial class SupplierView : Form {
    private readonly WsysApplication parentApp;
    public SupplierView(WsysApplication parentApp) {
        this.InitializeComponent();
    }

    internal DialogResult OpenForCreation(Supplier newSupplier) {
        throw new NotImplementedException();
    }

    internal DialogResult OpenForDeletion(Supplier supplier) {
        throw new NotImplementedException();
    }

    internal DialogResult OpenForDetailsView(Supplier supplier) {
        throw new NotImplementedException();
    }

    internal DialogResult OpenForEdition(Supplier supplier) {
        throw new NotImplementedException();
    }
}
