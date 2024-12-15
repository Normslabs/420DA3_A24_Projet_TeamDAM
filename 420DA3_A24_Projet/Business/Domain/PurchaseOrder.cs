namespace _420DA3_A24_Projet.Business.Domain;


public class PurchaseOrder {

    public enum OrderStatus {
        New,
        Completed
    }

    // Backing fields
    private int id;
    private OrderStatus status;
    private int productId;
    private int warehouseId;
    private int quantity;

    #region Propriétés de données

    public int Id {
        get { return this.id; }
        set {
            if (!ValidateId(value)) {
                throw new ArgumentOutOfRangeException("Id", "Id must be greater than or equal to 0.");
            }
            this.id = value;
        }
    }

    public OrderStatus Status {
        get { return this.status; }
        set { this.status = value; }
    }

    public int ProductId {
        get { return this.productId; }
        set {
            if (!ValidateId(value)) {
                throw new ArgumentOutOfRangeException("ProductId", "ProductId must be greater than or equal to 0.");
            }
            this.productId = value;
        }
    }

    public int WarehouseId {
        get { return this.warehouseId; }
        set {
            if (!ValidateId(value)) {
                throw new ArgumentOutOfRangeException("WarehouseId", "WarehouseId must be greater than or equal to 0.");
            }
            this.warehouseId = value;
        }
    }

    public int Quantity {
        get { return this.quantity; }
        set {
            if (value <= 0) {
                throw new ArgumentOutOfRangeException("Quantity", "Quantity must be greater than 0.");
            }
            this.quantity = value;
        }
    }

    public DateTime? DateCompleted { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime? DateModified { get; set; }
    public DateTime? DateDeleted { get; set; }
    public byte[] RowVersion { get; set; } = null!;

    #endregion

    #region Propriétés de navigation


    public virtual Produits Product { get; set; } = null!;

    public virtual Entrepot Warehouse { get; set; } = null!;

    #endregion

    #region Constructeurs

    /// <param name="productId">Identifiant du produit à restocker.</param>
    /// <param name="warehouseId">Identifiant de l'entrepôt où le produit est stocké.</param>
    /// <param name="quantity">Quantité à commander.</param>
    public PurchaseOrder(int productId, int warehouseId, int quantity) {
        this.ProductId = productId;
        this.WarehouseId = warehouseId;
        this.Quantity = quantity;
        this.Status = OrderStatus.New;
    }

    protected PurchaseOrder(int id, OrderStatus status, int productId, int warehouseId, int quantity, DateTime? dateCompleted, DateTime dateCreated, DateTime? dateModified, DateTime? dateDeleted, byte[] rowVersion)
        : this(productId, warehouseId, quantity) {
        this.Id = id;
        this.Status = status;
        this.DateCompleted = dateCompleted;
        this.DateCreated = dateCreated;
        this.DateModified = dateModified;
        this.DateDeleted = dateDeleted;
        this.RowVersion = rowVersion;
    }

    #endregion

    #region Méthodes

    public static bool ValidateId(int id) {
        return id >= 0;
    }

    /// Override de <see cref="object.ToString"/> pour affichage dans une ListBox ou ComboBox.
    public override string ToString() {
        return $"RestockOrder #{this.Id} - Product: {this.ProductId}, Warehouse: {this.WarehouseId}, Quantity: {this.Quantity}, Status: {this.Status}";
    }

    #endregion
}
