using StatupWebMVC.Models.Enums;

namespace StatupWebMVC.Models
{
    public class RecordVenda
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Quantia { get; set; }
        public StatusVenda Status  { get; set; }
        public Vendedores Vendedores { get; set; }


        public RecordVenda()
        {

        }

        public RecordVenda(int id, DateTime date, double quantia, StatusVenda status, Vendedores vendedores)
        {
            Id = id;
            Date = date;
            Quantia = quantia;
            Status = status;
            Vendedores = vendedores;
        }
    }
}
