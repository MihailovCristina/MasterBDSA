namespace Seminar_1.Models
{
    public class User
    {
        public User()
        {
            Username = string.Empty;
            Password = string.Empty;
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime? LastLogin { get; set; }

        public static List<User> GetAll()
        {
            var users = new List<User>();

            users.Add(new User() { Id = 1, Username = "Ionut", Password = "100" });
            users.Add(new User() { Id = 2, Username = "Mihai", Password = "200" });
            users.Add(new User() { Id = 3, Username = "Ioana", Password = "300" });

            return users;
        }
    }
}
