
public class Exo02 : Exo
{
    /// <summary>
    /// variable type and values.
    /// </summary>
    /// <param name="parameters">list string of parameters need to execute exo.</param>
    override public void Execute(List<string> parameters)
    {
        // integer.

        //byte myByte = 0; // 0 to 255 (8bit)
        //sbyte mySbyte = 0; // -127 to 127

        //short myShort = 0; // -32,768 to 32,767 (16bit)
        //ushort myUshort = 0; // 0 to 65,535

        //int myInt = 0; // -2.14*10⁹ to 2.14*10⁹ (32bit)
        //uint myUint = 0; // 0 to 4.29*10⁹

        //long myLong = 0; // -9.22*10^18 to 9.22*10^18 (64bit)
        //ulong myUlong = 0; // 0 to 18.44*10^18


        // flaot.

        //float myFloat = 0.0f; // 1.5*10^-45 to 3.4*10^38 (4 bytes) (6-9 digits) !! not full precise !!
        //double myDouble = 0.0; // 5.0*10^-324 to 1.7*10^308 (8 bytes) (15-17 digits) !! not full precise !!
        //decimal myDecimal = 0.0m; // 1.0*10^-28 to 7.922*10^28 (16 bytes) (28-29 digits)


        // string.

        //char myChar = 'a'; // stock a single character (ascii 0-255).
        //string myString = "abc"; // stock a chaine of character.


        // bool.
        //bool myBool = true; // stock a value true or false.


        // nullable.
        //int? myIntNullable = null; // add ? after type for make a variable nullable.


        // constante.
        //const int myIntConst = 5; // constante.


        // var.
        //var myInt = 5; // take type of what set on it.



        Console.WriteLine($"byte in an int : {sizeof(int)}");
        Console.WriteLine($"min value of an int : {int.MinValue}");
        Console.WriteLine($"max value of an int : {int.MaxValue}");

        int myInt = 65;
        Console.WriteLine($"type of int : {myInt.GetType()}");
        Console.WriteLine($"cast int 65 to double : {(double)myInt}"); //cast.
        Console.WriteLine($"cast int 65 to string : {myInt.ToString()}");
        Console.WriteLine($"cast int 65 to char ascii : {(char)myInt}");
    }
}