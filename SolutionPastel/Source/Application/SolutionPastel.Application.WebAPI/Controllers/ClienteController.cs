﻿using SolutionPastel.Application.Service.Interface.AppService;
using SolutionPastel.Application.Service.ViewModel;
using System.Threading.Tasks;
using System.Web.Http;

namespace SolutionPastel.Application.WebAPI.Controllers
{
    [RoutePrefix("api/Cliente")]
    public class ClienteController : ApiController
    {

        private IClienteAppService _IClienteAppService;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="IClienteAppService"></param>
        /// 
        public ClienteController(IClienteAppService IClienteAppService)
        {
            _IClienteAppService = IClienteAppService;
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
            var retClient = await _IClienteAppService.GetByIdAsync(id);
            if (retClient == null)
            {
                return NotFound();
            }

            return Ok(retClient);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        [HttpPost]

        public async Task<IHttpActionResult> AddAsync([FromBody]ClienteViewModel entity)
        {
            await _IClienteAppService.AddAsync(entity);
            return Created(Request.RequestUri, entity);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="entity">todo: describe entity parameter on UpdateAsync</param>
        /// <returns></returns>
        [HttpPut]        
        public async Task<IHttpActionResult> UpdateAsync([FromBody]ClienteViewModel entity, [FromUri]int id)
        {
            var retClient = await _IClienteAppService.GetByIdAsync(id);
            if (retClient == null)
            {
                return NotFound();
            }
            else
            {
                await _IClienteAppService.UpdateAsync(entity,id);
                return Ok(entity);
            }
           
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

            var retClient = await _IClienteAppService.GetByIdAsync(id);
            if (retClient == null)
            {
                return NotFound();
            }
            else
            {
                await _IClienteAppService.DeleteAsync(retClient);
                return Ok();
            }
        }
    }
}
