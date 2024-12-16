using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.VisualBasic.ApplicationServices;
using Project_Utilities.Enums;
using System.Diagnostics;

namespace _420DA3_A24_Projet.Presentation.Views;
internal partial class ProductView : Form {
    private bool isInitialized = false;
    private readonly WsysApplication parentApp;


    public ViewActionsEnum CurrentAction { get; private set; }

    public Product CurrentEntityInstance { get; private set; } = null!;
    public ProductView(WsysApplication parentApp) {
        this.parentApp = parentApp;
        this.InitializeComponent();
    }

    private void label6_Click(object sender, EventArgs e) {

    }

    private void button1_Click(object sender, EventArgs e) {

    }

    public DialogResult OpenForCreation(Product instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Creation, "Création d'un produits", "Créer");
        return this.ShowDialog();
    }

    internal object OpenForView(Product product) {
        throw new NotImplementedException();
    }

    internal DialogResult OpenForModification(Product product) {
        throw new NotImplementedException();
    }

    internal DialogResult OpenForDeletion(Product product) {
        throw new NotImplementedException();
    }
    private void Initialize() {
        if (!this.isInitialized) {
            //this.ReloadSelectors();
            this.isInitialized = true;
        }
    }
    private Product SaveDataFromControls(Product product) {
        product.ProductName = this.productName.Text;
        product.ProductDescription = this.txtDescription.Text;
        product.UpcCode = this.txtUpcCode.Text;
        product.InStockQty = Convert.ToInt32(this.numericUpDownStock);
        product.WeightKg = Convert.ToInt32(this.numericUpDownStock);
      


        return product;
    }
    private void PreOpenSetup(Product instance, ViewActionsEnum action, string windowTitle, string actionButtonText) {
        // load selectors with items if not loaded
        this.Initialize();
        // remember what the current action is
        this.CurrentAction = action;
        // remember which instance we are currently working with
        this.CurrentEntityInstance = instance;
        // Change window title
        this.Text = windowTitle;
        // change action button text
        // this.btnAction.Text = actionButtonText;
        // display the current action in the top bar
        //this.openendModeValue.Text = Enum.GetName(action);
        // load data from the current instance in the controls
        // _ = this.LoadDataInControls(instance);
        // activate or deactivate the editable controls depending on the action
        // if (action == ViewActionsEnum.Creation || action == ViewActionsEnum.Edition) {
        //     this.ActivateControls();
        // } else {
        //     this.DeactivateControls();
        // }
    }
     
    private void btnApply_Click(object sender, EventArgs e) {
        try {

            switch (this.CurrentAction) {
                case ViewActionsEnum.Creation:
                    _ = this.SaveDataFromControls(this.CurrentEntityInstance);
                    this.CurrentEntityInstance = this.parentApp.ProductService.CreateProductInDatabase(this.CurrentEntityInstance);
                    break;
               
                default:
                    throw new NotImplementedException($"The view action [{Enum.GetName(this.CurrentAction)}] is not implemented in [{this.GetType().ShortDisplayName}].");
            }
            this.DialogResult = DialogResult.OK;

        } catch (Exception ex) {
            WsysApplication.HandleException(ex);
        }
    }
}
