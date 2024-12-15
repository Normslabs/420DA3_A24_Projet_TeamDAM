using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Services;
public class ProduitsService {
    private readonly ProduitDAO produitsDao;

    public ProduitsService(ProduitDAO produitsDao) {
        this.produitsDao = produitsDao;
    }

    // Méthode pour récupérer tous les produits
    public async Task<IEnumerable<Produit>> GetAllProduitsAsync() {
        return await produitsDao.GetAllProduitsAsync();
    }

    // Méthode pour récupérer un produit par son ID
    public async Task<Produit?> GetProduitByIdAsync(int id) {
        return await produitsDao.GetProduitByIdAsync(id);
    }

    // Méthode pour créer un nouveau produit
    public bool CreateProduit(Produit produit) {
        return produitsDao.CreateProduit(produit);
    }

    // Méthode pour mettre à jour un produit
    public bool UpdateProduit(Produit produit) {
        return this.produitsDao.UpdateProduitAsync(produit);
    }

    // Méthode pour supprimer un produit
    public async Task<bool> DeleteProduitAsync(int id) {
        return await produitsDao.DeleteProduitAsync(id);
    }
}
