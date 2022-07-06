using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ForOleksiyAspNet5.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gamers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Birthday = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Rang = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gamers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatrtGame = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    EndGame = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    GamerWhiteId = table.Column<int>(type: "int", nullable: true),
                    GamerDarkId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Games_Gamers_GamerDarkId",
                        column: x => x.GamerDarkId,
                        principalTable: "Gamers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Games_Gamers_GamerWhiteId",
                        column: x => x.GamerWhiteId,
                        principalTable: "Gamers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Hody",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    data_sozdaniya = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: true),
                    figura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    s = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    na = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hody", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hody_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Games_GamerDarkId",
                table: "Games",
                column: "GamerDarkId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_GamerWhiteId",
                table: "Games",
                column: "GamerWhiteId");

            migrationBuilder.CreateIndex(
                name: "IX_Hody_GameId",
                table: "Hody",
                column: "GameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hody");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Gamers");
        }
    }
}
