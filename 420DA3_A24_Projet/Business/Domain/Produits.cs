using System.ComponentModel.DataAnnotations;

namespace _420DA3_A24_Projet.Business.Domain;

/// <summary>
/// Classe représentant un produit stocké dans les entrepôts.
/// </summary>
public class Produits {
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

    #endregion

    #region Constructeurs

    public Produits() {
        // Default constructor for EF
    }

    public Produits(
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
        int entrepotId) {
       
        ProductName = productName;
        ProductDescription = productDescription;
        UpcCode = upcCode;
        ImageFileName = imageFileName;
        ClientId = clientId;
        SupplierName = supplierName;
        SupplierCode = supplierCode;
        StockQuantity = stockQuantity;
        TargetStockQuantity = targetStockQuantity;
        WeightKg = weightKg;
        EntrepotId = entrepotId;
    }

    protected Produits(
        int id,
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
        byte[] rowVersion): this(productName, productDescription, upcCode, imageFileName, clientId, supplierName, supplierCode, stockQuantity, targetStockQuantity, weightKg, entrepotId) {
        
        Id = id;
        DateCreated = dateCreated;
        DateModified = dateModified;
        DateDeleted = dateDeleted;
        RowVersion = rowVersion;
    }

    #endregion

    #region Méthodes

    public override string ToString() {
        return $"{ProductName} (UPC: {UpcCode}) - Stock: {StockQuantity}/{TargetStockQuantity}, Poids: {WeightKg}kg, Entrepôt: {EntrepotId}";
    }

    #endregion
}
