namespace CSharpUtils;

public static class ExtensionsObject
{
    /// <summary>
    /// Returns true if the <paramref name="object"/> is a numeric type
    /// <para>For .NET 6.0 and later, consider using the INumber interface for a more generic approach.</para>
    /// </summary>
    public static bool IsNumericType(this object @object)
    {
        if (@object == null)
        {
            return false;
        }

        Type type = @object.GetType();
        HashSet<Type> numericTypes =
        [
            typeof(int),
            typeof(float),
            typeof(double),
            typeof(long),
            typeof(short),
            typeof(ushort),
            typeof(uint),
            typeof(ulong),
            typeof(decimal),
            typeof(byte),
            typeof(sbyte)
        ];

        return numericTypes.Contains(type);
    }
}
