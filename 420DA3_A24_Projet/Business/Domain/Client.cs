using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
namespace _420DA3_A24_Projet.Business.Domain;

/// <summary>
/// Classe représentant un client.
/// </summary>
public class Client {
    /// <summary>
    /// Longueur maximum des champs de texte, en caractères.
    /// </summary>
    public const int NOM_COMPAGNIE_MAX_LENGTH = 128;
    public const int NOM_PERSONNE_MAX_LENGTH = 64;
    public const int PRENOM_PERSONNE_MAX_LENGTH = 64;
    public const int COURRIEL_MAX_LENGTH = 128;
    public const int TELEPHONE_MAX_LENGTH = 20;

    // Backing fields
    private int id;
    private string nomCompagnie = null!;
    private string nomContact = null!;
    private string prenomContact = null!;
    private string courrielContact = null!;
    private string telephoneContact = null!;

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

    public string NomCompagnie {
        get { return this.nomCompagnie; }
        set {
            if (!ValiderNomCompagnie(value)) {
                throw new ArgumentOutOfRangeException("NomCompagnie", $"Le nom de la compagnie doit contenir au maximum {NOM_COMPAGNIE_MAX_LENGTH} caractères.");
            }
            this.nomCompagnie = value;
        }
    }

    public string NomContact {
        get { return this.nomContact; }
        set {
            if (!ValiderNomContact(value)) {
                throw new ArgumentOutOfRangeException("NomContact", $"Le nom de la personne-contact doit contenir au maximum {NOM_PERSONNE_MAX_LENGTH} caractères.");
            }
            this.nomContact = value;
        }
    }

    public string PrenomContact {
        get { return this.prenomContact; }
        set {
            if (!ValiderPrenomContact(value)) {
                throw new ArgumentOutOfRangeException("PrenomContact", $"Le prénom de la personne-contact doit contenir au maximum {PRENOM_PERSONNE_MAX_LENGTH} caractères.");
            }
            this.prenomContact = value;
        }
    }

    public string CourrielContact {
        get { return this.courrielContact; }
        set {
            if (!ValiderCourrielContact(value)) {
                throw new ArgumentOutOfRangeException("CourrielContact", $"Le courriel de la personne-contact doit contenir au maximum {COURRIEL_MAX_LENGTH} caractères.");
            }
            this.courrielContact = value;
        }
    }

    public string TelephoneContact {
        get { return this.telephoneContact; }
        set {
            if (!ValiderTelephoneContact(value)) {
                throw new ArgumentOutOfRangeException("TelephoneContact", $"Le téléphone de la personne-contact doit contenir au maximum {TELEPHONE_MAX_LENGTH} caractères.");
            }
            this.telephoneContact = value;
        }
    }

    public DateTime DateCreation { get; set; }
    public DateTime? DateModification { get; set; }
    public DateTime? DateSuppression { get; set; }

    #endregion

    #region Propriétés de navigation

    /// <summary>
    /// Entrepôt attitré au client.
    /// </summary>
    public virtual Entrepot? EntrepotAttitre { get; set; }

    #endregion

    #region Constructeurs

    /// <summary>
    /// Constructeur principal.
    /// </summary>
    /// <param name="nomCompagnie">Nom de la compagnie.</param>
    /// <param name="nomContact">Nom de la personne-contact.</param>
    /// <param name="prenomContact">Prénom de la personne-contact.</param>
    /// <param name="courrielContact">Courriel de la personne-contact.</param>
    /// <param name="telephoneContact">Téléphone de la personne-contact.</param>
    public Client(string nomCompagnie, string nomContact, string prenomContact, string courrielContact, string telephoneContact) {
        this.NomCompagnie = nomCompagnie;
        this.NomContact = nomContact;
        this.PrenomContact = prenomContact;
        this.CourrielContact = courrielContact;
        this.TelephoneContact = telephoneContact;
        this.DateCreation = DateTime.Now;
    }

    /// <summary>
    /// Constructeur orienté Entity Framework.
    /// </summary>
    protected Client(int id, string nomCompagnie, string nomContact, string prenomContact, string courrielContact, string telephoneContact, DateTime dateCreation, DateTime? dateModification, DateTime? dateSuppression)
        : this(nomCompagnie, nomContact, prenomContact, courrielContact, telephoneContact) {
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

    public static bool ValiderNomCompagnie(string nomCompagnie) {
        return nomCompagnie.Length <= NOM_COMPAGNIE_MAX_LENGTH;
    }

    public static bool ValiderNomContact(string nomContact) {
        return nomContact.Length <= NOM_PERSONNE_MAX_LENGTH;
    }

    public static bool ValiderPrenomContact(string prenomContact) {
        return prenomContact.Length <= PRENOM_PERSONNE_MAX_LENGTH;
    }

    public static bool ValiderCourrielContact(string courrielContact) {
        return courrielContact.Length <= COURRIEL_MAX_LENGTH;
    }

    public static bool ValiderTelephoneContact(string telephoneContact) {
        return telephoneContact.Length <= TELEPHONE_MAX_LENGTH;
    }

    #endregion
}
