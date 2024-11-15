using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TP01.MVC.Web.ViewModels.Shoe;
using TP01EF2024.Entidades;
using TP01EF2024.Servicios.Interfaces;
using X.PagedList.Extensions;

namespace TP01.MVC.Web.Controllers
{
    public class ShoesController : Controller
    {
        private readonly IShoesService? _services;
        private readonly IBrandsService _brandService;
        private readonly IColoursService _colorService;
        private readonly IGenresService _genreService;
        private readonly ISportsService _sportService;
        private readonly ISizesService _sizesService;

        private readonly IMapper? _mapper;

        public ShoesController(IShoesService? services, IBrandsService brandService, IColoursService colorService, IGenresService genreService, ISportsService sportService, ISizesService sizesService, IMapper? mapper)
        {
            _services = services;
            _brandService = brandService;
            _colorService = colorService;
            _genreService = genreService;
            _sportService = sportService;
            _sizesService = sizesService;
            _mapper = mapper;
        }

        public IActionResult Index(int? page, string? search= null, int? FilterBrandId = null, int? FilterColourId = null, int? FilterGenreId = null, int? FilterSportId = null, bool verTodo = false, string? orden = null)
        {
            int pagenumber = page ?? 1;
            int pageSize = 8;
            ViewBag.Search = search;
            ViewBag.FilterBrandId = FilterBrandId;
            ViewBag.FilterColourId = FilterColourId;
            ViewBag.FilterGenreId = FilterGenreId;
            ViewBag.FilterSportId = FilterSportId;
            IEnumerable<Shoe> shoes;
            if (!verTodo)
            {
                if (!string.IsNullOrEmpty(search) || FilterBrandId != null || FilterColourId != null || FilterGenreId != null || FilterSportId != null)
                {
                    if (search != null && FilterBrandId == null && FilterColourId == null && FilterGenreId == null && FilterSportId == null)
                    {
                        shoes = _services!.GetAll(propertiesNames: "Sport,Brand,Colour,Genre", orderBy: o => o.OrderBy(s => s.Model),
                                    filter: f => f.Model!.Contains(search!) || f.Sport!.SportName.Contains(search) || f.Brand!.BrandName.Contains(search))!;
                    }
                    else
                    {
                        search = string.Empty;
                        ViewBag.Search = search;
                        shoes = _services!.GetAll(propertiesNames: "Sport,Brand,Colour,Genre", orderBy: o => o.OrderBy(order => order.Model),
                            filter: f => 
                            (FilterBrandId == null || f.BrandId == FilterBrandId) &&
                            (FilterColourId == null || f.ColourId == FilterColourId) &&
                            (FilterGenreId == null || f.GenreId == FilterGenreId) &&
                            (FilterSportId == null || f.SportId == FilterSportId))!;
                    }

                }
                else
                {
                    shoes = _services!.GetAll(orderBy: o => o.OrderBy(s => s.Model), propertiesNames: "Sport,Brand,Colour,Genre")!;
                }
            }
            else
            {
                ViewBag.Search = null;
                ViewBag.FilterBrandId = null;
                ViewBag.FilterColourId = null;
                ViewBag.FilterGenreId = null;
                ViewBag.FilterSportId = null;

                shoes = _services!.GetAll(orderBy: o => o.OrderBy(s => s.Model), propertiesNames: "Sport,Brand,Colour,Genre")!;
            }

            var listavm = _mapper?.Map<IEnumerable<ShoeViewModel>>(shoes).ToList();
            switch (orden)
            {
                case "AZ":
                    listavm = listavm!.OrderBy(o => o.Model).ToList();
                    break;
                case "ZA":
                    listavm = listavm!.OrderByDescending(o => o.Model).ToList();
                    break;
                case "MenorPrecio":
                    listavm = listavm!.OrderBy(s => s.Price).ToList();
                    break;
                case "MayorPrecio":
                    listavm = listavm!.OrderByDescending(s => s.Price).ToList();
                    break;
                default:
                    break;
            }
            var shoeFilterVM = new ShoeFilterViewModel()
            {
                Shoes = listavm!.ToPagedList(pagenumber, pageSize),
                Brands = _brandService!.GetAll(orderBy: o => o.OrderBy(order => order.BrandName))!.Select(s => new SelectListItem { Text = s.BrandName, Value = s.BrandId.ToString() }).ToList(),
                Genres = _genreService!.GetAll(orderBy: o => o.OrderBy(order => order.GenreName))!.Select(s => new SelectListItem { Text = s.GenreName, Value = s.GenreId.ToString() }).ToList(),
                Colours = _colorService!.GetAll(orderBy: o => o.OrderBy(order => order.ColourName))!.Select(s => new SelectListItem { Text = s.ColourName, Value = s.ColourId.ToString() }).ToList(),
                Sports = _sportService!.GetAll(orderBy: o => o.OrderBy(order => order.SportName))!.Select(s => new SelectListItem { Text = s.SportName, Value = s.SportId.ToString() }).ToList(),

            };
            return View(shoeFilterVM);
        }

