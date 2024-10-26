using Syroot.BinaryData;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using YamlDotNet.RepresentationModel;

namespace GBFRDataTools.Files.UI.Types;

public class UIFloat : UIObjectBase
{
    public override UIFieldType Type => UIFieldType.F32;

    public float Value { get; set; }

    public UIFloat() { }

    public UIFloat(float value)
    {
        Value = value;
    }

    public override void Write(BinaryStream bs)
    {
        bs.WriteSingle(Value);
    }

    public override YamlNode GetYamlNode()
    {
        return new YamlScalarNode(Value.ToString());
    }
}
