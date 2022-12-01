using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SqlServerContext.Migrations.Migrations
{
    public partial class Test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnsatEntityKompetenceEntity_Ansat_AnsatteAnsatID",
                table: "AnsatEntityKompetenceEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_AnsatEntityKompetenceEntity_Kompetance_KompetencerKompetenceID",
                table: "AnsatEntityKompetenceEntity");

            migrationBuilder.RenameColumn(
                name: "KompetencerKompetenceID",
                table: "AnsatEntityKompetenceEntity",
                newName: "KompetenceEntitiesKompetenceID");

            migrationBuilder.RenameColumn(
                name: "AnsatteAnsatID",
                table: "AnsatEntityKompetenceEntity",
                newName: "AnsatEntitiesAnsatID");

            migrationBuilder.RenameIndex(
                name: "IX_AnsatEntityKompetenceEntity_KompetencerKompetenceID",
                table: "AnsatEntityKompetenceEntity",
                newName: "IX_AnsatEntityKompetenceEntity_KompetenceEntitiesKompetenceID");

            migrationBuilder.AddForeignKey(
                name: "FK_AnsatEntityKompetenceEntity_Ansat_AnsatEntitiesAnsatID",
                table: "AnsatEntityKompetenceEntity",
                column: "AnsatEntitiesAnsatID",
                principalSchema: "Ansat",
                principalTable: "Ansat",
                principalColumn: "AnsatID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AnsatEntityKompetenceEntity_Kompetance_KompetenceEntitiesKompetenceID",
                table: "AnsatEntityKompetenceEntity",
                column: "KompetenceEntitiesKompetenceID",
                principalSchema: "Kompetence",
                principalTable: "Kompetance",
                principalColumn: "KompetenceID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnsatEntityKompetenceEntity_Ansat_AnsatEntitiesAnsatID",
                table: "AnsatEntityKompetenceEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_AnsatEntityKompetenceEntity_Kompetance_KompetenceEntitiesKompetenceID",
                table: "AnsatEntityKompetenceEntity");

            migrationBuilder.RenameColumn(
                name: "KompetenceEntitiesKompetenceID",
                table: "AnsatEntityKompetenceEntity",
                newName: "KompetencerKompetenceID");

            migrationBuilder.RenameColumn(
                name: "AnsatEntitiesAnsatID",
                table: "AnsatEntityKompetenceEntity",
                newName: "AnsatteAnsatID");

            migrationBuilder.RenameIndex(
                name: "IX_AnsatEntityKompetenceEntity_KompetenceEntitiesKompetenceID",
                table: "AnsatEntityKompetenceEntity",
                newName: "IX_AnsatEntityKompetenceEntity_KompetencerKompetenceID");

            migrationBuilder.AddForeignKey(
                name: "FK_AnsatEntityKompetenceEntity_Ansat_AnsatteAnsatID",
                table: "AnsatEntityKompetenceEntity",
                column: "AnsatteAnsatID",
                principalSchema: "Ansat",
                principalTable: "Ansat",
                principalColumn: "AnsatID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AnsatEntityKompetenceEntity_Kompetance_KompetencerKompetenceID",
                table: "AnsatEntityKompetenceEntity",
                column: "KompetencerKompetenceID",
                principalSchema: "Kompetence",
                principalTable: "Kompetance",
                principalColumn: "KompetenceID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
