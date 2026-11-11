using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AindaMaisExercicios
{
    public class ArquivoTexto : IArmazenavel
    {
        public void Salvar(string conteudo)
        {
            Console.WriteLine($"Salvando no arquivo {conteudo}");
        }
        public void Ler()
        {
            Console.WriteLine("Lendo arquivo");
        }
    }
}