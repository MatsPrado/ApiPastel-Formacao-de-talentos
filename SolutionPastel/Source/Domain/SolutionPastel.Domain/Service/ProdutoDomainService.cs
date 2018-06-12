using SolutionPastel.Domain.Interface.Repositorios;
using SolutionPastel.Domain.Interface.Services;
using SolutionPastel.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionPastel.Domain.Service
{
    public class ProdutoDomainService : DomainServiceBase<Produto>, IProdutoDomainService
    {
        public ProdutoDomainService(IProdutoRepositorio repositoryBase) : base(repositoryBase) {

        }
    }
}
