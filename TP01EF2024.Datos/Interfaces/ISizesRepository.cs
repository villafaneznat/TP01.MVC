using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01EF2024.Entidades.Enums;
using TP01EF2024.Entidades;

namespace TP01EF2024.Datos.Interfaces
{
    public interface ISizesRepository
    {
        void Agregar(Size size);
        void Editar(Size size);
        void Eliminar(Size size);
        bool EstaRelacionado(Size size);
        bool Existe(Size size);
        Size? GetSizePorId(int id);
        List<Size> GetSizes();
        int GetCantidad();
        List<Size> GetSizesPaginadosOrdenados(int page, int pageSize, Orden? orden = null);
        List<Shoe>? GetShoesForSize(int sizeId);
    }
}
