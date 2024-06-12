using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ems_persistencia.Migrations
{
    /// <inheritdoc />
    public partial class EliminaTablaPeople2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "ConfiguracionArranque",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    demanda_contratada = table.Column<double>(type: "REAL", nullable: false),
                    porcentaje_carga_segura = table.Column<double>(type: "REAL", nullable: false),
                    limite_demanda = table.Column<double>(type: "REAL", nullable: false),
                    potencia_baterias = table.Column<double>(type: "REAL", nullable: false),
                    capacidad_baterias = table.Column<double>(type: "REAL", nullable: false),
                    porcentaje_respaldo_energía = table.Column<double>(type: "REAL", nullable: false),
                    capacidad_bateria_segura = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfiguracionArranque", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConfiguracionArranque");

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });
        }
    }
}
