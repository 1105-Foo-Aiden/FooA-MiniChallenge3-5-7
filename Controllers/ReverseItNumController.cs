using Microsoft.AspNetCore.Mvc;

namespace FooA_MiniChallenge3_5_7.Controllers;
[ApiController]
[Route("[controller]")]
public class ReverseItNumController : Controller
{
    [HttpGet]
    [Route("/ReverseItNum/{number}")]
    public string ReverseitNum(int number)
    {

        string inputNumber = number.ToString();

        Char[] numCharArray = inputNumber!.ToCharArray();

        Array.Reverse(numCharArray);

        string result = string.Join("", numCharArray);
        return result;
    }
}