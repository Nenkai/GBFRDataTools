using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GBFRDataTools.Hashing;

namespace GBFRDataTools.Misc;

// Used to cleanup filelist.txt from gbfrelink.utility.filenamelogger.
public class XXHash64HashListCleanup
{
    public static void Cleanup(string path)
    {
        Dictionary<ulong, string> lines = [];

        using (var sr = File.OpenText(path))
        {
            while (!sr.EndOfStream)
            {
                var line = sr.ReadLine();
                string[] spl = line.Split('|');

                string source = spl.Length == 1 ? "" : spl[1];
                string inputStr = spl.Length == 2 ? spl[1] : spl[0];

                if (string.IsNullOrWhiteSpace(inputStr) || inputStr.Any(e => !char.IsAsciiLetterOrDigit(e) &&
                    e != '_' && e != '/' && e != '\\' && e != '-' && e != '-' && e != '.' && e != '(' && e != ')' && e != ':'))
                {
                    continue;
                }

                byte[] hashStr = XXHash64.HashString(inputStr, 0);
                lines.TryAdd(BinaryPrimitives.ReadUInt64LittleEndian(hashStr), inputStr);
            }
        }

        using var sw = new StreamWriter(path);
        foreach (var line in lines)
        {
            sw.WriteLine($"{line.Key:X16}|{line.Value}");
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
