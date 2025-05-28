
using System.Threading.Tasks;

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
        new Exo07(), //obj. (eritage, override, interface, multi constructor, struct)
        new Exo08(), //type generic and dictionary.
        new Exo09(), //obj2. (surcharge cast and operator, type generique, getter/setter, dynamicObject)
        new Exo10(), //json.
        new Exo11(), //try catch.
        new Exo12(), //pile and tas.
        new Exo13(), //attribut.
        new Exo14(), //function. (Action, Func, Delegate) ( + namespace)
        new Exo15(), //yield
        new Exo16(), //string builder.
        new Exo17(), //string.
        new Exo18(), //date.
        new Exo19(), //entityFrameWork.
        new Exo20(), //debug mode.
        new Exo21(), //task, async and http call.
        new Exo22(), //conection DB.
        new Exo23(), //xml.
        new Exo24(), //list.
        new Exo25(), //thread.
        new Exo26(), //lock.
        new Exo27(), //goto.
        new Exo28(), //event.
        new Exo29()  //test unitaire.
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