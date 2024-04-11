using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CarAccouting
{
    public partial class ManagementTSGContext : DbContext
    {
        public ManagementTSGContext()
        {
        }

        public ManagementTSGContext(DbContextOptions<ManagementTSGContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Собственники> Собственники { get; set; }
        public virtual DbSet<Услуги> Услуги { get; set; }
        public virtual DbSet<Финансы> Финансы { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=QWERTY;Database=ManagementTSG;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK__Employee__78113481AD55C060");

                entity.HasIndex(e => e.EmployeePhone)
                    .HasName("UQ__Employee__27896340F447E0FA")
                    .IsUnique();

                entity.HasIndex(e => e.EmployeeUsername)
                    .HasName("UQ__Employee__AE51D1EFB8957471")
                    .IsUnique();

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.EmployeeFullName)
                    .IsRequired()
                    .HasColumnName("Employee_full_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeJobTitle)
                    .IsRequired()
                    .HasColumnName("Employee_job_title")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeePassHash)
                    .IsRequired()
                    .HasColumnName("Employee_pass_hash")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeePhone)
                    .IsRequired()
                    .HasColumnName("Employee_phone")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeUsername)
                    .IsRequired()
                    .HasColumnName("Employee_username")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Собственники>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Имя)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Телефон)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Фамилия)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Услуги>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Название)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Стоимость).HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<Финансы>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdСобственника).HasColumnName("ID_Собственника");

                entity.Property(e => e.IdУслуги).HasColumnName("ID_Услуги");

                entity.Property(e => e.Дата).HasColumnType("date");

                entity.HasOne(d => d.IdСобственникаNavigation)
                    .WithMany(p => p.Финансы)
                    .HasForeignKey(d => d.IdСобственника)
                    .HasConstraintName("FK__Финансы__ID_Собс__6C190EBB");

                entity.HasOne(d => d.IdУслугиNavigation)
                    .WithMany(p => p.Финансы)
                    .HasForeignKey(d => d.IdУслуги)
                    .HasConstraintName("FK__Финансы__ID_Услу__6D0D32F4");
            });
        }
    }
}
