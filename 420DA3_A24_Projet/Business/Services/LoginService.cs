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
            return result == DialogResult.OK;
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
        Role roleSelectionne = user.Roles.Count > 1
            ? this.roleSelectionWindow.OpenRoleSelectionWindowForUser(user)
            : user.Roles.Count == 1
                ? user.Roles[0]
                : throw new Exception("Impossible de poursuivre la connexion: l'utilisateur n'a aucun rôle assigné.");
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
