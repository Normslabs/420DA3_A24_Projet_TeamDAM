using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Services;
public class EntrepotService {
    private readonly EntrepotDAO entrepotDao;

    public EntrepotService(EntrepotDAO entrepotDao) {
        this.entrepotDao = entrepotDao;
    }

    // Méthode pour récupérer tous les entrepôts
    public async Task<IEnumerable<Entrepot>> GetAllEntrepotsAsync() {
        return await entrepotDao.GetAllEntrepotsAsync();
    }

    // Méthode pour récupérer un entrepôt par son ID
    public async Task<Entrepot?> GetEntrepotByIdAsync(int id) {
        return await entrepotDao.GetEntrepotByIdAsync(id);
    }

    // Méthode pour créer un nouvel entrepôt
    public bool CreateEntrepot(Entrepot entrepot) {
        return entrepotDao.CreateEntrepot(entrepot);
    }

    // Méthode pour mettre à jour un entrepôt
    public async Task<bool> UpdateEntrepotAsync(Entrepot entrepot) {
        return await entrepotDao.UpdateEntrepotAsync(entrepot);
    }

    // Méthode pour supprimer un entrepôt
    public async Task<bool> DeleteEntrepotAsync(int id) {
        return await entrepotDao.DeleteEntrepotAsync(id);
    }
}
