using Microsoft.AspNetCore.Mvc;

namespace MarkMobileMechanic.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult Get() => Ok(new
    {
        Status = "Healthy",
        Timestamp = DateTimeOffset.UtcNow
    });
}
