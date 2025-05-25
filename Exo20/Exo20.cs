
using System.Diagnostics;

public class Exo20 : Exo
{
    /// <summary>
    /// debug mode.
    /// </summary>
    /// <param name="parameters">list string of parameters need to execute exo.</param>
    override public void Execute(List<string> parameters)
    {

#if DEBUG
        Console.WriteLine("it's run on debug mode.");
#else
        Console.WriteLine("it's run on normal mode.");
#endif


        #region my block of code

        // delimit a block of code (for readability).

        #endregion

    }

}