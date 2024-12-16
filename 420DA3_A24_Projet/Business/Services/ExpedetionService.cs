using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.DAOs;

namespace _420DA3_A24_Projet.Business.Services;
{
    /// <summary>
    /// Service for managing Expedition business logic.
    /// </summary>
    public class ExpeditionService {
    private readonly ExpeditionDAO _expeditionDao;

    public ExpeditionService(ExpeditionDAO expeditionDao) {
        _expeditionDao = expeditionDao;
    }

    /// <summary>
    /// Creates a new expedition and generates a tracking code.
    /// </summary>
    /// <param name="serviceLivraison">The delivery service (e.g., Purolator, PostesCanada, FedEx).</param>
    /// <returns>The created Expedition object.</returns>
    public async Task<Expedition> CreateExpeditionAsync(string serviceLivraison) {
        if (string.IsNullOrWhiteSpace(serviceLivraison)) {
            throw new ArgumentException("Le service de livraison est requis.", nameof(serviceLivraison));
        }

        return await _expeditionDao.CreateExpeditionWithTrackingAsync(serviceLivraison);
    }

    /// <summary>
    /// Retrieves an expedition by its ID.
    /// </summary>
    /// <param name="id">The ID of the expedition.</param>
    /// <returns>The Expedition object if found, null otherwise.</returns>
    public async Task<Expedition?> GetExpeditionByIdAsync(int id) {
        return await _expeditionDao.GetExpeditionByIdAsync(id);
    }

    /// <summary>
    /// Retrieves all expeditions.
    /// </summary>
    /// <returns>A list of all expeditions.</returns>
    public async Task<List<Expedition>> GetAllExpeditionsAsync() {
        return await _expeditionDao.GetAllExpeditionsAsync();
    }

    /// <summary>
    /// Updates an existing expedition.
    /// </summary>
    /// <param name="expedition">The expedition to update.</param>
    /// <returns>True if the update was successful, false otherwise.</returns>
    public async Task<bool> UpdateExpeditionAsync(Expedition expedition) {
        if (expedition == null) {
            throw new ArgumentNullException(nameof(expedition), "L'expédition ne peut pas être nulle.");
        }

        return await _expeditionDao.UpdateExpeditionAsync(expedition);
    }

    /// <summary>
    /// Deletes an expedition by its ID.
    /// </summary>
    /// <param name="id">The ID of the expedition to delete.</param>
    /// <returns>True if the deletion was successful, false otherwise.</returns>
    public async Task<bool> DeleteExpeditionAsync(int id) {
        return await _expeditionDao.DeleteExpeditionAsync(id);
    }

    /// <summary>
    /// Validates the delivery service name.
    /// </summary>
    /// <param name="serviceLivraison">The delivery service name to validate.</param>
    private void ValidateServiceLivraison(string serviceLivraison) {
        var validServices = new List<string> { "Purolator", "PostesCanada", "FedEx" };

        if (!validServices.Contains(serviceLivraison)) {
            throw new ArgumentException($"Le service de livraison '{serviceLivraison}' n'est pas valide.");
        }
    }
}
}
