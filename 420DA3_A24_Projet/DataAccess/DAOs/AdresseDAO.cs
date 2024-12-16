using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;

namespace _420DA3_A24_Projet.DataAccess.DAOs;

internal class AdresseDAO {
    private readonly WsysDbContext context;

    public AdresseDAO(WsysDbContext context) {
        this.context = context;
    }

    public Adresse Create(Adresse adresse) {
        this.context.Adresses.Add(adresse);
        this.context.SaveChanges();
        return adresse;
    }

    public Adresse? GetById(int id) {
        return this.context.Adresses.FirstOrDefault(a => a.Id == id);
    }

    public Adresse Update(Adresse adresse) {
        this.context.Adresses.Update(adresse);
        this.context.SaveChanges();
        return adresse;
    }

    public Adresse Delete(Adresse adresse) {
        this.context.Adresses.Remove(adresse);
        this.context.SaveChanges();
        return adresse;
    }

    public List<Adresse> Search(string criterion) {
        return this.context.Adresses
            .Where(a => a.City.Contains(criterion) || a.Street.Contains(criterion))
            .ToList();
    }

    public Adresse? GetByWarehouse(int warehouseId) {
        return this.context.Adresses.FirstOrDefault(a => a.WarehouseId == warehouseId);
    }

    public Adresse? GetByShipOrder(int shipOrderId) {
        return this.context.Adresses.FirstOrDefault(a => a.ShipOrderId == shipOrderId);
    }
}
