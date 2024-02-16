using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using YamlDotNet.RepresentationModel;

namespace GBFRDataTools.Core.UI.Types;

public abstract class UIObjectBase
{
    public string Name { get; set; }

    public abstract YamlNode GetYamlNode();
}
