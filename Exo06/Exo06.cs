
public class Exo06 : Exo
{
    /// <summary>
    /// enum and switch.
    /// </summary>
    /// <param name="parameters">list string of parameters need to execute exo.</param>
    override public void Execute(List<string> parameters)
    {
        // get param.
        string productAsk = (parameters.Count >= 1) ? parameters[0] : "";

        // cast to enum.
        object? objProductAsk;
        EnumProduct enumProductAsk = EnumProduct.Book;
        if (Enum.TryParse(typeof(EnumProduct), productAsk, true, out objProductAsk))
        {
            enumProductAsk = (EnumProduct)(objProductAsk ?? throw new NullElement());

            Console.WriteLine($"product : {enumProductAsk}");
        }
        else
        {
            Console.WriteLine($"no product found for : {productAsk}");
            return;
        }

        // print all enum names.
        string[] listEnum = Enum.GetNames(typeof(EnumProduct));
        Console.WriteLine($"list of enum : [{string.Join(", ", listEnum)}]");

        // a switch/case for processing base on enum.
        switch (enumProductAsk)
        {
            case (EnumProduct.Book):
                Console.WriteLine("it's a book, you can read it.");
                break;
            case (EnumProduct.Pen):
                Console.WriteLine("it's a pen, you can write with it.");
                break;
            case (EnumProduct.Papper):
                Console.WriteLine("it's a papper, you can write on it.");
                break;
            case (EnumProduct.Ink):
                Console.WriteLine("it's somme Ink, you can use it.");
                break;
        }

        // get description from enum.
        Console.WriteLine(enumProductAsk.GetDescription());


    }
}