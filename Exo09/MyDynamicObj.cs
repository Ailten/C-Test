using System.Dynamic;
public class MyDynamicObj : DynamicObject // an object can herit from dynamicObject for apply less verify from compilor.
{
    /// <summary>
    /// call when try to axess a member of object.
    /// </summary>
    /// <param name="binder">object for the access member.</param>
    /// <param name="result">result if the access member is valid (or not).</param>
    /// <returns>true if the access is valid.</returns>
    public override bool TryGetMember(GetMemberBinder binder, out object? result)
    {
        result = binder.Name; // place the name of member call on the result return.
        return true; // yes it's working to access this member.
    }
}