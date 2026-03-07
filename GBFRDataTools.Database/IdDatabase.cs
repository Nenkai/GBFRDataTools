using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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
