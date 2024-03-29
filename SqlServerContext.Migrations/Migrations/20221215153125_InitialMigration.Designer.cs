﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SqlServerContext;

#nullable disable

namespace SqlServerContext.Migrations.Migrations
{
    [DbContext(typeof(ServerContext))]
    [Migration("20221215153125_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AnsatEntityKompetenceEntity", b =>
                {
                    b.Property<int>("AnsatEntitiesAnsatID")
                        .HasColumnType("int");

                    b.Property<int>("KompetenceEntitiesKompetenceID")
                        .HasColumnType("int");

                    b.HasKey("AnsatEntitiesAnsatID", "KompetenceEntitiesKompetenceID");

                    b.HasIndex("KompetenceEntitiesKompetenceID");

                    b.ToTable("AnsatEntityKompetenceEntity");
                });

            modelBuilder.Entity("Domain.Booking.BookingModel.BookingEntity", b =>
                {
                    b.Property<int>("BookingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingID"), 1L, 1);

                    b.Property<int>("AnsatID")
                        .HasColumnType("int");

                    b.Property<string>("BookingName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OpgaveID")
                        .HasColumnType("int");

                    b.Property<int>("ProjektID")
                        .HasColumnType("int");

                    b.Property<DateTime>("SlutDato")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDato")
                        .HasColumnType("datetime2");

                    b.HasKey("BookingID");

                    b.ToTable("Booking", "Booking");
                });

            modelBuilder.Entity("Domain.Opgave.OpgaveModel.OpgaveEntity", b =>
                {
                    b.Property<int>("OpgaveID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OpgaveID"), 1L, 1);

                    b.Property<int>("KompetenceID")
                        .HasColumnType("int");

                    b.Property<string>("OpgaveName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OpgaveType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OpgaveID");

                    b.ToTable("Opgave", "Opgave");
                });

            modelBuilder.Entity("Domain.Projekt.ProjektModel.ProjektEntity", b =>
                {
                    b.Property<int>("ProjektID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProjektID"), 1L, 1);

                    b.Property<DateTime>("EstimeretSlutDato")
                        .HasColumnType("datetime2");

                    b.Property<int?>("KIDKundeID")
                        .HasColumnType("int");

                    b.Property<int>("KundeID")
                        .HasColumnType("int");

                    b.Property<DateTime>("OprettelsesDato")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProjektName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProjektID");

                    b.HasIndex("KIDKundeID");

                    b.ToTable("Projekt", "Projekt");
                });

            modelBuilder.Entity("Domain.StamData.Ansat.AnsatModel.AnsatEntity", b =>
                {
                    b.Property<int>("AnsatID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AnsatID"), 1L, 1);

                    b.Property<string>("AnsatName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnsatTelefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnsatType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AnsatID");

                    b.ToTable("Ansat", "Ansat");
                });

            modelBuilder.Entity("Domain.StamData.Kompetencer.KompetenceModel.KompetenceEntity", b =>
                {
                    b.Property<int>("KompetenceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KompetenceID"), 1L, 1);

                    b.Property<string>("KompetenceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("KompetenceID");

                    b.ToTable("Kompetance", "Kompetence");
                });

            modelBuilder.Entity("Domain.StamData.Kunde.KundeModel.KundeEntity", b =>
                {
                    b.Property<int>("KundeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KundeID"), 1L, 1);

                    b.Property<string>("KUserID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KundeAdresse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KundeCVR")
                        .HasColumnType("int");

                    b.Property<string>("KundeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KundePostNr")
                        .HasColumnType("int");

                    b.HasKey("KundeID");

                    b.ToTable("Kunde", "Kunde");
                });

            modelBuilder.Entity("AnsatEntityKompetenceEntity", b =>
                {
                    b.HasOne("Domain.StamData.Ansat.AnsatModel.AnsatEntity", null)
                        .WithMany()
                        .HasForeignKey("AnsatEntitiesAnsatID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.StamData.Kompetencer.KompetenceModel.KompetenceEntity", null)
                        .WithMany()
                        .HasForeignKey("KompetenceEntitiesKompetenceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Projekt.ProjektModel.ProjektEntity", b =>
                {
                    b.HasOne("Domain.StamData.Kunde.KundeModel.KundeEntity", "KID")
                        .WithMany("ProjektEntities")
                        .HasForeignKey("KIDKundeID");

                    b.Navigation("KID");
                });

            modelBuilder.Entity("Domain.StamData.Kunde.KundeModel.KundeEntity", b =>
                {
                    b.Navigation("ProjektEntities");
                });
#pragma warning restore 612, 618
        }
    }
}
