using MC_EightToTenEndpoints.Services.GuessIt;
using Microsoft.AspNetCore.Mvc;

namespace MC_EightToTenEndpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class GuessItController : ControllerBase
{
    private readonly IGuessItService _guessItService;

    public GuessItController(IGuessItService guessItService)
    {
        _guessItService = guessItService;
    }

    [HttpGet]
    [Route("Pick_a_Number/Easy/{guess}")]
    public string GuessItMachineEasy(string guess)
    {
        return _guessItService.GuessItMachineEasy(guess);
    }

    [HttpGet]
    [Route("Pick_a_Number/Medium/{guess}")]
    public string GuessItMachineMedium(string guess)
    {
        return _guessItService.GuessItMachineMedium(guess);
    }

    [HttpGet]
    [Route("Pick_a_Number/Hard/{guess}")]
    public string GuessItMachineHard(string guess)
    {
        return _guessItService.GuessItMachineHard(guess);
    }
}
