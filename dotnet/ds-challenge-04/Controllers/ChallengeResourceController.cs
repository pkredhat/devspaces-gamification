using Microsoft.AspNetCore.Mvc;

namespace ds_challenge_04.Controllers;

[ApiController]
[Route("[controller]")]
public class ChallengeResourceController : ControllerBase
{
    private readonly ILogger<ChallengeResourceController> _logger;

    public ChallengeResourceController(ILogger<ChallengeResourceController> logger)
    {
        _logger = logger;
    }


    [HttpGet("challenge04")]
    [Produces("text/plain")]
    public string ChallengeMethod()
    {
        string name = "OpenShift DevSpaces";
        int length = name.Length;

        for (int index = 0; index < length; index++)
        {
            char myChar = name[index];
            if (index == 4) // Index 4 represents the fifth character in a zero-based index system
            {
                char fifthCharacter = name[index];
                return $"The Fifth Character in the word \"OpenShift\"=[{fifthCharacter}]\n";
            }
        }
        return "String is shorter than length 5 \n";
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
