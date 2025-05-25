
using System.Text.Json;

public class Exo10 : Exo
{
    /// <summary>
    /// write in console.
    /// </summary>
    /// <param name="parameters">list string of parameters need to execute exo.</param>
    override public void Execute(List<string> parameters)
    {
        // instantie an object.
        var myBox = new Box()
        {
            myInt = 5,
            myDouble = 0.2,
            myString = "this is a box",
            myChar = 'A'
        };

        // cast obj to json string.
        string jsonStr = JsonSerializer.Serialize(myBox);
        Console.WriteLine(jsonStr);

        // save on file.
        using (var sw = new StreamWriter("Exo10/boxSave.json"))
        {
            sw.WriteLine(jsonStr);
        }


        // some object can be marked [Serializable] (for mark it can be fold on a compact json or xml).
        // also some parameter of object serializable can be mark [NonSerializable].

    }
}