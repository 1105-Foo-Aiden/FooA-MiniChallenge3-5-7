namespace FooA_MiniChallenge3_5_7.Services.OddEven;

    public class OddEven : IOddEven
    {
        public string OddOrEven(double number){
            return number % 2 == 0 ? $"{number} is even" : $"{number} is odd";
        }
    }
