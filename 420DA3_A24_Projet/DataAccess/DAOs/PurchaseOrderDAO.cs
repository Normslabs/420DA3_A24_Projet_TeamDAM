using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;

namespace _420DA3_A24_Projet.DataAccess.DAOs;

/// <summary>
/// DAO pour la gestion des ordres de restockage.
/// </summary>
internal class PurchaseOrderDAO {

    private readonly WsysDbContext context;

    /// <summary>
    /// Constructeur du DAO des ordres de restockage.
    /// </summary>
    /// <param name="context">Contexte de la base de données.</param>
    public PurchaseOrderDAO(WsysDbContext context) {
        this.context = context;
    }

    /// <summary>
    /// Récupère un ordre de restockage par son ID.
    /// </summary>
    /// <param name="id">Identifiant de l'ordre.</param>
    /// <param name="includeDeleted">Inclure ou non les ordres supprimés.</param>
    /// <returns>L'ordre de restockage correspondant ou <c>null</c>.</returns>
    public PurchaseOrder? GetById(int id, bool includeDeleted = false) {
        return this.context.PurchaseOrders
            .Where(po => po.Id == id && (includeDeleted || po.DateDeleted == null))
            .Include(po => po.Product)
            .Include(po => po.Warehouse)
            .SingleOrDefault();
    }

    /// <summary>
    /// Recherche des ordres de restockage selon un critère.
    /// </summary>
    /// <param name="criterion">Critère de recherche.</param>
    /// <param name="includeDeleted">Inclure ou non les ordres supprimés.</param>
    /// <returns>Liste des ordres correspondant au critère.</returns>
    public List<PurchaseOrder> Search(string criterion, bool includeDeleted = false) {
        return this.context.PurchaseOrders
            .Where(po => (
                po.Id.ToString().Contains(criterion)
                || po.ProductId.ToString().Contains(criterion)
                || po.WarehouseId.ToString().Contains(criterion)
            ) && (includeDeleted || po.DateDeleted == null))
            .Include(po => po.Product)
            .Include(po => po.Warehouse)
            .ToList();
    }

    /// <summary>
    /// Crée un nouvel ordre de restockage.
    /// </summary>
    /// <param name="purchaseOrder">Ordre de restockage à créer.</param>
    /// <returns>Ordre créé.</returns>
    public PurchaseOrder Create(PurchaseOrder purchaseOrder) {
        _ = this.context.PurchaseOrders.Add(purchaseOrder);
        _ = this.context.SaveChanges();
        return purchaseOrder;
    }

    /// <summary>
    /// Met à jour un ordre de restockage existant.
    /// </summary>
    /// <param name="purchaseOrder">Ordre à mettre à jour.</param>
    /// <returns>Ordre mis à jour.</returns>
    public PurchaseOrder Update(PurchaseOrder purchaseOrder) {
        purchaseOrder.DateModified = DateTime.Now;
        _ = this.context.PurchaseOrders.Update(purchaseOrder);
        _ = this.context.SaveChanges();
        return purchaseOrder;
    }

    /// <summary>
    /// Supprime un ordre de restockage (soft delete par défaut).
    /// </summary>
    /// <param name="purchaseOrder">Ordre à supprimer.</param>
    /// <param name="softDeletes">Indique si la suppression est logique (soft delete).</param>
    /// <returns>Ordre supprimé.</returns>
    public PurchaseOrder Delete(PurchaseOrder purchaseOrder, bool softDeletes = true) {
        if (softDeletes) {
            purchaseOrder.DateDeleted = DateTime.Now;
            _ = this.context.PurchaseOrders.Update(purchaseOrder);
        } else {
            _ = this.context.PurchaseOrders.Remove(purchaseOrder);
        }
        _ = this.context.SaveChanges();
        return purchaseOrder;
    }

    /// <summary>
    /// Récupère tous les ordres avec un statut spécifique.
    /// </summary>
    /// <param name="status">Statut de l'ordre.</param>
    /// <param name="includeDeleted">Inclure ou non les ordres supprimés.</param>
    /// <returns>Liste des ordres avec le statut spécifié.</returns>
    public List<PurchaseOrder> GetByStatus(PurchaseOrder.OrderStatus status, bool includeDeleted = false) {
        return this.context.PurchaseOrders
            .Where(po => po.Status == status && (includeDeleted || po.DateDeleted == null))
            .Include(po => po.Product)
            .Include(po => po.Warehouse)
            .ToList();
    }
}
