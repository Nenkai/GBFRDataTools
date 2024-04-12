using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using YamlDotNet.RepresentationModel;

namespace GBFRDataTools.Files.UI.Types;

public class UIObject : UIObjectBase
{
    public List<UIObjectBase> Children { get; set; } = [];

    public override YamlNode GetYamlNode()
    {
        YamlMappingNode childNodes = new YamlMappingNode();
        foreach (var child in Children)
        {
            var n = child.GetYamlNode();
            childNodes.Add(child.Name, n);
        }

        return childNodes;
    }
}
