using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PawConnect.Migrations
{
    /// <inheritdoc />
    public partial class AddPetServices : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PetServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetServices", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "PetServices",
                columns: new[] { "Id", "Address", "Category", "Description", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "123 King St, Waterloo, ON", "Vet", "General checkups, vaccines, and emergency support.", "Happy Paws Veterinary Clinic", "(519) 111-2222" },
                    { 2, "45 University Ave, Waterloo, ON", "Vet", "Full-service vet care with diagnostics and surgery.", "Waterloo Animal Hospital", "(519) 222-3333" },
                    { 3, "88 Bridgeport Rd, Waterloo, ON", "Groomer", "Bath, haircut, nail trimming, and ear cleaning.", "Downtown Pet Groomers", "(519) 333-4444" },
                    { 4, "12 Weber St, Kitchener, ON", "Groomer", "Grooming for dogs and cats with gentle handling.", "Fresh Fur Grooming Studio", "(519) 444-5555" },
                    { 5, "200 Victoria St, Kitchener, ON", "Trainer", "Obedience training for puppies and adult dogs.", "Canine Training Academy", "(519) 555-6666" },
                    { 6, "9 Highland Rd, Kitchener, ON", "Trainer", "Behavior help for barking, leash pulling, and anxiety.", "Good Dog Behavior Coaching", "(519) 666-7777" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PetServices");
        }
    }
}
