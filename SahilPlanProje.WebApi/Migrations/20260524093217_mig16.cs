using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SahilPlanProje.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class mig16 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TahakkukDirectorates_TahakkukInstitutions_tahakkuk_institution_id",
                table: "TahakkukDirectorates");

            migrationBuilder.CreateTable(
                name: "TahakkukFeeSubSubjects",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tahakkuk_fee_subject_id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    is_active = table.Column<bool>(type: "bit", nullable: false),
                    create_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TahakkukFeeSubSubjects", x => x.id);
                    table.ForeignKey(
                        name: "FK_TahakkukFeeSubSubjects_TahakkukFeeSubjects_tahakkuk_fee_subject_id",
                        column: x => x.tahakkuk_fee_subject_id,
                        principalTable: "TahakkukFeeSubjects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TahakkukFeeSubSubjects_tahakkuk_fee_subject_id",
                table: "TahakkukFeeSubSubjects",
                column: "tahakkuk_fee_subject_id");

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

            migrationBuilder.DropTable(
                name: "TahakkukFeeSubSubjects");

            migrationBuilder.AddForeignKey(
                name: "FK_TahakkukDirectorates_TahakkukInstitutions_tahakkuk_institution_id",
                table: "TahakkukDirectorates",
                column: "tahakkuk_institution_id",
                principalTable: "TahakkukInstitutions",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
