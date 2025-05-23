using System.Text.RegularExpressions;

public class Exo04 : Exo
{
    /// <summary>
    /// byte.
    /// </summary>
    /// <param name="parameters">list string of parameters need to execute exo.</param>
    override public void Execute(List<string> parameters)
    {
        // generate a random seed for RNG.
        Random rand = new Random(DateTime.Now.Millisecond);

        // generate a random string of True/False.
        string txt = "";
        for (int i = 0; i < 8; i++)
        {
            if (txt != "")
                txt += ", ";

            bool isRngTrue = rand.Next(2) == 1;
            txt += isRngTrue.ToString();
        }
        Console.WriteLine($"txt: [{txt}]");

        // cast (only for print alternative).
        string txt2 = new string(txt.Split(", ").Select(b => (b == true.ToString()) ? '1' : '0').ToArray());
        Console.WriteLine($"txt2: [{txt2}]");

        // set byte.
        Console.WriteLine("--- printing byte ---");
        byte myByte = 0;
        bool[] arrayBool = txt.Split(", ").Select(b => b == true.ToString()).ToArray();
        for (int i = 0; i < arrayBool.Length; i++)
        {
            myByte <<= 1;
            if (arrayBool[i])
                myByte += 1;

            string valueByteTreeDigit = $"{((myByte<100)? "0": "")}{((myByte<10)? "0": "")}{myByte}";
            Console.WriteLine($"{i}. {this.castByteToStr(myByte)} -> ({valueByteTreeDigit})");
        }
        Console.WriteLine("---------------------");


    }


    /// <summary>
    /// cast a byte to a string containing 0 and 1.
    /// </summary>
    /// <param name="myByte">the byte to convert.</param>
    /// <returns>string containing 8 char of 0 or 1</returns>
    private string castByteToStr(byte myByte)
    {
        string output = "";
        for (int i = 7; i >= 0; i--)
        {
            bool isTrue = (myByte >> i) %2 == 1;
            output += isTrue? "1": "0";
        }
        return output;
    }
}

