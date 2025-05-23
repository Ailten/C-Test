
using System.Text.RegularExpressions;

public class Exo05 : Exo
{
    /// <summary>
    /// regex.
    /// </summary>
    /// <param name="parameters">list string of parameters need to execute exo.</param>
    override public void Execute(List<string> parameters)
    {
        // get data.
        string txt = (parameters.Count >= 1) ? parameters[0] : "abc";
        string regex = (parameters.Count >= 2) ? parameters[1] : "b";
        string replace = (parameters.Count >= 3) ? parameters[2] : "#";

        // replace by regex.
        Regex rgx = new Regex(regex);
        string output = rgx.Replace(txt, replace);
        Console.WriteLine(txt);
        Console.WriteLine(output);
    }
}