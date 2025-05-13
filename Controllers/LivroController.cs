using LivrariaApi.Communication.Reponse;
using LivrariaApi.Communication.Requests;
using LivrariaApi.Data;
using LivrariaApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace LivrariaApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LivroController : ControllerBase
{
    [HttpGet("{id}")]
    [ProducesResponseType(typeof(Livro), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult GetById([FromRoute] int id)
    {
        var livro = LivroRepository.GetById(id);

        if (livro == null)
            return NotFound();

        return Ok(livro);
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<Livro>), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        var livros = LivroRepository.Livros;
        return Ok(livros);
    }


    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterLivroJson), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult Create([FromBody] RequestsLivroJson request)
    {
        if (request == null || string.IsNullOrWhiteSpace(request.Titulo))
            return BadRequest("Dados inválidos.");

        var livro = new Livro
        {
            Id = new Random().Next(1, 1000),
            Titulo = request.Titulo,
            Author = request.Author,
            Genero = request.Genero,
            Preco = request.Preco,
            Quantidade = request.Quantidade
        };

        LivroRepository.Add(livro); 
        var response = new ResponseRegisterLivroJson
        {
            Id = livro.Id,
            Titulo = livro.Titulo,
            Author = livro.Author,
            Genero = livro.Genero,
            Preco = livro.Preco,
            Quantidade = livro.Quantidade
        };

        return CreatedAtAction(nameof(GetById), new { id = livro.Id }, response);
    }


    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestsLivroJson request)
    {
        if (request == null || string.IsNullOrWhiteSpace(request.Titulo))
            return BadRequest("Dados inválidos.");

        var livro = new Livro
        {
            Id = id,
            Titulo = request.Titulo,
            Author = request.Author,
            Genero = request.Genero,
            Preco = request.Preco,
            Quantidade = request.Quantidade
        };

        var atualizado = LivroRepository.Update(id, livro);
        if (!atualizado)
            return NotFound();

        return NoContent();
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult Delete([FromRoute] int id)
    {
        var removido = LivroRepository.Delete(id);
        if (!removido)
            return NotFound();

        return NoContent();
    }

}
