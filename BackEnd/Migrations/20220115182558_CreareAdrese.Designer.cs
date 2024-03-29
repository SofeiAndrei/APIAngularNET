﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proiect_O_A.Data;

namespace Proiect_O_A.Migrations
{
    [DbContext(typeof(ProiectOAContext))]
    [Migration("20220115182558_CreareAdrese")]
    partial class CreareAdrese
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Proiect_O_A.Entities.Adresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cod_Postal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Judet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numar")
                        .HasColumnType("int");

                    b.Property<string>("Oras")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Strada")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Adrese");
                });

            modelBuilder.Entity("Proiect_O_A.Entities.Autor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ani_Experienta")
                        .HasColumnType("int");

                    b.Property<string>("Nume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenume")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Autori");
                });

            modelBuilder.Entity("Proiect_O_A.Entities.Informatii_nutritionale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Calorii")
                        .HasColumnType("int");

                    b.Property<int>("Glucide")
                        .HasColumnType("int");

                    b.Property<int>("Grasimi")
                        .HasColumnType("int");

                    b.Property<int>("Proteine")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Informatii_Nutritionale");
                });

            modelBuilder.Entity("Proiect_O_A.Entities.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Categorie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Unitate_Masura")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ingrediente");
                });

            modelBuilder.Entity("Proiect_O_A.Entities.Magazin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Site")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Magazine");
                });

            modelBuilder.Entity("Proiect_O_A.Entities.Recenzie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Continut")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Recenzii");
                });

            modelBuilder.Entity("Proiect_O_A.Entities.Reteta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bucatarie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Categorie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Durata_minute")
                        .HasColumnType("int");

                    b.Property<string>("Grad_Dificultate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mod_preparare")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numar_portii")
                        .HasColumnType("int");

                    b.Property<string>("Nume")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Retete");
                });
#pragma warning restore 612, 618
        }
    }
}
