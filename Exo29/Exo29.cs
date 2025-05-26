

public class Exo29 : Exo
{
    /// <summary>
    /// test unitaire.
    /// </summary>
    /// <param name="parameters">list string of parameters need to execute exo.</param>
    override public void Execute(List<string> parameters)
    {
        double a = 10;
        double b = 2;
        Console.WriteLine($"{a} / {b} = {divide(a, b)}");
    }

    public double divide(double a, double b)
    {
        return a / b;
    }
}