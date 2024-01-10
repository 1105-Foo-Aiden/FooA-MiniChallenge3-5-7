using FooA_MiniChallenge3_5_7.Services.MadLib;
using Microsoft.AspNetCore.Mvc;

namespace FooA_MiniChallenge3_5_7.Controllers;
[ApiController]
[Route("[controller]")]
public class MadLibController : Controller
{
    private readonly IMadLib madLib;

    public MadLibController(IMadLib MadLib)
    {
        madLib = MadLib;
    }
    [HttpGet]
    [Route("/MadLib/{name}/{place}/{avderb}/{name2}/{numberOf}/{thing}/{adjective2}/{verb}/{verb2}")]
    public string MadLibStory(string name, string place, string adverb, string name2, int numberOf, string thing, string adjective2, string verb, string verb2)
    {
        return madLib.MadLibStory(name, place, adverb, name2, numberOf, thing, adjective2, verb, verb2);
    }
}
