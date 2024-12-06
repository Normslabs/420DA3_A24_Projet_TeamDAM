using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Services;
public class EntrepotService {
    private readonly EntrepotDAO _entrepotDao;

    // Inject DAO through constructor
    public EntrepotService(EntrepotDAO entrepotDao) {
        _entrepotDao = entrepotDao;
    }

    // Méthode pour récupérer tous les entrepôts
    public async Task<IEnumerable<Entrepot>> GetAllEntrepotsAsync() {
        return await _entrepotDao.GetAllEntrepotsAsync();
    }

    // Méthode pour récupérer un entrepôt par son ID
    public async Task<Entrepot?> GetEntrepotByIdAsync(int id) {
        return await _entrepotDao.GetEntrepotByIdAsync(id);
    }

    // Méthode pour créer un nouvel entrepôt
    public async Task<bool> CreateEntrepotAsync(Entrepot entrepot) {
        return await _entrepotDao.CreateEntrepotAsync(entrepot);
    }

    // Méthode pour mettre à jour un entrepôt
    public async Task<bool> UpdateEntrepotAsync(Entrepot entrepot) {
        return await _entrepotDao.UpdateEntrepotAsync(entrepot);
    }

    // Méthode pour supprimer un entrepôt
    public async Task<bool> DeleteEntrepotAsync(int id) {
        return await _entrepotDao.DeleteEntrepotAsync(id);
    }
}
