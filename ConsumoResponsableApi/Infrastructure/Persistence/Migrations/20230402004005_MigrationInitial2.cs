using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsumoResponsableApi.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class MigrationInitial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consumptions_UnitMeasures_unit_measure_id",
                table: "Consumptions");

            migrationBuilder.DropIndex(
                name: "IX_Consumptions_unit_measure_id",
                table: "Consumptions");

            migrationBuilder.DropColumn(
                name: "unit_measure_id",
                table: "Consumptions");

            migrationBuilder.AddColumn<int>(
                name: "unit_measure_id",
                table: "ConsumptionTypes",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                comment: "Unit Measure Foreign key");

            migrationBuilder.AddColumn<DateTime>(
                name: "executed_at",
                table: "Consumptions",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                comment: "Consumption execution date");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumptionTypes_unit_measure_id",
                table: "ConsumptionTypes",
                column: "unit_measure_id");

            migrationBuilder.AddForeignKey(
                name: "FK_ConsumptionTypes_UnitMeasures_unit_measure_id",
                table: "ConsumptionTypes",
                column: "unit_measure_id",
                principalTable: "UnitMeasures",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConsumptionTypes_UnitMeasures_unit_measure_id",
                table: "ConsumptionTypes");

            migrationBuilder.DropIndex(
                name: "IX_ConsumptionTypes_unit_measure_id",
                table: "ConsumptionTypes");

            migrationBuilder.DropColumn(
                name: "unit_measure_id",
                table: "ConsumptionTypes");

            migrationBuilder.DropColumn(
                name: "executed_at",
                table: "Consumptions");

            migrationBuilder.AddColumn<int>(
                name: "unit_measure_id",
                table: "Consumptions",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                comment: "Unit Measure Foreign key");

            migrationBuilder.CreateIndex(
                name: "IX_Consumptions_unit_measure_id",
                table: "Consumptions",
                column: "unit_measure_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Consumptions_UnitMeasures_unit_measure_id",
                table: "Consumptions",
                column: "unit_measure_id",
                principalTable: "UnitMeasures",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
