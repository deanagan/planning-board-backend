using System.Collections.Generic;
using System.Linq;

namespace PlanningBoard.Api.Interfaces
{
    public interface IDataRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        T Get(params object[] parameters);

        IQueryable<T> GetUsingRawSql(string query, params object[] parameters);

        void Add(T parameter);
        void AddRange(IEnumerable<T> parameters);

        void Update(T parameter);

        void Delete(T parameter);

    }
}
