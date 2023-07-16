using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

public class AcudienteController : BaseApiController
{
    public readonly IAcudiente _acudienteRepository;
    
    public AcudienteController(IAcudiente acudienteRepository)
    {
      _acudienteRepository = acudienteRepository;
    }


    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<Acudiente>>> Get()
    {
        var acudientes = await _acudienteRepository.GetAllAsync();
        return Ok(acudientes);
    }
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Get(string id)
    {
        var acudiente = await _acudienteRepository.GetByIdAsync(id);
        return Ok(acudiente);
    }
}
