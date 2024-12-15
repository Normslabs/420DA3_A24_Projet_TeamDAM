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
    public class ProduitDAO {
        private readonly DbContext context;

        public ProduitDAO(DbContext context) {
            this.context = context;
        }

        // Create
        public async Task<Produit> AddProduitAsync(Produit produit) {
            this.context.Set<Produit>()
                        .Add(produit);
            await this.context.SaveChangesAsync();
            return produit;
        }

        // Lire- Get by ID
        public async Task<Produit?> GetProduitByIdAsync(int id) {
            return await context.Set<Produit>()
                .Include(p => p.Client)
                .Include(p => p.Entrepot)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        // Lire - Get All
        public async Task<List<Produit>> GetAllProduitsAsync() {
            return await context.Set<Produit>()
                .Include(p => p.Client)
                .Include(p => p.Entrepot)
                .ToListAsync();
        }

        // Update
        public async Task<bool> UpdateProduit(Produit produit) {
            this.context.Set<Produit>()
                        .Update(produit);
            return await this.context.SaveChangesAsync() > 0;
        }

    // Supprimer
    public async Task<bool> DeleteProduitAsync(int id) {
        // Récupérer le produit à partir de son ID
        Produit produit = await this.GetProduitByIdAsync(id); 

        // Vérifier si le produit existe
        if (produit == null)
            return false;

        // Supprimer le produit du contexte
        this.context.Set<Produit>()
                    .Remove(produit);

        
        return await context.SaveChangesAsync() > 0;
    }


    internal bool CreateProduit(Produit produit) {
        throw new NotImplementedException();
    }

    internal bool UpdateProduitAsync(Produit produit) {
        throw new NotImplementedException();
    }
}
