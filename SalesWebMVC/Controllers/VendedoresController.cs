﻿using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;
using SalesWebMVC.Services;
using SalesWebMVC.Models.ViewModels;

namespace SalesWebMVC.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly VendedorService vendedorService;
        private readonly DepartamentoService departamentoService;

        public VendedoresController(VendedorService vendedor, DepartamentoService departamento)
        {
            vendedorService = vendedor;
            departamentoService = departamento;

        }

        public IActionResult Index()
        {
            var list = vendedorService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            var departamentos = departamentoService.FindAll();
            var viewModel = new VendedorFormViewModel() { Departamentos = departamentos };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Vendedor vendedor)
        {
            vendedorService.AdicionarVendedor(vendedor);
            return RedirectToAction(nameof(Index));
        }
    }
}