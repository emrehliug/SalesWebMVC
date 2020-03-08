using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;
using System.Collections.Generic;

namespace SalesWebMVC.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {
            List<Departamento> listaDepartamentos = new List<Departamento>();

            listaDepartamentos.Add(new Departamento { Id = 1, Nome = "Eletronicos" });
            listaDepartamentos.Add(new Departamento { Id = 2, Nome = "Fashion" });

            return View(listaDepartamentos);
        }
    }
}