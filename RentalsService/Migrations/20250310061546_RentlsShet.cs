using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentalsService.Migrations
{
    /// <inheritdoc />
    public partial class RentlsShet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Rentals",
                table: "Rentals");

            migrationBuilder.RenameTable(
                name: "Rentals",
                newName: "RentalsData");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RentalsData",
                table: "RentalsData",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RentalsData",
                table: "RentalsData");

            migrationBuilder.RenameTable(
                name: "RentalsData",
                newName: "Rentals");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rentals",
                table: "Rentals",
                column: "Id");
        }
    }
}
