using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _420DA3_A24_Projet.Business.Domain;

namespace _420DA3_A24_Projet.DataAccess.DAOs;
/// <summary>
/// DAO for managing Entrepot entities.
/// </summary>
public class EntrepotDAO {
        private readonly DbContext _context;

        public EntrepotDAO(DbContext context) {
            _context = context;
        }

        // Créer
        public async Task<Entrepot> AddEntrepotAsync(Entrepot entrepot) {
            _context.Set<Entrepot>().Add(entrepot);
            await _context.SaveChangesAsync();
            return entrepot;
        }

        // Lire - Get by ID
        public async Task<Entrepot?> GetEntrepotByIdAsync(int id) {
            return await _context.Set<Entrepot>()
                .Include(e => e.Adresse)
                .Include(e => e.Clients)
                .Include(e => e.OrdreRestockage)
                .Include(e => e.EmployesEntrepot)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        // Lire - Get All
        public async Task<List<Entrepot>> GetAllEntrepotsAsync() {
            return await _context.Set<Entrepot>()
                .Include(e => e.Adresse)
                .Include(e => e.Clients)
                .Include(e => e.OrdreRestockage)
                .Include(e => e.EmployesEntrepot)
                .ToListAsync();
        }

        // Update
        public async Task<bool> UpdateEntrepotAsync(Entrepot entrepot) {
            _context.Set<Entrepot>().Update(entrepot);
            return await _context.SaveChangesAsync() > 0;
        }

    // Supprimer
    public async Task<bool> DeleteEntrepotAsync(int id) {
        // S'assure que la méthode GetEntrepotByIdAsync fonctionne correctement et ne retourne pas une valeur nulle de manière inattendue.
        Entrepot? entrepot = await GetEntrepotByIdAsync(id);

        // If no entrepôt retourne faux
        if (entrepot == null) {
            return false;
        }

        // Supprime l'entrepôt trouvé du context
        _context.Set<Entrepot>().Remove(entrepot);

        // Save changes and return result
        return await _context.SaveChangesAsync() > 0;
    }

    internal async Task<bool> CreateEntrepotAsync(Entrepot entrepot) {
        throw new NotImplementedException();
    }
}



