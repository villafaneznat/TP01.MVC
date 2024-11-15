using System.Linq.Expressions;

namespace TP01EF2024.Datos.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll(Expression<Func<T, bool>>? 
            filter = null,
            Func<IQueryable<T>, 
            IOrderedQueryable<T>>? orderBy = null,
            string? propertiesNames = null);

        T? Get(Expression<Func<T, 
            bool>>? filter = null,
            string? propertiesNames = null, 
            bool tracked = true);

        void Agregar(T entity);

        void Eliminar(T entity);

    }
}
