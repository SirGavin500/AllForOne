using System.Linq;

namespace AllForOne.Services;

public class ReverseItAlphaService
{
    public string Reverse(string input)
    {
        return new string(input.Reverse().ToArray());
    }
}
