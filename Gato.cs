using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AindaMaisExercicios
{
    public class Gato : Animal
    {
        public Gato(string nome) : base(nome)
        {
        }
        public override void EmitirSom()
        {
            Console.WriteLine("Miau"); 
        }
    }
}