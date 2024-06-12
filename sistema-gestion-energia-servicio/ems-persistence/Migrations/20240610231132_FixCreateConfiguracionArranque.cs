using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ems_persistencia.Migrations
{
    /// <inheritdoc />
    public partial class FixCreateConfiguracionArranque : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ConfiguracionArranques",
                table: "ConfiguracionArranques");

            migrationBuilder.RenameTable(
                name: "ConfiguracionArranques",
                newName: "ConfiguracionArranque");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ConfiguracionArranque",
                table: "ConfiguracionArranque",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ConfiguracionArranque",
                table: "ConfiguracionArranque");

            migrationBuilder.RenameTable(
                name: "ConfiguracionArranque",
                newName: "ConfiguracionArranques");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ConfiguracionArranques",
                table: "ConfiguracionArranques",
                column: "Id");
        }
    }
}
