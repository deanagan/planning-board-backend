using System.Collections.Generic;
using System.Linq;
using Api.Data.Models;
using Api.Interfaces;

namespace Api.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<User> GetUsers()
        {
            return _unitOfWork.Users.GetAll();
        }

        public User GetUser(int id)
        {
            var user = _unitOfWork.Users.Get(id);

            user.Role = _unitOfWork.Roles.Get(user.RoleId);

            return user;
        }


    }
}
