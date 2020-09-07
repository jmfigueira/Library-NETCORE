namespace Library.Domain.Entities
{
    public class User : BaseEntity<int>
    {
        public User(int id, string name, string email, string password, bool isAdmin) : base(id)
        {
            Name = name;
            Email = email;
            Password = password;
            IsAdmin = isAdmin;
        }

        public string Name { get; }
        public string Password { get; }
        public string Email { get; }
        public bool IsAdmin { get; }
    }
}