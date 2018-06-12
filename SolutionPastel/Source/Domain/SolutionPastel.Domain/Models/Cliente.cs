using SolutionPastelDomain.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionPastel.Domain.Models
{
    public class Cliente : Entity
    {
        public string Nome { get; private set; }
        
        public Cliente(string nome)
        {
            Nome = nome;
        }
        private Cliente() { }
    }
}
