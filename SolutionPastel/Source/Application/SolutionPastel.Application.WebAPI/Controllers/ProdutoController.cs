using SolutionPastel.Application.Service.AppService;
using SolutionPastel.Application.Service.Interface.AppService;
using SolutionPastel.Application.Service.ViewModel;
using System.Threading.Tasks;
using System.Web.Http;

namespace SolutionPastel.Application.WebAPI.Controllers
{
    public class ProdutoController : ApiController
    {

        private IProdutoAppService _IProdutoAppService;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="produtoAppService"></param>
        public ProdutoController(IProdutoAppService produtoAppService)
        {
            _IProdutoAppService = produtoAppService;
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
            var retProdut = await _IProdutoAppService.GetByIdAsync(id);
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

        public async Task<IHttpActionResult> AddAsync([FromBody]ProdutoViewModel entity)
        {
            await _IProdutoAppService.AddAsync(entity);
            return Created(Request.RequestUri, entity);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IHttpActionResult> UpdateAsync([FromBody]ProdutoViewModel entity)
        {
            await _IProdutoAppService.UpdateAsync(entity);
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

            var retProdut = await _IProdutoAppService.GetByIdAsync(id);
            if (retProdut == null)
            {
                return NotFound();
            }
            else
            {
                await _IProdutoAppService.DeleteAsync(retProdut);
                return Ok();
            }
        }
    }
}
