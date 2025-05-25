
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
        new Exo21() //Task, async and http call.
        //page 207, conection DB.

        //thread and event.
        //test unitaire.


        //make a json class who generate a json string modulable (add atribute) and restitue it (?). (maybe using dynamic obj)

        //page 56, making excel process.
        //page 91, generate code in code, (codeDom).
        //page 94, arbre d'expression. (function arbre ?)

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