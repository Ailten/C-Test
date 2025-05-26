
public class Exo27 : Exo
{
    /// <summary>
    /// goto. (do not use : depreciate)
    /// </summary>
    /// <param name="parameters">list string of parameters need to execute exo.</param>
    override public void Execute(List<string> parameters)
    {
        
        Console.WriteLine("START");
        int i = 0;

    MYENCRE:

        Console.WriteLine($"i: {i++}");

        if (i < 10)
            goto MYENCRE; // goto an encre.
        
        Console.WriteLine("END");

    }
}