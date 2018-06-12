using SimpleInjector;
using SimpleInjector.Lifestyles;
using SolutionPastel.Application.Service.AppService;
using SolutionPastel.Application.Service.Interface.AppService;
using SolutionPastel.Domain.Interface.Repositorios;
using SolutionPastel.Domain.Interface.Services;
using SolutionPastel.Domain.Service;
using SolutionPastel.Infra.Data.Repositories;

namespace SolutionPastel.Infra.IoC.BootsTrapper
{
    public static class IoCManager
    {
        public static Container Inject()
        {
            var container = new Container
            {
                Options =
                {
                    DefaultScopedLifestyle = new AsyncScopedLifestyle()
                }
            };
            container.Register<IProdutoRepositorio, ProdutoRepository>();
            container.Register<IProdutoDomainService, ProdutoDomainService>();
            container.Register<IProdutoAppService, ProdutoAppService>();

            container.Register<IClienteRepositorio, ClienteRepository>();
            container.Register<IClienteDomainService, ClienteDomainService>();
            container.Register<IClienteAppService, ClienteAppService>();

            container.Register<IPedidoRepositorio, PedidoRepository>();
            container.Register<IPedidoDomainService, PedidoDomainService>();
            container.Register<IPedidoAppService, PedidoAppService>();

            container.Register<IPedidoItemRepositorio, PedidoItemRepository>();
            container.Register<IPedidoItemDomainService, PedidoItemDomainService>();
            container.Register<IPedidoItemAppService, PedidoItemAppService>();

            return container;
        }
    }
}