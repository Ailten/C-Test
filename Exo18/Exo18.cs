
using System.Diagnostics;
using System.Globalization;

public class Exo18 : Exo
{
    /// <summary>
    /// date.
    /// </summary>
    /// <param name="parameters">list string of parameters need to execute exo.</param>
    override public void Execute(List<string> parameters)
    {
        // stock date now.
        DateTime d = DateTime.Now;
        Console.WriteLine(d);

        // print on another format region.
        CultureInfo c = new("en-US"); // or "fr-FR".
        Console.WriteLine(d.ToString(c));

        // ask only the date (not time part, hours minutes seconde.)
        Console.WriteLine(d.ToString("d", c));

        // make a date 1 day before now.
        DateTime dTomorow = d; // duplicate, becose DateTime is a struct.
        dTomorow = dTomorow.AddDays(1);
        Console.WriteLine($"is tomorow bigger than now : {(dTomorow.Date > d.Date)}");

        // diference between two date.
        TimeSpan dif = dTomorow - d;
        double difHours = dif.TotalHours;
        Console.WriteLine($"amount of hours between now and tomorow : {difHours}h");


        // example of Stopwatch, a way to chrono on the performence code.
        Stopwatch sw = new Stopwatch();
        sw.Start();
        Thread.Sleep(5); // wait.
        sw.Stop();
        Console.WriteLine($"code execute time : {sw.Elapsed}");


    }
}