using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using GBFRDataTools.Database.Entities;
using GBFRDataTools.Hashing;

namespace GBFRDataTools.Database;

/// <summary>
/// Database of all ids for hashes present in a game database.
/// </summary>
public class IdDatabase
{
    private Dictionary<uint, string> _hashesToIds = new Dictionary<uint, string>();

    /// <summary>
    /// Hashes to ids.
    /// </summary>
    public IReadOnlyDictionary<uint, string> Hashes => _hashesToIds.AsReadOnly();

    /// <summary>
    /// Opens the database text file (normally ids.txt) at the specified path. <br/>
    /// Appends hashes that are in it if a previous database was already open.
    /// </summary>
    /// <param name="path"></param>
    public void Open(string path)
    {
        using var sr = new StreamReader(path);

        while (!sr.EndOfStream)
        {
            string? line = sr.ReadLine();
            if (string.IsNullOrWhiteSpace(line) || line.StartsWith("//"))
                continue;

            string[] spl = line.Split('|');
            if (spl.Length == 3)
            {
                //uint hash = uint.Parse(spl[0], System.Globalization.NumberStyles.HexNumber);
                _hashesToIds.TryAdd(XXHash32Custom.Hash(spl[2]), spl[2]);
            }
        }

#if DEBUG
        var r2ModsPath = Environment.GetEnvironmentVariable("RELOADEDIIMODS");
        if (!string.IsNullOrWhiteSpace(r2ModsPath))
        {
            string file = Path.Combine(r2ModsPath, "gbfrelink.utility.filenamelogger", "logs", "hashlist.txt");
            if (File.Exists(file))
            {
                using var sr2 = new StreamReader($"{r2ModsPath}/gbfrelink.utility.filenamelogger/logs/hashlist.txt");

                while (!sr2.EndOfStream)
                {
                    string? line = sr2.ReadLine();
                    if (string.IsNullOrWhiteSpace(line) || line.StartsWith("//"))
                        continue;

                    string[] spl = line.Split('|');
                    if (spl.Length == 2)
                    {
                        uint hash = uint.Parse(spl[0], System.Globalization.NumberStyles.HexNumber);
                        _hashesToIds.TryAdd(hash, spl[1]);
                    }
                }
            }
        }

        /*
        using var sr3 = new StreamReader(@$"<file>");
        while (!sr3.EndOfStream)
        {
            string? line = sr3.ReadLine();
            if (string.IsNullOrWhiteSpace(line) || line.StartsWith("//"))
                continue;

            _hashesToIds.TryAdd(XXHash32Custom.Hash(line), line);
        }
        */
#endif
    }

    /// <summary>
    /// Adds a list of strings (to be hashed) to the database
    /// </summary>
    /// <param name="ids"></param>
    public void AddIds(IEnumerable<string> ids)
    {
        ArgumentNullException.ThrowIfNull(ids, nameof(ids));

        foreach (var id in ids)
            _hashesToIds.TryAdd(XXHash32Custom.Hash(id), id);
    }

    /// <summary>
    /// Adds an id to be hashed to the database
    /// </summary>
    /// <param name="id"></param>
    public void AddId(string id)
    {
        ArgumentException.ThrowIfNullOrEmpty(id, nameof(id));

        _hashesToIds.TryAdd(XXHash32Custom.Hash(id), id);
    }

    /// <summary>
    /// Registers all ids from the current executing path (from Data/ids.txt) aswell as extra ids from the specified directory which should have ids.txt.
    /// </summary>
    /// <param name="dir"></param>
    /// <returns></returns>
    /// <exception cref="FileNotFoundException"></exception>
    public static IdDatabase GetFromDir(string? dir)
    {
        string exePath = Utils.GetCurrentExecutingPath();

        string currentDir = Path.GetDirectoryName(exePath)!;
        string path = Path.Combine(currentDir, "Data", "ids.txt");

        if (!File.Exists(path))
            throw new FileNotFoundException("ERROR: Data/ids.txt was missing.");

        var idDatabase = new IdDatabase();
        idDatabase.Open(path);

        if (!string.IsNullOrWhiteSpace(dir))
        {
            string idPath = Path.Combine(dir, "ids.txt");
            if (File.Exists(idPath))
                idDatabase.Open(idPath);
        }

        return idDatabase;
    }
}
