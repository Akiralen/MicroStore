namespace SecurityAPI.Models
{
    public class AppUser
    {
        public required int Id { get; set; }
        public bool IsGroup { get; set; } 
        public required string Username { get; set; }
        public required string? Password { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool IsActive { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public int? BelongsToGroup { get; set; }
    }
}