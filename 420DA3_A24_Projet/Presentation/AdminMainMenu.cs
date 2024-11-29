using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;

namespace _420DA3_A24_Projet.Presentation;
internal partial class AdminMainMenu : Form {

    private WsysApplication parentApp;

    public AdminMainMenu(WsysApplication application) {
        this.parentApp = application;
        this.InitializeComponent();
    }

    private void ButtonLogout_Click(object sender, EventArgs e) {
        this.parentApp.LoginService.LogOut();
        this.DialogResult = DialogResult.Continue;
    }


    #region GESTION DES UTILISATEURS

    private void UserCreateButton_Click(object sender, EventArgs e) {
        User? utilisateurCree = this.parentApp.UserService.OpenUserWindowForCreation();
        if (utilisateurCree is not null) {
            _ = this.userSearchResults.Items.Add(utilisateurCree);
            this.userSearchResults.SelectedItem = utilisateurCree;
        }
    }

    private void UserSearchTextBox_TextChanged(object sender, EventArgs e) {
        string criterion = this.userSearchTextBox.Text.Trim();
        List<User> results = this.parentApp.UserService.Search(criterion);
        this.userSearchResults.Items.Clear();
        this.userSearchResults.SelectedItem = null;
        this.userSearchResults.SelectedIndex = -1;
        foreach (User user in results) {
            _ = this.userSearchResults.Items.Add(user);
        }
    }

    private void UserSearchResults_SelectedIndexChanged(object sender, EventArgs e) {
        User? selectedUser = this.userSearchResults.SelectedItem as User;
        if (selectedUser is not null) {
            this.userViewButton.Enabled = true;
            this.userModifyButton.Enabled = true;
            this.userDeleteButton.Enabled = true;
        } else {
            this.userViewButton.Enabled = false;
            this.userModifyButton.Enabled = false;
            this.userDeleteButton.Enabled = false;
        }
    }

    private void UserViewButton_Click(object sender, EventArgs e) {
        User? selectedUser = this.userSearchResults.SelectedItem as User;
        if (selectedUser is null) {
            throw new Exception("Veuillez sélectionner un utilisateur.");
        }
        _ = this.parentApp.UserService.OpenUserWindowForDetailsView(selectedUser);
    }

    private void UserModifyButton_Click(object sender, EventArgs e) {
        User? selectedUser = this.userSearchResults.SelectedItem as User;
        if (selectedUser is null) {
            throw new Exception("Veuillez sélectionner un utilisateur.");
        }
        _ = this.parentApp.UserService.OpenUserWindowForEdition(selectedUser);
        this.userSearchResults.Refresh();
    }

    private void UserDeleteButton_Click(object sender, EventArgs e) {
        User? selectedUser = this.userSearchResults.SelectedItem as User;
        if (selectedUser is null) {
            throw new Exception("Veuillez sélectionner un utilisateur.");
        }
        selectedUser = this.parentApp.UserService.OpenUserWindowForDeletion(selectedUser);
        if (selectedUser is not null) {
            this.userSearchResults.Items.Remove(selectedUser);
            this.userSearchResults.SelectedItem = null;
            this.userSearchResults.SelectedIndex = -1;
        }

    }

    #endregion


}
