using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using YamlDotNet.Core.Tokens;
using YamlDotNet.RepresentationModel;

namespace GBFRDataTools.Files.UI.Types;

public class UIObjectArray : UIObjectBase
{
    public List<UIObjectBase> Array { get; set; }

    public override YamlNode GetYamlNode()
    {
        var seq = new YamlSequenceNode();
        foreach (var obj in Array)
        {
            var n = obj.GetYamlNode();
            seq.Add(n);
        }

        return seq;
    }
}
