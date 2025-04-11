using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using treinamento.Domain;
using treinamento.Domain.DTOs;
using treinamento.Services;

namespace treinamento.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TesteController : ControllerBase
    {
        private readonly ITesteServices _testeServices;

        public TesteController(ITesteServices testeservices)
        {
            _testeServices = testeservices;
        }
        [HttpGet("{id}")]

        public IActionResult ObterPorID(int id)
        {
            var aluno = _testeServices.ObterPorId(id);
            return Ok(aluno);
        }
        [HttpGet]

        public IActionResult ObterTodos()
        {
            var todos = _testeServices.ObterTodos();
            return Ok(todos);
        }
        [HttpDelete("{id}")]

        public IActionResult Remover(int id)
        {
            _testeServices.Remover(id);
            return Ok();
        }
        [HttpPatch]

        public IActionResult Atualizar([FromBody] TesteDomain Aluno)
        {
            _testeServices.Atualizar(Aluno.Id, Aluno.Nota, Aluno.Nome);
            return Ok();
        }
        [HttpPost("create")]

        public IActionResult Salvar([FromBody] CreateAlunoDTO Aluno)
        {
            _testeServices.Salvar(Aluno.nota, Aluno.nome);
            return Ok();
        }

    }
}