        public IActionResult Details(int? id)
        {
            if (id is null || id == 0)
            {
                return NotFound();
            }
            Shoe shoe = _services.Get(filter: s => s.ShoeId == id, propertiesNames: "Brand,Sport,Genre,Colour");
            if (shoe is null)
            {
                return NotFound();
            }
            ShoeViewModel shoeVM = _mapper.Map<ShoeViewModel>(shoe);
            return View(shoeVM);
        }

        public IActionResult Create()
        {
            ShoeEditViewModel? shoeVM = new ShoeEditViewModel();
            RecargarCombos(shoeVM);
            return View(shoeVM);
        }

        private void RecargarCombos(ShoeEditViewModel shoeVM)
        {
            shoeVM!.Brands = _brandService!.GetAll()!
               .Select(b => new SelectListItem
               {
                   Text = b.BrandName,
                   Value = b.BrandId.ToString()
               }
               ).ToList();
            shoeVM.Colours = _colorService!.GetAll()!
              .Select(c => new SelectListItem
              {
                  Text = c.ColourName,
                  Value = c.ColourId.ToString()
              }
              ).ToList();
            shoeVM.Genres = _genreService!.GetAll()!
              .Select(g => new SelectListItem
              {
                  Text = g.GenreName,
                  Value = g.GenreId.ToString()
              }
              ).ToList();
            shoeVM.Sports = _sportService!.GetAll()!
              .Select(s => new SelectListItem
              {
                  Text = s.SportName,
                  Value = s.SportId.ToString()
              }
              ).ToList();
        }

        [HttpPost]
        public IActionResult Create(ShoeEditViewModel shoeVM)
        {
            if (!ModelState.IsValid)
            {
                return View(shoeVM);
            }
            Shoe shoe = _mapper.Map<Shoe>(shoeVM);
            if (shoe is null)
            {
                ModelState.AddModelError(string.Empty, "Zapatilla es nulo");
                return View(shoeVM);
            }
            if (_services.Existe(shoe))
            {
                ModelState.AddModelError(string.Empty, "El registro ya existe");
                return View(shoeVM);
            }
            _services.Guardar(shoe);
            TempData["success"] = "Registro agregado satisfactoriamente";
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if (id is null || id == 0)
            {
                return NotFound();
            }
            Shoe shoe = _services.Get(filter: s => s.ShoeId == id);
            if (shoe is null)
            {
                return NotFound();
            }
            ShoeEditViewModel shoeVM = _mapper.Map<ShoeEditViewModel>(shoe);
            RecargarCombos(shoeVM);
            return View(shoeVM);
        }
        [HttpPost]
        public IActionResult Edit(ShoeEditViewModel shoeVM)
        {
            if (!ModelState.IsValid)
            {
                return View(shoeVM);
            }
            Shoe shoe = _mapper.Map<Shoe>(shoeVM);
            if (shoe is null)
            {
                ModelState.AddModelError(string.Empty, "La zapatilla es nula");
                return View(shoeVM);
            }
            if (_services.Existe(shoe))
            {
                ModelState.AddModelError(string.Empty, "El registro ya existe");
                return View(shoeVM);
            }
            _services.Guardar(shoe);
            TempData["success"] = "Registro editado satisfactoriamente";
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id is null || id == 0)
            {
                return NotFound();
            }
            Shoe shoe = _services.Get(filter: s => s.ShoeId == id, propertiesNames: "Brand,Sport,Genre,Colour");
            if (shoe is null)
            {
                return NotFound();
            }
            ShoeViewModel shoeVM = _mapper.Map<ShoeViewModel>(shoe);
            return View(shoeVM);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            Shoe shoe = _services.Get(filter: s => s.ShoeId == id, propertiesNames: "Brand,Sport,Genre,Colour");
            if (shoe is null)
            {
                return NotFound();
            }
            if (_services.EstaRelacionado(shoe.ShoeId))
            {
                ModelState.AddModelError(string.Empty, "El registro no puede borrarse, está relacionado");
                ShoeViewModel shoeVM = _mapper.Map<ShoeViewModel>(shoe);
                return View(shoeVM);
            }
            _services.Eliminar(shoe);
            TempData["success"] = "Registro eliminado correctamente";
            return RedirectToAction("Index");
        }

