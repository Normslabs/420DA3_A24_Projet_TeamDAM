using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain;

/// <summary>
/// Classe représentant une adresse associée à un client ou à un entrepôt.
/// </summary>
public class Adresse {
    /// <summary>
    /// Longueur maximum des champs de texte, en caractères.
    /// </summary>
    public const int TYPE_MAX_LENGTH = 32;
    public const int DESTINATAIRE_MAX_LENGTH = 128;
    public const int NUMERO_CIVIQUE_MAX_LENGTH = 16;
    public const int RUE_MAX_LENGTH = 128;
    public const int VILLE_MAX_LENGTH = 64;
    public const int PROVINCE_MAX_LENGTH = 64;
    public const int PAYS_MAX_LENGTH = 64;
    public const int CODE_POSTAL_MAX_LENGTH = 16;

    // Backing fields
    private int id;
    private string typeAdresse = null!;
    private string destinataire = null!;
    private string numeroCivique = null!;
    private string rue = null!;

    #region Propriétés de données

    public int Id {
        get { return this.id; }
        set {
            if (!ValiderId(value)) {
                throw new ArgumentOutOfRangeException("Id", "L'Id doit être supérieur ou égal à 0.");
            }
            this.id = value;
        }
    }

    public string TypeAdresse {
        get { return this.typeAdresse; }
        set {
            if (!ValiderTypeAdresse(value)) {
                throw new ArgumentOutOfRangeException("TypeAdresse", $"Le type d'adresse doit contenir au maximum {TYPE_MAX_LENGTH} caractères.");
            }
            this.typeAdresse = value;
        }
    }

    public string Destinataire {
        get { return this.destinataire; }
        set {
            if (!ValiderDestinataire(value)) {
                throw new ArgumentOutOfRangeException("Destinataire", $"Le destinataire doit contenir au maximum {DESTINATAIRE_MAX_LENGTH} caractères.");
            }
            this.destinataire = value;
        }
    }

    public string NumeroCivique {
        get { return this.numeroCivique; }
        set {
            if (!ValiderNumeroCivique(value)) {
                throw new ArgumentOutOfRangeException("NumeroCivique", $"Le numéro civique doit contenir au maximum {NUMERO_CIVIQUE_MAX_LENGTH} caractères.");
            }
            this.numeroCivique = value;
        }
    }

    public string Rue {
        get { return this.rue; }
        set {
            if (!ValiderRue(value)) {
                throw new ArgumentOutOfRangeException("Rue", $"La rue doit contenir au maximum {RUE_MAX_LENGTH} caractères.");
            }
            this.rue = value;
        }
    }

    public string Ville { get; set; } = null!;
    public string Province { get; set; } = null!;
    public string Pays { get; set; } = null!;
    public string CodePostal { get; set; } = null!;
    public DateTime DateCreation { get; set; }
    public DateTime? DateModification { get; set; }
    public DateTime? DateSuppression { get; set; }

    #endregion

    #region Propriétés de navigation

    /// <summary>
    /// Client ou entrepôt associé à l'adresse.
    /// </summary>
    public virtual Client? Client { get; set; }

    #endregion

    #region Constructeurs

    /// <summary>
    /// Constructeur principal.
    /// </summary>
    /// <param name="typeAdresse">Le type d'adresse (entrepôt ou destinataire).</param>
    /// <param name="destinataire">Le nom du destinataire ou du bâtiment.</param>
    /// <param name="numeroCivique">Le numéro civique.</param>
    /// <param name="rue">Le nom de la rue.</param>
    /// <param name="ville">La ville.</param>
    /// <param name="province">La province.</param>
    /// <param name="pays">Le pays.</param>
    /// <param name="codePostal">Le code postal.</param>
    public Adresse(string typeAdresse, string destinataire, string numeroCivique, string rue, string ville, string province, string pays, string codePostal) {
        this.TypeAdresse = typeAdresse;
        this.Destinataire = destinataire;
        this.NumeroCivique = numeroCivique;
        this.Rue = rue;
        this.Ville = ville;
        this.Province = province;
        this.Pays = pays;
        this.CodePostal = codePostal;
        this.DateCreation = DateTime.Now;
    }

    /// <summary>
    /// Constructeur orienté Entity Framework.
    /// </summary>
    protected Adresse(int id, string typeAdresse, string destinataire, string numeroCivique, string rue, string ville, string province, string pays, string codePostal, DateTime dateCreation, DateTime? dateModification, DateTime? dateSuppression)
        : this(typeAdresse, destinataire, numeroCivique, rue, ville, province, pays, codePostal) {
        this.Id = id;
        this.DateCreation = dateCreation;
        this.DateModification = dateModification;
        this.DateSuppression = dateSuppression;
    }

    #endregion

    #region Méthodes

    public static bool ValiderId(int id) {
        return id >= 0;
    }

    public static bool ValiderTypeAdresse(string typeAdresse) {
        return typeAdresse.Length <= TYPE_MAX_LENGTH;
    }

    public static bool ValiderDestinataire(string destinataire) {
        return destinataire.Length <= DESTINATAIRE_MAX_LENGTH;
    }

    public static bool ValiderNumeroCivique(string numeroCivique) {
        return numeroCivique.Length <= NUMERO_CIVIQUE_MAX_LENGTH;
    }

    public static bool ValiderRue(string rue) {
        return rue.Length <= RUE_MAX_LENGTH;
    }

    #endregion
}

