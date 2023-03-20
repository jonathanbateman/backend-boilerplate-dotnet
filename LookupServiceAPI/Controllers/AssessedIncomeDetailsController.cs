using Microsoft.AspNetCore.Mvc;

namespace LookupServiceAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class AssessedIncomeDetailsController : ControllerBase
{

    private readonly ILogger<AssessedIncomeDetailsController> _logger;

    public AssessedIncomeDetailsController(ILogger<AssessedIncomeDetailsController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "assessed-income")]
    public IActionResult GetAssessedIncomeDetails(string ssn)
    {
        return new AssessedIncomeDetails
        {
            assessedIncome = new List<AssessedIncomeDetails>

        };
    }
}