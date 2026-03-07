using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.BehaviorTree;

public class ReferenceTreeNode : LeafNode
{
    [JsonPropertyName("param_")]
    public ReferenceTreeNodeParam Param { get; set; }
}

public class ReferenceTreeNodeParam : NodeParamBase
{
    [JsonPropertyName("referenceTreeFolderName_")]
    public string ReferenceTreeFolderName { get; set; } // sys::String

    [JsonPropertyName("referenceTreeName_")]
    public string ReferenceTreeName { get; set; } // sys::String

    [JsonPropertyName("assetPattern_")]
    public uint AssetPattern { get; set; }
}