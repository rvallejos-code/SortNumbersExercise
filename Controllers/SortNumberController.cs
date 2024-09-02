using Microsoft.AspNetCore.Mvc;

namespace SortNumbersExercise.Controllers;

[ApiController]
[Route("[controller]")]
public class SortNumberController : ControllerBase
{
    private readonly ILogger<SortNumberController> _logger;

    public SortNumberController(ILogger<SortNumberController> logger) =>
        _logger = logger;

    [HttpGet]
    public IEnumerable<int> Get([FromQuery] int[] numbers)
    {
        // TODO: retornar numeros ordenador de mayor a menor.
        return [];
    }
}
