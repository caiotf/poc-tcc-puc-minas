using Microsoft.EntityFrameworkCore.Migrations;

namespace GSL.RatingAPI.Migrations
{
    public partial class UpdateRatingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserEmail",
                table: "Ratings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Ratings",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserEmail",
                table: "Ratings");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Ratings");
        }
    }
}
