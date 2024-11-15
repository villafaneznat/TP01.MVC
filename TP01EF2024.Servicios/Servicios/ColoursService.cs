using System.Linq.Expressions;
using TP01EF2024.Datos.Interfaces;
using TP01EF2024.Entidades;
using TP01EF2024.Servicios.Interfaces;

namespace TP01EF2024.Servicios.Servicios
{
    public class ColoursService : IColoursService
    {
        private readonly IColoursRepository _repository;

        private readonly IUnitOfWork _unitOfWork;
        public ColoursService(IColoursRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public void Eliminar(Colour colour)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                _repository.Eliminar(colour);
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

        public bool Existe(Colour colour)
        {
            try
            {
                return _repository.Existe(colour);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Colour? Get(Expression<Func<Colour, bool>>? filter = null, string? propertiesNames = null, bool tracked = true)
        {
            return _repository!.Get(filter, propertiesNames, tracked);
        }

        public IEnumerable<Colour>? GetAll(Expression<Func<Colour, bool>>? filter = null, Func<IQueryable<Colour>, IOrderedQueryable<Colour>>? orderBy = null, string? propertiesNames = null)
        {
            return _repository!.GetAll(filter, orderBy, propertiesNames);
        }

        public void Guardar(Colour colour)
        {
            try
            {
                _unitOfWork.BeginTransaction();

                if (colour.ColourId == 0)
                {
                    _repository.Agregar(colour);
                }
                else
                {
                    _repository.Editar(colour);
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
