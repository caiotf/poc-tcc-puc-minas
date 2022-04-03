using Microsoft.EntityFrameworkCore.Migrations;

namespace GSL.RatingAPI.Migrations
{
    public partial class RemoveColumnRatingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Transparencia",
                table: "Ratings");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Transparencia",
                table: "Ratings",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
