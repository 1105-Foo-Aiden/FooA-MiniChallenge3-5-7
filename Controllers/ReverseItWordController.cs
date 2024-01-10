using Microsoft.AspNetCore.Mvc;

namespace FooA_MiniChallenge3_5_7.Controllers;

[ApiController]
[Route("[controller]")]
public class ReverseItWordController : Controller
{
    [HttpGet]
    [Route("/ReverseItWord/{word}")]
    public string ReverseitNum(string word)
    {
        int.TryParse(word, out int numberCheck);

        return numberCheck == 0 ? Reverse() : "That is not a valid word, please try again";
    
        string Reverse(){
             Char[] numCharArray = word!.ToCharArray();

            Array.Reverse(numCharArray);

            string result = string.Join("", numCharArray);
            return result;
        }
    }
}