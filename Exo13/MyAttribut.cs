
/// <summary>
/// making a custom attribute.
/// </summary>
public class MyAttribut : Attribute
{
    private string nameWhoDevIt { get; }

    public MyAttribut(string name)
    {
        this.nameWhoDevIt = name;
    }

}