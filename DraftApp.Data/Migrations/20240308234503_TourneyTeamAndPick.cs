using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DraftApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class TourneyTeamAndPick : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Sequence",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TourneyTeams",
                columns: table => new
                {
                    TourneyTeamID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamID = table.Column<int>(type: "int", nullable: false),
                    Seed = table.Column<int>(type: "int", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BracketPosition = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourneyTeams", x => x.TourneyTeamID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TourneyTeams");

            migrationBuilder.DropColumn(
                name: "Sequence",
                table: "Players");
        }
    }
}
