using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HappyPets.Data
{
    public partial class HappyPetsDBContext : DbContext
    {
        public HappyPetsDBContext()
        {
        }

        public HappyPetsDBContext(DbContextOptions<HappyPetsDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Appointments> Appointments { get; set; }
        public virtual DbSet<Cart> Cart { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeRating> EmployeeRating { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Pet> Pet { get; set; }
        public virtual DbSet<PetSize> PetSize { get; set; }
        public virtual DbSet<PetType> PetType { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Services> Services { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UserType> UserType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:rios-1806.database.windows.net,1433;Initial Catalog=HappyPetsDB;Persist Security Info=False;User ID=rios;Password=Yes12345;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointments>(entity =>
            {
                entity.HasKey(e => e.AppointmentId);

                entity.ToTable("Appointments", "Pets");

                entity.Property(e => e.AppointmentId).HasColumnName("appointment_id");

                entity.Property(e => e.AppointmentDate)
                    .HasColumnName("appointment_date")
                    .HasColumnType("date");

                entity.Property(e => e.AppointmentTime).HasColumnName("appointment_time");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.UsersId).HasColumnName("users_id");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_employeeToAppointments");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_orderToAppointments");

                entity.HasOne(d => d.Users)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.UsersId)
                    .HasConstraintName("FK_userToAppointments");
            });

            modelBuilder.Entity<Cart>(entity =>
            {
                entity.ToTable("Cart", "Pets");

                entity.Property(e => e.CartId).HasColumnName("cart_id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemTotalCost)
                    .HasColumnName("item_total_cost")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ItemType).HasColumnName("item_type");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.UsersId).HasColumnName("users_id");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Cart)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_orderToCart");

                entity.HasOne(d => d.Users)
                    .WithMany(p => p.Cart)
                    .HasForeignKey(d => d.UsersId)
                    .HasConstraintName("FK_userToCart");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee", "Pets");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK_locationToEmployee");
            });

            modelBuilder.Entity<EmployeeRating>(entity =>
            {
                entity.HasKey(e => e.RatingId);

                entity.ToTable("Employee_Rating", "Pets");

                entity.Property(e => e.RatingId).HasColumnName("rating_id");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeRating)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_employeeToRating");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("Location", "Pets");

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.Property(e => e.LocationName)
                    .HasColumnName("location_name")
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("Orders", "Pets");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.Property(e => e.OrderTime)
                    .HasColumnName("order_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.TotalCost)
                    .HasColumnName("total_cost")
                    .HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_employeeToorder");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_locationToorder");
            });

            modelBuilder.Entity<Pet>(entity =>
            {
                entity.ToTable("Pet", "Pets");

                entity.Property(e => e.PetId).HasColumnName("pet_id");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SizeId).HasColumnName("size_id");

                entity.Property(e => e.TypesId).HasColumnName("types_id");

                entity.HasOne(d => d.Size)
                    .WithMany(p => p.Pet)
                    .HasForeignKey(d => d.SizeId)
                    .HasConstraintName("FK_petsizeToPet");

                entity.HasOne(d => d.Types)
                    .WithMany(p => p.Pet)
                    .HasForeignKey(d => d.TypesId)
                    .HasConstraintName("FK_typeToPet");
            });

            modelBuilder.Entity<PetSize>(entity =>
            {
                entity.HasKey(e => e.SizeId);

                entity.ToTable("Pet_Size", "Pets");

                entity.Property(e => e.SizeId).HasColumnName("size_id");

                entity.Property(e => e.PetSize1)
                    .HasColumnName("pet_size")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PetType>(entity =>
            {
                entity.HasKey(e => e.TypesId);

                entity.ToTable("Pet_Type", "Pets");

                entity.Property(e => e.TypesId).HasColumnName("types_id");

                entity.Property(e => e.TypesName)
                    .HasColumnName("types_name")
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.ToTable("Products", "Pets");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.InventoryQuantity).HasColumnName("inventory_quantity");

                entity.Property(e => e.ProductDescription)
                    .HasColumnName("product_description")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ProductNames)
                    .HasColumnName("product_names")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.ProductPrice)
                    .HasColumnName("product_price")
                    .HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<Services>(entity =>
            {
                entity.HasKey(e => e.ServiceId);

                entity.ToTable("Services", "Pets");

                entity.Property(e => e.ServiceId).HasColumnName("service_id");

                entity.Property(e => e.ServiceDescription)
                    .HasColumnName("service_description")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceNames)
                    .HasColumnName("service_names")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.ServicePrice)
                    .HasColumnName("service_price")
                    .HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("Users", "Pets");

                entity.Property(e => e.UsersId).HasColumnName("users_id");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.Property(e => e.Passwords)
                    .HasColumnName("passwords")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.StreetAddress)
                    .HasColumnName("street_address")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.UserType).HasColumnName("user_type");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_employeeTousers");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK_locationToUser");

                entity.HasOne(d => d.UserTypeNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UserType)
                    .HasConstraintName("FK_usertypeToUser");
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.HasKey(e => e.TypesId);

                entity.ToTable("User_Type", "Pets");

                entity.Property(e => e.TypesId).HasColumnName("types_id");

                entity.Property(e => e.TypesName)
                    .HasColumnName("types_name")
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });
        }
    }
}
