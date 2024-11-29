using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.Presentation;
using Project_Utilities.Exceptions;

namespace _420DA3_A24_Projet.Business.Services;
internal class LoginService {

    private readonly WsysApplication parentApp;
    private readonly LoginWindow loginWindow;
    private readonly RoleSelectionWindow roleSelectionWindow;

    public User? LoggedInUser { get; private set; }
    public Role? LoggedInUserRole { get; private set; }
    public bool IsUserLoggedIn { get; private set; }

    public LoginService(WsysApplication parentApp) {
        this.parentApp = parentApp;
        this.loginWindow = new LoginWindow(parentApp);
        this.roleSelectionWindow = new RoleSelectionWindow(parentApp);
        this.IsUserLoggedIn = false;
    }

    public bool RequireLoggedInUser() {
        if (this.IsUserLoggedIn && this.LoggedInUser is User && this.LoggedInUserRole is Role) {
            return true;
        } else {
            DialogResult result = this.OpenLoginWindow();
            if (result == DialogResult.OK) {
                return true;
            } else {
                return false;
            }
        }
    }

    public void TryLogin(string username, string password) {
        User? user = this.parentApp.UserService.GetByUsername(username);
        if (user is null) {
            throw new UserNotFoundException($"L'utilisateur [{username}] n'existe pas.");
        }
        if (!this.parentApp.PasswordService.ValidatePassword(password, user.PasswordHash)) {
            throw new InvalidPasswordException("Le mot de passe est invalide.");
        }
        Role roleSelectionne;
        if (user.Roles.Count > 1) {
            roleSelectionne = this.roleSelectionWindow.OpenRoleSelectionWindowForUser(user);

        } else if (user.Roles.Count == 1) {
            roleSelectionne = user.Roles[0];

        } else {
            throw new Exception("Impossible de poursuivre la connexion: l'utilisateur n'a aucun rôle assigné.");
        }
        this.LoggedInUser = user;
        this.LoggedInUserRole = roleSelectionne;
        this.IsUserLoggedIn = true;
    }

    public void LogOut() {
        this.LoggedInUser = null;
        this.LoggedInUserRole = null;
        this.IsUserLoggedIn = false;
    }

    private DialogResult OpenLoginWindow() {
        return this.loginWindow.ShowDialog();
    }
}
