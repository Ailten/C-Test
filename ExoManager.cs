
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
        new Exo07(), //obj. (eritage, override, interface, multi constructor)
        new Exo08(), //type generic and dictionary.
        new Exo09(), //obj2. (surcharge cast and operator, type generique, getter/setter)
        new Exo10(), //json.
        new Exo11() //try catch.

        //read book about C# for search more idee to add.

        //delegate and action.
        //thread.
        //test unitaire.

        //make a json class who generate a json string modulable (add atribute) and restitue it (?).

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