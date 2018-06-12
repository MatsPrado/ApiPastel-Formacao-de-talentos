using SolutionPastel.Domain.Interface.Repositorios;
using SolutionPastel.Domain.Interface.Services;
using SolutionPastel.Domain.Models;
using SolutionPastel.Domain.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionPastel.Domain.Service
{
    public class PedidoItemDomainService : DomainServiceBase<PedidoItem>, IPedidoItemDomainService
    {
        public PedidoItemDomainService(IPedidoItemRepositorio repositoryBase) : base(repositoryBase) { }
    }
}
