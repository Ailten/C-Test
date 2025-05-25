
using System.Xml.Serialization;

public class Exo12 : Exo
{
    /// <summary>
    /// pile and tas.
    /// </summary>
    /// <param name="parameters">list string of parameters need to execute exo.</param>
    override public void Execute(List<string> parameters)
    {
        // make a primitive (on pile).
        int myIntPile = 5;
        Console.WriteLine($"{myIntPile.GetType()} is a primitive (on pile).");

        // instancie an object (on tas) (managed by garbadge colector).
        if (myIntPile == 5)
        {
            object myObjectTas = new object();
            Console.WriteLine($"{myObjectTas.GetType()} is an object (on tas).");
        }

        // force garbadge colector to clean all object not use (like myObjectTas, because not on a block) bether idee to never use and trust garbadge colector.
        GC.Collect();
        GC.WaitForPendingFinalizers();



        // example of free memory.
        Console.WriteLine("--- other example ---");
        if (myIntPile == 5)
        {
            AClassToGarbedg myObjectTas = new AClassToGarbedg();
            myObjectTas.a = 4;

            myObjectTas.Dispose(); // ask to free stuff (no more use).

            // heer, myObjectTas is still usable, but element on it, is free (after dispose)

            WeakReference weakRef = new(myObjectTas); // weak referance, is for stay info about an instance who can be free by the GC.

            GC.SuppressFinalize(myObjectTas); // free the object. (Fixme, not the result expected)
            GC.Collect();
            GC.WaitForPendingFinalizers();

            // (suposed) myObjectTas free and not usable at this point.

            Console.WriteLine($"the instance is free by the GC : {weakRef.IsAlive}"); // ask if instance is alive.
        }

    }
}

public class AClassToGarbedg : IDisposable
{
    public int a;

    public AClassToGarbedg()
    {
        Console.WriteLine("Instance of AClassToGarbedg is create !");
    }

    /// <summary>
    /// call when the garbadge colector free memory of this instance (we don't know when it's call).
    /// </summary>
    ~AClassToGarbedg()
    {
        Console.WriteLine("Instance of AClassToGarbedg is clean by garbedg colector !");
    }

    /// <summary>
    /// function dipose, for free element until is mark for garbade (like alocation on elemnt, no more use, but still on a scope use).
    /// </summary>
    public void Dispose()
    {
        Console.WriteLine("call Dispose");

        // free elements on the instance.
        this.a = 0; // fake free (for example).
    }
}