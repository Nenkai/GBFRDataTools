using CsvHelper;

using GBFRDataTools.SaveData;
using GBFRDataTools.FlatBuffers;
using System.Globalization;

namespace GBFRQuestClearChecker;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"GBFRQuestClearChecker by Nenkai");
        string gbfrFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "GBFR", "Saved", "SaveGames");
        if (!Directory.Exists(gbfrFolder))
        {
            Console.WriteLine($"ERROR: Folder '{gbfrFolder}' does not exist.");
            return;
        }

        int saveIndex = 0;

        while (saveIndex == 0)
        {
            Console.WriteLine("Select Save (press a key):");
            for (int i = 1; i <= 3; i++)
            {
                if (File.Exists(Path.Combine(gbfrFolder, $"SaveData{i}.dat")))
                {
                    Console.WriteLine($"{i} => Save File {i}");
                }
            }

            Console.Write(">> ");
            saveIndex = Console.ReadKey().Key switch
            {
                ConsoleKey.NumPad1 => 1,
                ConsoleKey.D1 => 1,
                ConsoleKey.NumPad2 => 2,
                ConsoleKey.D2 => 1,
                ConsoleKey.NumPad3 => 3,
                ConsoleKey.D3 => 1,
                _ => 0,
            };
            Console.WriteLine();
        }


        
        var save = SaveGameFile.FromFile(Path.Combine(gbfrFolder, $"SaveData{saveIndex}.dat"));
        var questIdUnits = save.GetSlotUnitByType(UnitType.QUESTSYSTEM_QUEST_IDS) as UIntSaveDataUnit;
        var completeCounts = save.GetSlotUnitByType(UnitType.QUESTSYSTEM_QUEST_COMPLETECOUNT) as UIntSaveDataUnit;

        Dictionary<uint, string> _questIdToName = [];
        using (var reader = new StreamReader("csv_data/quest_id.csv"))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            // Skip first
            csv.Read();

            while (csv.Read())
            {
                if (uint.TryParse(csv.GetField(0), out uint questId))
                    _questIdToName.Add(questId, csv.GetField(1));
            }
        }

        Dictionary<uint, uint> str = new();
        uint total = 0;
        for (int i = 0; i < 512; i++)
        {
            uint questId = questIdUnits.ValueData[i];
            uint count = completeCounts.ValueData[i];

            str.TryAdd(questId, count);
            total += count;
        }

        Console.WriteLine("---------------------------");
        Console.WriteLine($"Total Quest Clears: {total}");
        Console.WriteLine("---------------------------");
        foreach (var s in str.OrderByDescending(e => e.Value))
        {
            var dec = uint.Parse(s.Key.ToString("X6"));
            string questName = _questIdToName.ContainsKey(dec) ? _questIdToName[dec] : $"Unknown Quest {dec}";

            if (s.Value != 0)
                Console.WriteLine($"{questName} - {s.Value} ({(float)s.Value / total * 100:0.00}%)");
            else
                Console.WriteLine($"{questName} - No Clears");
        }

        Console.WriteLine("---------------------------");
        Console.WriteLine("Press a key to exit...");
        Console.ReadLine();
    }
}
