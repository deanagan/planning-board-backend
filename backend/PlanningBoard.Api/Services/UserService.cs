using System.Collections.Generic;
using System.Linq;
using Api.Data.Models;
using Api.Interfaces;
using System.Text;

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
                        select new UserView
                        {
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

            return user != null ? new UserView
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                Hash = user.Hash,
                Role = _unitOfWork.Roles.Get(user.RoleId)
            } : null;
        }

        public void CreateUser(User user)
        {
            var newUser = new User
            {
                Name = user.Name,
                RoleId = user.RoleId,
                Email = user.Email,
                Hash = "todo123"
            };

            _unitOfWork.Users.Add(newUser);

            _unitOfWork.Save();
            user.Id = newUser.Id;

        }

        public bool UpdateUser(User user)
        {
            if (user != null)
            {
                _unitOfWork.Users.Update(user);
                _unitOfWork.Save();
            }

            return user != null;
        }

        public bool DeleteUser(int id)
        {
            var user = _unitOfWork.Users.Get(id);
            if (user != null)
            {
                _unitOfWork.Users.Delete(user);
                _unitOfWork.Save();
            }

            return user != null;
        }

    }
}
