using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy.SeofonTweyen;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8000SwordShineLevelCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8000SwordShineLevelCondition);

    [JsonPropertyName("swordShineLevel_")]
    public int SwordShineLevel { get; set; } = 0;

    [Description("Compare type for blackboard key: 0xC9A979A6")]
    [JsonPropertyName("comparaType_")]
    public Em8000SwordShineLevelConditionCompareType ComparaType { get; set; } = Em8000SwordShineLevelConditionCompareType.LessThan;
}

public enum Em8000SwordShineLevelConditionCompareType
{
    LessThan = 0,
    GreaterThan = 1,
    Equals = 2,
}