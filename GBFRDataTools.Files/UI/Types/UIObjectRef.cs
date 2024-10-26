using GBFRDataTools.Hashing;

using Syroot.BinaryData;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using YamlDotNet.Core.Tokens;
using YamlDotNet.RepresentationModel;

namespace GBFRDataTools.Files.UI.Types;

public class UIObjectRef : UIObjectBase
{
    public override UIFieldType Type => UIFieldType.ObjectRef;

    public string ComponentNameStr;

    public uint ComponentName { get; set; }
    public short Index { get; set; }
    public short ObjectRefId { get; set; }

    public UIObjectRef() { }

    public UIObjectRef(string componentName, short index, short objectRefId)
    {
        ComponentNameStr = componentName;
        ComponentName = XXHash32Custom.Hash(componentName);
        Index = index;
        ObjectRefId = objectRefId;
    }

    public UIObjectRef(uint componentNameHash, short index, short objectRefId)
    {
        ComponentName = componentNameHash;
        Index = index;
        ObjectRefId = objectRefId;
    }

    public override void Write(BinaryStream bs)
    {
        if (!string.IsNullOrEmpty(ComponentNameStr))
            bs.WriteUInt32(XXHash32Custom.Hash(ComponentNameStr));
        else
            bs.WriteUInt32(ComponentName);

        bs.WriteInt16(Index);
        bs.WriteInt16(ObjectRefId);
    }

    public override YamlNode GetYamlNode()
    {
        var yamlNode = new YamlMappingNode();

        if (ComponentNameStr is null)
            yamlNode.Add(nameof(ComponentName), new YamlScalarNode(ComponentName.ToString("X8")));
        else
            yamlNode.Add(nameof(ComponentName), new YamlScalarNode(ComponentNameStr));

        yamlNode.Add(nameof(Index), new YamlScalarNode(Index.ToString()));
        yamlNode.Add(nameof(ObjectRefId), new YamlScalarNode(ObjectRefId.ToString()));
        return yamlNode;

    }
}
