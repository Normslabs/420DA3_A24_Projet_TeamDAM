﻿using _420DA3_A24_Exemple_Enseignant.Business.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace _420DA3_A24_Exemple_Enseignant.DataAccess.Contexts;
internal class ExempleDbContext : DbContext {

    public DbSet<Medecin> Medecins { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<RendezVous> RendezVous { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        base.OnConfiguring(optionsBuilder);

        _ = optionsBuilder
            .UseLazyLoadingProxies()
            .UseSqlServer("Server=.\\SQL2022DEV;Database=420da3_projet_exemple_enseignant;Integrated Security=true;TrustServerCertificate=true;");
    }



    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);

        // CONFIGURATIONS DU MODÈLE DE DONNÉES ENTITY FRAMEWORK

        // Convertisseur de DateTime temps local -> UTC et UTC -> temps local
        // Permet de trvailler avec des temps UTC dans la BdD et de les convertir en temps local
        // pour l'application.
        ValueConverter<DateTime, DateTime> dateTimeUtcConverter = new ValueConverter<DateTime, DateTime>(
            dt => dt.ToUniversalTime(), 
            dt => DateTime.SpecifyKind(dt, DateTimeKind.Utc).ToLocalTime());


        #region CONFIGURATION DE LA LIAISON ENTITÉ Medecin À TABLE 'Medecins'

        // CONFIGURATION DE LA TABLE 'Medecins' ET DE SA CLÉ PRIMAIRE
        _ = modelBuilder.Entity<Medecin>()      // L'entité Medecin
            .ToTable("Medecins")                // Est liée à une table nommée 'Medecins'
            .HasKey(medecin => medecin.Id);     // Dont la clé primaire est la popriété 'Id' de l'entité

        // CONFIGURATION DES COLONNES DE LA TABLE 'Medecins'
        _ = modelBuilder.Entity<Medecin>()      // L'entité Medecin
            .Property(medecin => medecin.Id)    // A sa propriété 'Id'
            .HasColumnName("Id")                // Liée à une colonne nommée 'Id' dans la table
            .HasColumnOrder(0)                  // Qui est la première colonne (index 0) dans la table
            .HasColumnType("int");              // Et dont le type est INT
            // NOTE: la colonne de clé primaire est toujours NOT NULL

        _ = modelBuilder.Entity<Medecin>()
            .Property(medecin => medecin.Nom)
            .HasColumnName("Nom")
            .HasColumnOrder(1)
            .HasColumnType($"nvarchar({Medecin.LASTNAME_MAX_LENGTH})") // type: NVARCHAR(<taille spécifiée dans la constante>)
            .IsRequired(true); // colonne NOT NULL

        _ = modelBuilder.Entity<Medecin>()
            .Property(medecin => medecin.Prenom)
            .HasColumnName("Prenom")
            .HasColumnOrder(2)
            .HasColumnType($"nvarchar({Medecin.FIRSTNAME_MAX_LENGTH})")
            .IsRequired(true);

        _ = modelBuilder.Entity<Medecin>()
            .Property(medecin => medecin.NumLicenseMedicale)
            .HasColumnName("NumLicenseMedicale")
            .HasColumnOrder(3)
            .HasColumnType($"nvarchar({Medecin.LICENSE_MAX_LENGTH})")
            .IsRequired(true);

        _ = modelBuilder.Entity<Medecin>()
            .Property(medecin => medecin.DateCreated)
            .HasColumnName("DateCreated")
            .HasColumnOrder(4)
            .HasColumnType("datetime2(6)") // type: DATETIME2(6)
            .HasPrecision(6) // précision de la colonne: 6 (datetime2 -> précision à la microseconde)
            .HasDefaultValueSql("GETUTCDATE()") // valeur par défaut (insertion) = le moment de l'insertion
            .HasConversion(dateTimeUtcConverter)
            .IsRequired(true);

        _ = modelBuilder.Entity<Medecin>()
            .Property(medecin => medecin.DateModified)
            .HasColumnName("DateModified")
            .HasColumnOrder(5)
            .HasColumnType("datetime2(6)")
            .HasPrecision(6)
            .HasConversion(dateTimeUtcConverter)
            .IsRequired(false); // colonne acceptant les valeurs NULL

        _ = modelBuilder.Entity<Medecin>()
            .Property(medecin => medecin.DateDeleted)
            .HasColumnName("DateDeleted")
            .HasColumnOrder(6)
            .HasColumnType("datetime2(6)")
            .HasPrecision(6)
            .HasConversion(dateTimeUtcConverter)
            .IsRequired(false);

        _ = modelBuilder.Entity<Medecin>()
            .Property(medecin => medecin.RowVersion)
            .HasColumnName("RowVersion")
            .IsRowVersion(); // colonne spéciale de protection contre les modifications concurrentes


        #endregion


        #region CONFIGURATION DE LA LIAISON ENTITÉ Patient À TABLE 'Patients'

        // CONFIGURATION DE LA TABLE 'Patiens' ET DE SA CLÉ PRIMAIRE
        _ = modelBuilder.Entity<Patient>()      // L'entité Patient
            .ToTable("Patients")                // Est liée à une table nommée 'Patients'
            .HasKey(patient => patient.Id);     // Dont la clé primaire est la popriété 'Id' de l'entité

