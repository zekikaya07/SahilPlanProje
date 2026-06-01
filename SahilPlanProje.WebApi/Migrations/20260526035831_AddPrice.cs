using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SahilPlanProje.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class AddPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "price2",
                table: "TahakkukDefinitions",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "price3",
                table: "TahakkukDefinitions",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "price4",
                table: "TahakkukDefinitions",
                type: "decimal(18,2)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "price2",
                table: "TahakkukDefinitions");

            migrationBuilder.DropColumn(
                name: "price3",
                table: "TahakkukDefinitions");

            migrationBuilder.DropColumn(
                name: "price4",
                table: "TahakkukDefinitions");
        }
    }
}
