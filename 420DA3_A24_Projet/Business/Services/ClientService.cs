using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;
using System.Runtime.Serialization;

namespace _420DA3_A24_Projet.Business.Services;

internal class ClientService {
    private readonly ClientDAO dao;
    private readonly ClientView view;

    public ClientService(WsysApplication parentApp, WsysDbContext context) {
        this.dao = new ClientDAO(context);
        this.view = new ClientView(parentApp);
    }

    public Client? OpenClientWindowForCreation() {
        Client newClient = (Client) FormatterServices.GetUninitializedObject(typeof(Client));
        DialogResult result = this.view.OpenForCreation(newClient);
        return result == DialogResult.OK ? newClient : null;
    }

    public Client? OpenClientWindowForDetailsView(Client client) {
        DialogResult result = this.view.OpenForDetailsView(client);
        return result == DialogResult.OK ? client : null;
    }

    public Client? OpenClientWindowForEdition(Client client) {
        DialogResult result = this.view.OpenForEdition(client);
        return result == DialogResult.OK ? client : null;
    }

    public Client? OpenClientWindowForDeletion(Client client) {
        DialogResult result = this.view.OpenForDeletion(client);
        return result == DialogResult.OK ? client : null;
    }

    public Client? GetById(int id, bool includeDeleted = false) {
        return this.dao.GetById(id, includeDeleted);
    }

    public Client? GetByName(string name, bool includeDeleted = false) {
        return this.dao.GetByName(name, includeDeleted);
    }

    public List<Client> Search(string criterion, bool includeDeleted = false) {
        return this.dao.Search(criterion, includeDeleted);
    }

    public Client CreateNewClient(Client client) {
        return this.dao.Create(client);
    }

    public Client UpdateClient(Client client) {
        return this.dao.Update(client);
    }

    public Client DeleteClient(Client client, bool softDeletes = true) {
        return this.dao.Delete(client, softDeletes);
    }
}
