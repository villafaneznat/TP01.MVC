using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01EF2024.Entidades;

namespace TP01EF2024.Datos.Interfaces
{
    public interface IBrandsRepository:IGenericRepository<Brand>
    {
        void Editar(Brand brand);
        bool EstaRelacionado(int id);
        bool Existe(Brand brand);
    }
}
