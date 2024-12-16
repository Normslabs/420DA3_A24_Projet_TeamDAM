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
            .Include(po => po.ProductId)
            .Include(po => po.Warehouse)
            .SingleOrDefault();
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
    public void Delete(PurchaseOrder purchaseOrder, bool softDeletes = true) {
        if (softDeletes) {
            purchaseOrder.DateDeleted = DateTime.Now;
            _ = this.context.PurchaseOrders.Update(purchaseOrder);
        } else {
            _ = this.context.PurchaseOrders.Remove(purchaseOrder);
        }
        _ = this.context.SaveChanges();
    }
    /// <summary>
    /// Récupère les ordres par entrepôt et statut (optionnel).
    /// </summary>
    /// <param name="warehouse">Entrepôt cible.</param>
    /// <param name="status">Statut de commande (optionnel).</param>
    /// <returns>Liste des ordres correspondant aux critères.</returns>
    public List<PurchaseOrder> GetByWarehouse(Warehouse warehouse, PurchaseOrder.OrderStatus? status = null) {
        return this.context.PurchaseOrders
            .Where(po => po.WarehouseId == warehouse.Id && (status == null || po.Status == status))
            .Include(po => po.ProductId)
            .Include(po => po.WarehouseId)
            .ToList();
    }
    /// <summary>
    /// Récupère les ordres par produit et statut (optionnel).
    /// </summary>
    /// <param name="product">Produit cible.</param>
    /// <param name="status">Statut de commande (optionnel).</param>
    /// <returns>Liste des ordres correspondant aux critères.</returns>
    public List<PurchaseOrder> GetByProduct(Product product, PurchaseOrder.OrderStatus? status = null) {
        return this.context.PurchaseOrders
            .Where(po => po.ProductId == product.ProductId && (status == null || po.Status == status))
            .Include(po => po.ProductId)
            .Include(po => po.WarehouseId)
            .ToList();
    }

}
