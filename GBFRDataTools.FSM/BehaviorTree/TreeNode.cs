using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.BehaviorTree;

public class TreeNode
{
    [JsonPropertyName("guid_")]
    public uint Guid { get; set; }

    [JsonPropertyName("tailIndexOfChildNodeGuids_")]
    public int TailIndexOfChildNodeGuids { get; set; }

    [JsonPropertyName("tailIndexOfComponentGuids_")]
    public int TailIndexOfComponentGuids { get; set; }
}
