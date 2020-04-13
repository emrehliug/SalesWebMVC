using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SalesWebMVC.Models
{
    public class Vendedor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} é necessario")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} tem que ter no minimo {2} caracteres e maximo de {1}")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "{0} é necessario")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Entre com email valido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} é necessario")]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "{0} é necessario")]
        [Display(Name ="Salario Base")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double BaseSalario { get; set; }

        public Departamento Departamento { get; set; }

        public int DepartamentoId { get; set; }

        public ICollection<RegistroVendas> Vendas { get; set; } = new List<RegistroVendas>();

        public Vendedor()
        {

        }

        public Vendedor(string nome, string email, DateTime dataNascimento, double baseSalario, Departamento departamento)
        {
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
