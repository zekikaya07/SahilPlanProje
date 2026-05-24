using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SahilPlanProje.WebApi.Migrations
{
    public partial class mig12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TahakkukDirectorates",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    tahakkuk_institution_id = table.Column<int>(type: "int", nullable: false),
                    is_active = table.Column<bool>(type: "bit", nullable: false),
                    create_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TahakkukDirectorates", x => x.id);

                    table.ForeignKey(
                        name: "FK_TahakkukDirectorates_TahakkukInstitutions_tahakkuk_institution_id",
                        column: x => x.tahakkuk_institution_id,
                        principalTable: "TahakkukInstitutions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TahakkukDirectorates_tahakkuk_institution_id",
                table: "TahakkukDirectorates",
                column: "tahakkuk_institution_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TahakkukDirectorates");
        }
    }
}