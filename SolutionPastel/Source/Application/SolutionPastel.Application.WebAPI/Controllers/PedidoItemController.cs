using SolutionPastel.Application.Service.Interface.AppService;
using SolutionPastel.Application.Service.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace SolutionPastel.Application.WebAPI.Controllers
{
    public class PedidoItemController : ApiController
    {

        private IPedidoItemAppService _IPedidoItemAppService;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="IPedidoItemAppService"></param>
        public PedidoItemController(IPedidoItemAppService IPedidoItemAppService)
        {
            _IPedidoItemAppService = IPedidoItemAppService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("id")]
        public async Task<IHttpActionResult> GetAsync(int id)
        {
            var retPok = await _IPedidoItemAppService.GetByIdAsync(id);
            if (retPok == null)
            {
                return NotFound();
            }

            return Ok(retPok);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        [HttpPost]

        public async Task<IHttpActionResult> AddAsync([FromBody]PedidoItemViewModel entity)
        {
            await _IPedidoItemAppService.AddAsync(entity);
            return Created(Request.RequestUri, entity);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IHttpActionResult> UpdateAsync([FromBody]PedidoItemViewModel entity)
        {
            await _IPedidoItemAppService.UpdateAsync(entity);
            return Ok(entity);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("id")]
        public async Task<IHttpActionResult> DeleteAsync(int id)
        {

            var retPok = await _IPedidoItemAppService.GetByIdAsync(id);
            if (retPok == null)
            {
                return NotFound();
            }
            else
            {
                await _IPedidoItemAppService.DeleteAsync(retPok);
                return Ok();
            }
        }
    }

}
