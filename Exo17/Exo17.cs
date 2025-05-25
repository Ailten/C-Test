
public class Exo17 : Exo
{
    /// <summary>
    /// string.
    /// </summary>
    /// <param name="parameters">list string of parameters need to execute exo.</param>
    override public void Execute(List<string> parameters)
    {
        // data.
        string myStr = "abc";
        Console.WriteLine($"row data : {myStr}");

        Console.WriteLine($"substring(0, 2) : {myStr.Substring(0, 2)}");

        Console.WriteLine($"indexOf(\"bc\") : {myStr.IndexOf("bc")}");

        Console.WriteLine($"startsWith(\"a\") : {myStr.StartsWith("a")}");

        Console.WriteLine($"endWith(\"a\") : {myStr.EndsWith("a")}");

        Console.WriteLine($"replace(\"bc\", \"-def-\") : {myStr.Replace("bc", "-def-")}");

        Console.WriteLine($"remove(0, 2) : {myStr.Remove(0, 2)}");

        string[] arrayS = myStr.Split("b");
        Console.WriteLine($"split(\"b\") : [{string.Join(", ", arrayS)}]");

    }
}