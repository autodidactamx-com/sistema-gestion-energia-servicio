using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ems_persistencia.Migrations
{
    /// <inheritdoc />
    public partial class CreateConfiguracionArranque : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConfiguracionArranques",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DemandaContratada = table.Column<double>(type: "REAL", nullable: false),
                    PorcentajeCargaSegura = table.Column<double>(type: "REAL", nullable: false),
                    LimiteDemanda = table.Column<double>(type: "REAL", nullable: false),
                    PotenciaBaterías = table.Column<double>(type: "REAL", nullable: false),
                    CapacidadBaterías = table.Column<double>(type: "REAL", nullable: false),
                    PorcentajeRespaldoEnergía = table.Column<double>(type: "REAL", nullable: false),
                    CapacidadBateríaSegura = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfiguracionArranques", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConfiguracionArranques");
        }
    }
}
