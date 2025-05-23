
using System.Drawing;

public class Rectangle : Geometry
{
    private int width;
    private int length;

    public Rectangle(Color color, int width, int length) : base("Rectangle")
    {
        this.color = color;
        this.width = width;
        this.length = length;
    }
    public Rectangle(int width, int length) : base("Rectangle", Color.Black)
    {
        this.width = width;
        this.length = length;
    }





    public override void draw()
    {
        Console.WriteLine("draw a Rectangle.");
    }

    public override double getSize()
    {
        return this.width * this.length;
    }

    public override string getData()
    {
        string output = base.getData();
        output += ("\n" +
            $"size: {this.getSize()}"
        );
        return output;
    }

}