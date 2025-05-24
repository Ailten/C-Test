
using System.Diagnostics.Contracts;

public enum EnumType
{
    Byte,
    Sbyte,
    Short,
    Ushort,
    Int,
    Uint,

    Long,
    Ulong,

    Float,
    Double,
    Decimal,

    Char,
    String
}


public static class EnumTypeMethode
{
    static public Type ToType(this EnumType enumType)
    {
        switch (enumType)
        {
            case (EnumType.Byte):
                return typeof(byte);
            case (EnumType.Sbyte):
                return typeof(sbyte);
            case (EnumType.Short):
                return typeof(short);
            case (EnumType.Ushort):
                return typeof(ushort);
            case (EnumType.Int):
                return typeof(int);
            case (EnumType.Uint):
                return typeof(uint);

            case (EnumType.Long):
                return typeof(long);
            case (EnumType.Ulong):
                return typeof(ulong);

            case (EnumType.Float):
                return typeof(float);
            case (EnumType.Double):
                return typeof(double);
            case (EnumType.Decimal):
                return typeof(decimal);

            case (EnumType.Char):
                return typeof(char);
            case (EnumType.String):
                return typeof(string);

            default:
                throw new ElementNotFound();
        }
    }

    static public EnumType StringToEnumType(this EnumType enumType, string strEnumType)
    {
        switch (strEnumType)
        {
            case ("byte"):
                return EnumType.Byte;
            case ("sbyte"):
                return EnumType.Sbyte;
            case ("short"):
                return EnumType.Short;
            case ("ushort"):
                return EnumType.Ushort;
            case ("int"):
                return EnumType.Int;
            case ("uint"):
                return EnumType.Uint;

            case ("long"):
                return EnumType.Long;
            case ("ulong"):
                return EnumType.Ulong;

            case ("float"):
                return EnumType.Float;
            case ("double"):
                return EnumType.Double;
            case ("decimal"):
                return EnumType.Decimal;

            case ("char"):
                return EnumType.Char;
            case ("string"):
                return EnumType.String;

            default:
                throw new ElementNotFound();
        }
    }

    static public Object CastStringToObject(this EnumType enumType, string valueString)
    {
        switch (enumType)
        {
            case (EnumType.Byte):
                return byte.Parse(valueString);
            case (EnumType.Sbyte):
                return sbyte.Parse(valueString);
            case (EnumType.Short):
                return short.Parse(valueString);
            case (EnumType.Ushort):
                return ushort.Parse(valueString);
            case (EnumType.Int):
                return int.Parse(valueString);
            case (EnumType.Uint):
                return uint.Parse(valueString);

            case (EnumType.Long):
                return long.Parse(valueString);
            case (EnumType.Ulong):
                return ulong.Parse(valueString);

            case (EnumType.Float):
                return float.Parse(valueString);
            case (EnumType.Double):
                return double.Parse(valueString);
            case (EnumType.Decimal):
                return decimal.Parse(valueString);

            case (EnumType.Char):
                return char.Parse(valueString);
            case (EnumType.String):
                return valueString;

            default:
                throw new ElementNotFound();
        }
    }
}