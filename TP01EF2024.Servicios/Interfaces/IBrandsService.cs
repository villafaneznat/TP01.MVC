﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TP01EF2024.Entidades;
using TP01EF2024.Entidades.Enums;

namespace TP01EF2024.Servicios.Interfaces
{
    public interface IBrandsService
    {
        IEnumerable<Brand>? GetAll(Expression<Func<Brand, 
            bool>>? filter = null,
            Func<IQueryable<Brand>, 
            IOrderedQueryable<Brand>>? orderBy = null,
            string? propertiesNames = null);

        void Guardar(Brand brand);

        void Eliminar(Brand brand);

        Brand? Get(Expression<Func<Brand, 
            bool>>? filter = null,
            string? propertiesNames = null,
            bool tracked = true);

        bool Existe(Brand brand);

        bool EstaRelacionado(int id);



    }
}
