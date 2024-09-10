using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01EF2024.Datos.Interfaces;
using TP01EF2024.Entidades;
using TP01EF2024.Entidades.Enums;
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

        public void Eliminar(Genre genre)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                _repository.Eliminar(genre);
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.RollBack();
                throw;
            }
        }

        public bool EstaRelacionado(Genre genre)
        {
            try
            {
                return _repository.EstaRelacionado(genre);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Existe(Genre genre)
        {
            try
            {
                return _repository.Existe(genre);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Genre? GetGenrePorId(int id)
        {
            try
            {
                return _repository.GetGenrePorId(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Genre> GetGenres()
        {
            try
            {
                return _repository.GetGenres();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int GetCantidad()
        {
            return _repository.GetCantidad();
        }

        public void Guardar(Genre genre)
        {
            try
            {
                _unitOfWork.BeginTransaction();

                if (genre.GenreId == 0)
                {
                    _repository.Agregar(genre);
                }
                else
                {
                    _repository.Editar(genre);
                }

                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.RollBack();
                throw;
            }
        }

        public List<Shoe>? GetShoes(Genre genre)
        {
            return _repository.GetShoes(genre);
        }

        public List<Genre> GetGenresPaginadosOrdenados(int page, int pageSize, Orden? orden = null, string? textFil = null)
        {
            return _repository.GetGenresPaginadosOrdenados(page, pageSize, orden, textFil);
        }


    }
}
