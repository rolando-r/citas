using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;


public class ConsultorioController : BaseApiController
{
    public readonly IConsultorio _consultorioRepository;

    public ConsultorioController(IConsultorio _consultorio)
    {
        _consultorioRepository = _consultorio;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<Consultorio>>> Get()
    {
        var consultorios = await _consultorioRepository.GetAllAsync();
        return Ok(consultorios);
    }
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Get(string id)
    {
        var consultorio = await _consultorioRepository.GetByIdAsync(id);
        return Ok(consultorio);
    }
}