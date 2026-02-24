using GBFRDataTools.Hashing;

using Syroot.BinaryData;

namespace GBFRDataTools.Files.UI.Types;

public class CyanStringHash
{
    /// <summary>
    /// String (if available), otheruse use <see cref="Hash"/>.
    /// </summary>
    public string String { get; set; }

    public uint Hash { get; set; }

    public CyanStringHash() 
    {
        String = string.Empty;
        Hash = XXHash32Custom.Hash(String);
    }

    public CyanStringHash(string str)
    {
        String = str;
        Hash = XXHash32Custom.Hash(str);
    }

    public CyanStringHash(uint hash)
    {
        Hash = hash;
    }

    public void Write(BinaryStream bs)
    {
        bs.WriteUInt32(Hash);
    }
}