        public IActionResult GetShoesSizes(int id, int? page, string? filtro)
        {
            int pageNum = page ?? 1;
            int pageSize = 6;
            var shoesSizes = _services.GetAllShoesSizes(id);

            if (shoesSizes == null || !shoesSizes.Any())
            {
                return NotFound();
            }
            if (!string.IsNullOrEmpty(filtro))
            {
                var sizes = _sizesService.GetAll(filter: s => s.SizeNumber.ToString().Contains(filtro));
                shoesSizes = shoesSizes.Where(ss => sizes.Any(s => s.SizeNumber == ss.Size.SizeNumber)).ToList();
                if (shoesSizes.Count() > 0)
                {
                    pageSize = shoesSizes.Count();
                }
            }

            var sizeStockVM = _mapper.Map<List<SizeStockViewModel>>(shoesSizes).ToPagedList(pageNum, pageSize);
            if (sizeStockVM == null || !sizeStockVM.Any())
            {
                ViewBag.IdError = id;
            }
            ViewBag.CurrentPage = pageNum;
            ViewBag.Filtro = filtro;
            return View(sizeStockVM);
        }

        public IActionResult Plus(decimal sizeNumber, int shoeId, int? page, string? filter)
        {
            ShoeSize shoeSize = _services.GetShoeSizeBySizeNumber(sizeNumber, shoeId);

            if (shoeSize == null)
            {
                var size = _sizesService.Get(filter: s => s.SizeNumber == sizeNumber);
                shoeSize = new ShoeSize
                {
                    ShoeId = shoeId,
                    SizeId = size.SizeId,
                    QuantityInStock = 1
                };

                _services.InsertShoeSize(shoeSize);
            }
            else
            {
                if (shoeSize.QuantityInStock >= 0)
                {
                    shoeSize.QuantityInStock += 1;
                    _services.UpdateShoeSize(shoeSize);
                }
            }
            return RedirectToAction("GetShoesSizes", new { id = shoeId, page = page, filtro = filter });

        }

        public IActionResult Minus(decimal sizeNumber, int shoeId, int? page, string? filter)
        {
            ShoeSize shoeSize = _services.GetShoeSizeBySizeNumber(sizeNumber, shoeId);
            if (shoeSize.QuantityInStock >= 1)
            {
                shoeSize.QuantityInStock -= 1;
                _services.UpdateShoeSize(shoeSize);
            }
            return RedirectToAction("GetShoesSizes", new { id = shoeId, page = page, filtro = filter });

        }

        [HttpPost]
        public IActionResult UpdateStock(int stock, decimal sizeNumber, int shoeId, int? page, string? filter)
        {
            ShoeSize shoeSize = _services.GetShoeSizeBySizeNumber(sizeNumber, shoeId);

            if (shoeSize != null)
            {
                if (stock >= 0)
                {
                    shoeSize.QuantityInStock = stock;
                    _services.UpdateShoeSize(shoeSize);
                }
            }
            else
            {
                var size = _sizesService.Get(filter: s => s.SizeNumber == sizeNumber);
                shoeSize = new ShoeSize
                {
                    ShoeId = shoeId,
                    SizeId = size.SizeId,
                    QuantityInStock = stock
                };

                _services.InsertShoeSize(shoeSize);

            }
            return RedirectToAction("GetShoesSizes", new { id = shoeId, page = page, filtro = filter });


        }

    }
}

