using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PawConnect.Migrations
{
    /// <inheritdoc />
    public partial class AddPostsFeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorHandle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "AuthorHandle", "AuthorName", "Content", "CreatedAt" },
                values: new object[,]
                {
                    { 1, "@mayur", "Mayur", "Just adopted my first puppy today 🐶 Any tips for a new pet owner?", new DateTime(2026, 2, 1, 10, 30, 0, 0, DateTimeKind.Utc) },
                    { 2, "@shyamal", "Shyamal", "Found a good groomer in Waterloo. The service was calm and quick.", new DateTime(2026, 2, 1, 13, 10, 0, 0, DateTimeKind.Utc) },
                    { 3, "@haley", "Haley", "My cat won’t eat the new food. Any easy suggestions?", new DateTime(2026, 2, 2, 9, 15, 0, 0, DateTimeKind.Utc) },
                    { 4, "@samarth", "Samarth", "Quick reminder: keep your dog hydrated on long walks, even in winter.", new DateTime(2026, 2, 2, 16, 40, 0, 0, DateTimeKind.Utc) },
                    { 5, "@kabrawala", "Kabrawala", "Does anyone know a trainer who helps with leash pulling?", new DateTime(2026, 2, 2, 20, 5, 0, 0, DateTimeKind.Utc) }
                });
        }

        
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
