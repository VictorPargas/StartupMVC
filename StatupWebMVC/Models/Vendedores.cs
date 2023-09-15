using System;
using System.Collections.Generic;
using System.Linq;

namespace StatupWebMVC.Models

{
    public class Vendedores
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public double SalarioBase { get; set; }
        public DateTime DataAniver { get; set; }
        public Departamento Departamento { get; set; }
        public ICollection<RecordVenda> Record { get; set; } = new List<RecordVenda>();

        public Vendedores()
        {
        }

        public Vendedores(int id, string nome, string email, double salarioBase, DateTime dataAniver, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            SalarioBase = salarioBase;
            DataAniver = dataAniver;
            Departamento = departamento;
        }

        public void AddVenda(RecordVenda sr)
        {
            Record.Add(sr);
        }

        public void RemoveVenda(RecordVenda sr)
        {
            Record.Remove(sr);
        }

       public double TotalVenda(DateTime initial, DateTime final)
        {
            return Record.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Quantia);
        }
    }
}
