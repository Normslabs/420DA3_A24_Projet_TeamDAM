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
        this.buttonLogout = new Button();
        this.venterTLP = new TableLayoutPanel();
        this.poManagementPanel = new Panel();
        this.poPanelHeader = new Label();
        this.shipmentManagementPanel = new Panel();
        this.shipmentPanelHeader = new Label();
        this.soManagementPanel = new Panel();
        this.soPanelHeader = new Label();
        this.clientManagementPanel = new Panel();
        this.clientPanelHeader = new Label();
        this.addressManagementPanel = new Panel();
        this.addressPanelHeader = new Label();
        this.warehouseManagementPanel = new Panel();
        this.tableLayoutPanel7 = new TableLayoutPanel();
        this.panel7 = new Panel();
        this.button6 = new Button();
        this.button7 = new Button();
        this.button8 = new Button();
        this.entrepotSearchResults = new ListBox();
        this.textBox2 = new TextBox();
        this.tableLayoutPanel6 = new TableLayoutPanel();
        this.panel6 = new Panel();
        this.button5 = new Button();
        this.warehousePanelHeader = new Label();
        this.supplierManagementPanel = new Panel();
        this.supplierPanelHeader = new Label();
        this.productManagementPanel = new Panel();
        this.tableLayoutPanel5 = new TableLayoutPanel();
        this.panel5 = new Panel();
        this.button2 = new Button();
        this.button3 = new Button();
        this.button4 = new Button();
        this.produitSearchResults = new ListBox();
        this.textBox1 = new TextBox();
        this.tableLayoutPanel4 = new TableLayoutPanel();
        this.panel4 = new Panel();
        this.button1 = new Button();
        this.productPanelHeader = new Label();
        this.roleManagementPanel = new Panel();
        this.roleSearchResults = new ListBox();
        this.roleSearchTextBox = new TextBox();
        this.tableLayoutPanel2 = new TableLayoutPanel();
        this.panel2 = new Panel();
        this.roleDeleteButton = new Button();
        this.roleModifyButton = new Button();
        this.roleViewButton = new Button();
        this.tableLayoutPanel3 = new TableLayoutPanel();
        this.panel3 = new Panel();
        this.roleCreationButton = new Button();
        this.rolePanelHeader = new Label();
        this.userManagementPanel = new Panel();
        this.userSearchResults = new ListBox();
        this.userSearchTextBox = new TextBox();
        this.tableLayoutPanel1 = new TableLayoutPanel();
        this.panel1 = new Panel();
        this.userDeleteButton = new Button();
        this.userModifyButton = new Button();
        this.userViewButton = new Button();
        this.userCreateButtonTLP = new TableLayoutPanel();
        this.userCreateButtonPanel = new Panel();
        this.userCreateButton = new Button();
        this.userPanelHeader = new Label();
        this.bottomBar.SuspendLayout();
        this.venterTLP.SuspendLayout();
        this.poManagementPanel.SuspendLayout();
        this.shipmentManagementPanel.SuspendLayout();
        this.soManagementPanel.SuspendLayout();
        this.clientManagementPanel.SuspendLayout();
        this.addressManagementPanel.SuspendLayout();
        this.warehouseManagementPanel.SuspendLayout();
        this.tableLayoutPanel7.SuspendLayout();
        this.panel7.SuspendLayout();
        this.tableLayoutPanel6.SuspendLayout();
        this.panel6.SuspendLayout();
        this.supplierManagementPanel.SuspendLayout();
        this.productManagementPanel.SuspendLayout();
        this.tableLayoutPanel5.SuspendLayout();
        this.panel5.SuspendLayout();
        this.tableLayoutPanel4.SuspendLayout();
        this.panel4.SuspendLayout();
        this.roleManagementPanel.SuspendLayout();
        this.tableLayoutPanel2.SuspendLayout();
        this.panel2.SuspendLayout();
        this.tableLayoutPanel3.SuspendLayout();
        this.panel3.SuspendLayout();
        this.userManagementPanel.SuspendLayout();
        this.tableLayoutPanel1.SuspendLayout();
        this.panel1.SuspendLayout();
        this.userCreateButtonTLP.SuspendLayout();
        this.userCreateButtonPanel.SuspendLayout();
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
        // buttonLogout
        // 
        this.buttonLogout.Location = new Point(985, 15);
        this.buttonLogout.Name = "buttonLogout";
        this.buttonLogout.Size = new Size(116, 23);
        this.buttonLogout.TabIndex = 0;
        this.buttonLogout.Text = "Déconnexion";
        this.buttonLogout.UseVisualStyleBackColor = true;
        this.buttonLogout.Click += this.ButtonLogout_Click;
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
        // warehouseManagementPanel
        // 
        this.warehouseManagementPanel.Controls.Add(this.tableLayoutPanel7);
        this.warehouseManagementPanel.Controls.Add(this.entrepotSearchResults);
        this.warehouseManagementPanel.Controls.Add(this.textBox2);
        this.warehouseManagementPanel.Controls.Add(this.tableLayoutPanel6);
        this.warehouseManagementPanel.Controls.Add(this.warehousePanelHeader);
        this.warehouseManagementPanel.Dock = DockStyle.Fill;
        this.warehouseManagementPanel.Location = new Point(891, 3);
        this.warehouseManagementPanel.Name = "warehouseManagementPanel";
        this.warehouseManagementPanel.Size = new Size(219, 272);
        this.warehouseManagementPanel.TabIndex = 4;
        // 
        // tableLayoutPanel7
        // 
        this.tableLayoutPanel7.ColumnCount = 3;
        this.tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
        this.tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel7.Controls.Add(this.panel7, 1, 0);
        this.tableLayoutPanel7.Dock = DockStyle.Bottom;
        this.tableLayoutPanel7.Location = new Point(0, 182);
        this.tableLayoutPanel7.Name = "tableLayoutPanel7";
        this.tableLayoutPanel7.RowCount = 1;
        this.tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.tableLayoutPanel7.Size = new Size(219, 90);
        this.tableLayoutPanel7.TabIndex = 11;
        // 
        // panel7
        // 
        this.panel7.Controls.Add(this.button6);
        this.panel7.Controls.Add(this.button7);
        this.panel7.Controls.Add(this.button8);
        this.panel7.Dock = DockStyle.Fill;
        this.panel7.Location = new Point(22, 3);
        this.panel7.Name = "panel7";
        this.panel7.Size = new Size(174, 84);
        this.panel7.TabIndex = 0;
        // 
        // button6
        // 
        this.button6.Enabled = false;
        this.button6.Location = new Point(3, 61);
        this.button6.Name = "button6";
        this.button6.Size = new Size(168, 23);
        this.button6.TabIndex = 2;
        this.button6.Text = "Supprimer";
        this.button6.UseVisualStyleBackColor = true;
        // 
        // button7
        // 
        this.button7.Enabled = false;
        this.button7.Location = new Point(3, 32);
        this.button7.Name = "button7";
        this.button7.Size = new Size(168, 23);
        this.button7.TabIndex = 1;
        this.button7.Text = "Modifier";
        this.button7.UseVisualStyleBackColor = true;
        // 
        // button8
        // 
        this.button8.Enabled = false;
        this.button8.Location = new Point(3, 3);
        this.button8.Name = "button8";
        this.button8.Size = new Size(168, 23);
        this.button8.TabIndex = 0;
        this.button8.Text = "Voir les détails";
        this.button8.UseVisualStyleBackColor = true;
        // 
        // entrepotSearchResults
        // 
        this.entrepotSearchResults.Dock = DockStyle.Fill;
        this.entrepotSearchResults.FormattingEnabled = true;
        this.entrepotSearchResults.ItemHeight = 15;
        this.entrepotSearchResults.Location = new Point(0, 86);
        this.entrepotSearchResults.Name = "entrepotSearchResults";
        this.entrepotSearchResults.Size = new Size(219, 186);
        this.entrepotSearchResults.TabIndex = 10;
        // 
        // textBox2
        // 
        this.textBox2.Dock = DockStyle.Top;
        this.textBox2.Location = new Point(0, 63);
        this.textBox2.Name = "textBox2";
        this.textBox2.PlaceholderText = "Rechercher un rôle";
        this.textBox2.Size = new Size(219, 23);
        this.textBox2.TabIndex = 9;
        // 
        // tableLayoutPanel6
        // 
        this.tableLayoutPanel6.ColumnCount = 3;
        this.tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
        this.tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel6.Controls.Add(this.panel6, 1, 0);
        this.tableLayoutPanel6.Dock = DockStyle.Top;
        this.tableLayoutPanel6.Location = new Point(0, 23);
        this.tableLayoutPanel6.Name = "tableLayoutPanel6";
        this.tableLayoutPanel6.RowCount = 1;
        this.tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.tableLayoutPanel6.Size = new Size(219, 40);
        this.tableLayoutPanel6.TabIndex = 7;
        // 
        // panel6
        // 
        this.panel6.Controls.Add(this.button5);
        this.panel6.Dock = DockStyle.Fill;
        this.panel6.Location = new Point(22, 3);
        this.panel6.Name = "panel6";
        this.panel6.Size = new Size(174, 34);
        this.panel6.TabIndex = 0;
        // 
        // button5
        // 
        this.button5.Location = new Point(3, 3);
        this.button5.Name = "button5";
        this.button5.Size = new Size(168, 23);
        this.button5.TabIndex = 0;
        this.button5.Text = "Créer un entrepôt";
        this.button5.UseVisualStyleBackColor = true;
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
        // productManagementPanel
        // 
        this.productManagementPanel.Controls.Add(this.tableLayoutPanel5);
        this.productManagementPanel.Controls.Add(this.produitSearchResults);
        this.productManagementPanel.Controls.Add(this.textBox1);
        this.productManagementPanel.Controls.Add(this.tableLayoutPanel4);
        this.productManagementPanel.Controls.Add(this.productPanelHeader);
        this.productManagementPanel.Dock = DockStyle.Fill;
        this.productManagementPanel.Location = new Point(447, 3);
        this.productManagementPanel.Name = "productManagementPanel";
        this.productManagementPanel.Size = new Size(216, 272);
        this.productManagementPanel.TabIndex = 2;
        // 
        // tableLayoutPanel5
        // 
        this.tableLayoutPanel5.ColumnCount = 3;
        this.tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
        this.tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel5.Controls.Add(this.panel5, 1, 0);
        this.tableLayoutPanel5.Dock = DockStyle.Bottom;
        this.tableLayoutPanel5.Location = new Point(0, 182);
        this.tableLayoutPanel5.Name = "tableLayoutPanel5";
        this.tableLayoutPanel5.RowCount = 1;
        this.tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.tableLayoutPanel5.Size = new Size(216, 90);
        this.tableLayoutPanel5.TabIndex = 10;
        // 
        // panel5
        // 
        this.panel5.Controls.Add(this.button2);
        this.panel5.Controls.Add(this.button3);
        this.panel5.Controls.Add(this.button4);
        this.panel5.Dock = DockStyle.Fill;
        this.panel5.Location = new Point(21, 3);
        this.panel5.Name = "panel5";
        this.panel5.Size = new Size(174, 84);
        this.panel5.TabIndex = 0;
        // 
        // button2
        // 
        this.button2.Enabled = false;
        this.button2.Location = new Point(3, 61);
        this.button2.Name = "button2";
        this.button2.Size = new Size(168, 23);
        this.button2.TabIndex = 2;
        this.button2.Text = "Supprimer";
        this.button2.UseVisualStyleBackColor = true;
        // 
        // button3
        // 
        this.button3.Enabled = false;
        this.button3.Location = new Point(3, 32);
        this.button3.Name = "button3";
        this.button3.Size = new Size(168, 23);
        this.button3.TabIndex = 1;
        this.button3.Text = "Modifier";
        this.button3.UseVisualStyleBackColor = true;
        // 
        // button4
        // 
        this.button4.Enabled = false;
        this.button4.Location = new Point(3, 3);
        this.button4.Name = "button4";
        this.button4.Size = new Size(168, 23);
        this.button4.TabIndex = 0;
        this.button4.Text = "Voir les détails";
        this.button4.UseVisualStyleBackColor = true;
        // 
        // produitSearchResults
        // 
        this.produitSearchResults.Dock = DockStyle.Fill;
        this.produitSearchResults.FormattingEnabled = true;
        this.produitSearchResults.ItemHeight = 15;
        this.produitSearchResults.Location = new Point(0, 86);
        this.produitSearchResults.Name = "produitSearchResults";
        this.produitSearchResults.Size = new Size(216, 186);
        this.produitSearchResults.TabIndex = 9;
        // 
        // textBox1
        // 
        this.textBox1.Dock = DockStyle.Top;
        this.textBox1.Location = new Point(0, 63);
        this.textBox1.Name = "textBox1";
        this.textBox1.PlaceholderText = "Rechercher un rôle";
        this.textBox1.Size = new Size(216, 23);
        this.textBox1.TabIndex = 8;
        // 
        // tableLayoutPanel4
        // 
        this.tableLayoutPanel4.ColumnCount = 3;
        this.tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
        this.tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel4.Controls.Add(this.panel4, 1, 0);
        this.tableLayoutPanel4.Dock = DockStyle.Top;
        this.tableLayoutPanel4.Location = new Point(0, 23);
        this.tableLayoutPanel4.Name = "tableLayoutPanel4";
        this.tableLayoutPanel4.RowCount = 1;
        this.tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.tableLayoutPanel4.Size = new Size(216, 40);
        this.tableLayoutPanel4.TabIndex = 6;
        // 
        // panel4
        // 
        this.panel4.Controls.Add(this.button1);
        this.panel4.Dock = DockStyle.Fill;
        this.panel4.Location = new Point(21, 3);
        this.panel4.Name = "panel4";
        this.panel4.Size = new Size(174, 34);
        this.panel4.TabIndex = 0;
        // 
        // button1
        // 
        this.button1.Location = new Point(3, 3);
        this.button1.Name = "button1";
        this.button1.Size = new Size(168, 23);
        this.button1.TabIndex = 0;
        this.button1.Text = "Créer un produit";
        this.button1.UseVisualStyleBackColor = true;
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
        // roleManagementPanel
        // 
        this.roleManagementPanel.Controls.Add(this.roleSearchResults);
        this.roleManagementPanel.Controls.Add(this.roleSearchTextBox);
        this.roleManagementPanel.Controls.Add(this.tableLayoutPanel2);
        this.roleManagementPanel.Controls.Add(this.tableLayoutPanel3);
        this.roleManagementPanel.Controls.Add(this.rolePanelHeader);
        this.roleManagementPanel.Dock = DockStyle.Fill;
        this.roleManagementPanel.Location = new Point(225, 3);
        this.roleManagementPanel.Name = "roleManagementPanel";
        this.roleManagementPanel.Size = new Size(216, 272);
        this.roleManagementPanel.TabIndex = 1;
        // 
        // roleSearchResults
        // 
        this.roleSearchResults.Dock = DockStyle.Fill;
        this.roleSearchResults.FormattingEnabled = true;
        this.roleSearchResults.ItemHeight = 15;
        this.roleSearchResults.Location = new Point(0, 86);
        this.roleSearchResults.Name = "roleSearchResults";
        this.roleSearchResults.Size = new Size(216, 96);
        this.roleSearchResults.TabIndex = 8;
        this.roleSearchResults.SelectedIndexChanged += this.RoleSearchResults_SelectedIndexChanged;
        // 
        // roleSearchTextBox
        // 
        this.roleSearchTextBox.Dock = DockStyle.Top;
        this.roleSearchTextBox.Location = new Point(0, 63);
        this.roleSearchTextBox.Name = "roleSearchTextBox";
        this.roleSearchTextBox.PlaceholderText = "Rechercher un rôle";
        this.roleSearchTextBox.Size = new Size(216, 23);
        this.roleSearchTextBox.TabIndex = 7;
        this.roleSearchTextBox.TextChanged += this.RoleSearchTextBox_TextChanged;
        // 
        // tableLayoutPanel2
        // 
        this.tableLayoutPanel2.ColumnCount = 3;
        this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
        this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
        this.tableLayoutPanel2.Dock = DockStyle.Bottom;
        this.tableLayoutPanel2.Location = new Point(0, 182);
        this.tableLayoutPanel2.Name = "tableLayoutPanel2";
        this.tableLayoutPanel2.RowCount = 1;
        this.tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.tableLayoutPanel2.Size = new Size(216, 90);
        this.tableLayoutPanel2.TabIndex = 6;
        // 
        // panel2
        // 
        this.panel2.Controls.Add(this.roleDeleteButton);
        this.panel2.Controls.Add(this.roleModifyButton);
        this.panel2.Controls.Add(this.roleViewButton);
        this.panel2.Dock = DockStyle.Fill;
        this.panel2.Location = new Point(21, 3);
        this.panel2.Name = "panel2";
        this.panel2.Size = new Size(174, 84);
        this.panel2.TabIndex = 0;
        // 
        // roleDeleteButton
        // 
        this.roleDeleteButton.Enabled = false;
        this.roleDeleteButton.Location = new Point(3, 61);
        this.roleDeleteButton.Name = "roleDeleteButton";
        this.roleDeleteButton.Size = new Size(168, 23);
        this.roleDeleteButton.TabIndex = 2;
        this.roleDeleteButton.Text = "Supprimer";
        this.roleDeleteButton.UseVisualStyleBackColor = true;
        this.roleDeleteButton.Click += this.RoleDeleteButton_Click;
        // 
        // roleModifyButton
        // 
        this.roleModifyButton.Enabled = false;
        this.roleModifyButton.Location = new Point(3, 32);
        this.roleModifyButton.Name = "roleModifyButton";
        this.roleModifyButton.Size = new Size(168, 23);
        this.roleModifyButton.TabIndex = 1;
        this.roleModifyButton.Text = "Modifier";
        this.roleModifyButton.UseVisualStyleBackColor = true;
        this.roleModifyButton.Click += this.RoleModifyButton_Click;
        // 
        // roleViewButton
        // 
        this.roleViewButton.Enabled = false;
        this.roleViewButton.Location = new Point(3, 3);
        this.roleViewButton.Name = "roleViewButton";
        this.roleViewButton.Size = new Size(168, 23);
        this.roleViewButton.TabIndex = 0;
        this.roleViewButton.Text = "Voir les détails";
        this.roleViewButton.UseVisualStyleBackColor = true;
        this.roleViewButton.Click += this.RoleViewButton_Click;
        // 
        // tableLayoutPanel3
        // 
        this.tableLayoutPanel3.ColumnCount = 3;
        this.tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
        this.tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel3.Controls.Add(this.panel3, 1, 0);
        this.tableLayoutPanel3.Dock = DockStyle.Top;
        this.tableLayoutPanel3.Location = new Point(0, 23);
        this.tableLayoutPanel3.Name = "tableLayoutPanel3";
        this.tableLayoutPanel3.RowCount = 1;
        this.tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.tableLayoutPanel3.Size = new Size(216, 40);
        this.tableLayoutPanel3.TabIndex = 5;
        // 
        // panel3
        // 
        this.panel3.Controls.Add(this.roleCreationButton);
        this.panel3.Dock = DockStyle.Fill;
        this.panel3.Location = new Point(21, 3);
        this.panel3.Name = "panel3";
        this.panel3.Size = new Size(174, 34);
        this.panel3.TabIndex = 0;
        // 
        // roleCreationButton
        // 
        this.roleCreationButton.Location = new Point(3, 3);
        this.roleCreationButton.Name = "roleCreationButton";
        this.roleCreationButton.Size = new Size(168, 23);
        this.roleCreationButton.TabIndex = 0;
        this.roleCreationButton.Text = "Créer un rôle";
        this.roleCreationButton.UseVisualStyleBackColor = true;
        this.roleCreationButton.Click += this.RoleCreationButton_Click;
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
        // userManagementPanel
        // 
        this.userManagementPanel.Controls.Add(this.userSearchResults);
        this.userManagementPanel.Controls.Add(this.userSearchTextBox);
        this.userManagementPanel.Controls.Add(this.tableLayoutPanel1);
        this.userManagementPanel.Controls.Add(this.userCreateButtonTLP);
        this.userManagementPanel.Controls.Add(this.userPanelHeader);
        this.userManagementPanel.Dock = DockStyle.Fill;
        this.userManagementPanel.Location = new Point(3, 3);
        this.userManagementPanel.Name = "userManagementPanel";
        this.userManagementPanel.Padding = new Padding(3, 0, 3, 0);
        this.userManagementPanel.Size = new Size(216, 272);
        this.userManagementPanel.TabIndex = 0;
        // 
        // userSearchResults
        // 
        this.userSearchResults.Dock = DockStyle.Fill;
        this.userSearchResults.FormattingEnabled = true;
        this.userSearchResults.ItemHeight = 15;
        this.userSearchResults.Location = new Point(3, 86);
        this.userSearchResults.Name = "userSearchResults";
        this.userSearchResults.Size = new Size(210, 96);
        this.userSearchResults.TabIndex = 4;
        this.userSearchResults.SelectedIndexChanged += this.UserSearchResults_SelectedIndexChanged;
        // 
        // userSearchTextBox
        // 
        this.userSearchTextBox.Dock = DockStyle.Top;
        this.userSearchTextBox.Location = new Point(3, 63);
        this.userSearchTextBox.Name = "userSearchTextBox";
        this.userSearchTextBox.PlaceholderText = "Rechercher un utilisateur";
        this.userSearchTextBox.Size = new Size(210, 23);
        this.userSearchTextBox.TabIndex = 3;
        this.userSearchTextBox.TextChanged += this.UserSearchTextBox_TextChanged;
        // 
        // tableLayoutPanel1
        // 
        this.tableLayoutPanel1.ColumnCount = 3;
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
        this.tableLayoutPanel1.Dock = DockStyle.Bottom;
        this.tableLayoutPanel1.Location = new Point(3, 182);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 1;
        this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.tableLayoutPanel1.Size = new Size(210, 90);
        this.tableLayoutPanel1.TabIndex = 2;
        // 
        // panel1
        // 
        this.panel1.Controls.Add(this.userDeleteButton);
        this.panel1.Controls.Add(this.userModifyButton);
        this.panel1.Controls.Add(this.userViewButton);
        this.panel1.Dock = DockStyle.Fill;
        this.panel1.Location = new Point(18, 3);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(174, 84);
        this.panel1.TabIndex = 0;
        // 
        // userDeleteButton
        // 
        this.userDeleteButton.Enabled = false;
        this.userDeleteButton.Location = new Point(3, 61);
        this.userDeleteButton.Name = "userDeleteButton";
        this.userDeleteButton.Size = new Size(168, 23);
        this.userDeleteButton.TabIndex = 2;
        this.userDeleteButton.Text = "Supprimer";
        this.userDeleteButton.UseVisualStyleBackColor = true;
        this.userDeleteButton.Click += this.UserDeleteButton_Click;
        // 
        // userModifyButton
        // 
        this.userModifyButton.Enabled = false;
        this.userModifyButton.Location = new Point(3, 32);
        this.userModifyButton.Name = "userModifyButton";
        this.userModifyButton.Size = new Size(168, 23);
        this.userModifyButton.TabIndex = 1;
        this.userModifyButton.Text = "Modifier";
        this.userModifyButton.UseVisualStyleBackColor = true;
        this.userModifyButton.Click += this.UserModifyButton_Click;
        // 
        // userViewButton
        // 
        this.userViewButton.Enabled = false;
        this.userViewButton.Location = new Point(3, 3);
        this.userViewButton.Name = "userViewButton";
        this.userViewButton.Size = new Size(168, 23);
        this.userViewButton.TabIndex = 0;
        this.userViewButton.Text = "Voir les détails";
        this.userViewButton.UseVisualStyleBackColor = true;
        this.userViewButton.Click += this.UserViewButton_Click;
        // 
        // userCreateButtonTLP
        // 
        this.userCreateButtonTLP.ColumnCount = 3;
        this.userCreateButtonTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.userCreateButtonTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
        this.userCreateButtonTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.userCreateButtonTLP.Controls.Add(this.userCreateButtonPanel, 1, 0);
        this.userCreateButtonTLP.Dock = DockStyle.Top;
        this.userCreateButtonTLP.Location = new Point(3, 23);
        this.userCreateButtonTLP.Name = "userCreateButtonTLP";
        this.userCreateButtonTLP.RowCount = 1;
        this.userCreateButtonTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.userCreateButtonTLP.Size = new Size(210, 40);
        this.userCreateButtonTLP.TabIndex = 1;
        // 
        // userCreateButtonPanel
        // 
        this.userCreateButtonPanel.Controls.Add(this.userCreateButton);
        this.userCreateButtonPanel.Dock = DockStyle.Fill;
        this.userCreateButtonPanel.Location = new Point(18, 3);
        this.userCreateButtonPanel.Name = "userCreateButtonPanel";
        this.userCreateButtonPanel.Size = new Size(174, 34);
        this.userCreateButtonPanel.TabIndex = 0;
        // 
        // userCreateButton
        // 
        this.userCreateButton.Location = new Point(3, 3);
        this.userCreateButton.Name = "userCreateButton";
        this.userCreateButton.Size = new Size(168, 23);
        this.userCreateButton.TabIndex = 0;
        this.userCreateButton.Text = "Créer un utilisateur";
        this.userCreateButton.UseVisualStyleBackColor = true;
        this.userCreateButton.Click += this.UserCreateButton_Click;
        // 
        // userPanelHeader
        // 
        this.userPanelHeader.Dock = DockStyle.Top;
        this.userPanelHeader.Location = new Point(3, 0);
        this.userPanelHeader.Name = "userPanelHeader";
        this.userPanelHeader.Size = new Size(210, 23);
        this.userPanelHeader.TabIndex = 0;
        this.userPanelHeader.Text = "Gestion des utilisateurs";
        this.userPanelHeader.TextAlign = ContentAlignment.MiddleCenter;
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
        this.poManagementPanel.ResumeLayout(false);
        this.shipmentManagementPanel.ResumeLayout(false);
        this.soManagementPanel.ResumeLayout(false);
        this.clientManagementPanel.ResumeLayout(false);
        this.addressManagementPanel.ResumeLayout(false);
        this.warehouseManagementPanel.ResumeLayout(false);
        this.warehouseManagementPanel.PerformLayout();
        this.tableLayoutPanel7.ResumeLayout(false);
        this.panel7.ResumeLayout(false);
        this.tableLayoutPanel6.ResumeLayout(false);
        this.panel6.ResumeLayout(false);
        this.supplierManagementPanel.ResumeLayout(false);
        this.productManagementPanel.ResumeLayout(false);
        this.productManagementPanel.PerformLayout();
        this.tableLayoutPanel5.ResumeLayout(false);
        this.panel5.ResumeLayout(false);
        this.tableLayoutPanel4.ResumeLayout(false);
        this.panel4.ResumeLayout(false);
        this.roleManagementPanel.ResumeLayout(false);
        this.roleManagementPanel.PerformLayout();
        this.tableLayoutPanel2.ResumeLayout(false);
        this.panel2.ResumeLayout(false);
        this.tableLayoutPanel3.ResumeLayout(false);
        this.panel3.ResumeLayout(false);
        this.userManagementPanel.ResumeLayout(false);
        this.userManagementPanel.PerformLayout();
        this.tableLayoutPanel1.ResumeLayout(false);
        this.panel1.ResumeLayout(false);
        this.userCreateButtonTLP.ResumeLayout(false);
        this.userCreateButtonPanel.ResumeLayout(false);
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
    private TableLayoutPanel tableLayoutPanel1;
    private Panel panel1;
    private Button userDeleteButton;
    private Button userModifyButton;
    private Button userViewButton;
    private TableLayoutPanel userCreateButtonTLP;
    private Panel userCreateButtonPanel;
    private Button userCreateButton;
    private TextBox userSearchTextBox;
    private ListBox userSearchResults;
    private ListBox roleSearchResults;
    private TextBox roleSearchTextBox;
    private TableLayoutPanel tableLayoutPanel2;
    private Panel panel2;
    private Button roleDeleteButton;
    private Button roleModifyButton;
    private Button roleViewButton;
    private TableLayoutPanel tableLayoutPanel3;
    private Panel panel3;
    private Button roleCreationButton;
    private TableLayoutPanel tableLayoutPanel4;
    private Panel panel4;
    private Button button1;
    private TableLayoutPanel tableLayoutPanel7;
    private Panel panel7;
    private Button button6;
    private Button button7;
    private Button button8;
    private ListBox entrepotSearchResults;
    private TextBox textBox2;
    private TableLayoutPanel tableLayoutPanel6;
    private Panel panel6;
    private Button button5;
    private TableLayoutPanel tableLayoutPanel5;
    private Panel panel5;
    private Button button2;
    private Button button3;
    private Button button4;
    private ListBox produitSearchResults;
    private TextBox textBox1;
}