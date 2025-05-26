//using static NamespaceExo14.Exo14; // example of using.
//
//namespace NamespaceExo14 // example of namespace, for making unacessible for every other (without using).
//{}

public class Exo14 : Exo
{
    /// <summary>
    /// function.
    /// </summary>
    /// <param name="parameters">list string of parameters need to execute exo.</param>
    override public void Execute(List<string> parameters)
    {
        // parameters can be send by specify name (various order, or skip for default value).
        Console.WriteLine("--- First ---");
        MyFirstFunc(1, 2);
        MyFirstFunc(b: 2, a: 1);

        // example of default value to parameters.
        Console.WriteLine("--- Second ---");
        MySecondFunc(1, 2);
        MySecondFunc(1);

        // function with a various amount of parameters.
        Console.WriteLine("--- Third ---");
        MyThirdFunc(1);
        MyThirdFunc(1, 2, 3, 4);

        // function with parameters this (for make callable from an ohter element).
        Console.WriteLine("--- Four ---");
        AnObject myObject = new AnObject();
        myObject.MyFourFunc(2);

        // function with ref (send variable by reference, can be edit on the function) object is always passing by reference.
        Console.WriteLine("--- Fift ---");
        int a = 1;
        int b = 2;
        MyFiftFunc(ref a, b);
        Console.WriteLine($"a: {a}, b: {b}");

        // example of lambda syntax. () => {}
        Console.WriteLine("--- Lambda ---");
        MyLambda(1, 2);

        // example of Action. (no parameter, no return).
        Console.WriteLine("--- Action ---");
        Action stockAction = () => { Console.WriteLine("call on a Action"); };
        stockAction();

        // make a function on a Func. (one parameter enter, one parameter return).
        Console.WriteLine("--- Func ---");
        Func<int, string> stockAFunc = (int a) => { return $"a: {a}"; };
        Console.WriteLine(stockAFunc(1));
        Func<int, int, bool> stockAFuncTwoParam = (int a, int b) =>
        {
            Console.WriteLine($"a: {a}, b: {b}");
            return true;
        };
        stockAFuncTwoParam(1, 2);

        // delegate example (delegate is like a type function with signature).
        Console.WriteLine("--- Delegate ---");
        MyDelegate myD = new MyDelegate(this.MyFirstFunc);
        myD(1, 2);
        myD = new MyDelegate(this.MyLambda); // can be replace.
        myD(1, 2);

    }
    public void MyFirstFunc(int a, int b)
    {
        Console.WriteLine($"a: {a}, b: {b}");
    }
    public void MySecondFunc(int a, int b = 2)
    {
        Console.WriteLine($"a: {a}, b: {b}");
    }
    public void MyThirdFunc(params int[] arrayA)
    {
        Console.WriteLine($"{string.Join(", ", arrayA)}");
    }
    public void MyFiftFunc(ref int a, int b)
    {
        a = 5;
        b = 5;
    }

    public void MyLambda(int a, int b) => Console.WriteLine($"a: {a}, b: {b}");

    public delegate void MyDelegate(int a, int b);
}
public static class BlockStatic
{
    public static void MyFourFunc(this AnObject a, int b) // need to be place static and on a class static.
    {
        Console.WriteLine($"a: {a.GetType()}, b: {b}");
    }
}
public class AnObject
{
}

