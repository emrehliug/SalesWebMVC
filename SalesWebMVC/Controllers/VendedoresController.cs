using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;
using SalesWebMVC.Services;
using SalesWebMVC.Models.ViewModels;
using System.Collections.Generic;
using SalesWebMVC.Services.Exceptions;

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

        public IActionResult Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            
            var obj = vendedorService.FindId(id.Value);
            
            if(obj == null)
            {
                return NotFound();
            }

            return View(obj);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            vendedorService.RemoverVendedor(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = vendedorService.FindId(id.Value);

            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        public IActionResult Edit(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var obj = vendedorService.FindId(id.Value);
            if(obj == null)
            {
                return NotFound();
            }

            List<Departamento> departamentos = departamentoService.FindAll();
            VendedorFormViewModel vendedor = new VendedorFormViewModel() { Vendedor = obj, Departamentos = departamentos };
            
            return View(vendedor);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, VendedorFormViewModel obj)
        {
            if(id != obj.Vendedor.Id)
            {
                return BadRequest();
            }

            try
            {
                vendedorService.Atualizar(obj.Vendedor);
                return RedirectToAction(nameof(Index));
            }
            catch(NotFoundException)
            {
                return NotFound();
            }
            catch(DbConcurrencyException)
            {
                return BadRequest();
            }
            
        }
    }
}