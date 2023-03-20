using Microsoft.AspNetCore.Mvc;

namespace LookupServiceAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonalDetailsController : ControllerBase
{

    private readonly ILogger<PersonalDetailsController> _logger;

    public PersonalDetailsController(ILogger<PersonalDetailsController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetPersonalDetails")]
    public IActionResult GetPersonalDetails(string ssn)
    {
        return new PersonalDetails
        {
            firstName,
            lastName,
            address
        })
        .ToArray();
    }
}