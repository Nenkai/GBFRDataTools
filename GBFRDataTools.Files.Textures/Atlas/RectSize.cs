using System;

namespace GBFRDataTools.Files.Textures.Atlas;

public struct RectSize : IEquatable<RectSize>
{
    public int width;
    public int height;

    public override bool Equals(object obj)
    {
        return obj is RectSize && Equals((RectSize)obj);
    }

    public bool Equals(RectSize other)
    {
        return width == other.width &&
               height == other.height;
    }

    public override int GetHashCode()
    {
        var hashCode = 1263118649;
        hashCode = hashCode * -1521134295 + width.GetHashCode();
        hashCode = hashCode * -1521134295 + height.GetHashCode();
        return hashCode;
    }

    public static bool operator ==(RectSize size1, RectSize size2)
    {
        return size1.Equals(size2);
    }

    public static bool operator !=(RectSize size1, RectSize size2)
    {
        return !(size1 == size2);
    }
};