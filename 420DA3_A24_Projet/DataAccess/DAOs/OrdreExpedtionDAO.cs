{
    /// <summary>
    /// DAO for managing OrdreExpedition entities.
    /// </summary>
    public class OrdreExpeditionDAO {
    private readonly DbContext _context;

    public OrdreExpeditionDAO(DbContext context) {
        _context = context;
    }

    // Creer
    public async Task<OrdreExpedition> AddOrdreExpeditionAsync(OrdreExpedition ordreExpedition) {
        _context.Set<OrdreExpedition>().Add(ordreExpedition);
        await _context.SaveChangesAsync();
        return ordreExpedition;
    }

    // Lire 
    public async Task<OrdreExpedition?> GetOrdreExpeditionByIdAsync(int id) {
        return await _context.Set<OrdreExpedition>()
            .Include(o => o.Client)
            .Include(o => o.Createur)
            .Include(o => o.LiensProduits)
                .ThenInclude(lp => lp.Produit)
            .Include(o => o.Adresse)
            .Include(o => o.EmployeEntrepot)
            .Include(o => o.Expedition)
            .FirstOrDefaultAsync(o => o.Id == id);
    }

    // Lire - Get All
    public async Task<List<OrdreExpedition>> GetAllOrdresExpeditionAsync() {
        return await _context.Set<OrdreExpedition>()
            .Include(o => o.Client)
            .Include(o => o.Createur)
            .Include(o => o.LiensProduits)
                .ThenInclude(lp => lp.Produit)
            .Include(o => o.Adresse)
            .Include(o => o.EmployeEntrepot)
            .Include(o => o.Expedition)
            .ToListAsync();
    }

    // Mettre a jour
    public async Task<bool> UpdateOrdreExpeditionAsync(OrdreExpedition ordreExpedition) {
        _context.Set<OrdreExpedition>().Update(ordreExpedition);
        return await _context.SaveChangesAsync() > 0;
    }

    // Supprimer
    public async Task<bool> DeleteOrdreExpeditionAsync(int id) {
        OrdreExpedition? ordreExpedition = await GetOrdreExpeditionByIdAsync(id);
        if (ordreExpedition == null) {
            return false;
        }

        _context.Set<OrdreExpedition>().Remove(ordreExpedition);
        return await _context.SaveChangesAsync() > 0;
    }

    // Obtenir les ordres par statut
    public async Task<List<OrdreExpedition>> GetOrdresByStatutAsync(string statut) {
        return await _context.Set<OrdreExpedition>()
            .Where(o => o.Statut == statut)
            .ToListAsync();
    }

    // Affecter un employe d'entrepot à un ordre d'expedition
    public async Task<bool> AssignEmployeEntrepotAsync(int ordreId, int employeId) {
        var ordreExpedition = await GetOrdreExpeditionByIdAsync(ordreId);
        if (ordreExpedition == null || ordreExpedition.EmployeEntrepotId != null) {
            return false;
        }

        ordreExpedition.EmployeEntrepotId = employeId;
        ordreExpedition.Statut = "processing";
        return await UpdateOrdreExpeditionAsync(ordreExpedition);
    }

    // Marquer comme emballé
    public async Task<bool> MarkAsPackagedAsync(int ordreId, int expeditionId) {
        var ordreExpedition = await GetOrdreExpeditionByIdAsync(ordreId);
        if (ordreExpedition == null || ordreExpedition.Statut != "processing") {
            return false;
        }

        ordreExpedition.ExpeditionId = expeditionId;
        ordreExpedition.Statut = "packaged";
        return await UpdateOrdreExpeditionAsync(ordreExpedition);
    }

    // Marquer comme expédié
    public async Task<bool> MarkAsShippedAsync(int ordreId, DateTime dateExpedition) {
        var ordreExpedition = await GetOrdreExpeditionByIdAsync(ordreId);
        if (ordreExpedition == null || ordreExpedition.Statut != "packaged") {
            return false;
        }

        ordreExpedition.DateExpedition = dateExpedition;
        ordreExpedition.Statut = "shipped";
        return await UpdateOrdreExpeditionAsync(ordreExpedition);
    }
}
}
