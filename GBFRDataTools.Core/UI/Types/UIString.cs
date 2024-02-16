using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using YamlDotNet.RepresentationModel;

namespace GBFRDataTools.Core.UI.Types;

public class UIString : UIObjectBase
{
    public string Str { get; set; }

    public override YamlNode GetYamlNode()
    {
        return new YamlScalarNode(Str);
    }
}
