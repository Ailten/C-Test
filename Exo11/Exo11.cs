
public class Exo11 : Exo
{
    /// <summary>
    /// write in console.
    /// </summary>
    /// <param name="parameters">list string of parameters need to execute exo.</param>
    override public void Execute(List<string> parameters)
    {
        // get data.
        string param = (parameters.Count >= 1) ? parameters[0] : "";

        try
        {
            if (param == "")
                throw new MissingParameter();

            if (param == "error")
                throw new MyErrorCustom();

            if (param == "valid")
                Console.WriteLine("Process Success");
        }
        catch (MissingParameter exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }
        finally
        {
            Console.WriteLine("close everything.");
        }

    }
}