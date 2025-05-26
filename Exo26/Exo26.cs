
public class Exo26 : Exo
{
    /// <summary>
    /// lock.
    /// </summary>
    /// <param name="parameters">list string of parameters need to execute exo.</param>
    override public void Execute(List<string> parameters)
    {

        object locker = new object();
        lock (locker) // make a block of code during execution the object is unacessible from other thread async.
        {

        }
        
    }
}