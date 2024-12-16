using System.ComponentModel.DataAnnotations;

namespace _420DA3_A24_Projet.Business.Domain;

/// <summary>
/// Classe représentant un entrepôt
/// </summary>
public class Warehouse {

    public const int WarehouseNameMaxLength = 128;

    // Attributs de la classe Warehouse
    public int Id { get; set; }



    // Validation du nom avec des annotations de données
    [Required(ErrorMessage = "Le nom est requis.")]
    [StringLength(100, ErrorMessage = "Le nom ne doit pas dépasser 100 caractères.")]
    public string WarehouseName { get; set; }

    // Clé étrangère pour l'adresse de l'entrepôt
    [Required]
    public int AdresseId { get; set; }


    // Dates de gestion (création, modification, suppression)
    public DateTime DateCreation { get; set; } = DateTime.Now;
    public DateTime? DateModification { get; set; }
    public DateTime? DateSuppression { get; set; }
    public byte[]? RowVersion { get; set; } = null;

    // Propriété de navigation pour l'adresse (avec modificateur 'virtual')
    public virtual Adresse Adresse { get; set; }


    public virtual List<Client> Clients { get; set; } = new List<Client>();
    public virtual List<PurchaseOrder> RestockOrders { get; set; } = new List<PurchaseOrder>();
    public virtual List<User> WarehouseEmployes { get; set; } = new List<User>();
    public object Capacite { get; internal set; }
    public object OrdreRestockage { get; internal set; }
    public object WareHouseName { get; private set; }


    public Warehouse(string wareHouseName, int adressId) {
        this.WareHouseName = wareHouseName;
        this.AdresseId = adressId;
    }
    // Constructeur par défaut
    public Warehouse() {
        // La DateCreation doit être définie par la base de données via GETDATE()
    }

    // Constructeur avec des paramètres pour toutes les propriétés de données
    public Warehouse(int id,
                    string nom,
                    int adresseId,
                    DateTime? dateModification = null,
                    DateTime? dateSuppression = null,
                    byte[]? rowVersion = null) {
        this.Id = id;
        this.WarehouseName = nom;
        this.AdresseId = adresseId;
        this.DateModification = dateModification;
        this.DateSuppression = dateSuppression;
        this.RowVersion = rowVersion ?? Array.Empty<byte>();

    }
    public override string ToString() {
        return $"#{this.Id} - {this.WareHouseName}";
    }
    public static bool ValidateWarehouseName(string name) {
        return !string.IsNullOrWhiteSpace(name) && name.Length <= WarehouseNameMaxLength;
    }
}


