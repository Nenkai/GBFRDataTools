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

public class UIVec2 : UIObjectBase
{
    public override UIFieldType Type => UIFieldType.CVec2;

    public Vector2 Vector { get; set; }

    public UIVec2() { }

    public UIVec2(Vector2 vector)
    {
        Vector = vector;
    }

    public override void Write(BinaryStream bs)
    {
        bs.WriteSingle(Vector.X);
        bs.WriteSingle(Vector.Y);
    }

    public override YamlNode GetYamlNode()
    {
        return new YamlScalarNode($"{Vector.X.ToString(CultureInfo.InvariantCulture)}, {Vector.Y.ToString(CultureInfo.InvariantCulture)}");
    }
}
