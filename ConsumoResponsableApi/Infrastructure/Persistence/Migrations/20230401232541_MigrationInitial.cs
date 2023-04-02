using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ConsumoResponsableApi.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class MigrationInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false, comment: "Entity Primary Key")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "Creation date"),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "Update date"),
                    active = table.Column<bool>(type: "boolean", nullable: false, comment: "Status of register"),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "Delete date"),
                    name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false, comment: "Catalogue item name"),
                    description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false, comment: "Catalogue item description")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Emissions",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false, comment: "Entity Primary Key")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "Creation date"),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "Update date"),
                    active = table.Column<bool>(type: "boolean", nullable: false, comment: "Status of register"),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "Delete date"),
                    name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false, comment: "Catalogue item name"),
                    description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false, comment: "Catalogue item description")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emissions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "UnitMeasures",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false, comment: "Entity Primary Key")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "Creation date"),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "Update date"),
                    active = table.Column<bool>(type: "boolean", nullable: false, comment: "Status of register"),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "Delete date"),
                    name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false, comment: "Catalogue item name"),
                    description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false, comment: "Catalogue item description")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitMeasures", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false, comment: "Entity Primary Key")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    company_id = table.Column<int>(type: "integer", nullable: false, comment: "Company Foreign key"),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "Creation date"),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "Update date"),
                    active = table.Column<bool>(type: "boolean", nullable: false, comment: "Status of register"),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "Delete date"),
                    name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false, comment: "Catalogue item name"),
                    description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false, comment: "Catalogue item description")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.id);
                    table.ForeignKey(
                        name: "FK_Locations_Companies_company_id",
                        column: x => x.company_id,
                        principalTable: "Companies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConsumptionTypes",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false, comment: "Entity Primary Key")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    petroleum_derivative = table.Column<bool>(type: "boolean", nullable: false, comment: "Petroleum derivative item"),
                    emission_id = table.Column<int>(type: "integer", nullable: false, comment: "Emission Foreign key"),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "Creation date"),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "Update date"),
                    active = table.Column<bool>(type: "boolean", nullable: false, comment: "Status of register"),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "Delete date"),
                    name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false, comment: "Catalogue item name"),
                    description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false, comment: "Catalogue item description")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsumptionTypes", x => x.id);
                    table.ForeignKey(
                        name: "FK_ConsumptionTypes_Emissions_emission_id",
                        column: x => x.emission_id,
                        principalTable: "Emissions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Consumptions",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false, comment: "Entity Primary Key")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    quantity = table.Column<int>(type: "integer", nullable: false, comment: "Consumption quantity"),
                    consumption_type_id = table.Column<int>(type: "integer", nullable: false, comment: "Consumption Type Foreign key"),
                    unit_measure_id = table.Column<int>(type: "integer", nullable: false, comment: "Unit Measure Foreign key"),
                    location_id = table.Column<int>(type: "integer", nullable: false, comment: "Location Foreign key"),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "Creation date"),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "Update date"),
                    active = table.Column<bool>(type: "boolean", nullable: false, comment: "Status of register"),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "Delete date"),
                    name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false, comment: "Catalogue item name"),
                    description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false, comment: "Catalogue item description")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consumptions", x => x.id);
                    table.ForeignKey(
                        name: "FK_Consumptions_ConsumptionTypes_consumption_type_id",
                        column: x => x.consumption_type_id,
                        principalTable: "ConsumptionTypes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Consumptions_Locations_location_id",
                        column: x => x.location_id,
                        principalTable: "Locations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Consumptions_UnitMeasures_unit_measure_id",
                        column: x => x.unit_measure_id,
                        principalTable: "UnitMeasures",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Consumptions_consumption_type_id",
                table: "Consumptions",
                column: "consumption_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_Consumptions_location_id",
                table: "Consumptions",
                column: "location_id");

            migrationBuilder.CreateIndex(
                name: "IX_Consumptions_unit_measure_id",
                table: "Consumptions",
                column: "unit_measure_id");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumptionTypes_emission_id",
                table: "ConsumptionTypes",
                column: "emission_id");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_company_id",
                table: "Locations",
                column: "company_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Consumptions");

            migrationBuilder.DropTable(
                name: "ConsumptionTypes");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "UnitMeasures");

            migrationBuilder.DropTable(
                name: "Emissions");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
