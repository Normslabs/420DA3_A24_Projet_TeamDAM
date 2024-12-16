using _420DA3_A24_Projet.Business.Domain;

using _420DA3_A24_Projet.Business;

using Project_Utilities.Enums;

using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Windows.Forms;

using Microsoft.EntityFrameworkCore.Infrastructure;

namespace _420DA3_A24_Projet.Presentation.Views;

internal partial class ClientView : Form {

    /// <summary>

    /// Management window for <see cref="Client"/> entities.

    /// </summary>


    private bool isInitialized = false;

    private readonly WsysApplication parentApp;

    /// <summary>

    /// The <see cref="ViewActionsEnum"/> value indicating the intent for which the window

    /// is currently opened or was opened last.

    /// </summary>

    public ViewActionsEnum CurrentAction { get; private set; }

    /// <summary>

    /// The working <see cref="Client"/> value with which the window is currently

    /// opened or was opened last.

    /// </summary>

    public Adresse CurrentEntityInstance { get; private set; } = null!;

    /// <summary>

    /// <see cref="ClientView"/> constructor.

    /// </summary>

    /// <param name="application"></param>

    public ClientView(WsysApplication application) {

        this.parentApp = application;

        this.InitializeComponent();

    }

    /// <summary>

    /// Opens a <see cref="ClientView"/> modal window in entity creation mode.

    /// </summary>

    /// <param name="instance"></param>

    /// <returns></returns>

    public DialogResult OpenForCreation(Client instance) {

        this.PreOpenSetup(instance, ViewActionsEnum.Creation, "Création", "Créer");

        return this.ShowDialog();

    }

    /// <summary>

    /// Opens a <see cref="ClientView"/> modal window in entity visualization mode.

    /// </summary>

    /// <param name="instance"></param>

    /// <returns></returns>

    public DialogResult OpenForDetailsView(Client instance) {

        this.PreOpenSetup(instance, ViewActionsEnum.Visualization, "Détails", "OK");

        return this.ShowDialog();

    }

    /// <summary>

    /// Opens a <see cref="ClientView"/> modal window in entity visualization mode.

    /// </summary>

    /// <param name="instance"></param>

    /// <returns></returns>

    public DialogResult OpenForModification(Client instance) {

        this.PreOpenSetup(instance, ViewActionsEnum.Edition, "Modifier", "Enregistrer");

        return this.ShowDialog();

    }

    /// <summary>

    /// Opens a <see cref="ClientView"/> modal window in entity visualization mode.

    /// </summary>

    /// <param name="instance"></param>

    /// <returns></returns>

    public DialogResult OpenForDeletion(Client instance) {

        this.PreOpenSetup(instance, ViewActionsEnum.Deletion, "Supprimer", "Supprimer");

        return this.ShowDialog();

    }

    /// <summary>

    /// Performs pre-opening initialization, clean-up and preparation for the <see cref="ClientView"/> window.

    /// </summary>

    /// <param name="instance"></param>

    /// <param name="action"></param>

    /// <param name="windowTitle"></param>

    /// <param name="actionButtonText"></param>

    private void PreOpenSetup(Client instance, ViewActionsEnum action, string windowTitle, string actionButtonText) {

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

    private Client LoadDataInControls(Client client) {

        this.numericUpDown1.Value = client.Id;

        this.textBox1.Text = client.PrenomContact;

        this.textBox2.Text = client.NomContact;

        this.textBox4.Text = client.CourrielContact;

        this.textBox5.Text = client.TelephoneContact;

        this.textBox6.Text = client.NomCompagnie;

        return client;

    }

    /// <summary>

    /// Enables the <see cref="ClientView"/> window's controls for creation and edition modes.

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

    /// Disables the <see cref="ClientView"/> window's controls for visualization and deletion modes.

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

    private Client SaveDataFromControls(Client client) {

        client.NomContact = this.textBox1.Text;

        client.NomCompagnie = this.textBox2.Text;

        client.PrenomContact = this.textBox3.Text;

        client.CourrielContact = this.textBox4.Text;

        client.TelephoneContact = this.textBox5.Text;

        return client;

    }

    private void applybtn_Click(object sender, EventArgs e) {

        try {

            switch (this.CurrentAction) {

                case ViewActionsEnum.Creation:

                    _ = this.SaveDataFromControls(this.CurrentEntityInstance);

                    this.CurrentEntityInstance = this.parentApp.ClientService.Create(this.CurrentEntityInstance);

                    break;

                case ViewActionsEnum.Edition:

                    _ = this.SaveDataFromControls(this.CurrentEntityInstance);

                    this.CurrentEntityInstance = this.parentApp.ClientService.Update(this.CurrentEntityInstance);

                    break;

                case ViewActionsEnum.Deletion:

                    this.CurrentEntityInstance = this.parentApp.ClientService.Delete(this.CurrentEntityInstance);

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

