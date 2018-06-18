using SolutionPastel.Application.Service.AppService;
using SolutionPastel.Application.Service.ViewModel;
using SolutionPastel.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionPastel.Application.Service.Interface.AppService
{
    public interface IClienteAppService : AplicationServiceBase< Cliente,ClienteViewModel>
    {
    }
}
