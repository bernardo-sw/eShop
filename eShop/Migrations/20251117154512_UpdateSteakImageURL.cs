using Microsoft.EntityFrameworkCore.Migrations;
using System.Collections.Generic;
using TexasSteaks.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

#nullable disable

namespace TexasSteaks.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSteakImageURL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Steaks SET ImageURL = 'Picanha.png', ThumbnailURL = 'Picanha_thumb.png' WHERE Id = 1");
            migrationBuilder.Sql("UPDATE Steaks SET ImageURL = 'Ancho.png', ThumbnailURL = 'Ancho_thumb.png' WHERE Id = 2");
            migrationBuilder.Sql("UPDATE Steaks SET ImageURL = 'Fraldinha.png', ThumbnailURL = 'Fraldinha_thumb.png' WHERE Id = 3");
            migrationBuilder.Sql("UPDATE Steaks SET ImageURL = 'Maminha.png', ThumbnailURL = 'Maminha_thumb.png' WHERE Id = 4");
            migrationBuilder.Sql("UPDATE Steaks SET ImageURL = 'Brisket.png', ThumbnailURL = 'Brisket_thumb.png' WHERE Id = 5");
            migrationBuilder.Sql("UPDATE Steaks SET ImageURL = 'Asinhas_de_frango.png', ThumbnailURL = 'Asinhas_de_frango_thumb.png' WHERE Id = 6");
            migrationBuilder.Sql("UPDATE Steaks SET ImageURL = 'Contrafilé.png', ThumbnailURL = 'Contrafilé_thumb.png' WHERE Id = 7");
            migrationBuilder.Sql("UPDATE Steaks SET ImageURL = 'Assado_de_tira.png', ThumbnailURL = 'Assado_de_tira_thumb.png' WHERE Id = 8");
            migrationBuilder.Sql("UPDATE Steaks SET ImageURL = 'Capa_do_acem.png', ThumbnailURL = 'Capa_do_acem_thumb.png' WHERE Id = 9");
            migrationBuilder.Sql("UPDATE Steaks SET ImageURL = 'Patinho.png', ThumbnailURL = 'Patinho_thumb.png' WHERE Id = 10");
            migrationBuilder.Sql("UPDATE Steaks SET ImageURL = 'File_mignon.png', ThumbnailURL = 'File_mignon_thumb.png' WHERE Id = 11");
            migrationBuilder.Sql("UPDATE Steaks SET ImageURL = 'Porterhouse.png', ThumbnailURL = 'Porterhouse_thumb.png' WHERE Id = 12");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Steaks SET ImageURL = null, ThumbnailURL = null");
        }
    }
}
