using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;


public class ConsultorioController : BaseApiController
{
    private readonly IUnitOfWork unitofwork;

    public ConsultorioController(IUnitOfWork _unitofwork)
    {
        unitofwork = _unitofwork;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<Consultorio>>> Get()
    {
        var consultorio = await unitofwork.Consultorios.GetAllAsync();
        return Ok(consultorio);
    }
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Get(string id)
    {
        var consultorio = await unitofwork.Consultorios.GetByIdAsync(id);
        return Ok(consultorio);
    }
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Consultorio>> Post(Consultorio consultorio){
        this.unitofwork.Consultorios.Add(consultorio);
        await unitofwork.SaveAsync();
        if(consultorio == null)
        {
            return BadRequest();
        }
        return CreatedAtAction(nameof(Post),new {id= consultorio.ConsCodigo}, consultorio);
    }
}