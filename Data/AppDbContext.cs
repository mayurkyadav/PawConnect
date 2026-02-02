using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PawConnect.Models;

namespace PawConnect.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<PetService> PetServices { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //  Static seed data for Sprint 1
            builder.Entity<PetService>().HasData(
                new PetService
                {
                    Id = 1,
                    Name = "Happy Paws Veterinary Clinic",
                    Category = "Vet",
                    Address = "123 King St, Waterloo, ON",
                    Phone = "(519) 111-2222",
                    Description = "General checkups, vaccines, and emergency support."
                },
                new PetService
                {
                    Id = 2,
                    Name = "Waterloo Animal Hospital",
                    Category = "Vet",
                    Address = "45 University Ave, Waterloo, ON",
                    Phone = "(519) 222-3333",
                    Description = "Full-service vet care with diagnostics and surgery."
                },
                new PetService
                {
                    Id = 3,
                    Name = "Downtown Pet Groomers",
                    Category = "Groomer",
                    Address = "88 Bridgeport Rd, Waterloo, ON",
                    Phone = "(519) 333-4444",
                    Description = "Bath, haircut, nail trimming, and ear cleaning."
                },
                new PetService
                {
                    Id = 4,
                    Name = "Fresh Fur Grooming Studio",
                    Category = "Groomer",
                    Address = "12 Weber St, Kitchener, ON",
                    Phone = "(519) 444-5555",
                    Description = "Grooming for dogs and cats with gentle handling."
                },
                new PetService
                {
                    Id = 5,
                    Name = "Canine Training Academy",
                    Category = "Trainer",
                    Address = "200 Victoria St, Kitchener, ON",
                    Phone = "(519) 555-6666",
                    Description = "Obedience training for puppies and adult dogs."
                },
                new PetService
                {
                    Id = 6,
                    Name = "Good Dog Behavior Coaching",
                    Category = "Trainer",
                    Address = "9 Highland Rd, Kitchener, ON",
                    Phone = "(519) 666-7777",
                    Description = "Behavior help for barking, leash pulling, and anxiety."
                }


            );

            builder.Entity<Post>().HasData(
    new Post
    {
        Id = 1,
        AuthorName = "Mayur",
        AuthorHandle = "@mayur",
        Content = "Just adopted my first puppy today 🐶 Any tips for a new pet owner?",
        CreatedAt = new DateTime(2026, 02, 01, 10, 30, 00, DateTimeKind.Utc)
    },
    new Post
    {
        Id = 2,
        AuthorName = "Shyamal",
        AuthorHandle = "@shyamal",
        Content = "Found a good groomer in Waterloo. The service was calm and quick.",
        CreatedAt = new DateTime(2026, 02, 01, 13, 10, 00, DateTimeKind.Utc)
    },
    new Post
    {
        Id = 3,
        AuthorName = "Haley",
        AuthorHandle = "@haley",
        Content = "My cat won’t eat the new food. Any easy suggestions?",
        CreatedAt = new DateTime(2026, 02, 02, 09, 15, 00, DateTimeKind.Utc)
    },
    new Post
    {
        Id = 4,
        AuthorName = "Samarth",
        AuthorHandle = "@samarth",
        Content = "Quick reminder: keep your dog hydrated on long walks, even in winter.",
        CreatedAt = new DateTime(2026, 02, 02, 16, 40, 00, DateTimeKind.Utc)
    },
    new Post
    {
        Id = 5,
        AuthorName = "Kabrawala",
        AuthorHandle = "@kabrawala",
        Content = "Does anyone know a trainer who helps with leash pulling?",
        CreatedAt = new DateTime(2026, 02, 02, 20, 05, 00, DateTimeKind.Utc)
    }
);

        }
    }
}
