using SalesWebMVC.Models.Enums;
using System;


namespace SalesWebMVC.Models
{
    public class RegistroVendas
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Amout { get; set; }
        public VendaStatus Status { get; set; }
        public Vendedor Vendedor { get; set; }

        public RegistroVendas()
        {

        }

        public RegistroVendas(int id, DateTime data, double amout, VendaStatus status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Amout = amout;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
