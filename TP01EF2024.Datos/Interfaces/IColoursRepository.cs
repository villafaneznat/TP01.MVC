using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01EF2024.Entidades;
using TP01EF2024.Entidades.Enums;

namespace TP01EF2024.Datos.Interfaces
{
    public interface IColoursRepository : IGenericRepository<Colour>
    {
        void Editar(Colour colour);
        bool EstaRelacionado(int id);
        bool Existe(Colour colour);


    }
}
