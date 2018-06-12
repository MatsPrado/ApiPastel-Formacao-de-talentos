using SolutionPastel.Application.Service.Interface.AppService;
using SolutionPastel.Application.Service.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolutionPastel.Domain.Interface.Services;
using SolutionPastel.Domain.Service;
using SolutionPastel.Domain.Models;

namespace SolutionPastel.Application.Service.AppService
{
    public class PedidoItemAppService : AplicationServiceBase<PedidoItem, PedidoItemViewModel>, IPedidoItemAppService
    {
        public PedidoItemAppService(IPedidoItemDomainService domainServiceBase) : base(domainServiceBase)
        {
        }
    }
}
