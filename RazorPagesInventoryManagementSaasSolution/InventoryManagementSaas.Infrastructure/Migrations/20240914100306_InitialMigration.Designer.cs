﻿// <auto-generated />
using InventoryManagementSaas.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InventoryManagementSaas.Infrastructure.Migrations
{
    [DbContext(typeof(InventoryDbContext))]
    [Migration("20240914100306_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("InventoryManagementSaas.Infrastructure.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT")
                        .HasColumnName("Description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Name");

                    b.HasKey("CategoryId");

                    b.ToTable("Category", "dbo");
                });

            modelBuilder.Entity("InventoryManagementSaas.Infrastructure.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT")
                        .HasColumnName("Email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Name");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT")
                        .HasColumnName("PhoneNumber");

                    b.HasKey("CompanyId");

                    b.ToTable("Company", "dbo");
                });

            modelBuilder.Entity("InventoryManagementSaas.Infrastructure.Inventory", b =>
                {
                    b.Property<int>("InventoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("CategoryId");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT")
                        .HasColumnName("Description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Name");

                    b.Property<int>("QuantityInStock")
                        .HasColumnType("INTEGER")
                        .HasColumnName("QuantityInStock");

                    b.Property<int>("ReorderLevel")
                        .HasColumnType("INTEGER")
                        .HasColumnName("ReorderLevel");

                    b.Property<int>("SupplierId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("SupplierId");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("TEXT")
                        .HasColumnName("UnitPrice");

                    b.HasKey("InventoryId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Inventory", "dbo");
                });

            modelBuilder.Entity("InventoryManagementSaas.Infrastructure.Supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT")
                        .HasColumnName("Email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Name");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT")
                        .HasColumnName("PhoneNumber");

                    b.HasKey("SupplierId");

                    b.ToTable("Supplier", "dbo");
                });

            modelBuilder.Entity("InventoryManagementSaas.Infrastructure.Tenant", b =>
                {
                    b.Property<int>("TenantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Host")
                        .HasColumnType("INTEGER")
                        .HasColumnName("Host");

                    b.Property<int>("Name")
                        .HasColumnType("INTEGER")
                        .HasColumnName("Name");

                    b.HasKey("TenantId");

                    b.ToTable("Tenant", "dbo");
                });

            modelBuilder.Entity("InventoryManagementSaas.Infrastructure.Inventory", b =>
                {
                    b.HasOne("InventoryManagementSaas.Infrastructure.Category", "Category")
                        .WithMany("Inventories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InventoryManagementSaas.Infrastructure.Supplier", "Supplier")
                        .WithMany("Inventories")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("InventoryManagementSaas.Infrastructure.Category", b =>
                {
                    b.Navigation("Inventories");
                });

            modelBuilder.Entity("InventoryManagementSaas.Infrastructure.Supplier", b =>
                {
                    b.Navigation("Inventories");
                });
#pragma warning restore 612, 618
        }
    }
}
