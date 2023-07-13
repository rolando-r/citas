using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

public class AcudienteController : BaseApiController
{
    private readonly CitasContext _context;
    
    public AcudienteController(CitasContext context)
    {
      _context = context;
    }
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<Acudiente>>> Get()
    {
        var nameVar = await _context.Acudientes.ToListAsync();
        return Ok(nameVar);
    }
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Get(int id)
    {
        var acudiente = await _context.Acudientes.FindAsync(id);
        return Ok(acudiente);
    }
}
