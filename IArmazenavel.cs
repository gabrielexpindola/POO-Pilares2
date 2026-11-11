using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AindaMaisExercicios
{
    public interface IArmazenavel
    {
        public void Salvar(string conteudo);
        public void Ler();
    }
}