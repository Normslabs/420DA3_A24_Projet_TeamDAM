using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _420DA3_A24_Projet.Business.Domain;

namespace _420DA3_A24_Projet.DataAccess.DAOs;
{
    /// <summary>
    /// DAO for managing Expedition entities.
    /// </summary>
    public class ExpeditionDAO {
    private readonly DbContext _context;

    public ExpeditionDAO(DbContext context) {
        _context = context;
    }

    // Créer
    public async Task<Expedition> AddExpeditionAsync(Expedition expedition) {
        _context.Set<Expedition>().Add(expedition);
        await _context.SaveChangesAsync();
        return expedition;
    }

    // Lire 
    public async Task<Expedition?> GetExpeditionByIdAsync(int id) {
        return await _context.Set<Expedition>()
            .FirstOrDefaultAsync(e => e.Id == id);
    }

    // Lire 
    public async Task<List<Expedition>> GetAllExpeditionsAsync() {
        return await _context.Set<Expedition>().ToListAsync();
    }

    // Mettre a jour
    public async Task<bool> UpdateExpeditionAsync(Expedition expedition) {
        _context.Set<Expedition>().Update(expedition);
        return await _context.SaveChangesAsync() > 0;
    }

    // Supprimer
    public async Task<bool> DeleteExpeditionAsync(int id) {
        Expedition? expedition = await GetExpeditionByIdAsync(id);
        if (expedition == null) {
            return false;
        }

        _context.Set<Expedition>().Remove(expedition);
        return await _context.SaveChangesAsync() > 0;
    }

    // Générer un code de suivi 
    public string GenerateTrackingCode(string serviceLivraison) {
        return $"{serviceLivraison.ToUpper()}-{Guid.NewGuid().ToString().Substring(0, 8).ToUpper()}";
    }

    // Créer une expédition avec code de suivi
    public async Task<Expedition> CreateExpeditionWithTrackingAsync(string serviceLivraison) {
        var expedition = new Expedition {
            ServiceLivraison = serviceLivraison,
            CodeSuivi = GenerateTrackingCode(serviceLivraison),
            DateCreation = DateTime.Now
        };

        return await AddExpeditionAsync(expedition);
    }
}
}
