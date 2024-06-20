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
        foreach (string tableFile in Directory.GetFiles(dir, "*.tbl"))
        {
            string hdr = TableMappingReader.GetHeadersFile(Path.GetFileNameWithoutExtension(tableFile));
            if (string.IsNullOrEmpty(hdr))
                continue;

            DataTable dt = new DataTable();
            dt.Read(tableFile, version);

            Tables.Add(Path.GetFileNameWithoutExtension(tableFile), dt);
        }
    }

    /// <summary>
    /// Saves tables (.tbl) to the specified folder.
    /// </summary>
    /// <param name="dir"></param>
    public void SaveTo(string dir)
    {
        Directory.CreateDirectory(dir);

        foreach (var table in Tables)
        {
            table.Value.Save(Path.Combine(dir, $"{table.Key}.tbl"));
        }
    }
}
