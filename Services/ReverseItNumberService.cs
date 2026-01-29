using System.Linq;

namespace AllForOne.Services;

public class ReverseItNumberService
{
    public string Reverse(string input)
    {
        if (!input.All(char.IsDigit))
        {
            return  null;
        }

        return new string(input.Reverse().ToArray());
    }
}
