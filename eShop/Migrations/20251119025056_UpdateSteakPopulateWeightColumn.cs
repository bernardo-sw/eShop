using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TexasSteaks.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSteakPopulateWeightColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Steaks SET Weight = 1.0");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Steaks SET Weight = 0.0");
        }
    }
}
