using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _420DA3_A24_Projet.Business.Domain;

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
            this.context.Set<Warehouse>()
                        .Add(warehouse);
            await this.context.SaveChangesAsync();
            return warehouse;
        }

        // Lire - Get by ID
        public async Task<Warehouse?> GetEntrepotByIdAsync(int id) {
            return await context.Set<Warehouse>()
                .Include(e => e.Adresse)
                .Include(e => e.Clients)
                .Include(e => e.OrdreRestockage)
                .Include(e => e.WarehouseEmployes)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        // Lire - Get All
        public async Task<List<Warehouse>> GetAllEntrepotsAsync() {
            return await context.Set<Warehouse>()
                .Include(e => e.Adresse)
                .Include(e => e.Clients)
                .Include(e => e.OrdreRestockage)
                .Include(e => e.WarehouseEmployes)
                .ToListAsync();
        }

        // Update
        public async Task<bool> UpdateEntrepotAsync(Warehouse warehouse) {
            this.context.Set<Warehouse>()
            .Update(warehouse);
            return await context.SaveChangesAsync() > 0;
        }

    // Supprimer
    public async Task<bool> DeleteEntrepotAsync(int id) {
        // S'assure que la méthode GetEntrepotByIdAsync fonctionne correctement et ne retourne pas une valeur nulle de manière inattendue.
        Warehouse? warehouse = await this.GetEntrepotByIdAsync(id);


        if (warehouse == null) {
            return false;
        }

        // Supprime l'entrepôt trouvé du context
        context.Set<Warehouse>()
               .Remove(warehouse);


        return await context.SaveChangesAsync() > 0;
    }

    internal bool CreateEntrepot(Warehouse warehouse) {
        throw new NotImplementedException();
    }
}



