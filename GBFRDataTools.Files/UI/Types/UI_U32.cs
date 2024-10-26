using Syroot.BinaryData;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using YamlDotNet.RepresentationModel;

namespace GBFRDataTools.Files.UI.Types;

public class UI_U32 : UIObjectBase
{
    public override UIFieldType Type => UIFieldType.U32;

    public uint Value { get; set; }

    public UI_U32() { }

    public UI_U32(uint value)
    {
        Value = value;
    }

    public override void Write(BinaryStream bs)
    {
        bs.WriteUInt32(Value);
    }

    public override YamlNode GetYamlNode()
    {
        return new YamlScalarNode(Value.ToString());
    }
}
