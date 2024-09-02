using Microsoft.AspNetCore.Mvc;

namespace SortNumbersExercise.Controllers;

[ApiController]
[Route("[controller]")]
public class SortNumberController : ControllerBase
{
    private readonly ILogger<SortNumberController> _logger;

    public SortNumberController(ILogger<SortNumberController> logger) =>
        _logger = logger;

    public IEnumerable<int> Get()
    {
        return [];
    }
}
