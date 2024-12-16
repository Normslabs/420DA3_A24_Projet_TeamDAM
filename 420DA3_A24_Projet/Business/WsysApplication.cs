using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.Business.Services;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.Presentation;
using System.Diagnostics;
using System.Text;

namespace _420DA3_A24_Projet.Business;
internal class WsysApplication {

    private readonly WsysDbContext context;
    private readonly AdminMainMenu adminMainMenu;
    private readonly OfficeEmpMainMenu officeEmployeeMainMenu;
    private readonly WhEmpMainMenu warehouseEmployeeMainMenu;

    public PasswordService PasswordService { get; private set; }
    public TrackingNumberFactory TrackingNumberFactory { get; private set; }
    public UserService UserService { get; private set; }
    public RoleService RoleService { get; private set; }
    public LoginService LoginService { get; private set; }
    public SupplierService SupplierService { get; private set; }
    public PurchaseOrderService PurchaseOrderService { get; private set; }
    public ProductService ProductService { get; private set; }
    public WareHouseService WareHouseService { get; private set; }


    public ProductService ProductService { get; private set; }


    public WareHouseService WareHouseService { get; private set; }
    public WsysApplication() {
        this.context = new WsysDbContext();
        this.adminMainMenu = new AdminMainMenu(this);
        this.officeEmployeeMainMenu = new OfficeEmpMainMenu(this);
        this.warehouseEmployeeMainMenu = new WhEmpMainMenu(this);

        this.PasswordService = PasswordService.GetInstance();
        this.TrackingNumberFactory = TrackingNumberFactory.GetInstance();
        this.UserService = new UserService(this, this.context);
        this.RoleService = new RoleService(this, this.context);
        this.SupplierService = new SupplierService(this, this.context);
        this.PurchaseOrderService = new PurchaseOrderService(this, this.context);
        this.ProductService = new ProductService (this, this.context);
        this.LoginService = new LoginService(this);
        this.WareHouseService = new WareHouseService(this, this.context);
        this.ProductService = new ProductService(this, this.context);
    }


    public void Start() {
        Application.Run();
        while (this.LoginService.RequireLoggedInUser()) {
            _ = this.LoginService.LoggedInUserRole?.Id == Role.ADMIN_ROLE_ID
                ? this.adminMainMenu.ShowDialog()
                : this.LoginService.LoggedInUserRole?.Id == Role.OFFICE_EMPLOYEE_ROLE_ID
                    ? this.officeEmployeeMainMenu.ShowDialog()
                    : this.LoginService.LoggedInUserRole?.Id == Role.WAREHOUSE_EMPLOYEE_ROLE_ID
                                    ? this.warehouseEmployeeMainMenu.ShowDialog()
                                    : throw new Exception("Impossible de démarrer l'application: rôle non implémenté.");
        }
    }


    /// <summary>
    /// Gestion générale d'une exception.
    /// </summary>
    /// <remarks>
    /// Affiche les détails de l'exception dans la console, dans la fenêtre de débogage et dans une boîte de dialogue.
    /// </remarks>
    /// <param name="ex">L'exception à gérer.</param>
    public static void HandleException(Exception ex) {
        string? stack = ex.StackTrace;
        StringBuilder messageBuilder = new StringBuilder();
        Console.Error.WriteLine(ex.Message);
        Debug.WriteLine(ex.Message);
        _ = messageBuilder.Append(ex.Message);
        while (ex.InnerException != null) {
            ex = ex.InnerException;
            Console.Error.WriteLine(ex.Message);
            Debug.WriteLine(ex.Message);
            _ = messageBuilder.Append(Environment.NewLine + "Caused By: " + ex.Message);
        }
        Console.Error.WriteLine("Stack trace:");
        Console.Error.WriteLine(stack);
        Debug.WriteLine("Stack trace:");
        Debug.WriteLine(stack);
        _ = MessageBox.Show(messageBuilder.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

    }
}
