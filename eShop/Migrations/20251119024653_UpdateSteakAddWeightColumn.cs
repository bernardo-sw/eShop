using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TexasSteaks.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSteakAddWeightColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Weight",
                table: "Steaks",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Steaks");
        }
    }
}
