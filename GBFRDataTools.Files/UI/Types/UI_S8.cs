using Syroot.BinaryData;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

using YamlDotNet.RepresentationModel;

namespace GBFRDataTools.Files.UI.Types;

public class UI_S8 : UIObjectBase
{
    public override UIFieldType Type => UIFieldType.S8;

    public sbyte Value { get; set; }

    public UI_S8() { }

    public UI_S8(sbyte value)
    {
        Value = value;
    }

    public override void Write(BinaryStream bs)
    {
        bs.WriteInt32(Value);
    }

    public override YamlNode GetYamlNode()
    {
        return new YamlScalarNode(Value.ToString());
    }
}
