using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GBFRDataTools.Files.Textures.Atlas;

public struct PackerBitmap : IEquatable<PackerBitmap>, IComparable<PackerBitmap>
{
    public int Width;
    public int Height;
    public string Name;
    public int FrameX;
    public int FrameY;
    public int FrameW;
    public int FrameH;
    public Image<Rgba32> Data;

    public unsafe PackerBitmap(Image<Rgba32> image, string name, bool premultiply, bool trim)
    {
        Name = name;
        Width = (int)image.Width;
        Height = (int)image.Height;
        Data = image;
        FrameX = 0;
        FrameY = 0;
        FrameW = 0;
        FrameH = 0;

        //Premultiply all the pixels by their alpha
        if (premultiply)
        {
            int count = (int)image.Width * (int)image.Height;
            for (int y = 0; y < image.Height; ++y)
            {
                for (int x = 0; x < image.Width; ++x)
                {
                    uint c = image[x, y].Rgba;
                    uint a = c >> 24;
                    float m = (a) / 255.0f;
                    uint r = (uint)((float)(c & 0xff) * m);
                    uint g = (uint)((float)((c >> 8) & 0xff) * m);
                    uint b = (uint)((float)((c >> 16) & 0xff) * m);
                    image[x, y] = new Rgba32((a << 24) | (b << 16) | (g << 8) | r);
                }
            }
        }

        //TODO: skip if all corners contain opaque pixels?

        //Get pixel bounds
        int minX = (int)image.Width - 1;
        int minY = (int)image.Height - 1;
        int maxX = 0;
        int maxY = 0;
        if (trim)
        {
            for (int y = 0; y < image.Height; ++y)
            {
                for (int x = 0; x < image.Width; ++x)
                {
                    uint p = image[x, y].Rgba;
                    if ((p >> 24) > 0)
                    {
                        minX = Math.Min(x, minX);
                        minY = Math.Min(y, minY);
                        maxX = Math.Max(x, maxX);
                        maxY = Math.Max(y, maxY);
                    }
                }
            }
            if (maxX < minX || maxY < minY)
            {
                minX = 0;
                minY = 0;
                maxX = (int)image.Width - 1;
                maxY = (int)image.Height - 1;
                Console.WriteLine("image is completely transparent ");
            }
        }
        else
        {
            minX = 0;
            minY = 0;
            maxX = (int)image.Width - 1;
            maxY = (int)image.Height - 1;
        }

        //Calculate our trimmed size
        Width = (maxX - minX) + 1;
        Height = (maxY - minY) + 1;
        FrameW = (int)image.Width;
        FrameH = (int)image.Height;

        if (Width == image.Width && Height == image.Height)
        {
            //If we aren't trimmed, use the loaded image data
            FrameX = 0;
            FrameY = 0;
        }
        else
        {
            //Create the trimmed image data
            Data = new Image<Rgba32>(Width, Height);
            FrameX = -minX;
            FrameY = -minY;

            //Copy trimmed pixels over to the trimmed pixel array
            for (int y = minY; y <= maxY; ++y)
            {
                for (int x = minX; x <= maxX; ++x)
                {
                    Data[(x - minX), (y - minY)] = image[x, y];
                }
            }
        }
    }

    public PackerBitmap(int width, int height)
    {
        Name = "";
        Width = width;
        Height = height;
        FrameX = 0;
        FrameY = 0;
        FrameW = 0;
        FrameH = 0;
    }

    public override bool Equals(object obj)
    {
        return obj is PackerBitmap bitmap && Equals(bitmap);
    }

    public bool Equals(PackerBitmap other)
    {
        return Data == other.Data &&
               Width == other.Width &&
               Height == other.Height &&
               Name == other.Name &&
               FrameX == other.FrameX &&
               FrameY == other.FrameY &&
               FrameW == other.FrameW &&
               FrameH == other.FrameH;
    }

    public override int GetHashCode()
    {
        var hashCode = -84555632;
        hashCode = hashCode * -1521134295 + Data.GetHashCode();
        hashCode = hashCode * -1521134295 + Width.GetHashCode();
        hashCode = hashCode * -1521134295 + Height.GetHashCode();
        hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
        hashCode = hashCode * -1521134295 + FrameX.GetHashCode();
        hashCode = hashCode * -1521134295 + FrameY.GetHashCode();
        hashCode = hashCode * -1521134295 + FrameW.GetHashCode();
        hashCode = hashCode * -1521134295 + FrameH.GetHashCode();
        return hashCode;
    }

    public int CompareTo(PackerBitmap other)
    {
        var AreaX = (Width * Height);
        var AreaY = (other.Width * other.Height);
        if (AreaX < AreaY)
        {
            return 1;
        }
        if (AreaX > AreaY)
        {
            return -1;
        }
        return 0;
    }

    public static bool operator ==(PackerBitmap left, PackerBitmap right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(PackerBitmap left, PackerBitmap right)
    {
        return !(left == right);
    }
}