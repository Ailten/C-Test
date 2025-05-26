

using System.Xml;

public class Exo23 : Exo
{
    /// <summary>
    /// xml.
    /// </summary>
    /// <param name="parameters">list string of parameters need to execute exo.</param>
    override public void Execute(List<string> parameters)
    {
        // open a file xml.
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load("Exo23/docXml.xml");

        // get an element by tag name (all biblio node).
        XmlNodeList nodes = xmlDoc.GetElementsByTagName("biblio");
        XmlNode biblio = nodes[0] ?? throw new NullElement();
        Console.WriteLine(" --- biblio --- ");
        Console.WriteLine(biblio.InnerXml);

        // get a book by matching name node child.
        XmlNode book = biblio.SelectSingleNode("descendant::shelf/book[name = \"Titanic\"]") ?? throw new NullElement();
        Console.WriteLine(" --- book (name) --- ");
        Console.WriteLine(book.InnerXml);

        // get a book by an attribute.
        book = biblio.SelectSingleNode("descendant::shelf/book[@id = \"0\"]") ?? throw new NullElement();
        Console.WriteLine(" --- book (id) --- ");
        Console.WriteLine(book.InnerXml);
    }
}