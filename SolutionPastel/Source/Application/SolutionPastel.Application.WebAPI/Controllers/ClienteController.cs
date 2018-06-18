using SolutionPastel.Application.Service.Interface.AppService;
using SolutionPastel.Application.Service.ViewModel;
using SolutionPastel.Domain.Models;
using SolutionPastelDomain.core.Models;
using System.Net;
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
        /// Método para buscar todos os clientes
        /// </summary>
        /// <returns></returns>
        /// <remarks>Obtém todos os clientes</remarks>
        /// <Response code="200">Ok</Response>
        /// <Response code="400">BadRequest</Response>
        /// <Response code="500">InternalServerError</Response>
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.BadRequest, "BadRequest")]
        [SwaggerResponse(HttpStatusCode.InternalServerError, "InternalServerError")]
        [ResponseType(typeof(Cliente))]
        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            return Ok(await _IClienteAppService.GetListAsync());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="entity">todo: describe entity parameter on DeleteAsync</param>
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
                await _IClienteAppService.DeleteAsync(retClient, id);
                return Ok();
            }
        }

        //[HttpGet]
        //public async Task<IHttpActionResult> GetAll()
        //{
        //    var listaCliente = await _serviceBase.GetListAsync();
        //    return Ok(listaCliente);
        //}

    }
}
