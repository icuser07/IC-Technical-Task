using System.Linq.Expressions;

namespace BlockCypher.Domain.Interfaces
{
    public interface IRepository<T>
    {
        IQueryable<T> GetAll();
        T GetById(int id);
        Task<T> GetByIdAsync(int id);
        Task<IQueryable<T>> FindAsync(Expression<Func<T, bool>> match);
        void Insert(T entity);
        Task<T> InsertAsync(T entity);
        void Remove(T entity);
        Task RemoveAsync(T entity);
        void RemoveById(int id);
        Task RemoveByIdAsync(int id);
        void Update(T entity);
        Task<T> UpdateAsync(T entity);
    }
}