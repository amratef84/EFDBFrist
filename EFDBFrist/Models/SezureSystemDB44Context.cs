using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EFDBFrist.Models
{
    public partial class SezureSystemDB44Context : DbContext
    {
        public SezureSystemDB44Context()
        {
        }

        public SezureSystemDB44Context(DbContextOptions<SezureSystemDB44Context> options)
            : base(options)
        {
        }

        public virtual DbSet<AppForm> AppForms { get; set; } = null!;
        public virtual DbSet<Assignment> Assignments { get; set; } = null!;
        public virtual DbSet<AssignmentPerson> AssignmentPeople { get; set; } = null!;
        public virtual DbSet<Company> Companies { get; set; } = null!;
        public virtual DbSet<Permission> Permissions { get; set; } = null!;
        public virtual DbSet<Person> Persons { get; set; } = null!;
        public virtual DbSet<PharmaceuticalForm> PharmaceuticalForms { get; set; } = null!;
        public virtual DbSet<PortOfEntry> PortOfEntries { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<SampleLabSend> SampleLabSends { get; set; } = null!;
        public virtual DbSet<SampleLabTest> SampleLabTests { get; set; } = null!;
        public virtual DbSet<SeizureProcess> SeizureProcesses { get; set; } = null!;
        public virtual DbSet<SeizureProduct> SeizureProducts { get; set; } = null!;
        public virtual DbSet<Supplier> Suppliers { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=SezureSystemDB44;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppForm>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<Assignment>(entity =>
            {
                entity.ToTable("Assignment");
            });

            modelBuilder.Entity<AssignmentPerson>(entity =>
            {
                entity.ToTable("AssignmentPerson");

                entity.HasIndex(e => e.AssignmentId, "IX_AssignmentPerson_AssignmentId");

                entity.HasIndex(e => e.PersonId, "IX_AssignmentPerson_PersonId");

                entity.HasIndex(e => e.SupplierId, "IX_AssignmentPerson_SupplierId");

                entity.HasOne(d => d.Assignment)
                    .WithMany(p => p.AssignmentPeople)
                    .HasForeignKey(d => d.AssignmentId);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.AssignmentPeople)
                    .HasForeignKey(d => d.PersonId);

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.AssignmentPeople)
                    .HasForeignKey(d => d.SupplierId);
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("Company");
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.ToTable("Permission");

                entity.HasIndex(e => e.RoleId, "IX_Permission_RoleId");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Permissions)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<PharmaceuticalForm>(entity =>
            {
                entity.ToTable("PharmaceuticalForm");
            });

            modelBuilder.Entity<PortOfEntry>(entity =>
            {
                entity.ToTable("PortOfEntry");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.HasIndex(e => e.PharmaceuticalFormId, "IX_Product_PharmaceuticalFormId");

                entity.Property(e => e.Packaging).HasColumnName("packaging");

                entity.Property(e => e.PharmaceuticalFormId).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.PharmaceuticalForm)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.PharmaceuticalFormId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<SampleLabSend>(entity =>
            {
                entity.ToTable("SampleLabSend");

                entity.HasIndex(e => e.SeizureProcessId, "IX_SampleLabSend_SeizureProcessId");

                entity.HasOne(d => d.SeizureProcess)
                    .WithMany(p => p.SampleLabSends)
                    .HasForeignKey(d => d.SeizureProcessId);
            });

            modelBuilder.Entity<SampleLabTest>(entity =>
            {
                entity.ToTable("SampleLabTest");
            });

            modelBuilder.Entity<SeizureProcess>(entity =>
            {
                entity.ToTable("SeizureProcess");

                entity.HasIndex(e => e.AssignmentId, "IX_SeizureProcess_AssignmentId");

                entity.HasIndex(e => e.CompanyId, "IX_SeizureProcess_CompanyId");

                entity.HasIndex(e => e.PortOfEntryId, "IX_SeizureProcess_PortOfEntryId");

                entity.HasIndex(e => e.SupplierId, "IX_SeizureProcess_SupplierId");

                entity.HasIndex(e => e.UserId, "IX_SeizureProcess_UserId");

                entity.Property(e => e.SeizureType).HasColumnName("seizureType");

                entity.HasOne(d => d.Assignment)
                    .WithMany(p => p.SeizureProcesses)
                    .HasForeignKey(d => d.AssignmentId);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.SeizureProcesses)
                    .HasForeignKey(d => d.CompanyId);

                entity.HasOne(d => d.PortOfEntry)
                    .WithMany(p => p.SeizureProcesses)
                    .HasForeignKey(d => d.PortOfEntryId);

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.SeizureProcesses)
                    .HasForeignKey(d => d.SupplierId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SeizureProcesses)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<SeizureProduct>(entity =>
            {
                entity.ToTable("SeizureProduct");

                entity.HasIndex(e => e.ProductId, "IX_SeizureProduct_ProductId");

                entity.HasIndex(e => e.SampleLabTestId, "IX_SeizureProduct_SampleLabTestId");

                entity.HasIndex(e => e.SeizureProcessId, "IX_SeizureProduct_SeizureProcessId");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.SeizureProducts)
                    .HasForeignKey(d => d.ProductId);

                entity.HasOne(d => d.SampleLabTest)
                    .WithMany(p => p.SeizureProducts)
                    .HasForeignKey(d => d.SampleLabTestId);

                entity.HasOne(d => d.SeizureProcess)
                    .WithMany(p => p.SeizureProducts)
                    .HasForeignKey(d => d.SeizureProcessId);
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.ToTable("Supplier");

                entity.Property(e => e.LicenseDate).HasColumnName("licenseDate");

                entity.Property(e => e.LicenseNumber).HasColumnName("licenseNumber");

                entity.Property(e => e.Province).HasColumnName("province");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.HasIndex(e => e.RoleId, "IX_User_RoleId");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
