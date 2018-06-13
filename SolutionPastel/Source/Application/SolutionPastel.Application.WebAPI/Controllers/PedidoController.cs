using SolutionPastel.Application.Service.Interface.AppService;
using SolutionPastel.Application.Service.ViewModel;
using System.Threading.Tasks;
using System.Web.Http;

namespace SolutionPastel.Application.WebAPI.Controllers
{
    [RoutePrefix("api/Pedido")]
    public class PedidoController : ApiController
    {

        private IPedidoAppService _IPedidoAppService;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="IPedidoAppService"></param>
        public PedidoController(IPedidoAppService IPedidoAppService)
        {
            _IPedidoAppService = IPedidoAppService;
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
            var retPok = await _IPedidoAppService.GetByIdAsync(id);
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

        public async Task<IHttpActionResult> AddAsync([FromBody]PedidoViewModel entity)
        {
            await _IPedidoAppService.AddAsync(entity);
            return Created(Request.RequestUri, entity);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="id">todo: describe id parameter on UpdateAsync</param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IHttpActionResult> UpdateAsync([FromBody]PedidoViewModel entity, [FromUri]int id)
        {
            var retClient = await _IPedidoAppService.GetByIdAsync(id);
            if (retClient == null)
            {
                return NotFound();
            }
            else
            {
                await _IPedidoAppService.UpdateAsync(entity, id);
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

            var retPok = await _IPedidoAppService.GetByIdAsync(id);
            if (retPok == null)
            {
                return NotFound();
            }
            else
            {
                await _IPedidoAppService.DeleteAsync(retPok);
                return Ok();
            }
        }
    }

}
