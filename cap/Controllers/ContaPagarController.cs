using cap.Data.Repositories;
using cap.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace cap.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    [Authorize]
    public class ContaPagarController : ControllerBase
    {
        private readonly ContaPagarRepository _contaPagarRepository;

        public ContaPagarController(ContaPagarRepository contaPagarRepository)
        {
            _contaPagarRepository = contaPagarRepository;
        }
        /// <summary>
        /// Este serviço permite cadastrar curso para o usuário autenticado.
        /// </summary>
        /// <returns>Retorna status ok, dados do usuário e token em caso de sucesso</returns>
        [SwaggerResponse(statusCode: 201, description: "Sucesso ao cadastrar um curso")]
        [SwaggerResponse(statusCode: 401, description: "Não autorizado")]
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Post(ContaPagar contaPagar)
        {
            _contaPagarRepository.Insert(contaPagar);
            _contaPagarRepository.Commit();
            return Created("", contaPagar);
        }

        [HttpGet]
        [Route("{codigo}")]
        public async Task<IActionResult> Get(int codigo)
        {
            IList<ContaPagar> conta = _contaPagarRepository.Select(codigo);

            return Ok(conta);
        }

        [HttpPut]
        [Route("")]
        public async Task<IActionResult> Put(ContaPagar contaPagar)
        {
            _contaPagarRepository.Update(contaPagar);
            _contaPagarRepository.Commit();
            return Accepted("", contaPagar);
        }

        [HttpDelete]
        [Route("{codigo}")]
        public async Task<IActionResult> Delete()
        {
            return Ok();
        }

    }
}
