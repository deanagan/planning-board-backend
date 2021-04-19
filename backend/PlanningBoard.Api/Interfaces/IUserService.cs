using System.Collections.Generic;

using PlanningBoard.Api.Data.Models;

namespace PlanningBoard.Api.Interfaces
{
    public interface IUserService
    {
        IEnumerable<UserView> GetUsers();
        UserView GetUser(int id);
        void CreateUser(User user);
        bool UpdateUser(User user);

        bool DeleteUser(int id);
    }

}
