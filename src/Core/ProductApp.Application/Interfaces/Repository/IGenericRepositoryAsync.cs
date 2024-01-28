using ProductApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Interfaces.Repository
{
    public interface IGenericRepositoryAsync<T> where T : class
    {
        Task<List<T>> GetAllAsync();

        Task<T> GetByIdAsync(Guid id);

        Task<T> AddAsynch(T entity);
    }
}
