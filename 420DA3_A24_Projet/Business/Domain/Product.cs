using System.ComponentModel.DataAnnotations;

namespace _420DA3_A24_Projet.Business.Domain;

/// <summary>
/// Classe représentant un produit stocké dans les entrepôts.
/// </summary>
public class Product {
    // Constantes pour les limites de validation
    public const int PRODUCT_NAME_MAX_LENGTH = 255;
    public const int PRODUCT_DESCRIPTION_MAX_LENGTH = 1024;
    public const int UPC_CODE_MAX_LENGTH = 24;
    public const int SUPPLIER_CODE_MAX_LENGTH = 24;
    public const int IMAGE_FILE_NAME_MAX_LENGTH = 128;

    #region Propriétés de données

    [Key]
    public int Id { get; set; }

    [Required, MaxLength(PRODUCT_NAME_MAX_LENGTH)]
    public string ProductName { get; set; } = null!;

    [MaxLength(PRODUCT_DESCRIPTION_MAX_LENGTH)]
    public string ProductDescription { get; set; } = null!;

    [Required, StringLength(UPC_CODE_MAX_LENGTH)]
    public string UpcCode { get; set; } = null!;

    [MaxLength(IMAGE_FILE_NAME_MAX_LENGTH)]
    public string? ImageFileName { get; set; }

    [Required]
    public int OwnerClientId { get; set; }

    public virtual Client Client { get; set; } = null!;

    [Required, MaxLength(SUPPLIER_CODE_MAX_LENGTH)]
    public string SupplierName { get; set; } = null!;

    [MaxLength(SUPPLIER_CODE_MAX_LENGTH)]
    public string SupplierCode { get; set; } = null!;


    [Required]
    public double WeightKg { get; set; }

    public int InStockQty { get; set; }
    public int DesiredQty { get; set; }

    public DateTime DateCreated { get; set; } = DateTime.UtcNow;

    public DateTime? DateModified { get; set; }

    public DateTime? DateDeleted { get; set; }

    public Client OwnerClient { get; set; }

    public List<PurchaseOrder> PurchaseOrder { get; set; }
    public List<ShippingOrderProduct> ShippingOrderProduct { get; set; }

    [Timestamp]
    public byte[] RowVersion { get; set; } = Array.Empty<byte>();

    #endregion

    #region Propriétés de navigation

    [Required]
    public int EntrepotId { get; set; }

    public virtual Warehouse Entrepot { get; set; } = null!;
    public object Nom { get; internal set; }
    public object Description { get; internal set; }
    public object Prix { get; internal set; }
    public object Stock { get; internal set; }
    public object DateCreation { get; internal set; }
    public object DateModification { get; internal set; }
    public object DateSuppression { get; internal set; }


    #endregion

    #region Constructeurs

    public Product() {
        // Default constructor for EF
    }

    public Product(string productName,
                   string productDescription,
                   string upcCode,
                   string? imageFileName,
                   int clientId,
                   string supplierid,
                   string supplierCode,
                   int desiredqty,
                   int instockqty,
                   decimal weightKg,
                   int entrepotId) {

        this.ProductName = productName;
        this.ProductDescription = productDescription;
        this.UpcCode = upcCode;
        this.ImageFileName = imageFileName;
        this.OwnerClientId = clientId;
        this.SupplierName = supplierid;
        this.SupplierCode = supplierCode;
        this.DesiredQty = desiredqty;
        this.InStockQty = instockqty;
        this.WeightKg = (double) weightKg;
        this.EntrepotId = entrepotId;
    }

    protected Product(int id,
                      string productName,
                      string productDescription,
                      string upcCode,
                      string? imageFileName,
                      int clientId,
                      string supplierName,
                      string supplierCode,
                      int desiredqty,
                      int instockqty,
                      decimal weightKg,
                      int entrepotId,
                      DateTime dateCreated,
                      DateTime? dateModified,
                      DateTime? dateDeleted,
                      byte[] rowVersion) : this(productName, productDescription, upcCode, imageFileName, clientId, supplierName, supplierCode, desiredqty, instockqty, weightKg, entrepotId) {

        this.Id = id;
        this.DateCreated = dateCreated;
        this.DateModified = dateModified;
        this.DateDeleted = dateDeleted;
        this.RowVersion = rowVersion;
    }

    #endregion

    #region Méthodes
    //Partie pour valider les méthodes
    public bool ValidateUpcCode(string upcCode) {
        return !string.IsNullOrWhiteSpace(upcCode) && upcCode.Length <= UPC_CODE_MAX_LENGTH;
    }

    public bool ValidateProductName(string name) {
        return !string.IsNullOrWhiteSpace(name) && name.Length <= PRODUCT_NAME_MAX_LENGTH;
    }

    public bool ValidateProductDescription(string description) {
        return !string.IsNullOrWhiteSpace(description) && description.Length <= PRODUCT_DESCRIPTION_MAX_LENGTH;
    }

    public bool ValidateImageFileName(string fileName) {
        return !string.IsNullOrWhiteSpace(fileName) && fileName.Length <= IMAGE_FILE_NAME_MAX_LENGTH;
    }

    public bool ValidateSupplierCode(string supplierCode) {
        return !string.IsNullOrWhiteSpace(supplierCode) && supplierCode.Length <= SUPPLIER_CODE_MAX_LENGTH;
    }

    public bool ValidateWeightInKg(double weight) {
        return weight >= 0; // Ensure weight is not negative
    }

    public bool IsDueForRestocking() {
        return this.InStockQty < this.DesiredQty;
    }
    public override string ToString() {
        return $"{this.ProductName} (UPC: {this.UpcCode}) - Stock: {this.DesiredQty}/{this.InStockQty}, Weight: {this.WeightKg}kg, Warehouse: {this.Entrepot.Id}";
    }

    #endregion
}

public class ShippingOrderProduct {
}