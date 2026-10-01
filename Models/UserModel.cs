namespace MVC_Project.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;

        private static readonly List<UserModel> _users = new()
        {
            new UserModel { Id = 1, Name = "Alice", Role = "Backend Developer" },
            new UserModel { Id = 2, Name = "Bob", Role = "Frontend Developer" },
            new UserModel { Id = 3, Name = "Charlie", Role = "UI/UX Designer" }
        };

        public static List<UserModel> GetAll() => _users;

        public static void Add(UserModel user)
        {
            user.Id = _users.Count + 1;
            _users.Add(user);
        }
    }
}