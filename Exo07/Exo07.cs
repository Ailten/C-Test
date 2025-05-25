
using System.Drawing;

public class Exo07 : Exo
{
    /// <summary>
    /// object.
    /// </summary>
    /// <param name="parameters">list string of parameters need to execute exo.</param>
    override public void Execute(List<string> parameters)
    {
        // set many geometry.
        Geometry[] manyGeometry = new Geometry[]
        {
            new Square(5),
            new Square(Color.Red, 4),
            new Rectangle(5, 2),
            new Rectangle(Color.Brown, 4, 3)
        };

        // loop print.
        manyGeometry.ToList().ForEach(g =>
        {
            Console.WriteLine("---");
            Console.WriteLine(g.getData());
        });


        // example struct.
        Circle circle = new Circle(5);
        Console.WriteLine("--- struct circle ---");
        Console.WriteLine(circle.getData());


        // example of keyword as (return element of set class or null).
        Console.WriteLine("--- List Square ---");
        List<Square?> listS = manyGeometry.Select(g => g as Square).ToList();
        Console.WriteLine(string.Join(", ", listS));


        // key word sealed make a parameter or a class disable to eritage (no child can be maked with this class parent, or unsable to make function override).
        // look getData on class Square for example.

        // example of Interface usefull : 
        //IEnumerable (for list), 
        //IComparable (for make comparable to other class).
        //IDisposable (for make free memory some ressource no longer use).
    }
}