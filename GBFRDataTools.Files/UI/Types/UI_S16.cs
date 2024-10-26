using Syroot.BinaryData;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

using YamlDotNet.RepresentationModel;

namespace GBFRDataTools.Files.UI.Types;

public class UI_S16 : UIObjectBase
{
    public override UIFieldType Type => UIFieldType.S16;

    public short Value { get; set; }

    public UI_S16() { }

    public UI_S16(short value)
    {
        Value = value;
    }

    public override void Write(BinaryStream bs)
    {
        bs.WriteInt16(Value);
    }

    public override YamlNode GetYamlNode()
    {
        return new YamlScalarNode(Value.ToString());
    }
}
