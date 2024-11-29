namespace _420DA3_A24_Projet.Presentation;

partial class AdminMainMenu {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        this.topBar = new Panel();
        this.bottomBar = new Panel();
        this.venterTLP = new TableLayoutPanel();
        this.userManagementPanel = new Panel();
        this.userPanelHeader = new Label();
        this.roleManagementPanel = new Panel();
        this.rolePanelHeader = new Label();
        this.productManagementPanel = new Panel();
        this.productPanelHeader = new Label();
        this.supplierManagementPanel = new Panel();
        this.supplierPanelHeader = new Label();
        this.warehouseManagementPanel = new Panel();
        this.warehousePanelHeader = new Label();
        this.addressManagementPanel = new Panel();
        this.addressPanelHeader = new Label();
        this.clientManagementPanel = new Panel();
        this.clientPanelHeader = new Label();
        this.soManagementPanel = new Panel();
        this.soPanelHeader = new Label();
        this.shipmentManagementPanel = new Panel();
        this.shipmentPanelHeader = new Label();
        this.poManagementPanel = new Panel();
        this.poPanelHeader = new Label();
        this.buttonLogout = new Button();
        this.bottomBar.SuspendLayout();
        this.venterTLP.SuspendLayout();
        this.userManagementPanel.SuspendLayout();
        this.roleManagementPanel.SuspendLayout();
        this.productManagementPanel.SuspendLayout();
        this.supplierManagementPanel.SuspendLayout();
        this.warehouseManagementPanel.SuspendLayout();
        this.addressManagementPanel.SuspendLayout();
        this.clientManagementPanel.SuspendLayout();
        this.soManagementPanel.SuspendLayout();
        this.shipmentManagementPanel.SuspendLayout();
        this.poManagementPanel.SuspendLayout();
        this.SuspendLayout();
        // 
        // topBar
        // 
        this.topBar.Dock = DockStyle.Top;
        this.topBar.Location = new Point(0, 0);
        this.topBar.Name = "topBar";
        this.topBar.Size = new Size(1113, 50);
        this.topBar.TabIndex = 0;
        // 
        // bottomBar
        // 
        this.bottomBar.Controls.Add(this.buttonLogout);
        this.bottomBar.Dock = DockStyle.Bottom;
        this.bottomBar.Location = new Point(0, 606);
        this.bottomBar.Name = "bottomBar";
        this.bottomBar.Size = new Size(1113, 50);
        this.bottomBar.TabIndex = 1;
        // 
        // venterTLP
        // 
        this.venterTLP.ColumnCount = 5;
        this.venterTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        this.venterTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        this.venterTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        this.venterTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        this.venterTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        this.venterTLP.Controls.Add(this.poManagementPanel, 4, 1);
        this.venterTLP.Controls.Add(this.shipmentManagementPanel, 3, 1);
        this.venterTLP.Controls.Add(this.soManagementPanel, 2, 1);
        this.venterTLP.Controls.Add(this.clientManagementPanel, 1, 1);
        this.venterTLP.Controls.Add(this.addressManagementPanel, 0, 1);
        this.venterTLP.Controls.Add(this.warehouseManagementPanel, 4, 0);
        this.venterTLP.Controls.Add(this.supplierManagementPanel, 3, 0);
        this.venterTLP.Controls.Add(this.productManagementPanel, 2, 0);
        this.venterTLP.Controls.Add(this.roleManagementPanel, 1, 0);
        this.venterTLP.Controls.Add(this.userManagementPanel, 0, 0);
        this.venterTLP.Dock = DockStyle.Fill;
        this.venterTLP.Location = new Point(0, 50);
        this.venterTLP.Name = "venterTLP";
        this.venterTLP.RowCount = 2;
        this.venterTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        this.venterTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        this.venterTLP.Size = new Size(1113, 556);
        this.venterTLP.TabIndex = 2;
        // 
        // userManagementPanel
        // 
        this.userManagementPanel.Controls.Add(this.userPanelHeader);
        this.userManagementPanel.Dock = DockStyle.Fill;
        this.userManagementPanel.Location = new Point(3, 3);
        this.userManagementPanel.Name = "userManagementPanel";
        this.userManagementPanel.Size = new Size(216, 272);
        this.userManagementPanel.TabIndex = 0;
        // 
        // userPanelHeader
        // 
        this.userPanelHeader.Dock = DockStyle.Top;
        this.userPanelHeader.Location = new Point(0, 0);
        this.userPanelHeader.Name = "userPanelHeader";
        this.userPanelHeader.Size = new Size(216, 23);
        this.userPanelHeader.TabIndex = 0;
        this.userPanelHeader.Text = "Gestion des utilisateurs";
        this.userPanelHeader.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // roleManagementPanel
        // 
        this.roleManagementPanel.Controls.Add(this.rolePanelHeader);
        this.roleManagementPanel.Dock = DockStyle.Fill;
        this.roleManagementPanel.Location = new Point(225, 3);
        this.roleManagementPanel.Name = "roleManagementPanel";
        this.roleManagementPanel.Size = new Size(216, 272);
        this.roleManagementPanel.TabIndex = 1;
        // 
        // rolePanelHeader
        // 
        this.rolePanelHeader.Dock = DockStyle.Top;
        this.rolePanelHeader.Location = new Point(0, 0);
        this.rolePanelHeader.Name = "rolePanelHeader";
        this.rolePanelHeader.Size = new Size(216, 23);
        this.rolePanelHeader.TabIndex = 0;
        this.rolePanelHeader.Text = "Gestion des rôles";
        this.rolePanelHeader.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // productManagementPanel
        // 
        this.productManagementPanel.Controls.Add(this.productPanelHeader);
        this.productManagementPanel.Dock = DockStyle.Fill;
        this.productManagementPanel.Location = new Point(447, 3);
        this.productManagementPanel.Name = "productManagementPanel";
        this.productManagementPanel.Size = new Size(216, 272);
        this.productManagementPanel.TabIndex = 2;
        // 
        // productPanelHeader
        // 
        this.productPanelHeader.Dock = DockStyle.Top;
        this.productPanelHeader.Location = new Point(0, 0);
        this.productPanelHeader.Name = "productPanelHeader";
        this.productPanelHeader.Size = new Size(216, 23);
        this.productPanelHeader.TabIndex = 0;
        this.productPanelHeader.Text = "Gestion des produits";
        this.productPanelHeader.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // supplierManagementPanel
        // 
        this.supplierManagementPanel.Controls.Add(this.supplierPanelHeader);
        this.supplierManagementPanel.Dock = DockStyle.Fill;
        this.supplierManagementPanel.Location = new Point(669, 3);
        this.supplierManagementPanel.Name = "supplierManagementPanel";
        this.supplierManagementPanel.Size = new Size(216, 272);
        this.supplierManagementPanel.TabIndex = 3;
        // 
        // supplierPanelHeader
        // 
        this.supplierPanelHeader.Dock = DockStyle.Top;
        this.supplierPanelHeader.Location = new Point(0, 0);
        this.supplierPanelHeader.Name = "supplierPanelHeader";
        this.supplierPanelHeader.Size = new Size(216, 23);
        this.supplierPanelHeader.TabIndex = 0;
        this.supplierPanelHeader.Text = "Gestion des fournisseurs";
        this.supplierPanelHeader.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // warehouseManagementPanel
        // 
        this.warehouseManagementPanel.Controls.Add(this.warehousePanelHeader);
        this.warehouseManagementPanel.Dock = DockStyle.Fill;
        this.warehouseManagementPanel.Location = new Point(891, 3);
        this.warehouseManagementPanel.Name = "warehouseManagementPanel";
        this.warehouseManagementPanel.Size = new Size(219, 272);
        this.warehouseManagementPanel.TabIndex = 4;
        // 
        // warehousePanelHeader
        // 
        this.warehousePanelHeader.Dock = DockStyle.Top;
        this.warehousePanelHeader.Location = new Point(0, 0);
        this.warehousePanelHeader.Name = "warehousePanelHeader";
        this.warehousePanelHeader.Size = new Size(219, 23);
        this.warehousePanelHeader.TabIndex = 0;
        this.warehousePanelHeader.Text = "Gestion des entrepôts";
        this.warehousePanelHeader.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // addressManagementPanel
        // 
        this.addressManagementPanel.Controls.Add(this.addressPanelHeader);
        this.addressManagementPanel.Dock = DockStyle.Fill;
        this.addressManagementPanel.Location = new Point(3, 281);
        this.addressManagementPanel.Name = "addressManagementPanel";
        this.addressManagementPanel.Size = new Size(216, 272);
        this.addressManagementPanel.TabIndex = 5;
        // 
        // addressPanelHeader
        // 
        this.addressPanelHeader.Dock = DockStyle.Top;
        this.addressPanelHeader.Location = new Point(0, 0);
        this.addressPanelHeader.Name = "addressPanelHeader";
        this.addressPanelHeader.Size = new Size(216, 23);
        this.addressPanelHeader.TabIndex = 0;
        this.addressPanelHeader.Text = "Gestion des addresses";
        this.addressPanelHeader.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // clientManagementPanel
        // 
        this.clientManagementPanel.Controls.Add(this.clientPanelHeader);
        this.clientManagementPanel.Dock = DockStyle.Fill;
        this.clientManagementPanel.Location = new Point(225, 281);
        this.clientManagementPanel.Name = "clientManagementPanel";
        this.clientManagementPanel.Size = new Size(216, 272);
        this.clientManagementPanel.TabIndex = 6;
        // 
        // clientPanelHeader
        // 
        this.clientPanelHeader.Dock = DockStyle.Top;
        this.clientPanelHeader.Location = new Point(0, 0);
        this.clientPanelHeader.Name = "clientPanelHeader";
        this.clientPanelHeader.Size = new Size(216, 23);
        this.clientPanelHeader.TabIndex = 0;
        this.clientPanelHeader.Text = "Gestion des clients";
        this.clientPanelHeader.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // soManagementPanel
        // 
        this.soManagementPanel.Controls.Add(this.soPanelHeader);
        this.soManagementPanel.Dock = DockStyle.Fill;
        this.soManagementPanel.Location = new Point(447, 281);
        this.soManagementPanel.Name = "soManagementPanel";
        this.soManagementPanel.Size = new Size(216, 272);
        this.soManagementPanel.TabIndex = 7;
        // 
        // soPanelHeader
        // 
        this.soPanelHeader.Dock = DockStyle.Top;
        this.soPanelHeader.Location = new Point(0, 0);
        this.soPanelHeader.Name = "soPanelHeader";
        this.soPanelHeader.Size = new Size(216, 23);
        this.soPanelHeader.TabIndex = 0;
        this.soPanelHeader.Text = "Gestion des ordres d'expédition";
        this.soPanelHeader.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // shipmentManagementPanel
        // 
        this.shipmentManagementPanel.Controls.Add(this.shipmentPanelHeader);
        this.shipmentManagementPanel.Dock = DockStyle.Fill;
        this.shipmentManagementPanel.Location = new Point(669, 281);
        this.shipmentManagementPanel.Name = "shipmentManagementPanel";
        this.shipmentManagementPanel.Size = new Size(216, 272);
        this.shipmentManagementPanel.TabIndex = 8;
        // 
        // shipmentPanelHeader
        // 
        this.shipmentPanelHeader.Dock = DockStyle.Top;
        this.shipmentPanelHeader.Location = new Point(0, 0);
        this.shipmentPanelHeader.Name = "shipmentPanelHeader";
        this.shipmentPanelHeader.Size = new Size(216, 23);
        this.shipmentPanelHeader.TabIndex = 0;
        this.shipmentPanelHeader.Text = "Gestion des expéditions";
        this.shipmentPanelHeader.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // poManagementPanel
        // 
        this.poManagementPanel.Controls.Add(this.poPanelHeader);
        this.poManagementPanel.Dock = DockStyle.Fill;
        this.poManagementPanel.Location = new Point(891, 281);
        this.poManagementPanel.Name = "poManagementPanel";
        this.poManagementPanel.Size = new Size(219, 272);
        this.poManagementPanel.TabIndex = 9;
        // 
        // poPanelHeader
        // 
        this.poPanelHeader.Dock = DockStyle.Top;
        this.poPanelHeader.Location = new Point(0, 0);
        this.poPanelHeader.Name = "poPanelHeader";
        this.poPanelHeader.Size = new Size(219, 23);
        this.poPanelHeader.TabIndex = 0;
        this.poPanelHeader.Text = "Gestion des ordres de restockage";
        this.poPanelHeader.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // buttonLogout
        // 
        this.buttonLogout.Location = new Point(985, 15);
        this.buttonLogout.Name = "buttonLogout";
        this.buttonLogout.Size = new Size(116, 23);
        this.buttonLogout.TabIndex = 0;
        this.buttonLogout.Text = "Déconnexion";
        this.buttonLogout.UseVisualStyleBackColor = true;
        // 
        // AdminMainMenu
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(1113, 656);
        this.Controls.Add(this.venterTLP);
        this.Controls.Add(this.bottomBar);
        this.Controls.Add(this.topBar);
        this.Name = "AdminMainMenu";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "AdminMainMenu";
        this.WindowState = FormWindowState.Minimized;
        this.bottomBar.ResumeLayout(false);
        this.venterTLP.ResumeLayout(false);
        this.userManagementPanel.ResumeLayout(false);
        this.roleManagementPanel.ResumeLayout(false);
        this.productManagementPanel.ResumeLayout(false);
        this.supplierManagementPanel.ResumeLayout(false);
        this.warehouseManagementPanel.ResumeLayout(false);
        this.addressManagementPanel.ResumeLayout(false);
        this.clientManagementPanel.ResumeLayout(false);
        this.soManagementPanel.ResumeLayout(false);
        this.shipmentManagementPanel.ResumeLayout(false);
        this.poManagementPanel.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion

    private Panel topBar;
    private Panel bottomBar;
    private TableLayoutPanel venterTLP;
    private Panel supplierManagementPanel;
    private Label supplierPanelHeader;
    private Panel productManagementPanel;
    private Label productPanelHeader;
    private Panel roleManagementPanel;
    private Label rolePanelHeader;
    private Panel userManagementPanel;
    private Label userPanelHeader;
    private Panel poManagementPanel;
    private Label poPanelHeader;
    private Panel shipmentManagementPanel;
    private Label shipmentPanelHeader;
    private Panel soManagementPanel;
    private Label soPanelHeader;
    private Panel clientManagementPanel;
    private Label clientPanelHeader;
    private Panel addressManagementPanel;
    private Label addressPanelHeader;
    private Panel warehouseManagementPanel;
    private Label warehousePanelHeader;
    private Button buttonLogout;
}