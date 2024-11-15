using TP01EF2024.Datos.Interfaces;
using TP01EF2024.Entidades;

namespace TP01EF2024.Datos.Repositorios
{
    public class BrandsRepository : GenericRepository<Brand>, IBrandsRepository
    {
        private readonly TP01DbContext _context;
        public BrandsRepository(TP01DbContext context) : base(context)
        {
            _context = context;
        }

        public void Editar(Brand brand)
        {
            _context.Brands.Update(brand);
        }

        public bool EstaRelacionado(int id)
        {
            return _context.Shoes.Any(s => s.BrandId == id);
        }

        public bool Existe(Brand brand)
        {
            if (brand.BrandId == 0)
            {
                return _context.Brands
                    .Any(c => c.BrandName == brand.BrandName);
            }
            return _context.Brands
                .Any(c => c.BrandName == brand.BrandName
                && c.BrandId != brand.BrandId);
        }
    }
}
