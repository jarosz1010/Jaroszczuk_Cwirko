﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication7.Models;

namespace WebApplication7.Migrations
{
    [DbContext(typeof(WebApplication7Context))]
    [Migration("20200429110743_transakcje")]
    partial class transakcje
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication7.Models.Klient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Imie");

                    b.Property<string>("Nazwisko");

                    b.Property<int>("Znizka");

                    b.HasKey("Id");

                    b.ToTable("Klientcs");
                });

            modelBuilder.Entity("WebApplication7.Models.Polaczenie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Godzina");

                    b.Property<int>("Ilosc_miejsc");

                    b.Property<string>("Stacja");

                    b.HasKey("Id");

                    b.ToTable("Trasa");
                });

            modelBuilder.Entity("WebApplication7.Models.Pracownik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Haslo");

                    b.Property<string>("Imie");

                    b.Property<string>("Login");

                    b.Property<string>("Nazwisko");

                    b.Property<string>("Stanowisko");

                    b.HasKey("Id");

                    b.ToTable("Pracownik");
                });

            modelBuilder.Entity("WebApplication7.Models.Transakcja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("KlientId");

                    b.Property<int?>("PolaczenieId");

                    b.Property<int?>("PracownikId");

                    b.HasKey("Id");

                    b.HasIndex("KlientId");

                    b.HasIndex("PolaczenieId");

                    b.HasIndex("PracownikId");

                    b.ToTable("Transakcja");
                });

            modelBuilder.Entity("WebApplication7.Models.Transakcja", b =>
                {
                    b.HasOne("WebApplication7.Models.Klient", "Klient")
                        .WithMany()
                        .HasForeignKey("KlientId");

                    b.HasOne("WebApplication7.Models.Polaczenie", "Polaczenie")
                        .WithMany()
                        .HasForeignKey("PolaczenieId");

                    b.HasOne("WebApplication7.Models.Pracownik", "Pracownik")
                        .WithMany()
                        .HasForeignKey("PracownikId");
                });
#pragma warning restore 612, 618
        }
    }
}
