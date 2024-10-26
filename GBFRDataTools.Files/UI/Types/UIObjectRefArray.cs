using Syroot.BinaryData;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using YamlDotNet.RepresentationModel;

namespace GBFRDataTools.Files.UI.Types;

public class UIObjectRefArray : UIObjectBase
{
    public override UIFieldType Type => UIFieldType.ObjectRefVector;

    public List<UIObjectRef> Array { get; set; }

    public override YamlNode GetYamlNode()
    {
        var seq = new YamlSequenceNode();
        foreach (var obj in Array)
        {
            seq.Add(obj.GetYamlNode());
        }

        return seq;
    }

    public override void Write(BinaryStream bs)
    {
        throw new NotImplementedException();
    }
}
