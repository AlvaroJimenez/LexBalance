using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LexBalance.Cases.Api.Controllers;

[ApiController]
[Authorize]
[Route("expedientes")]
public class CasesController : ControllerBase
{
    // POST /expedientes
    [HttpPost]
    public IActionResult Create() => StatusCode(StatusCodes.Status501NotImplemented);

    // GET /expedientes (lista con el nombre del abogado asignado)
    [HttpGet]
    public IActionResult GetAll() => StatusCode(StatusCodes.Status501NotImplemented);
}
