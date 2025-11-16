using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TexasSteaks.Migrations
{
    /// <inheritdoc />
    public partial class PopulateSteaks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Steaks(Name, ShortDescription, Price, IsFavorite, InStock, CategoryId) " +
                "VALUES ('Picanha', 'Corte suculento com uma capa de gordura que o torna ideal para grelhar.', 82.99, 1, 0, 1)");
            migrationBuilder.Sql("INSERT INTO Steaks(Name, ShortDescription, Price, IsFavorite, InStock, CategoryId) " +
                "VALUES ('Ancho', 'Corte com bom marmoreio, o que garante suculência mesmo em contato direto com a grelha.', 59.99, 1, 0, 1)");

            migrationBuilder.Sql("INSERT INTO Steaks(Name, ShortDescription, Price, IsFavorite, InStock, CategoryId) " +
                "VALUES ('Fraldinha', 'Corte com fibras longas e sabor intenso, sendo uma ótima opção para quem busca carne mais magra.', 43.99, 0, 1, 2)");
            migrationBuilder.Sql("INSERT INTO Steaks(Name, ShortDescription, Price, IsFavorite, InStock, CategoryId) " +
                "VALUES ('Maminha', 'Considerada um corte nobre da alcatra, é magra e com sabor suave, ideal para espetos.', 74.99, 1, 0, 2)");

            migrationBuilder.Sql("INSERT INTO Steaks(Name, ShortDescription, Price, IsFavorite, InStock, CategoryId) " +
                "VALUES ('Brisket', 'O corte de peito de boi é o principal no churrasco americano, assado por longas horas até ficar suculento e macio.', 119.3, 0, 0, 3)");
            migrationBuilder.Sql("INSERT INTO Steaks(Name, ShortDescription, Price, IsFavorite, InStock, CategoryId) " +
                "VALUES ('Asas de frango', 'Asas de frango e outros cortes são muito comuns, geralmente assados com uma variedade de temperos e molhos.', 13.99, 0, 1, 3)");

            migrationBuilder.Sql("INSERT INTO Steaks(Name, ShortDescription, Price, IsFavorite, InStock, CategoryId) " +
                "VALUES ('Contrafilé', 'Pode ser conhecido como ripa da chuleta. A parte traseira do contrafilé é chamada de bife de chorizo.', 54.99, 1, 0, 4)");
            migrationBuilder.Sql("INSERT INTO Steaks(Name, ShortDescription, Price, IsFavorite, InStock, CategoryId) " +
                "VALUES ('Assado de Tira', 'Costela cortada na transversal, que exibe uma combinação única de sabor e textura.', 36.99, 0, 0, 4)");

            migrationBuilder.Sql("INSERT INTO Steaks(Name, ShortDescription, Price, IsFavorite, InStock, CategoryId) " +
                "VALUES ('Capa do Acém', 'É uma carne mais firme, ideal para ser cozida na panela, ensopados ou assados.', 56.99, 1, 0, 5)");
            migrationBuilder.Sql("INSERT INTO Steaks(Name, ShortDescription, Price, IsFavorite, InStock, CategoryId) " +
                "VALUES ('Patinho', 'Pode ser preparado de diversas maneiras: bife de patinho, moída, picadinho, e em tiras para strogonoff ou escalopes.', 55.99, 1, 0, 5)");

            migrationBuilder.Sql("INSERT INTO Steaks(Name, ShortDescription, Price, IsFavorite, InStock, CategoryId) " +
                "VALUES ('Filé Mignon', 'Considerado por muitos o corte mais nobre, é extremamente macio e de sabor suave, ideal para medalhões.', 209.99, 1, 0, 6)");
            migrationBuilder.Sql("INSERT INTO Steaks(Name, ShortDescription, Price, IsFavorite, InStock, CategoryId) " +
                "VALUES ('Porterhouse', 'Pode ser preparado de diversas maneiras: bife de patinho, moída, picadinho, e em tiras para strogonoff ou escalopes.', 179.9, 1, 0, 6)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Steaks");
        }
    }
}
