using _420DA3_A24_Projet.Business.Domain;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace _420DA3_A24_Projet.DataAccess.Contexts;
internal class WsysDbContext : DbContext {

    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Adresse> Adresses { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
    public DbSet<Product> Produits { get; set; }
    public DbSet<Warehouse> Entrepots { get; set; }
    

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        base.OnConfiguring(optionsBuilder);

        string connString = ConfigurationManager.ConnectionStrings["ProjectDatabase"].ConnectionString;

        _ = optionsBuilder
            .UseSqlServer(connString)
            .UseLazyLoadingProxies();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);


        #region USER

        _ = modelBuilder.Entity<User>()
            .ToTable(nameof(this.Users))
            .HasKey(user => user.Id);

        _ = modelBuilder.Entity<User>()
            .HasIndex(user => user.Username)
            .IsUnique(true);

        _ = modelBuilder.Entity<User>()
            .Property(user => user.Id)
            .HasColumnName("Id")
            .HasColumnOrder(0)
            .HasColumnType("int")
            .UseIdentityColumn(1, 1);

        _ = modelBuilder.Entity<User>()
            .Property(user => user.Username)
            .HasColumnName("Username")
            .HasColumnOrder(1)
            .HasColumnType($"nvarchar({User.USERNAME_MAX_LENGTH})")
            .HasMaxLength(User.USERNAME_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<User>()
            .Property(user => user.PasswordHash)
            .HasColumnName("PasswordHash")
            .HasColumnOrder(2)
            .HasColumnType($"nvarchar({User.PASSWORDHASH_MAX_LENGTH})")
            .HasMaxLength(User.PASSWORDHASH_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<User>()
            .Property(user => user.EmployeeWarehouseId)
            .HasColumnName("EmployeeWarehouseId")
            .HasColumnOrder(3)
            .HasColumnType("int")
            .IsRequired(false);

        _ = modelBuilder.Entity<User>()
            .Property(user => user.DateCreated)
            .HasColumnName("DateCreated")
            .HasColumnOrder(4)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .HasDefaultValueSql("GETDATE()")
            .IsRequired(true);

        _ = modelBuilder.Entity<User>()
            .Property(user => user.DateModified)
            .HasColumnName("DateModified")
            .HasColumnOrder(5)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<User>()
            .Property(user => user.DateDeleted)
            .HasColumnName("DateDeleted")
            .HasColumnOrder(6)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<User>()
            .Property(user => user.RowVersion)
            .HasColumnName("RowVersion")
            .HasColumnOrder(7)
            .IsRowVersion();


        // TODO @PROF Faire config User-Warehouse 

        #endregion

        #region ROLE

        // TODO: @PROF Faire config Role
        _ = modelBuilder.Entity<Role>()
            .ToTable(nameof(this.Roles))
            .HasKey(role => role.Id);

        _ = modelBuilder.Entity<Role>()
            .HasIndex(role => role.Name)
            .IsUnique(true);

        _ = modelBuilder.Entity<Role>()
            .Property(role => role.Id)
            .HasColumnName("Id")
            .HasColumnOrder(0)
            .HasColumnType("int")
            .UseIdentityColumn(1, 1);

        _ = modelBuilder.Entity<Role>()
            .Property(role => role.Name)
            .HasColumnName("Name")
            .HasColumnOrder(1)
            .HasColumnType($"nvarchar({Role.NAME_MAX_LENGTH})")
            .HasMaxLength(Role.NAME_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<Role>()
            .Property(role => role.Description)
            .HasColumnName("Description")
            .HasColumnOrder(2)
            .HasColumnType($"nvarchar({Role.DESCRIPTION_MAX_LENGTH})")
            .HasMaxLength(Role.DESCRIPTION_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<Role>()
            .Property(role => role.DateCreated)
            .HasColumnName("DateCreated")
            .HasColumnOrder(3)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .HasDefaultValueSql("GETDATE()")
            .IsRequired(true);

        _ = modelBuilder.Entity<Role>()
            .Property(role => role.DateModified)
            .HasColumnName("DateModified")
            .HasColumnOrder(4)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<Role>()
            .Property(role => role.DateDeleted)
            .HasColumnName("DateDeleted")
            .HasColumnOrder(5)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<Role>()
            .Property(role => role.RowVersion)
            .HasColumnName("RowVersion")
            .HasColumnOrder(6)
            .IsRowVersion();


        #endregion

        #region CLIENT

        _ = modelBuilder.Entity<Client>()
            .ToTable(nameof(this.Clients))
            .HasKey(client => client.Id);

        _ = modelBuilder.Entity<Client>()
            .Property(client => client.Id)
            .HasColumnName("Id")
            .HasColumnOrder(0)
            .HasColumnType("int")
            .UseIdentityColumn(1, 1);

        _ = modelBuilder.Entity<Client>()
            .Property(client => client.NomCompagnie)
            .HasColumnName("NomCompagnie")
            .HasColumnOrder(1)
            .HasColumnType($"nvarchar({Client.NOM_COMPAGNIE_MAX_LENGTH})")
            .HasMaxLength(Client.NOM_COMPAGNIE_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<Client>()
            .Property(client => client.NomContact)
            .HasColumnName("NomContact")
            .HasColumnOrder(2)
            .HasColumnType($"nvarchar({Client.NOM_PERSONNE_MAX_LENGTH})")
            .HasMaxLength(Client.NOM_PERSONNE_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<Client>()
            .Property(client => client.PrenomContact)
            .HasColumnName("PrenomContact")
            .HasColumnOrder(3)
            .HasColumnType($"nvarchar({Client.PRENOM_PERSONNE_MAX_LENGTH})")
            .HasMaxLength(Client.PRENOM_PERSONNE_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<Client>()
            .Property(client => client.CourrielContact)
            .HasColumnName("CourrielContact")
            .HasColumnOrder(4)
            .HasColumnType($"nvarchar({Client.COURRIEL_MAX_LENGTH})")
            .HasMaxLength(Client.COURRIEL_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<Client>()
            .Property(client => client.TelephoneContact)
            .HasColumnName("TelephoneContact")
            .HasColumnOrder(5)
            .HasColumnType($"nvarchar({Client.TELEPHONE_MAX_LENGTH})")
            .HasMaxLength(Client.TELEPHONE_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<Client>()
            .Property(client => client.DateCreation)
            .HasColumnName("DateCreation")
            .HasColumnOrder(6)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .HasDefaultValueSql("GETDATE()")
            .IsRequired(true);

        _ = modelBuilder.Entity<Client>()
            .Property(client => client.DateModification)
            .HasColumnName("DateModification")
            .HasColumnOrder(7)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<Client>()
            .Property(client => client.DateSuppression)
            .HasColumnName("DateSuppression")
            .HasColumnOrder(8)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        #endregion

        #region ADRESSE

        _ = modelBuilder.Entity<Adresse>()
            .ToTable(nameof(this.Adresses))
            .HasKey(adresse => adresse.Id);

        _ = modelBuilder.Entity<Adresse>()
            .Property(adresse => adresse.Id)
            .HasColumnName("Id")
            .HasColumnOrder(0)
            .HasColumnType("int")
            .UseIdentityColumn(1, 1);

        _ = modelBuilder.Entity<Adresse>()
            .Property(adresse => adresse.TypeAdresse)
            .HasColumnName("TypeAdresse")
            .HasColumnOrder(1)
            .HasColumnType("nvarchar(20)")
            .IsRequired(true);

        _ = modelBuilder.Entity<Adresse>()
            .Property(adresse => adresse.Destinataire)
            .HasColumnName("Destinataire")
            .HasColumnOrder(2)
            .HasColumnType($"nvarchar({Adresse.DESTINATAIRE_MAX_LENGTH})")
            .HasMaxLength(Adresse.DESTINATAIRE_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<Adresse>()
            .Property(adresse => adresse.NumeroCivique)
            .HasColumnName("NumeroCivique")
            .HasColumnOrder(3)
            .HasColumnType("nvarchar(20)")
            .IsRequired(true);

        _ = modelBuilder.Entity<Adresse>()
            .Property(adresse => adresse.Rue)
            .HasColumnName("Rue")
            .HasColumnOrder(4)
            .HasColumnType($"nvarchar({Adresse.RUE_MAX_LENGTH})")
            .HasMaxLength(Adresse.RUE_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<Adresse>()
            .Property(adresse => adresse.Ville)
            .HasColumnName("Ville")
            .HasColumnOrder(5)
            .HasColumnType($"nvarchar({Adresse.VILLE_MAX_LENGTH})")
            .HasMaxLength(Adresse.VILLE_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<Adresse>()
            .Property(adresse => adresse.Province)
            .HasColumnName("Province")
            .HasColumnOrder(6)
            .HasColumnType($"nvarchar({Adresse.PROVINCE_MAX_LENGTH})")
            .HasMaxLength(Adresse.PROVINCE_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<Adresse>()
            .Property(adresse => adresse.Pays)
            .HasColumnName("Pays")
            .HasColumnOrder(7)
            .HasColumnType($"nvarchar({Adresse.PAYS_MAX_LENGTH})")
            .HasMaxLength(Adresse.PAYS_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<Adresse>()
            .Property(adresse => adresse.CodePostal)
            .HasColumnName("CodePostal")
            .HasColumnOrder(8)
            .HasColumnType("nvarchar(10)")
            .IsRequired(true);

        _ = modelBuilder.Entity<Adresse>()
            .Property(adresse => adresse.DateCreation)
            .HasColumnName("DateCreation")
            .HasColumnOrder(9)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .HasDefaultValueSql("GETDATE()")
            .IsRequired(true);

        _ = modelBuilder.Entity<Adresse>()
            .Property(adresse => adresse.DateModification)
            .HasColumnName("DateModification")
            .HasColumnOrder(10)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<Adresse>()
            .Property(adresse => adresse.DateSuppression)
            .HasColumnName("DateSuppression")
            .HasColumnOrder(11)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        #endregion

        #region SUPPLIER

        _ = modelBuilder.Entity<Supplier>()
            .ToTable(nameof(this.Suppliers)) // Nom de la table
            .HasKey(supplier => supplier.Id); // Clé primaire

        _ = modelBuilder.Entity<Supplier>()
            .HasIndex(supplier => supplier.Name) // Index unique sur le nom
            .IsUnique();

        _ = modelBuilder.Entity<Supplier>()
            .Property(supplier => supplier.Id)
            .HasColumnName("Id")
            .HasColumnOrder(0)
            .HasColumnType("int")
            .UseIdentityColumn(1, 1);

        _ = modelBuilder.Entity<Supplier>()
            .Property(supplier => supplier.Name)
            .HasColumnName("Name")
            .HasColumnOrder(1)
            .HasColumnType($"nvarchar({Supplier.NAME_MAX_LENGTH})")
            .HasMaxLength(Supplier.NAME_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<Supplier>()
            .Property(supplier => supplier.ContactFirstName)
            .HasColumnName("ContactFirstName")
            .HasColumnOrder(2)
            .HasColumnType($"nvarchar({Supplier.CONTACT_INFO_MAX_LENGTH})")
            .HasMaxLength(Supplier.CONTACT_INFO_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<Supplier>()
            .Property(supplier => supplier.ContactLastName)
            .HasColumnName("ContactLastName")
            .HasColumnOrder(3)
            .HasColumnType($"nvarchar({Supplier.CONTACT_INFO_MAX_LENGTH})")
            .HasMaxLength(Supplier.CONTACT_INFO_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<Supplier>()
            .Property(supplier => supplier.ContactEmail)
            .HasColumnName("ContactEmail")
            .HasColumnOrder(4)
            .HasColumnType($"nvarchar({Supplier.CONTACT_INFO_MAX_LENGTH})")
            .HasMaxLength(Supplier.CONTACT_INFO_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<Supplier>()
            .Property(supplier => supplier.ContactPhone)
            .HasColumnName("ContactPhone")
            .HasColumnOrder(5)
            .HasColumnType($"nvarchar({Supplier.CONTACT_INFO_MAX_LENGTH})")
            .HasMaxLength(Supplier.CONTACT_INFO_MAX_LENGTH)
            .IsRequired(true);

        _ = modelBuilder.Entity<Supplier>()
            .Property(supplier => supplier.DateCreated)
            .HasColumnName("DateCreated")
            .HasColumnOrder(6)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .HasDefaultValueSql("GETDATE()")
            .IsRequired(true);

        _ = modelBuilder.Entity<Supplier>()
            .Property(supplier => supplier.DateModified)
            .HasColumnName("DateModified")
            .HasColumnOrder(7)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<Supplier>()
            .Property(supplier => supplier.DateDeleted)
            .HasColumnName("DateDeleted")
            .HasColumnOrder(8)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<Supplier>()
            .Property(supplier => supplier.RowVersion)
            .HasColumnName("RowVersion")
            .HasColumnOrder(9)
            .IsRowVersion();

        #endregion

        #region PURCHASE ORDER

        _ = modelBuilder.Entity<PurchaseOrder>()
            .ToTable(nameof(this.PurchaseOrders))
            .HasKey(order => order.Id);

        _ = modelBuilder.Entity<PurchaseOrder>()
            .Property(order => order.Id)
            .HasColumnName("Id")
            .HasColumnOrder(0)
            .HasColumnType("int")
            .UseIdentityColumn(1, 1);

        _ = modelBuilder.Entity<PurchaseOrder>()
            .Property(order => order.Status)
            .HasColumnName("Status")
            .HasColumnOrder(1)
            .HasColumnType("int")
            .IsRequired();

        _ = modelBuilder.Entity<PurchaseOrder>()
            .Property(order => order.ProductId)
            .HasColumnName("ProductId")
            .HasColumnOrder(2)
            .HasColumnType("int")
            .IsRequired();

        _ = modelBuilder.Entity<PurchaseOrder>()
            .Property(order => order.WarehouseId)
            .HasColumnName("WarehouseId")
            .HasColumnOrder(3)
            .HasColumnType("int")
            .IsRequired();

        _ = modelBuilder.Entity<PurchaseOrder>()
            .Property(order => order.Quantity)
            .HasColumnName("Quantity")
            .HasColumnOrder(4)
            .HasColumnType("int")
            .IsRequired();

        _ = modelBuilder.Entity<PurchaseOrder>()
            .Property(order => order.DateCompleted)
            .HasColumnName("DateCompleted")
            .HasColumnOrder(5)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<PurchaseOrder>()
            .Property(order => order.DateCreated)
            .HasColumnName("DateCreated")
            .HasColumnOrder(6)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .HasDefaultValueSql("GETDATE()")
            .IsRequired(true);

        _ = modelBuilder.Entity<PurchaseOrder>()
            .Property(order => order.DateModified)
            .HasColumnName("DateModified")
            .HasColumnOrder(7)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<PurchaseOrder>()
            .Property(order => order.DateDeleted)
            .HasColumnName("DateDeleted")
            .HasColumnOrder(8)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<PurchaseOrder>()
            .Property(order => order.RowVersion)
            .HasColumnName("RowVersion")
            .HasColumnOrder(9)
            .IsRowVersion();

        // Configuration des relations
        _ = modelBuilder.Entity<PurchaseOrder>()
            .HasOne(order => order.Product)
            .WithMany(produit => produit.)
            .HasForeignKey(order => order.ProductId)
            .OnDelete(DeleteBehavior.Restrict)
            .IsRequired();

        _ = modelBuilder.Entity<PurchaseOrder>()
            .HasOne(order => order.Warehouse)
            .WithMany(warehouse => warehouse.PurchaseOrders)
            .HasForeignKey(order => order.WarehouseId)
            .OnDelete(DeleteBehavior.Restrict)
            .IsRequired();

        #endregion











        // TODO: @TOUTE_EQUIPE Faites la configuration de vos entités et de leur relations ici



        #region Produits

        _ = modelBuilder.Entity<Product>()
            .ToTable(nameof(this.Produits))
            .HasKey(produit => produit.Id);

        _ = modelBuilder.Entity<Product>()
            .Property(produit => produit.Id)
            .HasColumnName("Id")
            .HasColumnOrder(0)
            .HasColumnType("int")
            .UseIdentityColumn(1, 1);

        _ = modelBuilder.Entity<Product>()
            .Property(produit => produit.Nom)
            .HasColumnName("Nom")
            .HasColumnOrder(1)
            .HasColumnType("nvarchar(100)")
            .IsRequired(true);

        _ = modelBuilder.Entity<Product>()
            .Property(produit => produit.Description)
            .HasColumnName("Description")
            .HasColumnOrder(2)
            .HasColumnType("nvarchar(255)")
            .IsRequired(false);

        _ = modelBuilder.Entity<Product>()
            .Property(produit => produit.Prix)
            .HasColumnName("Prix")
            .HasColumnOrder(3)
            .HasColumnType("decimal(18,2)")
            .IsRequired(true);

        _ = modelBuilder.Entity<Product>()
            .Property(produit => produit.Stock)
            .HasColumnName("Stock")
            .HasColumnOrder(4)
            .HasColumnType("int")
            .IsRequired(true);

        _ = modelBuilder.Entity<Product>()
            .Property(produit => produit.DateCreation)
            .HasColumnName("DateCreation")
            .HasColumnOrder(5)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .HasDefaultValueSql("GETDATE()")
            .IsRequired(true);

        _ = modelBuilder.Entity<Product>()
            .Property(produit => produit.DateModification)
            .HasColumnName("DateModification")
            .HasColumnOrder(6)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<Product>()
            .Property(produit => produit.DateSuppression)
            .HasColumnName("DateSuppression")
            .HasColumnOrder(7)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        #endregion



        #region Entrepot

        _ = modelBuilder.Entity<Warehouse>()
    .ToTable(nameof(this.Entrepots))
    .HasKey(entrepot => entrepot.Id);

        _ = modelBuilder.Entity<Warehouse>()
            .Property(entrepot => entrepot.Id)
            .HasColumnName("Id")
            .HasColumnOrder(0)
            .HasColumnType("int")
            .UseIdentityColumn(1, 1);

        _ = modelBuilder.Entity<Warehouse>()
            .Property(entrepot => entrepot.Nom)
            .HasColumnName("Nom")
            .HasColumnOrder(1)
            .HasColumnType("nvarchar(100)")
            .IsRequired(true);

        _ = modelBuilder.Entity<Warehouse>()
            .Property(entrepot => entrepot.Adresse)
            .HasColumnName("Adresse")
            .HasColumnOrder(2)
            .HasColumnType("nvarchar(255)")
            .IsRequired(true);

        _ = modelBuilder.Entity<Warehouse>()
            .Property(entrepot => entrepot.Capacite)
            .HasColumnName("Capacite")
            .HasColumnOrder(3)
            .HasColumnType("int")
            .IsRequired(true);

        _ = modelBuilder.Entity<Warehouse>()
            .Property(entrepot => entrepot.DateCreation)
            .HasColumnName("DateCreation")
            .HasColumnOrder(4)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .HasDefaultValueSql("GETDATE()")
            .IsRequired(true);

        _ = modelBuilder.Entity<Warehouse>()
            .Property(entrepot => entrepot.DateModification)
            .HasColumnName("DateModification")
            .HasColumnOrder(5)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);

        _ = modelBuilder.Entity<Warehouse>()
            .Property(entrepot => entrepot.DateSuppression)
            .HasColumnName("DateSuppression")
            .HasColumnOrder(6)
            .HasColumnType("datetime2")
            .HasPrecision(7)
            .IsRequired(false);



        // NOTE: le mot de passe des user est "testpasswd".
        User user1 = new User("UserAdmin", "43C39F5E14573CCB5E176B9C701673C3F7031F85C711E9A1B00AB6E4802A7310:F4C024A35DB3B92F9D1AFD928E9D6D26:100000:SHA256") {
            Id = 1
        };
        User user2 = new User("UserOffice", "43C39F5E14573CCB5E176B9C701673C3F7031F85C711E9A1B00AB6E4802A7310:F4C024A35DB3B92F9D1AFD928E9D6D26:100000:SHA256") {
            Id = 2
        };
        // TODO: @PROF assigner une warehouse à user3 quand une warehouse sera ajoutée.
        User user3 = new User("UserWarehouse", "43C39F5E14573CCB5E176B9C701673C3F7031F85C711E9A1B00AB6E4802A7310:F4C024A35DB3B92F9D1AFD928E9D6D26:100000:SHA256") {
            Id = 3
        };
        _ = modelBuilder.Entity<User>().HasData(user1, user2, user3);


        Role adminRole = new Role("Administrateurs",
            "Administrateurs tout-puissants."
        ) {
            Id = Role.ADMIN_ROLE_ID
        };
        Role officeEmployeesRole = new Role("Employés de bureau",
            "Employés travaillant dans les bureaux de WSYS Inc."
        ) {
            Id = Role.OFFICE_EMPLOYEE_ROLE_ID
        };
        Role whEmployeeRole = new Role("Employés d'entrepôt",
            "Employés travaillant dans les entrepôts de WSYS Inc."
        ) {
            Id = Role.WAREHOUSE_EMPLOYEE_ROLE_ID
        };
        _ = modelBuilder.Entity<Role>()
            .HasData(adminRole, officeEmployeesRole, whEmployeeRole);


        // NOTE: doit être placé après l'insertion de données pour User et pour Role
        // (besoin des IDs pour les associations)
        _ = modelBuilder.Entity<User>()
            .HasMany(user => user.Roles)
            .WithMany(role => role.Users)
            .UsingEntity("UserRoles",
                rightRelation => {
                    return rightRelation.HasOne(typeof(Role)).WithMany().HasForeignKey("RoleId").HasPrincipalKey(nameof(Role.Id));
                },
                leftRelation => {
                    return leftRelation.HasOne(typeof(User)).WithMany().HasForeignKey("UserId").HasPrincipalKey(nameof(User.Id));
                },
                shadowEntityConfig => {
                    _ = shadowEntityConfig.HasKey("UserId", "RoleId");
                    _ = shadowEntityConfig.HasData(
                    new { UserId = 1, RoleId = 1 },
                    new { UserId = 2, RoleId = 2 },
                    new { UserId = 3, RoleId = 3 });
                }
            );
        // Possiblement pas besoin de la relation inverse
        /*
        _ = modelBuilder.Entity<Role>()
            .HasMany(role => role.Users)
            .WithMany(user => user.Roles);
        */

        #endregion




    }
}
