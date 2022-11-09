namespace Alura.TestDrive.Models
{
    public class VeiculoModel
    {
        public VeiculoModel(int id, string nome, decimal valor)
        {
            Id = id;
            Nome = nome;
            Valor = valor;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
    }
}
