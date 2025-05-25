
/// <summary>
/// circle (as struct).
/// struct = no eritage.
/// </summary>
public struct Circle
{
    private int rayon;

    public Circle(int rayon)
    {
        this.rayon = rayon;
    }

    public double getSize()
    {
        return Math.Pow(rayon, 2);
    }

    public string getData()
    {
        return (
            $"type: {this.GetType().ToString()}\n" +
            $"size: {this.getSize()}"
        );
    }
}