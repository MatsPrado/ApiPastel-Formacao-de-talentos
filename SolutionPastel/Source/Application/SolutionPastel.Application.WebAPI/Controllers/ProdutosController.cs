using SolutionPastel.Application.Service.AppService;
using SolutionPastel.Application.Service.Interface.AppService;
using SolutionPastel.Application.Service.ViewModel;
using System.Threading.Tasks;
using System.Web.Http;

namespace SolutionPastel.Application.WebAPI.Controllers
{
    [RoutePrefix("api/Produtos")]
    public class ProdutosController : ApiController
    {

        private IProdutosAppService _IProdutosAppService;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="produtoAppService"></param>
        public ProdutosController(IProdutosAppService produtoAppService)
        {
            _IProdutosAppService = produtoAppService;
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
            var retProdut = await _IProdutosAppService.GetByIdAsync(id);
            if (retProdut == null)
            {
                return NotFound();
            }

            return Ok(retProdut);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        [HttpPost]

        public async Task<IHttpActionResult> AddAsync([FromBody]ProdutosViewModel entity)
        {
            await _IProdutosAppService.AddAsync(entity);
            return Created(Request.RequestUri, entity);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="id">todo: describe id parameter on UpdateAsync</param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IHttpActionResult> UpdateAsync([FromBody]ProdutosViewModel entity, [FromUri]int id)
        {
            var retClient = await _IProdutosAppService.GetByIdAsync(id);
            if (retClient == null)
            {
                return NotFound();
            }
            else
            {
                await _IProdutosAppService.UpdateAsync(entity, id);
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

            var retProdut = await _IProdutosAppService.GetByIdAsync(id);
            if (retProdut == null)
            {
                return NotFound();
            }
            else
            {
                await _IProdutosAppService.DeleteAsync(retProdut,id);
                return Ok();
            }
        }
    }
}
