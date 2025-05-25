
public class Exo15 : Exo
{
    /// <summary>
    /// yield.
    /// </summary>
    /// <param name="parameters">list string of parameters need to execute exo.</param>
    override public void Execute(List<string> parameters)
    {
        // call function fibonatcci and print it.
        Console.WriteLine(string.Join(", ", Fibonatcci(9)));

    }

    public IEnumerable<int> Fibonatcci(int amountOfRow)
    {
        int[] lastValue = new int[]{1, 0};
        for (int i = 0; i < amountOfRow; i++)
        {
            int newValue = lastValue.Sum();
            yield return newValue; // return single int, many time, to return an IEnumerable.
            lastValue[i % 2] = newValue; // + can make action after the return.
        }
    }
}