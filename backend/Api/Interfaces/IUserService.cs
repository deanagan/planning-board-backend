using System.Collections.Generic;

using Api.Data.Models;

namespace Api.Interfaces
{
    public interface IUserService
    {
        IEnumerable<User> GetUsers();
        User GetUser(int id);
    }

}
