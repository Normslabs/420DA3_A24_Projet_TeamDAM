using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.Business;
using Project_Utilities.Enums;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace _420DA3_A24_Projet.Presentation.Views;
internal partial class PurchaseOrderView : Form {
    private readonly WsysApplication parentApp;

    /// <summary>
    /// The <see cref="ViewActionsEnum"/> value indicating the intent for which the window
    /// is currently opened or was opened last.
    /// </summary>
    public ViewActionsEnum CurrentAction { get; private set; }
    /// <summary>
    /// The working <see cref="PurchaseOrder"/> value with which the window is currently
    /// opened or was opened last.
    /// </summary>
    public PurchaseOrder CurrentEntityInstance { get; private set; } = null!;

    /// <summary>
    /// <see cref="PurchaseOrderView"/> constructor.
    /// </summary>
    /// <param name="application"></param>
    public PurchaseOrderView(WsysApplication application) {
        this.parentApp = application;
        this.InitializeComponent();
    }

    /// <summary>
    /// Opens a <see cref="PurchaseOrderView"/> modal window in entity creation mode.
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForCreation(PurchaseOrder instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Creation, "Création", "Créer");
        return this.ShowDialog();
    }

    /// <summary>
    /// Opens a <see cref="PurchaseOrderView"/> modal window in entity visualization mode.
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForDetailsView(PurchaseOrder instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Visualization, "Détails", "OK");
        return this.ShowDialog();
    }

    /// <summary>
    /// Opens a <see cref="PurchaseOrderView"/> modal window in entity edition mode.
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForEdition(PurchaseOrder instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Edition, "Modifier", "Enregistrer");
        return this.ShowDialog();
    }

    /// <summary>
    /// Opens a <see cref="PurchaseOrderView"/> modal window in entity deletion mode.
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForDeletion(PurchaseOrder instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Deletion, "Supprimer", "Supprimer");
        return this.ShowDialog();
    }

    /// <summary>
    /// Performs pre-opening initialization, clean-up and preparation for the <see cref="PurchaseOrderView"/> window.
    /// </summary>
    /// <param name="instance"></param>
    /// <param name="action"></param>
    /// <param name="windowTitle"></param>
    /// <param name="actionButtonText"></param>
    private void PreOpenSetup(PurchaseOrder instance, ViewActionsEnum action, string windowTitle, string actionButtonText) {
        // remember what the current action is
        this.CurrentAction = action;
        // remember which instance we are currently working with
        this.CurrentEntityInstance = instance;
        // Change window title
        this.Text = windowTitle;
        // change action button text
        this.actionButton.Text = actionButtonText;
        // load data from the current instance in the controls
        _ = this.LoadDataInControls(instance);
        // activate or deactivate the editable controls depending on the action
        if (action == ViewActionsEnum.Creation || action == ViewActionsEnum.Edition) {
            this.ActivateControls();
        } else {
            this.DeactivateControls();
        }
    }

    /// <summary>
    /// Enables the <see cref="PurchaseOrderView"/> window's controls for creation and edition modes.
    /// </summary>
    private void ActivateControls() {
        this.quantityValue.Enabled = true;
        this.warehouseIdValue.Enabled = true;
    }

    /// <summary>
    /// Disables the <see cref="PurchaseOrderView"/> window's controls for visualization and deletion modes.
    /// </summary>
    private void DeactivateControls() {
        this.quantityValue.Enabled = false;
        this.warehouseIdValue.Enabled = false;
    }
    private PurchaseOrder LoadDataInControls(PurchaseOrder purchaseOrder) {
        this.POIdValue.Value = purchaseOrder.Id;
        this.warehouseIdValue.Text = purchaseOrder.Warehouse.ToString();
        this.quantityValue.Text = purchaseOrder.Quantity.ToString();
        this.dateTimePicker1.Value = purchaseOrder.DateCreated;
        this.dateTimePicker2.Value = purchaseOrder.DateModified ?? DateTime.Now;
        this.dateTimePicker3.Value = purchaseOrder.DateDeleted ?? DateTime.Now;
        return purchaseOrder;
    }

    private PurchaseOrder SaveDataFromControls(PurchaseOrder purchaseOrder) {
        return purchaseOrder;
    }


    private void actionButton_Click(object sender, EventArgs e) {
        try {

            switch (this.CurrentAction) {
                case ViewActionsEnum.Creation:
                    _ = this.SaveDataFromControls(this.CurrentEntityInstance);
                    this.CurrentEntityInstance = this.parentApp.PurchaseOrderService.CreateNewPurchaseOrder(this.CurrentEntityInstance);
                    break;
                case ViewActionsEnum.Edition:
                    _ = this.SaveDataFromControls(this.CurrentEntityInstance);
                    this.CurrentEntityInstance = this.parentApp.PurchaseOrderService.UpdatePurchaseOrder(this.CurrentEntityInstance);
                    break;
                case ViewActionsEnum.Deletion:
                    this.CurrentEntityInstance = this.parentApp.PurchaseOrderService.DeletePurchaseOrder(this.CurrentEntityInstance);
                    break;
                case ViewActionsEnum.Visualization:
                    break;
                default:
                    throw new NotImplementedException($"The view action [{Enum.GetName(this.CurrentAction)}] is not implemented in [{this.GetType().ShortDisplayName}].");
            }
            this.DialogResult = DialogResult.OK;

        } catch (Exception ex) {
            WsysApplication.HandleException(ex);
        }

    }

    private void cancelButton_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;

    }
}
