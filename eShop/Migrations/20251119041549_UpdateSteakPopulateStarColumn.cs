using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TexasSteaks.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSteakPopulateStarColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Steaks SET Star = 5 WHERE Id = 1");
            migrationBuilder.Sql("UPDATE Steaks SET Star = 5 WHERE Id = 2");
            migrationBuilder.Sql("UPDATE Steaks SET Star = 3 WHERE Id = 4");
            migrationBuilder.Sql("UPDATE Steaks SET Star = 5 WHERE Id = 7");
            migrationBuilder.Sql("UPDATE Steaks SET Star = 3 WHERE Id = 10");
            migrationBuilder.Sql("UPDATE Steaks SET Star = 5 WHERE Id = 11");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Steaks SET Star = 0 WHERE Id = 1");
            migrationBuilder.Sql("UPDATE Steaks SET Star = 0 WHERE Id = 2");
            migrationBuilder.Sql("UPDATE Steaks SET Star = 0 WHERE Id = 4");
            migrationBuilder.Sql("UPDATE Steaks SET Star = 0 WHERE Id = 7");
            migrationBuilder.Sql("UPDATE Steaks SET Star = 0 WHERE Id = 10");
            migrationBuilder.Sql("UPDATE Steaks SET Star = 0 WHERE Id = 11");
        }
    }
}
