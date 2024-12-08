﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;

namespace _420DA3_A24_Projet.Business.Domain;

/// <summary>
/// Classe représentant un entrepôt
/// </summary>
public class Entrepot {
    // Attributs de la classe Entrepot
    public int Id { get; set; }


    // Validation du nom avec des annotations de données
    [Required(ErrorMessage = "Le nom est requis.")]
    [StringLength(100, ErrorMessage = "Le nom ne doit pas dépasser 100 caractères.")]
    public string Nom { get; set; }

    // Clé étrangère pour l'adresse de l'entrepôt
    [Required]
    public int AdresseId { get; set; }


    // Dates de gestion (création, modification, suppression)
    public DateTime DateCreation { get; set; } = DateTime.Now;
    public DateTime? DateModification { get; set; }
    public DateTime? DateSuppression { get; set; }
    public byte[] RowVersion { get; set; } = null;

    // Propriété de navigation pour l'adresse (avec modificateur 'virtual')
    public virtual Adresse Adresse { get; set; }


    public virtual List<Client> Clients { get; set; } = new List<Client>();
    public virtual List<OrdreRestockage> OrdreRestockage { get; set; } = new List<OrdreRestockage>();
    public virtual List<User> EmployesEntrepot { get; set; } = new List<User>();
    public object Capacite { get; internal set; }


    // Constructeur par défaut
    public Entrepot() {
        // La DateCreation doit être définie par la base de données via GETDATE()
    }

    // Constructeur avec des paramètres pour toutes les propriétés de données
    public Entrepot(int id, string nom, int adresseId, DateTime? dateModification = null, DateTime? dateSuppression = null, byte[]? rowVersion = null) {
        Id = id;
        Nom = nom;
        AdresseId = adresseId;
        DateModification = dateModification;
        DateSuppression = dateSuppression;
        RowVersion = rowVersion ?? Array.Empty<byte>();
       
    }
}


