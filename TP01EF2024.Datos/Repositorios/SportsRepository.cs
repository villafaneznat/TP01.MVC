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
    public class SportsRepository : GenericRepository<Sport>, ISportsRepository
    {
        private readonly TP01DbContext _context;

        public SportsRepository(TP01DbContext context) : base(context)
        {
            _context = context;
        }

        public void Editar(Sport sport)
        {
            _context.Sports.Update(sport);
        }

        public bool EstaRelacionado(int id)
        {
            return _context.Shoes.Any(s => s.SportId == id);
        }

        public bool Existe(Sport sport)
        {
            if (sport.SportId == 0)
            {
                return _context.Sports
                    .Any(c => c.SportName == sport.SportName);
            }
            return _context.Sports
                .Any(c => c.SportName == sport.SportName
                && c.SportId != sport.SportId);
        }
    }
}
