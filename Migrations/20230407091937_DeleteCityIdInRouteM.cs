using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IntercityTransportation.Migrations
{
    /// <inheritdoc />
    public partial class DeleteCityIdInRouteM : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Routes_Cities_CityId",
                table: "Routes");

            migrationBuilder.DropIndex(
                name: "IX_Routes_CityId",
                table: "Routes");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Routes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Routes",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Routes_CityId",
                table: "Routes",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Routes_Cities_CityId",
                table: "Routes",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id");
        }
    }
}
