using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DraftApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class addteamalternatenames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AlternateNames",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlternateNames",
                table: "Teams");
        }
    }
}
