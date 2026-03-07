using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Quest;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Misc;

public class QuestNameDumper
{
    public static void Dump(string systemTableTextDirPath)
    {
        foreach (var localeDir in Directory.GetDirectories(systemTableTextDirPath))
        {
            string locale = Path.GetFileName(localeDir);
            var textStage = TextDataFile.Read(File.ReadAllBytes(Path.Combine(localeDir, "text_stage.msg")), isMessagePackFile: true);

            Console.WriteLine($"// {locale}");
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            foreach (var row in textStage.Rows)
            {
                if (!row.Id_hash.Contains("_QR_"))
                    continue;

                uint questId = uint.Parse(row.Id_hash.Split('_')[2], NumberStyles.HexNumber, null);
                Console.WriteLine($"{questId:X6},\"{row.Text}\"");
            }

            Console.WriteLine();
        }
    }
}
