using Microsoft.AspNetCore.Mvc;

namespace FooA_MiniChallenge3_5_7.Controllers;
[ApiController]
[Route("[controller]")]
public class FiveController : Controller
{
    public string Five(){
        return "remove errors";
    }
}
