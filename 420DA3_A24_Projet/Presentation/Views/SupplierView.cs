using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Project_Utilities.Enums;
using System.Data;

namespace _420DA3_A24_Projet.Presentation.Views;

/// <summary>
/// Management window for <see cref="Supplier"/> entities.
/// </summary>
internal partial class SupplierView : Form {

    private bool isInitialized = false;
    private readonly WsysApplication parentApp;

    /// <summary>
    /// The <see cref="ViewActionsEnum"/> value indicating the intent for which the window
    /// is currently opened or was opened last.
    /// </summary>
    public ViewActionsEnum CurrentAction { get; private set; }
    /// <summary>
    /// The working <see cref="Supplier"/> value with which the window is currently
    /// opened or was opened last.
    /// </summary>
    public Supplier CurrentEntityInstance { get; private set; } = null!;

    /// <summary>
    /// <see cref="SupplierView"/> constructor.
    /// </summary>
    /// <param name="application"></param>
    public SupplierView(WsysApplication application) {
        this.parentApp = application;
        this.InitializeComponent();
    }
    /// <summary>
    /// Opens a <see cref="SupplierView"/> modal window in entity creation mode.
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForCreation(Supplier instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Creation, "Création d'un fournisseur", "Créer");
        return this.ShowDialog();
    }
    /// <summary>
    /// Opens a <see cref="SupplierView"/> modal window in entity visualization mode.
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForDetailsView(Supplier instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Visualization, "Détails d'un fournisseur", "OK");
        return this.ShowDialog();
    }
    /// <summary>
    /// Opens a <see cref="SupplierView"/> modal window in entity visualization mode.
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForModification(Supplier instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Edition, "Modifier un fournisseur", "Enregistrer");
        return this.ShowDialog();
    }

    /// <summary>
    /// Opens a <see cref="SupplierView"/> modal window in entity visualization mode.
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForDeletion(Supplier instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Deletion, "Supprimer un fournisseur", "Supprimer");
        return this.ShowDialog();
    }
    /// <summary>
    /// Performs pre-opening initialization, clean-up and preparation for the <see cref="UserView"/> window.
    /// </summary>
    /// <param name="instance"></param>
    /// <param name="action"></param>
    /// <param name="windowTitle"></param>
    /// <param name="actionButtonText"></param>
    private void PreOpenSetup(Supplier instance, ViewActionsEnum action, string windowTitle, string actionButtonText) {
        // load selectors with items if not loaded
        this.Initialize();
        // remember what the current action is
        this.CurrentAction = action;
        // remember which instance we are currently working with
        this.CurrentEntityInstance = instance;
        // Change window title
        this.Text = windowTitle;
        // change action button text
        this.btnAction.Text = actionButtonText;
        // display the current action in the top bar
        this.openendModeValue.Text = Enum.GetName(action);
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
    /// Enables the <see cref="SupplierView"/> window's controls for creation and edition modes.
    /// </summary>
    private void ActivateControls() {
        this.suppliernameValue.Enabled = true;
        this.contactfirstnameValue.Enabled = true;
        this.contactlastnameValue.Enabled = true;
        this.contactemailValue.Enabled = true;
        this.contactphoneValue.Enabled = true;
    }

    /// <summary>
    /// Disables the <see cref="SupplierView"/> window's controls for visualization and deletion modes.
    /// </summary>
    private void DeactivateControls() {
        this.suppliernameValue.Enabled = false;
        this.contactfirstnameValue.Enabled = false;
        this.contactlastnameValue.Enabled = false;
        this.contactemailValue.Enabled = false;
        this.contactphoneValue.Enabled = false;
    }

    /// <summary>
    /// Ensures that the selector controls of the <see cref="SupplierView"/> window
    /// with static content have their items populated.
    /// </summary>
    private void Initialize() {
        if (!this.isInitialized) {
            this.ReloadSelectors();
            this.isInitialized = true;
        }
    }



    private void actionBtn_Click(object sender, EventArgs e) {
        try {

            switch (this.CurrentAction) {
                case ViewActionsEnum.Creation:
                    _ = this.SaveDataFromControls(this.CurrentEntityInstance);
                    this.CurrentEntityInstance = this.parentApp.SupplierService.CreateNewSupplier(this.CurrentEntityInstance);
                    break;
                case ViewActionsEnum.Edition:
                    _ = this.SaveDataFromControls(this.CurrentEntityInstance);
                    this.CurrentEntityInstance = this.parentApp.SupplierService.UpdateSupplier(this.CurrentEntityInstance);
                    break;
                case ViewActionsEnum.Deletion:
                    this.CurrentEntityInstance = this.parentApp.SupplierService. (this.CurrentEntityInstance);
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
    /// <summary>
    /// Fills the roles and warehouse selectors of the <see cref="SupplierView"/> window with all
    /// the existing <see cref="Product"/> Value
    /// </summary>
    private void ReloadSelectors() {
        try {
            this.supplierproductsValues.Items.Clear();
            List<Product> products = this.parentApp.ProductService.GetAllProduitsAsync();
            foreach (Role product in products) {
                _ = this.supplierproductsValues.Items.Add(product);
            }
        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to load data in selectors.", ex);
        }
    }



    private void cancelBtn_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }
}
