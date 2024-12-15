namespace _420DA3_A24_Projet.Presentation.Views;

partial class ProduitsView {
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
        this.panel1 = new Panel();
        this.label8 = new Label();
        this.label9 = new Label();
        this.label6 = new Label();
        this.txtUpcCode = new TextBox();
        this.btnCancel = new Button();
        this.btnApply = new Button();
        this.txtNom = new TextBox();
        this.txtPrix = new TextBox();
        this.txtId = new TextBox();
        this.txtDescription = new TextBox();
        this.listSupplier = new ListBox();
        this.listClient = new ListBox();
        this.numericUpDownWeight = new NumericUpDown();
        this.numericUpDownStock = new NumericUpDown();
        this.label5 = new Label();
        this.label4 = new Label();
        this.label3 = new Label();
        this.label2 = new Label();
        this.label1 = new Label();
        this.titreID = new Label();
        this.panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) this.numericUpDownWeight).BeginInit();
        ((System.ComponentModel.ISupportInitialize) this.numericUpDownStock).BeginInit();
        this.SuspendLayout();
        // 
        // panel1
        // 
        this.panel1.Controls.Add(this.label8);
        this.panel1.Controls.Add(this.label9);
        this.panel1.Controls.Add(this.label6);
        this.panel1.Controls.Add(this.txtUpcCode);
        this.panel1.Controls.Add(this.btnCancel);
        this.panel1.Controls.Add(this.btnApply);
        this.panel1.Controls.Add(this.txtNom);
        this.panel1.Controls.Add(this.txtPrix);
        this.panel1.Controls.Add(this.txtId);
        this.panel1.Controls.Add(this.txtDescription);
        this.panel1.Controls.Add(this.listSupplier);
        this.panel1.Controls.Add(this.listClient);
        this.panel1.Controls.Add(this.numericUpDownWeight);
        this.panel1.Controls.Add(this.numericUpDownStock);
        this.panel1.Controls.Add(this.label5);
        this.panel1.Controls.Add(this.label4);
        this.panel1.Controls.Add(this.label3);
        this.panel1.Controls.Add(this.label2);
        this.panel1.Controls.Add(this.label1);
        this.panel1.Controls.Add(this.titreID);
        this.panel1.Location = new Point(1, 0);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(799, 450);
        this.panel1.TabIndex = 0;
        // 
        // label8
        // 
        this.label8.AutoSize = true;
        this.label8.Font = new Font("Segoe UI", 11.25F,  FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
        this.label8.Location = new Point(545, 14);
        this.label8.Name = "label8";
        this.label8.Size = new Size(56, 20);
        this.label8.TabIndex = 23;
        this.label8.Text = "Client ";
        // 
        // label9
        // 
        this.label9.AutoSize = true;
        this.label9.Font = new Font("Segoe UI", 11.25F,  FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
        this.label9.Location = new Point(545, 228);
        this.label9.Name = "label9";
        this.label9.Size = new Size(76, 20);
        this.label9.TabIndex = 22;
        this.label9.Text = "Supplier  ";
        // 
        // label6
        // 
        this.label6.AutoSize = true;
        this.label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        this.label6.Location = new Point(47, 220);
        this.label6.Name = "label6";
        this.label6.Size = new Size(82, 17);
        this.label6.TabIndex = 19;
        this.label6.Text = "UPC Code  : ";
        this.label6.Click += this.label6_Click;
        // 
        // txtUpcCode
        // 
        this.txtUpcCode.Location = new Point(134, 220);
        this.txtUpcCode.Name = "txtUpcCode";
        this.txtUpcCode.PlaceholderText = "Code UPC du produit";
        this.txtUpcCode.Size = new Size(305, 23);
        this.txtUpcCode.TabIndex = 18;
        // 
        // btnCancel
        // 
        this.btnCancel.Location = new Point(309, 362);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new Size(130, 38);
        this.btnCancel.TabIndex = 17;
        this.btnCancel.Text = "Cancel";
        this.btnCancel.UseVisualStyleBackColor = true;
        // 
        // btnApply
        // 
        this.btnApply.Location = new Point(134, 362);
        this.btnApply.Name = "btnApply";
        this.btnApply.Size = new Size(169, 38);
        this.btnApply.TabIndex = 16;
        this.btnApply.Text = "Apply";
        this.btnApply.UseVisualStyleBackColor = true;
        this.btnApply.Click += this.button1_Click;
        // 
        // txtNom
        // 
        this.txtNom.Location = new Point(134, 102);
        this.txtNom.Name = "txtNom";
        this.txtNom.PlaceholderText = "Nom du produit";
        this.txtNom.Size = new Size(305, 23);
        this.txtNom.TabIndex = 15;
        // 
        // txtPrix
        // 
        this.txtPrix.Location = new Point(134, 182);
        this.txtPrix.Name = "txtPrix";
        this.txtPrix.PlaceholderText = "Prix du produit";
        this.txtPrix.Size = new Size(305, 23);
        this.txtPrix.TabIndex = 13;
        // 
        // txtId
        // 
        this.txtId.Location = new Point(134, 63);
        this.txtId.Name = "txtId";
        this.txtId.Size = new Size(305, 23);
        this.txtId.TabIndex = 12;
        // 
        // txtDescription
        // 
        this.txtDescription.Location = new Point(134, 143);
        this.txtDescription.Name = "txtDescription";
        this.txtDescription.PlaceholderText = "Description du produit";
        this.txtDescription.Size = new Size(305, 23);
        this.txtDescription.TabIndex = 11;
        // 
        // listSupplier
        // 
        this.listSupplier.FormattingEnabled = true;
        this.listSupplier.ItemHeight = 15;
        this.listSupplier.Location = new Point(487, 248);
        this.listSupplier.Name = "listSupplier";
        this.listSupplier.Size = new Size(284, 184);
        this.listSupplier.TabIndex = 10;
        // 
        // listClient
        // 
        this.listClient.FormattingEnabled = true;
        this.listClient.ItemHeight = 15;
        this.listClient.Location = new Point(487, 34);
        this.listClient.Name = "listClient";
        this.listClient.Size = new Size(284, 184);
        this.listClient.TabIndex = 9;
        // 
        // numericUpDownWeight
        // 
        this.numericUpDownWeight.Location = new Point(134, 300);
        this.numericUpDownWeight.Name = "numericUpDownWeight";
        this.numericUpDownWeight.Size = new Size(305, 23);
        this.numericUpDownWeight.TabIndex = 8;
        // 
        // numericUpDownStock
        // 
        this.numericUpDownStock.Location = new Point(134, 260);
        this.numericUpDownStock.Name = "numericUpDownStock";
        this.numericUpDownStock.Size = new Size(305, 23);
        this.numericUpDownStock.TabIndex = 6;
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        this.label5.Location = new Point(75, 260);
        this.label5.Name = "label5";
        this.label5.Size = new Size(54, 17);
        this.label5.TabIndex = 5;
        this.label5.Text = "Stock  : ";
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        this.label4.Location = new Point(67, 300);
        this.label4.Name = "label4";
        this.label4.Size = new Size(59, 17);
        this.label4.TabIndex = 4;
        this.label4.Text = "Weight : ";
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        this.label3.Location = new Point(83, 103);
        this.label3.Name = "label3";
        this.label3.Size = new Size(48, 17);
        this.label3.TabIndex = 3;
        this.label3.Text = "Nom : ";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        this.label2.Location = new Point(37, 143);
        this.label2.Name = "label2";
        this.label2.Size = new Size(89, 17);
        this.label2.TabIndex = 2;
        this.label2.Text = "Description  : ";
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        this.label1.Location = new Point(86, 183);
        this.label1.Name = "label1";
        this.label1.Size = new Size(40, 17);
        this.label1.TabIndex = 1;
        this.label1.Text = "Prix : ";
        // 
        // titreID
        // 
        this.titreID.AutoSize = true;
        this.titreID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        this.titreID.Location = new Point(99, 63);
        this.titreID.Name = "titreID";
        this.titreID.Size = new Size(31, 17);
        this.titreID.TabIndex = 0;
        this.titreID.Text = "ID : ";
        // 
        // ProduitsView
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(800, 450);
        this.Controls.Add(this.panel1);
        this.Name = "ProduitsView";
        this.Text = "ProduitsView";
        this.Load += this.ProduitsView_Load;
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) this.numericUpDownWeight).EndInit();
        ((System.ComponentModel.ISupportInitialize) this.numericUpDownStock).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Label label5;
    private Label label4;
    private Label label3;
    private Label label2;
    private Label label1;
    private Label titreID;
    private NumericUpDown numericUpDownWeight;
    private NumericUpDown numericUpDownStock;
    private TextBox txtNom;
    private TextBox txtPrix;
    private TextBox txtId;
    private TextBox txtDescription;
    private ListBox listSupplier;
    private ListBox listClient;
    private Button btnCancel;
    private Button btnApply;
    private Label label6;
    private TextBox txtUpcCode;
    private Label label8;
    private Label label9;
}