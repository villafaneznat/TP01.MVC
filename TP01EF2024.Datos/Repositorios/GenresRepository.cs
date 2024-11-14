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
    public class GenresRepository : GenericRepository<Genre>, IGenresRepository
    {
        private readonly TP01DbContext _context;
        public GenresRepository(TP01DbContext context) : base(context)
        {
            _context = context;
        }

        public void Editar(Genre genre)
        {
            _context.Genres.Update(genre);
        }

        public bool EstaRelacionado(int id)
        {
            return _context.Shoes.Any(s => s.GenreId == id);
        }

        public bool Existe(Genre genre)
        {
            if (genre.GenreId == 0)
            {
                return _context.Genres
                    .Any(c => c.GenreName == genre.GenreName);
            }
            return _context.Genres
                .Any(c => c.GenreName == genre.GenreName
                && c.GenreId != genre.GenreId);
        }
    }
}

