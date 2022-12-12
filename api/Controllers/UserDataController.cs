using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Api.Models;

namespace api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DemoController : ControllerBase
{
    public UserData userData = new UserData();

    [HttpGet]
    public IEnumerable<UserData> Get()
    {
        userData.createTestData();
        return userData.userDataList;
    }

    [HttpGet("{id}")]
    public ActionResult<UserData> Get(int id)
    {
        try
        {
            userData.createTestData();
            int i = userData.userDataList.FindIndex(userData => userData.Id == id);
            return userData.userDataList[i];
        }
        catch
        {
            return NotFound();
        }
    }
}
