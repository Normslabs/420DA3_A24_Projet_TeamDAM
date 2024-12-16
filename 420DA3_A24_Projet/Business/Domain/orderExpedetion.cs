using System;
using System.Collections.Generic;

namespace _420DA3_A24_Projet.Business.Domain {
    /// <summary>
    /// Représente un ordre d'expédition.
    /// </summary>
    public class OrdreExpedition {
        public int Id { get; set; }
        public string Statut { get; set; } = "new"; // Statut initial par défaut
        public int ClientId { get; set; } // Référence au client
        public Client Client { get; set; } = null!; // Propriété de navigation pour le client
        public int CreateurId { get; set; } // Référence à l'utilisateur qui a créé l'ordre
        public Utilisateur Createur { get; set; } = null!; // Propriété de navigation pour l'utilisateur créateur
        public List<LienProduitOrdre> LiensProduits { get; set; } = new(); // Liens produits-ordre avec quantités
        public Adresse Adresse { get; set; } = null!; // Adresse de destination
        public int? EmployeEntrepotId { get; set; } // Employé d'entrepôt assigné (nullable)
        public EmployeEntrepot? EmployeEntrepot { get; set; } // Propriété de navigation pour l'employé assigné
        public int? ExpeditionId { get; set; } // Référence à l'expédition (nullable)
        public Expedition? Expedition { get; set; } // Propriété de navigation pour l'expédition
        public DateTime? DateExpedition { get; set; } // Date d'expédition (nullable)
        public DateTime DateCreation { get; set; } = DateTime.Now; // Date de création automatique
        public DateTime DateModification { get; set; } = DateTime.Now; // Date de modification automatique
        public DateTime? DateSuppression { get; set; } // Date de suppression (nullable)

        /// <summary>
        /// Met à jour la date de modification lors d'une modification de l'entité.
        /// </summary>
        public void UpdateDateModification() {
            DateModification = DateTime.Now;
        }
    }

    /// <summary>
    /// Lien pivot entre un produit et un ordre d'expédition.
    /// </summary>
    public class LienProduitOrdre {
        public int OrdreExpeditionId { get; set; } // Référence à l'ordre d'expédition
        public OrdreExpedition OrdreExpedition { get; set; } = null!;
        public int ProduitId { get; set; } // Référence au produit
        public Produit Produit { get; set; } = null!;
        public int Quantite { get; set; } // Quantité de produit dans l'ordre
    }
}
