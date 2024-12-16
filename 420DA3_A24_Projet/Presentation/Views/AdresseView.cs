using _420DA3_A24_Projet.Business.Domain;

using _420DA3_A24_Projet.Business;

using Project_Utilities.Enums;

using Org.BouncyCastle.Pqc.Crypto.Lms;

using Microsoft.EntityFrameworkCore.Infrastructure;

namespace _420DA3_A24_Projet.Presentation.Views;

internal partial class AdresseView : Form {

    /// <summary>

    /// Management window for <see cref="Adresse"/> entities.

    /// </summary>


    private bool isInitialized = false;

    private readonly WsysApplication parentApp;

    /// <summary>

    /// The <see cref="ViewActionsEnum"/> value indicating the intent for which the window

    /// is currently opened or was opened last.

    /// </summary>

    public ViewActionsEnum CurrentAction { get; private set; }

    /// <summary>

    /// The working <see cref="Adresse"/> value with which the window is currently

    /// opened or was opened last.

    /// </summary>

    public Adresse CurrentEntityInstance { get; private set; } = null!;

    /// <summary>

    /// <see cref="AdresseView"/> constructor.

    /// </summary>

    /// <param name="application"></param>

    public AdresseView(WsysApplication application) {

        this.parentApp = application;

        this.InitializeComponent();

    }

    /// <summary>

    /// Opens a <see cref="AdresseView"/> modal window in entity creation mode.

    /// </summary>

    /// <param name="instance"></param>

    /// <returns></returns>

    public DialogResult OpenForCreation(Adresse instance) {

        this.PreOpenSetup(instance, ViewActionsEnum.Creation, "Création", "Créer");

        return this.ShowDialog();

    }

    /// <summary>

    /// Opens a <see cref="AdresseView"/> modal window in entity visualization mode.

    /// </summary>

    /// <param name="instance"></param>

    /// <returns></returns>

    public DialogResult OpenForDetailsView(Adresse instance) {

        this.PreOpenSetup(instance, ViewActionsEnum.Visualization, "Détails", "OK");

        return this.ShowDialog();

    }

    /// <summary>

    /// Opens a <see cref="AdresseView"/> modal window in entity visualization mode.

    /// </summary>

    /// <param name="instance"></param>

    /// <returns></returns>

    public DialogResult OpenForModification(Adresse instance) {

        this.PreOpenSetup(instance, ViewActionsEnum.Edition, "Modifier", "Enregistrer");

        return this.ShowDialog();

    }

    /// <summary>

    /// Opens a <see cref="AdresseView"/> modal window in entity visualization mode.

    /// </summary>

    /// <param name="instance"></param>

    /// <returns></returns>

    public DialogResult OpenForDeletion(Adresse instance) {

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

    private void PreOpenSetup(Adresse instance, ViewActionsEnum action, string windowTitle, string actionButtonText) {

        // load selectors with items if not loaded

        this.Initialize();

        // remember what the current action is

        this.CurrentAction = action;

        // remember which instance we are currently working with

        this.CurrentEntityInstance = instance;

        // Change window title

        this.Text = windowTitle;

        // change action button text

        this.cancelbtn.Text = actionButtonText;

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

    private Adresse LoadDataInControls(Adresse adresse) {

        this.numericUpDown1.Value = adresse.Id;

        this.textBox1.Text = adresse.type;

        this.textBox2.Text = adresse.Ville;

        this.textBox4.Text = adresse.Destinataire;

        this.textBox5.Text = adresse.NumeroCivique;

        this.textBox6.Text = adresse.Pays;

        //foreach (Product product in ) {

        //    this.supplierproductsValues.SelectedItems.Add(product);

        //}

        return adresse;

    }

    /// <summary>

    /// Enables the <see cref="SupplierView"/> window's controls for creation and edition modes.

    /// </summary>

    private void ActivateControls() {

        this.textBox1.Enabled = true;

        this.textBox2.Enabled = true;

        this.textBox3.Enabled = true;

        this.textBox4.Enabled = true;

        this.textBox5.Enabled = true;

        this.textBox6.Enabled = true;

    }

    /// <summary>

    /// Disables the <see cref="SupplierView"/> window's controls for visualization and deletion modes.

    /// </summary>

    private void DeactivateControls() {

        this.textBox1.Enabled = false;

        this.textBox2.Enabled = false;

        this.textBox3.Enabled = false;

        this.textBox4.Enabled = false;

        this.textBox5.Enabled = false;

        this.textBox6.Enabled = false;

    }

    /// <summary>

    /// Ensures that the selector controls of the <see cref="AdresseView"/> window

    /// with static content have their items populated.

    /// </summary>

    private void Initialize() {

        if (!this.isInitialized) {

            this.ReloadSelectors();

            this.isInitialized = true;

        }

    }

    private Adresse SaveDataFromControls(Adresse adresse) {

        adresse.Ville = this.textBox1.Text;

        adresse.Destinataire = this.textBox2.Text;

        adresse.Rue = this.textBox3.Text;

        adresse.NumeroCivique = this.textBox4.Text;

        adresse.Destinataire = this.textBox5.Text;

        return adresse;

    }

    private void applybtn_Click(object sender, EventArgs e) {

        try {

            switch (this.CurrentAction) {

                case ViewActionsEnum.Creation:

                    _ = this.SaveDataFromControls(this.CurrentEntityInstance);

                    this.CurrentEntityInstance = this.parentApp.AdresseService.Create(this.CurrentEntityInstance);

                    break;

                case ViewActionsEnum.Edition:

                    _ = this.SaveDataFromControls(this.CurrentEntityInstance);

                    this.CurrentEntityInstance = this.parentApp.AdresseService.Update(this.CurrentEntityInstance);

                    break;

                case ViewActionsEnum.Deletion:

                    this.CurrentEntityInstance = this.parentApp.AdresseService.Delete(this.CurrentEntityInstance);

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

    private void cancelbtn_Click(object sender, EventArgs e) {

        this.DialogResult = DialogResult.Cancel;

    }

}

