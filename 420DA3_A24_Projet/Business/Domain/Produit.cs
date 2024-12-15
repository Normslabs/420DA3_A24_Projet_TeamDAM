using System.ComponentModel.DataAnnotations;

namespace _420DA3_A24_Projet.Business.Domain;

/// <summary>
/// Classe représentant un produit stocké dans les entrepôts.
/// </summary>
public class Produit {
    // Constantes pour les limites de validation
    public const int PRODUCT_NAME_MAX_LENGTH = 128;
    public const int PRODUCT_DESCRIPTION_MAX_LENGTH = 512;
    public const int UPC_CODE_LENGTH = 12;
    public const int SUPPLIER_CODE_MAX_LENGTH = 64;
    public const int IMAGE_FILE_NAME_MAX_LENGTH = 256;

    #region Propriétés de données

    [Key]
    public int Id { get; set; }

    [Required, MaxLength(PRODUCT_NAME_MAX_LENGTH)]
    public string ProductName { get; set; } = null!;

    [MaxLength(PRODUCT_DESCRIPTION_MAX_LENGTH)]
    public string ProductDescription { get; set; } = null!;

    [Required, StringLength(UPC_CODE_LENGTH)]
    public string UpcCode { get; set; } = null!;

    [MaxLength(IMAGE_FILE_NAME_MAX_LENGTH)]
    public string? ImageFileName { get; set; }

    [Required]
    public int ClientId { get; set; }

    public virtual Client Client { get; set; } = null!;

    [Required, MaxLength(SUPPLIER_CODE_MAX_LENGTH)]
    public string SupplierName { get; set; } = null!;

    [MaxLength(SUPPLIER_CODE_MAX_LENGTH)]
    public string SupplierCode { get; set; } = null!;

    [Required]
    public int StockQuantity { get; set; }

    [Required]
    public int TargetStockQuantity { get; set; }

    [Required]
    public decimal WeightKg { get; set; }

    public DateTime DateCreated { get; set; } = DateTime.UtcNow;

    public DateTime? DateModified { get; set; }

    public DateTime? DateDeleted { get; set; }

    [Timestamp]
    public byte[] RowVersion { get; set; } = Array.Empty<byte>();

    #endregion

    #region Propriétés de navigation

    [Required]
    public int EntrepotId { get; set; }

    public virtual Entrepot Entrepot { get; set; } = null!;
    public object Nom { get; internal set; }
    public object Description { get; internal set; }
    public object Prix { get; internal set; }
    public object Stock { get; internal set; }
    public object DateCreation { get; internal set; }
    public object DateModification { get; internal set; }
    public object DateSuppression { get; internal set; }

    #endregion

    #region Constructeurs

    public Produit() {
        // Default constructor for EF
    }

    public Produit(string productName,
                   string productDescription,
                   string upcCode,
                   string? imageFileName,
                   int clientId,
                   string supplierName,
                   string supplierCode,
                   int stockQuantity,
                   int targetStockQuantity,
                   decimal weightKg,
                   int entrepotId) {
       
        this.ProductName = productName;
        this.ProductDescription = productDescription;
        this.UpcCode = upcCode;
        this.ImageFileName = imageFileName;
        this.ClientId = clientId;
        this.SupplierName = supplierName;
        this.SupplierCode = supplierCode;
        this.StockQuantity = stockQuantity;
        this.TargetStockQuantity = targetStockQuantity;
        this.WeightKg = weightKg;
        this.EntrepotId = entrepotId;
    }

    protected Produit(int id,
                      string productName,
                      string productDescription,
                      string upcCode,
                      string? imageFileName,
                      int clientId,
                      string supplierName,
                      string supplierCode,
                      int stockQuantity,
                      int targetStockQuantity,
                      decimal weightKg,
                      int entrepotId,
                      DateTime dateCreated,
                      DateTime? dateModified,
                      DateTime? dateDeleted,
                      byte[] rowVersion) : this(productName, productDescription, upcCode, imageFileName, clientId, supplierName, supplierCode, stockQuantity, targetStockQuantity, weightKg, entrepotId) {
        
        this.Id = id;
        this.DateCreated = dateCreated;
        this.DateModified = dateModified;
        this.DateDeleted = dateDeleted;
        this.RowVersion = rowVersion;
    }

    #endregion

    #region Méthodes

    public override string ToString() {
        return $"{this.ProductName} (UPC: {this.UpcCode}) - Stock: {this.StockQuantity}/{this.TargetStockQuantity}, Poids: {this.WeightKg}kg, Entrepôt: {this.EntrepotId}";
    }

    #endregion
}
