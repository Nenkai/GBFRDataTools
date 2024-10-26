using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using YamlDotNet.Core.Tokens;
using YamlDotNet.RepresentationModel;

using GBFRDataTools.Hashing;

using Syroot.BinaryData;

namespace GBFRDataTools.Files.UI.Types;

public class CyanStringHash : UIObjectBase
{
    public override UIFieldType Type => UIFieldType.CyanStringHash;

    /// <summary>
    /// String (if available), otheruse use <see cref="Hash"/>.
    /// </summary>
    public string String { get; set; }

    public uint Hash { get; set; }

    public CyanStringHash() { }

    public CyanStringHash(string str)
    {
        String = str;
        Hash = XXHash32Custom.Hash(str);
    }

    public CyanStringHash(uint hash)
    {
        Hash = hash;
    }

    public override void Write(BinaryStream bs)
    {
        bs.WriteUInt32(Hash);
    }

    public override YamlNode GetYamlNode()
    {
        if (String is null)
            return new YamlScalarNode($"{Hash:X8}");
        else
            return new YamlScalarNode(String);
    }
}
