using TP01EF2024.Entidades;

namespace TP01EF2024.Datos.Interfaces
{
    public interface ISportsRepository:IGenericRepository<Sport>
    {
        void Editar(Sport sport);
        bool EstaRelacionado(int id);
        bool Existe(Sport sport);

    }
}
