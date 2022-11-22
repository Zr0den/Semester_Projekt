using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SqlServerContext.Migrations.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Ansat");

            migrationBuilder.EnsureSchema(
                name: "Kompetence");

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
                    AnsatID = table.Column<int>(type: "int", nullable: false),
                    KompetenceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KompetenceType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kompetance", x => x.KompetenceID);
                    table.ForeignKey(
                        name: "FK_Kompetance_Ansat_AnsatID",
                        column: x => x.AnsatID,
                        principalSchema: "Ansat",
                        principalTable: "Ansat",
                        principalColumn: "AnsatID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kompetance_AnsatID",
                schema: "Kompetence",
                table: "Kompetance",
                column: "AnsatID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kompetance",
                schema: "Kompetence");

            migrationBuilder.DropTable(
                name: "Ansat",
                schema: "Ansat");
        }
    }
}
