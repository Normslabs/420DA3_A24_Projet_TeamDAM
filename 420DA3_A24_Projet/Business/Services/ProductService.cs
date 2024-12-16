using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Runtime.Serialization;

namespace _420DA3_A24_Projet.Business.Services;
internal class ProductService {

    private readonly ProductDAO produitsDAO;
    private readonly ProductView view;

    public ProductService(WsysApplication parentApp, WsysDbContext context) {
        this.produitsDAO = new ProductDAO(context);
        this.view = new ProductView(parentApp);
    }

    // Méthode pour récupérer tous les produits
    public async Task<IEnumerable<Product>> GetAllProduitsAsync() {
        return await this.produitsDAO.GetAllProduitsAsync();
    }

    // Méthode pour récupérer un produit par son ID
    public async Task<Product?> GetProduitByIdAsync(int id) {
        return await this.produitsDAO.GetProduitByIdAsync(id);
    }

    // Méthode pour créer un nouveau produit
    public bool CreateProduit(Product produit) {
        return this.produitsDAO.CreateProduit(produit);
    }

    // Méthode pour mettre à jour un produit
    public bool UpdateProduit(Product produit) {
        return this.produitsDAO.UpdateProduitAsync(produit);
    }

    // Méthode pour supprimer un produit
    public async Task<bool> DeleteProduitAsync(int id) {
        return await this.produitsDAO.DeleteProduitAsync(id);
    }


    public Product? OpenViewForCreation() {
        Product product = new Product();
        DialogResult result = this.view.OpenForCreation(product);
        return result == DialogResult.OK ? product :  null;
    }
    public Product OpenViewForView(Product product) {
        _ = this.view.OpenForView(product);
        return product;
    }
    public Product? OpenViewForModification(Product product) {
        DialogResult result = this.view.OpenForModification(product);
        return result == DialogResult.OK ? product : null;
    }
    public Product? OpenViewForDeletion(Product product) {
        DialogResult result = this.view.OpenForDeletion(product);
        return result == DialogResult.OK ? product : null;
    }
    public Product? OpenManagementWindowForCreation() {
        try {
            Product newProduct = (Product) FormatterServices.GetUninitializedObject(typeof(Product));
            DialogResult result = this.view.OpenForCreation(newProduct);
            return result == DialogResult.OK
                ? newProduct
                : null;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the user management window in user creation mode.", ex);
        }
    }
    public Product CreateProductInDatabase(Product product) {
        try {
            return this.produitsDAO.Create(product);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to insert a new user in the database.", ex);
        }
    }

}
