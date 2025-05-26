

public class Exo28 : Exo
{
    /// <summary>
    /// event.
    /// </summary>
    /// <param name="parameters">list string of parameters need to execute exo.</param>
    override public void Execute(List<string> parameters)
    {

        myEvent += new EventHandler<int>(myVoidA);
        myEvent += new EventHandler<int>(myVoidB);

        var obj = new Obj()
        {
            A = 0,
            B = 0
        };

        Console.WriteLine(" --- start main call --- ");
        Console.WriteLine($"A:{obj.A}, B:{obj.B}");

        myEvent.Invoke(obj, 5);

        Console.WriteLine(" --- end main call --- ");
        Console.WriteLine($"A:{obj.A}, B:{obj.B}");

    }

    public static event EventHandler<int> myEvent;


    public static void myVoidA(object sender, int e)
    {
        Obj obj = (sender as Obj ?? throw new ObjectCast());
        obj.A = e;
        Console.WriteLine(" --- call void A --- ");
        Console.WriteLine($"A set to {obj.A}");
    }
    public static void myVoidB(object sender, int e)
    {
        Obj obj = (sender as Obj ?? throw new ObjectCast());
        obj.B = e;
        Console.WriteLine(" --- call void B --- ");
        Console.WriteLine($"B set to {obj.B}");
    }
    public static void myVoidPrint(object sender, int e)
    {
        Obj obj = (sender as Obj ?? throw new ObjectCast());
        Console.WriteLine(" --- call void print --- ");
        Console.WriteLine($"A:{obj.A}, B:{obj.B}");
    }


    public class Obj
    {
        public int A { get; set; }
        public int B { get; set; }
    }


    /// <summary>
    /// example of "add" and "remove".
    /// </summary>
    public event EventHandler<int> myEvn
    {
        add
        {
            myEvn += value;
        }
        remove
        {
            myEvn -= value;
        }
    }

}