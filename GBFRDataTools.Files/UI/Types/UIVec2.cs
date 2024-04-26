using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using YamlDotNet.RepresentationModel;

namespace GBFRDataTools.Files.UI.Types;

public class UIVec2 : UIObjectBase
{
    public Vector2 Vector { get; set; }

    public override YamlNode GetYamlNode()
    {
        return new YamlScalarNode($"{Vector.X}, {Vector.Y}");
    }
}
