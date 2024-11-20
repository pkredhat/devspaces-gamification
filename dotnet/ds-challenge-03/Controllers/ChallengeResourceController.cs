using Microsoft.AspNetCore.Mvc;

namespace ds_challenge_03.Controllers;

[ApiController]
[Route("[controller]")]
public class ChallengeResourceController : ControllerBase
{


    private readonly ILogger<ChallengeResourceController> _logger;

    public ChallengeResourceController(ILogger<ChallengeResourceController> logger)
    {
        _logger = logger;
    }
    [HttpGet("greet/{name}")]
    [Produces("text/plain")]
    public string GreetUser(string name)
    {
        string user = name;
        return $"Hello {user}\n";
    }

    [HttpGet("hello")]
    [Produces("text/plain")]
    public string Greet()
    {
        return "Hello Challenge Attendees";
    }

}
