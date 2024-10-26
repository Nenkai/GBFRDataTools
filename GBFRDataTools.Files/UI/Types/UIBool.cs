using Syroot.BinaryData;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

using YamlDotNet.RepresentationModel;

namespace GBFRDataTools.Files.UI.Types;

public class UIBool : UIObjectBase
{
    public override UIFieldType Type => UIFieldType.Bool;

    public bool Value { get; set; }

    public UIBool() { }

    public UIBool(bool value)
    {
        Value = value;
    }

    public override void Write(BinaryStream bs)
    {
        bs.WriteBoolean(Value, BooleanCoding.Dword);
    }

    public override YamlNode GetYamlNode()
    {
        return new YamlScalarNode(Value.ToString());
    }
}
