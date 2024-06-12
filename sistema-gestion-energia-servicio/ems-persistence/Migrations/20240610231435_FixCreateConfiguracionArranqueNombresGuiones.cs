using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ems_persistencia.Migrations
{
    /// <inheritdoc />
    public partial class FixCreateConfiguracionArranqueNombresGuiones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ConfiguracionArranque",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "PotenciaBaterías",
                table: "ConfiguracionArranque",
                newName: "potencia_baterias");

            migrationBuilder.RenameColumn(
                name: "PorcentajeRespaldoEnergía",
                table: "ConfiguracionArranque",
                newName: "porcentaje_respaldo_energía");

            migrationBuilder.RenameColumn(
                name: "PorcentajeCargaSegura",
                table: "ConfiguracionArranque",
                newName: "porcentaje_carga_segura");

            migrationBuilder.RenameColumn(
                name: "LimiteDemanda",
                table: "ConfiguracionArranque",
                newName: "limite_demanda");

            migrationBuilder.RenameColumn(
                name: "DemandaContratada",
                table: "ConfiguracionArranque",
                newName: "demanda_contratada");

            migrationBuilder.RenameColumn(
                name: "CapacidadBaterías",
                table: "ConfiguracionArranque",
                newName: "capacidad_baterias");

            migrationBuilder.RenameColumn(
                name: "CapacidadBateríaSegura",
                table: "ConfiguracionArranque",
                newName: "capacidad_bateria_segura");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "ConfiguracionArranque",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "potencia_baterias",
                table: "ConfiguracionArranque",
                newName: "PotenciaBaterías");

            migrationBuilder.RenameColumn(
                name: "porcentaje_respaldo_energía",
                table: "ConfiguracionArranque",
                newName: "PorcentajeRespaldoEnergía");

            migrationBuilder.RenameColumn(
                name: "porcentaje_carga_segura",
                table: "ConfiguracionArranque",
                newName: "PorcentajeCargaSegura");

            migrationBuilder.RenameColumn(
                name: "limite_demanda",
                table: "ConfiguracionArranque",
                newName: "LimiteDemanda");

            migrationBuilder.RenameColumn(
                name: "demanda_contratada",
                table: "ConfiguracionArranque",
                newName: "DemandaContratada");

            migrationBuilder.RenameColumn(
                name: "capacidad_baterias",
                table: "ConfiguracionArranque",
                newName: "CapacidadBaterías");

            migrationBuilder.RenameColumn(
                name: "capacidad_bateria_segura",
                table: "ConfiguracionArranque",
                newName: "CapacidadBateríaSegura");
        }
    }
}
