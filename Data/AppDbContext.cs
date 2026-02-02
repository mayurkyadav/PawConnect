using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PawConnect.Models;

namespace PawConnect.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<PetService> PetServices { get; set; }

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
        }
    }
}
