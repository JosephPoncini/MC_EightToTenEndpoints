using MC_EightToTenEndpoints.Services.RestarauntPicker;
using Microsoft.AspNetCore.Mvc;

namespace MC_EightToTenEndpoints.Controllers;
[ApiController]
[Route("[controller]")]
public class RestarauntPickerController : ControllerBase
{
    private readonly IRestarauntPickerService _restarauntPickerService;

    public RestarauntPickerController(IRestarauntPickerService restarauntPickerService)
    {
        _restarauntPickerService = restarauntPickerService;
    }

    [HttpGet]
    [Route("Pick_American_Mexican_Or_Asian/{category}")]
    public string RestarauntPickerMachine(string category){
        return _restarauntPickerService.RestarauntPickerMachine(category);
    }
}
