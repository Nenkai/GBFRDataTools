using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Misc;

public class SigilDescDumper
{
    public static void Run()
    {
        string pathToTextMsg = @"data\system\table\text\en\text.msg";

        var textData = TextDataFile.Read(File.ReadAllBytes(pathToTextMsg), isMessagePackFile: true);
        var geen = textData.Rows.Where(e => e.Id_hash.Contains("SKILL") && !e.Text.Contains("Dummy")).ToArray();

        foreach (var gen in geen)
        {
            if (gen.Id_hash.Contains("_SUMMARY_"))
                continue;

            if (string.IsNullOrEmpty(gen.Text))
                continue;

            var i = gen.Id_hash.Replace("TXT_SKILL", "TXT_SKILL_SUMMARY");
            var desc = geen.FirstOrDefault(e => e.Id_hash == i);
            if (desc != null)
            {
                Console.WriteLine($"{gen.Text}: {desc.Text.ReplaceLineEndings(" ")}");
            }
            else
                ;

        }
    }
}
