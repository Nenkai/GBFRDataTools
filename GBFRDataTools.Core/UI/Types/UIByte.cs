using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

using YamlDotNet.RepresentationModel;

namespace GBFRDataTools.Core.UI.Types;

public class UI_S8 : UIObjectBase
{
    public sbyte Value { get; set; }

    public override YamlNode GetYamlNode()
    {
        return new YamlScalarNode(Value.ToString());
    }
}
