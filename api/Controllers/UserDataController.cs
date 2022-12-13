using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Api.Models;
using Api.Services;
using Swashbuckle.AspNetCore.Annotations;

namespace api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DemoController : ControllerBase
{
    ApiService _service;

    public DemoController(ApiService service)
    {
        _service = service;
    }

    public UserData userData = new UserData();

    [HttpGet]
    public IEnumerable<UserData> Get()
    {
        // userData.createTestData();
        // return userData.userDataList;
        return _service.GetAll();
    }

    [HttpGet("{id}")]
    [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(UserData))]
    [SwaggerResponse(StatusCodes.Status404NotFound, Type = typeof(NotFoundResult))]
    public ActionResult<UserData> Get(int id)
    {
        // try
        // {
        //     userData.createTestData();
        //     int i = userData.userDataList.FindIndex(userData => userData.Id == id);
        //     return userData.userDataList[i];
        // }
        // catch
        // {
        //     return NotFound();
        // }
        var userData = _service.GetById(id);

        if (userData is not null)
        {
            return Ok(userData);
        }
        else
        {
            return NotFound(userData);
        }
    }
}
