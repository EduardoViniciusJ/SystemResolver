using SystemResolver.Domain.Enums;

namespace SystemResolver.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; } = string.Empty;   
        public string FirebaseId { get; set; }  = string.Empty;
        public Role Role { get; set; }
        private User() { }
        public User(string email, string firebaseId, Role role)
        {
            Email = email;
            FirebaseId = firebaseId;
            Role = role;
        }
    }
}
