
class Program
{
    /// <summary>
    /// function call when execute (dotnet run).
    /// </summary>
    /// <param name="args">array of parameter send after cmd dotnet run.</param>
    static void Main(string[] args)
    {
        // missing parameter. TODO: make an menu ascii when no parameter.
        if (args.Length == 0)
            throw new MissingParameter();

        // split args.
        string ExoAsked = args[0];
        List<string> parameters = args.ToList();
        parameters.RemoveAt(0);

        // browse exo manager to find the exo to execute.
        ExoManager.ExecuteAnExo(ExoAsked, parameters);
    }

}