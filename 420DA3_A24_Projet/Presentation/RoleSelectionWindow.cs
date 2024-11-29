using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;

namespace _420DA3_A24_Projet.Presentation;
internal partial class RoleSelectionWindow : Form {

    private readonly WsysApplication parentApp;
    public Role SelectedRole { get; private set; } = null!;

    public RoleSelectionWindow(WsysApplication parentApp) {
        this.parentApp = parentApp;
        this.InitializeComponent();
    }

    public Role OpenRoleSelectionWindowForUser(User utilisateur) {
        this.ReloadUserRolesList(utilisateur.Roles);
        DialogResult result = this.ShowDialog();
        if (result != DialogResult.OK) {
            throw new Exception("Impossible de compléter le login: aucun rôle sélectionné.");
        }
        return this.SelectedRole;
    }

    private void ReloadUserRolesList(List<Role> roles) {
        this.userRolesListBox.Items.Clear();
        this.userRolesListBox.SelectedItem = null;
        this.userRolesListBox.SelectedIndex = -1;
        foreach (Role role in roles) {
            _ = this.userRolesListBox.Items.Add(role);
        }
    }

    private void UserRolesListBox_SelectedIndexChanged(object sender, EventArgs e) {
        Role? selectedRole = this.userRolesListBox.SelectedItem as Role;
        if (selectedRole is null) {
            this.buttonSelectRole.Enabled = false;
        } else {
            this.buttonSelectRole.Enabled = true;
            this.SelectedRole = selectedRole;
        }
    }

    private void ButtonSelectRole_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.OK;
    }

    private void ButtonCancel_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }
}
