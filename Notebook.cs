using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AindaMaisExercicios
{
    public class Notebook : Equipamento
    {
        public int MemoriaRAM { get; set; }
        public Notebook(string modelo, int numeroSerie, int memoriaRAM) : base(modelo, numeroSerie)
    {
        MemoriaRAM = memoriaRAM;
    }
        override public void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Memória RAM: {MemoriaRAM} GB");
        }
    }
}