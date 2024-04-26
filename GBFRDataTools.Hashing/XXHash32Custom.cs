using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Buffers.Binary;

namespace GBFRDataTools.Hashing;

/// <summary>
/// Utility class for custom XXHash32 hashing.
/// </summary>
public class XXHash32Custom
{
    private const uint PRIME32_1 = 0x9e3779b1;
    private const uint PRIME32_2 = 0x85EBCA77;
    private const uint PRIME32_3 = 0xC2B2AE3D;
    private const uint PRIME32_4 = 0x27D4EB2F;
    private const uint PRIME32_5 = 0x165667B1;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static uint XXH32_rotl(uint x, int r) => x << r | x >> 32 - r;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static uint XXH32_round(uint seed, uint input) =>
        XXH32_rotl(seed + input * PRIME32_2, 13) * PRIME32_1;

    /// <summary>
    /// XXHash32 a string.
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static uint Hash(string str)
    {
        Span<byte> strBytes = stackalloc byte[Encoding.ASCII.GetByteCount(str)];
        Encoding.ASCII.GetBytes(str, strBytes);
        return Hash(strBytes);
    }

    /// <summary>
    /// XXHash32 a buffer.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public static uint Hash(Span<byte> input)
    {
        var p = input;
        uint h32 = 0x178A54A4; // This is different

        if (input.Length >= 16)
        {
            /* Orig
            var v1 = h32 + PRIME32_1 + PRIME32_2;
            var v2 = h32 + PRIME32_2;
            var v3 = h32 + 0;
            var v4 = h32 - PRIME32_1;
            */

            // No idea how these are calculated but this is also different
            var v1 = 0x2557311Bu;
            var v2 = 0x871FB76Au;
            var v3 = 0x0133ECF3u;
            var v4 = 0x62FC7342u;

            do
            {
                v1 = XXH32_round(v1, BinaryPrimitives.ReadUInt32LittleEndian(p[0..]));
                v2 = XXH32_round(v2, BinaryPrimitives.ReadUInt32LittleEndian(p[4..]));
                v3 = XXH32_round(v3, BinaryPrimitives.ReadUInt32LittleEndian(p[8..]));
                v4 = XXH32_round(v4, BinaryPrimitives.ReadUInt32LittleEndian(p[12..]));

                p = p[0x10..];
            }
            while (p.Length > 16);

            h32 = XXH32_rotl(v1, 1)
                + XXH32_rotl(v2, 7)
                + XXH32_rotl(v3, 12)
                + XXH32_rotl(v4, 18);
        }

        h32 += (uint)input.Length;

        while (p.Length >= 4)
        {
            h32 = XXH32_rotl(h32 + BinaryPrimitives.ReadUInt32LittleEndian(p) * PRIME32_3, 17) * PRIME32_4;
            p = p[4..];
        }

        while (p.Length > 0)
        {
            h32 = XXH32_rotl(h32 + p[0] * PRIME32_5, 11) * PRIME32_1;
            p = p[1..];
        }

        h32 ^= h32 >> 15;
        h32 *= PRIME32_2;
        h32 ^= h32 >> 13;
        h32 *= PRIME32_3;
        h32 ^= h32 >> 16;

        return h32;
    }
}
