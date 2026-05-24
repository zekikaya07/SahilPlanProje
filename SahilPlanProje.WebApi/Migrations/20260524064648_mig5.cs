using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SahilPlanProje.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class mig5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "tahakkuk_institution_id",
                table: "TahakkukDirectorates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TahakkukDirectorates_tahakkuk_institution_id",
                table: "TahakkukDirectorates",
                column: "tahakkuk_institution_id");

            migrationBuilder.AddForeignKey(
                name: "FK_TahakkukDirectorates_TahakkukInstitutions_tahakkuk_institution_id",
                table: "TahakkukDirectorates",
                column: "tahakkuk_institution_id",
                principalTable: "TahakkukInstitutions",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TahakkukDirectorates_TahakkukInstitutions_tahakkuk_institution_id",
                table: "TahakkukDirectorates");

            migrationBuilder.DropIndex(
                name: "IX_TahakkukDirectorates_tahakkuk_institution_id",
                table: "TahakkukDirectorates");

            migrationBuilder.DropColumn(
                name: "tahakkuk_institution_id",
                table: "TahakkukDirectorates");
        }
    }
}
