namespace AllForOne.Services;

public class MadLibService
{
    public string Create(string noun, string adjective, string verb)
    {
        return $"The {adjective} {noun} likes to {verb}.";
    }
}
