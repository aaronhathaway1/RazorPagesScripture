using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPagesScripture.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Scripture",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Collection = table.Column<string>(nullable: true),
                    Book = table.Column<string>(nullable: true),
                    Chapter = table.Column<string>(nullable: true),
                    Verse = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scripture", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Scripture");
        }
    }
}
