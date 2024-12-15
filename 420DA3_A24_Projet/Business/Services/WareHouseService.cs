using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.DAOs;

namespace _420DA3_A24_Projet.Business.Services;
public class WareHouseService {
    private readonly WarehouseDAO warehouseDAO;

    public WareHouseService(WarehouseDAO warehouse) {
        this.warehouseDAO = warehouse;
    }

    // Méthode pour récupérer tous les entrepôts
    public async Task<IEnumerable<Warehouse>> GetAllEntrepotsAsync() {
        return await this.warehouseDAO.GetAllEntrepotsAsync();
    }

    // Méthode pour récupérer un entrepôt par son ID
    public async Task<Domain.Warehouse?> GetEntrepotByIdAsync(int id) {
        return await this.warehouseDAO.GetEntrepotByIdAsync(id);
    }

    // Méthode pour créer un nouvel entrepôt
    public bool CreateEntrepot(Warehouse warehouse) {
        return this.warehouseDAO.CreateEntrepot(warehouse);
    }

    // Méthode pour mettre à jour un entrepôt
    public async Task<bool> UpdateEntrepotAsync(Warehouse warehouse) {
        return await this.warehouseDAO.UpdateEntrepotAsync(warehouse);
    }

    // Méthode pour supprimer un entrepôt
    public async Task<bool> DeleteEntrepotAsync(int id) {
        return await this.warehouseDAO.DeleteEntrepotAsync(id);
    }
}
