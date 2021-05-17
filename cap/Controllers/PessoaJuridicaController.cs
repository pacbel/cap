using cap.Business.Entities;
using cap.Business.Repositories;

using cap.Repositories;
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
    public class PessoaJuridicaController : ControllerBase
    {
        private readonly IPessoaJuridicaRepository _pessoaJuridicaRepository;

        public PessoaJuridicaController(IPessoaJuridicaRepository pessoaRepository)
        {
            _pessoaJuridicaRepository = pessoaRepository;
        }
        /// <summary>
        /// Este serviço permite cadastrar curso para o usuário autenticado.
        /// </summary>
        /// <returns>Retorna status ok, dados do usuário e token em caso de sucesso</returns>
        [SwaggerResponse(statusCode: 201, description: "Sucesso ao cadastrar um curso")]
        [SwaggerResponse(statusCode: 401, description: "Não autorizado")]
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Post(PessoaJuridica pessoa)
        {
            _pessoaJuridicaRepository.Insert(pessoa);
            _pessoaJuridicaRepository.Commit();
            return Created("", pessoa);
        }

        [HttpGet]
        [Route("{codigo}")]
        public async Task<IActionResult> Get(int codigo)
        {
            IList<PessoaJuridica> pessoa = _pessoaJuridicaRepository.Select(codigo);

            return Ok(pessoa);
        }

        [HttpPut]
        [Route("")]
        public async Task<IActionResult> Put(PessoaJuridica pessoa)
        {
            _pessoaJuridicaRepository.Update(pessoa);
            _pessoaJuridicaRepository.Commit();
            return Accepted("", pessoa);
        }

        [HttpDelete]
        [Route("{codigo}")]
        public async Task<IActionResult> Delete(int codigo)
        {
            _pessoaJuridicaRepository.Delete(codigo);
            _pessoaJuridicaRepository.Commit();
            return Ok();
        }

    }
}
