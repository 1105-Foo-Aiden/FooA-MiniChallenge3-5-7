namespace FooA_MiniChallenge3_5_7.Services.MadLib;

public class MadLib : IMadLib
{
    public string MadLibStory(string name, string place, string adverb, string name2, int numberOf, string thing, string adjective2, string verb, string verb2)
    {
        return $"{name} went to {place} {adverb} in order to go see {name2}'s {numberOf} {thing}. They had a(n) {adjective2} time, {verb} and {verb2} all day long.";
    }
}
