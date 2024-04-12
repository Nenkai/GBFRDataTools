using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using YamlDotNet.RepresentationModel;

namespace GBFRDataTools.Files.UI.Types;

public class CyanStringHash : UIObjectBase
{
    public uint Value { get; set; }

    public override YamlNode GetYamlNode()
    {
        return new YamlScalarNode($"{Value:X8}");
    }
}
