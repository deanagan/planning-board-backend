using Api.Data.Models;

namespace Api.Interfaces
{
    public interface IUnitOfWork
    {
        IDataRepository<User> Users { get; }
        IDataRepository<Role> Roles { get; }
        void Save();
    }
}
