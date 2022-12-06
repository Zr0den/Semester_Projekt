﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SqlServerContext.Migrations.Migrations
{
    public partial class NameOfTheegege : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Ansat");

            migrationBuilder.EnsureSchema(
                name: "Kompetence");

            migrationBuilder.EnsureSchema(
                name: "Kunde");

            migrationBuilder.EnsureSchema(
                name: "Projekt");

            migrationBuilder.CreateTable(
                name: "Ansat",
                schema: "Ansat",
                columns: table => new
                {
                    AnsatID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnsatName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnsatTelefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnsatType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ansat", x => x.AnsatID);
                });

            migrationBuilder.CreateTable(
                name: "Kompetance",
                schema: "Kompetence",
                columns: table => new
                {
                    KompetenceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KompetenceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kompetance", x => x.KompetenceID);
                });

            migrationBuilder.CreateTable(
                name: "Kunde",
                schema: "Kunde",
                columns: table => new
                {
                    KundeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KundeUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KundeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KundeAdresse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KundePostNr = table.Column<int>(type: "int", nullable: false),
                    KundeCVR = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kunde", x => x.KundeID);
                });

            migrationBuilder.CreateTable(
                name: "Projekt",
                schema: "Projekt",
                columns: table => new
                {
                    ProjektID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjektName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SælgerID = table.Column<int>(type: "int", nullable: false),
                    KundeID = table.Column<int>(type: "int", nullable: false),
                    OprettelsesDato = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstimeretSlutDato = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projekt", x => x.ProjektID);
                });

            migrationBuilder.CreateTable(
                name: "AnsatEntityKompetenceEntity",
                columns: table => new
                {
                    AnsatEntitiesAnsatID = table.Column<int>(type: "int", nullable: false),
                    KompetenceEntitiesKompetenceID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnsatEntityKompetenceEntity", x => new { x.AnsatEntitiesAnsatID, x.KompetenceEntitiesKompetenceID });
                    table.ForeignKey(
                        name: "FK_AnsatEntityKompetenceEntity_Ansat_AnsatEntitiesAnsatID",
                        column: x => x.AnsatEntitiesAnsatID,
                        principalSchema: "Ansat",
                        principalTable: "Ansat",
                        principalColumn: "AnsatID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnsatEntityKompetenceEntity_Kompetance_KompetenceEntitiesKompetenceID",
                        column: x => x.KompetenceEntitiesKompetenceID,
                        principalSchema: "Kompetence",
                        principalTable: "Kompetance",
                        principalColumn: "KompetenceID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnsatEntityKompetenceEntity_KompetenceEntitiesKompetenceID",
                table: "AnsatEntityKompetenceEntity",
                column: "KompetenceEntitiesKompetenceID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnsatEntityKompetenceEntity");

            migrationBuilder.DropTable(
                name: "Kunde",
                schema: "Kunde");

            migrationBuilder.DropTable(
                name: "Projekt",
                schema: "Projekt");

            migrationBuilder.DropTable(
                name: "Ansat",
                schema: "Ansat");

            migrationBuilder.DropTable(
                name: "Kompetance",
                schema: "Kompetence");
        }
    }
}