using Microsoft.EntityFrameworkCore;
using TP01EF2024.Datos.Interfaces;
using TP01EF2024.Entidades;

namespace TP01EF2024.Datos.Repositorios
{
    public class ShoesRepository : GenericRepository<Shoe>, IShoesRepository
    {
        private readonly TP01DbContext _context;

        public ShoesRepository(TP01DbContext context) : base(context)
        {
            _context = context;
        }

        public bool Exist(Shoe shoe)
        {
            if (shoe.ShoeId == 0)
            {
                return _context.Shoes.Any(s => s.BrandId == shoe.BrandId
                                            && s.SportId == shoe.SportId
                                            && s.GenreId == shoe.GenreId
                                            && s.ColourId == shoe.ColourId
                                            && s.Model == shoe.Model
                                            && s.Description == shoe.Description
                                            && s.Price == shoe.Price
                                            && s.Active == shoe.Active);
            }
            return _context.Shoes.Any(s => s.BrandId == shoe.BrandId
                                        && s.SportId == shoe.SportId
                                        && s.GenreId == shoe.GenreId
                                        && s.ColourId == shoe.ColourId
                                        && s.Model == shoe.Model
                                        && s.Description == shoe.Description
                                        && s.Price == shoe.Price
                                        && s.Active == shoe.Active
                                        && s.ShoeId == shoe.ShoeId);
        }

        public bool ItsRelated(int id)
        {
            return _context.ShoesSizes.Any(ss => ss.ShoeId == id);
        }

        public void Update(Shoe shoe)
        {
            var brandExist = _context.Brands.FirstOrDefault(b => b.BrandId == shoe.BrandId);

            if (brandExist != null)
            {
                _context.Attach(brandExist);
                shoe.Brand = brandExist;
            }

            var sportExist = _context.Sports.FirstOrDefault(s => s.SportId == shoe.SportId);

            if (sportExist != null)
            {
                _context.Attach(sportExist);
                shoe.Sport = sportExist;
            }

            var genreExist = _context.Genres.FirstOrDefault(g => g.GenreId == shoe.GenreId);

            if (genreExist != null)
            {
                _context.Attach(genreExist);
                shoe.Genre = genreExist;
            }

            var colourExist = _context.Colours.FirstOrDefault(c => c.ColourId == shoe.ColourId);

            if (colourExist != null)
            {
                _context.Attach(colourExist);
                shoe.Colour = colourExist;
            }

            var shoeExist = _context.Shoes.Local.FirstOrDefault(s => s.ShoeId == shoe.ShoeId);

            if (shoeExist != null)
            {
                _context.Entry(shoeExist).State = EntityState.Detached;
            }

            _context.Shoes.Update(shoe);

        }

        public ShoeSize? GetShoeSizeBySizeNumber(decimal sizeNumber, int shoeId)
        {
            return _context.ShoesSizes
            .FromSqlRaw("EXEC GetShoeSizeBySizeNumber @SizeNumber = {0}, @ShoeId = {1}", sizeNumber, shoeId)
            .AsEnumerable() //Me traigo el resultado del procedimiento, termina la ejecucion de la consulta "en la base"
            .FirstOrDefault(); //Ejecuto en memoria, para poder tener un objeto y no un Enumerable o List
        }

        public List<ShoeSize> GetAllShoesSizes(int shoeId)
        {
            var shoesSizes = _context.ShoesSizes
            .FromSqlRaw("EXEC GetAllSizesWithStock @ShoeId = {0}", shoeId)
            .ToList();

            //porque Sizes viene null y lo necesito para mappear con SizeStockViewModel
            foreach (var shoeSize in shoesSizes)
            {
                shoeSize.Size = _context.Sizes.FirstOrDefault(s => s.SizeId == shoeSize.SizeId);
            }

            return shoesSizes;
        }

        public void UpdateShoeSize (ShoeSize ss)
        {
            _context.ShoesSizes.Update(ss);
        }

        public void InsertShoeSize(ShoeSize shoeSize)
        {
            _context.ShoesSizes.Add(shoeSize);
        }
    }
}
