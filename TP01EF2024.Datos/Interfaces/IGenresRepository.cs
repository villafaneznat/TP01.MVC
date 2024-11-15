using TP01EF2024.Entidades;

namespace TP01EF2024.Datos.Interfaces
{
    public interface IGenresRepository:IGenericRepository<Genre>
    {
        void Editar(Genre genre);
        bool EstaRelacionado(int id);
        bool Existe(Genre genre);
    }
}
