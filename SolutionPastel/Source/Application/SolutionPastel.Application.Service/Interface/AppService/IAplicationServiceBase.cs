using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionPastel.Application.Service.Interface.AppService
{
    public interface IAplicationServiceBase<TViewModel>
           where TViewModel : class
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TViewModel> GetByIdAsync(int id);
        Task<TViewModel> AddAsync(TViewModel entity);
        Task UpdateAsync(TViewModel entity,int id);
        Task DeleteAsync(/*int id,*/ TViewModel entity);
     }
}
