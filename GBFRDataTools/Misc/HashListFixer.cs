using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GBFRDataTools.Hashing;

namespace GBFRDataTools.Misc;

class HashListFixer
{
    // Trims many fields ending with underscore & starting with lowercase
    // 'obj_' -> 'Obj'
    // Useful for UI property definitions
    public static void Fix()
    {
        using var sw = new StreamWriter("new_hash_list.txt");
        var t = File.ReadAllLines(@"hashlist.txt");

        Dictionary<uint, (string, string)> lines = [];
        foreach (var line in t)
        {
            string[] spl = line.Split('|');
            if (spl[0].Length != 8)
                continue;

            string source = spl.Length == 2 ? "" : spl[1];
            string inputStr = spl.Length == 2 ? spl[1] : spl[2];

            lines.TryAdd(uint.Parse(spl[0], System.Globalization.NumberStyles.HexNumber), (source, inputStr));

            if (inputStr.EndsWith('_') && char.IsAsciiLetterLower(inputStr[0]))
            {
                string str = inputStr.TrimEnd('_');
                str = FirstCharToUpper(str);
                lines.TryAdd(XXHash32Custom.Hash(str), (source, str));
            }
        }

        foreach (var line in lines)
        {
            sw.WriteLine($"0x{line.Key:X8}|{line.Value.Item1}|{line.Value.Item2}");
        }

    }

    public static string FirstCharToUpper(string input) =>
        input switch
        {
            null => throw new ArgumentNullException(nameof(input)),
            "" => throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input)),
            _ => string.Concat(input[0].ToString().ToUpper(), input.AsSpan(1))
        };

}
