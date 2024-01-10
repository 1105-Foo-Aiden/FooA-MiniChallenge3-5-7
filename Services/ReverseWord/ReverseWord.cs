namespace FooA_MiniChallenge3_5_7.Services.ReverseWord;

public class ReverseWord : IReverseWord
{
    public string ReverseitNum(string word)
    {
        Char[] numCharArray = word!.ToCharArray();

        Array.Reverse(numCharArray);

        string result = string.Join("", numCharArray);
        return result;
    }
}
