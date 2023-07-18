using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;


public class ConsultorioController : BaseApiController
{
    private readonly IUnitOfWork unitofwork;
    private readonly IMapper mapper;

    public ConsultorioController(IUnitOfWork unitofwork, IMapper mapper)
    {
        this.unitofwork = unitofwork;
        this.mapper = mapper;
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
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Consultorio>> Put(string id, [FromBody]Consultorio consultorio){
        if(consultorio == null)
            return NotFound();
        unitofwork.Consultorios.Update(consultorio);
        await unitofwork.SaveAsync();
        return consultorio;
    }
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(string id){
        var consultorio = await unitofwork.Consultorios.GetByIdAsync(id);
        if(consultorio == null){
            return NotFound();
        }
        unitofwork.Consultorios.Remove(consultorio);
        await unitofwork.SaveAsync();
        return NoContent();
    }
}