using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01EF2024.Datos.Interfaces;
using TP01EF2024.Entidades;
using TP01EF2024.Entidades.Dtos;
using TP01EF2024.Entidades.Enums;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace TP01EF2024.Datos.Repositorios
{
    public class ShoesRepository : IShoesRepository
    {
        private readonly TP01DbContext _context;

        public ShoesRepository(TP01DbContext context)
        {
            _context = context;
        }

        public void Agregar(Shoe shoe)
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

            _context.Shoes.Add(shoe);
        }

        public void Editar(Shoe shoe)
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

        public void Eliminar(Shoe shoe)
        {
            var brandExist = _context.Brands.Local.FirstOrDefault(b => b.BrandId == shoe.BrandId);

            if (brandExist != null)
            {
                _context.Entry(brandExist).State = EntityState.Detached;
            }

            var sportExist = _context.Sports.Local.FirstOrDefault(s => s.SportId == shoe.SportId);

            if (sportExist != null)
            {
                _context.Entry(sportExist).State = EntityState.Detached;
            }

            var genreExist = _context.Genres.Local.FirstOrDefault(g => g.GenreId == shoe.GenreId);

            if (genreExist != null)
            {
                _context.Entry(genreExist).State = EntityState.Detached;
            }

            var colourExist = _context.Colours.Local.FirstOrDefault(c => c.ColourId == shoe.ColourId);

            if (colourExist != null)
            {
                _context.Entry(colourExist).State = EntityState.Detached;
            }

            var shoeExist = _context.Shoes.Local.FirstOrDefault(s => s.ShoeId == shoe.ShoeId);

            if (shoeExist != null)
            {
                _context.Entry(shoeExist).State = EntityState.Detached;
            }

            _context.Remove(shoe);
        }

        public bool EstaRelacionado(Shoe shoe)
        {
            return _context.ShoesSizes.Any(ss => ss.ShoeId == shoe.ShoeId);
        }

        public bool Existe(Shoe shoe)
        {
            if (shoe.ShoeId == 0)
            {
                return _context.Shoes.Any(s => s.BrandId == shoe.BrandId 
                                            && s.SportId == shoe.SportId 
                                            && s.GenreId == shoe.GenreId
                                            && s.ColourId == shoe.ColourId
                                            && s.Model == shoe.Model
                                            && s.Description == shoe.Description
                                            && s.Price == shoe.Price);
            }
            return _context.Shoes.Any(s => s.BrandId == shoe.BrandId 
                                        && s.SportId == shoe.SportId 
                                        && s.GenreId == shoe.GenreId
                                        && s.ColourId == shoe.ColourId
                                        && s.Model == shoe.Model
                                        && s.Description == shoe.Description
                                        && s.Price == shoe.Price
                                        && s.ShoeId == shoe.ShoeId);
        }

        public Shoe? GetShoePorId(int id)
        {
            return _context.Shoes.
                Include(s => s.Brand).
                Include(s => s.Genre).
                Include(s => s.Sport).
                Include(s => s.Colour).
                AsNoTracking().
                SingleOrDefault(s => s.ShoeId == id);
        }

        public List<Shoe> GetShoes()
        {
            return _context.Shoes.
                Include(s => s.Brand).
                Include(s => s.Sport).
                Include(s => s.Genre).
                Include(s => s.Colour).
                OrderBy(s => s.ShoeId).
                AsNoTracking().ToList();
        }

        public List<ShoeDto> GetListaDto()
        {
            return _context.Shoes
                          .Include(p => p.Brand)
                          .Include(p => p.Genre)
                          .Include(p => p.Colour)
                          .Include(p => p.Sport)
                          .Select(n => new ShoeDto
                          {
                              ShoeId = n.ShoeId,
                              Brand = n.Brand != null ? n.Brand.BrandName : string.Empty,
                              Genre = n.Genre != null ? n.Genre.GenreName : string.Empty,
                              Color = n.Colour != null ? n.Colour.ColourName : string.Empty,
                              Sport = n.Sport != null ? n.Sport.SportName : string.Empty,
                              Model = n.Model,
                              Description = n.Description,
                              Price = n.Price,
                          })
                          .ToList(); ;

        }
        
        public int GetCantidad()
        {
            return _context.Shoes.Count();
        }

        public List<Shoe> GetListaShoesPaginadaOrdenadaFiltrada(
            int page,
            int pageSize,
            Orden? orden = null,
            string? textFil = null,
            Brand? brand = null,
            Sport? sport = null,
            Genre? genre = null,
            Colour? colour = null,
            decimal? maximo = null,
            decimal? minimo = null)
        {
            IQueryable<Shoe> query = _context.Shoes
                .Include(s => s.Brand)
                .Include(s => s.Sport)
                .Include(s => s.Genre)
                .Include(s => s.Colour)
                .AsNoTracking();

            // FILTROS
            if (brand != null)
            {
                query = query
                    .Where(s => s.BrandId == brand.BrandId);
            }
            if (sport != null)
            {
                query = query
                    .Where(s => s.SportId == sport.SportId);
            }
            if (genre != null)
            {
                query = query
                    .Where(s => s.GenreId == genre.GenreId);
            }
            if (colour != null)
            {
                query = query
                    .Where(s => s.ColourId == colour.ColourId);
            }
            //TEXTO FILTRO
            if (textFil != null)
            {
                query = query.Where(s => s.Model.Contains(textFil));
            }
            //PRECIO
            if (maximo != null && minimo != null)
            {
                query = query
                    .Where(s => s.Price <= maximo)
                    .Where(s => s.Price >= minimo);
            }
            //ORDEN
            if (orden != null)
            {
                switch (orden)
                {
                    case Orden.AZ:
                        query = query.OrderBy(s => s.Model);
                        break;
                    case Orden.ZA:
                        query = query.OrderByDescending(s => s.Model);
                        break;
                    case Orden.MenorPrecio:
                        query = query.OrderBy(s => s.Price);
                        break;
                    case Orden.MayorPrecio:
                        query = query.OrderByDescending(s => s.Price);
                        break;
                    default:
                        break;
                }
            }
            //PAGINADO
            List<Shoe> listaPaginada = query.AsNoTracking()
            .Skip(page * pageSize)//Saltea estos registros
            .Take(pageSize)//Muestra estos
            .ToList();
            return listaPaginada;
        }

        public int GetCantidadFiltrada(Brand? brand = null,
            Sport? sport = null,
            Genre? genre = null,
            Colour? colour = null,
            decimal? maximo = null,
            decimal? minimo = null)
        {
            IQueryable<Shoe> query = _context.Shoes.AsNoTracking();
            // FILTROS
            if (brand != null)
            {
                query = query
                    .Where(s => s.BrandId == brand.BrandId);
            }
            if (sport != null)
            {
                query = query
                    .Where(s => s.SportId == sport.SportId);
            }
            if (genre != null)
            {
                query = query
                    .Where(s => s.GenreId == genre.GenreId);
            }
            if (colour != null)
            {
                query = query
                    .Where(s => s.ColourId == colour.ColourId);
            }
            //PRECIO
            if (maximo != null && minimo != null)
            {
                query = query
                    .Where(s => s.Price <= maximo)
                    .Where(s => s.Price >= minimo);
            }

            return query.Count();
        }

        public List<ShoeDto> GetListaShoesDtosPaginadaOrdenadaFiltrada(
            int page,
            int pageSize,
            Orden? orden = null,
            string? textFil = null,
            Brand? brand = null,
            Sport? sport = null,
            Genre? genre = null,
            Colour? colour = null,
            decimal? maximo = null,
            decimal? minimo = null,
            Size? size = null)
        {
            IQueryable<Shoe> query = _context.Shoes
               .Include(s => s.Colour)
               .Include(s => s.Genre)
               .Include(s => s.Sport)
               .Include(s => s.Brand)
               .AsNoTracking();
            // FILTROS
            if (brand != null)
            {
                query = query
                    .Where(s => s.BrandId == brand.BrandId);
            }
            if (sport != null)
            {
                query = query
                    .Where(s => s.SportId == sport.SportId);
            }
            if (genre != null)
            {
                query = query
                    .Where(s => s.GenreId == genre.GenreId);
            }
            if (colour != null)
            {
                query = query
                    .Where(s => s.ColourId == colour.ColourId);
            }
            if (size != null)
            {
                query = query.Where(s => _context.ShoesSizes
                               .Any(ss => ss.ShoeId == s.ShoeId && ss.SizeId == size.SizeId));
            }
            //TEXTO FILTRO
            if (textFil != null)
            {
                query = query.Where(s => s.Model.Contains(textFil));
            }
            //PRECIO
            if (maximo != null)
            {
                query = query.Where(s => s.Price <= maximo);
            }
            if (minimo != null)
            {                               
                query = query.Where(s => s.Price >= minimo);
            }
            //ORDEN
            if (orden != null)
            {
                switch (orden)
                {
                    case Orden.AZ:
                        query = query.OrderBy(s => s.Model);
                        break;
                    case Orden.ZA:
                        query = query.OrderByDescending(s => s.Model);
                        break;
                    case Orden.MenorPrecio:
                        query = query.OrderBy(s => s.Price);
                        break;
                    case Orden.MayorPrecio:
                        query = query.OrderByDescending(s => s.Price);
                        break;
                    default:
                        break;
                }
            }
            //PAGINADO
            List<Shoe> listaPaginada = query
                .Skip(page * pageSize)
                .Take(pageSize)
                .ToList();

            // Mapear los resultados a ShoeListDto
            List<ShoeDto> listaDto = listaPaginada.Select(s =>
                                                  new ShoeDto
                                                  {
                                                      ShoeId = s.ShoeId,
                                                      Model = s.Model,
                                                      Description = s.Description,
                                                      Color = s.Colour?.ColourName ?? "",
                                                      Genre = s.Genre?.GenreName ?? "",
                                                      Sport = s.Sport?.SportName ?? "",
                                                      Brand = s.Brand?.BrandName ?? "",
                                                      Price = s.Price
                                                  })
                                                  .ToList();

            return listaDto;

        }


        public void AgregarShoeSize(ShoeSize nuevaRelacion)
        {
            _context.ShoesSizes.Add(nuevaRelacion);
        }

        public void ActualizarShoeSize(ShoeSize shoeSize)
        {
            var shoeExist = _context.Shoes.Local.FirstOrDefault(s => s.ShoeId == shoeSize.ShoeId);

            if (shoeExist != null)
            {
                _context.Entry(shoeExist).State = EntityState.Detached;
            }
            _context.Set<ShoeSize>().Update(shoeSize);
        }

        public void EliminarShoeSize(ShoeSize shoeSize)
        {
            var shoeExist = _context.Shoes.Local.FirstOrDefault(s => s.ShoeId == shoeSize.ShoeId);

            if (shoeExist != null)
            {
                _context.Entry(shoeExist).State = EntityState.Detached;
            }

            _context.ShoesSizes.Remove(shoeSize);
        }

        public bool ExisteShoeSize(ShoeSize shoesize)
        {
            if (shoesize.ShoeSizeId == 0)
            {
                return _context.ShoesSizes.Any(ss => ss.ShoeId == shoesize.ShoeId
                            && ss.SizeId == shoesize.SizeId);
            }
            else
            {
                return _context.ShoesSizes.Any(ss => ss.ShoeId == shoesize.ShoeId
                            && ss.QuantityInStock == shoesize.QuantityInStock
                            && ss.SizeId == shoesize.SizeId);
            }

        }

        public ShoeSize? GetShoeSize(Shoe shoe, Size size)
        {
            return _context.ShoesSizes
                .Include(ss => ss.Shoe)
                .Include(ss => ss.Size)
                .FirstOrDefault(ss => ss.ShoeId == shoe.ShoeId && ss.SizeId == size.SizeId);
        }

        public List<Size> GetSizesForShoe(int shoeId)
        {
            return _context.ShoesSizes
                .Include(ss => ss.Size)
                .Where(ss => ss.ShoeId == shoeId)
                .Select(ss => ss.Size)
                .AsNoTracking()
                .ToList();

        }

        public List<ShoeSize> GetShoesSizesPaginados(int page, int pageSize, Shoe shoe)
        {
            return _context.ShoesSizes
                                .Include(ss => ss.Shoe)
                                .Include(ss => ss.Size)
                                .Where(ss => ss.ShoeId == shoe.ShoeId)
                                .OrderBy(ss => ss.Size.SizeNumber)
                                .AsNoTracking()
                                .Skip(page * pageSize)//Saltea estos registros
                                .Take(pageSize)//Muestra estos
                                .ToList();
        }

    }

}
