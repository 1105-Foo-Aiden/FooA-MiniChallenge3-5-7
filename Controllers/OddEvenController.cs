using FooA_MiniChallenge3_5_7.Services.OddEven;
using Microsoft.AspNetCore.Mvc;

namespace FooA_MiniChallenge3_5_7.Controllers;
[ApiController]
[Route("/OddEven/{number}")]
public class OddEvenController
{
    private readonly IOddEven oddEven;

    public OddEvenController(IOddEven OddEven)
    {
        oddEven = OddEven;
    }
    public string OddOrEven(double number)
    {
        return oddEven.OddOrEven(number);
    }
}
