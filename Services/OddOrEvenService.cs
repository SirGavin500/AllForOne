namespace AllForOne.Services;

public class OddOrEvenService
{
    public string Check(int number)
    {
        return number % 2 == 0 ? "Even" : "Odd";
    }
}
