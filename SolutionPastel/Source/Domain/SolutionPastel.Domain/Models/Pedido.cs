using SolutionPastelDomain.core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionPastel.Domain.Models
{
    public class Pedido : Entity
    {
        public int Id_CLiente { get; set; }
        public int Quantidade { get; private set; }
        public DateTime Date { get; private set; }

        public Pedido(int id_cliente, int quantidade, DateTime date)
        {
            Quantidade = quantidade;
            Id_CLiente = id_cliente;
            Date = date;
        }
        private Pedido()
        {

        }


    }
}
