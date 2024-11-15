﻿using System.Linq.Expressions;
using TP01EF2024.Datos.Interfaces;
using TP01EF2024.Entidades;
using TP01EF2024.Servicios.Interfaces;

namespace TP01EF2024.Servicios.Servicios
{
    public class SizesService : ISizesService
    {
        private readonly ISizesRepository _repository;

        private readonly IUnitOfWork _unitOfWork;

        public SizesService(ISizesRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public void Eliminar(Size size)
        {
            try
            {
                try
                {
                    _unitOfWork.BeginTransaction();
                    _repository.Eliminar(size);
                    _unitOfWork.Commit();
                }
                catch (Exception)
                {
                    _unitOfWork.RollBack();
                    throw;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool EstaRelacionado(Size size)
        {
            try
            {
                return _repository.EstaRelacionado(size);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Existe(Size size)
        {
            try
            {
                return _repository.Existe(size);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int GetCantidad()
        {
            try
            {
                return _repository.GetCantidad();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Guardar(Size size)
        {
            try
            {
                _unitOfWork.BeginTransaction();

                if (size.SizeId == 0)
                {
                    _repository.Agregar(size);
                }
                else
                {
                    _repository.Editar(size);
                }

                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.RollBack();
                throw;
            }
        }

        public List<Shoe>? GetShoesForSize(int sizeId)
        {
            try
            {
                return _repository.GetShoesForSize(sizeId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<Size>? GetAll(Expression<Func<Size, bool>>? filter = null, Func<IQueryable<Size>, IOrderedQueryable<Size>>? orderBy = null, string? propertiesNames = null)
        {
            return _repository!.GetAll(filter, orderBy, propertiesNames);
        }

        public Size? Get(Expression<Func<Size, bool>>? filter = null, string? propertiesNames = null, bool tracked = true)
        {
            return _repository!.Get(filter, propertiesNames, tracked);
        }

    }
}
