using Microsoft.AspNetCore.Mvc;

namespace LookupServiceAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class DebtDetailsController : ControllerBase
{

    private readonly ILogger<DebtDetailsController> _logger;

    public DebtDetailsController(ILogger<DebtDetailsController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "debt-details")]
    public IActionResult GetDebtDetails(string ssn)
    {
        return new DebtDetails
        {
            balanceOfDebt = new List<DebtDetails>,
            complaints = new List<DebtDetails>
        };
    }
}