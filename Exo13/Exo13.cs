
using System.Reflection;

public class Exo13 : Exo
{
    /// <summary>
    /// attribut.
    /// </summary>
    /// <param name="parameters">list string of parameters need to execute exo.</param>
    override public void Execute(List<string> parameters)
    {
        // enum Tast has atribut Flags, make it can containing many values.
        Tast myTast = Tast.Vanilla | Tast.Chocolat;

        // print.
        Console.WriteLine(myTast); // default return a single value.
        Console.WriteLine(myTast.HasFlag(Tast.Vanilla)); // True, it contain this value.
        Console.WriteLine(myTast.HasFlag(Tast.Chocolat)); // True, it contain this value.
        Console.WriteLine(myTast.HasFlag(Tast.Pistash)); // False, don't have this value.


        // there are other attributs with other effect.
        // Serializable / NonSerializable. (for making json or export on format).


        // list every attribute on Tast.
        Console.WriteLine("---");
        List<string> customAttriute = typeof(Tast).GetCustomAttributesData().Select(cad => cad.ToString()).ToList();
        customAttriute = typeof(Tast).GetProperties().Select(p => p.Name).ToList(); // same resultat, other methode.
        Console.WriteLine(string.Join(", ", customAttriute));

        bool isTastHasAttributeFlags = Attribute.IsDefined(typeof(Tast), typeof(FlagsAttribute));
        if (isTastHasAttributeFlags)
            Console.WriteLine("yes, Tast has attribute Flags");

    }
}


[Flags]
[MyAttribut("Thomas the Developper")]
enum Tast
{
    Vanilla,
    Chocolat,
    Pistash
}