
/// <summary>
/// Class parent of all Exo.
/// </summary>
public class Exo
{

    public string InstanceName
    {
        get { return this.GetType().ToString(); }
    }

    /// <summary>
    /// function call to execute an exo.
    /// </summary>
    /// <param name="parameters">list string of parameters need to execute exo.</param>
    virtual public void Execute(List<string> parameters)
    {
        throw new NotOverided();
    }
}