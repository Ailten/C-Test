
public class SpecialRectangle
{
    private double length;
    private double width;

    public double getLength
    {
        get { return this.length; }
    }

    public double getWidth
    {
        get { return this.width; }
    }

    public double getSurface
    {
        get { return this.length * this.width; }
    }

    public SpecialRectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    /// <summary>
    /// surcharge operator add. make a new Rectangle from both add together.
    /// </summary>
    /// <param name="rectA">first rectangle.</param>
    /// <param name="rectB">second rectangle.</param>
    /// <returns>a new rectangle.</returns>
    public static SpecialRectangle operator +(SpecialRectangle rectA, SpecialRectangle rectB)
    {
        // find the shorter and the bigger.
        bool isAShorter = (rectA.length < rectB.length);
        SpecialRectangle shorterRect = (isAShorter) ? rectA : rectB;
        SpecialRectangle biggerRect = (isAShorter) ? rectB : rectA;

        // set a rectangle with length of shorter and with of both.
        double length = shorterRect.length;
        double width = rectA.width + rectB.width;

        // add rest from the bigger one.
        double difLength = biggerRect.length - shorterRect.length;
        double difSurface = difLength * biggerRect.width;
        width += difSurface / length;

        // make the new rectangle.
        return new SpecialRectangle(length, width);
    }

    /// <summary>
    /// surcharge of cast rectangle to double.
    /// </summary>
    /// <param name="x">the rectangle</param>
    /// <returns>the double of rectangle surface.</returns>
    public static implicit operator double(SpecialRectangle rectA)
    {
        return rectA.getSurface;
    }

    /// <summary>
    /// override to string from object.
    /// </summary>
    /// <returns>a string containing data of rectangle.</returns>
    public override string ToString()
    {
        return $"Rect => [l:{this.length}, w:{this.width}] => [{(double)this}]";
    }

    /// <summary>
    /// make an acessor by index to class. (can be call instance[0] for recup length attribute)
    /// </summary>
    /// <param name="index">index parameter</param>
    /// <returns>the value length or with (depend on index send).</returns>
    public double this[int index]
    {
        get
        {
            if (index == 0)
                return this.getLength;
            if (index == 1)
                return this.getWidth;
            else
                throw new ElementNotFound();
        }
    }

}