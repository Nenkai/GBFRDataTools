using Syroot.BinaryData;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using YamlDotNet.RepresentationModel;

namespace GBFRDataTools.Files.UI.Types;

public class UI_S32 : UIObjectBase
{
    public override UIFieldType Type => UIFieldType.S32;

    public int Value { get; set; }

    public UI_S32() { }

    public UI_S32(int value)
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
