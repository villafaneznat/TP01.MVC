using System.Linq.Expressions;
using TP01EF2024.Entidades;

namespace TP01EF2024.Servicios.Interfaces
{
    public interface IColoursService
    {
        IEnumerable<Colour>? GetAll(Expression<Func<Colour,
           bool>>? filter = null,
           Func<IQueryable<Colour>,
           IOrderedQueryable<Colour>>? orderBy = null,
           string? propertiesNames = null);

        void Guardar(Colour colour);

        void Eliminar(Colour colour);

        Colour? Get(Expression<Func<Colour,
            bool>>? filter = null,
            string? propertiesNames = null,
            bool tracked = true);

        bool Existe(Colour colour);

        bool EstaRelacionado(int id);


    }
}
