using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LAB11CoreMvc.Migrations
{
    /// <inheritdoc />
    public partial class agregandonuevocampo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Activo",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Activo",
                table: "Products");
        }
    }
}
