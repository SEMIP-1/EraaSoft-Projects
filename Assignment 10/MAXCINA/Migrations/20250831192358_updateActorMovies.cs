using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MAXCINA.Migrations
{
    /// <inheritdoc />
    public partial class updateActorMovies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "ActorMovies",
                newName: "MoviesId");

            migrationBuilder.RenameColumn(
                name: "ActorId",
                table: "ActorMovies",
                newName: "ActorsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MoviesId",
                table: "ActorMovies",
                newName: "MovieId");

            migrationBuilder.RenameColumn(
                name: "ActorsId",
                table: "ActorMovies",
                newName: "ActorId");
        }
    }
}
