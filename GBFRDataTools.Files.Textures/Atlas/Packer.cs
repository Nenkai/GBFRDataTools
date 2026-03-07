using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace GBFRDataTools.Files.Textures.Atlas;

public class Packer
{
    public int Width;
    public int Height;
    public int Pad;

    public List<PackerBitmap> Bitmaps { get; set; } = [];
    public List<Point> Points { get; set; } = [];
    Dictionary<int, int> DupLookup { get; set; } = [];

    public Packer(int width, int height, int pad)
    {
        Width = width;
        Height = height;
        Pad = pad;
    }

    public void Pack(List<PackerBitmap> bitmaps, bool verbose, bool unique, bool rotate)
    {
        var packer = new MaxRectsBinPack(Width, Height);
        int ww = 0;
        int hh = 0;
        while (bitmaps.Count > 0)
        {
            var bitmap = bitmaps[^1];

            if (verbose) Console.WriteLine($"     { bitmaps.Count - 1 }:  {bitmap.Name} ({bitmap.Width}x{bitmap.Height})");

            //Check to see if this is a duplicate of an already packed bitmap
            if (unique)
            {
                if (DupLookup.TryGetValue(bitmap.GetHashCode(),out var di))
                {
                    Point p = Points[di];
                    p.dupID = di;
                    Points.Add(p);
                    Bitmaps.Add(bitmap);
                    bitmaps.RemoveAt(bitmaps.Count - 1);
                    continue;
                }
            }

            //If it's not a duplicate, pack it into the atlas
            {
                BinRect rect = packer.Insert(bitmap.Width + Pad, bitmap.Height + Pad, rotate, MaxRectsBinPack.FreeRectChoiceHeuristic.RectBestShortSideFit);

                if (rect.width == 0 || rect.height == 0)
                    break;

                if (unique)
                {
                    DupLookup.Add(bitmap.GetHashCode(), Points.Count);
                }
                //Check if we rotated it
                Point p;
                p.x = rect.x;
                p.y = rect.y;
                p.dupID = -1;
                p.rot = rotate && (bitmap.Width != (rect.width - Pad));

                Points.Add(p);
                Bitmaps.Add(bitmap);
                bitmaps.RemoveAt(bitmaps.Count - 1);

                ww = Math.Max(rect.x + rect.width, ww);
                hh = Math.Max(rect.y + rect.height, hh);
            }
        }

        while (Width / 2 >= ww)
        {
            Width /= 2;
        }
        while (Height / 2 >= hh)
        {
            Height /= 2;
        }
    }

    
    public unsafe Image<Rgba32> GetTexture()
    {
        var output = new Image<Rgba32>(Width, Height);
        for (int i = 0; i < Bitmaps.Count; ++i)
        {
            var bitmap = Bitmaps[i];
            Image<Rgba32> src = bitmap.Data;
            if (Points[i].dupID < 0)
            {
                if (Points[i].rot)
                {
                    int r = bitmap.Height - 1;
                    for (int y = 0; y < bitmap.Width; ++y)
                    {
                        for (int x = 0; x < bitmap.Height; ++x)
                        {
                            output[(Points[i].x + x), (Points[i].y + y)] = src[(r - x), + y];
                        }
                    }
                }
                else
                {
                    for (int y = 0; y < bitmap.Height; ++y)
                    {
                        for (int x = 0; x < bitmap.Width; ++x)
                        {
                            output[(Points[i].x + x), (Points[i].y + y)] = src[x, y];
                        }
                    }
                }
            }
        }

        return output;
    }
}