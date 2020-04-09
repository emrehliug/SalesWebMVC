using SalesWebMVC.Data;
using SalesWebMVC.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Services.Exceptions;

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
            _context.Add(vendedor);
            _context.SaveChanges();
        }

        public Vendedor FindId(int id)
        {
            return _context.Vendedor.Include(obj => obj.Departamento).FirstOrDefault(x => x.Id == id);
        }

        public void RemoverVendedor(int id)
        {
            var vendedor = _context.Vendedor.Find(id);
            _context.Vendedor.Remove(vendedor);
            _context.SaveChanges();
        }

        public void Atualizar(Vendedor vendedor)
        {
            if (!_context.Vendedor.Any(x => x.Id == vendedor.Id))
            {
                throw new NotFoundException("Id not Found");
            }
            try
            {
                _context.Update(vendedor);
                _context.SaveChanges();
            }
            catch(DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
