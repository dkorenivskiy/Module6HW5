using Homework4.Core.Entities;

namespace Homework4.Core.Services
{
    public class UserService
    {
        private readonly List<User> _users;

        public UserService(RoleService roleService)
        {
            Role? role = roleService.GetAll().FirstOrDefault(r => r.Name == "user");

            _users = new List<User>();
            _users.Add(new User
            {
                Id = 1,
                Email = "user@gmail.com",
                Password = "123",
                Role = role,
                RoleId = role.Id
            });
        }

        public void Create(User user)
        {
            _users.Add(user);
        }

        public IEnumerable<User> GetAll()
        {
            return _users;
        }
    }
}
