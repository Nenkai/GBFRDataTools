using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Text;

namespace GBFRDataTools.Misc;

internal class BruteforceShaderParamName
{
    public static void Start(string wordListFilePath)
    {
        var list = new List<uint>
        {
            0x037BE4E5,
            0x0A05A26F,
            0x11664BFC,
            0x2AEDA6AD,
            0x2B5C866C,
            0x372C03F0,
            0x4298F7E4,
            0x53F49792,
            0x56346692,
            0x92339519,
            0x93D9F63A,
            0x9C83F56F,
            0xA6EB1B34,
            0xAB261CFA,
            0xAC6F995D,
            0xB0EA41D9,
            0xBAEF6920,
            0xC5BD3DED,
            0xC9762248,
            0xE56343C0,
            0xEB6F1AE7,
        };

        using var fs = File.OpenText(wordListFilePath);
        while (!fs.EndOfStream)
        {
            string line = fs.ReadLine();
            if (line.Length < 2)
                continue;

            var hashcode = new HashCode();

            string s = char.ToUpper(line[0]) + line.Substring(1);
            if (list.Contains(XXHash32Custom.Hash($"g_Enable{s}Mask")))
            {
                Console.WriteLine($"Found: {line}");
            }

            if (list.Contains(XXHash32Custom.Hash($"g_{s}")))
            {
                Console.WriteLine($"Found: {line}");
            }

            if (list.Contains(XXHash32Custom.Hash($"g_Use{s}")))
            {
                Console.WriteLine($"Found: {line}");
            }

            if (list.Contains(XXHash32Custom.Hash($"g_IsUse{s}")))
            {
                Console.WriteLine($"Found: {line}");
            }

            if (list.Contains(XXHash32Custom.Hash($"g_{s}Use")))
            {
                Console.WriteLine($"Found: {line}");
            }

            if (list.Contains(XXHash32Custom.Hash($"g_Enable{s}")))
            {
                Console.WriteLine($"Found: {line}");
            }

        }

    }
}
