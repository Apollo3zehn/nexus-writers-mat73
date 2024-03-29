﻿namespace Nexus.Writers;

public static class Mat73Utilities
{
    public static int[] ToCodePoints(this string value)
    {
        List<int> codePoints;

        ArgumentNullException.ThrowIfNull(value);

        codePoints = new List<int>(value.Length);

        for (int i = 0; i < value.Length; i++)
        {
            codePoints.Add(Char.ConvertToUtf32(value, i));

            if (Char.IsHighSurrogate(value[i]))
            {
                i += 1;
            }
        }

        return [.. codePoints];
    }
}
