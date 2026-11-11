using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AindaMaisExercicios
{
    public class Smartphone : Equipamento
    {
        public int Armazenamento { get; set; }
        public Smartphone(string modelo, int numeroSerie, int armazenamento)
            : base(modelo, numeroSerie)
        {
            Armazenamento = armazenamento;
        }
        override public void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Armazenamento: {Armazenamento} GB");
        }
    }
}