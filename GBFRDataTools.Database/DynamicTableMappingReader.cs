namespace GBFRDataTools.Database;

/// <summary>
/// Dynamic table mapping reader, for reading .headers files.
/// </summary>
public class DynamicTableMappingReader : TableMappingReader
{
    private static readonly Lazy<DynamicTableMappingReader> _instance = new();

    /// <summary>
    /// Instance.
    /// </summary>
    public static DynamicTableMappingReader Instance => _instance.Value;

    private static Dictionary<string, string> HeaderFiles { get; set; }

    static DynamicTableMappingReader()
    {
        string exePath = Utils.GetCurrentExecutingPath();
        string currentDir = Path.GetDirectoryName(exePath)!;

        HeaderFiles = Directory.EnumerateFiles(Path.Combine(currentDir, "Headers"), "*.headers").ToDictionary(x => Path.GetFileNameWithoutExtension(x));
    }

    public DynamicTableMappingReader()
    {

    }

    /// <inheritdoc/>
    protected override Stream? GetHeaderSource(string tableName)
    {
        if (HeaderFiles.TryGetValue(tableName, out string? path))
        {
            return new FileStream(path, FileMode.Open);
        }

        return null;
    }

    /// <inheritdoc/>
    protected override void Log(string @string)
    {
        Console.WriteLine(@string);
    }

    /// <summary>
    /// Returns whether a header file for the specified table name exists.
    /// </summary>
    /// <param name="tableName"></param>
    /// <returns></returns>
    public bool ContainsTable(string tableName)
        => HeaderFiles.ContainsKey(tableName);
}
