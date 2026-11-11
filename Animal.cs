using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AindaMaisExercicios
{
    public abstract class Animal
    {
        public string? Nome { get; set; }
        
        public Animal(string nome)
        {
            Nome = nome; 
        }
        public void Apresentar()
        {
            Console.WriteLine("Animal: " + Nome);
        }
        public abstract void EmitirSom();
    }
}