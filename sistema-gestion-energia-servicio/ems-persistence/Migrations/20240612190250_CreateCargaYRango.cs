using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ems_persistencia.Migrations
{
    /// <inheritdoc />
    public partial class CreateCargaYRango : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CargaDescargaBloque",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    estacion = table.Column<string>(type: "TEXT", nullable: false),
                    dia_semana = table.Column<int>(type: "INTEGER", nullable: false),
                    hora_inicial = table.Column<DateTime>(type: "TEXT", nullable: false),
                    hora_final = table.Column<DateTime>(type: "TEXT", nullable: false),
                    tipo = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargaDescargaBloque", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "RangoBloqueEstacion",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    hora_inicial = table.Column<DateTime>(type: "TEXT", nullable: false),
                    hora_final = table.Column<DateTime>(type: "TEXT", nullable: false),
                    estacion = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RangoBloqueEstacion", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CargaDescargaBloque");

            migrationBuilder.DropTable(
                name: "RangoBloqueEstacion");
        }
    }
}
