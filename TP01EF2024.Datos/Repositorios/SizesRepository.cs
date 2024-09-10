using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01EF2024.Datos.Interfaces;
using TP01EF2024.Entidades;
using TP01EF2024.Entidades.Enums;

namespace TP01EF2024.Datos.Repositorios
{
    public class SizesRepository : ISizesRepository
    {
        private readonly TP01DbContext _context;

        public SizesRepository(TP01DbContext context)
        {
            _context = context;
        }

        public void Agregar(Size size)
        {
            _context.Sizes.Add(size);
        }

        public void Editar(Size size)
        {
            _context.Sizes.Update(size);
        }

        public void Eliminar(Size size)
        {
            _context.Sizes.Remove(size);
        }

        public bool EstaRelacionado(Size size)
        {
            return _context.ShoesSizes.Any(ss => ss.SizeId == size.SizeId);
        }

        public bool Existe(Size size)
        {
            if (size.SizeId == 0)
            {
                return _context.Sizes.Any(s => s.SizeNumber == size.SizeNumber);
            }
            return _context.Sizes.Any(s => s.SizeNumber == size.SizeNumber && s.SizeId != size.SizeId);
        }

        public int GetCantidad()
        {
            return _context.Sizes.Count();
        }

        public Size? GetSizePorId(int id)
        {
            return _context.Sizes.SingleOrDefault(s => s.SizeId == id);
        }

        public List<Size> GetSizes()
        {
            return _context.Sizes.AsNoTracking().ToList();
        }

        public List<Size> GetSizesPaginadosOrdenados(int page, int pageSize, Orden? orden = null)
        {
            IQueryable<Size> query = _context.Sizes.AsNoTracking();

            //ORDEN
            if (orden != null)
            {
                switch (orden)
                {
                    case Orden.AZ:
                        query = query.OrderBy(s => s.SizeNumber);
                        break;
                    case Orden.ZA:
                        query = query.OrderByDescending(s => s.SizeNumber);
                        break;
                    default:
                        break;
                }
            }

            //PAGINADO
            List<Size> listaPaginada = query.AsNoTracking()
                .Skip(page * pageSize) //Saltea estos registros
                .Take(pageSize) //Muestra estos
                .ToList();

            return listaPaginada;
        }

        public List<Shoe> GetShoesForSize(int sizeId)
        {
            //return _context.ShoesSizes
            //    .Include(ss => ss.Shoe)
            //    .Where(ss => ss.SizeId == sizeId)
            //    .Select(ss => ss.Shoe)
            //    .Include(s => s.Brand)
            //    .Include(s => s.Genre)
            //    .Include(s => s.Sport)
            //    .Include(s => s.Colour)
            //    .ToList();
            return _context.ShoesSizes
                .Include(ss => ss.Shoe).ThenInclude(s => s.Brand)
                .Include(ss => ss.Shoe).ThenInclude(s => s.Genre)
                .Include(ss => ss.Shoe).ThenInclude(s => s.Sport)
                .Include(ss => ss.Shoe).ThenInclude(s => s.Colour)
                .Where(ss => ss.SizeId == sizeId)
                .Select(ss => ss.Shoe)
                .ToList();

        }

    }
}
