using Microsoft.EntityFrameworkCore.Migrations;

namespace DbContextTraining.Migrations
{
    public partial class assigneeconnected : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Assignee_AssigneeId",
                table: "Todos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Assignee",
                table: "Assignee");

            migrationBuilder.RenameTable(
                name: "Assignee",
                newName: "Assignees");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Assignees",
                table: "Assignees",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Assignees_AssigneeId",
                table: "Todos",
                column: "AssigneeId",
                principalTable: "Assignees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Assignees_AssigneeId",
                table: "Todos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Assignees",
                table: "Assignees");

            migrationBuilder.RenameTable(
                name: "Assignees",
                newName: "Assignee");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Assignee",
                table: "Assignee",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Assignee_AssigneeId",
                table: "Todos",
                column: "AssigneeId",
                principalTable: "Assignee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
