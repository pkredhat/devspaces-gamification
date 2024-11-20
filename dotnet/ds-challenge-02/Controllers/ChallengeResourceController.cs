using Microsoft.AspNetCore.Mvc;

namespace ds_challenge_02.Controllers;

[ApiController]
[Route("[controller]")]
public class ChallengeResourceController : ControllerBase
{
    [HttpGet(Name = "hello")]
    [Produces("text/plain")]
    public string Greet()
    {
        return "Hello Challenge Attendees";
    }
    private readonly ILogger<ChallengeResourceController> _logger;

    public ChallengeResourceController(ILogger<ChallengeResourceController> logger)
    {
        _logger = logger;
    }
}
