using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TexasSteaks.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSteakPopulateDiscountColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Steaks SET Discount = 20 WHERE Id = 1");
            migrationBuilder.Sql("UPDATE Steaks SET Discount = 30 WHERE Id = 4");
            migrationBuilder.Sql("UPDATE Steaks SET Discount = 25 WHERE Id = 10");
            migrationBuilder.Sql("UPDATE Steaks SET Discount = 10 WHERE Id = 12");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Steaks SET Discount = 0 WHERE Id = 1");
            migrationBuilder.Sql("UPDATE Steaks SET Discount = 0 WHERE Id = 4");
            migrationBuilder.Sql("UPDATE Steaks SET Discount = 0 WHERE Id = 10");
            migrationBuilder.Sql("UPDATE Steaks SET Discount = 0 WHERE Id = 12");
        }
    }
}
