using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;


public class ConsultorioController : BaseApiController
{
    private readonly IUnitOfWork unitOfWork;

    public ConsultorioController(IUnitOfWork _unitOfWork)
    {
        unitOfWork = _unitOfWork;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<Consultorio>>> Get()
    {
        var consultorio = await unitOfWork.Consultorios.GetAllAsync();
        return Ok(consultorio);
    }
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Get(string id)
    {
        var consultorio = await unitOfWork.Consultorios.GetByIdAsync(id);
        return Ok(consultorio);
    }
}