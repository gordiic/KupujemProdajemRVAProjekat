﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RVAProjekat.AppData;

namespace RVAProjekat.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    partial class DataBaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RVAProjekat.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cijena")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Fiksno")
                        .HasColumnType("bit");

                    b.Property<string>("Kategorija")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MjestoGrad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naslov")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NudimTrazim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PrihvatamZamjenu")
                        .HasColumnType("bit");

                    b.Property<string>("TekstOglasa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("RVAProjekat.Models.Obavjestenje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdArtikla")
                        .HasColumnType("int");

                    b.Property<int>("KomeId")
                        .HasColumnType("int");

                    b.Property<string>("KomeIme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OdkogaId")
                        .HasColumnType("int");

                    b.Property<string>("OdkogaIme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Obavjestenja");
                });

            modelBuilder.Entity("RVAProjekat.Models.Ocjena", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrOcjene")
                        .HasColumnType("int");

                    b.Property<int>("IdKorisnika")
                        .HasColumnType("int");

                    b.Property<int>("IdKorisnikaOcijenjenog")
                        .HasColumnType("int");

                    b.Property<string>("Komentar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KorisnickoIme")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ocjenas");
                });

            modelBuilder.Entity("RVAProjekat.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrOcjena")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KorisnickoIme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lozinka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ProsjecnaOcjena")
                        .HasColumnType("float");

                    b.Property<string>("Uloga")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
