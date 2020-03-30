using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMVC.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public double BaseSalario { get; set; }
        public Departamento Departamento { get; set; }
        public ICollection<RegistroVendas> Vendas { get; set; } = new List<RegistroVendas>();

        public Vendedor()
        {

        }

        public Vendedor(int id, string nome, string email, DateTime dataNascimento, double baseSalario, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            BaseSalario = baseSalario;
            Departamento = departamento;
        }

        public void AddVenda(RegistroVendas venda)
        {
            Vendas.Add(venda);
        }

        public void RemoveVenda(RegistroVendas venda)
        {
            Vendas.Remove(venda);
        }

        public double TotalVendas(DateTime initial, DateTime Fim)
        {
            return Vendas.Where(x => x.Data >= initial && x.Data <= Fim).Sum(x => x.Amout);
        }
    }
}
