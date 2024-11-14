using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TP01EF2024.Entidades;
using TP01EF2024.Entidades.Enums;

namespace TP01EF2024.Servicios.Interfaces
{
    public interface IGenresService
    {
        IEnumerable<Genre>? GetAll(Expression<Func<Genre,
            bool>>? filter = null,
            Func<IQueryable<Genre>,
            IOrderedQueryable<Genre>>? orderBy = null,
            string? propertiesNames = null);

        void Guardar(Genre genre);

        void Eliminar(Genre genre);

        Genre? Get(Expression<Func<Genre,
            bool>>? filter = null,
            string? propertiesNames = null,
            bool tracked = true);

        bool Existe(Genre genre);

        bool EstaRelacionado(int id);

    }
}
