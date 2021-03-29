using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Overview = table.Column<string>(type: "TEXT", nullable: true),
                    Adult = table.Column<bool>(type: "INTEGER", nullable: false),
                    Backdrop_path = table.Column<string>(type: "TEXT", nullable: true),
                    Original_language = table.Column<string>(type: "TEXT", nullable: true),
                    Original_title = table.Column<string>(type: "TEXT", nullable: true),
                    Popularity = table.Column<decimal>(type: "TEXT", nullable: false),
                    Poster_path = table.Column<string>(type: "TEXT", nullable: true),
                    Release_date = table.Column<string>(type: "TEXT", nullable: true),
                    Video = table.Column<bool>(type: "INTEGER", nullable: false),
                    Vote_avarage = table.Column<float>(type: "REAL", nullable: false),
                    Vote_count = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
