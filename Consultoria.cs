using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AindaMaisExercicios
{
    public class Consultoria : Servico, IContratavel
    {
    public Consultoria(string nome) : base(nome)
    {

    }

    public void Contratar()
    {
        Console.WriteLine($"Consultoria {Nome} contratada com sucesso.");
    }
    }
}