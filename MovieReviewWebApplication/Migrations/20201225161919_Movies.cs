using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieReviewWebApplication.Migrations
{
    public partial class Movies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(8,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieId);
                });



            migrationBuilder.CreateTable(
                name: "MovieGenres",
                columns: table => new
                {
                    GenresId = table.Column<long>(type: "bigint", nullable: false),
                    MoviesMovieId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieGenres", x => new { x.GenresId, x.MoviesMovieId });
                    table.ForeignKey(
                        name: "FK_MovieGenres_Genres_GenresId",
                        column: x => x.GenresId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieGenres_Movies_MoviesMovieId",
                        column: x => x.MoviesMovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieGenres_MoviesMovieId",
                table: "MovieGenres",
                column: "MoviesMovieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieGenres");            

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
