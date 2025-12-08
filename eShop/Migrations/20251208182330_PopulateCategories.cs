using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eShop.Migrations
{
    /// <inheritdoc />
    public partial class PopulateCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categories(Name, Description) VALUES ('Churrasco na grelha', 'Versátil e tradicional para a maioria dos cortes.')");
            migrationBuilder.Sql("INSERT INTO Categories(Name, Description) VALUES ('Churrasco no espeto', 'Usado para cortes grandes como o costelão 12 horas ou picanha, preservando suculência.')");
            migrationBuilder.Sql("INSERT INTO Categories(Name, Description) VALUES ('Churrasco estilo americano (Barbecue)', 'Caracterizado pela defumação lenta, usando marinadas e temperos.')");
            migrationBuilder.Sql("INSERT INTO Categories(Name, Description) VALUES ('Parrilla', ' Estilo da culinária argentina e uruguaia, com grelhas baixas e cortes de carne preparados de forma específica.')");
            migrationBuilder.Sql("INSERT INTO Categories(Name, Description) VALUES ('Delivery/Marmitex', 'Opções práticas para quem pede comida em casa, como o churrasco em marmitas.')");
            migrationBuilder.Sql("INSERT INTO Categories(Name, Description) VALUES ('Steakhouse', 'Restaurantes especializados em carnes, com cortes nobres e diferentes técnicas de preparo.')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categories");
        }
    }
}
