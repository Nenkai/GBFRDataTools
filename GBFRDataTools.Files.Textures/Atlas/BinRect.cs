using System;

namespace GBFRDataTools.Files.Textures.Atlas;

public struct BinRect : IEquatable<BinRect>
{
    public int x;
    public int y;
    public int width;
    public int height;

    public override bool Equals(object obj)
    {
        return obj is BinRect && Equals((BinRect)obj);
    }

    public bool Equals(BinRect other)
    {
        return x == other.x &&
               y == other.y &&
               width == other.width &&
               height == other.height;
    }

    public override int GetHashCode()
    {
        var hashCode = -1222528132;
        hashCode = hashCode * -1521134295 + x.GetHashCode();
        hashCode = hashCode * -1521134295 + y.GetHashCode();
        hashCode = hashCode * -1521134295 + width.GetHashCode();
        hashCode = hashCode * -1521134295 + height.GetHashCode();
        return hashCode;
    }

    public static bool operator ==(BinRect rect1, BinRect rect2)
    {
        return rect1.Equals(rect2);
    }

    public static bool operator !=(BinRect rect1, BinRect rect2)
    {
        return !(rect1 == rect2);
    }
};