using Microsoft.EntityFrameworkCore.Migrations;

namespace NTBErrorReporter.Migrations
{
    public partial class Reporter_Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReportId",
                table: "Reporter");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReportId",
                table: "Reporter",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
