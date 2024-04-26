using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Hashing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace GBFRDataTools.Hashing;

/// <summary>
/// Utility class for XXHash64 hashing.
/// </summary>
public class XXHash64
{
    /// <summary>
    /// XXHash64 a string using the specified seed.
    /// </summary>
    /// <param name="str"></param>
    /// <param name="seed"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte[] HashString(string str, long seed)
    {
        return XxHash64.Hash(Encoding.ASCII.GetBytes(str), seed);
    }

    /// <summary>
    /// XXHash64 a buffer using the specified seed.
    /// </summary>
    /// <param name="data"></param>
    /// <param name="seed"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ulong Hash(Span<byte> data, long seed)
    {
        return XxHash64.HashToUInt64(data, seed);
    }
}
