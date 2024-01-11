using MC_EightToTenEndpoints.Services.MagicEightBall;
using Microsoft.AspNetCore.Mvc;

namespace MC_EightToTenEndpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class MagicEightBallController : ControllerBase
{
    private readonly IMagicEightBallService _magicEightBallService;

    public MagicEightBallController(IMagicEightBallService magicEightBallService)
    {
        _magicEightBallService = magicEightBallService;
    }


    [HttpGet]
    [Route("Question/{question}")]
    public string AnswerMachine(string question){
        return _magicEightBallService.AnswerMachine(question);
    }
}
