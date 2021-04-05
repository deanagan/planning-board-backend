using Api.Data.Models;
using Api.Data.Access;
using Api.Interfaces;

namespace Api.Data.Contexts
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private DataRepository<User> _users;
        private DataRepository<Role> _roles;
        // private DataRepository<ItemDetail> _itemDetails;
        // private DataRepository<CheckListToItemDetail> _checkListToItemDetails;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public IDataRepository<User> Users
        {
            get { return _users ?? (_users = new DataRepository<User>(_context)); }
        }

        public IDataRepository<Role> Roles
        {
            get { return _roles ?? (_roles = new DataRepository<Role>(_context));}
        }

        // public IDataRepository<ItemDetail> ItemDetails
        // {
        //     get { return _itemDetails ?? (_itemDetails = new DataRepository<ItemDetail>(_context));}
        // }
        // public IDataRepository<CheckListToItemDetail> CheckListToItemDetails
        // {
        //     get { return _checkListToItemDetails ?? (_checkListToItemDetails = new DataRepository<CheckListToItemDetail>(_context));}
        // }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
