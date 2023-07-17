using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

public class AcudienteController : BaseApiController
{
    public readonly IUnitOfWork unitofwork;
    
    public AcudienteController(IUnitOfWork _unitofwork)
    {
      unitofwork = _unitofwork;
    }


    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<Acudiente>>> Get()
    {
        var acudiente = await unitofwork.Acudientes.GetAllAsync();
        return Ok(acudiente);
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
}
