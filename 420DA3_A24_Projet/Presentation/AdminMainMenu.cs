using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;
using Project_Utilities.Exceptions;
using Project_Utilities.Presentation;

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
        try {
            User? utilisateurCree = this.parentApp.UserService.OpenManagementWindowForCreation();
            if (utilisateurCree is not null) {
                _ = this.userSearchResults.Items.Add(utilisateurCree);
                this.userSearchResults.SelectedItem = utilisateurCree;
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    private void UserSearchTextBox_TextChanged(object sender, EventArgs e) {
        try {
            string criterion = this.userSearchTextBox.Text.Trim();
            List<User> results = this.parentApp.UserService.SearchUsers(criterion);
            this.userSearchResults.Items.Clear();
            this.userSearchResults.SelectedItem = null;
            this.userSearchResults.SelectedIndex = -1;
            foreach (User user in results) {
                _ = this.userSearchResults.Items.Add(user);
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
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
        try {
            User? selectedUser = this.userSearchResults.SelectedItem as User 
                ?? throw new ValidationException("Veuillez sélectionner un utilisateur.");
            _ = this.parentApp.UserService.OpenManagementWindowForVisualization(selectedUser);

        } catch (ValidationException ex) {
            _ = MessageBox.Show(ex.Message);

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    private void UserModifyButton_Click(object sender, EventArgs e) {
        try {
            User? selectedUser = this.userSearchResults.SelectedItem as User 
                ?? throw new ValidationException("Veuillez sélectionner un utilisateur.");
            bool wasModified = this.parentApp.UserService.OpenManagementWindowForEdition(selectedUser);
            if (wasModified) {
                this.userSearchResults.RefreshDisplay();
            }

        } catch (ValidationException ex) {
            _ = MessageBox.Show(ex.Message);

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    private void UserDeleteButton_Click(object sender, EventArgs e) {
        try {
            User? selectedUser = this.userSearchResults.SelectedItem as User 
                ?? throw new ValidationException("Veuillez sélectionner un utilisateur.");
            bool wasDeleted = this.parentApp.UserService.OpenManagementWindowForDeletion(selectedUser);
            if (wasDeleted) {
                this.userSearchResults.Items.Remove(selectedUser);
                this.userSearchResults.SelectedItem = null;
                this.userSearchResults.SelectedIndex = -1;
            }

        } catch (ValidationException ex) {
            _ = MessageBox.Show(ex.Message);

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }

    }

    #endregion


    #region GESTION DES RÔLES

    private void RoleCreationButton_Click(object sender, EventArgs e) {
        try {
            Role? roleCree = this.parentApp.RoleService.OpenManagementWindowForCreation();
            if (roleCree is not null) {
                _ = this.roleSearchResults.Items.Add(roleCree);
                this.roleSearchResults.SelectedItem = roleCree;
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    private void RoleSearchTextBox_TextChanged(object sender, EventArgs e) {
        try {
            string criterion = this.roleSearchTextBox.Text.Trim();
            List<Role> results = this.parentApp.RoleService.SearchRoles(criterion);
            this.roleSearchResults.Items.Clear();
            this.roleSearchResults.SelectedItem = null;
            this.roleSearchResults.SelectedIndex = -1;
            foreach (Role role in results) {
                _ = this.roleSearchResults.Items.Add(role);
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
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
        try {
            Role? selectedRole = this.roleSearchResults.SelectedItem as Role
                ?? throw new ValidationException("Veuillez sélectionner un rôle.");
            _ = this.parentApp.RoleService.OpenManagementWindowForVisualization(selectedRole);

        } catch (ValidationException ex) {
            _ = MessageBox.Show(ex.Message);

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }

    }

    private void RoleModifyButton_Click(object sender, EventArgs e) {
        try {
            Role? selectedRole = this.roleSearchResults.SelectedItem as Role 
                ?? throw new ValidationException("Veuillez sélectionner un rôle.");
            bool wasModified = this.parentApp.RoleService.OpenManagementWindowForEdition(selectedRole);
            if (wasModified) {
                this.roleSearchResults.RefreshDisplay();
            }

        } catch (ValidationException ex) {
            _ = MessageBox.Show(ex.Message);

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }

    }

    private void RoleDeleteButton_Click(object sender, EventArgs e) {
        try {
            Role? selectedRole = this.roleSearchResults.SelectedItem as Role 
                ?? throw new ValidationException("Veuillez sélectionner un rôle.");
            bool wasDeleted = this.parentApp.RoleService.OpenManagementWindowForDeletion(selectedRole);
            if (wasDeleted) {
                this.roleSearchResults.Items.Remove(selectedRole);
                this.roleSearchResults.SelectedItem = null;
                this.roleSearchResults.SelectedIndex = -1;
            }

        } catch (ValidationException ex) {
            _ = MessageBox.Show(ex.Message);

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    #endregion




}
