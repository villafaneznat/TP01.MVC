namespace TP01EF2024.Datos.Interfaces
{
    public interface IUnitOfWork
    {
        void BeginTransaction();
        void Commit();
        void RollBack();
        int SaveChanges();
    }
}
