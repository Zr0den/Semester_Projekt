using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SqlServerContext.Migrations.Migrations
{
    public partial class KompetenceMaybe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kompetance_Ansat_AnsatID",
                schema: "Kompetence",
                table: "Kompetance");

            migrationBuilder.DropIndex(
                name: "IX_Kompetance_AnsatID",
                schema: "Kompetence",
                table: "Kompetance");

            migrationBuilder.DropColumn(
                name: "AnsatID",
                schema: "Kompetence",
                table: "Kompetance");

            migrationBuilder.DropColumn(
                name: "KompetenceType",
                schema: "Kompetence",
                table: "Kompetance");

            migrationBuilder.CreateTable(
                name: "AnsatEntityKompetenceEntity",
                columns: table => new
                {
                    AnsatteAnsatID = table.Column<int>(type: "int", nullable: false),
                    KompetencerKompetenceID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnsatEntityKompetenceEntity", x => new { x.AnsatteAnsatID, x.KompetencerKompetenceID });
                    table.ForeignKey(
                        name: "FK_AnsatEntityKompetenceEntity_Ansat_AnsatteAnsatID",
                        column: x => x.AnsatteAnsatID,
                        principalSchema: "Ansat",
                        principalTable: "Ansat",
                        principalColumn: "AnsatID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnsatEntityKompetenceEntity_Kompetance_KompetencerKompetenceID",
                        column: x => x.KompetencerKompetenceID,
                        principalSchema: "Kompetence",
                        principalTable: "Kompetance",
                        principalColumn: "KompetenceID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnsatEntityKompetenceEntity_KompetencerKompetenceID",
                table: "AnsatEntityKompetenceEntity",
                column: "KompetencerKompetenceID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnsatEntityKompetenceEntity");

            migrationBuilder.AddColumn<int>(
                name: "AnsatID",
                schema: "Kompetence",
                table: "Kompetance",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "KompetenceType",
                schema: "Kompetence",
                table: "Kompetance",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Kompetance_AnsatID",
                schema: "Kompetence",
                table: "Kompetance",
                column: "AnsatID");

            migrationBuilder.AddForeignKey(
                name: "FK_Kompetance_Ansat_AnsatID",
                schema: "Kompetence",
                table: "Kompetance",
                column: "AnsatID",
                principalSchema: "Ansat",
                principalTable: "Ansat",
                principalColumn: "AnsatID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
