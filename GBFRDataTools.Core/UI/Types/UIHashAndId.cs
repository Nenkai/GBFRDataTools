using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using YamlDotNet.RepresentationModel;

namespace GBFRDataTools.Core.UI.Types;

public class UIHashAndId : UIObjectBase
{
    public uint Hash { get; set; }
    public short Unk1 { get; set; }
    public short Unk2 { get; set; }

    public override YamlNode GetYamlNode()
    {
        return new YamlScalarNode($"{Hash:X8}, {Unk1}, {Unk2}");
    }
}
