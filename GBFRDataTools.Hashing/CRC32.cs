using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Hashing;

/// <summary>
/// Utility class for CRC32 hashing.
/// </summary>
public static class CRC32
{
    private const uint _poly1 = 0xedb88320;
    public static uint[] checksum_0x77073096 = new uint[256];

    static CRC32()
    {
        uint fwd, rev;
        for (uint i = 0; i < checksum_0x77073096.Length; i++)
        {
            fwd = i;
            for (int j = 8; j > 0; j--)
            {
                if ((fwd & 1) == 1)
                    fwd = ((fwd >> 1) ^ _poly1);
                else
                    fwd >>= 1;
            }
            checksum_0x77073096[i] = fwd;
        }
    }

    public static uint crc32_0x77073096(string str, bool toLower = true)
    {
        uint checksum = 0xFFFFFFFF;

        for (int i = 0; i < str.Length; i++)
        {
            if (toLower)
                checksum = checksum_0x77073096[(byte)(checksum ^ (byte)char.ToLower(str[i]))] ^ (checksum >> 8);
            else
                checksum = checksum_0x77073096[(byte)(checksum ^ str[i])] ^ (checksum >> 8);
        }

        return ~checksum;
    }
}