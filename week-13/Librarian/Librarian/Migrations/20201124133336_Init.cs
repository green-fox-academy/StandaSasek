using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibrarianSystem.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Librarians",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Librarians", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Registered = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Registered = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegisteredById = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Librarians_RegisteredById",
                        column: x => x.RegisteredById,
                        principalTable: "Librarians",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Borrows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BorrowerId = table.Column<int>(type: "int", nullable: false),
                    BorrowedBookId = table.Column<int>(type: "int", nullable: false),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlannedEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RealEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Penalty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Borrows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Borrows_Books_BorrowedBookId",
                        column: x => x.BorrowedBookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Borrows_Users_BorrowerId",
                        column: x => x.BorrowerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategorizedById = table.Column<int>(type: "int", nullable: false),
                    CategorizedBookId = table.Column<int>(type: "int", nullable: false),
                    CategorizedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Books_CategorizedBookId",
                        column: x => x.CategorizedBookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Categories_Librarians_CategorizedById",
                        column: x => x.CategorizedById,
                        principalTable: "Librarians",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_RegisteredById",
                table: "Books",
                column: "RegisteredById");

            migrationBuilder.CreateIndex(
                name: "IX_Borrows_BorrowedBookId",
                table: "Borrows",
                column: "BorrowedBookId");

            migrationBuilder.CreateIndex(
                name: "IX_Borrows_BorrowerId",
                table: "Borrows",
                column: "BorrowerId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategorizedBookId",
                table: "Categories",
                column: "CategorizedBookId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategorizedById",
                table: "Categories",
                column: "CategorizedById");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Borrows");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Librarians");
        }
    }
}
