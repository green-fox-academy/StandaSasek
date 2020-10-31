using Microsoft.EntityFrameworkCore.Migrations;

namespace Redit.Migrations
{
    public partial class workVotes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WorkVotes",
                table: "Posts",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WorkVotes",
                table: "Posts");
        }
    }
}
