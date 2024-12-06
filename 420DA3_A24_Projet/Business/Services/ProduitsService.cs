using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Services;
public class ProduitsService {
    private readonly ProduitsDAO _produitsDao;

    // Inject DAO through constructor
    public ProduitsService(ProduitsDAO produitsDao) {
        _produitsDao = produitsDao;
    }

    // Méthode pour récupérer tous les produits
    public async Task<IEnumerable<Produits>> GetAllProduitsAsync() {
        return await _produitsDao.GetAllProduitsAsync();
    }

    // Méthode pour récupérer un produit par son ID
    public async Task<Produits?> GetProduitByIdAsync(int id) {
        return await _produitsDao.GetProduitByIdAsync(id);
    }

    // Méthode pour créer un nouveau produit
    public async Task<bool> CreateProduitAsync(Produits produit) {
        return await _produitsDao.CreateProduitAsync(produit);
    }

    // Méthode pour mettre à jour un produit
    public async Task<bool> UpdateProduitAsync(Produits produit) {
        return await _produitsDao.UpdateProduitAsync(produit);
    }

    // Méthode pour supprimer un produit
    public async Task<bool> DeleteProduitAsync(int id) {
        return await _produitsDao.DeleteProduitAsync(id);
    }
}
