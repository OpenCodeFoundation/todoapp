using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Techcombd.Todo.Core.SharedKernel;

namespace Todo.Core.Interfaces
{
    interface IAsyncRepository<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> ListAllAsync();
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
