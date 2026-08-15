namespace GBFRDataTools.Database;

public class DynamicTableMappingReader : TableMappingReader
{
    private static Lazy<DynamicTableMappingReader> _instance = new();
    public static DynamicTableMappingReader Instance => _instance.Value;

    private static Dictionary<string, string> HeaderFiles { get; set; }

    static DynamicTableMappingReader()
    {
        string exePath = Utils.GetCurrentExecutingPath();
        string currentDir = Path.GetDirectoryName(exePath)!;

        HeaderFiles = Directory.EnumerateFiles(currentDir, "*.headers").ToDictionary(x => Path.GetFileNameWithoutExtension(x));
    }

    private DynamicTableMappingReader()
    {

    }

    protected override Stream? GetHeaderSource(string tableName)
    {
        if (HeaderFiles.TryGetValue(tableName, out string? path))
        {
            return new FileStream(path, FileMode.Open);
        }

        return null;
    }

    protected override void Log(string @string)
    {
        Console.WriteLine(@string);
    }

    public bool ContainsTable(string tableName)
        => HeaderFiles.ContainsKey(tableName);
}
