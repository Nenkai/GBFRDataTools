using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions.Quest;

public class CheckTargetTask : QuestConditionComponent
{
    [JsonPropertyName("label_")]
    public string Label { get; set; }

    [JsonPropertyName("iVal_")]
    public uint IVal { get; set; }

    [JsonPropertyName("fVal_")]
    public float FVal { get; set; }

    [JsonPropertyName("operatorType_")]
    public byte OperatorType { get; set; }
}
