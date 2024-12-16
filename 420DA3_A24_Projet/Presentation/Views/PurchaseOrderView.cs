using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;

namespace _420DA3_A24_Projet.Presentation.Views;
internal partial class PurchaseOrderView : Form {
    private readonly WsysApplication parentApp;
    public PurchaseOrderView(WsysApplication parentApp) {
        this.InitializeComponent();
    }

    internal DialogResult OpenForCreation(PurchaseOrder newPurchaseOrder) {
        throw new NotImplementedException();
    }

    internal DialogResult OpenForDeletion(PurchaseOrder purchaseOrder) {
        throw new NotImplementedException();
    }

    internal DialogResult OpenForDetailsView(PurchaseOrder order) {
        throw new NotImplementedException();
    }

    internal DialogResult OpenForEdition(PurchaseOrder purchaseOrder) {
        throw new NotImplementedException();
    }
}