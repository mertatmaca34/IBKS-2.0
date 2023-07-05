namespace Core.Entities.Concrete
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required byte[] PasswordSalt { get; set; }
        public required byte[] PasswordHash { get; set; }
        public bool Status { get; set; }
    }
}
