using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using YamlDotNet.RepresentationModel;

namespace GBFRDataTools.Files.UI.Types;

public class UI_S32 : UIObjectBase
{
    public int Value { get; set; }

    public override YamlNode GetYamlNode()
    {
        return new YamlScalarNode(Value.ToString());
    }
}
