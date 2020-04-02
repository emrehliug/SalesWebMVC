using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMVC.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Vendedor> Vendedores { get; set; } = new List<Vendedor>();

        public Departamento()
        {

        }
        
        public Departamento(string nome)
        {
            Nome = nome;
        }

        public void AddVendedor(Vendedor vendedor)
        {
            Vendedores.Add(vendedor);
        }

        public double TotalVendasDepartamento(DateTime initial, DateTime Fim)
        {
            return Vendedores.Sum(x => x.TotalVendas(initial,Fim));
        }
    }
}
