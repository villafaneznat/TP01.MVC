using System.Linq.Expressions;
using TP01EF2024.Datos.Interfaces;
using TP01EF2024.Entidades;
using TP01EF2024.Servicios.Interfaces;

namespace TP01EF2024.Servicios.Servicios
{
    public class GenresService : IGenresService
    {
        private readonly IGenresRepository _repository;

        private readonly IUnitOfWork _unitOfWork;

        public GenresService(IGenresRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public void Eliminar(Genre brand)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                _repository.Eliminar(brand);
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.RollBack();
                throw;
            }
        }

        public bool EstaRelacionado(int id)
        {
            try
            {
                return _repository.EstaRelacionado(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Existe(Genre brand)
        {
            try
            {
                return _repository.Existe(brand);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Genre? Get(Expression<Func<Genre, bool>>? filter = null, string? propertiesNames = null, bool tracked = true)
        {
            return _repository!.Get(filter, propertiesNames, tracked);
        }

        public IEnumerable<Genre>? GetAll(Expression<Func<Genre, bool>>? filter = null, Func<IQueryable<Genre>, IOrderedQueryable<Genre>>? orderBy = null, string? propertiesNames = null)
        {
            return _repository!.GetAll(filter, orderBy, propertiesNames);
        }

        public void Guardar(Genre brand)
        {
            try
            {
                _unitOfWork.BeginTransaction();

                if (brand.GenreId == 0)
                {
                    _repository.Agregar(brand);
                }
                else
                {
                    _repository.Editar(brand);
                }

                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.RollBack();
                throw;
            }
        }
    }
}
