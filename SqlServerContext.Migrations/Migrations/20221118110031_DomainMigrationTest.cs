using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SqlServerContext.Migrations.Migrations
{
    public partial class DomainMigrationTest : Migration
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
                    AnsatKey = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnsatId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnsatName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnsatTelefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnsatEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnsatType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ansat", x => x.AnsatKey);
                });

            migrationBuilder.CreateTable(
                name: "Kompetance",
                schema: "Kompetence",
                columns: table => new
                {
                    KompetenceKey = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KompetenceId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KompetenceType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kompetance", x => x.KompetenceKey);
                });

            migrationBuilder.CreateTable(
                name: "AnsatEntityKompetenceEntity",
                columns: table => new
                {
                    AnsatteEntitiesAnsatKey = table.Column<int>(type: "int", nullable: false),
                    KompetenceListKompetenceKey = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnsatEntityKompetenceEntity", x => new { x.AnsatteEntitiesAnsatKey, x.KompetenceListKompetenceKey });
                    table.ForeignKey(
                        name: "FK_AnsatEntityKompetenceEntity_Ansat_AnsatteEntitiesAnsatKey",
                        column: x => x.AnsatteEntitiesAnsatKey,
                        principalSchema: "Ansat",
                        principalTable: "Ansat",
                        principalColumn: "AnsatKey",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnsatEntityKompetenceEntity_Kompetance_KompetenceListKompetenceKey",
                        column: x => x.KompetenceListKompetenceKey,
                        principalSchema: "Kompetence",
                        principalTable: "Kompetance",
                        principalColumn: "KompetenceKey",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnsatEntityKompetenceEntity_KompetenceListKompetenceKey",
                table: "AnsatEntityKompetenceEntity",
                column: "KompetenceListKompetenceKey");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnsatEntityKompetenceEntity");

            migrationBuilder.DropTable(
                name: "Ansat",
                schema: "Ansat");

            migrationBuilder.DropTable(
                name: "Kompetance",
                schema: "Kompetence");
        }
    }
}
