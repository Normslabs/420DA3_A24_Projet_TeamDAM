using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;
using System.Runtime.Serialization;

namespace _420DA3_A24_Projet.Business.Services;

internal class PurchaseOrderService {

    private readonly PurchaseOrderDAO dao;
    private readonly PurchaseOrderView view;

    public PurchaseOrderService(WsysApplication parentApp, WsysDbContext context) {
        this.dao = new PurchaseOrderDAO(context);
        this.view = new PurchaseOrderView(parentApp);
    }

    public PurchaseOrder? OpenPurchaseOrderWindowForCreation() {
        PurchaseOrder newOrder = (PurchaseOrder) FormatterServices.GetUninitializedObject(typeof(PurchaseOrder));
        DialogResult result = this.view.OpenForCreation(newOrder);
        return result == DialogResult.OK ? newOrder : null;
    }

    public PurchaseOrder? OpenPurchaseOrderWindowForDetailsView(PurchaseOrder order) {
        DialogResult result = this.view.OpenForDetailsView(order);
        return result == DialogResult.OK ? order : null;
    }

    public PurchaseOrder? OpenPurchaseOrderWindowForEdition(PurchaseOrder order) {
        DialogResult result = this.view.OpenForEdition(order);
        return result == DialogResult.OK ? order : null;
    }

    public PurchaseOrder? OpenPurchaseOrderWindowForDeletion(PurchaseOrder order) {
        DialogResult result = this.view.OpenForDeletion(order);
        return result == DialogResult.OK ? order : null;
    }

    public PurchaseOrder? GetById(int id, bool includeDeleted = false) {
        return this.dao.GetById(id, includeDeleted);
    }

    public List<PurchaseOrder> Search(string criterion, bool includeDeleted = false) {
        return this.dao.Search(criterion, includeDeleted);
    }

    public PurchaseOrder CreateNewPurchaseOrder(PurchaseOrder order) {
        return this.dao.Create(order);
    }

    public PurchaseOrder UpdatePurchaseOrder(PurchaseOrder order) {
        return this.dao.Update(order);
    }

    public PurchaseOrder DeletePurchaseOrder(PurchaseOrder order, bool softDeletes = true) {
        return this.dao.Delete(order, softDeletes);
    }
}
