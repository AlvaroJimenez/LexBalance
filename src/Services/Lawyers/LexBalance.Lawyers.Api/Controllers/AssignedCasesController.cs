using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LexBalance.Lawyers.Api.Controllers;

[ApiController]
[Authorize]
[Route("expedientes")]
public class AssignedCasesController : ControllerBase
{
    // GET /expedientes/abogado/{lawyerId}
    [HttpGet("abogado/{lawyerId}")]
    public IActionResult GetByLawyer(int lawyerId) => StatusCode(StatusCodes.Status501NotImplemented);
}
