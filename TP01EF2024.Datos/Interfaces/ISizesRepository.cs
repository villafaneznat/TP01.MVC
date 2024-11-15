using TP01EF2024.Entidades;

namespace TP01EF2024.Datos.Interfaces
{
    public interface ISizesRepository : IGenericRepository<Size>
    {
        void Editar(Size size);
        bool EstaRelacionado(Size size);
        bool Existe(Size size);
        int GetCantidad();
        List<Shoe>? GetShoesForSize(int sizeId);
    }
}
