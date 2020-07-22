using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkLibrary.Services
{
    public interface IDataService<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetByID(int id);
        Task<T> Create(T entity);
        Task<T> Update(int id, T entity);
        Task<bool> Delete(T entity);
    }
}
