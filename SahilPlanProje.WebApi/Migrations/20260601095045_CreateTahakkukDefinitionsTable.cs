using Microsoft.EntityFrameworkCore.Migrations;
using System;
#nullable disable

namespace SahilPlanProje.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class CreateTahakkukDefinitionsTable : Migration
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
                    price2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    price3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    price4 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),

                    has_vat = table.Column<bool>(type: "bit", nullable: false),

                    city_id = table.Column<int>(type: "int", nullable: false),
                    district_id = table.Column<int>(type: "int", nullable: true),
                    tahakkuk_year_id = table.Column<int>(type: "int", nullable: false),
                    tahakkuk_institution_id = table.Column<int>(type: "int", nullable: false),
                    tahakkuk_fee_subject_id = table.Column<int>(type: "int", nullable: false),
                    tahakkuk_fee_sub_subject_id = table.Column<int>(type: "int", nullable: true),
                    tahakkuk_scale_id = table.Column<int>(type: "int", nullable: true),
                    tahakkuk_department_id = table.Column<int>(type: "int", nullable: true),
                    tahakkuk_directorate_id = table.Column<int>(type: "int", nullable: true),

                    is_active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    create_date = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TahakkukDefinitions", x => x.id);

                    table.ForeignKey(
                        name: "FK_TahakkukDefinitions_Cities_city_id",
                        column: x => x.city_id,
                        principalTable: "Cities",
                        principalColumn: "id");

                    table.ForeignKey(
                        name: "FK_TahakkukDefinitions_Districts_district_id",
                        column: x => x.district_id,
                        principalTable: "Districts",
                        principalColumn: "id");

                    table.ForeignKey(
                        name: "FK_TahakkukDefinitions_TahakkukYears_tahakkuk_year_id",
                        column: x => x.tahakkuk_year_id,
                        principalTable: "TahakkukYears",
                        principalColumn: "id");

                    table.ForeignKey(
                        name: "FK_TahakkukDefinitions_TahakkukInstitutions_tahakkuk_institution_id",
                        column: x => x.tahakkuk_institution_id,
                        principalTable: "TahakkukInstitutions",
                        principalColumn: "id");

                    table.ForeignKey(
                        name: "FK_TahakkukDefinitions_TahakkukFeeSubjects_tahakkuk_fee_subject_id",
                        column: x => x.tahakkuk_fee_subject_id,
                        principalTable: "TahakkukFeeSubjects",
                        principalColumn: "id");

                    table.ForeignKey(
                        name: "FK_TahakkukDefinitions_TahakkukFeeSubSubjects_tahakkuk_fee_sub_subject_id",
                        column: x => x.tahakkuk_fee_sub_subject_id,
                        principalTable: "TahakkukFeeSubSubjects",
                        principalColumn: "id");

                    table.ForeignKey(
                        name: "FK_TahakkukDefinitions_TahakkukScales_tahakkuk_scale_id",
                        column: x => x.tahakkuk_scale_id,
                        principalTable: "TahakkukScales",
                        principalColumn: "id");

                    table.ForeignKey(
                        name: "FK_TahakkukDefinitions_TahakkukDepartments_tahakkuk_department_id",
                        column: x => x.tahakkuk_department_id,
                        principalTable: "TahakkukDepartments",
                        principalColumn: "id");

                    table.ForeignKey(
                        name: "FK_TahakkukDefinitions_TahakkukDirectorates_tahakkuk_directorate_id",
                        column: x => x.tahakkuk_directorate_id,
                        principalTable: "TahakkukDirectorates",
                        principalColumn: "id");
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
                name: "IX_TahakkukDefinitions_tahakkuk_year_id",
                table: "TahakkukDefinitions",
                column: "tahakkuk_year_id");

            migrationBuilder.CreateIndex(
                name: "IX_TahakkukDefinitions_tahakkuk_institution_id",
                table: "TahakkukDefinitions",
                column: "tahakkuk_institution_id");

            migrationBuilder.CreateIndex(
                name: "IX_TahakkukDefinitions_tahakkuk_fee_subject_id",
                table: "TahakkukDefinitions",
                column: "tahakkuk_fee_subject_id");

            migrationBuilder.CreateIndex(
                name: "IX_TahakkukDefinitions_tahakkuk_fee_sub_subject_id",
                table: "TahakkukDefinitions",
                column: "tahakkuk_fee_sub_subject_id");

            migrationBuilder.CreateIndex(
                name: "IX_TahakkukDefinitions_tahakkuk_scale_id",
                table: "TahakkukDefinitions",
                column: "tahakkuk_scale_id");

            migrationBuilder.CreateIndex(
                name: "IX_TahakkukDefinitions_tahakkuk_department_id",
                table: "TahakkukDefinitions",
                column: "tahakkuk_department_id");

            migrationBuilder.CreateIndex(
                name: "IX_TahakkukDefinitions_tahakkuk_directorate_id",
                table: "TahakkukDefinitions",
                column: "tahakkuk_directorate_id");
        }
        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TahakkukDefinitions");
        }
    }
}
