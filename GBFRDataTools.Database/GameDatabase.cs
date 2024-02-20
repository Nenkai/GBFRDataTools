using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Database;

public class GameDatabase
{
    public Dictionary<string, DataTable> Tables = [];

    public void Load(string dir)
    {
        foreach (string tableFile in Directory.GetFiles(dir, "*.tbl"))
        {
            string hdr = TableMappingReader.GetHeadersFile(Path.GetFileNameWithoutExtension(tableFile));
            if (string.IsNullOrEmpty(hdr))
                continue;

            DataTable dt = new DataTable();
            dt.Read(tableFile);

            Tables.Add(Path.GetFileNameWithoutExtension(tableFile), dt);
        }
    }
}
