﻿using System.Linq.Expressions;
using TP01EF2024.Datos.Interfaces;
using TP01EF2024.Entidades;
using TP01EF2024.Servicios.Interfaces;

namespace TP01EF2024.Servicios.Servicios
{
    public class BrandsService : IBrandsService
    {
        private readonly IBrandsRepository _repository;

        private readonly IUnitOfWork _unitOfWork;

        public BrandsService(IBrandsRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public void Eliminar(Brand brand)
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

        public bool Existe(Brand brand)
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

        public Brand? Get(Expression<Func<Brand, bool>>? filter = null, string? propertiesNames = null, bool tracked = true)
        {
            return _repository!.Get(filter, propertiesNames, tracked);
        }

        public IEnumerable<Brand>? GetAll(Expression<Func<Brand, bool>>? filter = null, Func<IQueryable<Brand>, IOrderedQueryable<Brand>>? orderBy = null, string? propertiesNames = null)
        {
            return _repository!.GetAll(filter, orderBy, propertiesNames);
        }

        public void Guardar(Brand brand)
        {
            try
            {
                _unitOfWork.BeginTransaction();

                if (brand.BrandId == 0)
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
