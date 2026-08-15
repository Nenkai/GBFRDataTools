using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace GBFRDataTools.Database.Generator;

public class StaticTableMappingReader : TableMappingReader
{
    public List<string> Logs = [];

    protected override Stream? GetHeaderSource(string tableName)
        => Assembly.GetExecutingAssembly().GetManifestResourceStream($"GBFRDataTools.Database.Generator.{tableName}.headers");

    protected override void Log(string @string)
    {
        Logs.Add(@string);
    }

    public static IEnumerable<string> GetAllEmbeddedHeaders()
    {
        return Assembly.GetExecutingAssembly().GetManifestResourceNames()
            .Where(x => x.StartsWith("GBFRDataTools.Database.Generator."))
            .Select(x =>
            {
                var _x = x.Split('.');
                return _x[_x.Length - 2];
            });
    }
}
