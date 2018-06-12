using SolutionPastel.Application.Service.Interface.AppService;
using SolutionPastel.Application.Service.ViewModel;
using SolutionPastel.Domain.Interface.Services;
using SolutionPastel.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionPastel.Application.Service.AppService
{
    public sealed class PedidoAppService : AplicationServiceBase<Pedido, PedidoViewModel>, IPedidoAppService
    {
        public PedidoAppService(IPedidoDomainService domainServiceBase) : base(domainServiceBase) { }
    }
}