using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using YamlDotNet.RepresentationModel;
using Syroot.BinaryData;

namespace GBFRDataTools.Files.UI.Types;

public class UIVec3 : UIObjectBase
{
    public override UIFieldType Type => UIFieldType.CVec3;

    public Vector3 Vector { get; set; }

    public UIVec3() { }

    public UIVec3(Vector3 vector)
    {
        Vector = vector;
    }

    public override void Write(BinaryStream bs)
    {
        bs.WriteSingle(Vector.X);
        bs.WriteSingle(Vector.Y);
        bs.WriteSingle(Vector.Z);
    }

    public override YamlNode GetYamlNode()
    {
        return new YamlScalarNode($"{Vector.X}, {Vector.Y}, {Vector.Z}");
    }
}
