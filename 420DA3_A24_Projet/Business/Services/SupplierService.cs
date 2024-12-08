using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;
using System.Runtime.Serialization;

namespace _420DA3_A24_Projet.Business.Services;

internal class SupplierService {
    private readonly SupplierDAO dao;
    private readonly SupplierView view;

    public SupplierService(WsysApplication parentApp, WsysDbContext context) {
        this.dao = new SupplierDAO(context);
        this.view = new SupplierView(parentApp);
    }

    public Supplier? OpenSupplierWindowForCreation() {
        Supplier newSupplier = (Supplier) FormatterServices.GetUninitializedObject(typeof(Supplier));
        DialogResult result = this.view.OpenForCreation(newSupplier);
        return result == DialogResult.OK ? newSupplier : null;
    }

    public Supplier? OpenSupplierWindowForDetailsView(Supplier supplier) {
        DialogResult result = this.view.OpenForDetailsView(supplier);
        return result == DialogResult.OK ? supplier : null;
    }

    public Supplier? OpenSupplierWindowForEdition(Supplier supplier) {
        DialogResult result = this.view.OpenForEdition(supplier);
        return result == DialogResult.OK ? supplier : null;
    }

    public Supplier? OpenSupplierWindowForDeletion(Supplier supplier) {
        DialogResult result = this.view.OpenForDeletion(supplier);
        return result == DialogResult.OK ? supplier : null;
    }

    public Supplier? GetById(int id, bool includeDeleted = false) {
        return this.dao.GetById(id, includeDeleted);
    }

    public Supplier? GetByName(string name, bool includeDeleted = false) {
        return this.dao.GetByName(name, includeDeleted);
    }

    public List<Supplier> Search(string criterion, bool includeDeleted = false) {
        return this.dao.Search(criterion, includeDeleted);
    }

    public Supplier CreateNewSupplier(Supplier supplier) {
        return this.dao.Create(supplier);
    }

    public Supplier UpdateSupplier(Supplier supplier) {
        return this.dao.Update(supplier);
    }

    public Supplier DeleteSupplier(Supplier supplier, bool softDeletes = true) {
        return this.dao.Delete(supplier, softDeletes);
    }
}
