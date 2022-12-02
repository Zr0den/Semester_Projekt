using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SqlServerContext.Migrations.Migrations
{
    public partial class ProjektTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Projekt");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projekt",
                schema: "Projekt");
        }
    }
}
