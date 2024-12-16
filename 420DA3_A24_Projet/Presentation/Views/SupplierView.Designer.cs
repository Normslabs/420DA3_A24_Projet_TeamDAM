namespace _420DA3_A24_Projet.Presentation.Views;

partial class SupplierView {
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
        this.contactphoneValue = new TextBox();
        this.contactphoneLabel = new Label();
        this.contactemailValue = new TextBox();
        this.contactlastnameValue = new TextBox();
        this.contactfirstnameLabel = new Label();
        this.supplierproductsValues = new ListBox();
        this.supplierproductsLabel = new Label();
        this.dateDeletedValue = new DateTimePicker();
        this.dateModifiedValue = new DateTimePicker();
        this.dateCreatedValue = new DateTimePicker();
        this.dateDeletedLabel = new Label();
        this.dateCreatedLabel = new Label();
        this.centerPanel = new Panel();
        this.contactfirstnameValue = new TextBox();
        this.suppliernameValue = new TextBox();
        this.dateModifiedLabel = new Label();
        this.contactemailLabel = new Label();
        this.contactlastnameLabel = new Label();
        this.suppliernameLabel = new Label();
        this.idValue = new NumericUpDown();
        this.idLabel = new Label();
        this.btnAction = new Button();
        this.btnCancel = new Button();
        this.centerBarTabLayPanel = new TableLayoutPanel();
        this.topBarPanel = new Panel();
        this.openendModeValue = new Label();
        this.openedModeLabel = new Label();
        this.bottomBarPanel = new Panel();
        this.actionBtn = new Button();
        this.cancelBtn = new Button();
        this.centerPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) this.idValue).BeginInit();
        this.centerBarTabLayPanel.SuspendLayout();
        this.topBarPanel.SuspendLayout();
        this.bottomBarPanel.SuspendLayout();
        this.SuspendLayout();
        // 
        // contactphoneValue
        // 
        this.contactphoneValue.Location = new Point(179, 240);
        this.contactphoneValue.Margin = new Padding(3, 4, 3, 4);
        this.contactphoneValue.Name = "contactphoneValue";
        this.contactphoneValue.PlaceholderText = "Telephone contact";
        this.contactphoneValue.Size = new Size(267, 27);
        this.contactphoneValue.TabIndex = 22;
        this.contactphoneValue.UseSystemPasswordChar = true;
        // 
        // contactphoneLabel
        // 
        this.contactphoneLabel.Location = new Point(6, 238);
        this.contactphoneLabel.Margin = new Padding(6, 7, 6, 7);
        this.contactphoneLabel.Name = "contactphoneLabel";
        this.contactphoneLabel.Size = new Size(165, 31);
        this.contactphoneLabel.TabIndex = 21;
        this.contactphoneLabel.Text = "Telephone du contact :";
        this.contactphoneLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // contactemailValue
        // 
        this.contactemailValue.Location = new Point(179, 198);
        this.contactemailValue.Margin = new Padding(3, 4, 3, 4);
        this.contactemailValue.Name = "contactemailValue";
        this.contactemailValue.PlaceholderText = "Courriel contact";
        this.contactemailValue.Size = new Size(267, 27);
        this.contactemailValue.TabIndex = 20;
        this.contactemailValue.UseSystemPasswordChar = true;
        // 
        // contactlastnameValue
        // 
        this.contactlastnameValue.Location = new Point(180, 154);
        this.contactlastnameValue.Margin = new Padding(3, 4, 3, 4);
        this.contactlastnameValue.Name = "contactlastnameValue";
        this.contactlastnameValue.PlaceholderText = "nom contact";
        this.contactlastnameValue.Size = new Size(267, 27);
        this.contactlastnameValue.TabIndex = 19;
        this.contactlastnameValue.UseSystemPasswordChar = true;
        // 
        // contactfirstnameLabel
        // 
        this.contactfirstnameLabel.Location = new Point(5, 107);
        this.contactfirstnameLabel.Margin = new Padding(6, 7, 6, 7);
        this.contactfirstnameLabel.Name = "contactfirstnameLabel";
        this.contactfirstnameLabel.Size = new Size(165, 31);
        this.contactfirstnameLabel.TabIndex = 18;
        this.contactfirstnameLabel.Text = "Prenom du contact :";
        this.contactfirstnameLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // supplierproductsValues
        // 
        this.supplierproductsValues.FormattingEnabled = true;
        this.supplierproductsValues.ItemHeight = 20;
        this.supplierproductsValues.Location = new Point(179, 435);
        this.supplierproductsValues.Margin = new Padding(3, 4, 3, 4);
        this.supplierproductsValues.Name = "supplierproductsValues";
        this.supplierproductsValues.SelectionMode = SelectionMode.MultiSimple;
        this.supplierproductsValues.Size = new Size(267, 124);
        this.supplierproductsValues.TabIndex = 17;
        // 
        // supplierproductsLabel
        // 
        this.supplierproductsLabel.Location = new Point(0, 435);
        this.supplierproductsLabel.Margin = new Padding(6, 7, 6, 7);
        this.supplierproductsLabel.Name = "supplierproductsLabel";
        this.supplierproductsLabel.Size = new Size(165, 57);
        this.supplierproductsLabel.TabIndex = 16;
        this.supplierproductsLabel.Text = "Les produits du fournisseurs :";
        this.supplierproductsLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateDeletedValue
        // 
        this.dateDeletedValue.Enabled = false;
        this.dateDeletedValue.Location = new Point(179, 377);
        this.dateDeletedValue.Margin = new Padding(3, 4, 3, 4);
        this.dateDeletedValue.Name = "dateDeletedValue";
        this.dateDeletedValue.Size = new Size(267, 27);
        this.dateDeletedValue.TabIndex = 15;
        // 
        // dateModifiedValue
        // 
        this.dateModifiedValue.Enabled = false;
        this.dateModifiedValue.Location = new Point(179, 328);
        this.dateModifiedValue.Margin = new Padding(3, 4, 3, 4);
        this.dateModifiedValue.Name = "dateModifiedValue";
        this.dateModifiedValue.Size = new Size(267, 27);
        this.dateModifiedValue.TabIndex = 14;
        // 
        // dateCreatedValue
        // 
        this.dateCreatedValue.Enabled = false;
        this.dateCreatedValue.Location = new Point(180, 283);
        this.dateCreatedValue.Margin = new Padding(3, 4, 3, 4);
        this.dateCreatedValue.Name = "dateCreatedValue";
        this.dateCreatedValue.Size = new Size(267, 27);
        this.dateCreatedValue.TabIndex = 13;
        // 
        // dateDeletedLabel
        // 
        this.dateDeletedLabel.Location = new Point(6, 373);
        this.dateDeletedLabel.Margin = new Padding(6, 7, 6, 7);
        this.dateDeletedLabel.Name = "dateDeletedLabel";
        this.dateDeletedLabel.Size = new Size(165, 31);
        this.dateDeletedLabel.TabIndex = 8;
        this.dateDeletedLabel.Text = "Date de suppression :";
        this.dateDeletedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateCreatedLabel
        // 
        this.dateCreatedLabel.Location = new Point(6, 283);
        this.dateCreatedLabel.Margin = new Padding(6, 7, 6, 7);
        this.dateCreatedLabel.Name = "dateCreatedLabel";
        this.dateCreatedLabel.Size = new Size(165, 31);
        this.dateCreatedLabel.TabIndex = 6;
        this.dateCreatedLabel.Text = "Date de création :";
        this.dateCreatedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // centerPanel
        // 
        this.centerPanel.Controls.Add(this.contactphoneValue);
        this.centerPanel.Controls.Add(this.contactphoneLabel);
        this.centerPanel.Controls.Add(this.contactemailValue);
        this.centerPanel.Controls.Add(this.contactlastnameValue);
        this.centerPanel.Controls.Add(this.contactfirstnameLabel);
        this.centerPanel.Controls.Add(this.supplierproductsValues);
        this.centerPanel.Controls.Add(this.supplierproductsLabel);
        this.centerPanel.Controls.Add(this.dateDeletedValue);
        this.centerPanel.Controls.Add(this.dateModifiedValue);
        this.centerPanel.Controls.Add(this.dateCreatedValue);
        this.centerPanel.Controls.Add(this.contactfirstnameValue);
        this.centerPanel.Controls.Add(this.suppliernameValue);
        this.centerPanel.Controls.Add(this.dateDeletedLabel);
        this.centerPanel.Controls.Add(this.dateModifiedLabel);
        this.centerPanel.Controls.Add(this.dateCreatedLabel);
        this.centerPanel.Controls.Add(this.contactemailLabel);
        this.centerPanel.Controls.Add(this.contactlastnameLabel);
        this.centerPanel.Controls.Add(this.suppliernameLabel);
        this.centerPanel.Controls.Add(this.idValue);
        this.centerPanel.Controls.Add(this.idLabel);
        this.centerPanel.Dock = DockStyle.Fill;
        this.centerPanel.Location = new Point(174, 4);
        this.centerPanel.Margin = new Padding(3, 4, 3, 4);
        this.centerPanel.Name = "centerPanel";
        this.centerPanel.Size = new Size(451, 561);
        this.centerPanel.TabIndex = 0;
        // 
        // contactfirstnameValue
        // 
        this.contactfirstnameValue.Location = new Point(179, 109);
        this.contactfirstnameValue.Margin = new Padding(3, 4, 3, 4);
        this.contactfirstnameValue.Name = "contactfirstnameValue";
        this.contactfirstnameValue.PlaceholderText = "Prenom contact";
        this.contactfirstnameValue.Size = new Size(267, 27);
        this.contactfirstnameValue.TabIndex = 10;
        this.contactfirstnameValue.UseSystemPasswordChar = true;
        // 
        // suppliernameValue
        // 
        this.suppliernameValue.Location = new Point(179, 65);
        this.suppliernameValue.Margin = new Padding(3, 4, 3, 4);
        this.suppliernameValue.Name = "suppliernameValue";
        this.suppliernameValue.PlaceholderText = "Nom du fournisseur";
        this.suppliernameValue.Size = new Size(267, 27);
        this.suppliernameValue.TabIndex = 9;
        // 
        // dateModifiedLabel
        // 
        this.dateModifiedLabel.Location = new Point(6, 328);
        this.dateModifiedLabel.Margin = new Padding(6, 7, 6, 7);
        this.dateModifiedLabel.Name = "dateModifiedLabel";
        this.dateModifiedLabel.Size = new Size(165, 31);
        this.dateModifiedLabel.TabIndex = 7;
        this.dateModifiedLabel.Text = "Date de modification :";
        this.dateModifiedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // contactemailLabel
        // 
        this.contactemailLabel.Location = new Point(6, 196);
        this.contactemailLabel.Margin = new Padding(6, 7, 6, 7);
        this.contactemailLabel.Name = "contactemailLabel";
        this.contactemailLabel.Size = new Size(165, 31);
        this.contactemailLabel.TabIndex = 5;
        this.contactemailLabel.Text = "Courriel du contact :";
        this.contactemailLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // contactlastnameLabel
        // 
        this.contactlastnameLabel.Location = new Point(6, 152);
        this.contactlastnameLabel.Margin = new Padding(6, 7, 6, 7);
        this.contactlastnameLabel.Name = "contactlastnameLabel";
        this.contactlastnameLabel.Size = new Size(165, 31);
        this.contactlastnameLabel.TabIndex = 4;
        this.contactlastnameLabel.Text = "Nom du contact :";
        this.contactlastnameLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // suppliernameLabel
        // 
        this.suppliernameLabel.Location = new Point(6, 64);
        this.suppliernameLabel.Margin = new Padding(6, 7, 6, 7);
        this.suppliernameLabel.Name = "suppliernameLabel";
        this.suppliernameLabel.Size = new Size(165, 31);
        this.suppliernameLabel.TabIndex = 2;
        this.suppliernameLabel.Text = "Nom du fournisseur :";
        this.suppliernameLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // idValue
        // 
        this.idValue.Enabled = false;
        this.idValue.Location = new Point(179, 23);
        this.idValue.Margin = new Padding(3, 4, 3, 4);
        this.idValue.Name = "idValue";
        this.idValue.Size = new Size(267, 27);
        this.idValue.TabIndex = 1;
        // 
        // idLabel
        // 
        this.idLabel.Location = new Point(6, 20);
        this.idLabel.Margin = new Padding(6, 7, 6, 7);
        this.idLabel.Name = "idLabel";
        this.idLabel.Size = new Size(165, 31);
        this.idLabel.TabIndex = 0;
        this.idLabel.Text = "Id :";
        this.idLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // btnAction
        // 
        this.btnAction.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.btnAction.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.btnAction.Location = new Point(1278, -13);
        this.btnAction.Margin = new Padding(3, 4, 3, 4);
        this.btnAction.Name = "btnAction";
        this.btnAction.Size = new Size(130, 31);
        this.btnAction.TabIndex = 1;
        this.btnAction.Text = "ACTION";
        this.btnAction.UseVisualStyleBackColor = true;
        // 
        // btnCancel
        // 
        this.btnCancel.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.btnCancel.Location = new Point(1415, -13);
        this.btnCancel.Margin = new Padding(3, 4, 3, 4);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new Size(86, 31);
        this.btnCancel.TabIndex = 0;
        this.btnCancel.Text = "Annuler";
        this.btnCancel.UseVisualStyleBackColor = true;
        // 
        // centerBarTabLayPanel
        // 
        this.centerBarTabLayPanel.ColumnCount = 3;
        this.centerBarTabLayPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.centerBarTabLayPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 457F));
        this.centerBarTabLayPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.centerBarTabLayPanel.Controls.Add(this.centerPanel, 1, 0);
        this.centerBarTabLayPanel.Dock = DockStyle.Fill;
        this.centerBarTabLayPanel.Location = new Point(0, 67);
        this.centerBarTabLayPanel.Margin = new Padding(3, 4, 3, 4);
        this.centerBarTabLayPanel.Name = "centerBarTabLayPanel";
        this.centerBarTabLayPanel.RowCount = 1;
        this.centerBarTabLayPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.centerBarTabLayPanel.Size = new Size(800, 569);
        this.centerBarTabLayPanel.TabIndex = 5;
        // 
        // topBarPanel
        // 
        this.topBarPanel.Controls.Add(this.openendModeValue);
        this.topBarPanel.Controls.Add(this.openedModeLabel);
        this.topBarPanel.Dock = DockStyle.Top;
        this.topBarPanel.Location = new Point(0, 0);
        this.topBarPanel.Margin = new Padding(3, 4, 3, 4);
        this.topBarPanel.Name = "topBarPanel";
        this.topBarPanel.Size = new Size(800, 67);
        this.topBarPanel.TabIndex = 3;
        // 
        // openendModeValue
        // 
        this.openendModeValue.AutoSize = true;
        this.openendModeValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.openendModeValue.Location = new Point(61, 12);
        this.openendModeValue.Name = "openendModeValue";
        this.openendModeValue.Size = new Size(90, 20);
        this.openendModeValue.TabIndex = 1;
        this.openendModeValue.Text = "Placeholder";
        // 
        // openedModeLabel
        // 
        this.openedModeLabel.AutoSize = true;
        this.openedModeLabel.Location = new Point(3, 12);
        this.openedModeLabel.Name = "openedModeLabel";
        this.openedModeLabel.Size = new Size(55, 20);
        this.openedModeLabel.TabIndex = 0;
        this.openedModeLabel.Text = "Mode :";
        // 
        // bottomBarPanel
        // 
        this.bottomBarPanel.Controls.Add(this.cancelBtn);
        this.bottomBarPanel.Controls.Add(this.actionBtn);
        this.bottomBarPanel.Controls.Add(this.btnAction);
        this.bottomBarPanel.Controls.Add(this.btnCancel);
        this.bottomBarPanel.Dock = DockStyle.Bottom;
        this.bottomBarPanel.Location = new Point(0, 636);
        this.bottomBarPanel.Margin = new Padding(3, 4, 3, 4);
        this.bottomBarPanel.Name = "bottomBarPanel";
        this.bottomBarPanel.Size = new Size(800, 67);
        this.bottomBarPanel.TabIndex = 4;
        // 
        // actionBtn
        // 
        this.actionBtn.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.actionBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.actionBtn.Location = new Point(504, 23);
        this.actionBtn.Margin = new Padding(3, 4, 3, 4);
        this.actionBtn.Name = "actionBtn";
        this.actionBtn.Size = new Size(130, 31);
        this.actionBtn.TabIndex = 2;
        this.actionBtn.Text = "ACTION";
        this.actionBtn.UseVisualStyleBackColor = true;
        this.actionBtn.Click += this.actionBtn_Click;
        // 
        // cancelBtn
        // 
        this.cancelBtn.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.cancelBtn.Location = new Point(702, 23);
        this.cancelBtn.Margin = new Padding(3, 4, 3, 4);
        this.cancelBtn.Name = "cancelBtn";
        this.cancelBtn.Size = new Size(86, 31);
        this.cancelBtn.TabIndex = 3;
        this.cancelBtn.Text = "Annuler";
        this.cancelBtn.UseVisualStyleBackColor = true;
        this.cancelBtn.Click += this.cancelBtn_Click;
        // 
        // SupplierView
        // 
        this.AutoScaleDimensions = new SizeF(8F, 20F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(800, 703);
        this.Controls.Add(this.centerBarTabLayPanel);
        this.Controls.Add(this.topBarPanel);
        this.Controls.Add(this.bottomBarPanel);
        this.Name = "SupplierView";
        this.Text = "SupplierView";
        this.centerPanel.ResumeLayout(false);
        this.centerPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) this.idValue).EndInit();
        this.centerBarTabLayPanel.ResumeLayout(false);
        this.topBarPanel.ResumeLayout(false);
        this.topBarPanel.PerformLayout();
        this.bottomBarPanel.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion

    private TextBox contactphoneValue;
    private Label contactphoneLabel;
    private TextBox contactemailValue;
    private TextBox contactlastnameValue;
    private Label contactfirstnameLabel;
    private ListBox supplierproductsValues;
    private Label supplierproductsLabel;
    private DateTimePicker dateDeletedValue;
    private DateTimePicker dateModifiedValue;
    private DateTimePicker dateCreatedValue;
    private Label dateDeletedLabel;
    private Label dateCreatedLabel;
    private Panel centerPanel;
    private TextBox contactfirstnameValue;
    private TextBox suppliernameValue;
    private Label dateModifiedLabel;
    private Label contactemailLabel;
    private Label contactlastnameLabel;
    private Label suppliernameLabel;
    private NumericUpDown idValue;
    private Label idLabel;
    private Button btnAction;
    private Button btnCancel;
    private TableLayoutPanel centerBarTabLayPanel;
    private Panel topBarPanel;
    private Label openendModeValue;
    private Label openedModeLabel;
    private Panel bottomBarPanel;
    private Button actionBtn;
    private Button cancelBtn;
}