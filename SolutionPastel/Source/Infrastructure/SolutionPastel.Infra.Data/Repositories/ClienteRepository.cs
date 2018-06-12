using SolutionPastel.Domain.Interface.Repositorios;
using SolutionPastel.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionPastel.Infra.Data.Repositories
{
    public sealed class ClienteRepository : RepositoryBase<Cliente>, IClienteRepositorio
    {
    }
}
