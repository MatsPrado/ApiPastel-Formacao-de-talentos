using SolutionPastel.Application.Service.Interface.AppService;
using SolutionPastel.Application.Service.ViewModel;
using SolutionPastel.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolutionPastel.Domain.Interface.Services;

namespace SolutionPastel.Application.Service.AppService
{
    public sealed class ProdutosAppService : AplicationServiceBase<Produtos, ProdutosViewModel>, IProdutosAppService
    {
        public ProdutosAppService(IProdutosDomainService domainServiceBase) : base(domainServiceBase)
        {
        }
    }
}
