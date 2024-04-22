using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Anime.Migrations
{
    /// <inheritdoc />
    public partial class DadosIniciais : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Animes(Title,ImagemUrl,QuantidadeEp,Categoria) VALUES('Naruto','https://cinema10.com.br/upload/series/series_828_pnar.jpg?default=poster',500,'Shonen')");
            migrationBuilder.Sql("INSERT INTO Animes(Title,ImagemUrl,QuantidadeEp,Categoria) VALUES('One Piece','https://legadoplus.com.br/wp-content/uploads/2023/01/one-piece-legadoplus.webp',1088 ,'Shonen')");
            migrationBuilder.Sql("INSERT INTO Animes(Title,ImagemUrl,QuantidadeEp,Categoria) VALUES('Jujutsu Kaisen','https://s2-techtudo.glbimg.com/ZnivYBziOUVrbuR7yPgrk1tiOLk=/0x0:4096x2895/888x0/smart/filters:strip_icc()/i.s3.glbimg.com/v1/AUTH_08fbf48bc0524877943fe86e43087e7a/internal_photos/bs/2023/q/c/fdGjDwRBaeV4DvsJBATw/jujutsu-kaisen-crunchyroll-techtudo.jpg',47,'Shonen')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("REMOVE FROM animes");
        }
    }
}
