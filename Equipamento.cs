
namespace AindaMaisExercicios
{
    public abstract class Equipamento
    {
        public string Modelo { get; set; }
        protected int NumeroSerie { get; set; }

        public Equipamento(string modelo, int numeroSerie)
        {
            Modelo = modelo;
            NumeroSerie = numeroSerie;
        }
        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Número de Série: {NumeroSerie}");
        }
    }
}