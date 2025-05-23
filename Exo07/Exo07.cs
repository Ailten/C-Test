
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


    }
}