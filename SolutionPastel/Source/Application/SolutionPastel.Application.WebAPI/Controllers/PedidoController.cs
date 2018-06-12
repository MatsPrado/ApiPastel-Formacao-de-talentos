using SolutionPastel.Application.Service.Interface.AppService;
using SolutionPastel.Application.Service.ViewModel;
using System.Threading.Tasks;
using System.Web.Http;

namespace SolutionPastel.Application.WebAPI.Controllers
{
    public class PedidoController : ApiController
    {

        private IPedidoAppService _IPedidoAppService;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="IPokemonAppService"></param>
        public PedidoController(IPedidoAppService IPokemonAppService)
        {
            _IPedidoAppService = IPokemonAppService;
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
        /// <returns></returns>
        [HttpPut]
        public async Task<IHttpActionResult> UpdateAsync([FromBody]PedidoViewModel entity)
        {
            await _IPedidoAppService.UpdateAsync(entity);
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
