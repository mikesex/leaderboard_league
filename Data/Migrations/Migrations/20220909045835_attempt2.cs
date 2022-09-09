using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace leaderboard_league_app.Migrations
{
    public partial class attempt2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attempt",
                columns: table => new
                {
                    AttemptID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContactId = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<double>(type: "float", nullable: false),
                    TieBreakerScore = table.Column<double>(type: "float", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attempt", x => x.AttemptID);
                    table.ForeignKey(
                        name: "FK_Attempt_Category_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Attempt_Contact_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contact",
                        principalColumn: "ContactId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attempt_CategoryID",
                table: "Attempt",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Attempt_ContactId",
                table: "Attempt",
                column: "ContactId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attempt");
        }
    }
}
