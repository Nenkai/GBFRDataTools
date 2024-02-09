using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Utils
{
    public unsafe class XXHash32Custom
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

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public static uint Hash(byte* input, int len)
        {
            byte* p = input;

            var bEnd = p + len;
            uint h32 = 0x178A54A4; // This is different

            if (len >= 16)
            {
                var limit = bEnd - 16;

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
                    v1 = XXH32_round(v1, XXH_read32(p + 0));
                    v2 = XXH32_round(v2, XXH_read32(p + 4));
                    v3 = XXH32_round(v3, XXH_read32(p + 8));
                    v4 = XXH32_round(v4, XXH_read32(p + 12));

                    p += 16;
                }
                while (p <= limit);

                h32 = XXH32_rotl(v1, 1)
                    + XXH32_rotl(v2, 7)
                    + XXH32_rotl(v3, 12)
                    + XXH32_rotl(v4, 18);
            }

            h32 += (uint)len;

            while (p + 4 <= bEnd)
            {
                h32 = XXH32_rotl(h32 + XXH_read32(p) * PRIME32_3, 17) * PRIME32_4;
                p += 4;
            }

            while (p < bEnd)
            {
                h32 = XXH32_rotl(h32 + *p * PRIME32_5, 11) * PRIME32_1;
                p++;
            }

            h32 ^= h32 >> 15;
            h32 *= PRIME32_2;
            h32 ^= h32 >> 13;
            h32 *= PRIME32_3;
            h32 ^= h32 >> 16;


            return h32;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint XXH_read32(void* p) => *(uint*)p;
    }
}
