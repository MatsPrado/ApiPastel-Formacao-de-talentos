using SolutionPastelDomain.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionPastel.Domain.Models
{
    public class Produtos : Entity
    {
        public string Nome { get; private set; }

        public int Valor { get; private set; }
  

        public Produtos(string nome, int valor)
        {
            Nome = nome;
            Valor = valor;
        }
        private Produtos() { }
    }
}
