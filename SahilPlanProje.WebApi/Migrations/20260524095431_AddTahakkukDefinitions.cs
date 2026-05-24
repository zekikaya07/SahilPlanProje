using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SahilPlanProje.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class AddTahakkukDefinitions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TahakkukDefinitions",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    has_vat = table.Column<bool>(type: "bit", nullable: false),
                    city_id = table.Column<int>(type: "int", nullable: false),
                    district_id = table.Column<int>(type: "int", nullable: false),
                    tahakkuk_year_id = table.Column<int>(type: "int", nullable: false),
                    tahakkuk_institution_id = table.Column<int>(type: "int", nullable: false),
                    tahakkuk_fee_subject_id = table.Column<int>(type: "int", nullable: false),
                    tahakkuk_fee_sub_subject_id = table.Column<int>(type: "int", nullable: false),
                    is_active = table.Column<bool>(type: "bit", nullable: false),
                    create_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TahakkukDefinitions", x => x.id);
                    table.ForeignKey(
                        name: "FK_TahakkukDefinitions_Cities_city_id",
                        column: x => x.city_id,
                        principalTable: "Cities",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TahakkukDefinitions_Districts_district_id",
                        column: x => x.district_id,
                        principalTable: "Districts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TahakkukDefinitions_TahakkukFeeSubSubjects_tahakkuk_fee_sub_subject_id",
                        column: x => x.tahakkuk_fee_sub_subject_id,
                        principalTable: "TahakkukFeeSubSubjects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TahakkukDefinitions_TahakkukFeeSubjects_tahakkuk_fee_subject_id",
                        column: x => x.tahakkuk_fee_subject_id,
                        principalTable: "TahakkukFeeSubjects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TahakkukDefinitions_TahakkukInstitutions_tahakkuk_institution_id",
                        column: x => x.tahakkuk_institution_id,
                        principalTable: "TahakkukInstitutions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TahakkukDefinitions_TahakkukYears_tahakkuk_year_id",
                        column: x => x.tahakkuk_year_id,
                        principalTable: "TahakkukYears",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TahakkukDefinitions_city_id",
                table: "TahakkukDefinitions",
                column: "city_id");

            migrationBuilder.CreateIndex(
                name: "IX_TahakkukDefinitions_district_id",
                table: "TahakkukDefinitions",
                column: "district_id");

            migrationBuilder.CreateIndex(
                name: "IX_TahakkukDefinitions_tahakkuk_fee_sub_subject_id",
                table: "TahakkukDefinitions",
                column: "tahakkuk_fee_sub_subject_id");

            migrationBuilder.CreateIndex(
                name: "IX_TahakkukDefinitions_tahakkuk_fee_subject_id",
                table: "TahakkukDefinitions",
                column: "tahakkuk_fee_subject_id");

            migrationBuilder.CreateIndex(
                name: "IX_TahakkukDefinitions_tahakkuk_institution_id",
                table: "TahakkukDefinitions",
                column: "tahakkuk_institution_id");

            migrationBuilder.CreateIndex(
                name: "IX_TahakkukDefinitions_tahakkuk_year_id",
                table: "TahakkukDefinitions",
                column: "tahakkuk_year_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TahakkukDefinitions");
        }
    }
}
