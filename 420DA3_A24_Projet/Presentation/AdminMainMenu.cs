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


    #region GESTION DES RÔLES

    private void RoleCreationButton_Click(object sender, EventArgs e) {
        Role? roleCree = this.parentApp.RoleService.OpenUserWindowForCreation();
        if (roleCree is not null) {
            _ = this.roleSearchResults.Items.Add(roleCree);
            this.roleSearchResults.SelectedItem = roleCree;
        }
    }

    private void RoleSearchTextBox_TextChanged(object sender, EventArgs e) {
        string criterion = this.roleSearchTextBox.Text.Trim();
        List<Role> results = this.parentApp.RoleService.Search(criterion);
        this.roleSearchResults.Items.Clear();
        this.roleSearchResults.SelectedItem = null;
        this.roleSearchResults.SelectedIndex = -1;
        foreach (Role role in results) {
            _ = this.roleSearchResults.Items.Add(role);
        }
    }

    private void RoleSearchResults_SelectedIndexChanged(object sender, EventArgs e) {
        Role? selectedRole = this.roleSearchResults.SelectedItem as Role;
        if (selectedRole is not null) {
            this.roleViewButton.Enabled = true;
            this.roleModifyButton.Enabled = true;
            this.roleDeleteButton.Enabled = true;
        } else {
            this.roleViewButton.Enabled = false;
            this.roleModifyButton.Enabled = false;
            this.roleDeleteButton.Enabled = false;
        }
    }

    private void RoleViewButton_Click(object sender, EventArgs e) {
        Role? selectedRole = this.roleSearchResults.SelectedItem as Role;
        if (selectedRole is null) {
            throw new Exception("Veuillez sélectionner un rôle.");
        }
        _ = this.parentApp.RoleService.OpenUserWindowForDetailsView(selectedRole);

    }

    private void RoleModifyButton_Click(object sender, EventArgs e) {
        Role? selectedRole = this.roleSearchResults.SelectedItem as Role;
        if (selectedRole is null) {
            throw new Exception("Veuillez sélectionner un rôle.");
        }
        _ = this.parentApp.RoleService.OpenUserWindowForEdition(selectedRole);
        this.roleSearchResults.Refresh();

    }

    private void RoleDeleteButton_Click(object sender, EventArgs e) {
        Role? selectedRole = this.roleSearchResults.SelectedItem as Role;
        if (selectedRole is null) {
            throw new Exception("Veuillez sélectionner un rôle.");
        }
        selectedRole = this.parentApp.RoleService.OpenUserWindowForDeletion(selectedRole);
        if (selectedRole is not null) {
            this.roleSearchResults.Items.Remove(selectedRole);
            this.roleSearchResults.SelectedItem = null;
            this.roleSearchResults.SelectedIndex = -1;
        }
    }

    #endregion




}
