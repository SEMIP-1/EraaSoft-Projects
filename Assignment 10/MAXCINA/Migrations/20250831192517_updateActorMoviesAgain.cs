using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MAXCINA.Migrations
{
    /// <inheritdoc />
    public partial class updateActorMoviesAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_ActorMovies_ActorsId",
                table: "ActorMovies",
                column: "ActorsId");

            migrationBuilder.CreateIndex(
                name: "IX_ActorMovies_MoviesId",
                table: "ActorMovies",
                column: "MoviesId");

            migrationBuilder.AddForeignKey(
                name: "FK_ActorMovies_Actors_ActorsId",
                table: "ActorMovies",
                column: "ActorsId",
                principalTable: "Actors",
                principalColumn: "ActorsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ActorMovies_Movies_MoviesId",
                table: "ActorMovies",
                column: "MoviesId",
                principalTable: "Movies",
                principalColumn: "MoviesId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActorMovies_Actors_ActorsId",
                table: "ActorMovies");

            migrationBuilder.DropForeignKey(
                name: "FK_ActorMovies_Movies_MoviesId",
                table: "ActorMovies");

            migrationBuilder.DropIndex(
                name: "IX_ActorMovies_ActorsId",
                table: "ActorMovies");

            migrationBuilder.DropIndex(
                name: "IX_ActorMovies_MoviesId",
                table: "ActorMovies");
        }
    }
}
