using GBFRDataTools.Database.Entities;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Database;

/// <summary>
/// Represents a GBFR game database folder.
/// </summary>
public class GameDatabase
{
    /// <summary>
    /// All tables in the database.
    /// </summary>
    public Dictionary<string, DataTable> Tables = [];

    /// <summary>
    /// Loads tables (.tbl) files from the specified folder.
    /// </summary>
    /// <param name="dir"></param>
    /// <param name="version"></param>
    public void Load(string dir, Version version)
    {
        string exePath = Utils.GetCurrentExecutingPath();

        string currentDir = Path.GetDirectoryName(exePath)!;
        string path = Path.Combine(currentDir, "Data", "ids.txt");

        if (!File.Exists(path))
            throw new FileNotFoundException("ERROR: Data/ids.txt was missing.");

        var idDatabase = new IdDatabase();
        idDatabase.Open(path);

        string idPath = Path.Combine(dir, "ids.txt");
        if (File.Exists(idPath))
            idDatabase.Open(idPath);

        foreach (string tableFile in Directory.GetFiles(dir, "*.tbl"))
        {
            var tableName = Path.GetFileNameWithoutExtension(tableFile);
            if (!DynamicTableMappingReader.Instance.ContainsTable(tableName))
            {
                Console.WriteLine($"WARNING: Skipping {tableName}, no layout exists");
                continue;
            }

            try
            {
                DataTable dt = new DataTable();
                dt.Read(tableFile, version, idDatabase);

                Tables.Add(tableName, dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: Failed to read table {tableName} - {ex.Message}");
            }
        }

#if DEBUG
        Directory.CreateDirectory("debug");
        File.WriteAllLines("debug/table_ids.txt", TableRow.KnownHashes.Select(e => $"{e.Key:X8}|ID|{e.Value}"));
#endif
    }

    /// <summary>
    /// Saves tables (.tbl) to the specified folder.
    /// </summary>
    /// <param name="dir"></param>
    /// <param name="tables">Tables to convert, if left null, all.</param>
    public void SaveTo(string dir, IEnumerable<string>? tables = null)
    {
        Directory.CreateDirectory(dir);

        foreach (var table in Tables)
        {
            if (tables is not null && tables?.Contains(table.Key) == false)
                continue;

            table.Value.Save(Path.Combine(dir, $"{table.Key}.tbl"));
        }
    }
}
