﻿// <auto-generated />
using ECommerce.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ECommerce.Data.Migrations
{
    [DbContext(typeof(CommerceContext))]
    partial class CommerceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ECommerce.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsFeatured")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsFeatured = true,
                            Name = "Criollo Chocolate",
                            UnitPrice = 34.95m
                        },
                        new
                        {
                            Id = 2,
                            IsFeatured = true,
                            Name = "Arborio Rice",
                            UnitPrice = 22.75m
                        },
                        new
                        {
                            Id = 3,
                            IsFeatured = true,
                            Name = "White Asparagus",
                            UnitPrice = 39.80m
                        },
                        new
                        {
                            Id = 4,
                            IsFeatured = false,
                            Name = "Maldon Sea Salt",
                            UnitPrice = 19.50m
                        },
                        new
                        {
                            Id = 5,
                            IsFeatured = true,
                            Name = "Gruyère cheese",
                            UnitPrice = 48.50m
                        },
                        new
                        {
                            Id = 6,
                            IsFeatured = true,
                            Name = "Anchovies",
                            UnitPrice = 18.75m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
