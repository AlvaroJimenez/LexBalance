using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LexBalance.Lawyers.Api.Controllers;

[ApiController]
[Authorize]
[Route("abogados")]
public class LawyersController : ControllerBase
{
    // GET /abogados
    [HttpGet]
    public IActionResult GetAll() => StatusCode(StatusCodes.Status501NotImplemented);
}
