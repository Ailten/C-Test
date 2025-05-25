
using System.Drawing;

public class Square : Geometry
{
    private int length;

    public Square(Color color, int length) : base("Square")
    {
        this.color = color;
        this.length = length;
    }
    public Square(int length) : base("Square", Color.Black)
    {
        this.length = length;
    }



    public override void draw()
    {
        Console.WriteLine("draw a square.");
    }

    public override double getSize()
    {
        return Math.Pow(length, 2);
    }

    public sealed override string getData() // heer sealed make getData unpossible to override for every child of square (last override on eritage).
    {
        string output = base.getData();
        output += ("\n" +
            $"size: {this.getSize()}"
        );
        return output;
    }


}