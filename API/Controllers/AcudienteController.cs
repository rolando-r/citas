using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;


public class AcudienteController : BaseApiController
{
    private readonly IUnitOfWork unitofwork;
    private readonly IMapper mapper;

    public AcudienteController(IUnitOfWork unitofwork, IMapper mapper)
    {
        this.unitofwork = unitofwork;
        this.mapper = mapper;
    }
    /* [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<Acudiente>>> Get()
    {
        var acudiente = await unitofwork.Acudientes.GetAllAsync();
        return Ok(acudiente);
    } */
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<List<AcudienteDto>> Get()
    {
        var acudiente = await unitofwork.Acudientes.GetAllAsync();
        return this.mapper.Map<List<AcudienteDto>>(acudiente);
    }
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Get(string id)
    {
        var acudiente = await unitofwork.Acudientes.GetByIdAsync(id);
        return Ok(acudiente);
    }
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Acudiente>> Post(Acudiente acudiente){
        this.unitofwork.Acudientes.Add(acudiente);
        await unitofwork.SaveAsync();
        if(acudiente == null)
        {
            return BadRequest();
        }
        return CreatedAtAction(nameof(Post),new {id= acudiente.AcuCodigo}, acudiente);
    }
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Acudiente>> Put(string id, [FromBody]Acudiente acudiente){
        if(acudiente == null)
            return NotFound();
        unitofwork.Acudientes.Update(acudiente);
        await unitofwork.SaveAsync();
        return acudiente;
    }
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(string id){
        var acudiente = await unitofwork.Acudientes.GetByIdAsync(id);
        if(acudiente == null){
            return NotFound();
        }
        unitofwork.Acudientes.Remove(acudiente);
        await unitofwork.SaveAsync();
        return NoContent();
    }
}
