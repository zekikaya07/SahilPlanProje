using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SahilPlanProje.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class mig17 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "tahakkuk_department_id",
                table: "TahakkukDefinitions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tahakkuk_directorate_id",
                table: "TahakkukDefinitions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tahakkuk_scale_id",
                table: "TahakkukDefinitions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TahakkukDefinitions_tahakkuk_department_id",
                table: "TahakkukDefinitions",
                column: "tahakkuk_department_id");

            migrationBuilder.CreateIndex(
                name: "IX_TahakkukDefinitions_tahakkuk_directorate_id",
                table: "TahakkukDefinitions",
                column: "tahakkuk_directorate_id");

            migrationBuilder.CreateIndex(
                name: "IX_TahakkukDefinitions_tahakkuk_scale_id",
                table: "TahakkukDefinitions",
                column: "tahakkuk_scale_id");

            migrationBuilder.AddForeignKey(
                name: "FK_TahakkukDefinitions_TahakkukDepartments_tahakkuk_department_id",
                table: "TahakkukDefinitions",
                column: "tahakkuk_department_id",
                principalTable: "TahakkukDepartments",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_TahakkukDefinitions_TahakkukDirectorates_tahakkuk_directorate_id",
                table: "TahakkukDefinitions",
                column: "tahakkuk_directorate_id",
                principalTable: "TahakkukDirectorates",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_TahakkukDefinitions_TahakkukScales_tahakkuk_scale_id",
                table: "TahakkukDefinitions",
                column: "tahakkuk_scale_id",
                principalTable: "TahakkukScales",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TahakkukDefinitions_TahakkukDepartments_tahakkuk_department_id",
                table: "TahakkukDefinitions");

            migrationBuilder.DropForeignKey(
                name: "FK_TahakkukDefinitions_TahakkukDirectorates_tahakkuk_directorate_id",
                table: "TahakkukDefinitions");

            migrationBuilder.DropForeignKey(
                name: "FK_TahakkukDefinitions_TahakkukScales_tahakkuk_scale_id",
                table: "TahakkukDefinitions");

            migrationBuilder.DropIndex(
                name: "IX_TahakkukDefinitions_tahakkuk_department_id",
                table: "TahakkukDefinitions");

            migrationBuilder.DropIndex(
                name: "IX_TahakkukDefinitions_tahakkuk_directorate_id",
                table: "TahakkukDefinitions");

            migrationBuilder.DropIndex(
                name: "IX_TahakkukDefinitions_tahakkuk_scale_id",
                table: "TahakkukDefinitions");

            migrationBuilder.DropColumn(
                name: "tahakkuk_department_id",
                table: "TahakkukDefinitions");

            migrationBuilder.DropColumn(
                name: "tahakkuk_directorate_id",
                table: "TahakkukDefinitions");

            migrationBuilder.DropColumn(
                name: "tahakkuk_scale_id",
                table: "TahakkukDefinitions");
        }
    }
}
