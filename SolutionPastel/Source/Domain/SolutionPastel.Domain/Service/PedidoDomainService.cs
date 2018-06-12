using SolutionPastel.Domain.Interface.Services;
using SolutionPastel.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolutionPastel.Domain.Interface.Repositorios;

namespace SolutionPastel.Domain.Service
{
    public class PedidoDomainService : DomainServiceBase<Pedido>, IPedidoDomainService
    {
        public PedidoDomainService(IPedidoRepositorio repositoryBase) : base(repositoryBase)
        {
        }
    }
}
