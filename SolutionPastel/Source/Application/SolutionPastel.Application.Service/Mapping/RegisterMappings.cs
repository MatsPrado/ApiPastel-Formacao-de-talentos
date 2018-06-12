using AutoMapper;
using SolutionPastel.Application.Service.ViewModel;
using SolutionPastel.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionPastel.Application.Service.Mapping
{
    public class RegisterMappings
    { 
        public static void Now()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Produto, ProdutoViewModel>();
                cfg.CreateMap<ProdutoViewModel, Produto>();

                cfg.CreateMap<Cliente, ClienteViewModel>();
                cfg.CreateMap<ClienteViewModel, Cliente>();

                cfg.CreateMap<Pedido, PedidoViewModel>();
                cfg.CreateMap<PedidoViewModel, Pedido>();

                cfg.CreateMap<PedidoItem, PedidoItemViewModel>();
                cfg.CreateMap<PedidoItemViewModel, PedidoItem>();
            });
        }
    }
}

