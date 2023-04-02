using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ConsumoResponsableApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
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
                    unit_measure_id = table.Column<int>(type: "integer", nullable: false, comment: "Unit Measure Foreign key"),
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
                    table.ForeignKey(
                        name: "FK_ConsumptionTypes_UnitMeasures_unit_measure_id",
                        column: x => x.unit_measure_id,
                        principalTable: "UnitMeasures",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Consumptions",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false, comment: "Entity Primary Key")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    executed_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "Consumption execution date"),
                    quantity = table.Column<int>(type: "integer", nullable: false, comment: "Consumption quantity"),
                    consumption_type_id = table.Column<int>(type: "integer", nullable: false, comment: "Consumption Type Foreign key"),
                    location_id = table.Column<int>(type: "integer", nullable: false, comment: "Location Foreign key"),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, comment: "Creation date"),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "Update date"),
                    active = table.Column<bool>(type: "boolean", nullable: false, comment: "Status of register"),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, comment: "Delete date")
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
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "id", "active", "created_at", "deleted_at", "description", "name", "updated_at" },
                values: new object[] { 1, true, new DateTime(2023, 4, 2, 4, 12, 56, 990, DateTimeKind.Utc).AddTicks(9909), null, "Fabrica Industrial S.A.", "Fabrica Industrial S.A.", null });

            migrationBuilder.InsertData(
                table: "Emissions",
                columns: new[] { "id", "active", "created_at", "deleted_at", "description", "name", "updated_at" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2023, 4, 2, 4, 12, 56, 991, DateTimeKind.Utc).AddTicks(634), null, "Asociadas a las actividades de la organización y que están controladas por dicha organización.", "directas", null },
                    { 2, true, new DateTime(2023, 4, 2, 4, 12, 56, 991, DateTimeKind.Utc).AddTicks(640), null, "Asociadas al consumo energético adquirido y consumido por la organización.", "indirectas", null },
                    { 3, true, new DateTime(2023, 4, 2, 4, 12, 56, 991, DateTimeKind.Utc).AddTicks(642), null, "Asociadas a otras actividades no controladas por la organización.", "otras", null }
                });

            migrationBuilder.InsertData(
                table: "UnitMeasures",
                columns: new[] { "id", "active", "created_at", "deleted_at", "description", "name", "updated_at" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2023, 4, 2, 4, 12, 56, 991, DateTimeKind.Utc).AddTicks(1432), null, "Kilo Watts", "kw", null },
                    { 2, true, new DateTime(2023, 4, 2, 4, 12, 56, 991, DateTimeKind.Utc).AddTicks(1486), null, "Galones", "galon", null },
                    { 3, true, new DateTime(2023, 4, 2, 4, 12, 56, 991, DateTimeKind.Utc).AddTicks(1488), null, "Unidad", "unidad", null }
                });

            migrationBuilder.InsertData(
                table: "ConsumptionTypes",
                columns: new[] { "id", "active", "created_at", "deleted_at", "description", "emission_id", "name", "petroleum_derivative", "unit_measure_id", "updated_at" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2023, 4, 2, 4, 12, 56, 991, DateTimeKind.Utc).AddTicks(255), null, "Consumo combustible para los vehículos", 1, "combustible para los vehículos", true, 2, null },
                    { 2, true, new DateTime(2023, 4, 2, 4, 12, 56, 991, DateTimeKind.Utc).AddTicks(262), null, "Perdida de gases refrigerantes", 1, "gases refrigerantes", true, 2, null },
                    { 3, true, new DateTime(2023, 4, 2, 4, 12, 56, 991, DateTimeKind.Utc).AddTicks(263), null, "Consumo de energía eléctrica ", 1, "energía eléctrica", true, 1, null },
                    { 4, true, new DateTime(2023, 4, 2, 4, 12, 56, 991, DateTimeKind.Utc).AddTicks(265), null, "Uso mensual de combustible para vehículos terceros", 2, "combustible para transportes de terceros", true, 2, null },
                    { 5, true, new DateTime(2023, 4, 2, 4, 12, 56, 991, DateTimeKind.Utc).AddTicks(266), null, "Viajes de miembros del equipo", 3, "viajes", true, 1, null },
                    { 6, true, new DateTime(2023, 4, 2, 4, 12, 56, 991, DateTimeKind.Utc).AddTicks(271), null, "Consumo de aceite para mantenimiento", 1, "aceite para mantenimiento", true, 1, null },
                    { 7, true, new DateTime(2023, 4, 2, 4, 12, 56, 991, DateTimeKind.Utc).AddTicks(272), null, "Otros consumos (Papel, lapices, agua,etc)", 1, "otros", false, 3, null }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "id", "active", "company_id", "created_at", "deleted_at", "description", "name", "updated_at" },
                values: new object[,]
                {
                    { 1, true, 1, new DateTime(2023, 4, 2, 4, 12, 56, 991, DateTimeKind.Utc).AddTicks(978), null, "Area administrativa", "Administracion", null },
                    { 2, true, 1, new DateTime(2023, 4, 2, 4, 12, 56, 991, DateTimeKind.Utc).AddTicks(982), null, "Area de distribucion", "Distribucion", null },
                    { 3, true, 1, new DateTime(2023, 4, 2, 4, 12, 56, 991, DateTimeKind.Utc).AddTicks(984), null, "Proveedores de transportes", "Transportes Terceros", null },
                    { 4, true, 1, new DateTime(2023, 4, 2, 4, 12, 56, 991, DateTimeKind.Utc).AddTicks(985), null, "Area gerencial", "Gerencia", null },
                    { 5, true, 1, new DateTime(2023, 4, 2, 4, 12, 56, 991, DateTimeKind.Utc).AddTicks(986), null, "Area de planta de envasado", "Planta de envasado", null },
                    { 6, true, 1, new DateTime(2023, 4, 2, 4, 12, 56, 991, DateTimeKind.Utc).AddTicks(989), null, "Area de operaciones", "Operaciones", null }
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
                name: "IX_ConsumptionTypes_emission_id",
                table: "ConsumptionTypes",
                column: "emission_id");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumptionTypes_unit_measure_id",
                table: "ConsumptionTypes",
                column: "unit_measure_id");

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
                name: "Emissions");

            migrationBuilder.DropTable(
                name: "UnitMeasures");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
