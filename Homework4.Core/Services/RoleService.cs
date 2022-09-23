using Homework4.Core.Entities;

namespace Homework4.Core.Services
{
    public class RoleService
    {
        private readonly List<Role> _roles;

        public RoleService()
        {
            _roles = new List<Role>();

            _roles.Add(new Role { Id = 1, Name = "admin" }); 
            _roles.Add(new Role { Id = 2, Name = "user" });
        }

        public IEnumerable<Role> GetAll()
        {
            return _roles;
        }
    }
}
