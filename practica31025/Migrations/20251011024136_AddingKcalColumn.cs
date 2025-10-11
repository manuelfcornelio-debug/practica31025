using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace practica31025.Migrations
{
    /// <inheritdoc />
    public partial class AddingKcalColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Kcal",
                table: "Foods",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Kcal",
                table: "Foods");
        }
    }
}
