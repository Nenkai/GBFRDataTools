using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy;

[GameSupport(GameVersion.EndlessRagnarok)]
public class EmLinkStateCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmLinkStateCondition);

    [JsonPropertyName("linkState_")]
    public int LinkState { get; set; } = 0;

    [JsonPropertyName("comparaType_")]
    public EmLinkStateConditionCompareType ComparaType { get; set; } = 0;
}

public enum EmLinkStateConditionCompareType
{
    Equals = 0,
    LessOrEqual = 1,
    GreaterEqualTo = 2,
}