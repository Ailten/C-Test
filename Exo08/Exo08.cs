using System.IO;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;

public class Exo08 : Exo
{
    /// <summary>
    /// type and dictionary.
    /// </summary>
    /// <param name="parameters">list string of parameters need to execute exo.</param>
    override public void Execute(List<string> parameters)
    {
        // loop on prompt.
        Console.WriteLine("Entre [type parameter:value] (ex: int name Thomas)");
        Console.WriteLine("type stop for end");
        Dictionary<string, KeyValuePair<Type, object>> dicoData = new();
        bool isEndPrompt = false;
        do
        {
            string prompt = Console.ReadLine() ?? "";

            if (prompt == "stop")
                isEndPrompt = true;
            else
            {
                // split data from prompt.
                string typeAttribute = new Regex("^[a-zA-Z]{1,}").Match(prompt).Value;
                string nameAttribute = new Regex("[ ][a-zA-Z]{1,}[ ]").Match(prompt).Value;
                nameAttribute = nameAttribute.Substring(1, nameAttribute.Length - 1);
                string valueAttribute = new Regex("[a-zA-Z0-9.-]{1,}$").Match(prompt).Value;

                EnumType enumTypeAttr = EnumType.String.StringToEnumType(typeAttribute);
                Type typeAttr = enumTypeAttr.ToType();
                object valueAttr = enumTypeAttr.CastStringToObject(valueAttribute);

                KeyValuePair<Type, object> typeAndValue = new(typeAttr, valueAttr);
                dicoData.Add(nameAttribute, typeAndValue);

            }

        } while (!isEndPrompt);

        // print.
        Console.WriteLine("--- data ---");
        dicoData.ToList().ForEach(nameAndKV =>
        {
            string nameAttr = nameAndKV.Key;
            Type typeAttr = nameAndKV.Value.Key;
            object valueAttr = nameAndKV.Value.Value;

            Console.WriteLine($"{nameAttr} is a type {typeAttr} and containe {valueAttr}");
        });
        Console.WriteLine("------------");


    }
}