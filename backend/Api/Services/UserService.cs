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

        public IEnumerable<UserView> GetUsers()
        {
            var users = from user in _unitOfWork.Users.GetAll()
            join role in _unitOfWork.Roles.GetAll()
            on user.RoleId equals role.Id
            select new UserView {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                Hash = user.Hash,
                Role = role
            };

            return users;
        }

        public UserView GetUser(int id)
        {
            var user = _unitOfWork.Users.Get(id);

            return new UserView {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                Hash = user.Hash,
                Role = _unitOfWork.Roles.Get(user.RoleId)
            };
        }


    }
}
