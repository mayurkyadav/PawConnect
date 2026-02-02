namespace PawConnect.Models
{
    public class PetService
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        // "Vet", "Groomer", "Trainer"
        public string Category { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
    }
}
