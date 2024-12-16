using System.ComponentModel.DataAnnotations;

namespace _420DA3_A24_Projet.Business.Domain;

public class Product
{
    // Constants 
    public const int PRODUCT_NAME_MAX_LENGTH = 255;
    public const int PRODUCT_DESCRIPTION_MAX_LENGTH = 1024;
    public const int UPC_CODE_MAX_LENGTH = 24;
    public const int IMAGE_FILE_NAME_MAX_LENGTH = 128;
    public const int SUPPLIER_CODE_MAX_LENGTH = 24;

    // Private properties 
    private string productName = null!;
    private string desc = null!;
    private string codeUPC = null!;
    private string pictureName = null!;
    private string supplierCode = null!;

    public int ProductId { get; set; }
    public string ProductName
    {
        get
        {
            return this.productName;
        }
        set
        {
            this.productName = !ValidateProductName(value)
                ? throw new ArgumentOutOfRangeException($"Product Name must be under {PRODUCT_NAME_MAX_LENGTH} character!")
                : value;
        }
    }
    public string ProductDescription
    {
        get
        {
            return this.desc;
        }
        set
        {
            this.desc = !ValidateProductDesc(value)
                ? throw new ArgumentOutOfRangeException($"Product Description must be under {PRODUCT_DESCRIPTION_MAX_LENGTH} characters!")
                : value;
        }
    }
    public string UpcCode
    {
        get
        {
            return this.UpcCode;
        }
        set
        {
            this.UpcCode = !ValidateCodeUPC(value)
                ? throw new ArgumentOutOfRangeException($"Product UPC code must be exactly {UPC_CODE_MAX_LENGTH} characters!")
                : value;
        }
    }
    public String? ImageFileName
    {
        get
        {
            return this.pictureName;
        }
        set
        {
            this.pictureName = !ValidatePictureName(value)
                ? throw new ArgumentOutOfRangeException($"Product Picture Name must be under {IMAGE_FILE_NAME_MAX_LENGTH} characters!")
                : value;
        }
    }

    public int ClientId { get; set; }
    public int SupplierId { get; set; }
    public string SupplierCode
    {
        get
        {
            return this.supplierCode;
        }
        set
        {
            this.supplierCode = !ValidateSupplierCode(value)
                ? throw new ArgumentOutOfRangeException($"Product Supplier Code must be under {SUPPLIER_CODE_MAX_LENGTH} characters!")
                : value;
        }
    }
    public int InStockQty { get; set; }
    public int DesiredQty { get; set; }
    public double WeightKg { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime? DateModified { get; set; }

    public DateTime? DateDeleted { get; set; }
    public byte[] RowVersion { get; set; } = null!;

    
    // Propriété de navigation 
    public virtual Supplier Supplier { get; set; } = null!;
    public virtual Client Client { get; set; } = null!;

    public virtual Warehouse Warehouse { get; set; } = null!;

    public virtual List<PurchaseOrder> PurchaseOrders { get; set; } = null!;
    public virtual List<orderExpedetion> OrderExpedetion { get; set; } = null!;

    // Constructeur
    public Product(string productName, string desc, string UpcCode, int clientId, int supplierId, string supplierCode, int quantity,
        int aimQuantity, double weight, string? pictureName = null)
    {
        this.ProductName = productName;
        this.ProductDescription = desc;
        this.UpcCode = UpcCode;
        this.ClientId = clientId;
        this.SupplierId = supplierId;
        this.SupplierCode = supplierCode;
        this.InStockQty = quantity;
        this.DesiredQty = aimQuantity;
        this.WeightKg = weight;
        this.ImageFileName = pictureName;
    }

    // Constructeur DB
    private Product(int productId, string productName, string desc, string UpcCode, int clientId, int supplierId, string supplierCode, int quantity,
        int aimQuantity, double weight, DateTime dateCreated, DateTime? dateModified, DateTime? dateDeleted, byte[] rowVersion, string? pictureName = null)
        : this(productName, desc, UpcCode, clientId, supplierId, supplierCode, quantity, aimQuantity, weight, pictureName)
    {
        this.ProductId = productId;
        this.DateCreated = dateCreated;
        this.DateModified = dateModified;
        this.DateDeleted = dateDeleted;
        this.RowVersion = rowVersion;
    }

    // Constructeur vide
    public Product() { }

    #region METHODES DE VERIFICATION
    static private bool ValidateProductName(string value)
    {
        return value.Length <= PRODUCT_NAME_MAX_LENGTH;
    }

    static private bool ValidateProductDesc(string value)
    {
        return value.Length <= PRODUCT_DESCRIPTION_MAX_LENGTH;
    }

    static private bool ValidateCodeUPC(string value)
    {
        return value.Length == UPC_CODE_MAX_LENGTH;
    }

    static private bool ValidatePictureName(string value)
    {
        return value.Length <= IMAGE_FILE_NAME_MAX_LENGTH || value == null;
    }

    static private bool ValidateSupplierCode(string value)
    {
        return value.Length <= SUPPLIER_CODE_MAX_LENGTH;
    }

    #endregion

    #region METHODES

    public override string ToString()
    {
        return $"#{this.ProductId} - {this.productName} | {this.InStockQty}";
    }
    #endregion

}

