
public class Exo19 : Exo
{
    /// <summary>
    /// entity framework.
    /// </summary>
    /// <param name="parameters">list string of parameters need to execute exo.</param>
    override public void Execute(List<string> parameters)
    {
        /*/ --- commented because no DbContext. ---
        using (var ctx = new Context())
        {
            // set elements from DB on context (heer is hardcoded, because no DB).
            ctx.Movies.Add(new Movie("Avengers"));
            ctx.Movies.Add(new Movie("Scary movie"));
            ctx.Movies.Add(new Movie(""));

            // save changes on context.
            ctx.SaveChanges();
        }
        //*/
    }
}