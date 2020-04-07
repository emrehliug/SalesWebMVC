using SalesWebMVC.Data;
using SalesWebMVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMVC.Services
{
    public class VendedorService
    {
        private readonly SalesWebMVCContext _context;

        public VendedorService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public List<Vendedor> FindAll()
        {
            return _context.Vendedor.ToList();
        }

        public void AdicionarVendedor(Vendedor vendedor)
        {
             vendedor.Departamento = _context.Departamento.First();
            _context.Add(vendedor);
            _context.SaveChanges();
        }
    }
}
