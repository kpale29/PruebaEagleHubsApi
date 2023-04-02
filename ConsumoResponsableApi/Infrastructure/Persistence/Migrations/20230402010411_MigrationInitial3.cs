using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsumoResponsableApi.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class MigrationInitial3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "description",
                table: "Consumptions");

            migrationBuilder.DropColumn(
                name: "name",
                table: "Consumptions");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "Consumptions",
                type: "character varying(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                comment: "Catalogue item description");

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "Consumptions",
                type: "character varying(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                comment: "Catalogue item name");
        }
    }
}
