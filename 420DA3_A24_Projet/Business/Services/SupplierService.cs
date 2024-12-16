using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Project_Utilities.Enums;
using System.Runtime.Serialization;

namespace _420DA3_A24_Projet.Business.Services;

internal class SupplierService {
    private readonly SupplierDAO supplierDAO;
    private readonly SupplierView supplierWindow;

    public SupplierService(WsysApplication parentApp, WsysDbContext context) {
        this.supplierDAO = new SupplierDAO(context);
        this.supplierWindow = new SupplierView(parentApp);
    }

    /// <summary>
    /// Opens the <see cref="SupplierView">user management window</see> in deletion mode
    /// for the given <paramref name="supplier"/>.
    /// </summary>
    /// <param name="supplier"></param>
    /// <returns></returns>
    public Supplier? OpenViewFor(ViewActionsEnum viewAction, Supplier? supplier = null) {
        try {
            switch (viewAction) {
                case ViewActionsEnum.Creation:
                    // Création d'un nouvel objet Supplier non initialisé
                    Supplier newSupplier = (Supplier) FormatterServices.GetUninitializedObject(typeof(Supplier));
                    DialogResult creationResult = this.supplierWindow.OpenForCreation(newSupplier);
                    return creationResult == DialogResult.OK ? newSupplier : null;

                case ViewActionsEnum.Edition:
                    if (supplier == null) {
                        throw new ArgumentNullException(nameof(supplier), "Supplier must be provided for editing.");
                    }
                    DialogResult editResult = this.supplierWindow.OpenForModification(supplier);
                    if (editResult == DialogResult.OK) {
                        // Ouvre la vue en mode visualisation après modification
                        _ = this.OpenViewFor(ViewActionsEnum.Visualization, supplier);
                        return supplier;
                    }
                    return null;

                case ViewActionsEnum.Deletion:
                    if (supplier == null) {
                        throw new ArgumentNullException(nameof(supplier), "Supplier must be provided for deletion.");
                    }
                    DialogResult deleteResult = this.supplierWindow.OpenForDeletion(supplier);
                    if (deleteResult == DialogResult.OK) {
                        // Marque l'objet comme supprimé et retourne null
                        supplier.DateDeleted = DateTime.Now;
                        return null;
                    }
                    return supplier;


                default:
                    throw new Exception($"The view action '{viewAction}' is not supported.");
            }
        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the user management window in suppllier .", ex);
        }
    }

    public Supplier? OpenSupplierWindowForDetailsView(Supplier supplier) {
        DialogResult result = this.supplierWindow.OpenForDetailsView(supplier);
        return result == DialogResult.OK ? supplier : null;
    }

    public Supplier? OpenSupplierWindowForEdition(Supplier supplier) {
        DialogResult result = this.supplierWindow.OpenForModification(supplier);
        return result == DialogResult.OK ? supplier : null;
    }

    public Supplier? OpenSupplierWindowForDeletion(Supplier supplier) {
        DialogResult result = this.supplierWindow.OpenForDeletion(supplier);
        return result == DialogResult.OK ? supplier : null;
    }

    public Supplier? GetById(int id, bool includeDeleted = false) {
        return this.supplierDAO.GetById(id, includeDeleted);
    }
    /// <summary>
    /// Returns the list of every <see cref="Supplier"/> that match the given <paramref name="criterion"/> in the data source.
    /// </summary>
    /// <param name="criterion"></param>
    /// <returns></returns>
    public List<Supplier> Search(string criterion) {
        try {
            return this.supplierDAO.Search(criterion);
        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to search suppliers with criterion [{criterion}].", ex);
        }
    }
    /// <summary>
    /// Inserts a <see cref="Supplier"/> in the data source.
    /// </summary>
    /// <param name="supplier"></param>
    /// <returns></returns>
    public Supplier CreateNewSupplier(Supplier supplier) {
        try {
            return this.supplierDAO.Create(supplier);
        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to create a new supplier.", ex);
        }
    }

    /// <summary>
    /// Updates a <see cref="Supplier"/> in the data source.
    /// </summary>
    /// <param name="supplier"></param>
    /// <returns></returns>
    public Supplier UpdateSupplier(Supplier supplier) {
        try {
            return this.supplierDAO.Update(supplier);
        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to update supplier with ID [{supplier.Id}].", ex);
        }
    }
    /// <summary>
    /// Deletes a <see cref="Supplier"/> from the data source.
    /// </summary>
    /// <param name="supplier"></param>
    /// <returns></returns>
    public Supplier DeleteSupplier(Supplier supplier) {
        try {
            return this.supplierDAO.Delete(supplier);
        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to delete supplier with ID [{supplier.Id}].", ex);
        }
    }
}
