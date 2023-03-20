using Microsoft.AspNetCore.Mvc;
using LookupServiceAPI.Models;

namespace LookupServiceAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class CreditDataController : ControllerBase
{
    private readonly ILogger<CreditDataController> _logger;

    public CreditDataController(ILogger<CreditDataController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "credit-data")]
    public IEnumerable<CreditDataItem> Get()
    {
        return new CreditDataItem
        {
            firstName = "Jonathan",
            lastName = "Bateman",
            address = "7 Goodrich Rd, Cheltenham, GL52 5FT",
            assessedIncome = 50000,
            balanceOfDebt = 0,
            complaints = "false"
        };
    }
}
