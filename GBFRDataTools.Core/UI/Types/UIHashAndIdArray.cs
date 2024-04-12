using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using YamlDotNet.RepresentationModel;

namespace GBFRDataTools.Files.UI.Types;

public class UIHashAndIdArray : UIObjectBase
{
    public List<UIHashAndId> Array { get; set; }

    public override YamlNode GetYamlNode()
    {
        var seq = new YamlSequenceNode();
        foreach (var obj in Array)
        {
            seq.Add(obj.GetYamlNode());
        }

        return seq;
    }
}
