using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SahilPlanProje.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Districts_Cities_cityid",
                table: "Districts");

            migrationBuilder.DropIndex(
                name: "IX_Districts_cityid",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "cityid",
                table: "Districts");

            migrationBuilder.CreateIndex(
                name: "IX_Districts_city_id",
                table: "Districts",
                column: "city_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Districts_Cities_city_id",
                table: "Districts",
                column: "city_id",
                principalTable: "Cities",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Districts_Cities_city_id",
                table: "Districts");

            migrationBuilder.DropIndex(
                name: "IX_Districts_city_id",
                table: "Districts");

            migrationBuilder.AddColumn<int>(
                name: "cityid",
                table: "Districts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Districts_cityid",
                table: "Districts",
                column: "cityid");

            migrationBuilder.AddForeignKey(
                name: "FK_Districts_Cities_cityid",
                table: "Districts",
                column: "cityid",
                principalTable: "Cities",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
