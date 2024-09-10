﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TP01EF2024.Datos;

#nullable disable

namespace TP01EF2024.Datos.Migrations
{
    [DbContext(typeof(TP01DbContext))]
    [Migration("20240523160730_IncorporacionTablaShoesColours")]
    partial class IncorporacionTablaShoesColours
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TP01EF2024.Entidades.Brand", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BrandId"));

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("BrandId");

                    b.HasIndex("BrandName")
                        .IsUnique();

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            BrandId = 1,
                            BrandName = "Vans"
                        },
                        new
                        {
                            BrandId = 2,
                            BrandName = "Adidas"
                        },
                        new
                        {
                            BrandId = 3,
                            BrandName = "Topper"
                        });
                });

            modelBuilder.Entity("TP01EF2024.Entidades.Colour", b =>
                {
                    b.Property<int>("ColourId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ColourId"));

                    b.Property<string>("ColourName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ColourId");

                    b.HasIndex("ColourName")
                        .IsUnique();

                    b.ToTable("Colours");

                    b.HasData(
                        new
                        {
                            ColourId = 1,
                            ColourName = "Rojo"
                        },
                        new
                        {
                            ColourId = 2,
                            ColourName = "Negro"
                        },
                        new
                        {
                            ColourId = 3,
                            ColourName = "Blanco"
                        });
                });

            modelBuilder.Entity("TP01EF2024.Entidades.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenreId"));

                    b.Property<string>("GenreName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("GenreId");

                    b.HasIndex("GenreName")
                        .IsUnique();

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreId = 1,
                            GenreName = "Femenino"
                        },
                        new
                        {
                            GenreId = 2,
                            GenreName = "Masculino"
                        },
                        new
                        {
                            GenreId = 3,
                            GenreName = "Unisex"
                        });
                });

            modelBuilder.Entity("TP01EF2024.Entidades.Shoe", b =>
                {
                    b.Property<int>("ShoeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShoeId"));

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<decimal>("Price")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("SportId")
                        .HasColumnType("int");

                    b.HasKey("ShoeId");

                    b.HasIndex("BrandId");

                    b.HasIndex("GenreId");

                    b.HasIndex("SportId");

                    b.ToTable("Shoes");
                });

            modelBuilder.Entity("TP01EF2024.Entidades.ShoeColour", b =>
                {
                    b.Property<int>("ShoeId")
                        .HasColumnType("int");

                    b.Property<int>("ColourId")
                        .HasColumnType("int");

                    b.HasKey("ShoeId", "ColourId");

                    b.HasIndex("ColourId");

                    b.ToTable("ShoesColours");
                });

            modelBuilder.Entity("TP01EF2024.Entidades.Sport", b =>
                {
                    b.Property<int>("SportId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SportId"));

                    b.Property<string>("SportName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("SportId");

                    b.HasIndex("SportName")
                        .IsUnique();

                    b.ToTable("Sports");

                    b.HasData(
                        new
                        {
                            SportId = 1,
                            SportName = "Futbol"
                        },
                        new
                        {
                            SportId = 2,
                            SportName = "Tenis"
                        },
                        new
                        {
                            SportId = 3,
                            SportName = "Basquet"
                        });
                });

            modelBuilder.Entity("TP01EF2024.Entidades.Shoe", b =>
                {
                    b.HasOne("TP01EF2024.Entidades.Brand", "Brand")
                        .WithMany("Shoes")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TP01EF2024.Entidades.Genre", "Genre")
                        .WithMany("Shoes")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TP01EF2024.Entidades.Sport", "Sport")
                        .WithMany("Shoes")
                        .HasForeignKey("SportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Genre");

                    b.Navigation("Sport");
                });

            modelBuilder.Entity("TP01EF2024.Entidades.ShoeColour", b =>
                {
                    b.HasOne("TP01EF2024.Entidades.Colour", "Colour")
                        .WithMany("ShoesColours")
                        .HasForeignKey("ColourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TP01EF2024.Entidades.Shoe", "Shoe")
                        .WithMany("ShoesColours")
                        .HasForeignKey("ShoeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Colour");

                    b.Navigation("Shoe");
                });

            modelBuilder.Entity("TP01EF2024.Entidades.Brand", b =>
                {
                    b.Navigation("Shoes");
                });

            modelBuilder.Entity("TP01EF2024.Entidades.Colour", b =>
                {
                    b.Navigation("ShoesColours");
                });

            modelBuilder.Entity("TP01EF2024.Entidades.Genre", b =>
                {
                    b.Navigation("Shoes");
                });

            modelBuilder.Entity("TP01EF2024.Entidades.Shoe", b =>
                {
                    b.Navigation("ShoesColours");
                });

            modelBuilder.Entity("TP01EF2024.Entidades.Sport", b =>
                {
                    b.Navigation("Shoes");
                });
#pragma warning restore 612, 618
        }
    }
}
