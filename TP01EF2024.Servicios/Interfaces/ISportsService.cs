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
    public interface ISportsService
    {
        IEnumerable<Sport>? GetAll(Expression<Func<Sport,
            bool>>? filter = null,
            Func<IQueryable<Sport>,
            IOrderedQueryable<Sport>>? orderBy = null,
            string? propertiesNames = null);

        void Guardar(Sport sport);

        void Eliminar(Sport sport);

        Sport? Get(Expression<Func<Sport,
            bool>>? filter = null,
            string? propertiesNames = null,
            bool tracked = true);

        bool Existe(Sport sport);

        bool EstaRelacionado(int id);

    }
}
