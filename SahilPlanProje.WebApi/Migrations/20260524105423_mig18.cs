using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SahilPlanProje.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class mig18 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddForeignKey(
                name: "FK_TahakkukDefinitions_TahakkukDepartments_tahakkuk_department_id",
                table: "TahakkukDefinitions",
                column: "tahakkuk_department_id",
                principalTable: "TahakkukDepartments",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TahakkukDefinitions_TahakkukDirectorates_tahakkuk_directorate_id",
                table: "TahakkukDefinitions",
                column: "tahakkuk_directorate_id",
                principalTable: "TahakkukDirectorates",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TahakkukDefinitions_TahakkukScales_tahakkuk_scale_id",
                table: "TahakkukDefinitions",
                column: "tahakkuk_scale_id",
                principalTable: "TahakkukScales",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
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
    }
}
