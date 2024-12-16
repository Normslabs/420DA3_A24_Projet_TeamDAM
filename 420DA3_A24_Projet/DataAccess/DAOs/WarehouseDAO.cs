using _420DA3_A24_Projet.Business.Domain;
using Microsoft.EntityFrameworkCore;

namespace _420DA3_A24_Projet.DataAccess.DAOs;
/// <summary>
/// DAO for managing Warehouse entities.
/// </summary>
public class WarehouseDAO {
    private readonly DbContext context;

    public WarehouseDAO(DbContext context) {
        this.context = context;
    }

    // Créer
    public async Task<Warehouse> AddEntrepotAsync(Warehouse warehouse) {
        _ = this.context.Set<Warehouse>()
                    .Add(warehouse);
        _ = await this.context.SaveChangesAsync();
        return warehouse;
    }

    // Lire - Get by ID
    public async Task<Warehouse?> GetEntrepotByIdAsync(int id) {
        return await this.context.Set<Warehouse>()
            .Include(e => e.Adresse)
            .Include(e => e.Clients)
            .Include(e => e.OrdreRestockage)
            .Include(e => e.WarehouseEmployes)
            .FirstOrDefaultAsync(e => e.Id == id);
    }

    // Lire - Get All
    public async Task<List<Warehouse>> GetAllEntrepotsAsync() {
        return await this.context.Set<Warehouse>()
            .Include(e => e.Adresse)
            .Include(e => e.Clients)
            .Include(e => e.OrdreRestockage)
            .Include(e => e.WarehouseEmployes)
            .ToListAsync();
    }

    // Update
    public async Task<bool> UpdateEntrepotAsync(Warehouse warehouse) {
        _ = this.context.Set<Warehouse>()
        .Update(warehouse);
        return await this.context.SaveChangesAsync() > 0;
    }

    // Supprimer
    public async Task<bool> DeleteEntrepotAsync(int id) {
        // S'assure que la méthode GetEntrepotByIdAsync fonctionne correctement et ne retourne pas une valeur nulle de manière inattendue.
        Warehouse? warehouse = await this.GetEntrepotByIdAsync(id);


        if (warehouse == null) {
            return false;
        }

        // Supprime l'entrepôt trouvé du context
        _ = this.context.Set<Warehouse>()
               .Remove(warehouse);


        return await this.context.SaveChangesAsync() > 0;
    }

    internal bool CreateEntrepot(Warehouse warehouse) {
        throw new NotImplementedException();
    }
}



