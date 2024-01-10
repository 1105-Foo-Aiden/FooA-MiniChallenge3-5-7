namespace FooA_MiniChallenge3_5_7.Services.ReverseNum;

public class ReverseNum : IReverseNum
{
    public string ReverseitNum(int number)
    {
        string inputNumber = number.ToString();

        Char[] numCharArray = inputNumber!.ToCharArray();

        Array.Reverse(numCharArray);
        string result = string.Join(" ", numCharArray);
        return result;
    }
}
