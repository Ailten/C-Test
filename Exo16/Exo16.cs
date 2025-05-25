
using System.Text;

public class Exo16 : Exo
{
    /// <summary>
    /// string writer.
    /// </summary>
    /// <param name="parameters">list string of parameters need to execute exo.</param>
    override public void Execute(List<string> parameters)
    {
        // make a string with a string builder.
        StringBuilder sb = new StringBuilder(" --- My Note --- \n");
        sb.Append("1. buy some milk.\n");
        sb.Append("2. refill the car.\n");
        sb.Append("3. walk the dog.\n");

        // make a string writer (for example).
        StringWriter sw = new StringWriter(sb); // with data of sb.
        sw.WriteLine("4. go back to home.\n"); // add a row. (the row is add to the string builder).
        sw.Flush(); // erase it. (data stay on sring builder)

        // write on a file (stream writer)
        using (StreamWriter streamWriter = new StreamWriter("Exo16/myNote.txt"))
        {
            // use a string reader.
            StringReader sr = new StringReader(sb.ToString());
            string? line;
            while ((line = sr.ReadLine()) != null) // loop until no more value.
            {
                Console.WriteLine(line);
                streamWriter.WriteLine(line);
            }
        }



    }
}