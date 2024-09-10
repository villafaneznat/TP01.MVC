﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TP01.MVC.Web.ViewModels.Brand;
using TP01EF2024.Entidades;
using TP01EF2024.Servicios.Interfaces;
using X.PagedList.Extensions;

namespace TP01.MVC.Web.Controllers
{
    public class BrandsController : Controller
    {
        private readonly IBrandsService? _services;

        private readonly IMapper? _mapper;

        public BrandsController(IBrandsService? services, IMapper mapper)
        {
            _services = services ?? throw new ArgumentNullException(nameof(services));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public IActionResult Index(int? page)
        {
            int pageNum = page ?? 1;
            int pageSize = 8;
            var brands = _services.GetAll().ToPagedList(pageNum, pageSize);
            return View(brands);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(BrandViewModel brandVM)
        {
            if (!ModelState.IsValid)
            {
                return View(brandVM);
            }
            Brand brand = _mapper.Map<Brand>(brandVM);
            if (brand is null)
            {
                ModelState.AddModelError(string.Empty, "Marca es nulo");
                return View(brandVM);
            }
            if (_services.Existe(brand))
            {
                ModelState.AddModelError(string.Empty, "El registro ya existe");
                return View(brandVM);
            }
            _services.Guardar(brand);
            TempData["success"] = "Registro agregado satisfactoriamente";
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if (id is null || id==0)
            {
                return NotFound();
            }
            Brand brand = _services.Get(filter: b => b.BrandId == id);
            if (brand is null)
            {
                return NotFound();
            }
            BrandViewModel brandVM = _mapper.Map<BrandViewModel>(brand);
            return View(brandVM);
        }

        [HttpPost]
        public IActionResult Edit(BrandViewModel brandVM)
        {
            if (!ModelState.IsValid)
            {
                return View(brandVM);
            }
            Brand brand = _mapper.Map<Brand>(brandVM);
            if (brand is null)
            {
                ModelState.AddModelError(string.Empty, "La marca es nula");
                return View(brandVM);
            }
            if (_services.Existe(brand))
            {
                ModelState.AddModelError(string.Empty, "El registro ya existe");
                return View(brandVM);
            }
            _services.Guardar(brand);
            TempData["success"] = "Registro editado satisfactoriamente";
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id is null || id == 0)
            {
                return NotFound();
            }
            Brand brand = _services.Get(filter: b => b.BrandId == id);
            if (brand is null)
            {
                return NotFound();
            }
            return View(brand);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            if (id==0)
            {
                return NotFound();
            }
            Brand brand = _services.Get(filter: b => b.BrandId == id);
            if (brand is null)
            {
                return NotFound();
            }
            if (_services.EstaRelacionado(brand.BrandId))
            {
                ModelState.AddModelError(string.Empty, "El registro no puede borrarse, está relacionado");
                return View(brand);
            }
            _services.Eliminar(brand);
            TempData["success"] = "Registro eliminado correctamente";
            return RedirectToAction("Index");
        }

    }
}
