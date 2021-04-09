using System.Collections.Generic;

using Api.Data.Models;

namespace Api.Interfaces
{
    public interface IUserService
    {
        IEnumerable<UserView> GetUsers();
        UserView GetUser(int id);
        void CreateUser(User user);
    }

}
