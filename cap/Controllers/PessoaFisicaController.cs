using cap.Business.Entities;
using cap.Business.Repositories;
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
    public class PessoaFisicaController : ControllerBase
    {
        private readonly IPessoaFisicaRepository _pessoaFisicaRepository;

        public PessoaFisicaController(IPessoaFisicaRepository pessoaFisicaRepository)
        {
            _pessoaFisicaRepository = pessoaFisicaRepository;
        }
        /// <summary>
        /// Este serviço permite cadastrar curso para o usuário autenticado.
        /// </summary>
        /// <returns>Retorna status ok, dados do usuário e token em caso de sucesso</returns>
        [SwaggerResponse(statusCode: 201, description: "Sucesso ao cadastrar um curso")]
        [SwaggerResponse(statusCode: 401, description: "Não autorizado")]
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Post(PessoaFisica pessoa)
        {
            _pessoaFisicaRepository.Insert(pessoa);
            _pessoaFisicaRepository.Commit();
            return Created("", pessoa);
        }

        [HttpGet]
        [Route("{codigo}")]
        public async Task<IActionResult> Get(int codigo)
        {
            IList<PessoaFisica> pessoa = _pessoaFisicaRepository.Select(codigo);

            return Ok(pessoa);
        }

        [HttpPut]
        [Route("")]
        public async Task<IActionResult> Put(PessoaFisica pessoa)
        {
            _pessoaFisicaRepository.Update(pessoa);
            _pessoaFisicaRepository.Commit();
            return Accepted("",pessoa);
        }

        [HttpDelete]
        [Route("{codigo}")]
        public async Task<IActionResult> Delete(int codigo)
        {
            _pessoaFisicaRepository.Delete(codigo);
            _pessoaFisicaRepository.Commit();
            return Ok();
        }

    }
}
