using Syroot.BinaryData;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using YamlDotNet.RepresentationModel;

namespace GBFRDataTools.Files.UI.Types;

public class UIObject : UIObjectBase
{
    public override UIFieldType Type => UIFieldType.Object;

    public Dictionary<string, UIObjectBase> Children { get; set; } = [];

    public UIObjectBase this[string str]
        => Children[str];
    

    public override YamlNode GetYamlNode()
    {
        YamlMappingNode childNodes = new YamlMappingNode();
        foreach (var child in Children.Values)
        {
            var n = child.GetYamlNode();
            childNodes.Add(child.Name, n);
        }

        return childNodes;
    }

    public override void Write(BinaryStream bs)
    {
        throw new NotImplementedException();
    }
}
