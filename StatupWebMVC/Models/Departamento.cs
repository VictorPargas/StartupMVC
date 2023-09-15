namespace StatupWebMVC.Models
{
    public class Departamento
    {

        public int Id{ get; set; }
        public string Name { get; set; }
        public ICollection<Vendedores> Vendedores { get; set; } = new List<Vendedores>();

        public Departamento()
        {
        }

        public Departamento(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddVendedor(Vendedores vendedores)
        {
            Vendedores.Add(vendedores);
        }

        public double TotalVenda(DateTime initial, DateTime final)
        {
            return Vendedores.Sum(Vendedores => Vendedores.TotalVenda(initial, final));
        }
    }
}
