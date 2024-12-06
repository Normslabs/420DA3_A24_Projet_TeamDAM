using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _420DA3_A24_Projet.Business.Domain;

namespace _420DA3_A24_Projet.DataAccess.DAOs; 
    /// <summary>
    /// DAO for managing Produits entities.
    /// </summary>
    public class ProduitsDAO {
        private readonly DbContext _context;

        public ProduitsDAO(DbContext context) {
            _context = context;
        }

        // Create
        public async Task<Produits> AddProduitAsync(Produits produit) {
            _context.Set<Produits>().Add(produit);
            await _context.SaveChangesAsync();
            return produit;
        }

        // Lire- Get by ID
        public async Task<Produits?> GetProduitByIdAsync(int id) {
            return await _context.Set<Produits>()
                .Include(p => p.Client)
                .Include(p => p.Entrepot)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        // Lire - Get All
        public async Task<List<Produits>> GetAllProduitsAsync() {
            return await _context.Set<Produits>()
                .Include(p => p.Client)
                .Include(p => p.Entrepot)
                .ToListAsync();
        }

        // Update
        public async Task<bool> UpdateProduitAsync(Produits produit) {
            _context.Set<Produits>().Update(produit);
            return await _context.SaveChangesAsync() > 0;
        }

    // Supprimer
    public async Task<bool> DeleteProduitAsync(int id) {
        // Récupérer le produit à partir de son ID
        Produits produit = await GetProduitByIdAsync(id); 

        // Vérifier si le produit existe
        if (produit == null)
            return false;

        // Supprimer le produit du contexte
        _context.Set<Produits>().Remove(produit);

        // Sauvegarder les modifications et retourner true si l'opération a réussi
        return await _context.SaveChangesAsync() > 0;
    }

    internal async Task<bool> CreateProduitAsync(Produits produit) {
        throw new NotImplementedException();
    }
}
