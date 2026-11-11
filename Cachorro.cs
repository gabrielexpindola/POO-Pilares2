using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AindaMaisExercicios
{
    public class Cachorro : Animal
    {
        public Cachorro(string nome) : base(nome)
        {
        }
        public override void EmitirSom()
        {
            Console.WriteLine("Au Au"); 
        }
    }
}