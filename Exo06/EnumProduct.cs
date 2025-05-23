
/// <summary>
/// enum of products.
/// </summary>
public enum EnumProduct
{
    Book = 0,
    Pen = 1,
    Papper = 2,
    Ink = 3

}

/// <summary>
/// class for adding methode to enum elements.
/// </summary>
public static class EnumProductMethode
{
    /// <summary>
    /// return a string of description custom.
    /// </summary>
    /// <param name="enumProduct">enumProduct from the one the methode is set.</param>
    /// <returns>description.</returns>
    public static string GetDescription(this EnumProduct enumProduct)
    {
        switch (enumProduct)
        {
            case (EnumProduct.Book):
                return "it's a red book.";
            case (EnumProduct.Pen):
                return "it's a pen, size of hand.";
            case (EnumProduct.Papper):
                return "it's a peace of papper, size A4.";
            case (EnumProduct.Ink):
                return "it's some ink, it's dark.";
            default:
                throw new ElementNotFound();
        }
    }
}