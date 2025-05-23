
public static class ExoManager
{
    /// <summary>
    /// array of all exo instance.
    /// </summary>
    private static Exo[] Exos = new Exo[]
    {
        new Exo01(), //console write.
        new Exo02(), //varaibles.
        new Exo03(), //read file.
        new Exo04(), //byte.
        new Exo05(), //regex.
        new Exo06(), //enum.
        new Exo07()  //obj.

        //https://www.w3schools.com/cs/cs_files.php

        //geter seter.
        //dictionary.
        //json. (write/read file, and create obj json on code)
        //try, catch, finaly. (many catch and exception class creation)
        //surcharge operator.
        //delegate and action.
        //thread.
    };


    /// <summary>
    /// browse on every exo and execute the one who match by instance name.
    /// </summary>
    /// <param name="nameExo">the name of instance searched.</param>
    /// <param name="parameters">list string of args rest.</param>
    public static void ExecuteAnExo(string nameExo, List<string> parameters)
    {
        // loop on every exos.
        foreach (var exo in Exos)
        {
            // skip exo when class instance was not matching.
            if (exo.InstanceName != nameExo)
                continue;

            // execute the one was found.
            exo.Execute(parameters);
            return;
        }

        // when nothing found on exos.
        throw new ElementNotFound();
    }

}