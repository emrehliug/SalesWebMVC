using SalesWebMVC.Models;
using SalesWebMVC.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Data
{
    public class SeedingService
    {
        private SalesWebMVCContext _context;

        public SeedingService(SalesWebMVCContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            if (_context.Departamento.Any() || _context.RegistroVendas.Any() || _context.Vendedor.Any())
            {
                return;
            }

            Departamento d1 = new Departamento("Informatica/Computadores");
            Departamento d2 = new Departamento("Livros");
            Departamento d3 = new Departamento("Modas");
            Departamento d4 = new Departamento("Eletronicos");

            Vendedor v1 = new Vendedor("Bob Brown", "bob@gmail.com", new DateTime(1997, 4, 21), 1000.0, d1);
            Vendedor v2 = new Vendedor("Charlote", "chacha@gmail.com", new DateTime(1997, 3, 24), 1200.0, d2);
            Vendedor v3 = new Vendedor("Carlos Alberto", "bebeto@gmail.com", new DateTime(1976, 2, 12), 1350.0, d1);
            Vendedor v4 = new Vendedor("Daniel Lopes", "danielel@gmail.com", new DateTime(1989, 7, 13), 2199.0, d4);
            Vendedor v5 = new Vendedor("Barbara Ohana", "baah@gmail.com", new DateTime(1977, 3, 19), 4500.0, d3);
            Vendedor v6 = new Vendedor("Matheus Vazamim", "mathmath@gmail.com", new DateTime(1998, 10, 22), 1900.0, d2);

            RegistroVendas r1 = new RegistroVendas(new DateTime(2018, 09, 25), 11000.0, VendaStatus.Faturado, v1);
            RegistroVendas r2 = new RegistroVendas(new DateTime(2018, 09, 4), 7000.0, VendaStatus.Faturado, v5);
            RegistroVendas r3 = new RegistroVendas(new DateTime(2018, 09, 13), 4000.0, VendaStatus.Cancelado, v4);
            RegistroVendas r4 = new RegistroVendas(new DateTime(2018, 09, 1), 8000.0, VendaStatus.Faturado, v1);
            RegistroVendas r5 = new RegistroVendas(new DateTime(2018, 09, 21), 3000.0, VendaStatus.Faturado, v3);
            RegistroVendas r6 = new RegistroVendas(new DateTime(2018, 09, 15), 2000.0, VendaStatus.Faturado, v1);
            RegistroVendas r7 = new RegistroVendas(new DateTime(2018, 09, 28), 13000.0, VendaStatus.Faturado, v2);
            RegistroVendas r8 = new RegistroVendas(new DateTime(2018, 09, 11), 4000.0, VendaStatus.Faturado, v4);
            RegistroVendas r9 = new RegistroVendas(new DateTime(2018, 09, 14), 11000.0, VendaStatus.Pendente, v6);
            RegistroVendas r10 = new RegistroVendas(new DateTime(2018, 09, 7), 9000.0, VendaStatus.Faturado, v6);
            RegistroVendas r11 = new RegistroVendas(new DateTime(2018, 09, 13), 6000.0, VendaStatus.Faturado, v2);
            RegistroVendas r12 = new RegistroVendas(new DateTime(2018, 09, 25), 7000.0, VendaStatus.Pendente, v3);
            RegistroVendas r13 = new RegistroVendas(new DateTime(2018, 09, 29), 10000.0, VendaStatus.Faturado, v4);
            RegistroVendas r14 = new RegistroVendas(new DateTime(2018, 09, 4), 3000.0, VendaStatus.Faturado, v5);
            RegistroVendas r15 = new RegistroVendas(new DateTime(2018, 09, 12), 4000.0, VendaStatus.Faturado, v1);
            RegistroVendas r16 = new RegistroVendas(new DateTime(2018, 10, 5), 2000.0, VendaStatus.Faturado, v4);
            RegistroVendas r17 = new RegistroVendas(new DateTime(2018, 10, 1), 12000.0, VendaStatus.Faturado, v1);
            RegistroVendas r18 = new RegistroVendas(new DateTime(2018, 10, 24), 6000.0, VendaStatus.Faturado, v3);
            RegistroVendas r19 = new RegistroVendas(new DateTime(2018, 10, 22), 8000.0, VendaStatus.Faturado, v5);
            RegistroVendas r20 = new RegistroVendas(new DateTime(2018, 10, 15), 8000.0, VendaStatus.Faturado, v6);
            RegistroVendas r21 = new RegistroVendas(new DateTime(2018, 10, 17), 9000.0, VendaStatus.Faturado, v2);
            RegistroVendas r22 = new RegistroVendas(new DateTime(2018, 10, 24), 4000.0, VendaStatus.Faturado, v4);
            RegistroVendas r23 = new RegistroVendas(new DateTime(2018, 10, 19), 11000.0, VendaStatus.Cancelado, v2);
            RegistroVendas r24 = new RegistroVendas(new DateTime(2018, 10, 12), 8000.0, VendaStatus.Faturado, v5);
            RegistroVendas r25 = new RegistroVendas(new DateTime(2018, 10, 31), 7000.0, VendaStatus.Faturado, v3);
            RegistroVendas r26 = new RegistroVendas(new DateTime(2018, 10, 6), 5000.0, VendaStatus.Faturado, v4);
            RegistroVendas r27 = new RegistroVendas(new DateTime(2018, 10, 13), 9000.0, VendaStatus.Pendente, v1);
            RegistroVendas r28 = new RegistroVendas(new DateTime(2018, 10, 7), 4000.0, VendaStatus.Faturado, v3);
            RegistroVendas r29 = new RegistroVendas(new DateTime(2018, 10, 23), 12000.0, VendaStatus.Faturado, v5);
            RegistroVendas r30 = new RegistroVendas(new DateTime(2018, 10, 12), 5000.0, VendaStatus.Faturado, v2);

            _context.Departamento.AddRange(d1,d2,d3,d4);

            _context.Vendedor.AddRange(v1, v2, v3, v4, v5, v6);

            _context.RegistroVendas.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18, r19, r20, r21, r22, r23, r24, r25, r26, r27, r28, r29, r30);

            _context.SaveChanges();
        }
    }
}
