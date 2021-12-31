using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApplicationDataAccess.Repository.Interfaces
{
    public interface IBaseRepo<T> where T : class
    {
        Task<IEnumerable<T>> Get();
        Task<T> GetByID(int id);
        Task<T> Create(T model);
        Task<T> Update(T models);
        Task<T> Delete(int id);
        Task<bool> SaveChages();
    }
}
