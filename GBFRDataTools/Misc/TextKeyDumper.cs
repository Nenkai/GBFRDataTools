using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Misc;

public class TextKeyDumper
{
    public static void Dump(string file)
    {
        var doc = System.Text.Json.JsonDocument.Parse(File.ReadAllText(file));
        foreach (var row in doc.RootElement.GetProperty("rows_").EnumerateArray())
        {
            var col = row.GetProperty("column_");
            var id = col.GetProperty("id_hash_").GetString().Substring("TXT_".Length); // Ignore TXT_
            var value = col.GetProperty("text_").GetString();

            Console.WriteLine($"{id},{value},{XXHash32Custom.Hash(id):X8}");
        }
    }
}
