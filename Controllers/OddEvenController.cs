using FooA_MiniChallenge3_5_7.Services.OddEven;
using Microsoft.AspNetCore.Mvc;

namespace FooA_MiniChallenge3_5_7.Controllers;
[ApiController]
[Route("[controller]")]

public class OddEvenController : ControllerBase
{

    private readonly IOddEven oddEven;

    public OddEvenController(IOddEven OddEven)
    {
        oddEven = OddEven;
    }

    [HttpGet]
    [Route("/OddOrEven/{number}")]
    public string OddOrEven(double number)
    {
        return oddEven.OddOrEven(number);
    }
}
