using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DemoController : ControllerBase{
    private readonly ILogger<DemoController> _logger;

    public DemoController(ILogger<DemoController> logger)
    {
        _logger = logger;
    }

    public UserData userData = new UserData();

    [HttpGet(Name = "GetUserData")]
    public UserData Get()
    {
        return userData;
    }
}
