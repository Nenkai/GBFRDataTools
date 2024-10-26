using Syroot.BinaryData;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using YamlDotNet.RepresentationModel;

namespace GBFRDataTools.Files.UI.Types;

public abstract class UIObjectBase
{
    public abstract UIFieldType Type { get; }
    public string Name { get; set; }

    public abstract YamlNode GetYamlNode();

    public abstract void Write(BinaryStream bs);
}
