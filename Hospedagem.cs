using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AindaMaisExercicios
{
    public class Hospedagem : Servico, IContratavel, ICancelavel
    {
    public Hospedagem(string nome) : base(nome)
    {

    }

    public void Contratar()
    {
        Console.WriteLine($"Hospedagem {Nome} contratada com sucesso.");
    }

    public void Cancelar()
    {
        Console.WriteLine($"Hospedagem {Nome} cancelada.");
    }
    }
}