using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.Business.Services;
using Project_Utilities.Exceptions;
using Project_Utilities.Presentation;
using System.Diagnostics;

namespace _420DA3_A24_Projet.Presentation;
internal partial class AdminMainMenu : Form {

    private readonly WsysApplication parentApp;

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
            WsysApplication.HandleException(ex);
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
            WsysApplication.HandleException(ex);
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
            WsysApplication.HandleException(ex);
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
            WsysApplication.HandleException(ex);
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
            WsysApplication.HandleException(ex);
        }

    }

    #endregion

    #region GESTION DES PRODUCTS
    private void ProductCreateButton_Click(object sender, EventArgs e) {
        Debug.WriteLine("wjienbgiowebhuiwuighbw");
        try {
            Product? createdProduct = this.parentApp.ProductService.OpenManagementWindowForCreation();
            if (createdProduct is not null) {
                _ = this.productSearchResults.Items.Add(createdProduct);
                this.productSearchResults.SelectedItem = createdProduct;
            }
        } catch (Exception ex) {
            WsysApplication.HandleException(ex);
        }
    }

    //private void ProductSearchTextBox_TextChanged(object sender, EventArgs e) {
    //    try {
    //        string criterion = this.productSearchTextBox.Text.Trim();
    //        List<Product> results = this.parentApp.ProductService.SearchProducts(criterion);
    //        this.productSearchResults.Items.Clear();
    //        this.productSearchResults.SelectedItem = null;
    //        this.productSearchResults.SelectedIndex = -1;
    //        foreach (Product product in results) {
    //            _ = this.productSearchResults.Items.Add(product);
    //        }
    //    } catch (Exception ex) {
    //        WsysApplication.HandleException(ex);
    //    }
    //}

    //private void ProductSearchResults_SelectedIndexChanged(object sender, EventArgs e) {
    //    Product? selectedProduct = this.productSearchResults.SelectedItem as Product;
    //    if (selectedProduct is not null) {
    //        this.productViewButton.Enabled = true;
    //        this.productModifyButton.Enabled = true;
    //        this.productDeleteButton.Enabled = true;
    //    } else {
    //        this.productViewButton.Enabled = false;
    //        this.productModifyButton.Enabled = false;
    //        this.productDeleteButton.Enabled = false;
    //    }
    //}

    //private void ProductViewButton_Click(object sender, EventArgs e) {
    //    try {
    //        Product? selectedProduct = this.productSearchResults.SelectedItem as Product
    //            ?? throw new ValidationException("Veuillez sélectionner un produit.");
    //        _ = this.parentApp.ProductService.OpenManagementWindowForVisualization(selectedProduct);
    //    } catch (ValidationException ex) {
    //        _ = MessageBox.Show(ex.Message);
    //    } catch (Exception ex) {
    //        WsysApplication.HandleException(ex);
    //    }
    //}

    //private void ProductModifyButton_Click(object sender, EventArgs e) {
    //    try {
    //        Product? selectedProduct = this.productSearchResults.SelectedItem as Product
    //            ?? throw new ValidationException("Veuillez sélectionner un produit.");
    //        bool wasModified = this.parentApp.ProductService.OpenManagementWindowForEdition(selectedProduct);
    //        if (wasModified) {
    //            this.productSearchResults.RefreshDisplay();
    //        }
    //    } catch (ValidationException ex) {
    //        _ = MessageBox.Show(ex.Message);
    //    } catch (Exception ex) {
    //        WsysApplication.HandleException(ex);
    //    }
    //}

    //private void ProductDeleteButton_Click(object sender, EventArgs e) {
    //    try {
    //        Product? selectedProduct = this.productSearchResults.SelectedItem as Product
    //            ?? throw new ValidationException("Veuillez sélectionner un produit.");
    //        bool wasDeleted = this.parentApp.ProductService.OpenManagementWindowForDeletion(selectedProduct);
    //        if (wasDeleted) {
    //            this.productSearchResults.Items.Remove(selectedProduct);
    //            this.productSearchResults.SelectedItem = null;
    //            this.productSearchResults.SelectedIndex = -1;
    //        }
    //    } catch (ValidationException ex) {
    //        _ = MessageBox.Show(ex.Message);
    //    } catch (Exception ex) {
    //        WsysApplication.HandleException(ex);
    //    }
    //}

    #endregion
    #region GESTION DES WAREHOUSES
    //private void WarehouseCreateButton_Click(object sender, EventArgs e) {
    //    try {
    //        Warehouse? createdWarehouse = this.parentApp.WarehouseService.OpenManagementWindowForCreation();
    //        if (createdWarehouse is not null) {
    //            _ = this.warehouseSearchResults.Items.Add(createdWarehouse);
    //            this.warehouseSearchResults.SelectedItem = createdWarehouse;
    //        }
    //    } catch (Exception ex) {
    //        WsysApplication.HandleException(ex);
    //    }
    //}

    //private void WarehouseSearchTextBox_TextChanged(object sender, EventArgs e) {
    //    try {
    //        string criterion = this.warehouseSearchTextBox.Text.Trim();
    //        List<Warehouse> results = this.parentApp.WarehouseService.SearchWarehouses(criterion);
    //        this.warehouseSearchResults.Items.Clear();
    //        this.warehouseSearchResults.SelectedItem = null;
    //        this.warehouseSearchResults.SelectedIndex = -1;
    //        foreach (Warehouse warehouse in results) {
    //            _ = this.warehouseSearchResults.Items.Add(warehouse);
    //        }
    //    } catch (Exception ex) {
    //        WsysApplication.HandleException(ex);
    //    }
    //}

    //private void WarehouseSearchResults_SelectedIndexChanged(object sender, EventArgs e) {
    //    Warehouse? selectedWarehouse = this.warehouseSearchResults.SelectedItem as Warehouse;
    //    if (selectedWarehouse is not null) {
    //        this.warehouseViewButton.Enabled = true;
    //        this.warehouseModifyButton.Enabled = true;
    //        this.warehouseDeleteButton.Enabled = true;
    //    } else {
    //        this.warehouseViewButton.Enabled = false;
    //        this.warehouseModifyButton.Enabled = false;
    //        this.warehouseDeleteButton.Enabled = false;
    //    }
    //}

    //private void WarehouseViewButton_Click(object sender, EventArgs e) {
    //    try {
    //        Warehouse? selectedWarehouse = this.warehouseSearchResults.SelectedItem as Warehouse
    //            ?? throw new ValidationException("Veuillez sélectionner un entrepôt.");
    //        _ = this.parentApp.WarehouseService.OpenManagementWindowForVisualization(selectedWarehouse);
    //    } catch (ValidationException ex) {
    //        _ = MessageBox.Show(ex.Message);
    //    } catch (Exception ex) {
    //        WsysApplication.HandleException(ex);
    //    }
    //}

    //private void WarehouseModifyButton_Click(object sender, EventArgs e) {
    //    try {
    //        Warehouse? selectedWarehouse = this.warehouseSearchResults.SelectedItem as Warehouse
    //            ?? throw new ValidationException("Veuillez sélectionner un entrepôt.");
    //        bool wasModified = this.parentApp.WarehouseService.OpenManagementWindowForEdition(selectedWarehouse);
    //        if (wasModified) {
    //            this.warehouseSearchResults.RefreshDisplay();
    //        }
    //    } catch (ValidationException ex) {
    //        _ = MessageBox.Show(ex.Message);
    //    } catch (Exception ex) {
    //        WsysApplication.HandleException(ex);
    //    }
    //}

    //private void WarehouseDeleteButton_Click(object sender, EventArgs e) {
    //    try {
    //        Warehouse? selectedWarehouse = this.warehouseSearchResults.SelectedItem as Warehouse
    //            ?? throw new ValidationException("Veuillez sélectionner un entrepôt.");
    //        bool wasDeleted = this.parentApp.WarehouseService.OpenManagementWindowForDeletion(selectedWarehouse);
    //        if (wasDeleted) {
    //            this.warehouseSearchResults.Items.Remove(selectedWarehouse);
    //            this.warehouseSearchResults.SelectedItem = null;
    //            this.warehouseSearchResults.SelectedIndex = -1;
    //        }
    //    } catch (ValidationException ex) {
    //        _ = MessageBox.Show(ex.Message);
    //    } catch (Exception ex) {
    //        WsysApplication.HandleException(ex);
    //    }
    //}
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
            WsysApplication.HandleException(ex);
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
            WsysApplication.HandleException(ex);
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
            WsysApplication.HandleException(ex);
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
            WsysApplication.HandleException(ex);
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
            WsysApplication.HandleException(ex);
        }
    }

    #endregion
}
