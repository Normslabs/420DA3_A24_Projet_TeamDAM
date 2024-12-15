using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Project_Utilities.Enums;
using System.Runtime.Serialization;

namespace _420DA3_A24_Projet.Business.Services;

internal class PurchaseOrderService {

    private readonly PurchaseOrderDAO dao;
    private readonly PurchaseOrderView view;

    public PurchaseOrderService(WsysApplication parentApp, WsysDbContext context) {
        this.dao = new PurchaseOrderDAO(context);
        this.view = new PurchaseOrderView(parentApp);
    }

    public PurchaseOrder? OpenViewFor(ViewActionsEnum viewAction, PurchaseOrder purchaseOrder = null) {
        try {
            switch (viewAction) {
                case ViewActionsEnum.Creation:
                    PurchaseOrder newPurchaseOrder = (PurchaseOrder) FormatterServices.GetUninitializedObject(typeof(PurchaseOrder));
                    DialogResult creationResult = this.view.OpenForCreation(newPurchaseOrder);
                    return creationResult == DialogResult.OK ? newPurchaseOrder : null;

                case ViewActionsEnum.Edition:
                    if (purchaseOrder == null) {
                        throw new ArgumentNullException(nameof(purchaseOrder), "PurchaseOrder must be provided for editing.");
                    }
                    DialogResult editResult = this.view.OpenForEdition(purchaseOrder);
                    if (editResult == DialogResult.OK) {
                       
                        _ = this.OpenViewFor(ViewActionsEnum.Visualization, purchaseOrder);
                        return purchaseOrder;
                    }
                    return null;

                case ViewActionsEnum.Deletion:
                    if (purchaseOrder == null) {
                        throw new ArgumentNullException(nameof(purchaseOrder), "Supplier must be provided for deletion.");
                    }
                    DialogResult deleteResult = this.view.OpenForDeletion(purchaseOrder);
                    if (deleteResult == DialogResult.OK) {
                        // Marque l'objet comme supprimé et retourne null
                        purchaseOrder.DateDeleted = DateTime.Now;
                        return null;
                    }
                    return purchaseOrder;


                default:
                    throw new Exception($"The view action '{viewAction}' is not supported.");
            }
        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the user management window in suppllier .", ex);
        }
    }

    public PurchaseOrder? OpenPurchaseOrderWindowForCreation() {
        PurchaseOrder newOrder = (PurchaseOrder) FormatterServices.GetUninitializedObject(typeof(PurchaseOrder));
        DialogResult result = this.view.OpenForCreation(newOrder);
        return result == DialogResult.OK ? newOrder : null;
    }

    public PurchaseOrder? OpenPurchaseOrderWindowForDetailsView(PurchaseOrder order) {
        DialogResult result = this.view.OpenForDetailsView(order);
        return result == DialogResult.OK ? order : null;
    }

    public PurchaseOrder? OpenPurchaseOrderWindowForEdition(PurchaseOrder order) {
        DialogResult result = this.view.OpenForEdition(order);
        return result == DialogResult.OK ? order : null;
    }

    public PurchaseOrder? OpenPurchaseOrderWindowForDeletion(PurchaseOrder order) {
        DialogResult result = this.view.OpenForDeletion(order);
        return result == DialogResult.OK ? order : null;
    }

    public PurchaseOrder? GetById(int id, bool includeDeleted = false) {
        return this.dao.GetById(id, includeDeleted);
    }


    /// <summary>
    /// Creates a new <see cref="PurchaseOrder"/> in the data source.
    /// </summary>
    /// <param name="order">The <see cref="PurchaseOrder"/> to create.</param>
    /// <returns>The created <see cref="PurchaseOrder"/>.</returns>
    public PurchaseOrder CreateNewPurchaseOrder(PurchaseOrder order) {
        try {
            return this.dao.Create(order);
        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to create a new purchase order.", ex);
        }
    }

    /// <summary>
    /// Updates a <see cref="PurchaseOrder"/> in the data source.
    /// </summary>
    /// <param name="order">The <see cref="PurchaseOrder"/> to update.</param>
    /// <returns>The updated <see cref="PurchaseOrder"/>.</returns>
    public PurchaseOrder UpdatePurchaseOrder(PurchaseOrder order) {
        try {
            return this.dao.Update(order);
        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to update purchase order with ID [{order.Id}].", ex);
        }
    }

    /// <summary>
    /// Deletes a <see cref="PurchaseOrder"/> from the data source.
    /// </summary>
    /// <param name="order">The <see cref="PurchaseOrder"/> to delete.</param>
    /// <param name="softDeletes">Indicates whether to perform a soft delete (default is true).</param>
    public void DeletePurchaseOrder(PurchaseOrder order, bool softDeletes = true) {
        try {
            this.dao.Delete(order, softDeletes);
        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to delete purchase order with ID [{order.Id}].", ex);
        }
    }
}
