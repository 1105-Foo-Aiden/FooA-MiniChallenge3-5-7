using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FooA_MiniChallenge3_5_7.Services.MadLib
{
    public interface IMadLib
    {
        public string MadLibStory(string name, string place, string adverb, string name2, int numberOf, string thing, string adjective2, string verb, string verb2);
    }
}