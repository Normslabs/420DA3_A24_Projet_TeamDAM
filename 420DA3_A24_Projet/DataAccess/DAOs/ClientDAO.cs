using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;

namespace _420DA3_A24_Projet.DataAccess.DAOs;

internal class ClientDAO {
    private readonly WsysDbContext context;

    public ClientDAO(WsysDbContext context) {
        this.context = context;
    }

    public List<Client> GetAll(bool includeDeleted = false) {
        return includeDeleted
            ? context.Clients.ToList()
            : context.Clients.Where(c => !c.IsDeleted).ToList();
    }

    public Client? GetById(int id, bool includeDeleted = false) {
        return includeDeleted
            ? context.Clients.FirstOrDefault(c => c.Id == id)
            : context.Clients.FirstOrDefault(c => c.Id == id && !c.IsDeleted);
    }

    public Client? GetByName(string name, bool includeDeleted = false) {
        return includeDeleted
            ? context.Clients.FirstOrDefault(c => c.Name == name)
            : context.Clients.FirstOrDefault(c => c.Name == name && !c.IsDeleted);
    }

    public List<Client> Search(string criterion, bool includeDeleted = false) {
        return includeDeleted
            ? context.Clients.Where(c => c.Name.Contains(criterion) || c.Email.Contains(criterion)).ToList()
            : context.Clients.Where(c => !c.IsDeleted && (c.Name.Contains(criterion) || c.Email.Contains(criterion))).ToList();
    }

    public Client Create(Client client) {
        context.Clients.Add(client);
        context.SaveChanges();
        return client;
    }

    public Client Update(Client client) {
        context.Clients.Update(client);
        context.SaveChanges();
        return client;
    }

    public Client Delete(Client client, bool softDeletes = true) {
        if (softDeletes) {
            client.IsDeleted = true;
            context.Clients.Update(client);
        } else {
            context.Clients.Remove(client);
        }
        context.SaveChanges();
        return client;
    }
}
