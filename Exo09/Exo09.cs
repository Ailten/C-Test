
public class Exo09 : Exo
{
    /// <summary>
    /// obj suite. (surcharge cast and operator, type generique, getter/setter)
    /// </summary>
    /// <param name="parameters">list string of parameters need to execute exo.</param>
    override public void Execute(List<string> parameters)
    {
        // make two rectangle.
        SpecialRectangle A = new SpecialRectangle(5, 2);
        SpecialRectangle B = new SpecialRectangle(8, 6);

        // make two caster (for example of generic type).
        SpecialCaster<string> ToString = new();
        SpecialCaster<double> ToDouble = new(); // not use.

        // print data.
        Console.WriteLine("Rect A ---");
        Console.WriteLine(ToString.cast(A));
        Console.WriteLine("Rect B ---");
        Console.WriteLine(ToString.cast(B));

        // add both (using surcharge operator).
        SpecialRectangle C = A + B;

        // print data C.
        Console.WriteLine("Rect C ---");
        Console.WriteLine(ToString.cast(C));

        // verify data C.
        Console.WriteLine("surface Rect A+B ---");
        Console.WriteLine($"surface => {A.getSurface + B.getSurface}");

    }
}