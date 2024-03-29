﻿// <auto-generated />
using System;
using EFDBFrist.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFDBFrist.Migrations
{
    [DbContext(typeof(SezureSystemDB44Context))]
    partial class SezureSystemDB44ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EFDBFrist.Models.AppForm", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("ID");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Parent")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("AppForms");
                });

            modelBuilder.Entity("EFDBFrist.Models.Assignment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AssignmentType")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreateById")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatingDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReasonAssignment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReferenceNo")
                        .HasColumnType("int");

                    b.Property<string>("ReleaseNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdateById")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UploadDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Assignment", (string)null);
                });

            modelBuilder.Entity("EFDBFrist.Models.AssignmentPerson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AssignmentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreateById")
                        .HasColumnType("int");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("PersonCode")
                        .HasColumnType("int");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdateById")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "AssignmentId" }, "IX_AssignmentPerson_AssignmentId");

                    b.HasIndex(new[] { "PersonId" }, "IX_AssignmentPerson_PersonId");

                    b.HasIndex(new[] { "SupplierId" }, "IX_AssignmentPerson_SupplierId");

                    b.ToTable("AssignmentPerson", (string)null);
                });

            modelBuilder.Entity("EFDBFrist.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreateById")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OriginCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdateById")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Company", (string)null);
                });

            modelBuilder.Entity("EFDBFrist.Models.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Add")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreateById")
                        .HasColumnType("int");

                    b.Property<bool>("Delete")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Other")
                        .HasColumnType("bit");

                    b.Property<int>("ParentId")
                        .HasColumnType("int")
                        .HasColumnName("ParentID");

                    b.Property<bool>("Print")
                        .HasColumnType("bit");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<bool>("Search")
                        .HasColumnType("bit");

                    b.Property<bool>("Show")
                        .HasColumnType("bit");

                    b.Property<bool>("Update")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdateById")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "RoleId" }, "IX_Permission_RoleId");

                    b.ToTable("Permission", (string)null);
                });

            modelBuilder.Entity("EFDBFrist.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreateById")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdateById")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("EFDBFrist.Models.PharmaceuticalForm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AmountOfSamplesDrawn")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreateById")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdateById")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PharmaceuticalForm", (string)null);
                });

            modelBuilder.Entity("EFDBFrist.Models.PortOfEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreateById")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdateById")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PortOfEntry", (string)null);
                });

            modelBuilder.Entity("EFDBFrist.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Concentration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreateById")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Packaging")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("packaging");

                    b.Property<int?>("PharmaceuticalFormId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("ProductCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ScientificName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdateById")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "PharmaceuticalFormId" }, "IX_Product_PharmaceuticalFormId");

                    b.ToTable("Product", (string)null);
                });

            modelBuilder.Entity("EFDBFrist.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreateById")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdateById")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("EFDBFrist.Models.SampleLabSend", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("AnalysisCertificate")
                        .HasColumnType("bit");

                    b.Property<bool>("AnalysisMethod")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreateById")
                        .HasColumnType("int");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SeizureProcessId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdateById")
                        .HasColumnType("int");

                    b.Property<int>("VoucherAnalysisNo")
                        .HasColumnType("int");

                    b.Property<bool>("WorkingStandard")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "SeizureProcessId" }, "IX_SampleLabSend_SeizureProcessId");

                    b.ToTable("SampleLabSend", (string)null);
                });

            modelBuilder.Entity("EFDBFrist.Models.SampleLabTest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreateById")
                        .HasColumnType("int");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Result")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdateById")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SampleLabTest", (string)null);
                });

            modelBuilder.Entity("EFDBFrist.Models.SeizureProcess", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AssignmentId")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreateById")
                        .HasColumnType("int");

                    b.Property<string>("InvoiceNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("PortOfEntryId")
                        .HasColumnType("int");

                    b.Property<string>("ReasonForSeizure")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReferenceNo")
                        .HasColumnType("int");

                    b.Property<string>("ReferenceNo2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SeizureType")
                        .HasColumnType("int")
                        .HasColumnName("seizureType");

                    b.Property<string>("ShipmentType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdateById")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UploadDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "AssignmentId" }, "IX_SeizureProcess_AssignmentId");

                    b.HasIndex(new[] { "CompanyId" }, "IX_SeizureProcess_CompanyId");

                    b.HasIndex(new[] { "PortOfEntryId" }, "IX_SeizureProcess_PortOfEntryId");

                    b.HasIndex(new[] { "SupplierId" }, "IX_SeizureProcess_SupplierId");

                    b.HasIndex(new[] { "UserId" }, "IX_SeizureProcess_UserId");

                    b.ToTable("SeizureProcess", (string)null);
                });

            modelBuilder.Entity("EFDBFrist.Models.SeizureProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AmountReal")
                        .HasColumnType("int");

                    b.Property<DateTime?>("AnalysisDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BatchNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreateById")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LabNotes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LabSendNotes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ProductionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Result")
                        .HasColumnType("int");

                    b.Property<int?>("SampleLabTestId")
                        .HasColumnType("int");

                    b.Property<int>("SampleSendToLab")
                        .HasColumnType("int");

                    b.Property<int>("SeizureProcessId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("SendAnalysisDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdateById")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "ProductId" }, "IX_SeizureProduct_ProductId");

                    b.HasIndex(new[] { "SampleLabTestId" }, "IX_SeizureProduct_SampleLabTestId");

                    b.HasIndex(new[] { "SeizureProcessId" }, "IX_SeizureProduct_SeizureProcessId");

                    b.ToTable("SeizureProduct", (string)null);
                });

            modelBuilder.Entity("EFDBFrist.Models.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreateById")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Directorate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LicenseDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("licenseDate");

                    b.Property<string>("LicenseNumber")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("licenseNumber");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<string>("Province")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("province");

                    b.Property<string>("SiteStore")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("SuperName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplierCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdateById")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Supplier", (string)null);
                });

            modelBuilder.Entity("EFDBFrist.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreateById")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassWord")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int")
                        .HasColumnName("type");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdateById")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "RoleId" }, "IX_User_RoleId");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("EFDBFrist.Models.AssignmentPerson", b =>
                {
                    b.HasOne("EFDBFrist.Models.Assignment", "Assignment")
                        .WithMany("AssignmentPeople")
                        .HasForeignKey("AssignmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFDBFrist.Models.Person", "Person")
                        .WithMany("AssignmentPeople")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFDBFrist.Models.Supplier", "Supplier")
                        .WithMany("AssignmentPeople")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assignment");

                    b.Navigation("Person");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("EFDBFrist.Models.Permission", b =>
                {
                    b.HasOne("EFDBFrist.Models.Role", "Role")
                        .WithMany("Permissions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("EFDBFrist.Models.Product", b =>
                {
                    b.HasOne("EFDBFrist.Models.PharmaceuticalForm", "PharmaceuticalForm")
                        .WithMany("Products")
                        .HasForeignKey("PharmaceuticalFormId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("PharmaceuticalForm");
                });

            modelBuilder.Entity("EFDBFrist.Models.SampleLabSend", b =>
                {
                    b.HasOne("EFDBFrist.Models.SeizureProcess", "SeizureProcess")
                        .WithMany("SampleLabSends")
                        .HasForeignKey("SeizureProcessId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SeizureProcess");
                });

            modelBuilder.Entity("EFDBFrist.Models.SeizureProcess", b =>
                {
                    b.HasOne("EFDBFrist.Models.Assignment", "Assignment")
                        .WithMany("SeizureProcesses")
                        .HasForeignKey("AssignmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFDBFrist.Models.Company", "Company")
                        .WithMany("SeizureProcesses")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFDBFrist.Models.PortOfEntry", "PortOfEntry")
                        .WithMany("SeizureProcesses")
                        .HasForeignKey("PortOfEntryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFDBFrist.Models.Supplier", "Supplier")
                        .WithMany("SeizureProcesses")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFDBFrist.Models.User", "User")
                        .WithMany("SeizureProcesses")
                        .HasForeignKey("UserId");

                    b.Navigation("Assignment");

                    b.Navigation("Company");

                    b.Navigation("PortOfEntry");

                    b.Navigation("Supplier");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EFDBFrist.Models.SeizureProduct", b =>
                {
                    b.HasOne("EFDBFrist.Models.Product", "Product")
                        .WithMany("SeizureProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFDBFrist.Models.SampleLabTest", "SampleLabTest")
                        .WithMany("SeizureProducts")
                        .HasForeignKey("SampleLabTestId");

                    b.HasOne("EFDBFrist.Models.SeizureProcess", "SeizureProcess")
                        .WithMany("SeizureProducts")
                        .HasForeignKey("SeizureProcessId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("SampleLabTest");

                    b.Navigation("SeizureProcess");
                });

            modelBuilder.Entity("EFDBFrist.Models.User", b =>
                {
                    b.HasOne("EFDBFrist.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("EFDBFrist.Models.Assignment", b =>
                {
                    b.Navigation("AssignmentPeople");

                    b.Navigation("SeizureProcesses");
                });

            modelBuilder.Entity("EFDBFrist.Models.Company", b =>
                {
                    b.Navigation("SeizureProcesses");
                });

            modelBuilder.Entity("EFDBFrist.Models.Person", b =>
                {
                    b.Navigation("AssignmentPeople");
                });

            modelBuilder.Entity("EFDBFrist.Models.PharmaceuticalForm", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("EFDBFrist.Models.PortOfEntry", b =>
                {
                    b.Navigation("SeizureProcesses");
                });

            modelBuilder.Entity("EFDBFrist.Models.Product", b =>
                {
                    b.Navigation("SeizureProducts");
                });

            modelBuilder.Entity("EFDBFrist.Models.Role", b =>
                {
                    b.Navigation("Permissions");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("EFDBFrist.Models.SampleLabTest", b =>
                {
                    b.Navigation("SeizureProducts");
                });

            modelBuilder.Entity("EFDBFrist.Models.SeizureProcess", b =>
                {
                    b.Navigation("SampleLabSends");

                    b.Navigation("SeizureProducts");
                });

            modelBuilder.Entity("EFDBFrist.Models.Supplier", b =>
                {
                    b.Navigation("AssignmentPeople");

                    b.Navigation("SeizureProcesses");
                });

            modelBuilder.Entity("EFDBFrist.Models.User", b =>
                {
                    b.Navigation("SeizureProcesses");
                });
#pragma warning restore 612, 618
        }
    }
}
