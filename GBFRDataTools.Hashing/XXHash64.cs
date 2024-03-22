using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Hashing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace GBFRDataTools.Hashing;

public class XXHash64
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte[] HashString(string str, long seed)
    {
        return XxHash64.Hash(Encoding.ASCII.GetBytes(str), seed);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ulong Hash(Span<byte> data, long seed)
    {
        return XxHash64.HashToUInt64(data, seed);
    }
}
