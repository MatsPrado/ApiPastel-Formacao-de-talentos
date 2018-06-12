using SolutionPastel.Application.Service.Interface.AppService;
using SolutionPastel.Application.Service.ViewModel;
using SolutionPastel.Domain.Interface.Services;
using SolutionPastel.Domain.Models;

namespace SolutionPastel.Application.Service.AppService
{
    public sealed class ClienteAppService : AplicationServiceBase<Cliente, ClienteViewModel>, IClienteAppService
    {
        public ClienteAppService(IClienteDomainService domainServiceBase) : base(domainServiceBase)
        {
        }
    }
}
