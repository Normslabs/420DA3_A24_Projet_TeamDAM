using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;

namespace _420DA3_A24_Projet.DataAccess.DAOs;

/// <summary>
/// DAO pour la gestion des fournisseurs.
/// </summary>
internal class SupplierDAO {

    private readonly WsysDbContext context;

    /// <summary>
    /// Constructeur du DAO de fournisseur.
    /// </summary>
    /// <param name="context">Contexte de la base de données.</param>
    public SupplierDAO(WsysDbContext context) {
        this.context = context;
    }

    /// <summary>
    /// Récupère un fournisseur par son ID.
    /// </summary>
    /// <param name="id">Identifiant du fournisseur.</param>
    /// <param name="includeDeleted">Inclure ou non les fournisseurs supprimés.</param>
    /// <returns>Le fournisseur correspondant ou <c>null</c>.</returns>
    public Supplier? GetById(int id, bool includeDeleted = false) {
        return this.context.Suppliers
            .Where(supplier => supplier.Id == id && (includeDeleted || supplier.DateDeleted == null))
            .SingleOrDefault();
    }

    /// <summary>
    /// Recherche de fournisseurs en fonction d'un critère.
    /// </summary>
    /// <param name="criterion">Critère de recherche.</param>
    /// <param name="includeDeleted">Inclure ou non les fournisseurs supprimés.</param>
    /// <returns>Liste des fournisseurs correspondant au critère.</returns>
    public List<Supplier> Search(string criterion, bool includeDeleted = false) {
        return this.context.Suppliers
            .Where(supplier => (
                supplier.Id.ToString().Contains(criterion)
                || supplier.Name.ToLower().Contains(criterion.ToLower())
                || supplier.ContactFirstName.ToLower().Contains(criterion.ToLower())
                || supplier.ContactLastName.ToLower().Contains(criterion.ToLower())
                || supplier.ContactEmail.ToLower().Contains(criterion.ToLower())
            ) && (includeDeleted || supplier.DateDeleted == null))
            .ToList();
    }

    /// <summary>
    /// Crée un nouveau fournisseur.
    /// </summary>
    /// <param name="supplier">Fournisseur à créer.</param>
    /// <returns>Fournisseur créé.</returns>
    public Supplier Create(Supplier supplier) {
        _ = this.context.Suppliers.Add(supplier);
        _ = this.context.SaveChanges();
        return supplier;
    }

    /// <summary>
    /// Met à jour un fournisseur existant.
    /// </summary>
    /// <param name="supplier">Fournisseur à mettre à jour.</param>
    /// <returns>Fournisseur mis à jour.</returns>
    public Supplier Update(Supplier supplier) {
        supplier.DateModified = DateTime.Now;
        _ = this.context.Suppliers.Update(supplier);
        _ = this.context.SaveChanges();
        return supplier;
    }

    /// <summary>
    /// Supprime un fournisseur (soft delete par défaut).
    /// </summary>
    /// <param name="supplier">Fournisseur à supprimer.</param>
    /// <param name="softDeletes">Indique si la suppression est logique (soft delete).</param>
    /// <returns>Fournisseur supprimé.</returns>
    public Supplier Delete(Supplier supplier, bool softDeletes = true) {
        if (softDeletes) {
            supplier.DateDeleted = DateTime.Now;
            _ = this.context.Suppliers.Update(supplier);
        } else {
            _ = this.context.Suppliers.Remove(supplier);
        }
        _ = this.context.SaveChanges();
        return supplier;
    }
}
