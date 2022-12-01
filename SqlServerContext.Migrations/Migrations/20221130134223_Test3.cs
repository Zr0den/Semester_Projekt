using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SqlServerContext.Migrations.Migrations
{
    public partial class Test3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnsatEntityKompetenceEntity");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
