using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01EF2024.Entidades;
using TP01EF2024.Entidades.Enums;

namespace TP01EF2024.Datos.Interfaces
{
    public interface ISportsRepository:IGenericRepository<Sport>
    {
        void Editar(Sport sport);
        bool EstaRelacionado(int id);
        bool Existe(Sport sport);

    }
}
