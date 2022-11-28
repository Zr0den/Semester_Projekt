﻿// <auto-generated />
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
    [Migration("20221124131107_Ansatfix")]
    partial class Ansatfix
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("StamData.Domain.Ansat.AnsatModel.AnsatEntity", b =>
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

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AnsatID");

                    b.ToTable("Ansat", "Ansat");
                });

            modelBuilder.Entity("StamData.Domain.Kompetencer.KompetenceModel.KompetenceEntity", b =>
                {
                    b.Property<int>("KompetenceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KompetenceID"), 1L, 1);

                    b.Property<int>("AnsatID")
                        .HasColumnType("int");

                    b.Property<string>("KompetenceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KompetenceType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KompetenceID");

                    b.HasIndex("AnsatID");

                    b.ToTable("Kompetance", "Kompetence");
                });

            modelBuilder.Entity("StamData.Domain.Kompetencer.KompetenceModel.KompetenceEntity", b =>
                {
                    b.HasOne("StamData.Domain.Ansat.AnsatModel.AnsatEntity", "Ansat")
                        .WithMany()
                        .HasForeignKey("AnsatID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ansat");
                });
#pragma warning restore 612, 618
        }
    }
}
