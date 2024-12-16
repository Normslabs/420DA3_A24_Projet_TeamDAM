using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace _420DA3_A24_Projet.DataAccess.DAOs;
/// <summary>
/// DAO for managing Produits entities.
/// </summary>
internal class ProductDAO {
    private readonly WsysDbContext context;

    public ProductDAO(WsysDbContext context) {
        this.context = context;
    }
    public Product Create(Product product) {
        try {
            _ = this.context.Produits.Add(product);
            _ = this.context.SaveChanges();
            return product;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to insert product in database.", ex);
        }
    }

    // Create
    public async Task<Product> AddProduitAsync(Product product) {
        _ = this.context.Set<Product>()
                    .Add(product);
        _ = await this.context.SaveChangesAsync();
        return product;
    }

    // Lire- Get by ID
    public async Task<Product?> GetProduitByIdAsync(int id) {
        return await this.context.Set<Product>()
            .Include(p => p.Client)
            .Include(p => p.Warehouse)
            .FirstOrDefaultAsync(p => p.ProductId == id);
    }
    // Get by Client 
    public async Task<Product?> GetProduitByFournisseurs(int id) {
        return await this.context.Set<Product>()
            .Include(p => p.Client)
            .Include(p => p.Warehouse)
            .FirstOrDefaultAsync(p => p.ProductId == id);
    }

    // Lire - Get All
    public async Task<List<Product>> GetAllProduitsAsync() {
        return await this.context.Set<Product>()
            .Include(p => p.Client)
            .Include(p => p.Warehouse)
            .ToListAsync();
    }

    // Lire - Get All
    public List<Product> GetAllProduits() {
        return this.context.Set<Product>()
            .Include(p => p.Client)
            .Include(p => p.Entrepot)
            .ToList();
    }

    // Update
    public async Task<bool> UpdateProduit(Product product) {
        _ = this.context.Set<Product>()
                    .Update(product);
        return await this.context.SaveChangesAsync() > 0;
    }

    // Supprimer
    public async Task<bool> DeleteProduitAsync(int id) {
        // Récupérer le produit à partir de son ID
        Product product = await this.GetProduitByIdAsync(id);

        // Vérifier si le produit existe
        if (product == null) {
            return false;
        }

        // Supprimer le produit du contexte
        _ = this.context.Set<Product>()
                    .Remove(product);


        return await this.context.SaveChangesAsync() > 0;
    }


    internal bool CreateProduit(Product product) {
        throw new NotImplementedException();
    }

    internal bool UpdateProduitAsync(Product product) {
        throw new NotImplementedException();
    }
}
