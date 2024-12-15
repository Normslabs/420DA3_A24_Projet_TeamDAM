namespace _420DA3_A24_Projet.Business.Domain;
internal class Expedition {

    /// <summary>
    /// Longueur maximale pour le nom du service de livraison.
    /// </summary>
    public const int DELIVERY_SERVICE_MAX_LENGTH = 64;

    /// <summary>
    /// Longueur maximale pour le code de suivi.
    /// </summary>
    public const int TRACKING_CODE_MAX_LENGTH = 128;

    private int id;
    private string deliveryService = null!;
    private string trackingCode = null!;

    /// <summary>
    /// Identifiant unique de l'expédition.
    /// </summary>
    public int Id {
        get { return this.id; }
        set {
            if (!ValidateId(value)) {
                throw new ArgumentOutOfRangeException("Id", "Id must be greater than or equal to 0.");
            }
            this.id = value;
        }
    }

    /// <summary>
    /// Service de livraison (ex. Purolator, PostesCanada, FedEx).
    /// </summary>
    public string DeliveryService {
        get { return this.deliveryService; }
        set {
            if (!ValidateDeliveryService(value)) {
                throw new ArgumentOutOfRangeException("DeliveryService", $"Delivery service name length must be lower than or equal to {DELIVERY_SERVICE_MAX_LENGTH} characters.");
            }
            this.deliveryService = value;
        }
    }

    /// <summary>
    /// Code de suivi de l'expédition.
    /// </summary>
    public string TrackingCode {
        get { return this.trackingCode; }
        set {
            if (!ValidateTrackingCode(value)) {
                throw new ArgumentOutOfRangeException("TrackingCode", $"Tracking code length must be lower than or equal to {TRACKING_CODE_MAX_LENGTH} characters.");
            }
            this.trackingCode = value;
        }
    }

    /// <summary>
    /// Date de création de l'expédition.
    /// </summary>
    public DateTime DateCreated { get; set; }

    /// <summary>
    /// Date de dernière modification de l'expédition.
    /// </summary>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// Date de suppression de l'expédition.
    /// </summary>
    public DateTime? DateDeleted { get; set; }

    /// <summary>
    /// Numéro de version pour la gestion de la concurrence.
    /// </summary>
    public byte[] RowVersion { get; set; } = null!;

    /// <summary>
    /// Constructeur orienté création manuelle/UI.
    /// </summary>
    /// <param name="deliveryService">Le service de livraison.</param>
    /// <param name="trackingCode">Le code de suivi.</param>
    public Expedition(string deliveryService, string trackingCode) {
        this.DeliveryService = deliveryService;
        this.TrackingCode = trackingCode;
    }

    /// <summary>
    /// Constructeur orienté entity framework.
    /// </summary>
    /// <param name="id">L'identifiant de l'expédition.</param>
    /// <param name="deliveryService">Le service de livraison.</param>
    /// <param name="trackingCode">Le code de suivi.</param>
    /// <param name="dateCreated">La date de création.</param>
    /// <param name="dateModified">La date de modification.</param>
    /// <param name="dateDeleted">La date de suppression.</param>
    /// <param name="rowVersion">Le numéro de version anti-concurrence.</param>
    protected Expedition(int id,
                         string deliveryService,
                         string trackingCode,
                         DateTime dateCreated,
                         DateTime? dateModified,
                         DateTime? dateDeleted,
                         byte[] rowVersion)
        : this(deliveryService, trackingCode) {
        this.Id = id;
        this.DateCreated = dateCreated;
        this.DateModified = dateModified;
        this.DateDeleted = dateDeleted;
        this.RowVersion = rowVersion;
    }

    /// <summary>
    /// Méthode de validation d'identifiant d'expédition.
    /// </summary>
    /// <param name="id">Le numéro d'ID à valider.</param>
    /// <returns><see langword="true"/> si valide, <see langword="false"/> sinon.</returns>
    public static bool ValidateId(int id) {
        return id >= 0;
    }

    /// <summary>
    /// Méthode de validation du nom du service de livraison.
    /// </summary>
    /// <param name="deliveryService">Le nom du service de livraison à valider.</param>
    /// <returns><see langword="true"/> si valide, <see langword="false"/> sinon.</returns>
    public static bool ValidateDeliveryService(string deliveryService) {
        return deliveryService.Length <= DELIVERY_SERVICE_MAX_LENGTH;
    }

    /// <summary>
    /// Méthode de validation du code de suivi.
    /// </summary>
    /// <param name="trackingCode">Le code de suivi à valider.</param>
    /// <returns><see langword="true"/> si valide, <see langword="false"/> sinon.</returns>
    public static bool ValidateTrackingCode(string trackingCode) {
        return trackingCode.Length <= TRACKING_CODE_MAX_LENGTH;
    }

    /// <summary>
    /// Override de la méthode <see cref="object.ToString"/> pour affichage des expéditions
    /// dans des ListBox ou ComboBox.
    /// </summary>
    /// <returns>Un string décrivant l'expédition.</returns>
    public override string ToString() {
        return $"#{this.Id} - {this.DeliveryService} ({this.TrackingCode})";
    }

}
