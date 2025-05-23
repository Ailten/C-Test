
/// <summary>
/// exception when a parameter is missing on a function call.
/// </summary>
public class MissingParameter : Exception
{
    public MissingParameter() : base("Missing Parameter")
    {

    }
}