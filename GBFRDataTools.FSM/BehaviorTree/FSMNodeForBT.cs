using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.BehaviorTree;

public class FSMNodeForBT : LeafNode
{
    [JsonPropertyName("param_")]
    public RandomSelectorEmNodeParam Param { get; set; }
}

public class FSMNodeForBTParam : NodeParamBase
{
    [JsonPropertyName("fsmFolderName_")]
    public string FsmFolderName { get; set; }

    [JsonPropertyName("fsmName_")]
    public string FsmName { get; set; }

    [JsonPropertyName("useBehaviorClassName_")]
    public bool UseBehaviorClassName { get; set; }

    [JsonPropertyName("objIdList_")]
    public BindingList<int> ObjIdList { get; set; }
}