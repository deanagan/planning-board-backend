using System.Collections.Generic;
using System.Linq;
using Api.Data.Models;
using Api.Interfaces;

namespace Api.Services
{
    public class UserService : IUserService
    {
        private List<User> _users = new List<User>();

        public UserService()
        {
            // Temporary Data
            _users.Add(new User ( id: 1, name: "John Doe",   role: new Role(
                id: 1,
                name: "Scrum Master",
                description: "A scrum master has more administration rights."),  email: "john.doe@planningboard.com",   hash: "123456"));

            _users.Add(new User ( id: 2, name: "Joe Black",  role: new Role(
                id: 2,
                name: "Developer",
                description: "A developer can do basic operations."),    email: "joe.black@planningboard.com",  hash: "23248"));

            _users.Add(new User ( id: 3, name: "Mary Sheep", role: new Role(
                id: 2,
                name: "Developer",
                description: "A developer can do basic operations."),   email: "mary.sheep@planningboard.com", hash: "74546"));
        }

        public IEnumerable<User> GetUsers() => _users;
        public User GetUser(int id) => _users.Find(user => user.Id == id) ?? null;


    }
}
