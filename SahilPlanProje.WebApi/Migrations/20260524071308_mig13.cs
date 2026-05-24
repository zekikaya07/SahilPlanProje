using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SahilPlanProje.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class mig13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "tahakkuk_department_id",
                table: "TahakkukDirectorates",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TahakkukDirectorates_tahakkuk_department_id",
                table: "TahakkukDirectorates",
                column: "tahakkuk_department_id");

            migrationBuilder.AddForeignKey(
                name: "FK_TahakkukDirectorates_TahakkukDepartments_tahakkuk_department_id",
                table: "TahakkukDirectorates",
                column: "tahakkuk_department_id",
                principalTable: "TahakkukDepartments",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TahakkukDirectorates_TahakkukDepartments_tahakkuk_department_id",
                table: "TahakkukDirectorates");

            migrationBuilder.DropIndex(
                name: "IX_TahakkukDirectorates_tahakkuk_department_id",
                table: "TahakkukDirectorates");

            migrationBuilder.DropColumn(
                name: "tahakkuk_department_id",
                table: "TahakkukDirectorates");
        }
    }
}
