using SolutionPastelDomain.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionPastel.Domain.Models
{
   public class PedidoItem : Entity
    {
        public int Id_Pedido { get; private set; }
        public int Id_Produtos { get; private set; }

        public PedidoItem(int id_Pedido,int id_Produtos)
        {
            Id_Pedido = id_Pedido;
            Id_Produtos = id_Produtos;
        }
        private PedidoItem() { }
    }
}