        // CONFIGURATION DES COLONNES DE LA TABLE 'Patients'
        _ = modelBuilder.Entity<Patient>()      // L'entité Patient
            .Property(patient => patient.Id)    // A sa propriété 'Id'
            .HasColumnName("Id")                // Liée à une colonne nommée 'Id' dans la table
            .HasColumnOrder(0)                  // Qui est la première colonne (index 0) dans la table
            .HasColumnType("int");              // Et dont le type est INT
            // NOTE: la colonne de clé primaire est toujours NOT NULL

        _ = modelBuilder.Entity<Patient>()
            .Property(patient => patient.Nom)
            .HasColumnName("Nom")
            .HasColumnOrder(1)
            .HasColumnType($"nvarchar({Patient.LASTNAME_MAX_LENGTH})")
            .IsRequired(true);

        _ = modelBuilder.Entity<Patient>()
            .Property(patient => patient.Prenom)
            .HasColumnName("Prenom")
            .HasColumnOrder(2)
            .HasColumnType($"nvarchar({Patient.FIRSTNAME_MAX_LENGTH})")
            .IsRequired(true);

        _ = modelBuilder.Entity<Patient>()
            .Property(patient => patient.NumAssMaladie)
            .HasColumnName("NumAssMaladie")
            .HasColumnOrder(3)
            .HasColumnType($"nvarchar({Patient.ASSNUMBER_MAX_LENGTH})")
            .IsRequired(true);

        _ = modelBuilder.Entity<Patient>()
            .Property(patient => patient.DateCreated)
            .HasColumnName("DateCreated")
            .HasColumnOrder(4)
            .HasColumnType("datetime2(6)")
            .HasPrecision(6)
            .HasDefaultValueSql("GETUTCDATE()")
            .HasConversion(dateTimeUtcConverter)
            .IsRequired(true);

        _ = modelBuilder.Entity<Patient>()
            .Property(patient => patient.DateModified)
            .HasColumnName("DateModified")
            .HasColumnOrder(5)
            .HasColumnType("datetime2(6)")
            .HasPrecision(6)
            .HasConversion(dateTimeUtcConverter)
            .IsRequired(false);

        _ = modelBuilder.Entity<Patient>()
            .Property(patient => patient.DateDeleted)
            .HasColumnName("DateDeleted")
            .HasColumnOrder(6)
            .HasColumnType("datetime2(6)")
            .HasPrecision(6)
            .HasConversion(dateTimeUtcConverter)
            .IsRequired(false);

        _ = modelBuilder.Entity<Patient>()
            .Property(patient => patient.RowVersion)
            .HasColumnName("RowVersion")
            .IsRowVersion();


        #endregion


        #region CONFIGURATION DE LA LIAISON ENTITÉ RendezVous À TABLE 'RendezVous'
        // CONFIGURATION DE LA TABLE 'Medecins' ET DE SA CLÉ PRIMAIRE
        _ = modelBuilder.Entity<RendezVous>()   // L'entité RendezVous
            .ToTable("RendezVous")              // Est liée à une table nommée 'RendezVous'
            .HasKey(rdv => rdv.Id);             // Dont la clé primaire est la popriété 'Id' de l'entité

        // CONFIGURATION DES COLONNES DE LA TABLE 'Medecins'
        _ = modelBuilder.Entity<RendezVous>()   // L'entité RendezVous
            .Property(rdv => rdv.Id)            // A sa propriété 'Id'
            .HasColumnName("Id")                // Liée à une colonne nommée 'Id' dans la table
            .HasColumnOrder(0)                  // Qui est la première colonne (index 0) dans la table
            .HasColumnType("int");              // Et dont le type est INT
            // NOTE: la colonne de clé primaire est toujours NOT NULL

        _ = modelBuilder.Entity<RendezVous>()
            .Property(rdv => rdv.DateRendezVous)
            .HasColumnName("DateRendezVous")
            .HasColumnOrder(1)
            .HasColumnType($"datetime2(6)")
            .HasPrecision(6)
            .HasConversion(dateTimeUtcConverter)
            .IsRequired(true);

        _ = modelBuilder.Entity<RendezVous>()
            .Property(rdv => rdv.PatientId)
            .HasColumnName("PatientId")
            .HasColumnOrder(2)
            .HasColumnType("int")
            .IsRequired(true);

        _ = modelBuilder.Entity<RendezVous>()
            .Property(rdv => rdv.MedecinId)
            .HasColumnName("MedecinId")
            .HasColumnOrder(3)
            .HasColumnType("int")
            .IsRequired(true);

        _ = modelBuilder.Entity<RendezVous>()
            .Property(rdv => rdv.DateCreated)
            .HasColumnName("DateCreated")
            .HasColumnOrder(4)
            .HasColumnType("datetime2(6)")
            .HasPrecision(6)
            .HasDefaultValueSql("GETUTCDATE()")
            .HasConversion(dateTimeUtcConverter)
            .IsRequired(true);

        _ = modelBuilder.Entity<RendezVous>()
            .Property(rdv => rdv.DateModified)
            .HasColumnName("DateModified")
            .HasColumnOrder(5)
            .HasColumnType("datetime2(6)")
            .HasPrecision(6)
            .HasConversion(dateTimeUtcConverter)
            .IsRequired(false);

        _ = modelBuilder.Entity<RendezVous>()
            .Property(rdv => rdv.DateDeleted)
            .HasColumnName("DateDeleted")
            .HasColumnOrder(6)
            .HasColumnType("datetime2(6)")
            .HasPrecision(6)
            .HasConversion(dateTimeUtcConverter)
            .IsRequired(false);

        #endregion

    }
}
