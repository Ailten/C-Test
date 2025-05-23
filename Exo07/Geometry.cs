
using System.Drawing;

/// <summary>
/// class parent of all geometry class.
/// </summary>
abstract public class Geometry : IDrawable, ISize
{
    private static int idCount = 0;
    private int id;
    protected string name;
    protected Color color;


    public Geometry(string name, Color color)
    {
        this.id = idCount++;
        this.name = name;
        this.color = color;
    }

    public Geometry(string name)
    {
        this.id = idCount++;
        this.name = name;
    }

    public abstract void draw();

    public abstract double getSize();

    public virtual string getData()
    {
        return (
            $"id: {this.id}\n" +
            $"name: {this.name}\n" +
            $"type: {this.GetType().ToString()}\n" +
            $"color: {this.color.ToString()}"
        );
    }


}