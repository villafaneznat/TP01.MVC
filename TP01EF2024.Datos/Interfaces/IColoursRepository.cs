using TP01EF2024.Entidades;

namespace TP01EF2024.Datos.Interfaces
{
    public interface IColoursRepository : IGenericRepository<Colour>
    {
        void Editar(Colour colour);
        bool EstaRelacionado(int id);
        bool Existe(Colour colour);


    }
}
