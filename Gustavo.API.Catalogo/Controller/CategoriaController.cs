using Gustavo.Dominio.DTOs.Categoria;
using Gustavo.Dominio.Entidades;
using Gustavo.Dominio.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gustavo.API.Catalogo.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaController(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        //[HttpGet]
        //public async Task<IActionResult> ObterTodos()
        //{
        //    var categorias = await _categoriaRepository.ObterTodos();
        //    return Ok(categorias);
        //}

        [HttpGet("{id}")]
        public async Task<IActionResult> ObterPorID(Guid id)
        {
            var categoria = await _categoriaRepository.ObterPorID(id);
            return Ok(categoria);
        }

        [HttpPost]
        public async Task<IActionResult> Inserir(Categoria categoria)
        {
            categoria.ID = Guid.Empty == categoria.ID ? Guid.NewGuid() : categoria.ID;

            categoria = new Categoria
            {
                Nome = categoria.Nome,
                ImagemUrl = categoria.ImagemUrl,
            };

            await _categoriaRepository.Inserir(categoria);
            return Ok(categoria);
        }

        [HttpPut("id")]
        public async Task<IActionResult> Atualizar(Guid id, AlterarCategoriaDTO alterarCategoriaDto)
        {
            var categoriaDB = await _categoriaRepository.ObterPorID(id);
            if (categoriaDB == null)
            {
                return NotFound();
            }

            categoriaDB.Nome = alterarCategoriaDto.Nome;
            categoriaDB.ImagemUrl = alterarCategoriaDto.ImagemUrl;
            categoriaDB.DataAlteracao = DateTime.Now;

            await _categoriaRepository.Atualizar(categoriaDB);
            return Ok(alterarCategoriaDto);
        }

        [HttpDelete]
        public async Task<IActionResult> Excluir(Guid id)
        {
            var categoria = await _categoriaRepository.ObterPorID(id);
            if (categoria == null)
            {
                return NotFound();
            }
            await _categoriaRepository.Excluir(categoria);
            return Ok();
        }
    }
}
