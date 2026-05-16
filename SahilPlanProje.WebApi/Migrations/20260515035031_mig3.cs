using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SahilPlanProje.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TahakkukYears",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    district_id = table.Column<int>(type: "int", nullable: false),
                    year = table.Column<int>(type: "int", nullable: false),
                    is_active = table.Column<bool>(type: "bit", nullable: false),
                    create_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TahakkukYears", x => x.id);
                    table.ForeignKey(
                        name: "FK_TahakkukYears_Districts_district_id",
                        column: x => x.district_id,
                        principalTable: "Districts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TahakkukInstitutions",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tahakkuk_year_id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    is_active = table.Column<bool>(type: "bit", nullable: false),
                    create_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TahakkukInstitutions", x => x.id);
                    table.ForeignKey(
                        name: "FK_TahakkukInstitutions_TahakkukYears_tahakkuk_year_id",
                        column: x => x.tahakkuk_year_id,
                        principalTable: "TahakkukYears",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TahakkukDepartments",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tahakkuk_institution_id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    is_active = table.Column<bool>(type: "bit", nullable: false),
                    create_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TahakkukDepartments", x => x.id);
                    table.ForeignKey(
                        name: "FK_TahakkukDepartments_TahakkukInstitutions_tahakkuk_institution_id",
                        column: x => x.tahakkuk_institution_id,
                        principalTable: "TahakkukInstitutions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TahakkukDirectorates",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tahakkuk_department_id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    is_active = table.Column<bool>(type: "bit", nullable: false),
                    create_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TahakkukDirectorates", x => x.id);
                    table.ForeignKey(
                        name: "FK_TahakkukDirectorates_TahakkukDepartments_tahakkuk_department_id",
                        column: x => x.tahakkuk_department_id,
                        principalTable: "TahakkukDepartments",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TahakkukScales",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tahakkuk_directorate_id = table.Column<int>(type: "int", nullable: false),
                    scale_value = table.Column<int>(type: "int", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    is_active = table.Column<bool>(type: "bit", nullable: false),
                    create_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TahakkukScales", x => x.id);
                    table.ForeignKey(
                        name: "FK_TahakkukScales_TahakkukDirectorates_tahakkuk_directorate_id",
                        column: x => x.tahakkuk_directorate_id,
                        principalTable: "TahakkukDirectorates",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TahakkukFeeSubjects",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tahakkuk_directorate_id = table.Column<int>(type: "int", nullable: false),
                    tahakkuk_scale_id = table.Column<int>(type: "int", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    is_active = table.Column<bool>(type: "bit", nullable: false),
                    create_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TahakkukFeeSubjects", x => x.id);
                    table.ForeignKey(
                        name: "FK_TahakkukFeeSubjects_TahakkukDirectorates_tahakkuk_directorate_id",
                        column: x => x.tahakkuk_directorate_id,
                        principalTable: "TahakkukDirectorates",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TahakkukFeeSubjects_TahakkukScales_tahakkuk_scale_id",
                        column: x => x.tahakkuk_scale_id,
                        principalTable: "TahakkukScales",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "TahakkukFeeSubSubjects",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tahakkuk_fee_subject_id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TahakkukDefinitions",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tahakkuk_fee_subject_id = table.Column<int>(type: "int", nullable: false),
                    tahakkuk_fee_sub_subject_id = table.Column<int>(type: "int", nullable: true),
                    fee_text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fee_amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    has_vat = table.Column<bool>(type: "bit", nullable: false),
                    description1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    is_active = table.Column<bool>(type: "bit", nullable: false),
                    create_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TahakkukDefinitions", x => x.id);
                    table.ForeignKey(
                        name: "FK_TahakkukDefinitions_TahakkukFeeSubSubjects_tahakkuk_fee_sub_subject_id",
                        column: x => x.tahakkuk_fee_sub_subject_id,
                        principalTable: "TahakkukFeeSubSubjects",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_TahakkukDefinitions_TahakkukFeeSubjects_tahakkuk_fee_subject_id",
                        column: x => x.tahakkuk_fee_subject_id,
                        principalTable: "TahakkukFeeSubjects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TahakkukDefinitions_tahakkuk_fee_sub_subject_id",
                table: "TahakkukDefinitions",
                column: "tahakkuk_fee_sub_subject_id");

            migrationBuilder.CreateIndex(
                name: "IX_TahakkukDefinitions_tahakkuk_fee_subject_id",
                table: "TahakkukDefinitions",
                column: "tahakkuk_fee_subject_id");

            migrationBuilder.CreateIndex(
                name: "IX_TahakkukDepartments_tahakkuk_institution_id",
                table: "TahakkukDepartments",
                column: "tahakkuk_institution_id");

            migrationBuilder.CreateIndex(
                name: "IX_TahakkukDirectorates_tahakkuk_department_id",
                table: "TahakkukDirectorates",
                column: "tahakkuk_department_id");

            migrationBuilder.CreateIndex(
                name: "IX_TahakkukFeeSubjects_tahakkuk_directorate_id",
                table: "TahakkukFeeSubjects",
                column: "tahakkuk_directorate_id");

            migrationBuilder.CreateIndex(
                name: "IX_TahakkukFeeSubjects_tahakkuk_scale_id",
                table: "TahakkukFeeSubjects",
                column: "tahakkuk_scale_id");

            migrationBuilder.CreateIndex(
                name: "IX_TahakkukFeeSubSubjects_tahakkuk_fee_subject_id",
                table: "TahakkukFeeSubSubjects",
                column: "tahakkuk_fee_subject_id");

            migrationBuilder.CreateIndex(
                name: "IX_TahakkukInstitutions_tahakkuk_year_id",
                table: "TahakkukInstitutions",
                column: "tahakkuk_year_id");

            migrationBuilder.CreateIndex(
                name: "IX_TahakkukScales_tahakkuk_directorate_id",
                table: "TahakkukScales",
                column: "tahakkuk_directorate_id");

            migrationBuilder.CreateIndex(
                name: "IX_TahakkukYears_district_id",
                table: "TahakkukYears",
                column: "district_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TahakkukDefinitions");

            migrationBuilder.DropTable(
                name: "TahakkukFeeSubSubjects");

            migrationBuilder.DropTable(
                name: "TahakkukFeeSubjects");

            migrationBuilder.DropTable(
                name: "TahakkukScales");

            migrationBuilder.DropTable(
                name: "TahakkukDirectorates");

            migrationBuilder.DropTable(
                name: "TahakkukDepartments");

            migrationBuilder.DropTable(
                name: "TahakkukInstitutions");

            migrationBuilder.DropTable(
                name: "TahakkukYears");
        }
    }
}
