using TP01EF2024.Datos.Interfaces;
using TP01EF2024.Entidades;

namespace TP01EF2024.Datos.Repositorios
{
    public class ColoursRepository : GenericRepository<Colour>, IColoursRepository
    {
        private readonly TP01DbContext _context;

        public ColoursRepository(TP01DbContext context) : base(context)
        {
            _context = context;
        }

        public void Editar(Colour colour)
        {
            _context.Colours.Update(colour);
        }

        public bool EstaRelacionado(int id)
        {
            return _context.Shoes.Any(s => s.ColourId == id);
        }

        public bool Existe(Colour colour)
        {
            if (colour.ColourId == 0)
            {
                return _context.Colours
                    .Any(c => c.ColourName == colour.ColourName);
            }
            return _context.Colours
                .Any(c => c.ColourName == colour.ColourName
                && c.ColourId != colour.ColourId);
        }
    }
}
