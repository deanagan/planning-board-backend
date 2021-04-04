using Api.Data.Models;

namespace Api.Interfaces
{
    public interface IUnitOfWork
    {
        // IDataRepository<CheckList> CheckLists { get; }
        IDataRepository<User> Users { get; }
        // IDataRepository<ItemDetail> ItemDetails { get; }
        // IDataRepository<CheckListToItemDetail> CheckListToItemDetails { get; }
        void Save();
    }
}
