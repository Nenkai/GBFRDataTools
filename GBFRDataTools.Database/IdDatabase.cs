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

    public void AddIds(IEnumerable<string> ids)
    {
        ArgumentNullException.ThrowIfNull(ids, nameof(ids));

        foreach (var id in ids)
            _hashesToIds.TryAdd(XXHash32Custom.Hash(id), id);
    }

    public void AddId(string id)
    {
        ArgumentException.ThrowIfNullOrEmpty(id, nameof(id));

        _hashesToIds.TryAdd(XXHash32Custom.Hash(id), id);
    }
}
