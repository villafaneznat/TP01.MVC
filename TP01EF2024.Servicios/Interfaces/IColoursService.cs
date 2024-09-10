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
