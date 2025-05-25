
using System.Reflection.Metadata;


/// <summary>
/// class for cast from a type generic. using type generique.
/// </summary>
/// <typeparam name="T">type to cast</typeparam>
public class SpecialCaster<T> // where T : struct // generic can have contrainte.
{
    public T cast(object obj)
    {
        if (typeof(T) == typeof(string))
        {
            return (T)(object)(obj.ToString() ?? "");
        }
        return (T)obj;
    }
}