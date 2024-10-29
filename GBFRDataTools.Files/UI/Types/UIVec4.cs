using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using YamlDotNet.RepresentationModel;
using Syroot.BinaryData;
using System.Globalization;

namespace GBFRDataTools.Files.UI.Types;

public class UIVec4 : UIObjectBase
{
    public override UIFieldType Type => UIFieldType.CVec4;

    public Vector4 Vector { get; set; }

    public UIVec4() { }

    public UIVec4(Vector4 vector)
    {
        Vector = vector;
    }

    public override void Write(BinaryStream bs)
    {
        bs.WriteSingle(Vector.X);
        bs.WriteSingle(Vector.Y);
        bs.WriteSingle(Vector.Z);
        bs.WriteSingle(Vector.W);
    }

    public override YamlNode GetYamlNode()
    {
        return new YamlScalarNode($"{Vector.X.ToString(CultureInfo.InvariantCulture)}, {Vector.Y.ToString(CultureInfo.InvariantCulture)}, {Vector.Z.ToString(CultureInfo.InvariantCulture)}, {Vector.W.ToString(CultureInfo.InvariantCulture)}");
    }
}
