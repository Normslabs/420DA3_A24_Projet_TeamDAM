namespace _420DA3_A24_Projet.Business.Domain;


public class Supplier {

    public const int NAME_MAX_LENGTH = 128;

    public const int CONTACT_FIRST_NAME_MAX_LENGTH = 32;
    public const int CONTACT_LAST_NAME_MAX_LENGTH = 32;
    public const int CONTACT_TELEPHONE_MAX_LENGTH = 128;
    public const int CONTACT_EMAIL_MAX_LENGTH = 15;



    private int id;
    private string name = null!;
    private string contactFirstName = null!;
    private string contactLastName = null!;
    private string contactEmail = null!;
    private string contactPhone = null!;

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

    public string Name {
        get { return this.name; }
        set {
            if (string.IsNullOrWhiteSpace(value) || value.Length > NAME_MAX_LENGTH) {
                throw new ArgumentOutOfRangeException("Name", $"Name length must be lower than or equal to {NAME_MAX_LENGTH} characters.");
            }
            this.name = value;
        }
    }

    public string ContactFirstName {
        get { return this.contactFirstName; }
        set {
            if (string.IsNullOrWhiteSpace(value) || value.Length > CONTACT_FIRST_NAME_MAX_LENGTH) {
                throw new ArgumentOutOfRangeException("ContactFirstName", $"ContactFirstName length must be lower than or equal to {CONTACT_FIRST_NAME_MAX_LENGTH} characters.");
            }
            this.contactFirstName = value;
        }
    }

    public string ContactLastName {
        get { return this.contactLastName; }
        set {
            if (string.IsNullOrWhiteSpace(value) || value.Length > CONTACT_LAST_NAME_MAX_LENGTH) {
                throw new ArgumentOutOfRangeException("ContactLastName", $"ContactLastName length must be lower than or equal to {CONTACT_LAST_NAME_MAX_LENGTH} characters.");
            }
            this.contactLastName = value;
        }
    }

    public string ContactEmail {
        get { return this.contactEmail; }
        set {
            if (string.IsNullOrWhiteSpace(value) || value.Length > CONTACT_EMAIL_MAX_LENGTH) {
                throw new ArgumentOutOfRangeException("ContactEmail", $"ContactEmail length must be lower than or equal to {CONTACT_EMAIL_MAX_LENGTH} characters.");
            }
            this.contactEmail = value;
        }
    }

    public string ContactPhone {
        get { return this.contactPhone; }
        set {
            if (string.IsNullOrWhiteSpace(value) || value.Length > CONTACT_TELEPHONE_MAX_LENGTH) {
                throw new ArgumentOutOfRangeException("ContactPhone", $"ContactPhone length must be lower than or equal to {CONTACT_TELEPHONE_MAX_LENGTH} characters.");
            }
            this.contactPhone = value;
        }
    }

    public DateTime DateCreated { get; set; }
    public DateTime? DateModified { get; set; }
    public DateTime? DateDeleted { get; set; }
    public byte[] RowVersion { get; set; } = null!;

    #endregion

    #region Constructeurs


    /// <param name="name"
    /// <param name="contactFirstName"
    /// <param name="contactLastName"
    /// <param name="contactEmail"
    /// <param name="contactPhone"
    public Supplier(string name, string contactFirstName, string contactLastName, string contactEmail, string contactPhone) {
        this.Name = name;
        this.ContactFirstName = contactFirstName;
        this.ContactLastName = contactLastName;
        this.ContactEmail = contactEmail;
        this.ContactPhone = contactPhone;
    }


    protected Supplier(int id, string name, string contactFirstName, string contactLastName, string contactEmail, string contactPhone, DateTime dateCreated, DateTime? dateModified, DateTime? dateDeleted, byte[] rowVersion)
        : this(name, contactFirstName, contactLastName, contactEmail, contactPhone) {

        this.Id = id;
        this.DateCreated = dateCreated;
        this.DateModified = dateModified;
        this.DateDeleted = dateDeleted;
        this.RowVersion = rowVersion;
    }

    #endregion

    #region Méthodes
    /// <summary>
    /// Méthode de validation d'ID
    /// </summary>
    /// <param name="id">Le numéro d'ID à valider</param>
    /// <returns><see langword="true"/> si valide, <see langword="false"/> sinon.</returns>
    public static bool ValidateId(int id) {
        return id >= 0;
    }

    /// <summary>
    /// Méthode de validation d'ID
    /// </summary>
    /// <param name="name">Le numéro d'ID à valider</param>
    /// <returns><see langword="true"/> si valide, <see langword="false"/> sinon.</returns>
    public static bool ValidateSupplierName(string name) {
        return name.Length <= NAME_MAX_LENGTH && name.Length <= NAME_MAX_LENGTH;
    }
    /// <summary>
    /// Méthode de validation d'ID
    /// </summary>
    /// <param name="firstName">Le numéro d'ID à valider</param>
    /// <returns><see langword="true"/> si valide, <see langword="false"/> sinon.</returns>
    public static bool ValidateContactFirstName(string firstName) {
        return firstName.Length <= CONTACT_FIRST_NAME_MAX_LENGTH && firstName.Length >= CONTACT_FIRST_NAME_MAX_LENGTH;
    }/// <summary>
     /// Méthode de validation d'ID
     /// </summary>
     /// <param name="lastName">Le numéro d'ID à valider</param>
     /// <returns><see langword="true"/> si valide, <see langword="false"/> sinon.</returns>
    public static bool ValidateContactLastName(string lastName) {
        return lastName.Length <= CONTACT_LAST_NAME_MAX_LENGTH && lastName.Length >= CONTACT_LAST_NAME_MAX_LENGTH;
    }

    /// <summary>
    /// Méthode de validation d'ID
    /// </summary>
    /// <param name="email">Le numéro d'ID à valider</param>
    /// <returns><see langword="true"/> si valide, <see langword="false"/> sinon.</returns>
    public static bool ValidateContactEmail(string email) {
        return email.Length <= CONTACT_EMAIL_MAX_LENGTH && email.Length <= CONTACT_EMAIL_MAX_LENGTH;
    }

    /// Override de <see cref="object.ToString"/> pour l'affichage dans des ListBox ou ComboBox.
    /// </summary>
    public override string ToString() {
        return $"{this.Name} - Contact: {this.ContactFirstName} {this.ContactLastName}, Email: {this.ContactEmail}, Phone: {this.ContactPhone}";
    }

    #endregion
}
