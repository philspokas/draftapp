using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DraftApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class TourneyTeamAndPick3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Picks",
                columns: table => new
                {
                    PickId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    TourneyTeamId = table.Column<int>(type: "int", nullable: false),
                    PickNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Picks", x => x.PickId);
                    table.ForeignKey(
                        name: "FK_Picks_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Picks_TourneyTeams_TourneyTeamId",
                        column: x => x.TourneyTeamId,
                        principalTable: "TourneyTeams",
                        principalColumn: "TourneyTeamID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TourneyTeams_TeamID",
                table: "TourneyTeams",
                column: "TeamID");

            migrationBuilder.CreateIndex(
                name: "IX_Picks_PlayerId",
                table: "Picks",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Picks_TourneyTeamId",
                table: "Picks",
                column: "TourneyTeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_TourneyTeams_Teams_TeamID",
                table: "TourneyTeams",
                column: "TeamID",
                principalTable: "Teams",
                principalColumn: "TeamId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TourneyTeams_Teams_TeamID",
                table: "TourneyTeams");

            migrationBuilder.DropTable(
                name: "Picks");

            migrationBuilder.DropIndex(
                name: "IX_TourneyTeams_TeamID",
                table: "TourneyTeams");
        }
    }
}
