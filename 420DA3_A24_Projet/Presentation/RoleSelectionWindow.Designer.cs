namespace _420DA3_A24_Projet.Presentation;

partial class RoleSelectionWindow {
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
        this.mainTLP = new TableLayoutPanel();
        this.centerPanel = new Panel();
        this.userRolesListBox = new ListBox();
        this.label1 = new Label();
        this.buttonsTLP = new TableLayoutPanel();
        this.connectionButtonPanel = new Panel();
        this.buttonSelectRole = new Button();
        this.cancelButtonPanel = new Panel();
        this.buttonCancel = new Button();
        this.mainTLP.SuspendLayout();
        this.centerPanel.SuspendLayout();
        this.buttonsTLP.SuspendLayout();
        this.connectionButtonPanel.SuspendLayout();
        this.cancelButtonPanel.SuspendLayout();
        this.SuspendLayout();
        // 
        // mainTLP
        // 
        this.mainTLP.ColumnCount = 3;
        this.mainTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.mainTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
        this.mainTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.mainTLP.Controls.Add(this.centerPanel, 1, 1);
        this.mainTLP.Controls.Add(this.label1, 1, 0);
        this.mainTLP.Dock = DockStyle.Fill;
        this.mainTLP.Location = new Point(0, 0);
        this.mainTLP.Name = "mainTLP";
        this.mainTLP.RowCount = 3;
        this.mainTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        this.mainTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 250F));
        this.mainTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        this.mainTLP.Size = new Size(284, 361);
        this.mainTLP.TabIndex = 0;
        // 
        // centerPanel
        // 
        this.centerPanel.Controls.Add(this.buttonsTLP);
        this.centerPanel.Controls.Add(this.userRolesListBox);
        this.centerPanel.Dock = DockStyle.Fill;
        this.centerPanel.Location = new Point(45, 63);
        this.centerPanel.Margin = new Padding(3, 8, 3, 3);
        this.centerPanel.Name = "centerPanel";
        this.centerPanel.Size = new Size(194, 239);
        this.centerPanel.TabIndex = 0;
        // 
        // userRolesListBox
        // 
        this.userRolesListBox.Dock = DockStyle.Top;
        this.userRolesListBox.FormattingEnabled = true;
        this.userRolesListBox.ItemHeight = 15;
        this.userRolesListBox.Location = new Point(0, 0);
        this.userRolesListBox.Name = "userRolesListBox";
        this.userRolesListBox.Size = new Size(194, 139);
        this.userRolesListBox.TabIndex = 0;
        this.userRolesListBox.SelectedIndexChanged += this.UserRolesListBox_SelectedIndexChanged;
        // 
        // label1
        // 
        this.label1.Dock = DockStyle.Fill;
        this.label1.Location = new Point(45, 0);
        this.label1.Name = "label1";
        this.label1.Size = new Size(194, 55);
        this.label1.TabIndex = 1;
        this.label1.Text = "Sélectionnez un rôle à utiliser";
        this.label1.TextAlign = ContentAlignment.BottomCenter;
        // 
        // buttonsTLP
        // 
        this.buttonsTLP.ColumnCount = 3;
        this.buttonsTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.buttonsTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
        this.buttonsTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.buttonsTLP.Controls.Add(this.connectionButtonPanel, 1, 0);
        this.buttonsTLP.Controls.Add(this.cancelButtonPanel, 1, 1);
        this.buttonsTLP.Dock = DockStyle.Fill;
        this.buttonsTLP.Location = new Point(0, 139);
        this.buttonsTLP.Name = "buttonsTLP";
        this.buttonsTLP.RowCount = 2;
        this.buttonsTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        this.buttonsTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        this.buttonsTLP.Size = new Size(194, 100);
        this.buttonsTLP.TabIndex = 1;
        // 
        // connectionButtonPanel
        // 
        this.connectionButtonPanel.Controls.Add(this.buttonSelectRole);
        this.connectionButtonPanel.Dock = DockStyle.Fill;
        this.connectionButtonPanel.Location = new Point(40, 3);
        this.connectionButtonPanel.Name = "connectionButtonPanel";
        this.connectionButtonPanel.Size = new Size(114, 44);
        this.connectionButtonPanel.TabIndex = 0;
        // 
        // buttonSelectRole
        // 
        this.buttonSelectRole.Enabled = false;
        this.buttonSelectRole.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
        this.buttonSelectRole.Location = new Point(3, 3);
        this.buttonSelectRole.Name = "buttonSelectRole";
        this.buttonSelectRole.Size = new Size(108, 38);
        this.buttonSelectRole.TabIndex = 0;
        this.buttonSelectRole.Text = "Choisir Rôle";
        this.buttonSelectRole.UseVisualStyleBackColor = true;
        this.buttonSelectRole.Click += this.ButtonSelectRole_Click;
        // 
        // cancelButtonPanel
        // 
        this.cancelButtonPanel.Controls.Add(this.buttonCancel);
        this.cancelButtonPanel.Dock = DockStyle.Fill;
        this.cancelButtonPanel.Location = new Point(40, 53);
        this.cancelButtonPanel.Name = "cancelButtonPanel";
        this.cancelButtonPanel.Size = new Size(114, 44);
        this.cancelButtonPanel.TabIndex = 1;
        // 
        // buttonCancel
        // 
        this.buttonCancel.Location = new Point(3, 3);
        this.buttonCancel.Name = "buttonCancel";
        this.buttonCancel.Size = new Size(108, 23);
        this.buttonCancel.TabIndex = 0;
        this.buttonCancel.Text = "Annuler";
        this.buttonCancel.UseVisualStyleBackColor = true;
        this.buttonCancel.Click += this.ButtonCancel_Click;
        // 
        // RoleSelectionWindow
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(284, 361);
        this.Controls.Add(this.mainTLP);
        this.Name = "RoleSelectionWindow";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Sélection de rôle";
        this.mainTLP.ResumeLayout(false);
        this.centerPanel.ResumeLayout(false);
        this.buttonsTLP.ResumeLayout(false);
        this.connectionButtonPanel.ResumeLayout(false);
        this.cancelButtonPanel.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel mainTLP;
    private Panel centerPanel;
    private ListBox userRolesListBox;
    private TableLayoutPanel buttonsTLP;
    private Panel connectionButtonPanel;
    private Button buttonSelectRole;
    private Panel cancelButtonPanel;
    private Button buttonCancel;
    private Label label1;
}