using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.BehaviorTree;

public class RandomSelectorEmNode : CompositeNode
{
    [JsonPropertyName("param_")]
    public RandomSelectorEmNodeParam Param { get; set; }
}

public class RandomSelectorEmNodeParam : NodeParamBase
{
    [JsonPropertyName("emParams_")]
    public BindingList<EmRandomParam> EmParams { get; set; } = []; // std::vector<BT::RandomSelectorEmNodeParam::EmRandomParam>

    [JsonPropertyName("blackboardName_")]
    public string ReferenceTreeName { get; set; }

    [JsonPropertyName("assetPattern_")]
    public uint AssetPattern { get; set; }

    public class EmRandomParam // BT::RandomSelectorEmNodeParam::EmRandomParam
    {
        [JsonPropertyName("childNodeRatio_")]
        public BindingList<int> ChildNodeRatio { get; set; } = [];

        [JsonPropertyName("coolTime_")]
        public BindingList<float> CoolTime { get; set; } = [];

        [JsonPropertyName("randomLevel_")]
        public int RandomLevel { get; set; }

        [JsonPropertyName("isSameAction_")]
        public bool IsSameAction { get; set; }

        [JsonPropertyName("sameActionRatio_")]
        public int SameActionRatio { get; set; }

        [JsonPropertyName("isSameActionRatio_")]
        public bool IsSameActionRatio { get; set; }
    }
}