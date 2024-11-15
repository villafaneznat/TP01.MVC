using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TP01.MVC.Web.ViewModels.Size;
using TP01EF2024.Entidades;
using TP01EF2024.Servicios.Interfaces;
using X.PagedList.Extensions;

namespace TP01.MVC.Web.Controllers
{
    public class SizesController : Controller
    {
        private readonly ISizesService? _services;
        private readonly IShoesService? _shoesServices;

        private readonly IMapper? _mapper;

        public SizesController(ISizesService? services, IShoesService? shoesServices, IMapper? mapper)
        {
            _services = services;
            _shoesServices = shoesServices;
            _mapper = mapper;
        }

        public IActionResult Index(int? page)
        {
            int pageNum = page ?? 1;
            int pageSize = 8;
            var sizes = _services?.GetAll(orderBy: s => s.OrderBy(s => s.SizeNumber)).ToPagedList(pageNum, pageSize);
            ViewBag.CurrentPage = pageNum;
            return View(sizes);
        }

        public IActionResult Details(int id, int? page)
        {
            var size = _services?.Get(filter: s => s.SizeId == id);
            var shoes = _services?.GetShoesForSize(id);
            var shoesSizes = new List<ShoeStockViewModel>();
            foreach (var shoe in shoes!)
            {
                var shoeSize = new ShoeStockViewModel()
                {
                    SizeId = size.SizeId,
                    BrandName = shoe.Brand.BrandName,
                    ColourName = shoe.Colour.ColourName,
                    GenreName = shoe.Genre.GenreName,
                    SportName = shoe.Sport.SportName,
                    Model = shoe.Model,
                    Description = shoe.Description,
                    Price = shoe.Price.ToString(),
                    ShoeId = shoe.ShoeId,
                    SizeNumber = size.SizeNumber,
                    QuantityInStock = _shoesServices.GetShoeSizeBySizeNumber(size.SizeNumber, shoe.ShoeId).QuantityInStock
                };
                if (shoeSize.QuantityInStock > 0)
                {
                    shoesSizes.Add(shoeSize);
                }
            }
            ViewBag.CurrentPage = page;
            return View(shoesSizes);
        }
        public IActionResult MoreDetails(int shoeId, int sizeId, int stock)
        {
            Shoe shoe = _shoesServices.Get(filter: s => s.ShoeId == shoeId, propertiesNames: "Brand,Sport,Genre,Colour");
            Size size = _services.Get(filter: s => s.SizeId == sizeId);

            var shoeSize = new ShoeStockViewModel()
            {
                SizeId = size.SizeId,
                ShoeId = shoe.ShoeId,
                BrandName = shoe.Brand.BrandName,
                ColourName = shoe.Colour.ColourName,
                GenreName = shoe.Colour.ColourName,
                SportName = shoe.Sport.SportName,
                Model = shoe.Model,
                Description = shoe.Description,
                Price = shoe.Price.ToString(),
                SizeNumber = size.SizeNumber,
                QuantityInStock = stock
            };
            return View(shoeSize);
        }

    }
}
