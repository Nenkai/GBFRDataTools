using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using YamlDotNet.RepresentationModel;
using Syroot.BinaryData;
using YamlDotNet.Core.Tokens;

namespace GBFRDataTools.Files.UI.Types;

public class UIString : UIObjectBase
{
    public override UIFieldType Type => UIFieldType.String;

    public string Value { get; set; }

    public UIString() { }

    public UIString(string value)
    {
        Value = value;
    }

    public override void Write(BinaryStream bs)
    {
        int length = Encoding.UTF8.GetByteCount(Value);
        bs.WriteInt32(length);
        bs.WriteString(Value, StringCoding.ZeroTerminated);

        // Therefore, padding occurs after temination anyway
        bs.Align(0x04, grow: true);
    }

    public override YamlNode GetYamlNode()
    {
        return new YamlScalarNode(Value);
    }
}
