﻿using Syroot.BinaryData;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using YamlDotNet.Core.Tokens;
using YamlDotNet.RepresentationModel;

namespace GBFRDataTools.Files.UI.Types;

public class UIIntArray : UIObjectBase
{
    public override UIFieldType Type => UIFieldType.S32;

    public List<int> Array { get; set; }

    public override YamlNode GetYamlNode()
    {
        var seq = new YamlSequenceNode();
        foreach (var obj in Array)
        {
            seq.Add(new YamlScalarNode(obj.ToString()));
        }

        return seq;
    }

    public override void Write(BinaryStream bs)
    {
        throw new NotImplementedException();
    }
}
