using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using YamlDotNet.RepresentationModel;

namespace GBFRDataTools.Core.UI.Types;

public class UIVec4 : UIObjectBase
{
    public Vector4 Vector { get; set; }

    public override YamlNode GetYamlNode()
    {
        return new YamlScalarNode($"{Vector.X}, {Vector.Y}, {Vector.Z}, {Vector.W}");
    }
}
