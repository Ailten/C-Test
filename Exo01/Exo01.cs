
public class Exo01 : Exo
{
    /// <summary>
    /// write in console.
    /// </summary>
    /// <param name="parameters">list string of parameters need to execute exo.</param>
    override public void Execute(List<string> parameters)
    {
        Console.WriteLine("--- list of parameters ---");

        parameters.ForEach(param => Console.WriteLine(" - " + param));

        Console.WriteLine("--------------------------");
    }
}