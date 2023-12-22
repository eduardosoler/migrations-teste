using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gustavo.Infra.DependencyInjection.Migrations
{
    /// <inheritdoc />
    public partial class Novocampodedescrição : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Categorias",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Categorias");
        }
    }
}
