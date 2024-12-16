using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;
using System.Runtime.Serialization;

namespace _420DA3_A24_Projet.Business.Services;

internal class AdresseService {
    private readonly AdresseDAO dao;
    private readonly AdresseView view;

    public AdresseService(WsysApplication parentApp, WsysDbContext context) {
        this.dao = new AdresseDAO(context);
        this.view = new AdresseView(parentApp);
    }

    public Adresse? OpenAdresseWindowForCreation() {
        Adresse newAdresse = (Adresse) FormatterServices.GetUninitializedObject(typeof(Adresse));
        DialogResult result = this.view.OpenForCreation(newAdresse);
        return result == DialogResult.OK ? newAdresse : null;
    }

    public Adresse? OpenAdresseWindowForDetailsView(Adresse adresse) {
        DialogResult result = this.view.OpenForDetailsView(adresse);
        return result == DialogResult.OK ? adresse : null;
    }

    public Adresse? OpenAdresseWindowForEdition(Adresse adresse) {
        DialogResult result = this.view.OpenForEdition(adresse);
        return result == DialogResult.OK ? adresse : null;
    }

    public Adresse? OpenAdresseWindowForDeletion(Adresse adresse) {
        DialogResult result = this.view.OpenForDeletion(adresse);
        return result == DialogResult.OK ? adresse : null;
    }

    public Adresse? GetById(int id) {
        return this.dao.GetById(id);
    }

    public Adresse? GetByWarehouse(int warehouseId) {
        return this.dao.GetByWarehouse(warehouseId);
    }

    public Adresse? GetByShipOrder(int shipOrderId) {
        return this.dao.GetByShipOrder(shipOrderId);
    }

    public List<Adresse> Search(string criterion) {
        return this.dao.Search(criterion);
    }

    public Adresse CreateNewAdresse(Adresse adresse) {
        return this.dao.Create(adresse);
    }

    public Adresse UpdateAdresse(Adresse adresse) {
        return this.dao.Update(adresse);
    }

    public Adresse DeleteAdresse(Adresse adresse, bool softDeletes = true) {
        return this.dao.Delete(adresse);
    }
}
