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
    public class GenresRepository : IGenresRepository
    {
        private readonly TP01DbContext _context;

        public GenresRepository(TP01DbContext context)
        {
            _context = context;
        }

        public void Agregar(Genre genre)
        {
            _context.Genres.Add(genre);
        }

        public void Editar(Genre genre)
        {
            _context.Genres.Update(genre);
        }

        public void Eliminar(Genre genre)
        {
            _context.Genres.Remove(genre);
        }

        public bool EstaRelacionado(Genre genre)
        {
            return _context.Shoes.Any(s => s.GenreId == genre.GenreId);
        }

        public bool Existe(Genre genre)
        {
            if (genre.GenreId == 0)
            {
                return _context.Genres.Any(g => g.GenreName == genre.GenreName);
            }
            return _context.Genres.Any(g => g.GenreName == genre.GenreName && g.GenreId != genre.GenreId);
        }

        public Genre? GetGenrePorId(int id)
        {
            return _context.Genres.SingleOrDefault(g =>g.GenreId == id);
        }

        public List<Genre> GetGenres()
        {
            return _context.Genres.AsNoTracking().ToList();
        }

        public int GetCantidad()
        {
            return _context.Genres.Count();
        }

        public List<Shoe>? GetShoes(Genre genre)
        {
            return _context.Shoes.
                Include(s => s.Brand).
                Include(s => s.Sport).
                Include(s => s.Genre).
                Include(s => s.Colour).
                Where(s => s.GenreId == genre.GenreId).ToList();


        }

        public List<Genre> GetGenresPaginadosOrdenados(int page, int pageSize, Orden? orden = null, string? textFil = null)
        {
            IQueryable<Genre> query = _context.Genres.AsNoTracking();

            //TEXTO FILTRO
            if (textFil != null)
            {
                query = query.Where(g => g.GenreName.Contains(textFil));
            }
            //ORDEN
            if (orden != null)
            {
                switch (orden)
                {
                    case Orden.AZ:
                        query = query.OrderBy(g => g.GenreName);
                        break;
                    case Orden.ZA:
                        query = query.OrderByDescending(g => g.GenreName);
                        break;
                    default:
                        break;
                }
            }
            //PAGINADO
            List<Genre> listaPaginada = query.AsNoTracking()
                .Skip(page * pageSize) //Saltea estos registros
                .Take(pageSize) //Muestra estos
                .ToList();

            return listaPaginada;
        }


    }
}
