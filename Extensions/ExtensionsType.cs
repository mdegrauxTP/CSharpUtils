namespace CSharpUtils;

public static class ExtensionsType
{
    /// <summary>
    /// Returns true if the <paramref name="type"/> is a whole number.
    /// </summary>
    public static bool IsWholeNumber(this Type type)
    {
        return
            type == typeof(int) ||
            type == typeof(long) ||
            type == typeof(short) ||
            type == typeof(byte) ||
            type == typeof(sbyte) ||
            type == typeof(uint) ||
            type == typeof(ulong) ||
            type == typeof(ushort);
    }
}
